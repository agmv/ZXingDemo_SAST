export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.GalleryAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




