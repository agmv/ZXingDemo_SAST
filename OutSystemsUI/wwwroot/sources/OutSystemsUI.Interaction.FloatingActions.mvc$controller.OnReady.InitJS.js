export default function ($parameters, $actions, $roles, $public) {
var toggleId;
var indexArray = [];
var insideBottomBar;
var bottomBar = document.querySelector(".active-screen .bottom-bar");
var floatingActions = document.getElementById($parameters.WidgetId);
var floatingActionsButton = floatingActions.querySelector('.floating-button');
var floatingActionsItemsWrapper = floatingActions.querySelector('.floating-items');
var floatingActionsItems = floatingActionsItemsWrapper.querySelectorAll('.floating-actions-item');
var firstButton = floatingActionsItems[0];
var lastButton = floatingActionsItems[floatingActionsItems.length - 1];

// Set the HTML Object of FloatingActions
$parameters.DOMElem = document.getElementById($parameters.WidgetId);

var setFocusTrap = function(e) {
    if(floatingActionsItems.length > 0) {
        var isShiftKey = e.shiftKey;
        
        // Focus trap to circle all buttons inside
        if(isShiftKey) {
            if(document.activeElement === firstButton) {
                lastButton.focus();
                e.preventDefault();
            }
        } else if (document.activeElement === lastButton){
            firstButton.focus();
            e.preventDefault();
        }
    }
};

// Check if there are FloatingActionsItemsWrapper
if(floatingActionsItems.length > 0) {

    // Push every floating-item index into a empty array
    for (var i = 0; i < floatingActionsItems.length; i++) { 
        indexArray.push(i);
    }
    
    // reverse order of array for css animation
    indexArray.reverse();
    
    // set CSS variable instead of inline styles for sequential animations
    for (var i = 0; i < floatingActionsItems.length; i++) { 
        floatingActionsItems[i].style.setProperty('--delay', indexArray[i] + 1);
    }
    
}

// Set keyboard interaction - Accessibility
var onButtonKeypress = function(e) {
    
    //If esc, Close Items
    if (e.keyCode == "27" && floatingActions.classList.contains('is--open')) {
        $actions.ToggleClick();
    }
    
    //If enter or space toggle Items
    if (e.keyCode == "32" || e.keyCode == "13") {
        $actions.ToggleClick();
    }
    
    setFocusTrap(e);

};

if($parameters.IsHover) {
    
    if($parameters.IsExpanded) {
        floatingActions.addEventListener("mouseleave", $actions.ToggleClick);
    } else {
        floatingActionsButton.addEventListener("mouseenter", $actions.ToggleClick);
    }

    floatingActionsButton.addEventListener("focus", $actions.ToggleClick);
    
} else {
    floatingActionsButton.addEventListener("click", $actions.ToggleClick);
    floatingActionsButton.addEventListener("keydown", onButtonKeypress);
}

// Exception for clicking Esc on items wrapper 
floatingActionsItemsWrapper.addEventListener("keydown", function(e){
    if (e.keyCode == "27") {
        if($parameters.IsHover) {
           floatingActionsButton.removeEventListener("focus", $actions.ToggleClick); 
        }        
        $actions.ToggleClick();

        if($parameters.IsHover) {
            floatingActionsButton.addEventListener("focus", $actions.ToggleClick);
        }
    }

    //If Up or Down Arrows
    if(e.keyCode == "38" || e.keyCode == "40") {
        const currTargetIndex = Array.from(floatingActionsItems).indexOf(e.target);

        // Up
        if(e.keyCode == "38") {
            if(currTargetIndex === 0) {
                $actions.ToggleClick();
            } else {
                Array.from(floatingActionsItems)[currTargetIndex-1].focus();
            }
        }

        // Down
        if(e.keyCode == "40") {
            if(currTargetIndex === floatingActionsItems.length-1) {
                $actions.ToggleClick();
            } else {
                Array.from(floatingActionsItems)[currTargetIndex+1].focus();
            }
        }
    } else {
         setFocusTrap(e);   
    }
});


// Inside Bottom Bar and IOS fix
if(bottomBar && floatingActions) {
    insideBottomBar = bottomBar.contains(floatingActions);
}

if(!insideBottomBar && floatingActions) {
    
    var layout = document.querySelector('.layout');

    if(layout) {
        var nativeLayout = layout.classList.contains('layout-native');
        
        if(nativeLayout) { // new native layouts
            $actions.MoveElement($parameters.WidgetId, ".active-screen .main");
        } else {// Old native layouts
            $actions.MoveElement($parameters.WidgetId, ".active-screen .screen"); 
        }
    }

    if(bottomBar) {
        $parameters.IsInsideBottomBar = true;
    }
}

};




