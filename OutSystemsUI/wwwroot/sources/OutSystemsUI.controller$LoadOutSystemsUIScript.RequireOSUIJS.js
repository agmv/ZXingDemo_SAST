export default function ($parameters, $actions, $roles, $public) {
return new Promise(function ($resolve, $reject) {
// Require the OutsystemsUI.js
$actions.RequireScript($parameters.URL).then(function(){    
    $parameters.Success = true;
}).catch(function(e){
    $parameters.Success = false;
    console.warn('The OutSystemsUI.js wasn\'t successfully required');
}).finally(function(){
    $resolve();
})

});
};




