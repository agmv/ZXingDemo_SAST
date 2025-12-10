export default function ($parameters, $actions, $roles, $public) {
// toggle Sidebar

var el;
var isOpen;

if($parameters.WidgetId !== "") {
    el = document.querySelector("#" + $parameters.WidgetId + " .sidebar");
}

if(el !== null) {
    isOpen = el.classList.contains("sidebar-open");
    
    if(isOpen) {
        el.classList.remove("sidebar-open");
    } else {
        el.classList.add("sidebar-open");
    }
}
};




