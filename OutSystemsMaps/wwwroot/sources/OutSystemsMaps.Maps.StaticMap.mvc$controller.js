import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Maps_StaticMap_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Maps.StaticMap.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
mapOnError_Callback$Action: function (mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn) {
mapObjIn = (mapObjIn === undefined) ? null : mapObjIn;
mapIdIn = (mapIdIn === undefined) ? "" : mapIdIn;
errorCodeIn = (errorCodeIn === undefined) ? "" : errorCodeIn;
extraErrorMessageIn = (extraErrorMessageIn === undefined) ? "" : extraErrorMessageIn;
return controller.executeActionInsideJSNode(controller._mapOnError_Callback$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapObjIn, OS.DataTypes.DataTypes.Object), OS.DataConversion.JSNodeParamConverter.from(mapIdIn, OS.DataTypes.DataTypes.Text), errorCodeIn, OS.DataConversion.JSNodeParamConverter.from(extraErrorMessageIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "MapOnError_Callback");
}
};
this.dataFetchDependenciesOriginal = {
obtainMapKey$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
obtainMapKey$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods
get getMapErrorByMapErrorCode$ServerAction() {if(!(this.hasOwnProperty("_getMapErrorByMapErrorCode$ServerAction"))) {
this._getMapErrorByMapErrorCode$ServerAction = function (mapErrorCodeIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetMapErrorByMapErrorCode", function (span) {
if(span) {
span.setAttribute("code.function", "GetMapErrorByMapErrorCode");
span.setAttribute("outsystems.function.key", "090ed996-d282-4f1d-9770-115596ee342d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
var inputs = {
MapErrorCode: OS.DataConversion.ServerDataConverter.to(mapErrorCodeIn, OS.DataTypes.DataTypes.Text)
};
return controller.callServerAction("GetMapErrorByMapErrorCode", "screenservices/OutSystemsMaps/Maps/StaticMap/ActionGetMapErrorByMapErrorCode", "AKO00eFUq17OMeJdpb1KGw", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.StaticMap$ActionGetMapErrorByMapErrorCode"))();
executeServerActionResult.errorMessageOut = OS.DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS.DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
}

return this._getMapErrorByMapErrorCode$ServerAction;
}set getMapErrorByMapErrorCode$ServerAction(value) {this._getMapErrorByMapErrorCode$ServerAction = value;
}


// Aggregates and Data Actions
get obtainMapKey$DataActRefresh() {if(!(this.hasOwnProperty("_obtainMapKey$DataActRefresh"))) {
this._obtainMapKey$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionObtainMapKey", "screenservices/OutSystemsMaps/Maps/StaticMap/DataActionObtainMapKey", "b6vWZHcEVp428CIoBdY18Q", function (b) {
model.variables.obtainMapKeyDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.obtainMapKeyDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.obtainMapKeyDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
return controller._obtainMapKey_OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("ObtainMapKey", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey");
span.setAttribute("outsystems.function.key", "3ca7f00f-4133-4823-b2ee-217d616b2963");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

return this._obtainMapKey$DataActRefresh;
}set obtainMapKey$DataActRefresh(value) {this._obtainMapKey$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["obtainMapKey$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1ea3e2f9-0bdd-4d4a-86e2-add67f00d8d7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: SetMapHeight
OutSystemsMapsController.default.setMapHeight$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.heightIn, callContext);
// Execute Action: InitializeProviderMap
return controller._initializeProviderMap$Action(callContext).then(function () {
// Execute Action: SubscribeEvents
controller._subscribeEvents$Action(callContext);
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

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "2390dcf5-e7cc-4fd8-acf5-665687708ea0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveMap
OutSystemsMapsController.default.removeMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "25deff53-1946-4474-b1f2-54af9c58b610");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SubscribeEvents");
callContext = controller.callContext(callContext);
var getCallbackHandlerJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlerJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandler", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandler");
span.setAttribute("outsystems.function.key", "92ca18a4-9046-4159-af29-ad2e7103351a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Maps_StaticMap_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
MapOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.StaticMap.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.mapOnError_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MapOnError_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
MapOnError_Callback: controller.clientActionProxies.mapOnError_Callback$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: MapOnError_Subscribe
OutSystemsMapsController.default.mapEventSubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.mapEvent.onError, getCallbackHandlerJSResult.value.mapOnError_CallbackOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__subscribeEvents$Action;
}set _subscribeEvents$Action(value) {this.__subscribeEvents$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "5ab888ae-c8a1-412a-9dc4-ff14a6792ac9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var getHashcode_MarkersVar = new OS.DataTypes.VariableHolder();
var serializeMarkersVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
return OS.Flow.executeAsyncFlow(function () {
// JSON Serialize: SerializeMarkers
serializeMarkersVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.staticMarkersIn, true, false);
// Execute Action: GetHashcode_Markers
getHashcode_MarkersVar.value = OutSystemsMapsController.default.getHashcode$Action(serializeMarkersVar.value.jSONOut, callContext);

// Markers change?
return OS.Flow.executeSequence(function () {
if((!(getHashcode_MarkersVar.value.hashcodeOut.equals(model.variables.markersHashcodeVar)))) {
// Execute Action: LogMarkersChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Markers has changed.", callContext);
// Execute Action: ChangeMarkers
model.flush();
return OutSystemsMapsController.default.changeMarkers$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OS.DataConversion.JSConversions.typeConvertRecordList(model.variables.staticMarkersIn, new (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_5a7ef7acf3b11e0c41074aefa2466f75Structure))(), function (source, target) {
target.locationAttr = source.locationAttr;
target.iconURLAttr = source.iconURLAttr;
target.advancedFormatAttr = source.dEPRECATED_AdvancedFormatAttr;
return target;
}), callContext).then(function () {
// Set Markers hashcode
// MarkersHashcode = GetHashcode_Markers.Hashcode
model.variables.markersHashcodeVar = getHashcode_MarkersVar.value.hashcodeOut;
});
}

}).then(function () {
// API Key changed?
return OS.Flow.executeSequence(function () {
if((((model.variables.aPIKeyIn) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr)))) {
// Execute Action: LogApiKeyChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter API Key has changed.", callContext);
// Execute Action: ChangeMapApiKey
OutSystemsMapsController.default.changeMapApiKey$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.aPIKeyIn, callContext);
// Execute Action: SetApiKey
return controller._setApiKey$Action(model.variables.aPIKeyIn, callContext);
}

});
}).then(function () {
// Localization changed?
if(((((model.variables.optionalStaticMapConfigsIn.localizationAttr.languageAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr)) || ((model.variables.optionalStaticMapConfigsIn.localizationAttr.regionAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr))))) {
// Execute Action: LogLocalizationChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Localization has changed.", callContext);
// Execute Action: ChangeMapLocalization
OutSystemsMapsController.default.changeMapLocalization$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalStaticMapConfigsIn.localizationAttr, callContext);
// Set new Localization
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalStaticMapConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalStaticMapConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalStaticMapConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalStaticMapConfigsIn.localizationAttr.regionAttr;
}

// Location changed?
if((((model.variables.centerIn) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.centerAttr)))) {
// Execute Action: LogLocationChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Location has changed.", callContext);
// Execute Action: ChangeMapLocation
OutSystemsMapsController.default.changeMapLocation$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.centerIn, callContext);
// Set new Location
// Internal_Configs.Internal_to_provider_configs.center = Center
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.centerAttr = model.variables.centerIn;
}

// Zoom changed?
if((((model.variables.optionalStaticMapConfigsIn.zoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr)))) {
// Execute Action: LogZoomChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Zoom has changed.", callContext);
// Execute Action: ChangeMapZoom
OutSystemsMapsController.default.changeMapZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalStaticMapConfigsIn.zoomAttr, callContext);
// Set new Zoom
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalStaticMapConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalStaticMapConfigsIn.zoomAttr;
}

// Height changed?
if((((model.variables.heightIn) !== (model.variables.internal_ConfigsVar.heightAttr)))) {
// Execute Action: LogHeightChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Height has changed.", callContext);
// Execute Action: SetMapHeight
OutSystemsMapsController.default.setMapHeight$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.heightIn, callContext);
// Set new height
// Internal_Configs.Height = Height
model.variables.internal_ConfigsVar.heightAttr = model.variables.heightIn;
}

// Type changed?
if((((model.variables.optionalStaticMapConfigsIn.typeAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr)))) {
// Execute Action: LogTypeChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Type has changed.", callContext);
// Execute Action: ChangeMapType
OutSystemsMapsController.default.changeMapType$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalStaticMapConfigsIn.typeAttr, callContext);
// Set new type
// Internal_Configs.Internal_to_provider_configs.type = OptionalStaticMapConfigs.Type
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr = model.variables.optionalStaticMapConfigsIn.typeAttr;
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

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _initializeProviderMap$Action() {if(!(this.hasOwnProperty("__initializeProviderMap$Action"))) {
this.__initializeProviderMap$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializeProviderMap", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderMap");
span.setAttribute("outsystems.function.key", "7f5b8099-6604-40ec-a826-c55d01f18099");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializeProviderMap");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: LogStart
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Going to instantiate Map", callContext);
// Has Maps Key?
return OS.Flow.executeSequence(function () {
if((!(((model.variables.aPIKeyIn) !== (""))))) {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isSecondRoundVar))) {
// Refresh Query: ObtainMapKey
var result = controller.obtainMapKey$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Execute Action: LogEnd_Waiting
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Waiting for API Key from server", callContext);
return OS.Flow.returnAsync();

});
}

});
}

}).then(function () {
// Execute Action: InitMap
OutSystemsMapsController.default.initMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Map instantiated", callContext);
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

return this.__initializeProviderMap$Action;
}set _initializeProviderMap$Action(value) {this.__initializeProviderMap$Action = value;
}

get _mapOnError_Callback$Action() {if(!(this.hasOwnProperty("__mapOnError_Callback$Action"))) {
this.__mapOnError_Callback$Action = function (mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("MapOnError_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "MapOnError_Callback");
span.setAttribute("outsystems.function.key", "913ceec5-0f3e-46dd-84de-92d46d52a194");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("MapOnError_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.StaticMap.MapOnError_Callback$vars"))());
vars.value.mapObjInLocal = mapObjIn;
vars.value.mapIdInLocal = mapIdIn;
vars.value.errorCodeInLocal = errorCodeIn;
vars.value.extraErrorMessageInLocal = extraErrorMessageIn;
var getMapErrorByMapErrorCodeVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: GetMapErrorByMapErrorCode
model.flush();
return controller.getMapErrorByMapErrorCode$ServerAction(vars.value.errorCodeInLocal, callContext).then(function (value) {
getMapErrorByMapErrorCodeVar.value = value;
}).then(function () {
// Trigger Event: OnError
return controller.onError$Action(vars.value.mapIdInLocal, OS.BuiltinFunctions.textToIdentifier(vars.value.errorCodeInLocal), ((((vars.value.extraErrorMessageInLocal) !== (""))) ? ((getMapErrorByMapErrorCodeVar.value.errorMessageOut + vars.value.extraErrorMessageInLocal)) : (getMapErrorByMapErrorCodeVar.value.errorMessageOut)), callContext);
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

return this.__mapOnError_Callback$Action;
}set _mapOnError_Callback$Action(value) {this.__mapOnError_Callback$Action = value;
}

get _setApiKey$Action() {if(!(this.hasOwnProperty("__setApiKey$Action"))) {
this.__setApiKey$Action = function (mapAPIKeyIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetApiKey", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "ad53d07e-7448-40da-a4cf-4a9c366cf651");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetApiKey");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.StaticMap.SetApiKey$vars"))());
vars.value.mapAPIKeyInLocal = mapAPIKeyIn;
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if(((model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr === ""))) {
// Set APIKey
// APIKey = MapAPIKey
model.variables.aPIKeyIn = vars.value.mapAPIKeyInLocal;
// Internal_Configs.Internal_to_provider_configs.apiKey = MapAPIKey
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr = vars.value.mapAPIKeyInLocal;
// Execute Action: ChangeMapApiKey
OutSystemsMapsController.default.changeMapApiKey$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.aPIKeyIn, callContext);
// Execute Action: InitializeProviderMap
return controller._initializeProviderMap$Action(callContext);
} else {
// Trigger Event: OnError
return controller.onError$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.mapErrors.lIB_InvalidApiKeyMap, "The APIKey can\'t be empty.", callContext);
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

return this.__setApiKey$Action;
}set _setApiKey$Action(value) {this.__setApiKey$Action = value;
}

get _obtainMapKey_OnAfterFetch$Action() {if(!(this.hasOwnProperty("__obtainMapKey_OnAfterFetch$Action"))) {
this.__obtainMapKey_OnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "b071278e-0ad1-407c-bce4-939b3f646c29");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ObtainMapKey_OnAfterFetch");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((((model.variables.obtainMapKeyDataAct.serverAPIKeyOut) !== ("")))) {
// IsSecondRound = True
model.variables.isSecondRoundVar = true;
// Execute Action: SetApiKey
return controller._setApiKey$Action(model.variables.obtainMapKeyDataAct.serverAPIKeyOut, callContext);
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

return this.__obtainMapKey_OnAfterFetch$Action;
}set _obtainMapKey_OnAfterFetch$Action(value) {this.__obtainMapKey_OnAfterFetch$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c4ee4372-b12b-4d8b-9c9a-0832864b8c18");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var getHashcode_MarkersVar = new OS.DataTypes.VariableHolder();
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var markersSerializeVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: LogStart
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Going to create Map", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsMapsController.default.generateUniqueId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);

// Configs_Local
// Internal_Configs.Internal_to_provider_configs.apiKey = APIKey
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr = model.variables.aPIKeyIn;
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.Height = Height
model.variables.internal_ConfigsVar.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.type = OptionalStaticMapConfigs.Type
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr = model.variables.optionalStaticMapConfigsIn.typeAttr;
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalStaticMapConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalStaticMapConfigsIn.zoomAttr;
// Internal_Configs.Internal_to_provider_configs.center = Center
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.centerAttr = model.variables.centerIn;
// Internal_Configs.Internal_to_provider_configs.height = Height
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalStaticMapConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalStaticMapConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalStaticMapConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalStaticMapConfigsIn.localizationAttr.regionAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar.internal_to_provider_configsAttr, true, false);
// Execute Action: CreateMap
OutSystemsMapsController.default.createMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.provider.google, OutSystemsMapsModel.staticEntities.mapType.staticMap, serialize_configsVar.value.jSONOut, callContext);
// Has markers?
return OS.Flow.executeSequence(function () {
if(((!(model.variables.staticMarkersIn.isEmpty)))) {
// JSON Serialize: MarkersSerialize
markersSerializeVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.staticMarkersIn, true, false);
// Execute Action: GetHashcode_Markers
getHashcode_MarkersVar.value = OutSystemsMapsController.default.getHashcode$Action(markersSerializeVar.value.jSONOut, callContext);

// Execute Action: ChangeMarkers
model.flush();
return OutSystemsMapsController.default.changeMarkers$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OS.DataConversion.JSConversions.typeConvertRecordList(model.variables.staticMarkersIn, new (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_5a7ef7acf3b11e0c41074aefa2466f75Structure))(), function (source, target) {
target.locationAttr = source.locationAttr;
target.iconURLAttr = source.iconURLAttr;
target.advancedFormatAttr = source.dEPRECATED_AdvancedFormatAttr;
return target;
}), callContext).then(function () {
// Set MarkersHashcode
// MarkersHashcode = GetHashcode_Markers.Hashcode
model.variables.markersHashcodeVar = getHashcode_MarkersVar.value.hashcodeOut;
});
} else {
// 🠓
// ⬊
}

}).then(function () {
// Execute Action: LogEnd
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Map created", callContext);
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

return this.__onInitialize$Action;
}set _onInitialize$Action(value) {this.__onInitialize$Action = value;
}


onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1ea3e2f9-0bdd-4d4a-86e2-add67f00d8d7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "2390dcf5-e7cc-4fd8-acf5-665687708ea0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDestroy$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

subscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "25deff53-1946-4474-b1f2-54af9c58b610");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._subscribeEvents$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "5ab888ae-c8a1-412a-9dc4-ff14a6792ac9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

