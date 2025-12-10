export default function ($parameters, $actions, $roles, $public) {
var apiMethod = OutSystems.OSUI.Utils.GetPickerExtensibilityAPI($parameters.WidgetId, "SetProviderConfigs");

$parameters.ResponseJSON = apiMethod($parameters.WidgetId, Providers.OSUI.SharedProviderResources.Flatpickr.NormalizeFlatpickrConfigs(JSON.parse($parameters.ProviderConfigs)));
};




