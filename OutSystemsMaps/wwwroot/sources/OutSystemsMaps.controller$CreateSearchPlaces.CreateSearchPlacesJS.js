export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.PlacesAPI.SearchPlacesManager.CreateSearchPlaces($parameters.searchPlacesId, $parameters.configs, 'v2');
};




