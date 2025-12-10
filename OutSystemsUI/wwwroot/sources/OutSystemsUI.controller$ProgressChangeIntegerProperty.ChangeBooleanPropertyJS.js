export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.ProgressAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




