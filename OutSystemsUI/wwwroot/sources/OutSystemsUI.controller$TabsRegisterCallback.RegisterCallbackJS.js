export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TabsAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




