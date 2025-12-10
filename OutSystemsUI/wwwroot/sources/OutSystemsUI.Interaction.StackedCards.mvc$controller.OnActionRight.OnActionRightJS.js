export default function ($parameters, $actions, $roles, $public) {
if($parameters.UseOverlays) {
    $parameters.RightObj.classList.remove('no-transition');
    $parameters.TopObj.classList.remove('no-transition');
    $parameters.RightObj.style.zIndex = '8';
}
setTimeout(function(){
    $actions.OnSwipeRight();
    $actions.ResetOverlayRight();
},300);
};




