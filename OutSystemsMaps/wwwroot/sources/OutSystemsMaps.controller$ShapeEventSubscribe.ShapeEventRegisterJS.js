export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.ShapeManager.Events.Subscribe($parameters.ShapeWidgetId, $parameters.ShapeEventId, $parameters.Callback);
};




