export default function ($parameters, $actions, $roles, $public) {
// Elements
var actionSheet = document.getElementById($parameters.WidgetId);
var cancelButton = document.getElementById($parameters.CancelButtonId);
var buttonWrapper = document.getElementById($parameters.Buttons);
var buttons = actionSheet.getElementsByTagName('BUTTON');
var firstButton = buttons[0];

var _focusableElems = 'a[href]:not([disabled]),[tabindex="0"], button:not([disabled]), textarea:not([disabled]), input[type="text"]:not([disabled]), input[type="radio"]:not([disabled]), input[type="checkbox"]:not([disabled]),input[type="submit"]:not([disabled]), select:not([disabled])';
var _focusableActionSheetElements = buttonWrapper.querySelectorAll(_focusableElems);
var _currentFocusedElementIndex = Array.from(_focusableActionSheetElements).findIndex(element => element.isEqualNode(document.activeElement));

// get event from eventListener
var e = $parameters.Event;

// Keycodes
var isTabPressed = (e.keyCode == "9");
var isShiftKey = e.shiftKey;
var isEsc = (e.keyCode == "27");
var isArrowDownPressed = e.key === "ArrowDown";
var isArrowUpPressed = e.key === "ArrowUp";


var setFocusTrap = function(){
    
    // Close on Esc
    if(isEsc) {
        $actions.OnCancelClick();
    }

    if(isTabPressed){
        // Focus trap to circle all buttons inside
        if(isShiftKey) {
            if(document.activeElement === firstButton) {
                cancelButton.focus();
                e.preventDefault();
            }
        } else if (document.activeElement === cancelButton){
            firstButton.focus();
            e.preventDefault();
        }
    }
    
    if(isArrowDownPressed || isArrowUpPressed){
        if (_focusableActionSheetElements.length === 0) {
        _currentFocusedElementIndex = undefined;
        } else if (isArrowDownPressed) {
            // If the _currentFocusedElementIndex is undefined or is the last one
            // Then move the focus to the first focusable element
            if (
                _currentFocusedElementIndex === undefined ||
                _currentFocusedElementIndex >= _focusableActionSheetElements.length - 1
            )
                _currentFocusedElementIndex = 0;
            // Otherwise, move the focus to the next focusable element
            else _currentFocusedElementIndex = _currentFocusedElementIndex + 1;
        }
        // When ArrowUp is pressed
        else if (isArrowUpPressed) {
            // If the _currentFocusedElementIndex is undefined or is the first one
            // Then move the focus to the last focusable element
            if (_currentFocusedElementIndex === undefined || _currentFocusedElementIndex === 0)
                _currentFocusedElementIndex = _focusableActionSheetElements.length - 1;
            // Otherwise, move the focus to the previous focusable element
            else _currentFocusedElementIndex = _currentFocusedElementIndex - 1;
        }

        // If the _currentFocusedElementIndex is undefined, focus on the balloon wrapper
        if (_currentFocusedElementIndex === undefined) {
            buttonWrapper.focus();
            // Otherwise, focus on the element corresponding ot the _currentFocusedElementIndex
        } else {
            _focusableActionSheetElements[_currentFocusedElementIndex].focus();
        }
    }
}();
};




