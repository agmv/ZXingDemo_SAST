export default function ($parameters, $actions, $roles, $public) {
$parameters.Response = OutSystems.OSUI.Utils.ScrollToElement(
    $parameters.WidgetId,
    $parameters.IsSmooth,
    $parameters.OffSet,
    $parameters.ElementParentClass,
    $parameters.ScrollDelay
);
};




