export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TimePickerAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




