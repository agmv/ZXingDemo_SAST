export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MapManager.Events.Unsubscribe($parameters.MapWidgetId, $parameters.MapEventId, $parameters.Callback);
};




