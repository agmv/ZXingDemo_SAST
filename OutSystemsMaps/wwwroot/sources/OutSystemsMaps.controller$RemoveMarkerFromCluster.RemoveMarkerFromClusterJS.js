export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.Maps.MapAPI.MarkerManager.RemoveMarkerFromCluster($parameters.MapId, $parameters.MarkerPosition);
};




