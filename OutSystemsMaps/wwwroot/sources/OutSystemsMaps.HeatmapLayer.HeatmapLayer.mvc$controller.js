import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
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
span.setAttribute("outsystems.function.key", "1e52b259-8623-499c-b7c7-b46578626643");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveHeatmapLayer
OutSystemsMapsController.default.removeHeatmapLayer$Action(model.variables.internal_HeatmapLayer_ConfigsVar.uniqueIdAttr, callContext);
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
span.setAttribute("outsystems.function.key", "49995647-4eea-4f7b-b2c9-43ae4c0e5414");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var getHashcode_PointsVar = new OS.DataTypes.VariableHolder();
var jSONSerializePointsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var jSONSerializeGradientVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: JSONSerializeGradient
jSONSerializeGradientVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.optionalConfigsIn.gradientAttr, true, false, OS.DataTypes.DataTypes.Text);
// JSON Serialize: JSONSerializePoints
jSONSerializePointsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.pointsIn, true, false);
// Execute Action: GetHashcode_Points
getHashcode_PointsVar.value = OutSystemsMapsController.default.getHashcode$Action(jSONSerializePointsVar.value.jSONOut, callContext);

// Points changed?
if((!(getHashcode_PointsVar.value.hashcodeOut.equals(model.variables.pointsHashCodeVar)))) {
// Execute Action: LogPointsChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Points has changed.", callContext);
// Execute Action: ChangeHeatmapLayerPoints
OutSystemsMapsController.default.changeHeatmapLayerPoints$Action(model.variables.uniqueIdVar, model.variables.pointsIn, callContext);
// Set Points Hash
// PointsHashCode = GetHashcode_Points.Hashcode
model.variables.pointsHashCodeVar = getHashcode_PointsVar.value.hashcodeOut;
}

// MaxIntensity changed?
if((!(model.variables.optionalConfigsIn.maxIntensityAttr.equals(model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.maxIntensityAttr)))) {
// Execute Action: LogMaxIntensityChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter MaxIntensity has changed.", callContext);
// Execute Action: ChangeHeatmapLayerMaxIntensity
OutSystemsMapsController.default.changeHeatmapLayerMaxIntensity$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.maxIntensityAttr, callContext);
// Set MaxIntensity
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.maxIntensity = OptionalConfigs.Opacity
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.maxIntensityAttr = model.variables.optionalConfigsIn.opacityAttr;
}

// Opacity changed?
if((!(model.variables.optionalConfigsIn.opacityAttr.equals(model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.opacityAttr)))) {
// Execute Action: LogOpacityChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Opacity has changed.", callContext);
// Execute Action: ChangeHeatmapLayerOpacity
OutSystemsMapsController.default.changeHeatmapLayerOpacity$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.opacityAttr, callContext);
// Set Opacity
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.opacity = OptionalConfigs.Opacity
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.opacityAttr = model.variables.optionalConfigsIn.opacityAttr;
}

// Radius changed?
if((((model.variables.optionalConfigsIn.radiusAttr) !== (model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.radiusAttr)))) {
// Execute Action: LogRadiusChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Radius has changed.", callContext);
// Execute Action: ChangeHeatmapLayerRadius
OutSystemsMapsController.default.changeHeatmapLayerRadius$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.radiusAttr, callContext);
// Set Radius
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.radius = OptionalConfigs.Radius
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.radiusAttr = model.variables.optionalConfigsIn.radiusAttr;
}

// DissipateOnZoom changed?
if((((model.variables.optionalConfigsIn.dissipateOnZoomAttr) !== (model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.dissipateOnZoomAttr)))) {
// Execute Action: LogDissipateOnZoomChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter DissipateOnZoom has changed.", callContext);
// Execute Action: ChangeHeatmapLayerDissipateOnZoom2
OutSystemsMapsController.default.changeHeatmapLayerDissipateOnZoom$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.dissipateOnZoomAttr, callContext);
// Set DissipateOnZoom
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.dissipateOnZoom = OptionalConfigs.DissipateOnZoom
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.dissipateOnZoomAttr = model.variables.optionalConfigsIn.dissipateOnZoomAttr;
}

