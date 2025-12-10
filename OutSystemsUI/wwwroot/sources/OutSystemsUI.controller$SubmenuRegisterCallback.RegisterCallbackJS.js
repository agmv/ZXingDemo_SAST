export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SubmenuAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




