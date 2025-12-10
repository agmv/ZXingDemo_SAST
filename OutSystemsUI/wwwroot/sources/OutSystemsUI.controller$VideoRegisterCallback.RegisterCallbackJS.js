export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.VideoAPI.RegisterCallback(
    $parameters.UniqueId,
    $parameters.EventName,
    $parameters.Callback
);
};




