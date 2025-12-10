export default function ($parameters, $actions, $roles, $public) {
var classList = document.body.classList;

if(classList.contains("landscape")) {
    $parameters.Orientation = "landscape";
} else if(classList.contains("portrait")) {
    $parameters.Orientation = "portrait";
}
};




