export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.ProgressAPI.SetProgressValue($parameters.WidgetId, $parameters.Progress);
};




