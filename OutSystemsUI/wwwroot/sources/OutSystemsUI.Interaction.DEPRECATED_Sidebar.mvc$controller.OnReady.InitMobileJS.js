export default function ($parameters, $actions, $roles, $public) {
var el = document.getElementById($parameters.WidgetId).parentNode.id;
var layout = document.querySelector('.layout');

if(layout) {
    var nativeLayout = layout.classList.contains('layout-native');
    
    if(nativeLayout) { // new native layouts
        $actions.MoveElement(el, ".active-screen .content-top");   
    } else {// Old native layouts
        $actions.MoveElement(el, ".active-screen .content-top");
    }
}



};




