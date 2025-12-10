export default function ($parameters, $actions, $roles, $public) {
var element = document.getElementById($parameters.WidgetId);

if (element) {
    var isBlock = element.hasAttribute('data-block');
    
    if(isBlock) {
       element.children[0].setAttribute('role', $parameters.Role); 
    } else {
        element.setAttribute('role', $parameters.Role);
    }
}

};




