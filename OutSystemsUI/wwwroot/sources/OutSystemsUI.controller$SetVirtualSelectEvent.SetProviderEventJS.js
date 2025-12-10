export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DropdownAPI.SetProviderEvent($parameters.WidgetId, $parameters.EventName, $parameters.Handler);
};




