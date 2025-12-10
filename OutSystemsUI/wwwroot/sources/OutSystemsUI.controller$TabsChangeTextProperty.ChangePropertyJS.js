export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TabsAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




