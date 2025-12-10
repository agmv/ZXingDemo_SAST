export default function ($parameters, $actions, $roles, $public) {
return new Promise(function ($resolve, $reject) {
OutSystems.Maps.MapAPI.Directions.GetTotalDistanceFromDirection($parameters.MapId).then(function(response) {
    $parameters.Distance = response;
    $resolve();
})
});
};




