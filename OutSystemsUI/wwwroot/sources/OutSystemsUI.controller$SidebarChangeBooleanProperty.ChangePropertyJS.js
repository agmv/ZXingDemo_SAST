export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.SidebarAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




