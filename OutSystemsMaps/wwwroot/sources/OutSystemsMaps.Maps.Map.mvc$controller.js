import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Maps_Map_mvc_controller_UnsubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Maps.Map.mvc$controller.UnsubscribeEvents.GetCallbackHandlerJS.js";
import OutSystemsMaps_Maps_Map_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Maps.Map.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

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
this.dataFetchDependenciesOriginal = {
getServerAPIKey$DataActRefresh: -1,
getApiVersion$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getServerAPIKey$DataActRefresh: [],
getApiVersion$DataActRefresh: []
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
return controller.callServerAction("GetMapErrorByMapErrorCode", "screenservices/OutSystemsMaps/Maps/Map/ActionGetMapErrorByMapErrorCode", "AKO00eFUq17OMeJdpb1KGw", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map$ActionGetMapErrorByMapErrorCode"))();
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
get getServerAPIKey$DataActRefresh() {if(!(this.hasOwnProperty("_getServerAPIKey$DataActRefresh"))) {
this._getServerAPIKey$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetServerAPIKey", "screenservices/OutSystemsMaps/Maps/Map/DataActionGetServerAPIKey", "WFv389nwOUTdQT3xqOYXCQ", function (b) {
model.variables.getServerAPIKeyDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getServerAPIKeyDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getServerAPIKeyDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
return controller._obtainMapKey_OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetServerAPIKey", function (span) {
if(span) {
span.setAttribute("code.function", "GetServerAPIKey");
span.setAttribute("outsystems.function.key", "0a3e8cdf-9085-4f8f-9bee-c3db7b7322f1");
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

return this._getServerAPIKey$DataActRefresh;
}set getServerAPIKey$DataActRefresh(value) {this._getServerAPIKey$DataActRefresh = value;
}

get getApiVersion$DataActRefresh() {if(!(this.hasOwnProperty("_getApiVersion$DataActRefresh"))) {
this._getApiVersion$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApiVersion", "screenservices/OutSystemsMaps/Maps/Map/DataActionGetApiVersion", "W7oDqG0MFaHlqkUIo+i8Sw", function (b) {
model.variables.getApiVersionDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApiVersionDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getApiVersionDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._obtainMapAPIVersion_OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetApiVersion", function (span) {
if(span) {
span.setAttribute("code.function", "GetApiVersion");
span.setAttribute("outsystems.function.key", "760be42d-b595-4c33-a3f2-7793d79448f2");
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

return this._getApiVersion$DataActRefresh;
}set getApiVersion$DataActRefresh(value) {this._getApiVersion$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getServerAPIKey$DataActRefresh", "getApiVersion$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _obtainMapKey_OnAfterFetch$Action() {if(!(this.hasOwnProperty("__obtainMapKey_OnAfterFetch$Action"))) {
this.__obtainMapKey_OnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "034f27d9-374c-444a-a028-b25f0d908a09");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ObtainMapKey_OnAfterFetch");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// IsSecondRound = True
model.variables.isSecondRoundVar = true;
// Execute Action: SetApiKey
return controller._setApiKey$Action(model.variables.getServerAPIKeyDataAct.serverAPIKeyOut, callContext).then(function () {
// Execute Action: SetProviderVersion
OutSystemsMapsController.default.setProviderVersion$Action(OutSystemsMapsModel.staticEntities.provider.google, model.variables.getServerAPIKeyDataAct.googleMapsApiVersionOut, false, callContext);
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

get _obtainMapAPIVersion_OnAfterFetch$Action() {if(!(this.hasOwnProperty("__obtainMapAPIVersion_OnAfterFetch$Action"))) {
this.__obtainMapAPIVersion_OnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ObtainMapAPIVersion_OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapAPIVersion_OnAfterFetch");
span.setAttribute("outsystems.function.key", "06e67485-2d13-4726-a07d-e34e88ef8a85");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ObtainMapAPIVersion_OnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: SetProviderVersion
OutSystemsMapsController.default.setProviderVersion$Action(OutSystemsMapsModel.staticEntities.provider.google, model.variables.getApiVersionDataAct.googleMapsApiVersionOut, false, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__obtainMapAPIVersion_OnAfterFetch$Action;
}set _obtainMapAPIVersion_OnAfterFetch$Action(value) {this.__obtainMapAPIVersion_OnAfterFetch$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "13bb1d52-c54e-41f3-895f-42ca1bee5aa4");
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

get _mapInitialized_Callback$Action() {if(!(this.hasOwnProperty("__mapInitialized_Callback$Action"))) {
this.__mapInitialized_Callback$Action = function (mapObjIn, mapIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("MapInitialized_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "MapInitialized_Callback");
span.setAttribute("outsystems.function.key", "3ab584f7-8b0e-473b-b314-9cad1324e568");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("MapInitialized_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map.MapInitialized_Callback$vars"))());
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

get _unsubscribeEvents$Action() {if(!(this.hasOwnProperty("__unsubscribeEvents$Action"))) {
this.__unsubscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UnsubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "UnsubscribeEvents");
span.setAttribute("outsystems.function.key", "6710eca3-79f9-4074-a932-0a7e135c9210");
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
span.setAttribute("outsystems.function.key", "8ac3c1e6-ea4d-4324-a662-d3a3b87cde81");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Maps_Map_mvc_controller_UnsubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "UnsubscribeEvents", {
MapInitialized_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
MapOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map.UnsubscribeEvents$getCallbackHandlerJSResult"))();
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

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "75523012-00f9-440f-8e64-32b323ce269e");
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
span.setAttribute("outsystems.function.key", "ea0ee88b-b67c-4c79-b357-5e82d58aca31");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Maps_Map_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
MapInitialized_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
MapOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map.SubscribeEvents$getCallbackHandlerJSResult"))();
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

get _setApiKey$Action() {if(!(this.hasOwnProperty("__setApiKey$Action"))) {
this.__setApiKey$Action = function (mapAPIKeyIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetApiKey", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "84be481c-1cff-4183-94c0-c5b4e4005b8c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetApiKey");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map.SetApiKey$vars"))());
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "9d105f54-8427-45de-9c8c-6ee19f4a457b");
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
// Internal_Configs.Internal_to_provider_configs.apiKey = APIKey
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr = model.variables.aPIKeyIn;
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.Internal_to_provider_configs.advancedFormat = OptionalConfigs.DEPRECATED_AdvancedFormat
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.advancedFormatAttr = model.variables.optionalConfigsIn.dEPRECATED_AdvancedFormatAttr;
// Internal_Configs.Height = Height
model.variables.internal_ConfigsVar.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.offset = OptionalConfigs.Offset
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.offsetAttr = model.variables.optionalConfigsIn.offsetAttr;
// Internal_Configs.Internal_to_provider_configs.showTraffic = OptionalConfigs.ShowTraffic
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.showTrafficAttr = model.variables.optionalConfigsIn.showTrafficAttr;
// Internal_Configs.Internal_to_provider_configs.style = If
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.styleAttr = (((model.variables.optionalConfigsIn.dEPRECATED_StyleAttr === OS.BuiltinFunctions.nullIdentifier())) ? (OutSystemsMapsModel.staticEntities.style.standard) : (model.variables.optionalConfigsIn.dEPRECATED_StyleAttr));
// Internal_Configs.Internal_to_provider_configs.type = If
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr = (((model.variables.optionalConfigsIn.typeAttr === OS.BuiltinFunctions.nullTextIdentifier())) ? (OutSystemsMapsModel.staticEntities.type.roadmap) : (model.variables.optionalConfigsIn.typeAttr));
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalConfigsIn.zoomAttr;
// Internal_Configs.Internal_to_provider_configs.center = Center
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.centerAttr = model.variables.centerIn;
// Internal_Configs.Internal_to_provider_configs.height = Height
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.heightAttr = model.variables.heightIn;
// Internal_Configs.Internal_to_provider_configs.markerClusterer = OptionalConfigs.MarkerClusterer
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr = OS.DataConversion.JSConversions.typeConvertRecord(model.variables.optionalConfigsIn.markerClustererAttr, new OutSystemsMapsModel.ST_9f8ac95fe4e47e327de12de1b56bed45Structure(), function (source, target) {
target.activeAttr = source.activeAttr;
target.maxZoomAttr = source.maxZoomAttr;
target.zoomOnClickAttr = source.zoomOnClickAttr;
target.minClusterSizeAttr = source.minClusterSizeAttr;
return target;
});
// Internal_Configs.Internal_to_provider_configs.autoZoomOnShapes = OptionalConfigs.AutoZoomOnShapes
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.autoZoomOnShapesAttr = model.variables.optionalConfigsIn.autoZoomOnShapesAttr;
// Internal_Configs.Internal_to_provider_configs.respectUserZoom = OptionalConfigs.RespectUserZoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr = model.variables.optionalConfigsIn.respectUserZoomAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalConfigsIn.localizationAttr.regionAttr;
// Internal_Configs.Internal_to_provider_configs.useAdvancedMarkers = OptionalConfigs.UseAdvancedMarkers
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.useAdvancedMarkersAttr = model.variables.optionalConfigsIn.useAdvancedMarkersAttr;
// Internal_Configs.Internal_to_provider_configs.mapStyleId = OptionalConfigs.MapStyleId
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.mapStyleIdAttr = model.variables.optionalConfigsIn.mapStyleIdAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar.internal_to_provider_configsAttr, true, false);
// Execute Action: CreateMap
OutSystemsMapsController.default.createMap$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.provider.google, OutSystemsMapsModel.staticEntities.mapType.map, serialize_configsVar.value.jSONOut, callContext);
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

get _initializeProviderMap$Action() {if(!(this.hasOwnProperty("__initializeProviderMap$Action"))) {
this.__initializeProviderMap$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializeProviderMap", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderMap");
span.setAttribute("outsystems.function.key", "c227e8a0-1504-4477-a0e2-4da3fa4ce7bc");
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
// Refresh Query: GetServerAPIKey
var result = controller.getServerAPIKey$DataActRefresh(callContext);
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
// Has Maps Key?
return OS.Flow.executeSequence(function () {
if((((model.variables.aPIKeyIn) !== ("")))) {
// Refresh Query: GetApiVersion
var result = controller.getApiVersion$DataActRefresh(callContext);
model.flush();
return result;
}

});
}).then(function () {
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
span.setAttribute("outsystems.function.key", "c51b35ae-ef94-4927-91b3-beb5ffb16964");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("MapOnError_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Maps.Map.MapOnError_Callback$vars"))());
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "edcce4d8-5aca-4d5a-b76f-98bb58f4fd30");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
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

}).then(function () {
// Localization changed?
if(((((model.variables.optionalConfigsIn.localizationAttr.languageAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr)) || ((model.variables.optionalConfigsIn.localizationAttr.regionAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr))))) {
// Execute Action: LogLocalizationChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Localization has changed.", callContext);
// Execute Action: ChangeMapLocalization
OutSystemsMapsController.default.changeMapLocalization$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.localizationAttr, callContext);
// Set new Localization
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalConfigsIn.localizationAttr.regionAttr;
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
if((((model.variables.optionalConfigsIn.zoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr)))) {
// Execute Action: LogZoomChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Zoom has changed.", callContext);
// Execute Action: ChangeMapZoom
OutSystemsMapsController.default.changeMapZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.zoomAttr, callContext);
// Set new Zoom
// Internal_Configs.Internal_to_provider_configs.zoom = OptionalConfigs.Zoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.zoomAttr = model.variables.optionalConfigsIn.zoomAttr;
}

// AutoZoomOnShapes changed?
if((((model.variables.optionalConfigsIn.autoZoomOnShapesAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.autoZoomOnShapesAttr)))) {
// Execute Action: LogAutoZoomOnShapesChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AutoZoomOnShapes has changed.", callContext);
// Execute Action: ChangeMapAutoZoomOnShapes
OutSystemsMapsController.default.changeMapAutoZoomOnShape$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.autoZoomOnShapesAttr, callContext);
// Set new Zoom
// Internal_Configs.Internal_to_provider_configs.autoZoomOnShapes = OptionalConfigs.AutoZoomOnShapes
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.autoZoomOnShapesAttr = model.variables.optionalConfigsIn.autoZoomOnShapesAttr;
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

// Style changed?
if((((model.variables.optionalConfigsIn.dEPRECATED_StyleAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.styleAttr)))) {
// Execute Action: LogStyleChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Style has changed.", callContext);
// Execute Action: ChangeMapStyle
OutSystemsMapsController.default.changeMapStyle$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.dEPRECATED_StyleAttr, callContext);
// Set new style
// Internal_Configs.Internal_to_provider_configs.style = OptionalConfigs.DEPRECATED_Style
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.styleAttr = model.variables.optionalConfigsIn.dEPRECATED_StyleAttr;
}

// Type changed?
if((((model.variables.optionalConfigsIn.typeAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr)))) {
// Execute Action: LogTypeChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Type has changed.", callContext);
// Execute Action: ChangeMapType
OutSystemsMapsController.default.changeMapType$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.typeAttr, callContext);
// Set new type
// Internal_Configs.Internal_to_provider_configs.type = OptionalConfigs.Type
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.typeAttr = model.variables.optionalConfigsIn.typeAttr;
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

// ShowTraffic changed?
if((((model.variables.optionalConfigsIn.showTrafficAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.showTrafficAttr)))) {
// Execute Action: LogShowTrafficChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter ShowTraffic has changed.", callContext);
// Execute Action: ChangeMapShowTraffic
OutSystemsMapsController.default.changeMapShowTraffic$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.showTrafficAttr, callContext);
// Set show traffic
// Internal_Configs.Internal_to_provider_configs.showTraffic = OptionalConfigs.ShowTraffic
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.showTrafficAttr = model.variables.optionalConfigsIn.showTrafficAttr;
}

// AdvancedFormat changed?
if((((model.variables.optionalConfigsIn.dEPRECATED_AdvancedFormatAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.advancedFormatAttr)))) {
// Execute Action: LogAdvancedFormatChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AdvancedFormat has changed.", callContext);
// Execute Action: ChangeMapAdvancedFormat
OutSystemsMapsController.default.changeMapAdvancedFormat$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.dEPRECATED_AdvancedFormatAttr, callContext);
// Set advanced format
// Internal_Configs.Internal_to_provider_configs.advancedFormat = OptionalConfigs.DEPRECATED_AdvancedFormat
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.advancedFormatAttr = model.variables.optionalConfigsIn.dEPRECATED_AdvancedFormatAttr;
}

// MarkerClusterer Active changed?
if((((model.variables.optionalConfigsIn.markerClustererAttr.activeAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.activeAttr)))) {
// Execute Action: LogMarkerClusteringChangeActive
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MarkerClustering Active has changed.", callContext);
// Execute Action: ChangeMapMarkerClusteringActive
OutSystemsMapsController.default.changeMapMarkerClusteringActive$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.markerClustererAttr.activeAttr, callContext);
// Set new MarkerClustering Active
// Internal_Configs.Internal_to_provider_configs.markerClusterer.Active = OptionalConfigs.MarkerClusterer.Active
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.activeAttr = model.variables.optionalConfigsIn.markerClustererAttr.activeAttr;
}

// MarkerClusterer MaxZoom changed?
if((((model.variables.optionalConfigsIn.markerClustererAttr.maxZoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.maxZoomAttr)))) {
// Execute Action: LogMarkerClusteringChangeMaxZoom
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MarkerClustering MaxZoom has changed.", callContext);
// Execute Action: ChangeMapMarkerClusteringMaxZoom
OutSystemsMapsController.default.changeMapMarkerClusteringMaxZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.markerClustererAttr.maxZoomAttr, callContext);
// Set new MarkerClustering MaxZoom
// Internal_Configs.Internal_to_provider_configs.markerClusterer.MaxZoom = OptionalConfigs.MarkerClusterer.MaxZoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.maxZoomAttr = model.variables.optionalConfigsIn.markerClustererAttr.maxZoomAttr;
}

// MarkerClusterer ZoomOnClick changed?
if((((model.variables.optionalConfigsIn.markerClustererAttr.zoomOnClickAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.zoomOnClickAttr)))) {
// Execute Action: LogMarkerClusteringChangeZoomOnClick
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MarkerClustering ZoomOnClick has changed.", callContext);
// Execute Action: ChangeMapMarkerClusteringZoomOnClickoomOnClick
OutSystemsMapsController.default.changeMapMarkerClusteringZoomOnClick$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.markerClustererAttr.zoomOnClickAttr, callContext);
// Set new MarkerClustering ZoomOnClick
// Internal_Configs.Internal_to_provider_configs.markerClusterer.ZoomOnClick = OptionalConfigs.MarkerClusterer.ZoomOnClick
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.zoomOnClickAttr = model.variables.optionalConfigsIn.markerClustererAttr.zoomOnClickAttr;
}

// MarkerClusterer changed?
if((((model.variables.optionalConfigsIn.markerClustererAttr.minClusterSizeAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.minClusterSizeAttr)))) {
// Execute Action: LogMarkerClusteringChangeMinClusterSize
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MarkerClustering MinClusterSize has changed.", callContext);
// Execute Action: ChangeMapMarkerClusteringMinClusterSize
OutSystemsMapsController.default.changeMapMarkerClusteringMinClusterSize$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.markerClustererAttr.minClusterSizeAttr, callContext);
// Set new MarkerClustering MinClusterSize
// Internal_Configs.Internal_to_provider_configs.markerClusterer.MinClusterSize = OptionalConfigs.MarkerClusterer.MinClusterSize
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.markerClustererAttr.minClusterSizeAttr = model.variables.optionalConfigsIn.markerClustererAttr.minClusterSizeAttr;
}

// RespectUserZoom  changed?
if((((model.variables.optionalConfigsIn.respectUserZoomAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr)))) {
// Execute Action: LogRespectUserZoom
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter RespectUserZoom has changed.", callContext);
// Execute Action: ChangeMapRespectUserZoom
OutSystemsMapsController.default.changeMapRespectUserZoom$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.respectUserZoomAttr, callContext);
// Set new RespectUserZoom
// Internal_Configs.Internal_to_provider_configs.respectUserZoom = OptionalConfigs.RespectUserZoom
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.respectUserZoomAttr = model.variables.optionalConfigsIn.respectUserZoomAttr;
}

// UseAdvancedMarkers  changed?
if((((model.variables.optionalConfigsIn.useAdvancedMarkersAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.useAdvancedMarkersAttr)))) {
// Execute Action: LogUseAdvancedMarkers
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter UseAdvancedMarkers has changed.", callContext);
// Execute Action: ChangeMapUseAdvancedMarkers
OutSystemsMapsController.default.changeMapUseAdvancedMarkers$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.useAdvancedMarkersAttr, callContext);
// Set new UseAdvancedMarkers
// Internal_Configs.Internal_to_provider_configs.useAdvancedMarkers = OptionalConfigs.UseAdvancedMarkers
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.useAdvancedMarkersAttr = model.variables.optionalConfigsIn.useAdvancedMarkersAttr;
}

