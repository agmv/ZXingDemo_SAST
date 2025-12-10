export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.RangeSliderAPI.SetProviderConfigs(
    $parameters.WidgetId,
    Providers.OSUI.RangeSlider.NoUISlider.Utils.NormalizeNoUISliderConfigs(JSON.parse($parameters.ProviderConfigs))
);
};




