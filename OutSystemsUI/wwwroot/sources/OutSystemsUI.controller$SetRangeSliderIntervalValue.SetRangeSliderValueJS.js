export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.RangeSliderAPI.SetRangeSliderValue($parameters.UniqueId, $parameters.ValueFrom, $parameters.ValueTo);
};




