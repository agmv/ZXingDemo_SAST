export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.OverflowMenuAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




