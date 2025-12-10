export default function ($parameters, $actions, $roles, $public) {
var apiMethod = OutSystems.OSUI.Utils.GetPickerExtensibilityAPI($parameters.WidgetId, "SetProviderEvent");

$parameters.ResponseJSON = apiMethod($parameters.WidgetId, $parameters.EventName, $parameters.Handler);

};




