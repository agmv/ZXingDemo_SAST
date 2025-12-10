export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.PlacesAPI.SearchPlacesManager.Events.Subscribe($parameters.SearchPlacesWidgetId, $parameters.SearchPlacesEventId, $parameters.Callback);
};




