function newCarousel() {
    
    var options;
    var carousel;
    var carouselEl;
    var carouselContainer;
    var listEl;
    var listElNodes;
    var dotsContainer;
    var dotsElNodes;
    var leftNavigation;
    var rightNavigation;
    var timeoutVar;
    var lastMaxElements;
    var currentItems;
    var isRTL;
    var marginCenter;
    var padding;

    var initCarousel = function(opts) {
        options = opts;
        isRTL = options.isRTL;

        padding = options.padding;
        
        // Carousel selectors
        carousel = document.getElementById(options.widgetId);
        carouselContainer = carousel.querySelector(".carousel-container");
                
        // Use filters to keep the scope on this pattern only, allowing for nested carousels
        currentCarouselEl = Array.prototype.filter.call(carousel.querySelectorAll('.carousel-container-content'), function (el) {
            return el.closest('.carousel') === carousel;
        });
        currentDotsContainer = Array.prototype.filter.call(carousel.querySelectorAll('.carousel-dots-container'), function (el) {
            return el.closest('.carousel') === carousel;
        });

        carouselEl = currentCarouselEl[0];
        dotsContainer = currentDotsContainer[0];
        listEl = carousel.querySelector('.carousel-container-content > .list');
        leftNavigation = carousel.querySelector('.carousel-navigation-left');
        rightNavigation = carousel.querySelector('.carousel-navigation-right');
        
        options.currentPosition = options.initialPosition;

        if(isList()) {
            waitListRender();
        } else {
            listElNodes = carousel.querySelector('.carousel-container-content').childNodes;
            options.initAction;
            buildCarousel();
        }
    };

    // Verify if carousel is working with list
    var isList = function() {
        if(!listEl) {
            return false;
        }
        return true;
    };
    
    var waitListRender = function() {
        if(!listEl.classList.contains("list-loading") && carousel.querySelector('.list').childNodes.length !== 0) {
            clearTimeout(timeoutVar);
            listElNodes = carousel.querySelector('.list').childNodes;
            options.initAction;
            buildCarousel();
        } else {
            timeoutVar = setTimeout(waitListRender, 100);
        }
    };
    
    var onUpdateCarousel = function() {
        // Validate if RTL was changed
        checkRTL();
        
        setTimeout(function() { // Wait for list remove
            // Get new list of nodes
            if(isList()) {
                listElNodes = carousel.querySelector('.list').childNodes;
            } else {
                listElNodes = carousel.querySelector('.carousel-container-content').childNodes;
            }
            
            destroyDots();
            
            lastMaxElements = options.maxElements;
            options.maxElements = listElNodes.length;
            
            handleDragEvents();
            
            if(options.maxElements > lastMaxElements){
                
                options.goToAction(options.currentPosition);
                createDots(options.currentPosition);
                
            } else if(options.maxElements <= lastMaxElements){
                
                if(options.currentPosition === options.maxElements) {
                        options.goToAction(options.currentPosition - 1);
                        createDots(options.currentPosition);
                        
                } else {
                    if((options.maxElements - 1) >= 0) { // carousel has element?
                        options.goToAction(options.currentPosition);
                        createDots(options.currentPosition);
                    }
                }
            
            }

            // apply the necessary configurations to elements on refreshing
            transformElements();
            
        if(padding === 0) {
            updateCarouselWidth();            
        }
            
        },50);
    }
    
    var handleDragEvents = function() {
        var addEvents = listElNodes.length > 0 ? true : false;
        options.setEventsStatus(addEvents);
    };

    var updateCarouselWidth = function (){
        carouselContainer.style.setProperty('--carousel-width', carousel.offsetWidth + "px");
    };

    var onDestroy = function (){
        window.removeEventListener('resize', onUpdateCarousel);
    };
    
    var buildCarousel = function() {
        
        if(padding === 0) {
            updateCarouselWidth();            
        }
        
        if(listElNodes.length > 0 && listElNodes[0].offsetWidth > 0) {
            setVariables();
            createDots(options.initialPosition);
            handleDragEvents();
            
            elementActive = listElNodes[options.initialPosition];
            if(elementActive) {
                elementActive.classList.add('active');
            }

            // Add the aria-hidden to all elements inside
            for(i = 0; i < (listElNodes.length); i++) {
                listElNodes[i].setAttribute('aria-hidden', 'true');
            }

            // Add tabindex visible elements inside
            for(i = options.initialPosition; i < (options.initialPosition + currentItems); i++) {
                listElNodes[i].setAttribute('tabindex', '0');
                listElNodes[i].removeAttribute('aria-hidden');
            }
            
            // Invert and update values based on isRTL
            options.lastX = isRTL ? options.lastX * -1 : options.lastX;
            
            transformUi(options.lastX);
            transformElements();
            transformNavigation();
            
            lastMaxElements = options.maxElements;
            
            carousel.classList.remove('init');
        } else {
            setTimeout(function(){
                buildCarousel();
            }, 50);
        }
        
        window.addEventListener('resize', onUpdateCarousel);
    };
    
    // Refresh Carousel's items nodes and key variables
    var setVariables = function() {

        listElNodesWidth = carouselEl.offsetWidth;
        
        
        // Create CSS Variable to allow onMove animations
        if(carouselEl && listElNodes) {
            var fullWidth = carouselEl.offsetWidth * listElNodes.length;
            document.body.style.setProperty('--' + carousel.parentNode.id + '-width', fullWidth + "px");
        }
        
        // Prepare Carousel items, depending on device parameter
        switch(options.currentDevice) {
          case (options.currentDevice = "desktop"):
            options.nodeWidth = (parseFloat(listElNodesWidth) - (options.margin * (options.itemsDesktop - 1))) / options.itemsDesktop;
            currentItems = options.itemsDesktop;
            break;
          case (options.currentDevice = "tablet"):
            options.nodeWidth = (parseFloat(listElNodesWidth) - (options.margin * (options.itemsTablet - 1))) / options.itemsTablet;
            currentItems = options.itemsTablet;
            break;
          case (options.currentDevice = "phone"):
            options.nodeWidth = (parseFloat(listElNodesWidth) - (options.margin * (options.itemsPhone - 1))) / options.itemsPhone;
            currentItems = options.itemsPhone;
            break;
        }

        options.maxElements = listElNodes.length;
        options.lastX = ((options.nodeWidth * options.currentPosition) + (options.margin * options.currentPosition)) * -1;
    };
    
    // Add or Remove disabled class to navigation depeding on loop and current position
    var transformNavigation = function() {

        checkRTL();
        
        if(!options.loop) {
            
            // change selectors to apply the correct classes
            if(isRTL) {
                leftNavigation = carousel.querySelector('.carousel-navigation-right');
                rightNavigation = carousel.querySelector('.carousel-navigation-left');
            }
            
            if(options.currentPosition === 0) {
                leftNavigation.classList.add('disabled');
                leftNavigation.setAttribute('tabindex', '-1');
            } else {
                leftNavigation.classList.remove('disabled');
                leftNavigation.setAttribute('tabindex', '0');
            }
            if(options.currentPosition === Math.ceil(options.maxElements / currentItems) - 1) {
                rightNavigation.classList.add('disabled');
                rightNavigation.setAttribute('tabindex', '-1');
            } else {
                rightNavigation.classList.remove('disabled');
                rightNavigation.setAttribute('tabindex', '0');
            }
        }
    };
    
    // Moves carousel UI
    var transformUi = function(value) {
        
        // Add CSS class on body to allow utility class .hide-on-carousel-move to work
        if(!carousel.classList.contains('carousel-is-moving') && value !== 0) {
           carousel.classList.add('carousel-is-moving'); 
        }
        
        requestAnimationFrame(function(){
            carouselEl.style.webkitTransform = 'translateX(' + value + 'px) translateZ(0) translateY(0)';
            carouselEl.style.transform = 'translateX(' + value + 'px) translateZ(0) translateY(0)';
            carouselEl.classList.add('carousel--animatable');
        });
    };    
    
    // Transform carousel items
    var transformElements = function() {

        // Set value if Center parameter is enabled
        if(options.center) {
            marginCenter = ((options.nodeWidth + options.margin) * (Math.floor(currentItems - 1)) / 2);
        }
        
        for(i = 0; i < options.maxElements; i++) {

                
            if(currentItems > 1){
                listElNodes[i].style.width = options.nodeWidth + 'px';
            }

            // Invert applied margins based on IsRTL 
            listElNodes[i].style.margin = isRTL ? '0 0 0 0' + options.margin + 'px' : '0 0' + options.margin + 'px 0 0';
            scale(i, .9);
            
            // Invert applied margins based on IsRTL
            if(options.center) {
                if(i === 0) {
                    if(isRTL) {
                        listElNodes[i].style.margin = '0 0' + marginCenter + 'px 0 0' + options.margin + 'px';
                    } else {
                        listElNodes[i].style.margin = '0 0' + options.margin + 'px 0 0' + marginCenter + 'px';
                    }
                }
            }
        }
        
        scale(options.currentPosition, 1);
    };

    // Scale elements
    var scale = function(target, value) {
        if(options.scale) {
            if(listElNodes[target]) {
                listElNodes[target].style.transform = 'scale(' + value + ') translateZ(0)';
                listElNodes[target].style.webkitTransform = 'scale(' + value + ') translateZ(0)';
                if(!carousel.classList.contains("init")) {
                    listElNodes[target].classList.add('carousel--animatable');
                }
            }
        }
    };
    
    // Create dots for navigate between items
    var createDots = function(target) {
        
        // Create CSS Variable to allow css animations on Carousel drag
        document.body.style.setProperty('--' + carousel.parentNode.id + '-items', (options.maxElements / currentItems));
        
         for(i = 0; i < (options.maxElements / currentItems); i++) {
            var dotEl = document.createElement('div');
            dotEl.classList.add('carousel-dot');
            dotEl.setAttribute('tabindex', "0");
            dotEl.setAttribute('role', "button");
            dotEl.setAttribute('aria-label', "Go To Item " + (i + 1));
            dotsContainer.appendChild(dotEl);
        }

        dotsElNodes = Array.prototype.filter.call(carousel.querySelectorAll('.carousel-dot'), function (el) {
            return el.closest('.carousel') === carousel;
        });
        
        for(i = 0; i < dotsElNodes.length; i++){
            dotsElNodes[i].addEventListener('click', clickDot);
            dotsElNodes[i].addEventListener('keydown', keypressDot);
        }
        if(dotsElNodes.length > 0){
            dotsElNodes[target].classList.add('active');
        }
    };
    
    // Validate if RTL was changed and update value
    var checkRTL = function() {
        RTLChanged = document.querySelector('.is-rtl') ? true : false;
        // Validate if RTL has changed
        if(isRTL !== RTLChanged) {
            isRTL = RTLChanged;
        }
    };
    
    // Destroy dots
    var destroyDots = function() {
        dotsElNodes = Array.prototype.filter.call(carousel.querySelectorAll('.carousel-dot'), function (el) {
            return el.closest('.carousel') === carousel;
        });
            for(i = 0; i < (options.maxElements / currentItems); i++) {
                if(dotsElNodes[i]) {
                    dotsContainer.removeChild(dotsElNodes[i]);
                }
            }
    };
    
    // Add Goto action to clicked dot
    var clickDot = function(event) {
        for(i = 0; i < dotsElNodes.length; i++){
            if(dotsElNodes[i] === event.target) {
                options.goToAction(i);
            }
        }
    };
    
        // Add Goto action to clicked dot
    var keypressDot = function(event) {
        for(i = 0; i < dotsElNodes.length; i++){
            //If enter or space 
            if (event.keyCode == "32" || event.keyCode == "13") {
                if(dotsElNodes[i] === event.target) {
                    options.goToAction(i);
                                    
                    event.preventDefault();
                    event.stopPropagation();
                }
            }
        }
    };
    
    // Scale Calculation
    var ScaleCalc = function(scale) {
        if (scale < 0) {
            scale = (scale / 1000) * -1;
        } else {
            scale = scale / 1000;
        }
        if(scale > .09) {
            return .09;
        }
        return scale;
    };

    return {
        init: function(opts) {
            initCarousel(opts);
        },
        
        // Destroy dots and recreate them for each element on list (usually used after list remove)
        updateCarousel: function() {
            onUpdateCarousel();
        },
    
        goTo: function(target) {
            checkRTL();
            setVariables();
            
            if(listElNodes[options.currentPosition]) {
                listElNodes[options.currentPosition].classList.remove('active');
            }
            if(dotsElNodes[options.currentPosition]) {
                dotsElNodes[options.currentPosition].classList.remove('active');
            }
            
            var lastItem = target === (dotsElNodes.length - 1);
            var difference = listElNodes.length - ((dotsElNodes.length - 1) * currentItems);
            
            if(lastItem && currentItems > 1 && difference < currentItems) {
                // When there's space left on last item
                value = (((options.nodeWidth + options.margin) * (target * currentItems)) - ((options.nodeWidth + options.margin) * (currentItems - difference))) * -1;
            } else if(currentItems > 1){
                value = ((options.nodeWidth + options.margin) * (target * currentItems)) * -1;
            } else {
                value = ((options.nodeWidth + options.margin) * target) * -1;
            }                                                    
                                                                                            
            
            scale(options.currentPosition, .9);
            scale(target, 1);
            options.currentPosition = target;
            
            
            if(options.currentPosition === (options.maxElements - 1)) {
                carousel.setAttribute('aria-label', 'Item ' + (options.currentPosition + 1) + ' of ' + options.maxElements + ". Last Item.");
                rightNavigation.setAttribute("aria-hidden", "true");
            } else if(options.currentPosition === (options.maxElements - options.maxElements)) {
                carousel.setAttribute('aria-label', 'Item ' + (options.currentPosition + 1) + ' of ' + options.maxElements + ". First Item.");
                leftNavigation.setAttribute("aria-hidden", "true");
            } else {
                carousel.setAttribute('aria-label', 'Item ' + (options.currentPosition + 1) + ' of ' + options.maxElements);
            }
            
            // Invert and update values based on isRTL
            value = isRTL ? value * -1 : value;
            
            transformUi(value);
            // Create CSS Variable to allow css animations on carousel drag
            document.body.style.setProperty('--' + carousel.parentNode.id + '-position', value + 'px');
            
            transformNavigation();
            
            options.lastX = value;
            if(listElNodes[target]) {
                listElNodes[target].classList.add('active');
            }
            if(dotsElNodes[target]) {
                dotsElNodes[target].classList.add('active');
            }
            
            if(carousel.classList.contains('carousel-is-moving')) {
                carousel.classList.remove('carousel-is-moving'); 
            }

            // Apply A11Y to visible elements only if the currentItems is higher then 0
            if (currentItems > 0) {
                target = target * currentItems;

                for(i = 0; i < (listElNodes.length); i++) {
                    if(listElNodes[i].tabIndex === 0){
                        listElNodes[i].setAttribute('aria-hidden', 'true');
                        listElNodes[i].removeAttribute('tabindex');
                    }
                }

                // Async the the update of a11y on each visible element
                setTimeout(function(){
                    // Define the number of elements to updated the A11Y
                    listOfElements = target + currentItems;

                    // Validate if elements exists and update the number of elements to be updated
                    if(listOfElements > lastMaxElements){
                        target = target - (listOfElements - lastMaxElements);
                        listOfElements = lastMaxElements;
                    }

                    for(i = target; i < (listOfElements); i++) {
                        listElNodes[i].setAttribute('tabindex', '0');
                        listElNodes[i].removeAttribute('aria-hidden');
                    }
                }, 0);

            } else {
                for(i = 0; i < (listElNodes.length); i++) {
                    if(listElNodes[i].classList.contains('active')) {
                        listElNodes[i].setAttribute('tabindex', '0');
                    } else {
                        listElNodes[i].setAttribute('aria-hidden', 'true');
                    }
                }
            }
        },
        
        previous: function() {
            if(options.currentPosition > 0){
                options.goToAction(options.currentPosition - 1);
            } else {
                if(options.loop){
                    options.goToAction((options.maxElements / currentItems) - 1);
                } else {
                    this.backToMiddle();
                }
            }

        },
        
        next: function() {
            if(options.currentPosition < (options.maxElements / currentItems) - 1){
                options.goToAction(options.currentPosition + 1);
            } else {
                if(options.loop){
                    options.goToAction(0);
                } else {
                    this.backToMiddle();
                }
            }
        },
        
        // Return number of items inside carousel to pattern
        getMaxElements: function() {
            return options.maxElements;
        },
        
        // Return number of items inside carousel to pattern
        getNodeWidth: function() {
            return options.nodeWidth;
        },
        
        gestureMove: function(offsetX) {
            value = options.lastX + offsetX;
            
            transformUi(value);
            
            // Scale transform while gestureMove using offset as base
            scaleNext = .9 + ScaleCalc(isRTL ? offsetX * -1 : offsetX) + .01;
            scaleCurrent = 1 - ScaleCalc(isRTL ? offsetX * -1 : offsetX) - .01;
    
            if(offsetX < 0) {
                if(options.currentPosition < (options.maxElements - 1)) {
                    scale(isRTL ? options.currentPosition - 1 : options.currentPosition + 1, scaleNext);
                    scale(options.currentPosition, scaleCurrent);
                } else {
                    scale(options.maxElements - 1, scaleCurrent);
                    scale(0, 1);
                }
            } else if(offsetX > 0) {
                if(options.currentPosition > 0) {
                    scale(isRTL ? options.currentPosition + 1 : options.currentPosition - 1,scaleNext);
                    scale(options.currentPosition,scaleCurrent);
                } else {
                    scale(0, scaleCurrent);
                    scale(options.currentPosition + 1, scaleNext);
                }
            }
        },
        
        addNoTransitionClasses: function() {
            carouselEl.classList.add('no-transition');
            
            if(listElNodes[options.currentPosition - 1]) {
                listElNodes[options.currentPosition - 1].classList.add('no-transition');
            }
            
            if(listElNodes[options.currentPosition]) {
                listElNodes[options.currentPosition].classList.add('no-transition');
            }
            
            if(listElNodes[options.currentPosition + 1]) {
                listElNodes[options.currentPosition + 1].classList.add('no-transition');
            }
            
        },
        
        removeNoTransitionClasses: function() {
            carouselEl.classList.remove('no-transition');
                        
            setTimeout(function(){
                if(carousel.classList.contains('carousel-is-moving')) {
                    carousel.classList.remove('carousel-is-moving'); 
                }  
            }, 0);                               

            
            if(listElNodes[options.currentPosition - 1]) {
                listElNodes[options.currentPosition - 1].classList.remove('no-transition');
            }
            
            if(listElNodes[options.currentPosition]) {
                listElNodes[options.currentPosition].classList.remove('no-transition');
            }
            
            if(listElNodes[options.currentPosition + 1]) {
                listElNodes[options.currentPosition + 1].classList.remove('no-transition');
            }
            
        },
        
        onOrientationChange: function() {
            timeoutVar = setTimeout(function() {
                setVariables();
                transformElements();
                
                // Invert and update values based on isRTL
                options.lastX = isRTL ? options.lastX * -1 : options.lastX;
                
                transformUi(options.lastX);
                window.dispatchEvent(new Event('resize')); // force charts redraw
                clearTimeout(timeoutVar);
            }, 300);
        },
        
        backToMiddle: function() {
            transformUi(options.lastX);
            scale(options.currentPosition, 1);
            scale(options.currentPosition + 1, .9);
            scale(options.currentPosition - 1, .9);
        },

        destroy: function(){
            onDestroy();
        }
    };
}