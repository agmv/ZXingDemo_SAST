export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.FileLayerManager.Events.Subscribe($parameters.FileLayerWidgetId, $parameters.FileLayerEventId, $parameters.Callback);
};




