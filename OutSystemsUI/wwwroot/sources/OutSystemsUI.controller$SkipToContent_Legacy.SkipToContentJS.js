export default function ($parameters, $actions, $roles, $public) {
var target = document.getElementById($parameters.TargetId);

if(target) {
    var isFocusable = target.getAttribute('tabindex');
    
    if(isFocusable === null) {
        target.setAttribute('tabindex', '0');
        target.focus();
        target.removeAttribute('tabindex');    
    } else {
        target.focus();
    }
}
};




