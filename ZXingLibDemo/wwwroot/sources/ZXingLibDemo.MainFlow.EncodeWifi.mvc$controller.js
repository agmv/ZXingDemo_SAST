import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import ZXingLibDemoLanguageResources from "./ZXingLibDemo.languageResources.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
wifiCardBarcode$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
wifiCardBarcode$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get wifiCardBarcode$DataActRefresh() {if(!(this.hasOwnProperty("_wifiCardBarcode$DataActRefresh"))) {
this._wifiCardBarcode$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionWifiCardBarcode", "screenservices/ZXingLibDemo/MainFlow/EncodeWifi/DataActionWifiCardBarcode", "KoWdTjweCkzPzVvPhlFu7A", function (b) {
model.variables.wifiCardBarcodeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.wifiCardBarcodeDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.wifiCardBarcodeDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._onAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("WifiCardBarcode", function (span) {
if(span) {
span.setAttribute("code.function", "WifiCardBarcode");
span.setAttribute("outsystems.function.key", "efcd10e6-05c2-44ed-b9e1-3af72d231ad7");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._wifiCardBarcode$DataActRefresh;
}set wifiCardBarcode$DataActRefresh(value) {this._wifiCardBarcode$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["wifiCardBarcode$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _wifiEncodeOnClick$Action() {if(!(this.hasOwnProperty("__wifiEncodeOnClick$Action"))) {
this.__wifiEncodeOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("WifiEncodeOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "WifiEncodeOnClick");
span.setAttribute("outsystems.function.key", "8e0e8a93-df93-4711-9867-3a94d5d12659");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("WifiEncodeOnClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// Show loading pop-up
// IsLoading = True
ZXingLibDemoClientVariables.setIsLoading(true);
// Refresh Query: WifiCardBarcode
var result = controller.wifiCardBarcode$DataActRefresh(callContext);
model.flush();
return result;
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__wifiEncodeOnClick$Action;
}set _wifiEncodeOnClick$Action(value) {this.__wifiEncodeOnClick$Action = value;
}

get _onAfterFetch$Action() {if(!(this.hasOwnProperty("__onAfterFetch$Action"))) {
this.__onAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "ead0f76f-3df7-410b-a77f-618262b92a80");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnAfterFetch");
callContext = controller.callContext(callContext);
// Hide loading pop-up
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onAfterFetch$Action;
}set _onAfterFetch$Action(value) {this.__onAfterFetch$Action = value;
}


wifiEncodeOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("WifiEncodeOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "WifiEncodeOnClick");
span.setAttribute("outsystems.function.key", "8e0e8a93-df93-4711-9867-3a94d5d12659");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wifiEncodeOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "ead0f76f-3df7-410b-a77f-618262b92a80");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = null;
}

return this._onRenderEventHandler;
}set onRenderEventHandler(value) {this._onRenderEventHandler = value;
}

get onDestroyEventHandler() {if(!(this.hasOwnProperty("_onDestroyEventHandler"))) {
this._onDestroyEventHandler = null;
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = null;
}

return this._onParametersChangedEventHandler;
}set onParametersChangedEventHandler(value) {this._onParametersChangedEventHandler = value;
}

// Sync Event Handler Actions
get onSyncStartEventHandler() {if(!(this.hasOwnProperty("_onSyncStartEventHandler"))) {
this._onSyncStartEventHandler = null;
}

return this._onSyncStartEventHandler;
}set onSyncStartEventHandler(value) {this._onSyncStartEventHandler = value;
}

get onSyncCompleteEventHandler() {if(!(this.hasOwnProperty("_onSyncCompleteEventHandler"))) {
this._onSyncCompleteEventHandler = null;
}

return this._onSyncCompleteEventHandler;
}set onSyncCompleteEventHandler(value) {this._onSyncCompleteEventHandler = value;
}

get onSyncErrorEventHandler() {if(!(this.hasOwnProperty("_onSyncErrorEventHandler"))) {
this._onSyncErrorEventHandler = null;
}

return this._onSyncErrorEventHandler;
}set onSyncErrorEventHandler(value) {this._onSyncErrorEventHandler = value;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex) {
return controller.handleError(ex);
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




