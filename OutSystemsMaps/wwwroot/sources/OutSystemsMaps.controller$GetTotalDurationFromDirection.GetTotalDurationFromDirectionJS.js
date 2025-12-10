export default function ($parameters, $actions, $roles, $public) {
return new Promise(function ($resolve, $reject) {
OutSystems.Maps.MapAPI.Directions.GetTotalDurationFromDirection($parameters.MapId).then(function(response) {
    $parameters.Duration = response;
    $resolve();
})
});
};




