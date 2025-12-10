export default function ($parameters, $actions, $roles, $public) {
OutSystems.Maps.MapAPI.MapManager.CreateMap($parameters.mapID, $parameters.mapProvider, $parameters.mapType, $parameters.configs);
};




