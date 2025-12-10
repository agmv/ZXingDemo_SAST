export default function ($parameters, $actions, $roles, $public) {
$parameters.Response = OutSystems.OSUI.Utils.Menu.SetActiveMenuItems($parameters.WidgetId,$parameters.ActiveItem,$parameters.ActiveSubItem);
};




