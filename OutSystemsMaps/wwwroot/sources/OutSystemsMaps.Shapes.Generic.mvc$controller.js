import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_Shapes_Generic_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.Shapes.Generic.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
callback_Event$Action: function (mapWidgetIdIn, shapeIdIn) {
mapWidgetIdIn = (mapWidgetIdIn === undefined) ? "" : mapWidgetIdIn;
shapeIdIn = (shapeIdIn === undefined) ? "" : shapeIdIn;
return controller.executeActionInsideJSNode(controller._callback_Event$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(mapWidgetIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(shapeIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
get _callback_Event$Action() {if(!(this.hasOwnProperty("__callback_Event$Action"))) {
this.__callback_Event$Action = function (mapWidgetIdIn, shapeIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Callback_Event", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "22419353-c7da-48e6-a20c-c200469bdc9e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Callback_Event");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.Shapes.Generic.Callback_Event$vars"))());
vars.value.mapWidgetIdInLocal = mapWidgetIdIn;
vars.value.shapeIdInLocal = shapeIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnClick
return controller.onClick$Action(vars.value.mapWidgetIdInLocal, vars.value.shapeIdInLocal, callContext);
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "59565863-7bb9-4a2f-bcbf-f05e7cb8af7e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveShape
OutSystemsMapsController.default.removeShape$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, callContext);
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
span.setAttribute("outsystems.function.key", "789bcb3e-9a0b-42f6-abbd-186fbb18e357");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var getHashcode_LocationsVar = new OS.DataTypes.VariableHolder();
var serializeLocationsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: SerializeLocations
serializeLocationsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.locationsIn, true, false, OS.DataTypes.DataTypes.Text);
// Execute Action: GetHashcode_Locations
getHashcode_LocationsVar.value = OutSystemsMapsController.default.getHashcode$Action(serializeLocationsVar.value.jSONOut, callContext);

// Locations changed?
if((!(getHashcode_LocationsVar.value.hashcodeOut.equals(model.variables.locationsHashcodeVar)))) {
// Execute Action: LogLocationChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Location has changed.", callContext);
// Execute Action: ChangeShapeLocations
OutSystemsMapsController.default.changeShapeLocations$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.locationsIn, callContext);
// Set Locations hashcode
// LocationsHashcode = GetHashcode_Locations.Hashcode
model.variables.locationsHashcodeVar = getHashcode_LocationsVar.value.hashcodeOut;
}

// Center changed?
if((((model.variables.centerIn) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.centerAttr)))) {
// Execute Action: LogCenterChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Center has changed.", callContext);
// Execute Action: ChangeShapeCenter
OutSystemsMapsController.default.changeShapeCenter$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.centerIn, callContext);
// Set Center
// Internal_Shape_Configs.Internal_to_provider_shape_configs.center = Center
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.centerAttr = model.variables.centerIn;
}

// Radius changed?
if((((model.variables.radiusIn) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.radiusAttr)))) {
// Execute Action: LogRadiusChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Radius has changed.", callContext);
// Execute Action: ChangeShapeRadius
OutSystemsMapsController.default.changeShapeRadius$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, OS.BuiltinFunctions.integerToDecimal(model.variables.radiusIn), callContext);
// Set Radius
// Internal_Shape_Configs.Internal_to_provider_shape_configs.radius = Radius
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.radiusAttr = model.variables.radiusIn;
}

// AllowDrag changed?
if((((model.variables.optionalConfigsIn.allowDragAttr) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowDragAttr)))) {
// Execute Action: LogAllowDragChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AllowDrag has changed.", callContext);
// Execute Action: ChangeShapeAllowDrag
OutSystemsMapsController.default.changeShapeAllowDrag$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.allowDragAttr, callContext);
// Set AllowDrag
// Internal_Shape_Configs.Internal_to_provider_shape_configs.allowDrag = OptionalConfigs.AllowDrag
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowDragAttr = model.variables.optionalConfigsIn.allowDragAttr;
}

