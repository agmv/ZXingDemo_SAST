export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SectionIndexAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




