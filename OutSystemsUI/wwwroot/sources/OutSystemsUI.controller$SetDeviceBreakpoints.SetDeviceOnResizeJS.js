export default function ($parameters, $actions, $roles, $public) {
$public.View.registerDeviceClassGetter(OutSystems.OSUI.Utils.DeviceDetection.SetDeviceBreakpoints($parameters.Phone, $parameters.Tablet));
};




