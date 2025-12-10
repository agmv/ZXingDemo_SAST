export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.GalleryAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




