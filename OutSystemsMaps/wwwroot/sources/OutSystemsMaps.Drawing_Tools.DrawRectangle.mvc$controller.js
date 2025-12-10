import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Drawing_Tools_DrawRectangle_mvc_controller_OnDestroy_GetCallbackHandlerJS from "./OutSystemsMaps.Drawing_Tools.DrawRectangle.mvc$controller.OnDestroy.GetCallbackHandlerJS.js";
import OutSystemsMaps_Drawing_Tools_DrawRectangle_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Drawing_Tools.DrawRectangle.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
callback_Event$Action: function (mapWidgetIdIn, rectangleIdIn, isNewRectangleIn, coordinatesIn, locationIn) {
mapWidgetIdIn = (mapWidgetIdIn === undefined) ? "" : mapWidgetIdIn;
rectangleIdIn = (rectangleIdIn === undefined) ? "" : rectangleIdIn;
isNewRectangleIn = (isNewRectangleIn === undefined) ? true : isNewRectangleIn;
coordinatesIn = (coordinatesIn === undefined) ? "" : coordinatesIn;
locationIn = (locationIn === undefined) ? "" : locationIn;
return controller.executeActionInsideJSNode(controller._callback_Event$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(rectangleIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(isNewRectangleIn, OS.DataTypes.DataTypes.Boolean), OS.DataConversion.JSNodeParamConverter.from(coordinatesIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(locationIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
span.setAttribute("outsystems.function.key", "409b167e-7bee-488d-94fa-7d0d45b1e45d");
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
span.setAttribute("outsystems.function.key", "e8b25e58-291c-4fe0-9022-ef80036890ad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Drawing_Tools_DrawRectangle_mvc_controller_OnDestroy_GetCallbackHandlerJS, "GetCallbackHandler", "OnDestroy", {
OnRectangleCreated_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.OnDestroy$getCallbackHandlerJSResult"))();
jsNodeResult.onRectangleCreated_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnRectangleCreated_Callback, OS.DataTypes.DataTypes.Object);
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
// Execute Action: ToolsEventUnSubscribe
OutSystemsMapsController.default.toolsEventUnSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolsEventTriggered.rectangleCreated, getCallbackHandlerJSResult.value.onRectangleCreated_CallbackOut, callContext);
// Execute Action: RemoveTool
OutSystemsMapsController.default.removeTool$Action(model.variables.uniqueIdVar, callContext);
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
span.setAttribute("outsystems.function.key", "4f191f43-0894-4cd4-8d80-08c5ebbbf861");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// AllowDrag changed?
if((((model.variables.allowDragIn) !== (model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowDragAttr)))) {
// Execute Action: LogAllowDragChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AllowDrag has changed.", callContext);
// Execute Action: ChangeToolAllowDrag
OutSystemsMapsController.default.changeToolAllowDrag$Action(model.variables.uniqueIdVar, model.variables.allowDragIn, callContext);
// Set AllowDrag
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.allowDrag = AllowDrag
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowDragAttr = model.variables.allowDragIn;
}

// AllowEdit changed?
if((((model.variables.allowEditIn) !== (model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowEditAttr)))) {
// Execute Action: LogAllowEditChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AllowEdit has changed.", callContext);
// Execute Action: ChangeToolAllowEdit
OutSystemsMapsController.default.changeToolAllowEdit$Action(model.variables.uniqueIdVar, model.variables.allowEditIn, callContext);
// Set AllowEdit
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.allowEdit = AllowEdit
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowEditAttr = model.variables.allowEditIn;
}

// StrokeColor changed?
if((((model.variables.strokeIn.colorAttr) !== (model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeColorAttr)))) {
// Execute Action: LogStrokeColorChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter StrokeColor has changed.", callContext);
// Execute Action: ChangeToolStrokeColor
OutSystemsMapsController.default.changeToolStrokeColor$Action(model.variables.uniqueIdVar, model.variables.strokeIn.colorAttr, callContext);
// Set Stroke.Color
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeColor = Stroke.Color
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeColorAttr = model.variables.strokeIn.colorAttr;
}

// StrokeOpacity changed?
if((!(model.variables.strokeIn.opacityAttr.equals(model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeOpacityAttr)))) {
// Execute Action: LogStrokeOpacityChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter StrokeOpacity has changed.", callContext);
// Execute Action: ChangeToolStokeOpacity
OutSystemsMapsController.default.changeToolStrokeOpacity$Action(model.variables.uniqueIdVar, model.variables.strokeIn.opacityAttr, callContext);
// Set Stroke.Opacity
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeOpacity = Stroke.Opacity
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeOpacityAttr = model.variables.strokeIn.opacityAttr;
}

// StrokeWeight changed?
if((((model.variables.strokeIn.weightAttr) !== (model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeWeightAttr)))) {
// Execute Action: LogStrokeWeightChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter StrokeWeight has changed.", callContext);
// Execute Action: ChangeToolStrokeWeight
OutSystemsMapsController.default.changeToolStrokeWeight$Action(model.variables.uniqueIdVar, model.variables.strokeIn.weightAttr, callContext);
// Set Stroke.Weight
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeWeight = Stroke.Weight
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeWeightAttr = model.variables.strokeIn.weightAttr;
}

// FillOpacity changed?
if((!(model.variables.fillIn.opacityAttr.equals(model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillOpacityAttr)))) {
// Execute Action: LogFillOpacityChange2
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter FillOpacity has changed.", callContext);
// Execute Action: ChangeToolFillOpacity
OutSystemsMapsController.default.changeToolFillOpacity$Action(model.variables.uniqueIdVar, model.variables.fillIn.opacityAttr, callContext);
// Set Fill.Opacity
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.fillOpacity = Fill.Opacity
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillOpacityAttr = model.variables.fillIn.opacityAttr;
}

// FillColor changed?
if((((model.variables.fillIn.colorAttr) !== (model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillColorAttr)))) {
// Execute Action: LogFillColorChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter FillColor has changed.", callContext);
// Execute Action: ChangeToolFillColor
OutSystemsMapsController.default.changeToolFillColor$Action(model.variables.uniqueIdVar, model.variables.fillIn.colorAttr, callContext);
// Set Fill.Color
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.fillColor = Fill.Color
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillColorAttr = model.variables.fillIn.colorAttr;
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "a048dfd0-a563-43fa-a1d3-a26b48d52bea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var serialize_ConfigsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: Serialize_Configs
serialize_ConfigsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr, true, false);
// Execute Action: AddTool
OutSystemsMapsController.default.addTool$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolType.rectangle, serialize_ConfigsVar.value.jSONOut, callContext);
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

get _callback_Event$Action() {if(!(this.hasOwnProperty("__callback_Event$Action"))) {
this.__callback_Event$Action = function (mapWidgetIdIn, rectangleIdIn, isNewRectangleIn, coordinatesIn, locationIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Callback_Event", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "a04d7ba6-a8de-4a61-a911-1d57dabefcaf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Callback_Event");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.Callback_Event$vars"))());
vars.value.mapWidgetIdInLocal = mapWidgetIdIn;
vars.value.rectangleIdInLocal = rectangleIdIn;
vars.value.isNewRectangleInLocal = isNewRectangleIn;
vars.value.coordinatesInLocal = coordinatesIn;
vars.value.locationInLocal = locationIn;
var jSONDeserializeCoordinatesVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType(OutSystemsMapsModel.ST_5fb6f64676b0133fcb572480a766fc9cStructure))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: JSONDeserializeCoordinates
jSONDeserializeCoordinatesVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.coordinatesInLocal, OutSystemsMapsModel.ST_5fb6f64676b0133fcb572480a766fc9cStructure, false);
// Trigger Event: OnDrawingChange
return controller.onDrawingChange$Action(vars.value.mapWidgetIdInLocal, vars.value.rectangleIdInLocal, vars.value.isNewRectangleInLocal, jSONDeserializeCoordinatesVar.value.dataOut, vars.value.locationInLocal, callContext);
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
span.setAttribute("outsystems.function.key", "e0b1cefc-6b60-40b3-88d5-3b465d2cd46a");
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
span.setAttribute("outsystems.function.key", "55d70dbf-837e-4045-81be-a99cb657696d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Drawing_Tools_DrawRectangle_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
OnRectangleCreated_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.onRectangleCreated_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnRectangleCreated_Callback, OS.DataTypes.DataTypes.Object);
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
// Execute Action: DrawingToolsInitialized_Subscribe
OutSystemsMapsController.default.toolsEventSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolsEventTriggered.rectangleCreated, getCallbackHandlerJSResult.value.onRectangleCreated_CallbackOut, callContext);
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
span.setAttribute("outsystems.function.key", "fc54da1b-7b35-442c-a400-34705adae4be");
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
// Internal_DrawingTools_Configs.UniqueId = UniqueId
model.variables.internal_DrawingTools_ConfigsVar.uniqueIdAttr = model.variables.uniqueIdVar;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.allowEdit = AllowEdit
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowEditAttr = model.variables.allowEditIn;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.allowDrag = AllowDrag
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.allowDragAttr = model.variables.allowDragIn;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeColor = Stroke.Color
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeColorAttr = model.variables.strokeIn.colorAttr;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeOpacity = Stroke.Opacity
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeOpacityAttr = model.variables.strokeIn.opacityAttr;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.strokeWeight = Stroke.Weight
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.strokeWeightAttr = model.variables.strokeIn.weightAttr;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.fillColor = Fill.Color
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillColorAttr = model.variables.fillIn.colorAttr;
// Internal_DrawingTools_Configs.Internal_to_provider_tools_configs.fillOpacity = Fill.Opacity
model.variables.internal_DrawingTools_ConfigsVar.internal_to_provider_tools_configsAttr.fillOpacityAttr = model.variables.fillIn.opacityAttr;
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


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "409b167e-7bee-488d-94fa-7d0d45b1e45d");
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
span.setAttribute("outsystems.function.key", "4f191f43-0894-4cd4-8d80-08c5ebbbf861");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "a048dfd0-a563-43fa-a1d3-a26b48d52bea");
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