// MapStyleId Changed?
if((((model.variables.optionalConfigsIn.mapStyleIdAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.mapStyleIdAttr)))) {
// Execute Action: LogMapStyleId
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MapStyleId has changed.", callContext);
// Execute Action: ChangeMapStyleId
OutSystemsMapsController.default.changeMapStyleId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.mapStyleIdAttr, callContext);
// Set new MapStyleId
// Internal_Configs.Internal_to_provider_configs.mapStyleId = OptionalConfigs.MapStyleId
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.mapStyleIdAttr = model.variables.optionalConfigsIn.mapStyleIdAttr;
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f0d66ab4-4c62-4b99-8819-22468a3d6420");
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
return controller._initializeProviderMap$Action(callContext);
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


obtainMapKey_OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "034f27d9-374c-444a-a028-b25f0d908a09");
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

obtainMapAPIVersion_OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ObtainMapAPIVersion_OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapAPIVersion_OnAfterFetch");
span.setAttribute("outsystems.function.key", "06e67485-2d13-4726-a07d-e34e88ef8a85");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._obtainMapAPIVersion_OnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "13bb1d52-c54e-41f3-895f-42ca1bee5aa4");
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

mapInitialized_Callback$Action(mapObjIn, mapIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("MapInitialized_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "MapInitialized_Callback");
span.setAttribute("outsystems.function.key", "3ab584f7-8b0e-473b-b314-9cad1324e568");
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

unsubscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UnsubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UnsubscribeEvents");
span.setAttribute("outsystems.function.key", "6710eca3-79f9-4074-a932-0a7e135c9210");
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

subscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "75523012-00f9-440f-8e64-32b323ce269e");
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

setApiKey$Action(mapAPIKeyIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetApiKey__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "84be481c-1cff-4183-94c0-c5b4e4005b8c");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "9d105f54-8427-45de-9c8c-6ee19f4a457b");
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

initializeProviderMap$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializeProviderMap__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderMap");
span.setAttribute("outsystems.function.key", "c227e8a0-1504-4477-a0e2-4da3fa4ce7bc");
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
span.setAttribute("outsystems.function.key", "c51b35ae-ef94-4927-91b3-beb5ffb16964");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "edcce4d8-5aca-4d5a-b76f-98bb58f4fd30");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f0d66ab4-4c62-4b99-8819-22468a3d6420");
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

get map_Initialized$Action() {if(!(this.hasOwnProperty("_map_Initialized$Action"))) {
this._map_Initialized$Action = function () {
return Promise.resolve();
};
}

return this._map_Initialized$Action;
}set map_Initialized$Action(value) {this._map_Initialized$Action = value;
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
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map$ActionGetMapErrorByMapErrorCode", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map.MapInitialized_Callback$vars", [{
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
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map.UnsubscribeEvents$getCallbackHandlerJSResult", [{
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
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map.SubscribeEvents$getCallbackHandlerJSResult", [{
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
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map.SetApiKey$vars", [{
name: "MapAPIKey",
attrName: "mapAPIKeyInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Maps.Map.MapOnError_Callback$vars", [{
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




