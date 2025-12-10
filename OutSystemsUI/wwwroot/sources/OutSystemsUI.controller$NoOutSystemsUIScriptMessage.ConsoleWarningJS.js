export default function ($parameters, $actions, $roles, $public) {
$parameters.Message = 'The action ' + $parameters.ActionName + ' requires the OutSystemsUI.js script and it is not loaded yet. Use the LoadOutSystemsUIScript action before the action to ensure that the script is defined.';
console.warn($parameters.Message);
};




