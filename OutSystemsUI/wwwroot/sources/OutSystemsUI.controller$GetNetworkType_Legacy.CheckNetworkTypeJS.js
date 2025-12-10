export default function ($parameters, $actions, $roles, $public) {
if (typeof navigator.connection !== "undefined") {
    //In a mobile device
    if(typeof navigator.connection.type !== "undefined"){
        $parameters.NetworkType = navigator.connection.type;
    } else {
        //In a web browser
        $parameters.NetworkType = "webbrowser"; 
    }
} else {
    //In a web browser
    $parameters.NetworkType = "webbrowser";
}
};




