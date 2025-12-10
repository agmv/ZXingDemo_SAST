import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Marker_Marker_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Marker.Marker.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
callback_Event$Action: function (mapWidgetIdIn, markerWidgetIdIn, eventNameIn, latLngIn) {
mapWidgetIdIn = (mapWidgetIdIn === undefined) ? "" : mapWidgetIdIn;
markerWidgetIdIn = (markerWidgetIdIn === undefined) ? "" : markerWidgetIdIn;
eventNameIn = (eventNameIn === undefined) ? "" : eventNameIn;
latLngIn = (latLngIn === undefined) ? "" : latLngIn;
return controller.executeActionInsideJSNode(controller._callback_Event$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(markerWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(eventNameIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(latLngIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
span.setAttribute("outsystems.function.key", "09437078-b62a-4a7c-8fe6-658c533cac66");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
var removeMarkerVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: RemoveMarker
model.flush();
return OutSystemsMapsController.default.removeMarker$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, callContext).then(function (value) {
removeMarkerVar.value = value;
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

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _callback_Event$Action() {if(!(this.hasOwnProperty("__callback_Event$Action"))) {
this.__callback_Event$Action = function (mapWidgetIdIn, markerWidgetIdIn, eventNameIn, latLngIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Callback_Event", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "4000bff2-7064-40d1-a7da-7e003cbf0fa0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Callback_Event");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Marker.Marker.Callback_Event$vars"))());
vars.value.mapWidgetIdInLocal = mapWidgetIdIn;
vars.value.markerWidgetIdInLocal = markerWidgetIdIn;
vars.value.eventNameInLocal = eventNameIn;
vars.value.latLngInLocal = latLngIn;
var coordsDeserializeVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType(OutSystemsMapsModel.RC_df0786951d2357ea5f13ac02dccd68c2))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: CoordsDeserialize
coordsDeserializeVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.latLngInLocal, OutSystemsMapsModel.RC_df0786951d2357ea5f13ac02dccd68c2, false);
// Trigger Event: OnClick
return controller.onClick$Action(vars.value.mapWidgetIdInLocal, vars.value.markerWidgetIdInLocal, OS.DataConversion.JSConversions.typeConvertRecord(coordsDeserializeVar.value.dataOut, new OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure(), function (source, target) {
target.latAttr = source.latAttr;
target.lngAttr = source.lngAttr;
return target;
}), callContext);
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

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "7018994a-1747-4c8e-a14b-c6cbc9b860dc");
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
span.setAttribute("outsystems.function.key", "6a68ab7e-1519-46f9-9ee7-646a9e7a949b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Marker_Marker_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
OnClick_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Marker.Marker.SubscribeEvents$getCallbackHandlerJSResult"))();
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
// Execute Action: MapInitialized_Subscribe
OutSystemsMapsController.default.markerEventSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.markerEvent.onClick, getCallbackHandlerJSResult.value.onClick_CallbackOut, callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ac09377e-f5b0-4853-9bd2-8a1fef12e03d");
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
// Internal_Marker_Configs.UniqueId = UniqueId
model.variables.internal_Marker_ConfigsVar.uniqueIdAttr = model.variables.uniqueIdVar;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.location = Position
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.locationAttr = model.variables.positionIn;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconUrl = OptionalConfigs.IconURL
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconUrlAttr = model.variables.optionalConfigsIn.iconURLAttr;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.title = OptionalConfigs.Title
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.titleAttr = model.variables.optionalConfigsIn.titleAttr;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.allowDrag = OptionalConfigs.AllowDrag
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.allowDragAttr = model.variables.optionalConfigsIn.allowDragAttr;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.label = OptionalConfigs.Label
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.labelAttr = model.variables.optionalConfigsIn.labelAttr;
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconWidth = OptionalConfigs.IconSize.Width
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconWidthAttr = (model.variables.optionalConfigsIn.iconSizeAttr.widthAttr).toString();
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconHeight = OptionalConfigs.IconSize.Height
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconHeightAttr = (model.variables.optionalConfigsIn.iconSizeAttr.heightAttr).toString();
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c4dc1550-d087-4bad-8cde-48565b0be09b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: CreateMarkerByUniqueID
OutSystemsMapsController.default.createMarkerByUniqueID$Action(model.variables.uniqueIdVar, model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr, OutSystemsMapsModel.staticEntities.markerType.marker, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "f18d6749-511a-4bb1-ae55-0a5a129b1307");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// Position changed?
if((((model.variables.positionIn) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.locationAttr)))) {
// Execute Action: LogPositionChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Position has changed.", callContext);
// Execute Action: ChangeMarkerLocation
OutSystemsMapsController.default.changeMarkerLocation$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.positionIn, callContext);
// Set Position
// Internal_Marker_Configs.Internal_to_provider_marker_configs.location = Position
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.locationAttr = model.variables.positionIn;
}

// IconURL changed?
if((((model.variables.optionalConfigsIn.iconURLAttr) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconUrlAttr)))) {
// Execute Action: LogIconURLChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter iconURL has changed.", callContext);
// Execute Action: ChangeMarkerIconUrl
OutSystemsMapsController.default.changeMarkerIconUrl$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.iconURLAttr, callContext);
// Set IconURL
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconUrl = OptionalConfigs.IconURL
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconUrlAttr = model.variables.optionalConfigsIn.iconURLAttr;
}

