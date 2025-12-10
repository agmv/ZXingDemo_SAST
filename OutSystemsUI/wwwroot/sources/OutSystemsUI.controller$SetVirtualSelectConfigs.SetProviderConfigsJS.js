export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Patterns.DropdownAPI.SetProviderConfigs(
        $parameters.WidgetId, 
        Providers.OSUI.Dropdown.VirtualSelect.Utils.NormalizeVirtualSelectConfigs(JSON.parse($parameters.ProviderConfigs))
    );
};




