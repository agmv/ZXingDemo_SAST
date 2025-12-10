export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.VideoAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




