export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.TabsAPI.SetActiveTab($parameters.UniqueId,$parameters.TabsNumber);
};




