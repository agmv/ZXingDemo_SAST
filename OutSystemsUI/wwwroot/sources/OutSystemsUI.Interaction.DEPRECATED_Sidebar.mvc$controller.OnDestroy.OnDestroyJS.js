export default function ($parameters, $actions, $roles, $public) {
var elem = document.getElementById($parameters.WidgetId);

if(elem && elem.parentElement) {
    elem.parentElement.remove();
}
};




