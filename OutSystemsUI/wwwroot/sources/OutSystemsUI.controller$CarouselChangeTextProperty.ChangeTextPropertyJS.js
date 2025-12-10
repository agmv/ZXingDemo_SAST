export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.CarouselAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




