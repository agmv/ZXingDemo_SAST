export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TabsContentItemAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




