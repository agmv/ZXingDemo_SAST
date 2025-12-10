export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.MonthPickerAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    JSON.parse($parameters.PropertyValue)
);
};




