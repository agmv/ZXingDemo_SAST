export default function ($parameters, $actions, $roles, $public) {
$parameters.isStandalone =  OutSystems.OSUI.Utils.DeviceDetection.IsRunningAsPWA();
};




