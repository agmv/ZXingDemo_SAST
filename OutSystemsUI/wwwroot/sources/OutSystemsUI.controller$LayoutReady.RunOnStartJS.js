export default function ($parameters, $actions, $roles, $public) {
// Actions that run only once per application start

if(window.applicationStarted === undefined) {
    $actions.SetDeviceClass($parameters.IsWebApp);

    if($parameters.IsWebApp || $parameters.IsPWA) {
        $actions.WCAGMetaTag();
    }
        
    window.applicationStarted = true;
}
};




