export default function ($parameters, $actions, $roles, $public) {
var content = document.getElementById($parameters.ContentId);

if(content) {
    if($parameters.IsHover) {
        content.removeEventListener("mouseover", $actions.ToggleTooltip);
        content.removeEventListener("mouseleave", $actions.ToggleTooltip);
    } else {
        content.removeEventListener("click", $actions.ToggleTooltip);
    }
}
};




