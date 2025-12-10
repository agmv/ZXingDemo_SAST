import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
export default {
applicationKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
applicationName: "OutSystems Maps",
userProviderName: "Users",
debugEnabled: false,
debugUseWebSockets: true,
homeModuleName: "OutSystemsMaps",
homeModuleKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
homeModuleControllerName: "OutSystemsMaps.controller",
homeModuleLanguageResourcesName: "OutSystemsMaps.languageResources",
defaultScreenName: "",
defaultTransition: "Fade",
errorPageConfig: {
showExceptionStack: false
},
isWeb: true,
frontendBuildWorkerVersion: "v18.445.0",
buildSDKVersion: "v44.7.4.0",
clientRuntimeVersion: "6.50.21",
appVersion: "45",
useBaseTag: false,
homeModuleControllerImporter: async function () {
var {default: OutSystemsMapsController} = await(import("./OutSystemsMaps.controller.js"));
return OutSystemsMapsController;

},
homeModuleLanguageResourcesImporter: async function () {
var {default: OutSystemsMapsLanguageResources} = await(import("./OutSystemsMaps.languageResources.js"));
return OutSystemsMapsLanguageResources;

},
screensDefinition: []
};




