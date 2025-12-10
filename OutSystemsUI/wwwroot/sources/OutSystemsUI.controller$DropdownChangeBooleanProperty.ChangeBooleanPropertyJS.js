export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.DropdownAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




