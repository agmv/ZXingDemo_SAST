export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.DropdownServerSideItemAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




