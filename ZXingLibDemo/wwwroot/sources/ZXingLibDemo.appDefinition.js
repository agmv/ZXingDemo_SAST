import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "61918b7a-e496-4b63-992b-b83299b21e43",
applicationName: "ZXingLib Demo",
userProviderName: "Users",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "ZXingLibDemo",
homeModuleKey: "61918b7a-e496-4b63-992b-b83299b21e43",
homeModuleControllerName: "ZXingLibDemo.controller",
homeModuleLanguageResourcesName: "ZXingLibDemo.languageResources",
defaultScreenName: "About",
defaultTransition: "Fade",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.445.0",
buildSDKVersion: "v44.7.4.0",
clientRuntimeVersion: "6.50.21",
appVersion: "63",
useBaseTag: false,
homeModuleControllerImporter: async function () {
var {default: ZXingLibDemoController} = await(import("./ZXingLibDemo.controller.js"));
return ZXingLibDemoController;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: ZXingLibDemoLanguageResources} = await(import("./ZXingLibDemo.languageResources.js"));
return ZXingLibDemoLanguageResources;

},
screensDefinition: [{
screenKey: "0e04d04c-3857-48b3-b59d-04051d40722c",
screenName: "Common.RecoverPasswordReset",
viewModuleName: "ZXingLibDemo.Common.RecoverPasswordReset.mvc$view",
modelModuleName: "ZXingLibDemo.Common.RecoverPasswordReset.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.RecoverPasswordReset.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "2b4875e6-4842-4a90-bbe5-5e12808a4563",
screenName: "Common.InvalidPermissions",
viewModuleName: "ZXingLibDemo.Common.InvalidPermissions.mvc$view",
modelModuleName: "ZXingLibDemo.Common.InvalidPermissions.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.InvalidPermissions.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "3fea9ba6-0c6b-4fe7-ab2e-65022a9839c0",
screenName: "Common.RecoverPasswordRequest",
viewModuleName: "ZXingLibDemo.Common.RecoverPasswordRequest.mvc$view",
modelModuleName: "ZXingLibDemo.Common.RecoverPasswordRequest.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.RecoverPasswordRequest.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "aa6a2f48-0824-4f02-bbe3-20b08d067bf1",
screenName: "Common.Login",
viewModuleName: "ZXingLibDemo.Common.Login.mvc$view",
modelModuleName: "ZXingLibDemo.Common.Login.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.Login.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "d1f92804-a4fa-4d9e-a9cd-6ae1223130e4",
screenName: "Common.UserProfile",
viewModuleName: "ZXingLibDemo.Common.UserProfile.mvc$view",
modelModuleName: "ZXingLibDemo.Common.UserProfile.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.UserProfile.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "e3781629-a18d-40a3-a680-8c697e181700",
screenName: "Common.ChangePassword",
viewModuleName: "ZXingLibDemo.Common.ChangePassword.mvc$view",
modelModuleName: "ZXingLibDemo.Common.ChangePassword.mvc$model",
controllerModuleName: "ZXingLibDemo.Common.ChangePassword.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.Common.controller"
}, {
screenKey: "38fdc85c-44aa-4670-a1d6-9e4fbc614c44",
screenName: "MainFlow.Demo",
viewModuleName: "ZXingLibDemo.MainFlow.Demo.mvc$view",
modelModuleName: "ZXingLibDemo.MainFlow.Demo.mvc$model",
controllerModuleName: "ZXingLibDemo.MainFlow.Demo.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.MainFlow.controller"
}, {
screenKey: "390e18bb-c9c7-4fdf-818a-4aedb7928967",
screenName: "MainFlow.About",
viewModuleName: "ZXingLibDemo.MainFlow.About.mvc$view",
modelModuleName: "ZXingLibDemo.MainFlow.About.mvc$model",
controllerModuleName: "ZXingLibDemo.MainFlow.About.mvc$controller",
webFlowControllerModuleName: "ZXingLibDemo.MainFlow.controller"
}]
};




