export default function ($parameters, $actions, $roles, $public) {
$parameters.Response = OutSystems.OSUI.Utils.Accessibility.SetAriaHidden($parameters.WidgetId,$parameters.IsHidden);
};




