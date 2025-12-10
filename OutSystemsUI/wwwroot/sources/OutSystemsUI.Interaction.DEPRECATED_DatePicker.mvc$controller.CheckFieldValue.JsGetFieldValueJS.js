export default function ($parameters, $actions, $roles, $public) {
var field = document.getElementById($parameters.InputWidgetId);

if(field) {
    $parameters.FieldValue = field.value; 
}
};




