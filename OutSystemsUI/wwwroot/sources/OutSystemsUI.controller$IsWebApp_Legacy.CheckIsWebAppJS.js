export default function ($parameters, $actions, $roles, $public) {
var layout = document.body.querySelector('.layout');

if(layout) {
    var isNative = layout.classList.contains('layout-native');
    var isNotOldNativeLayouts = document.querySelector('.active-screen .layout.layout-top') || document.querySelector('.active-screen .layout.layout-side') || document.querySelector('.active-screen .layout.blank') || document.querySelector('.active-screen .layout.layout-blank');
    
    if(isNotOldNativeLayouts && !isNative) {
            $parameters.IsWebApp = true;
    }
}

};




