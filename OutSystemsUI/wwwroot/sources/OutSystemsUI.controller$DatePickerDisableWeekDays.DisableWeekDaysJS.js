export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DatePickerAPI.DisableWeekDays(
    $parameters.WidgetId,
    JSON.parse($parameters.DisabledWeekDays)
);
};




