export default function ($parameters, $actions, $roles, $public) {
$parameters.Response = OutSystems.OSUI.Utils.Accessibility.SetAccessibilityRole($parameters.WidgetId,$parameters.Role);
};




