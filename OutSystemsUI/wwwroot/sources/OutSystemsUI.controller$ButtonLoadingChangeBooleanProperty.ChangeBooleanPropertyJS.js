export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.ButtonLoadingAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




