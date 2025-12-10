export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.ProgressAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




