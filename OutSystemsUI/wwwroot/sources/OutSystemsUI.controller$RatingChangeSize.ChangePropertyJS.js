export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.RatingAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




