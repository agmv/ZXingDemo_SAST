export default function ($parameters, $actions, $roles, $public) {
window.removeEventListener('orientationchange', $actions.OnOrientationChange);
$parameters.CarouselObj.destroy();
};