// Title changed?
if((((model.variables.optionalConfigsIn.titleAttr) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.titleAttr)))) {
// Execute Action: LogTitleChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Title has changed.", callContext);
// Execute Action: ChangeMarkerTitle
OutSystemsMapsController.default.changeMarkerTitle$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.titleAttr, callContext);
// Set Title
// Internal_Marker_Configs.Internal_to_provider_marker_configs.title = OptionalConfigs.Title
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.titleAttr = model.variables.optionalConfigsIn.titleAttr;
}

// AllowDrag changed?
if((((model.variables.optionalConfigsIn.allowDragAttr) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.allowDragAttr)))) {
// Execute Action: LogAllowDragChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AllowDrag has changed.", callContext);
// Execute Action: ChangeMarkerAllowDrag
OutSystemsMapsController.default.changeMarkerAllowDrag$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.allowDragAttr, callContext);
// Set AllowDrag
// Internal_Marker_Configs.Internal_to_provider_marker_configs.allowDrag = OptionalConfigs.AllowDrag
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.allowDragAttr = model.variables.optionalConfigsIn.allowDragAttr;
}

// Label changed?
if((((model.variables.optionalConfigsIn.labelAttr) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.labelAttr)))) {
// Execute Action: LogLabelChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Label has changed.", callContext);
// Execute Action: ChangeMarkerLabel
OutSystemsMapsController.default.changeMarkerLabel$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.labelAttr, callContext);
// Set Label
// Internal_Marker_Configs.Internal_to_provider_marker_configs.label = OptionalConfigs.Label
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.labelAttr = model.variables.optionalConfigsIn.labelAttr;
}

// IconWidth changed?
if(((((model.variables.optionalConfigsIn.iconSizeAttr.widthAttr).toString()) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconWidthAttr)))) {
// Execute Action: LogIconWidthChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter iconWidth has changed.", callContext);
// Execute Action: ChangeMarkerIconWidth
OutSystemsMapsController.default.changeMarkerIconWidth$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.iconSizeAttr.widthAttr, callContext);
// Set IconWidth
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconWidth = OptionalConfigs.IconSize.Width
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconWidthAttr = (model.variables.optionalConfigsIn.iconSizeAttr.widthAttr).toString();
}

// IconHeight changed?
if(((((model.variables.optionalConfigsIn.iconSizeAttr.heightAttr).toString()) !== (model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconHeightAttr)))) {
// Execute Action: LogIconHeightChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter iconHeight has changed.", callContext);
// Execute Action: ChangeMarkerIconHeight
OutSystemsMapsController.default.changeMarkerIconHeight$Action(model.variables.internal_Marker_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.iconSizeAttr.heightAttr, callContext);
// Set IconHeight
// Internal_Marker_Configs.Internal_to_provider_marker_configs.iconHeight = OptionalConfigs.IconSize.Height
model.variables.internal_Marker_ConfigsVar.internal_to_provider_marker_configsAttr.iconHeightAttr = (model.variables.optionalConfigsIn.iconSizeAttr.heightAttr).toString();
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


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "09437078-b62a-4a7c-8fe6-658c533cac66");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onDestroy$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

callback_Event$Action(mapWidgetIdIn, markerWidgetIdIn, eventNameIn, latLngIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Callback_Event__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "4000bff2-7064-40d1-a7da-7e003cbf0fa0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._callback_Event$Action, callContext, mapWidgetIdIn, markerWidgetIdIn, eventNameIn, latLngIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

subscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "7018994a-1747-4c8e-a14b-c6cbc9b860dc");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ac09377e-f5b0-4853-9bd2-8a1fef12e03d");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c4dc1550-d087-4bad-8cde-48565b0be09b");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "f18d6749-511a-4bb1-ae55-0a5a129b1307");
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
Controller.registerVariableGroupType("OutSystemsMaps.Marker.Marker.Callback_Event$vars", [{
name: "MapWidgetId",
attrName: "mapWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "MarkerWidgetId",
attrName: "markerWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "EventName",
attrName: "eventNameInLocal",
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
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Marker.Marker.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "OnClick_Callback",
attrName: "onClick_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