callback_Event$Action(mapWidgetIdIn, rectangleIdIn, isNewRectangleIn, coordinatesIn, locationIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Callback_Event__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "a04d7ba6-a8de-4a61-a911-1d57dabefcaf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._callback_Event$Action, callContext, mapWidgetIdIn, rectangleIdIn, isNewRectangleIn, coordinatesIn, locationIn);
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
span.setAttribute("outsystems.function.key", "e0b1cefc-6b60-40b3-88d5-3b465d2cd46a");
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
span.setAttribute("outsystems.function.key", "fc54da1b-7b35-442c-a400-34705adae4be");
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

get onDrawingChange$Action() {if(!(this.hasOwnProperty("_onDrawingChange$Action"))) {
this._onDrawingChange$Action = function () {
return Promise.resolve();
};
}

return this._onDrawingChange$Action;
}set onDrawingChange$Action(value) {this._onDrawingChange$Action = value;
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
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.OnDestroy$getCallbackHandlerJSResult", [{
name: "OnRectangleCreated_Callback",
attrName: "onRectangleCreated_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.Callback_Event$vars", [{
name: "MapWidgetId",
attrName: "mapWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "RectangleId",
attrName: "rectangleIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsNewRectangle",
attrName: "isNewRectangleInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return true;
}
}, {
name: "Coordinates",
attrName: "coordinatesInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Location",
attrName: "locationInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawRectangle.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "OnRectangleCreated_Callback",
attrName: "onRectangleCreated_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




