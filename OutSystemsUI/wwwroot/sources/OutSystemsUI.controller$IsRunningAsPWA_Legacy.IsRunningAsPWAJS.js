export default function ($parameters, $actions, $roles, $public) {
if (window.matchMedia && (window.matchMedia('(display-mode: standalone)').matches) || window.navigator.standalone === true) {
    $parameters.isStandalone = true;
}
else {
    $parameters.isStandalone = false;
}
};




