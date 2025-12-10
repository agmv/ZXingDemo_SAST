export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DropdownAPI.Clear(
    $parameters.WidgetId, 
    $parameters.SilentOnChangedEvent
);
};




