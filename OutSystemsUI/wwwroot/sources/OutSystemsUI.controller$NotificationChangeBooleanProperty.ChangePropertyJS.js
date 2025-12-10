export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.NotificationAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




