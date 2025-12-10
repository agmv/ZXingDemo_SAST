export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DatePickerAPI.DisableDays(
    $parameters.WidgetId,
    JSON.parse($parameters.DisabledWeekDays)
);
};




