export default function ($parameters, $actions, $roles, $public) {
if($parameters.DOMElem) {
    var floatingActionsButton = $parameters.DOMElem.querySelector('.floating-button');

    if($parameters.IsHover) {
        floatingActionsButton.removeEventListener("mouseleave",$actions.ToggleClick);
        $parameters.DOMElem.removeEventListener("mouseleave",$actions.ToggleClick);
    } else {
        floatingActionsButton.removeEventListener("click", $actions.ToggleClick);
    }

    // Remove detached DOM element
    $parameters.DOMElem.remove();
}
};




