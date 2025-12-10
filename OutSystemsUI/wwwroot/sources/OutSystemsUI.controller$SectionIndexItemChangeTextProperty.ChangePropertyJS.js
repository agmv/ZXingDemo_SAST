export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SectionIndexItemAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




