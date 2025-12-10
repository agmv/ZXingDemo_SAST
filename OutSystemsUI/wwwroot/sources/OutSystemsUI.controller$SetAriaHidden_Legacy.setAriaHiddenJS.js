export default function ($parameters, $actions, $roles, $public) {
var elem = document.getElementById($parameters.WidgetId);

if(elem) {
    elem.setAttribute('aria-hidden', $parameters.IsHidden);   
}

};




