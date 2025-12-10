export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SidebarAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




