import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "8be17f2a-431c-4958-b894-c77b988a7271",
applicationName: "OutSystems UI",
userProviderName: "Users",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "OutSystemsUI",
homeModuleKey: "8be17f2a-431c-4958-b894-c77b988a7271",
homeModuleControllerName: "OutSystemsUI.controller",
homeModuleLanguageResourcesName: "OutSystemsUI.languageResources",
defaultScreenName: "",
defaultTransition: "SlideFromRight",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.445.0",
buildSDKVersion: "v44.7.4.0",
clientRuntimeVersion: "6.50.21",
appVersion: "56",
useBaseTag: false,
homeModuleControllerImporter: async function () {
var {default: OutSystemsUIController} = await(import("./OutSystemsUI.controller.js"));
return OutSystemsUIController;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: OutSystemsUILanguageResources} = await(import("./OutSystemsUI.languageResources.js"));
return OutSystemsUILanguageResources;

},
screensDefinition: []
};




