export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MapManager.Events.Subscribe($parameters.MapWidgetId, $parameters.MapEventId, $parameters.Callback);
};




