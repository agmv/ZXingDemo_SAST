import {ApplicationInfo} from "@outsystems/runtime-core-js";

function buildURL(url) {
var basePath = ApplicationInfo.getBasePath();
basePath = basePath.replace(/\/$/, "");
if(url) {
return ((basePath + "/") + url);
} else {
return basePath;
}

};
export const ROUTER_INFO = [{
get pathname() {return buildURL();
},
screenName: "MainFlow.About",
forDefaultPath: true,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.MainFlow.About.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RecoverPasswordReset");
},
screenName: "Common.RecoverPasswordReset",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.RecoverPasswordReset.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvalidPermissions");
},
screenName: "Common.InvalidPermissions",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.InvalidPermissions.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RecoverPasswordRequest");
},
screenName: "Common.RecoverPasswordRequest",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.RecoverPasswordRequest.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Login");
},
screenName: "Common.Login",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.Login.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("UserProfile");
},
screenName: "Common.UserProfile",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.UserProfile.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ChangePassword");
},
screenName: "Common.ChangePassword",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.Common.ChangePassword.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Demo");
},
screenName: "MainFlow.Demo",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.MainFlow.Demo.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("About");
},
screenName: "MainFlow.About",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ZXingLibDemo.MainFlow.About.mvc$screen.js");
}
}
}];
export const SPLASH_SCREEN_ROUTE = null;
