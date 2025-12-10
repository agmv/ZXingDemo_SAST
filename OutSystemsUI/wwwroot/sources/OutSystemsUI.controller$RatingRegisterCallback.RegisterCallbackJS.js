export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.RatingAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




