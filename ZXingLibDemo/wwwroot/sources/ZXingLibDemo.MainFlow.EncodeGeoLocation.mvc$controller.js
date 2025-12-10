import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
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
geolocationBarcode$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
geolocationBarcode$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get geolocationBarcode$DataActRefresh() {if(!(this.hasOwnProperty("_geolocationBarcode$DataActRefresh"))) {
this._geolocationBarcode$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGeolocationBarcode", "screenservices/ZXingLibDemo/MainFlow/EncodeGeoLocation/DataActionGeolocationBarcode", "iIbM2LCXndFrHfAwE_N9Qg", function (b) {
model.variables.geolocationBarcodeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.geolocationBarcodeDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.geolocationBarcodeDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._onAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GeolocationBarcode", function (span) {
if(span) {
span.setAttribute("code.function", "GeolocationBarcode");
span.setAttribute("outsystems.function.key", "ea1ea8a9-eab3-43ee-8a84-7ef3c62df710");
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

return this._geolocationBarcode$DataActRefresh;
}set geolocationBarcode$DataActRefresh(value) {this._geolocationBarcode$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["geolocationBarcode$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _onAfterFetch$Action() {if(!(this.hasOwnProperty("__onAfterFetch$Action"))) {
this.__onAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "0ff31529-9fe5-4c6e-90c6-c2da2c2938cf");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnAfterFetch");
callContext = controller.callContext(callContext);
// Hide loading Pop-up.
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

get _geolocationEncodeOnClick$Action() {if(!(this.hasOwnProperty("__geolocationEncodeOnClick$Action"))) {
this.__geolocationEncodeOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GeolocationEncodeOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "GeolocationEncodeOnClick");
span.setAttribute("outsystems.function.key", "869b18ef-04cd-41dc-a6c7-8328da75474a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GeolocationEncodeOnClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// Show loading Pop-up 
// IsLoading = True
ZXingLibDemoClientVariables.setIsLoading(true);
// Refresh Query: GeolocationBarcode
var result = controller.geolocationBarcode$DataActRefresh(callContext);
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

return this.__geolocationEncodeOnClick$Action;
}set _geolocationEncodeOnClick$Action(value) {this.__geolocationEncodeOnClick$Action = value;
}

get _mapEventAction$Action() {if(!(this.hasOwnProperty("__mapEventAction$Action"))) {
this.__mapEventAction$Action = function (latLngIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("MapEventAction", function (span) {
if(span) {
span.setAttribute("code.function", "MapEventAction");
span.setAttribute("outsystems.function.key", "8849a563-8bc6-49b9-bd3a-d56651355d6f");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("MapEventAction");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.MainFlow.EncodeGeoLocation.MapEventAction$vars"))());
vars.value.latLngInLocal = latLngIn.clone();
// Assign coordinates
// Latitude = LatLng.Lat
model.variables.latitudeVar = OS.BuiltinFunctions.decimalToText(vars.value.latLngInLocal.latAttr);
// Longitude = LatLng.Lng
model.variables.longitudeVar = OS.BuiltinFunctions.decimalToText(vars.value.latLngInLocal.lngAttr);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__mapEventAction$Action;
}set _mapEventAction$Action(value) {this.__mapEventAction$Action = value;
}


onAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "0ff31529-9fe5-4c6e-90c6-c2da2c2938cf");
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

geolocationEncodeOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GeolocationEncodeOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GeolocationEncodeOnClick");
span.setAttribute("outsystems.function.key", "869b18ef-04cd-41dc-a6c7-8328da75474a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._geolocationEncodeOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

mapEventAction$Action(latLngIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("MapEventAction__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "MapEventAction");
span.setAttribute("outsystems.function.key", "8849a563-8bc6-49b9-bd3a-d56651355d6f");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._mapEventAction$Action, callContext, latLngIn);
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
Controller.registerVariableGroupType("ZXingLibDemo.MainFlow.EncodeGeoLocation.MapEventAction$vars", [{
name: "LatLng",
attrName: "latLngInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Record,
defaultValue: function () {
return new OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure();
},
complexType: OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure
}]);

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




