export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.DatePickerAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




