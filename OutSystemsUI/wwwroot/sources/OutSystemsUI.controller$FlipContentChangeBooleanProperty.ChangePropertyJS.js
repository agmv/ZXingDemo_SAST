export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.FlipContentAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




