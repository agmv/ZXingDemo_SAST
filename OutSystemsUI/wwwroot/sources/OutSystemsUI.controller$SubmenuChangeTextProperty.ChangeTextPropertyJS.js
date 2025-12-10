export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SubmenuAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




