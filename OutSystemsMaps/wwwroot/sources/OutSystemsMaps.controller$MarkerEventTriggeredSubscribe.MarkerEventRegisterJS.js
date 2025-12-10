export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MarkerManager.Events.SubscribeByUniqueId($parameters.MarkerEventUniqueId, $parameters.MarkerEventName, $parameters.Callback);
};




