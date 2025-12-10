export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.SidebarAPI.ToggleGestures($parameters.WidgetId, $parameters.EnableSwipe);
};




