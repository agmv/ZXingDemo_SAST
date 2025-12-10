export default function ($parameters, $actions, $roles, $public) {
var elementId = document.getElementById($parameters.ElementId);
$parameters.ChoicesObj.destroy();

if(elementId) {
    elementId.options.length = 0;
}
};




