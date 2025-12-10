export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.TooltipAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




