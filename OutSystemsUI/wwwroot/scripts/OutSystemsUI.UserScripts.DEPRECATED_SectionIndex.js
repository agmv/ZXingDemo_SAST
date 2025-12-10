var SectionIndex = function() { 
    // Objects
    var anchorlinks;
    var anchorTarget;
    var contentPadding = 40;
    var currentClicked;
    var finalTopPosition;
    var header;
    var headerHeight;
    var headerSize;
    var isFixed;
    var isLayoutNative;
    var isSmooth;
    var isWebApp;
    var mainPadding;
    var offset;
    var screenContainer;
    var screenHeight;
    var sectionIndex;
    var titleContent;
    var topPosition;
    var unsupportedBrowsers;

    var start = function(options, update) {
        header = document.querySelector('.header');
        screenContainer = document.querySelector('.active-screen.screen-container');
        sectionIndex = document.querySelector('.section-index');
        anchorTarget = document.querySelectorAll('.active-screen .section');
        anchorlinks = sectionIndex.getElementsByTagName('a');
        screenHeight = screenContainer.getBoundingClientRect().height;
        
        if(header) {
            headerHeight = header.offsetHeight;    
        } else {
            headerHeight = 0;    
        }
        
        offset = headerHeight + contentPadding;
        isSmooth = options.isSmooth;
        isFixed = options.isFixed;
        topPosition = options.topPosition;
        isWebApp = options.isWebApp;
        isLayoutNative = options.isLayoutNative;
        unsupportedBrowsers = document.body.classList.contains('edge') || document.body.classList.contains('safari');
      
        if(isFixed && isWebApp || isLayoutNative) {
          
            if(isWebApp) {
                headerSize = parseInt(getComputedStyle(document.documentElement).getPropertyValue('--header-size'));
                mainPadding = parseInt(getComputedStyle(document.documentElement).getPropertyValue('--space-xl'));
                finalTopPosition = headerSize + mainPadding + topPosition;
                sectionIndex.style.setProperty('--top-position', finalTopPosition + 'px');
            } else {
                sectionIndex.style.setProperty('--top-position', topPosition + 'px');
            }
        }
        
        // Check for browsers that don't support ScrollIntoView to call Polyfill
        if(isSmooth && unsupportedBrowsers){
          callPolyfill();
        }
        
        // Create links for each section
        if(!update) {
          createElements();
        }
        
        // Set classes and event listeners
        prepareElements();
      
    };

    var createElements = function() {
        // Add link for each section
        for (var i=0; i < anchorTarget.length; i++){
    
            // Get content from section-title text
            elemText = anchorTarget[i].querySelector('.section-title').textContent;
          
            if(elemText === "") {
                elemText = "section-"+ [i];
            } else {
                // Remove white spaces
                removeSpace = elemText.split(" ");
                // Get first word (to prevent error when title is composed from one than one)
                titleContent = removeSpace.shift();
            }
          
            // Create ID for each section-anchor
            var anchorTargetId = "section-"+ titleContent +"-"+ [i];
            anchorTarget[i].id = anchorTargetId;
          
            // Create links inside section-index, for each section
            sectionIndex.innerHTML += "<a href='#" + anchorTargetId + "' class='section-index-item' role='menuitem' tabindex='0' name=section-" + titleContent + "-"+ [i] +">"+ elemText +"</a>";
    
            // Create name attribute for each section-anchor (to enable navigation through url)
            anchorTarget[i].setAttribute('name', "section-"+ titleContent +"-"+[i]);
          
        }
    };

    var prepareElements = function() {   
        anchorlinks[0].classList.add('is--active'); 
      
        // Adds event listeners
        sectionIndex.addEventListener('click', onSectionIndexClick);
        sectionIndex.addEventListener('keydown', onSectionIndexKeypress);
       
        onScrollEnd(onScroll);
        
        activeOnScroll(); 
    
    };
  
    var onScroll = function() {
        sectionIndex.classList.remove('is--scrolling');
        var lastItem = sectionIndex.querySelector('a:last-child');
        var firstItem = sectionIndex.querySelector('a:first-child');
    
        if(getDocHeight() === (getScrollPos()[1] + screenHeight)){ // if on bottom of page, set last link to active
            toggleActive(lastItem);
        } else if(getScrollPos()[1] === 0) { // if on top of page, set first link to active
            toggleActive(firstItem);
        }
    };
  
    var onScrollEnd = function (callback) {
        // Make sure a valid callback was provided
        if (!callback || typeof callback !== 'function') return;
    
        // Setup scrolling variable
        var isScrolling;
    
        // Listen for scroll events
        screenContainer.addEventListener('scroll', function(){
            // Clear our timeout throughout the scroll
            window.clearTimeout(isScrolling);
        
            // Set a timeout to run after scrolling ends
            isScrolling = setTimeout(function() {
        
                // Run the callback
                callback();
        
            }, 66);
        }, false);
    
    };

    var toggleActive = function(el) {
        // Get all anchors with is--active class and remove it
        var elems = sectionIndex.querySelectorAll(".is--active");
        for(var i= 0; i < elems.length; i++){
            elems[i].className = "section-index-item";
        }
    
        // Add is--active class to active anchor
        if(el) {
           el.className = "section-index-item is--active"; 
        }
        
    };
  
    var activeOnScroll = function() {
      
    var bottomRootMargin = screenHeight - offset;
      
    var options = {
        rootMargin: '-' + offset + 'px 0px ' + '-'+ bottomRootMargin +'px ' + '0px'
    };
      
    observerScroll = new IntersectionObserver(function(entries) {
        for(var i = 0; i < entries.length; i++) {
            var targetParentId = entries[i].target.id;
            var activeAnchor =  sectionIndex.querySelector('[name=' + targetParentId +']');
              
            if(entries[i].isIntersecting){
                if(!sectionIndex.classList.contains('is--scrolling')) {
                var active = sectionIndex.querySelector('.is--active');
                    if(active) {
                    active.classList.remove('is--active');
                }
                activeAnchor.classList.add('is--active');
            }
          } 
        }
    }, options);
    
        for(var i = 0; i < anchorTarget.length; i++){
            observerScroll.observe(anchorTarget[i]);
        }
    
    };
  
    var addSmoothScroll = function(el) {
        // Get name attribute from targeted element 
        var targetSection = document.querySelector("#" + el.getAttribute('name'));
        
        if(targetSection) {
        targetSection.style.transform = "translateY(" + (-offset) + "px)";  
        
        // If IsSmooth call function with smooth animation. Otherwise, call with instant navigation
        if(isSmooth) {
            targetSection.scrollIntoView({behavior: "smooth", block: "start", inline: "nearest"});
            // call oberver that waits for end of scroll, and then focus on the target element
            var intoViewObserver = new IntersectionObserver(function(entries) {
                for(var i = 0; i < entries.length; i++) {
                    if (entries[i].isIntersecting) {
                      setTimeout(function(){
                         targetSection.focus();
                      }, 1000);
                    }
                }
        
            });
            // start observing
            intoViewObserver.observe(targetSection);
              
        } else {
            targetSection.scrollIntoView({behavior: "auto", block: "start", inline: "nearest"});
            targetSection.focus();
        }
          
        targetSection.style.transform = 'translateY(0px)';
        }
      
    };
  
    var onSectionIndexClick = function(e) {
        currentClicked = e.target;
        e.preventDefault();
        e.stopPropagation();
      
        sectionIndex.classList.add('is--scrolling');
        
        if(currentClicked.classList.contains('section-index-item')) {
        
            var oldActiveItem = sectionIndex.querySelector(".is--active");
            
            if(oldActiveItem) {
             oldActiveItem.classList.remove("is--active"); 
            }
            
            currentClicked.classList.add("is--active");
            
            addSmoothScroll(currentClicked);
        }
    
    };
  
    var onSectionIndexKeypress = function(e) {
        if (e.keyCode == "32" || e.keyCode == "13") {
            onSectionIndexClick(e);
        }
    };
  
    // Get position of scroll cross-browser function
    var getScrollPos = function () {
        var scrOfX = 0, scrOfY = 0;
        if( typeof( screenContainer.pageYOffset ) == 'number' ) {
            //Netscape compliant
            scrOfY = screenContainer.pageYOffset;
            scrOfX = screenContainer.pageXOffset;
        } else if( screenContainer && ( screenContainer.scrollLeft || screenContainer.scrollTop ) ) {
            //DOM compliant
            scrOfY = screenContainer.scrollTop;
            scrOfX = screenContainer.scrollLeft;
        } else {
            scrOfY = screenContainer.scrollTop;
            scrOfX = screenContainer.scrollLeft;
        }
        return [ scrOfX, scrOfY ];
    };
  
    // cross-browser document height function
    var getDocHeight = function () {
        return Math.max(
            screenContainer.scrollHeight,
            screenContainer.offsetHeight,
            screenContainer.clientHeight
        );
    };
    
    var onDestroy = function() {
        sectionIndex.removeEventListener('click', onSectionIndexClick);
        sectionIndex.removeEventListener('keydown', onSectionIndexKeypress);
    
        sectionIndex.innerHTML = "";
    };

    return {
        init: function(options, update) {
            start(options, update);
        },
        
        destroy: function(){
            onDestroy();
        }
    };

};