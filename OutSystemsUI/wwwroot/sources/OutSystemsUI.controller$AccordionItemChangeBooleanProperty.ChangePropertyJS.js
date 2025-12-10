export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.AccordionItemAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




