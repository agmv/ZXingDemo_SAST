export default function ($parameters, $actions, $roles, $public) {
$parameters.ReturnMessage = OutSystems.Maps.MapAPI.MarkerManager.AddMarker($parameters.MapId, $parameters.Configs);
};




