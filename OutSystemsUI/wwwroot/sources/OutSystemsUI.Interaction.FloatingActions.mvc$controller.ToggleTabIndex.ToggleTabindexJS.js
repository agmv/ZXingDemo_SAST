export default function ($parameters, $actions, $roles, $public) {
var floatingActions = document.getElementById($parameters.FloatingId);
var floatingActionsButton = floatingActions.querySelector('.floating-button');
var floatingActionsItems = floatingActions.querySelector('.floating-items');
var firstItem;
var focusableElems = 'a[href]:not([disabled]),[tabindex="0"], button:not([disabled]), textarea:not([disabled]), input[type="text"]:not([disabled]), input[type="radio"]:not([disabled]), input[type="checkbox"]:not([disabled]),input[type="submit"]:not([disabled]), select:not([disabled])';

// Accessibility SetTabIndex values
var setTabIndex = function (value) {
    var tabIndexItems = floatingActionsItems.querySelectorAll(focusableElems);

    tabIndexItems.forEach(function(item) {
        item.setAttribute('tabindex', value);
    });
};

// Toggle Attributes and focus
if($parameters.IsOpen) {
    setTabIndex("0");
    firstItem = floatingActionsItems.querySelector(".floating-actions-item");
    
    if(firstItem) {
        firstItem.focus();
    }
} else {
    if($parameters.IsOnReady === false) {
        floatingActionsButton.focus();
    }

    setTabIndex("-1");
}



};




