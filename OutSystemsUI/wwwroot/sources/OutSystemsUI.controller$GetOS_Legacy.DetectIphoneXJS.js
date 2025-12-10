export default function ($actions, $roles, $public) {
var body = document.querySelector("body");

// detect iPhoneX
function detectIphoneX() {
    // devices list and their screen sizes
    var devices = [
        
        // iPhoneX
        {width: 1125, height: 2436, description: "iphone x/xs"},
        {width: 828, height: 1792, description: "iphone xr"},
        {width: 750, height: 1624, description: "iphone xr scaled"},
        {width: 1242, height: 2688, description: "iphone xs max"},
        
        // iPhone12
        {width: 1170, height: 2532, description: "iphone 12"},
        {width: 1284, height: 2778, description: "iphone 12 pro max"},
        
        // iPhone13
        {width: 1170, height: 2532, description: "iphone 13"},
        {width: 1125, height: 2436, description: "iphone 13 mini"},
        {width: 1170, height: 2532, description: "iphone 13 pro"},
        {width: 1284, height: 2778, description: "iphone 13 pro max"},
    ];
    
    // get the device pixel ratio
    var ratio = window.devicePixelRatio || 1;

    // get the device screen dimensions
    var screen = {
        width : window.screen.width * ratio,
        height : window.screen.height * ratio
    };

    // check if the screen size matches any of the devices in the list
    for(var i = 0; i < devices.length; i++) {
        if(devices[i].width === screen.width && devices[i].height === screen.height) {
            window.iphoneX = true;
            break;
        }
    }
    
    if(window.iphoneX) {
        // get orientation and register an event to update it
        detectOrientation();
        window.addEventListener("orientationchange", function() {
            setTimeout(detectOrientation, 500);
        });
    }
}

// update orientation
function detectOrientation() {
    // store the notch position value
    var notchPosition;
    
    if("orientation" in window) {
        // mobile browers
        if (window.orientation == 90) {
            notchPosition = "left";
        } else if (window.orientation == -90) {
            notchPosition = "right";
        } else {
            notchPosition = "up";
        }
    } else if ("orientation" in window.screen) {
        // webkit browsers
        if( window.screen.orientation.type === "landscape-primary") {
            notchPosition = "left";
        } else if( window.screen.orientation.type === "landscape-secondary") {
            notchPosition = "right";
        } else {
            notchPosition = "up";
        }
    } else if("mozOrientation" in window.screen) {
        // firefox browsers
        if( window.screen.mozOrientation === "landscape-primary") {
            notchPosition = "left";
        } else if( window.screen.mozOrientation === "landscape-secondary") {
            notchPosition = "right";
        } else {
            notchPosition = "up";
        }
    }
    
    window.notch = notchPosition;
    updateClasses();
}

function updateClasses() {
    // set the iphonex class on the body
    body.classList.add("iphonex");
    
    // override tablet detection on landscape mode
    if (window.notch == "left" || window.notch == "right") {
        body.classList.remove("tablet");
        body.classList.add("phone");
    }
}

// detect iPhoneX
detectIphoneX();
};




