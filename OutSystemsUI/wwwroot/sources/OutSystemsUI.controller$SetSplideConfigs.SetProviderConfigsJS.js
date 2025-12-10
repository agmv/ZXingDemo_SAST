export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.CarouselAPI.SetProviderConfigs(
        $parameters.WidgetId, 
        Providers.OSUI.Carousel.Splide.Utils.NormalizeSplideConfigs(JSON.parse($parameters.ProviderConfigs))
    );
};




