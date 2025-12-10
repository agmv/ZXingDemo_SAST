export default function ($parameters, $actions, $roles, $public) {
var classList = document.body.classList;

if(classList.contains("phone")) {
    $parameters.Device = "phone";
} else if(classList.contains("tablet")) {
    $parameters.Device = "tablet";
} else {
    $parameters.Device = "desktop";
}
};