// AllowEdit changed?
if((((model.variables.optionalConfigsIn.allowEditAttr) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowEditAttr)))) {
// Execute Action: LogAllowEditChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter AllowEdit has changed.", callContext);
// Execute Action: ChangeShapeAllowEdit
OutSystemsMapsController.default.changeShapeAllowEdit$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.allowEditAttr, callContext);
// Set AllowEdit
// Internal_Shape_Configs.Internal_to_provider_shape_configs.allowEdit = OptionalConfigs.AllowEdit
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowEditAttr = model.variables.optionalConfigsIn.allowEditAttr;
}

// StrokeColor changed?
if((((model.variables.optionalConfigsIn.strokeAttr.colorAttr) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeColorAttr)))) {
// Execute Action: LogStrokeColorChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Color has changed.", callContext);
// Execute Action: ChangeShapeStrokeColor
OutSystemsMapsController.default.changeShapeStrokeColor$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.strokeAttr.colorAttr, callContext);
// Set Stroke.Color
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeColor = OptionalConfigs.Stroke.Color
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeColorAttr = model.variables.optionalConfigsIn.strokeAttr.colorAttr;
}

// StrokeOpacity changed?
if((!(model.variables.optionalConfigsIn.strokeAttr.opacityAttr.equals(model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeOpacityAttr)))) {
// Execute Action: LogStrokeOpacityChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Opacity has changed.", callContext);
// Execute Action: ChangeShapeStokeOpacity
OutSystemsMapsController.default.changeShapeStrokeOpacity$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.strokeAttr.opacityAttr, callContext);
// Set Stroke.Opacity
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeOpacity = OptionalConfigs.Stroke.Opacity
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeOpacityAttr = model.variables.optionalConfigsIn.strokeAttr.opacityAttr;
}

// StrokeWeight changed?
if((((model.variables.optionalConfigsIn.strokeAttr.weightAttr) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeWeightAttr)))) {
// Execute Action: LogStrokeWeightChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Weight has changed.", callContext);
// Execute Action: ChangeShapeStrokeWeight
OutSystemsMapsController.default.changeShapeStrokeWeight$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.strokeAttr.weightAttr, callContext);
// Set Stroke.Weight
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeWeight = OptionalConfigs.Stroke.Weight
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeWeightAttr = model.variables.optionalConfigsIn.strokeAttr.weightAttr;
}

// FillColor changed?
if((((model.variables.optionalConfigsIn.fillAttr.colorAttr) !== (model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillColorAttr)))) {
// Execute Action: LogFillColorChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter fillColor has changed.", callContext);
// Execute Action: ChangeShapeFillColor
OutSystemsMapsController.default.changeShapeFillColor$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.fillAttr.colorAttr, callContext);
// Set Fill.Color
// Internal_Shape_Configs.Internal_to_provider_shape_configs.fillColor = OptionalConfigs.Fill.Color
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillColorAttr = model.variables.optionalConfigsIn.fillAttr.colorAttr;
}

