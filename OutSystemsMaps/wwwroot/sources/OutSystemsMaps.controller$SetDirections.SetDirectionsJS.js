export default function ($parameters, $actions, $roles, $public) {
return new Promise(function ($resolve, $reject) {
OutSystems.Maps.MapAPI.Directions.SetDirections(
    $parameters.MapId,
    $parameters.Options
).then(function(response) {
    $parameters.ReturnMessage = response;
}).catch(function(responseError){
    $parameters.ReturnMessage = responseError;
}).finally(()=>{
    $resolve();
});
});
};




