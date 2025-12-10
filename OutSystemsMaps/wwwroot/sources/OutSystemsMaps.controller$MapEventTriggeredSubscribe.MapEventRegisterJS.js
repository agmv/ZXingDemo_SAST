export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MapManager.Events.SubscribeByUniqueId($parameters.MapEventUniqueId, $parameters.MapEventName, $parameters.Callback);
};




