export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.AnimatedLabelAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