// FillOpacity changed?
if((!(model.variables.optionalConfigsIn.fillAttr.opacityAttr.equals(model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillOpacityAttr)))) {
// Execute Action: LogFillOpacityChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter fillOpacity has changed.", callContext);
// Execute Action: ChangeShapeFillOpacity
OutSystemsMapsController.default.changeShapeFillOpacity$Action(model.variables.internal_Shape_ConfigsVar.uniqueIdAttr, model.variables.optionalConfigsIn.fillAttr.opacityAttr, callContext);
// Set Fill.Opacity
// Internal_Shape_Configs.Internal_to_provider_shape_configs.fillOpacity = OptionalConfigs.Fill.Opacity
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillOpacityAttr = model.variables.optionalConfigsIn.fillAttr.opacityAttr;
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
span.setAttribute("outsystems.function.key", "8b5d7c87-d990-4062-a37f-3c2c30227a60");
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
span.setAttribute("outsystems.function.key", "6a20b4f4-ea26-4b9d-acc4-33555ac31d79");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_Shapes_Generic_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
OnClick_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.Shapes.Generic.SubscribeEvents$getCallbackHandlerJSResult"))();
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
// Execute Action: ShapeInitialized_Subscribe
OutSystemsMapsController.default.shapeEventSubscribe$Action(model.variables.uniqueIdIn, OutSystemsMapsModel.staticEntities.shapeEvent.onClick, getCallbackHandlerJSResult.value.onClick_CallbackOut, callContext);
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
span.setAttribute("outsystems.function.key", "953a97ee-023b-4dd0-9edf-27cae528475b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: CreateShape
OutSystemsMapsController.default.createShape$Action(model.variables.uniqueIdIn, model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr, model.variables.shapeTypeIn, callContext);
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
span.setAttribute("outsystems.function.key", "aadfaa9f-4a3b-4bb7-ac8c-fc63219e71df");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var getHashcode_LocationsVar = new OS.DataTypes.VariableHolder();
var locationsSerializeVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: LocationsSerialize
locationsSerializeVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.locationsIn, true, false, OS.DataTypes.DataTypes.Text);
// Execute Action: GetHashcode_Locations
getHashcode_LocationsVar.value = OutSystemsMapsController.default.getHashcode$Action(locationsSerializeVar.value.jSONOut, callContext);

// LocationsHashcode = GetHashcode_Locations.Hashcode
model.variables.locationsHashcodeVar = getHashcode_LocationsVar.value.hashcodeOut;
// Set configurations
// Internal_Shape_Configs.UniqueId = UniqueId
model.variables.internal_Shape_ConfigsVar.uniqueIdAttr = model.variables.uniqueIdIn;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.locations = LocationsSerialize.JSON
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.locationsAttr = locationsSerializeVar.value.jSONOut;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.allowDrag = OptionalConfigs.AllowDrag
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowDragAttr = model.variables.optionalConfigsIn.allowDragAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.allowEdit = OptionalConfigs.AllowEdit
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.allowEditAttr = model.variables.optionalConfigsIn.allowEditAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeColor = OptionalConfigs.Stroke.Color
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeColorAttr = model.variables.optionalConfigsIn.strokeAttr.colorAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeOpacity = OptionalConfigs.Stroke.Opacity
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeOpacityAttr = model.variables.optionalConfigsIn.strokeAttr.opacityAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.strokeWeight = OptionalConfigs.Stroke.Weight
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.strokeWeightAttr = model.variables.optionalConfigsIn.strokeAttr.weightAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.fillColor = OptionalConfigs.Fill.Color
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillColorAttr = model.variables.optionalConfigsIn.fillAttr.colorAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.fillOpacity = OptionalConfigs.Fill.Opacity
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.fillOpacityAttr = model.variables.optionalConfigsIn.fillAttr.opacityAttr;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.center = Center
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.centerAttr = model.variables.centerIn;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.radius = Radius
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.radiusAttr = model.variables.radiusIn;
// Internal_Shape_Configs.Internal_to_provider_shape_configs.bounds = Bounds
model.variables.internal_Shape_ConfigsVar.internal_to_provider_shape_configsAttr.boundsAttr = model.variables.boundsIn;
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


callback_Event$Action(mapWidgetIdIn, shapeIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Callback_Event__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Callback_Event");
span.setAttribute("outsystems.function.key", "22419353-c7da-48e6-a20c-c200469bdc9e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._callback_Event$Action, callContext, mapWidgetIdIn, shapeIdIn);
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
span.setAttribute("outsystems.function.key", "59565863-7bb9-4a2f-bcbf-f05e7cb8af7e");
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
span.setAttribute("outsystems.function.key", "789bcb3e-9a0b-42f6-abbd-186fbb18e357");
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
span.setAttribute("outsystems.function.key", "8b5d7c87-d990-4062-a37f-3c2c30227a60");
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
span.setAttribute("outsystems.function.key", "953a97ee-023b-4dd0-9edf-27cae528475b");
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
span.setAttribute("outsystems.function.key", "aadfaa9f-4a3b-4bb7-ac8c-fc63219e71df");
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
Controller.registerVariableGroupType("OutSystemsMaps.Shapes.Generic.Callback_Event$vars", [{
name: "MapWidgetId",
attrName: "mapWidgetIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ShapeId",
attrName: "shapeIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.Shapes.Generic.SubscribeEvents$getCallbackHandlerJSResult", [{
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




