export default function ($parameters, $actions, $roles, $public) {
var el = document.getElementById($parameters.WidgetId).parentNode.id;

$actions.MoveElement(el, ".active-screen .content-top");   

};




