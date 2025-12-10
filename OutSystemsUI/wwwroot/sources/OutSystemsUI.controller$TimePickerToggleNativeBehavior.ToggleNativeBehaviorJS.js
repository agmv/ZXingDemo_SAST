export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.TimePickerAPI.ToggleNativeBehavior($parameters.UniqueId, $parameters.IsNative);
};




