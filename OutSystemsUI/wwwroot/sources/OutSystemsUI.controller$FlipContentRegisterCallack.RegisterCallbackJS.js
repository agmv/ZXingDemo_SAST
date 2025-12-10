export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.FlipContentAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




