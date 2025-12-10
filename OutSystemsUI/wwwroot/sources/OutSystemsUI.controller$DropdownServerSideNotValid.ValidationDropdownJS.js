export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DropdownAPI.SetValidation($parameters.UniqueId, false, $parameters.ValidationMessage);
};




