import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Drawing_Tools_DrawPolygon_mvc_controller_OnDestroy_GetCallbackHandlerJS from "./OutSystemsMaps.Drawing_Tools.DrawPolygon.mvc$controller.OnDestroy.GetCallbackHandlerJS.js";
import OutSystemsMaps_Drawing_Tools_DrawPolygon_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Drawing_Tools.DrawPolygon.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
callback_Event$Action: function (mapWidgetIdIn, polygonIdIn, isNewPolygonIn, coordinatesIn, locationIn) {
mapWidgetIdIn = (mapWidgetIdIn === undefined) ? "" : mapWidgetIdIn;
polygonIdIn = (polygonIdIn === undefined) ? "" : polygonIdIn;
isNewPolygonIn = (isNewPolygonIn === undefined) ? true : isNewPolygonIn;
coordinatesIn = (coordinatesIn === undefined) ? "" : coordinatesIn;
locationIn = (locationIn === undefined) ? "" : locationIn;
return controller.executeActionInsideJSNode(controller._callback_Event$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(polygonIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(isNewPolygonIn, OS.DataTypes.DataTypes.Boolean), OS.DataConversion.JSNodeParamConverter.from(coordinatesIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(locationIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "2e5e3f00-d69e-4457-a856-a1bbd3cdb277");
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "499c1e37-d14f-445e-b412-7221ac124bda");
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
span.setAttribute("outsystems.function.key", "ff472f4c-77f2-4878-aa62-76c2ac67d164");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Drawing_Tools_DrawPolygon_mvc_controller_OnDestroy_GetCallbackHandlerJS, "GetCallbackHandler", "OnDestroy", {
OnPolygonCreated_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.OnDestroy$getCallbackHandlerJSResult"))();
jsNodeResult.onPolygonCreated_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnPolygonCreated_Callback, OS.DataTypes.DataTypes.Object);
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
OutSystemsMapsController.default.toolsEventUnSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolsEventTriggered.polygonCreated, getCallbackHandlerJSResult.value.onPolygonCreated_CallbackOut, callContext);
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
span.setAttribute("outsystems.function.key", "d8bc0ee0-dfda-4412-9274-6e5792b30945");
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
// Execute Action: LogFillOpacityChange
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

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "e286811c-a7e0-4b8f-a08b-4b983168ab84");
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
span.setAttribute("outsystems.function.key", "e796119c-7ed3-404a-b832-97e75c7e58dd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Drawing_Tools_DrawPolygon_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
OnPolygonCreated_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.onPolygonCreated_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnPolygonCreated_Callback, OS.DataTypes.DataTypes.Object);
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
OutSystemsMapsController.default.toolsEventSubscribe$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolsEventTriggered.polygonCreated, getCallbackHandlerJSResult.value.onPolygonCreated_CallbackOut, callContext);
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

get _callback_Event$Action() {if(!(this.hasOwnProperty("__callback_Event$Action"))) {
this.__callback_Event$Action = function (mapWidgetIdIn, polygonIdIn, isNewPolygonIn, coordinatesIn, locationIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Callback_Event", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "e628ce45-ae41-4214-8f7c-e86fa3923b25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Callback_Event");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.Callback_Event$vars"))());
vars.value.mapWidgetIdInLocal = mapWidgetIdIn;
vars.value.polygonIdInLocal = polygonIdIn;
vars.value.isNewPolygonInLocal = isNewPolygonIn;
vars.value.coordinatesInLocal = coordinatesIn;
vars.value.locationInLocal = locationIn;
var jSONDeserializeTextListVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType(OS.DataTypes.TextList))());
var jSONDeserializeCoordinatesVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType((OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure))))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: JSONDeserializeCoordinates
jSONDeserializeCoordinatesVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.coordinatesInLocal, (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure)), false);
// JSON Deserialize: JSONDeserializeTextList
jSONDeserializeTextListVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.locationInLocal, OS.DataTypes.TextList, false);
// Trigger Event: OnDrawingChange
return controller.onDrawingChange$Action(vars.value.mapWidgetIdInLocal, vars.value.polygonIdInLocal, vars.value.isNewPolygonInLocal, jSONDeserializeCoordinatesVar.value.dataOut, jSONDeserializeTextListVar.value.dataOut, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f2325f5f-f3f1-4e8f-b622-29547c35aa78");
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
OutSystemsMapsController.default.addTool$Action(model.variables.uniqueIdVar, OutSystemsMapsModel.staticEntities.drawingToolType.polygon, serialize_ConfigsVar.value.jSONOut, callContext);
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


onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "2e5e3f00-d69e-4457-a856-a1bbd3cdb277");
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

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "499c1e37-d14f-445e-b412-7221ac124bda");
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
span.setAttribute("outsystems.function.key", "d8bc0ee0-dfda-4412-9274-6e5792b30945");
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
span.setAttribute("outsystems.function.key", "e286811c-a7e0-4b8f-a08b-4b983168ab84");
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

callback_Event$Action(mapWidgetIdIn, polygonIdIn, isNewPolygonIn, coordinatesIn, locationIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Callback_Event__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "e628ce45-ae41-4214-8f7c-e86fa3923b25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._callback_Event$Action, callContext, mapWidgetIdIn, polygonIdIn, isNewPolygonIn, coordinatesIn, locationIn);
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
span.setAttribute("outsystems.function.key", "f2325f5f-f3f1-4e8f-b622-29547c35aa78");
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
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.OnDestroy$getCallbackHandlerJSResult", [{
name: "OnPolygonCreated_Callback",
attrName: "onPolygonCreated_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "OnPolygonCreated_Callback",
attrName: "onPolygonCreated_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Drawing_Tools.DrawPolygon.Callback_Event$vars", [{
name: "MapWidgetId",
attrName: "mapWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "PolygonId",
attrName: "polygonIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsNewPolygon",
attrName: "isNewPolygonInLocal",
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

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