initializeProviderMap$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializeProviderMap__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderMap");
span.setAttribute("outsystems.function.key", "7f5b8099-6604-40ec-a826-c55d01f18099");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializeProviderMap$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

mapOnError_Callback$Action(mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("MapOnError_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "MapOnError_Callback");
span.setAttribute("outsystems.function.key", "913ceec5-0f3e-46dd-84de-92d46d52a194");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._mapOnError_Callback$Action, callContext, mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setApiKey$Action(mapAPIKeyIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetApiKey__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "ad53d07e-7448-40da-a4cf-4a9c366cf651");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._setApiKey$Action, callContext, mapAPIKeyIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

obtainMapKey_OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "b071278e-0ad1-407c-bce4-939b3f646c29");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._obtainMapKey_OnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c4ee4372-b12b-4d8b-9c9a-0832864b8c18");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onError$Action() {if(!(this.hasOwnProperty("_onError$Action"))) {
this._onError$Action = function () {
return Promise.resolve();
};
}

return this._onError$Action;
}set onError$Action(value) {this._onError$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
this._onDestroyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onDestroy$Action(callContext);

};
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
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
return OutSystemsMapsController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.Maps.StaticMap$ActionGetMapErrorByMapErrorCode", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.Maps.StaticMap.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "MapOnError_Callback",
attrName: "mapOnError_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.StaticMap.MapOnError_Callback$vars", [{
name: "MapObj",
attrName: "mapObjInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "MapId",
attrName: "mapIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ErrorCode",
attrName: "errorCodeInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ExtraErrorMessage",
attrName: "extraErrorMessageInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.StaticMap.SetApiKey$vars", [{
name: "MapAPIKey",
attrName: "mapAPIKeyInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