// Gradient changed?
if((((jSONSerializeGradientVar.value.jSONOut) !== (model.variables.stringifiedGradientVar)))) {
// Execute Action: LogGradientChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Gradient has changed.", callContext);
// Execute Action: ChangeHeatmapLayerGradient
OutSystemsMapsController.default.changeHeatmapLayerGradient$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.gradientAttr, callContext);
// Set Gradient
// StringifiedGradient = JSONSerializeGradient.JSON
model.variables.stringifiedGradientVar = jSONSerializeGradientVar.value.jSONOut;
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a0a93cde-03df-4dbd-bd7b-73afeeb36ee0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var getHashcode_PointsVar = new OS.DataTypes.VariableHolder();
var jSONSerializePointsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var jSONSerializeGradientVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsMapsController.default.generateUniqueId$Action("", callContext);

// UniqueId = GenerateUniqueId.Unique_ID
model.variables.uniqueIdVar = generateUniqueIdVar.value.unique_IDOut;
// JSON Serialize: JSONSerializeGradient
jSONSerializeGradientVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.optionalConfigsIn.gradientAttr, true, false, OS.DataTypes.DataTypes.Text);
// JSON Serialize: JSONSerializePoints
jSONSerializePointsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.pointsIn, true, false);
// Execute Action: GetHashcode_Points
getHashcode_PointsVar.value = OutSystemsMapsController.default.getHashcode$Action(jSONSerializePointsVar.value.jSONOut, callContext);

// Set configurations
// Internal_HeatmapLayer_Configs.UniqueId = UniqueId
model.variables.internal_HeatmapLayer_ConfigsVar.uniqueIdAttr = model.variables.uniqueIdVar;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.maxIntensity = OptionalConfigs.MaxIntensity
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.maxIntensityAttr = model.variables.optionalConfigsIn.maxIntensityAttr;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.opacity = OptionalConfigs.Opacity
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.opacityAttr = model.variables.optionalConfigsIn.opacityAttr;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.radius = OptionalConfigs.Radius
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.radiusAttr = model.variables.optionalConfigsIn.radiusAttr;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.dissipateOnZoom = OptionalConfigs.DissipateOnZoom
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.dissipateOnZoomAttr = model.variables.optionalConfigsIn.dissipateOnZoomAttr;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.gradient = OptionalConfigs.Gradient
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.gradientAttr = model.variables.optionalConfigsIn.gradientAttr;
// StringifiedGradient = JSONSerializeGradient.JSON
model.variables.stringifiedGradientVar = jSONSerializeGradientVar.value.jSONOut;
// Internal_HeatmapLayer_Configs.Internal_to_provider_heatmapLayer_configs.points = Points
model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr.pointsAttr = model.variables.pointsIn;
// PointsHashCode = GetHashcode_Points.Hashcode
model.variables.pointsHashCodeVar = getHashcode_PointsVar.value.hashcodeOut;
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
span.setAttribute("outsystems.function.key", "e8941417-021c-4710-8563-fadad2297f31");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: CreateHeatmapLayer
OutSystemsMapsController.default.createHeatmapLayer$Action(model.variables.uniqueIdVar, model.variables.internal_HeatmapLayer_ConfigsVar.internal_to_provider_heatmapLayer_configsAttr, callContext);
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


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "1e52b259-8623-499c-b7c7-b46578626643");
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
span.setAttribute("outsystems.function.key", "49995647-4eea-4f7b-b2c9-43ae4c0e5414");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a0a93cde-03df-4dbd-bd7b-73afeeb36ee0");
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
span.setAttribute("outsystems.function.key", "e8941417-021c-4710-8563-fadad2297f31");
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

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




