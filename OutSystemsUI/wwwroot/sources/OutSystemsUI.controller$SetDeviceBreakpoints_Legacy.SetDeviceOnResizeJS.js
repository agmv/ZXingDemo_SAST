export default function ($parameters, $actions, $roles, $public) {
$public.View.registerDeviceClassGetter(function() {

    var deviceList;
    var userValues;
    var device;
    var body = document.body;
    var windowWidth = window.innerWidth || document.documentElement.clientWidth;
    var windowHeight = window.innerHeight || document.documentElement.clientHeight;
    var orient = windowWidth > windowHeight ? "landscape" : "portrait";
    
    userValues = {
        phone: $parameters.Phone,
        tablet: $parameters.Tablet,
    };
    
    var phoneMax = userValues.phone ? userValues.phone : 700;
    var tabletMax = userValues.tablet ? userValues.tablet : 1024;
   
    deviceList = ["phone", "tablet", "desktop"];

    if (windowWidth <= phoneMax) {
        //Is phone!
        device = 0;
    } else if (windowWidth <= tabletMax) {
        //Is Tablet!
        device = 1;
    } else {
        //Is Desktop!
        device = 2;
    }
   
   return [orient, deviceList[device]];
   
});

};




