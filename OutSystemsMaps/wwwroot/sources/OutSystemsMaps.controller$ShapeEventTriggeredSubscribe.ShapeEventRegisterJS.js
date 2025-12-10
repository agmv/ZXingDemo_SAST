export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.ShapeManager.Events.SubscribeByEventUniqueId($parameters.ShapeEventUniqueId, $parameters.ShapeEventName, $parameters.Callback);
};




