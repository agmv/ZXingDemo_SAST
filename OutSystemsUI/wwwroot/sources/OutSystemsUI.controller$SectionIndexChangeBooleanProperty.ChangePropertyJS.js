export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SectionIndexAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




