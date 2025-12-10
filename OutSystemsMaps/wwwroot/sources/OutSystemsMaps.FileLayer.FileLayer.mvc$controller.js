import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_FileLayer_FileLayer_mvc_controller_OnDestroy_GetCallbackHandlerJS from "./OutSystemsMaps.FileLayer.FileLayer.mvc$controller.OnDestroy.GetCallbackHandlerJS.js";
import OutSystemsMaps_FileLayer_FileLayer_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.FileLayer.FileLayer.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
callback_Event$Action: function (mapWidgetIdIn, fileLayerIdIn, latLngIn, featureDataIn) {
mapWidgetIdIn = (mapWidgetIdIn === undefined) ? "" : mapWidgetIdIn;
fileLayerIdIn = (fileLayerIdIn === undefined) ? "" : fileLayerIdIn;
latLngIn = (latLngIn === undefined) ? "" : latLngIn;
featureDataIn = (featureDataIn === undefined) ? "" : featureDataIn;
return controller.executeActionInsideJSNode(controller._callback_Event$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(fileLayerIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(latLngIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(featureDataIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Callback_Event");
}
};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "225178da-88c2-47a9-8729-6d32117b8579");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
var getCallbackHandlerJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlerJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandler", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandler");
span.setAttribute("outsystems.function.key", "643a829c-ebf2-4c7e-acae-6bbd0a2c5b1a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_FileLayer_FileLayer_mvc_controller_OnDestroy_GetCallbackHandlerJS, "GetCallbackHandler", "OnDestroy", {
OnClick_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.OnDestroy$getCallbackHandlerJSResult"))();
jsNodeResult.onClick_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnClick_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
Callback_Event: controller.clientActionProxies.callback_Event$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: FileLayerEventUnsubscribe
OutSystemsMapsController.default.fileLayerEventUnsubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.fileLayerEvent.onClick, getCallbackHandlerJSResult.value.onClick_CallbackOut, callContext);
// Execute Action: RemoveFileLayer
OutSystemsMapsController.default.removeFileLayer$Action(model.variables.internal_FileLayer_ConfigsVar.uniqueIdAttr, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7ec8f1e9-80dd-4fde-bcaf-94e02975b19d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// LayerURL changed?
if((((model.variables.layerURLIn) !== (model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.layerUrlAttr)))) {
// Execute Action: LogLayerURLChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter LayerURL has changed.", callContext);
// Execute Action: ChangeFileLayerLayerURL
OutSystemsMapsController.default.changeFileLayerLayerURL$Action(model.variables.internal_FileLayer_ConfigsVar.uniqueIdAttr, model.variables.layerURLIn, callContext);
// Set LayerURL hashcode
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.layerUrl = LayerURL
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.layerUrlAttr = model.variables.layerURLIn;
}

// SuppressPopups changed?
if((((model.variables.optionalConfigsIn.suppressPopupsAttr) !== (model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.suppressPopupsAttr)))) {
// Execute Action: LogSuppressPopupsChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter SuppressPopups has changed.", callContext);
// Execute Action: ChangeFileLayerSuppressPopups
OutSystemsMapsController.default.changeFileLayerSuppressPopups$Action(model.variables.internal_FileLayer_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.suppressPopupsAttr, callContext);
// Set SuppressPopups
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.suppressPopups = OptionalConfigs.SuppressPopups
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.suppressPopupsAttr = model.variables.optionalConfigsIn.suppressPopupsAttr;
}

// PreserveViewport changed?
if((((model.variables.optionalConfigsIn.preserveViewportAttr) !== (model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.preserveViewportAttr)))) {
// Execute Action: LogPreserveViewportChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter PreserveViewport has changed.", callContext);
// Execute Action: ChangeFileLayerPreserveViewport
OutSystemsMapsController.default.changeFileLayerPreserveViewport$Action(model.variables.internal_FileLayer_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.preserveViewportAttr, callContext);
// Set PreserveViewport
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.preserveViewport = OptionalConfigs.PreserveViewport
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.preserveViewportAttr = model.variables.optionalConfigsIn.preserveViewportAttr;
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
span.setAttribute("outsystems.function.key", "858252ee-c02e-42a9-bc8c-e81a9ffb1f00");
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
span.setAttribute("outsystems.function.key", "1fabe20a-a7fa-4734-a7c2-adc38bcc1396");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_FileLayer_FileLayer_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
OnClick_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.onClick_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnClick_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
Callback_Event: controller.clientActionProxies.callback_Event$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: FileLayerOnClick_Subscribe
OutSystemsMapsController.default.fileLayerEventSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.fileLayerEvent.onClick, getCallbackHandlerJSResult.value.onClick_CallbackOut, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "85e71f01-54cd-44da-87a1-7d82108e0385");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: CreateFileLayer
OutSystemsMapsController.default.createFileLayer$Action(model.variables.uniqueIdVar, model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr, callContext);
// Execute Action: SubscribeEvents
controller._subscribeEvents$Action(callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "b6ea7448-ab2d-4c96-b709-4a5da4527b7c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsMapsController.default.generateUniqueId$Action("", callContext);

// UniqueId = GenerateUniqueId.Unique_ID
model.variables.uniqueIdVar = generateUniqueIdVar.value.unique_IDOut;
// Set configurations
// Internal_FileLayer_Configs.UniqueId = UniqueId
model.variables.internal_FileLayer_ConfigsVar.uniqueIdAttr = model.variables.uniqueIdVar;
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.layerUrl = LayerURL
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.layerUrlAttr = model.variables.layerURLIn;
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.suppressPopups = OptionalConfigs.SuppressPopups
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.suppressPopupsAttr = model.variables.optionalConfigsIn.suppressPopupsAttr;
// Internal_FileLayer_Configs.Internal_to_provider_fileLayer_configs.preserveViewport = OptionalConfigs.PreserveViewport
model.variables.internal_FileLayer_ConfigsVar.internal_to_provider_fileLayer_configsAttr.preserveViewportAttr = model.variables.optionalConfigsIn.preserveViewportAttr;
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

get _callback_Event$Action() {if(!(this.hasOwnProperty("__callback_Event$Action"))) {
this.__callback_Event$Action = function (mapWidgetIdIn, fileLayerIdIn, latLngIn, featureDataIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Callback_Event", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "e755d6d2-a0e0-4560-a890-509938fdcd04");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Callback_Event");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.Callback_Event$vars"))());
vars.value.mapWidgetIdInLocal = mapWidgetIdIn;
vars.value.fileLayerIdInLocal = fileLayerIdIn;
vars.value.latLngInLocal = latLngIn;
vars.value.featureDataInLocal = featureDataIn;
var jSONDeserializeCoordinatesVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType(OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: JSONDeserializeCoordinates
jSONDeserializeCoordinatesVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.latLngInLocal, OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure, false);
// Trigger Event: OnClick
return controller.onClick$Action(vars.value.mapWidgetIdInLocal, vars.value.fileLayerIdInLocal, jSONDeserializeCoordinatesVar.value.dataOut, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__callback_Event$Action;
}set _callback_Event$Action(value) {this.__callback_Event$Action = value;
}


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "225178da-88c2-47a9-8729-6d32117b8579");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7ec8f1e9-80dd-4fde-bcaf-94e02975b19d");
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
span.setAttribute("outsystems.function.key", "858252ee-c02e-42a9-bc8c-e81a9ffb1f00");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "85e71f01-54cd-44da-87a1-7d82108e0385");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "b6ea7448-ab2d-4c96-b709-4a5da4527b7c");
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

callback_Event$Action(mapWidgetIdIn, fileLayerIdIn, latLngIn, featureDataIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Callback_Event__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "e755d6d2-a0e0-4560-a890-509938fdcd04");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._callback_Event$Action, callContext, mapWidgetIdIn, fileLayerIdIn, latLngIn, featureDataIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onClick$Action() {if(!(this.hasOwnProperty("_onClick$Action"))) {
this._onClick$Action = function () {
return Promise.resolve();
};
}

return this._onClick$Action;
}set onClick$Action(value) {this._onClick$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.OnDestroy$getCallbackHandlerJSResult", [{
name: "OnClick_Callback",
attrName: "onClick_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "OnClick_Callback",
attrName: "onClick_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.FileLayer.FileLayer.Callback_Event$vars", [{
name: "MapWidgetId",
attrName: "mapWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FileLayerId",
attrName: "fileLayerIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "LatLng",
attrName: "latLngInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FeatureData",
attrName: "featureDataInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




