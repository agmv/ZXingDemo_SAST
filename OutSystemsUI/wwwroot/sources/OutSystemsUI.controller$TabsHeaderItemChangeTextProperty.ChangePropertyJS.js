export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TabsHeaderItemAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




