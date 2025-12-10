export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.BottomSheetAPI.ChangeProperty(
    $parameters.UniqueId, 
    $parameters.PropertyName, 
    $parameters.PropertyValue
);
};




