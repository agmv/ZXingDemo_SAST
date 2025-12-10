export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.VideoAPI.JumpToTime(
    $parameters.WidgetId,
    OSFramework.OSUI.Helper.Times.ConvertInSeconds($parameters.JumpToTime)
);
};




