export default function ($parameters, $actions, $roles, $public) {
$parameters.ReturnMessage = OutSystems.Maps.MapAPI.ShapeManager.ContainsLocation(
    $parameters.MapId,
    $parameters.ShapeWidgetId,
    $parameters.PointCoordinates,
    $parameters.CoordinatesList
);
};




