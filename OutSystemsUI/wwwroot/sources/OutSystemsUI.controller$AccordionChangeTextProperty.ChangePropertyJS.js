export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.AccordionAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




