export default function ($parameters, $actions, $roles, $public) {
var apiMethod = OutSystems.OSUI.Utils.GetPickerExtensibilityAPI($parameters.WidgetId, "UnsetProviderEvent");

$parameters.ResponseJSON = apiMethod($parameters.WidgetId, $parameters.EventId);

};




