import {runPreInitialization, Injector, useBaseApplication, Format, useAuthConfigsManager, useSettingsManager, settingsUpdatedHandler, useVersionsManager, runPostInitialization, Interfaces, ErrorScreen} from "@outsystems/runtime-core-js";
import {default as ZXingLibDemoAppDefinition} from "./ZXingLibDemo.appDefinition.js";
runPreInitialization(Injector, {
applicationDefinition: ZXingLibDemoAppDefinition
}).then(function () {
return Promise.all([useBaseApplication(Injector, {
dateTimeFormat: new Format.DateTimeFormatInfo("yyyy-MM-dd", "HH:mm:ss"),
numberFormat: new Format.NumberFormatInfo(".", "")
}), useAuthConfigsManager(Injector), useSettingsManager(Injector, {
onSettingsUpdated: settingsUpdatedHandler
}), useVersionsManager()]);
}).then(function () {
return runPostInitialization({
initType: Interfaces.Application.InitializationType.Minimal
}).then(function () {
function initView() {
ErrorScreen.renderErrorScreen(ZXingLibDemoAppDefinition);
}
return initView();

});
}).catch(function (error) {
console.error(error);
});

