export default function ($parameters, $actions, $roles, $public) {
$parameters.OperatingSystem = OutSystems.OSUI.Utils.DeviceDetection.GetOperatingSystem($parameters.UserAgent);
};




