export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.ButtonLoadingAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




