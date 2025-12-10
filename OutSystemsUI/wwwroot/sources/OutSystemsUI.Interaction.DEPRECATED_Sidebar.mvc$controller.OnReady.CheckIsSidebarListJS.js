export default function ($parameters, $actions, $roles, $public) {
var element = document.getElementById($parameters.WidgetId).closest('.list');

if(element){
    $parameters.IsList = true;
} else {
    $parameters.IsList = false;
}
};




