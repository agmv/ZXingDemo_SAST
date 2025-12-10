export default function ($parameters, $actions, $roles, $public) {
var body = document.body;
var isTouch = false;
  
function detectTouchscreen() {
  if (window.PointerEvent && ('maxTouchPoints' in navigator)) {
    // if Pointer Events are supported, just check maxTouchPoints
    if (navigator.maxTouchPoints > 0) {
      isTouch = true;
    }
  } else {
    // no Pointer Events...
    if (window.matchMedia && window.matchMedia("(any-pointer:coarse)").matches) {
      // check for any-pointer:coarse which mostly means touchscreen
      isTouch = true;
    } else if (window.TouchEvent || ('ontouchstart' in window)) {
      // last resort - check for exposed touch events API / event handler
      isTouch = true;
    }
  }
  
  return isTouch;
  
}

detectTouchscreen();
$parameters.IsTouch = isTouch;
};




