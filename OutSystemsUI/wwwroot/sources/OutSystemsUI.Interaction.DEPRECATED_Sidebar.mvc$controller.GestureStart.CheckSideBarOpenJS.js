export default function ($parameters, $actions, $roles, $public) {
var layout = document.getElementById($parameters.WidgetId);
var isRTL = document.querySelector('.is-rtl');

if (layout.classList.contains('sidebar-open')) {
    $parameters.IsOpen = true;
}

if(isRTL) {
    $parameters.isRTL = true;
}

$parameters.SidebarWidth = layout.offsetWidth;
};




