export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DropdownAPI.SetValues(
    $parameters.UniqueId, 
    $parameters.SelectedValues, 
    $parameters.SilentOnChangedEvent
);
};




