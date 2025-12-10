export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.RangeSliderAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




