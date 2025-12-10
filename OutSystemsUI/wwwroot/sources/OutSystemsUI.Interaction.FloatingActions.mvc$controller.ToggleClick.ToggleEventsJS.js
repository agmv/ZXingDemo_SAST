export default function ($parameters, $actions, $roles, $public) {
var floatingActions = document.getElementById($parameters.FloatingId);
var floatingActionsButton = floatingActions.querySelector('.floating-button');

if($parameters.IsHover) {
    floatingActionsButton.removeEventListener("focus", $actions.ToggleClick);
    
    //Handle event listeners
    if($parameters.IsOpen) {
        floatingActionsButton.removeEventListener("mouseenter", $actions.ToggleClick);
        floatingActions.addEventListener("mouseleave", $actions.ToggleClick);
    } else {
        floatingActionsButton.addEventListener("mouseenter", $actions.ToggleClick);
        floatingActions.removeEventListener("mouseleave", $actions.ToggleClick);
        floatingActionsButton.addEventListener("focus", $actions.ToggleClick);
    } 
}

};




