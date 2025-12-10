export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.DropdownAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




