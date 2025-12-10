export default function ($parameters, $actions, $roles, $public) {
var field = document.getElementById($parameters.InputWidgetId);
var fieldType;

if(field && field.type !== undefined) {
    $parameters.FieldType = field.type;
}

};




