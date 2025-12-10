export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.MonthPickerAPI.UpdateInitialMonth(
    $parameters.UniqueId,
    JSON.parse($parameters.NewMonth)
);

};




