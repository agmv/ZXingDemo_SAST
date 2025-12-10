export default function ($parameters, $actions, $roles, $public) {
$parameters.OnChange = $actions.OnChangeTimeHandler;
$parameters.OnInitialized = $actions.InitializedHandler;
};




