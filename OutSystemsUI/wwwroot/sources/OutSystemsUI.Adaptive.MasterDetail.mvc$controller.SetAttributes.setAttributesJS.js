export default function ($parameters, $actions, $roles, $public) {
// Elements
var rightElem = document.getElementById($parameters.RightPanelId);
var isOpenedOnPhone = $parameters.IsOpenedOnPhone;

if(rightElem) {
    if(isOpenedOnPhone) {
        rightElem.setAttribute('aria-hidden', false);
        rightElem.setAttribute('aria-expanded', true);
    } else {
        rightElem.setAttribute('aria-hidden', true);
        rightElem.setAttribute('aria-expanded', false);
    }
} else {
    setTimeout(function(){
        $actions.SetAttributes()
    }, 0)
}

};




