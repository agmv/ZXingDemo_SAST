export default function ($parameters, $actions, $roles, $public) {
// Set focus in the container
var elementId = document.getElementById($parameters.SetFocusWidgetId);
var isPhone = document.body.classList.contains('phone');

elementId.setAttribute('tabindex', "0");
elementId.focus();

if(!isPhone) {
    // Set the properties to define the tab navigation inside the content
    var focusItemTop = elementId.closest(".split-right-content").querySelector("span.focus-item.top");
    focusItemTop.setAttribute("tabindex", "0");
    focusItemTop.setAttribute("focusItemId", $parameters.ClickedItemId);
    
    var focusItemBottom = elementId.closest(".split-right-content").querySelector("span.focus-item.bottom");
    if(document.querySelector("#"+$parameters.ClickedItemId + " + div")){
        focusItemBottom.setAttribute("tabindex", "0");
        focusItemBottom.setAttribute("focusItemId", document.querySelector("#"+$parameters.ClickedItemId + " + div").id);   
    }
    else {
        focusItemBottom.setAttribute("tabindex", "-1");
        focusItemBottom.removeAttribute("focusItemId");
    } 
}
};




