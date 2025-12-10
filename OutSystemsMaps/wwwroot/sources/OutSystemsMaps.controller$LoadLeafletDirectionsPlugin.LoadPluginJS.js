export default function ($parameters, $actions, $roles, $public) {
$parameters.ReturnMessage = OutSystems.Maps.MapAPI.Directions.LoadPlugin(
    $parameters.MapId,
    $parameters.Provider,
    $parameters.APIKey
);
};




