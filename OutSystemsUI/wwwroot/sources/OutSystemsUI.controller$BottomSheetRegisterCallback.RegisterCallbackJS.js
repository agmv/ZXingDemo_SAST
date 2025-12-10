export default function ($parameters, $actions, $roles, $public) {
OutSystems.OSUI.Patterns.BottomSheetAPI.RegisterCallback($parameters.UniqueId, $parameters.EventName, $parameters.Callback);
};




