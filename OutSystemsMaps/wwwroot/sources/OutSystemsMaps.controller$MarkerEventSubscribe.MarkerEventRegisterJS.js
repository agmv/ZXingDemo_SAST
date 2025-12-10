export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MarkerManager.Events.Subscribe($parameters.MarkerWidgetId, $parameters.MarkerEventId, $parameters.Callback);
};




