export default function ($actions, $roles, $public) {
// Simulate scroll to avoid rendering issues on WebView (replicated on Tablet devices)
var docElem = document.documentElement;

docElem.scrollLeft = 2;

setTimeout(function(){ 
    docElem.scrollLeft = 0;
}, 100);
};




