export default function ($parameters, $actions, $roles, $public) {
$parameters.ResponseJSON = OutSystems.OSUI.Utils.InvalidInputs.FocusFirstInvalidInput(
    $parameters.WidgetId,
    $parameters.IsSmooth,
    $parameters.ElementParentClass
);
};




