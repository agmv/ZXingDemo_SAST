// Web Pull to Refresh based on the original repo
// https://github.com/apeatling/web-pull-to-refresh
// License: MIT

var WebPullToRefresh = (function () {
    'use strict';
    
    var prevContent; // exists to destroy the event listener of the previous page 
                     // and not the page that you just travelled to

    /**
     * Hold all of the default parameters for the module
     * @type {object}
     */    
    var defaults = {
        // ID of the element holding pannable content area
        contentEl: 'content', 

        // ID of the element holding pull to refresh loading area
        ptrEl: 'ptr', 

        // ID of the element holding pull to refresh a11y container info
        ptrElA11y: 'ptrA11y', 
        
        scrollEl: null,

        // Number of pixels of panning until refresh 
        distanceToRefresh: 70, 

        // Pointer to function that does the loading and returns a promise
        loadingFunction: false,

        // Dragging resistance level
        resistance: 2.5,

        // Callback method that will be used to update status at IDE
        updateStatusCallback: () => null
    };
 
    /**
     * Hold all of the merged parameter and default module options
     * @type {object}
     */
    var options = {};

    /**
     * Pan event parameters
     * @type {object}
     */
    var pan = {
        enabled: false,
        distance: 0,
        startX: 0,
        startY: 0,
        startTime: null
    };
    
    /**
     * Easy shortener for handling adding and removing body classes
     */
    var bodyClass = document.body.classList;
    
    /**
     * Initialize pull to refresh and bind pan events
     * 
     * @param {object=} params - Setup parameters for pull to refresh
     */
    var init = function(params) {
        params = params || {};
        var elementToScroll = params.scrollEl || defaults.scrollEl;
        
        options = {
            contentEl: params.contentEl || document.getElementById(defaults.contentEl),
            ptrEl: params.ptrEl || document.getElementById(defaults.ptrEl),
            ptrElA11y: params.ptrElA11y || document.getElementById(defaults.ptrElA11y),
            scrollEl: elementToScroll,
            distanceToRefresh: params.distanceToRefresh || defaults.distanceToRefresh,
            loadingFunction: params.loadingFunction || defaults.loadingFunction,
            resistance: params.resistance || defaults.resistance,
            updateStatusCallback: params.updateStatusCallback || defaults.updateStatusCallback,
        };

        if (!options.contentEl || !options.ptrEl) {
            return false;
        }
        
        options.contentEl.addEventListener('touchstart', _touchStart);
        options.contentEl.addEventListener('touchmove', _touchMove);
        options.contentEl.addEventListener('touchend', _touchEnd);
    };

    /** Calculate touch start variables **/
    var _touchStart = function(e) {
        var touchobj = e.changedTouches[0];
        pan.distance = 0;
        pan.startX = touchobj.pageX;
        pan.startY = touchobj.pageY;
        pan.startTime = new Date().getTime(); // record time when finger first makes contact with surface
        
        prevContent = options.contentEl;
        _panStart(e);
    };
    
    /**
     * Determine whether pan events should apply based on scroll position on panstart
     * 
     * @param {object} e - Event object
     */
    var _panStart = function(e) {
        var checkStart = 0;
        if (options.scrollEl) {
            /* Added the scrollEl because the original didn't support containers with overflow */
            checkStart = options.scrollEl.scrollTop;
        } else {
            checkStart = document.body.scrollTop;
        }

        if (checkStart === 0) {
            pan.enabled = true;
        }
    };
    
    /** Calculate touch movement variables **/
    var _touchMove = function(e) {

        // Early return conditions - prevent pull-to-refresh when:
        // 1. Master-Detail is opened on phone
        // 2. Targeting scrollable content inside Master-Detail that's not at top
        // 3. BottomSheet is opened 
        const closestSelect = e.target.closest('.split-left, .split-right');
        const masterDetailOpened = document.querySelector('.phone .split-right.open');
        const bottomSheetOpened = document.querySelector('.osui-bottom-sheet--is-active');
        if (masterDetailOpened || 
            (closestSelect && closestSelect.scrollTop !== 0) || 
            bottomSheetOpened) {
            return;
        }

        // Get touch coordinates and calculate distances
        const touchobj = e.changedTouches[0];
        const distX = touchobj.pageX - pan.startX;
        const distY = touchobj.pageY - pan.startY;
        
        pan.distance = distY / options.resistance;
        
        // Prioritize horizontal scrolling - ignore vertical when horizontal movement is dominant
        if (Math.abs(distX) > Math.abs(distY)) {
            return true;
        }

        // For native layout, only proceed if screen container is at the top
        const isNativeLayout = document.querySelector('.layout-native');
        if (isNativeLayout) {
            const screenContainer = document.querySelector('.screen-container');
            if (!screenContainer || screenContainer.scrollTop !== 0) {
                return;
            }
        }

        // Execute pan direction based on vertical movement
        if (distY > 0) {
            _panDown(e);
        } else {
            _panUp(e);
        }
    };

    /**
     * Handle element on screen movement when the pandown events are firing
     * 
     * @param {object} e - Event object
     */
    var _panDown = function(e) {
        if (!pan.enabled) {
            return;
        }
        
        // Prevent scrolling while panning and the error when the event is cancelable
        // The error occurs because scrolling is in progress and cannot be interrupted
        if (e.cancelable) {
            e.preventDefault();
        }
        
        const isNativeLayout = document.querySelector('.layout-native');
        if (isNativeLayout) {
            if (document.documentElement.scrollTop === 0) {
                _setContentPan();
                _setBodyClass();
            }
        } else {
            _setContentPan();
            _setBodyClass();
        }
        
    };

    /**
     * Handle element on screen movement when the pan up events are firing
     * 
     * @param {object} e - Event object
     */
    var _panUp = function(e) {
        if (!pan.enabled || pan.distance === 0) {
            return;
        }

        pan.distance = 0;
    };
    
    var _touchEnd = function(e) {
        var touchobj = e.changedTouches[0];
        var distY = touchobj.pageY - pan.startY; // get total dist traveled by finger while in contact with surface
        pan.distance = distY / options.resistance;
        var elapsedTime = new Date().getTime() - pan.startTime; // get time elapsed
        
        _panEnd(e);
    };

    /**
     * Set the CSS transform on the content element to move it on the screen
     */
    var _setContentPan = function() {
        // Use transforms to smoothly animate elements on desktop and mobile devices
        options.contentEl.style.transform = options.contentEl.style.webkitTransform = 'translate3d( 0, ' + pan.distance + 'px, 0 )';

    };

    /**
     * Set/remove the loading body class to show or hide the loading indicator after pull down
     */
    var _setBodyClass = function() {
        if (pan.distance > options.distanceToRefresh) {
            bodyClass.add('ptr-refresh');
        } else {
            bodyClass.remove('ptr-refresh');
        }        
    };

    /**
     * Determine how to animate and position elements when the panend event fires
     * 
     * @param {object} e - Event object
     */
    var _panEnd = function(e) {
        if (!pan.enabled) {
            return;
        }

        const mainContent = document.querySelector('.main-content');
        const strStyle = mainContent ? mainContent.getAttribute('style') : null;

        if (document.body.classList.contains('ptr-refresh')) {
            _doLoading();
        } else if (strStyle && strStyle.indexOf('transform') === 0) {
            _doReset();
        }
        
        options.contentEl.classList.remove("no-transition");
        options.contentEl.style.transform = options.contentEl.style.webkitTransform = '';

        pan.distance = 0;
        pan.enabled = false;
    };

    /**
     * Position content and refresh elements to show that loading is taking place
     */
    var _doLoading = function() {
        options.ptrElA11y.setAttribute("aria-hidden", "false");
        _callUpdateStatusCallback(true);
        
        bodyClass.add('ptr-loading');

        // If no valid loading function exists, just reset elements
        if (!options.loadingFunction) {
            return _doReset();
        }

        // The loading function should return a promise
        var loadingPromise = options.loadingFunction();

        // For UX continuity, make sure we show loading for at least one second before resetting
        setTimeout(function() {
            // Once actual loading is complete, reset pull to refresh
            loadingPromise.then(_doReset);
        }, 1000);
    };

    /**
     * Reset all elements to their starting positions before any paning took place
     */
    var _doReset = function() {
        options.contentEl.classList.remove("no-transition");

        bodyClass.remove('ptr-loading');
        bodyClass.remove('ptr-refresh');
        bodyClass.add('ptr-reset');

        _callUpdateStatusCallback(false);

        var bodyClassRemove = function() {
            bodyClass.remove('ptr-reset');
            document.body.removeEventListener('transitionend', bodyClassRemove, false);
            
            options.ptrElA11y.setAttribute("aria-hidden", "true");
        };

        document.body.addEventListener('transitionend', bodyClassRemove, false);
    };

    /**
     * Method that will trigger the callback in order to manage content info based on refresh status
     */
    var _callUpdateStatusCallback = function(isRefreshing) {
        // If CallBack has been defined!
        if (options.updateStatusCallback && options.updateStatusCallback !== null) {
            // trigger the callback function => client action
            options.updateStatusCallback(isRefreshing);
        }
    };
    
    var destroy = function() {
        if (prevContent) {
            prevContent.removeEventListener('touchstart', _touchStart);
            prevContent.removeEventListener('touchmove', _touchMove);
            prevContent.removeEventListener('touchend', _touchEnd);
        }
    };

    return {
        init: init,
        destroy: destroy
    };

})();