import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Maps_LeafletMap_mvc_controller_UnsubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Maps.LeafletMap.mvc$controller.UnsubscribeEvents.GetCallbackHandlerJS.js";
import OutSystemsMaps_Maps_LeafletMap_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Maps.LeafletMap.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
mapInitialized_Callback$Action: function (mapObjIn, mapIdIn) {
mapObjIn = (mapObjIn === undefined) ? null : mapObjIn;
mapIdIn = (mapIdIn === undefined) ? "" : mapIdIn;
return controller.executeActionInsideJSNode(controller._mapInitialized_Callback$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapObjIn, OS.DataTypes.DataTypes.Object), OS.DataConversion.JSNodeParamConverter.from(mapIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "MapInitialized_Callback");
},
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
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
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
return controller.callServerAction("GetMapErrorByMapErrorCode", "screenservices/OutSystemsMaps/Maps/LeafletMap/ActionGetMapErrorByMapErrorCode", "AKO00eFUq17OMeJdpb1KGw", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.LeafletMap$ActionGetMapErrorByMapErrorCode"))();
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _mapInitialized_Callback$Action() {if(!(this.hasOwnProperty("__mapInitialized_Callback$Action"))) {
this.__mapInitialized_Callback$Action = function (mapObjIn, mapIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("MapInitialized_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "MapInitialized_Callback");
span.setAttribute("outsystems.function.key", "1b133277-d0f2-45eb-b606-b2feaaa64a2e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("MapInitialized_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.LeafletMap.MapInitialized_Callback$vars"))());
vars.value.mapObjInLocal = mapObjIn;
vars.value.mapIdInLocal = mapIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Map_Initialized
return controller.map_Initialized$Action(vars.value.mapIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__mapInitialized_Callback$Action;
}set _mapInitialized_Callback$Action(value) {this.__mapInitialized_Callback$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "3bb784e1-f6bd-41a8-af1e-6e06e84932f1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: UnsubscribeEvents
controller._unsubscribeEvents$Action(callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "3f868fb2-f0e2-4a1e-ba06-9b27cdda3de2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Going to create Map", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsMapsController.default.generateUniqueId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);

// Configs_Local
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.Height = Height
model.variables.internal_ConfigsVar.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.offset = OptionalConfigs.Offset
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.offsetAttr = model.variables.optionalConfigsIn.offsetAttr;
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalConfigsIn.zoomAttr;
// Internal_Configs.Internal_to_provider_configs.center = Center
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.centerAttr = model.variables.centerIn;
// Internal_Configs.Internal_to_provider_configs.height = Height
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.autoZoomOnShapes = OptionalConfigs.AutoZoomOnShapes
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.autoZoomOnShapesAttr = model.variables.optionalConfigsIn.autoZoomOnShapesAttr;
// Internal_Configs.Internal_to_provider_configs.respectUserZoom = OptionalConfigs.RespectUserZoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr = model.variables.optionalConfigsIn.respectUserZoomAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar.internal_to_provider_configsAttr, true, false);
// Execute Action: CreateMap
OutSystemsMapsController.default.createMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.provider.leaflet, OutSystemsMapsModel.staticEntities.mapType.map, serialize_configsVar.value.jSONOut, callContext);
// Execute Action: SubscribeEvents
controller._subscribeEvents$Action(callContext);
// Execute Action: LogEnd
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Map created", callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onInitialize$Action;
}set _onInitialize$Action(value) {this.__onInitialize$Action = value;
}

get _unsubscribeEvents$Action() {if(!(this.hasOwnProperty("__unsubscribeEvents$Action"))) {
this.__unsubscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UnsubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "UnsubscribeEvents");
span.setAttribute("outsystems.function.key", "6218c7fb-8f74-447d-a84e-eb29fb09af09");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UnsubscribeEvents");
callContext = controller.callContext(callContext);
var getCallbackHandlerJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlerJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandler", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandler");
span.setAttribute("outsystems.function.key", "31fe6462-63c1-49f1-987c-5a01a15ef544");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Maps_LeafletMap_mvc_controller_UnsubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "UnsubscribeEvents", {
MapInitialized_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
MapOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.LeafletMap.UnsubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.mapInitialized_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MapInitialized_Callback, OS.DataTypes.DataTypes.Object);
jsNodeResult.mapOnError_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MapOnError_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
MapInitialized_Callback: controller.clientActionProxies.mapInitialized_Callback$Action,
MapOnError_Callback: controller.clientActionProxies.mapOnError_Callback$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: MapInitialized_Unsubscribe
OutSystemsMapsController.default.mapEventUnsubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.mapEvent.initialized, getCallbackHandlerJSResult.value.mapInitialized_CallbackOut, callContext);
// Execute Action: MapOnError_Unsubscribe
OutSystemsMapsController.default.mapEventUnsubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.mapEvent.onError, getCallbackHandlerJSResult.value.mapOnError_CallbackOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__unsubscribeEvents$Action;
}set _unsubscribeEvents$Action(value) {this.__unsubscribeEvents$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7ac97875-44d0-4327-9f1d-4c820eb5b234");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
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
if((((model.variables.optionalConfigsIn.zoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr)))) {
// Execute Action: LogZoomChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Zoom has changed.", callContext);
// Execute Action: ChangeMapZoom
OutSystemsMapsController.default.changeMapZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.zoomAttr, callContext);
// Set new Zoom
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalConfigsIn.zoomAttr;
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

// Offset changed?
if(((((model.variables.optionalConfigsIn.offsetAttr.offsetXAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.offsetAttr.offsetXAttr)) || ((model.variables.optionalConfigsIn.offsetAttr.offsetYAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.offsetAttr.offsetYAttr))))) {
// Execute Action: LogOffsetChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Offset has changed.", callContext);
// Execute Action: ChangeMapOffset
OutSystemsMapsController.default.changeMapOffset$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.offsetAttr, callContext);
// Set new offset
// Internal_Configs.Internal_to_provider_configs.offset = OptionalConfigs.Offset
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.offsetAttr = model.variables.optionalConfigsIn.offsetAttr;
}

// RespectUserZoom changed?
if((((model.variables.optionalConfigsIn.respectUserZoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr)))) {
// Execute Action: LogRespectUserZoom
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter RespectUserZoom has changed.", callContext);
// Execute Action: ChangeMapRespectUserZoom
OutSystemsMapsController.default.changeMapRespectUserZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.respectUserZoomAttr, callContext);
// Set new RespectUserZoom
// Internal_Configs.Internal_to_provider_configs.respectUserZoom = OptionalConfigs.RespectUserZoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr = model.variables.optionalConfigsIn.respectUserZoomAttr;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "8586aa4f-fd87-4e6d-9e8e-5ecfc66b9db7");
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
span.setAttribute("outsystems.function.key", "5be849f9-a481-41f1-a06c-43dc3cf2caf8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Maps_LeafletMap_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
MapInitialized_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
MapOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.LeafletMap.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.mapInitialized_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MapInitialized_Callback, OS.DataTypes.DataTypes.Object);
jsNodeResult.mapOnError_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MapOnError_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
MapInitialized_Callback: controller.clientActionProxies.mapInitialized_Callback$Action,
MapOnError_Callback: controller.clientActionProxies.mapOnError_Callback$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: MapInitialized_Subscribe
OutSystemsMapsController.default.mapEventSubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.mapEvent.initialized, getCallbackHandlerJSResult.value.mapInitialized_CallbackOut, callContext);
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

get _mapOnError_Callback$Action() {if(!(this.hasOwnProperty("__mapOnError_Callback$Action"))) {
this.__mapOnError_Callback$Action = function (mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("MapOnError_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "MapOnError_Callback");
span.setAttribute("outsystems.function.key", "b6b0d59d-e5c2-4327-a272-73b69cb57659");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("MapOnError_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.LeafletMap.MapOnError_Callback$vars"))());
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
return controller.onError$Action(vars.value.mapIdInLocal, vars.value.errorCodeInLocal, ((((vars.value.extraErrorMessageInLocal) !== (""))) ? ((getMapErrorByMapErrorCodeVar.value.errorMessageOut + vars.value.extraErrorMessageInLocal)) : (getMapErrorByMapErrorCodeVar.value.errorMessageOut)), callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "cb9af23c-481a-4d87-ba94-eaf7804d97b5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: SetMapHeight
OutSystemsMapsController.default.setMapHeight$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.heightIn, callContext);
// Execute Action: InitMap
OutSystemsMapsController.default.initMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}


mapInitialized_Callback$Action(mapObjIn, mapIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("MapInitialized_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "MapInitialized_Callback");
span.setAttribute("outsystems.function.key", "1b133277-d0f2-45eb-b606-b2feaaa64a2e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._mapInitialized_Callback$Action, callContext, mapObjIn, mapIdIn);
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
span.setAttribute("outsystems.function.key", "3bb784e1-f6bd-41a8-af1e-6e06e84932f1");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "3f868fb2-f0e2-4a1e-ba06-9b27cdda3de2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

unsubscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UnsubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UnsubscribeEvents");
span.setAttribute("outsystems.function.key", "6218c7fb-8f74-447d-a84e-eb29fb09af09");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._unsubscribeEvents$Action, callContext);
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
span.setAttribute("outsystems.function.key", "7ac97875-44d0-4327-9f1d-4c820eb5b234");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8586aa4f-fd87-4e6d-9e8e-5ecfc66b9db7");
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

mapOnError_Callback$Action(mapObjIn, mapIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("MapOnError_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "MapOnError_Callback");
span.setAttribute("outsystems.function.key", "b6b0d59d-e5c2-4327-a272-73b69cb57659");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "cb9af23c-481a-4d87-ba94-eaf7804d97b5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
} finally {
if(span) {
span.end();
}

}

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

get map_Initialized$Action() {if(!(this.hasOwnProperty("_map_Initialized$Action"))) {
this._map_Initialized$Action = function () {
return Promise.resolve();
};
}

return this._map_Initialized$Action;
}set map_Initialized$Action(value) {this._map_Initialized$Action = value;
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
Controller.registerVariableGroupType("OutSystemsMaps.Maps.LeafletMap$ActionGetMapErrorByMapErrorCode", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.Maps.LeafletMap.MapInitialized_Callback$vars", [{
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
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.LeafletMap.UnsubscribeEvents$getCallbackHandlerJSResult", [{
name: "MapInitialized_Callback",
attrName: "mapInitialized_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "MapOnError_Callback",
attrName: "mapOnError_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.LeafletMap.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "MapInitialized_Callback",
attrName: "mapInitialized_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "MapOnError_Callback",
attrName: "mapOnError_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.LeafletMap.MapOnError_Callback$vars", [{
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

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




