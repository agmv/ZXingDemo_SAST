export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.MonthPickerAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




