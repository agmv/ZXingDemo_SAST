export default function ($parameters, $actions, $roles, $public) {
var layout = document.body.querySelector('.layout');

if(layout) {
    var isNative = layout.classList.contains('layout-native');

    if(isNative) {
        $parameters.IsNative = true;
    } else {
        $parameters.IsNative = false;
    }
}

};




