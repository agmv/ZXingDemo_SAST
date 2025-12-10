export default function ($parameters, $actions, $roles, $public) {
$parameters.ReturnMessage = OutSystems.Maps.MapAPI.MarkerManager.Events.Subscribe($parameters.MarkerId, $parameters.MarkerEventTriggeredId, $parameters.Callback);
};




