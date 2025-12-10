export default function ($parameters, $actions, $roles, $public) {
$parameters.Legs = OutSystems.Maps.MapAPI.Directions.GetLegsFromDirection($parameters.MapId)
};




