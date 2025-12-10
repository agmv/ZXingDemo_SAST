export default function ($parameters, $actions, $roles, $public) {
var actionSheet = document.getElementById($parameters.WidgetId).querySelector('.action-sheet');

function OnTransitionEnd() {
    $parameters.ActiveDOMElem.focus(); 
    actionSheet.removeEventListener("transitionend", OnTransitionEnd, false);
}

if($parameters.ActiveDOMElem) {
    actionSheet.addEventListener("transitionend", OnTransitionEnd, false);
}
};




