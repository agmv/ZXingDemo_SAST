export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TooltipAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




