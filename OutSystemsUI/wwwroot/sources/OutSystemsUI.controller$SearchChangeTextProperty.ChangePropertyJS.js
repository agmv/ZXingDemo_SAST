export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SearchAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




