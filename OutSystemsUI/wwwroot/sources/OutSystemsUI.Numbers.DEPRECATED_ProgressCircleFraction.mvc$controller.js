import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_TranslationsResources from "./OutSystemsUI.Numbers.DEPRECATED_ProgressCircleFraction.mvc$translationsResources.js";
import OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_controller_OnParametersChanged_UpdateProgressJS from "./OutSystemsUI.Numbers.DEPRECATED_ProgressCircleFraction.mvc$controller.OnParametersChanged.UpdateProgressJS.js";
import OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_controller_OnReady_InitCircleJS from "./OutSystemsUI.Numbers.DEPRECATED_ProgressCircleFraction.mvc$controller.OnReady.InitCircleJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_TranslationsResources);
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
get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0b540b85-3eb3-4b88-87de-fc21adb4ea4f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("UpdateProgress", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateProgress");
span.setAttribute("outsystems.function.key", "04b836f4-15c3-41cb-9801-1d3e983ca076");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_controller_OnParametersChanged_UpdateProgressJS, "UpdateProgress", "OnParametersChanged", {
CircleObject: OS.DataConversion.JSNodeParamConverter.to(model.variables.circleObjVar, OS.DataTypes.DataTypes.Object),
PreviousProgressColor: OS.DataConversion.JSNodeParamConverter.to(model.variables.previousProgressColorVar, OS.DataTypes.DataTypes.Text),
ProgressColor: OS.DataConversion.JSNodeParamConverter.to(model.variables.progressColorIn, OS.DataTypes.DataTypes.Text),
Progress: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.round(OS.BuiltinFunctions.integerToDecimal(model.variables.numeratorIn).div(OS.BuiltinFunctions.integerToDecimal(model.variables.denominatorIn)), 2), OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// PreviousProgressColor = ProgressColor
model.variables.previousProgressColorVar = model.variables.progressColorIn;
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
span.setAttribute("outsystems.function.key", "daf4149f-0581-4397-b39c-be4a48dcb45d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var initCircleJSResult = new OS.DataTypes.VariableHolder();
initCircleJSResult.value = OS.Logger.startActiveSpan("InitCircle", function (span) {
if(span) {
span.setAttribute("code.function", "InitCircle");
span.setAttribute("outsystems.function.key", "289297f2-17bb-4b0e-8e7d-538584a1dde0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Numbers_DEPRECATED_ProgressCircleFraction_mvc_controller_OnReady_InitCircleJS, "InitCircle", "OnReady", {
ContainerId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ProgressCircle"), OS.DataTypes.DataTypes.Text),
ProgressColor: OS.DataConversion.JSNodeParamConverter.to(model.variables.progressColorIn, OS.DataTypes.DataTypes.Text),
Progress: OS.DataConversion.JSNodeParamConverter.to((((model.variables.denominatorIn === 0)) ? (OS.BuiltinFunctions.integerToDecimal(0)) : (OS.BuiltinFunctions.round(OS.BuiltinFunctions.integerToDecimal(model.variables.numeratorIn).div(OS.BuiltinFunctions.integerToDecimal(model.variables.denominatorIn)), 2))), OS.DataTypes.DataTypes.Decimal),
AnimationDuration: OS.DataConversion.JSNodeParamConverter.to(((model.variables.animateInitialProgressIn) ? (500) : (0)), OS.DataTypes.DataTypes.Integer),
StrokeWidth: OS.DataConversion.JSNodeParamConverter.to(model.variables.circleThicknessIn, OS.DataTypes.DataTypes.Integer),
TrailColor: OS.DataConversion.JSNodeParamConverter.to(model.variables.trailColorIn, OS.DataTypes.DataTypes.Text),
CircleObject: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
ContainerWidth: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Numbers.DEPRECATED_ProgressCircleFraction.OnReady$initCircleJSResult"))();
jsNodeResult.circleObjectOut = OS.DataConversion.JSNodeParamConverter.from($parameters.CircleObject, OS.DataTypes.DataTypes.Object);
jsNodeResult.containerWidthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ContainerWidth, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Calc size
// Size = If
model.variables.sizeVar = (((initCircleJSResult.value.containerWidthOut < 120)) ? ("small") : (((((initCircleJSResult.value.containerWidthOut >= 120) && (initCircleJSResult.value.containerWidthOut < 220))) ? ("medium") : ("large"))));
// Set CircleObject
// CircleObj = InitCircle.CircleObject
model.variables.circleObjVar = initCircleJSResult.value.circleObjectOut;
// PreviousProgressColor = ProgressColor
model.variables.previousProgressColorVar = model.variables.progressColorIn;
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


onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0b540b85-3eb3-4b88-87de-fc21adb4ea4f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
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
span.setAttribute("outsystems.function.key", "daf4149f-0581-4397-b39c-be4a48dcb45d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
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
this._onInitializeEventHandler = null;
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
this._onDestroyEventHandler = null;
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
return OutSystemsUIController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsUI.Numbers.DEPRECATED_ProgressCircleFraction.OnReady$initCircleJSResult", [{
name: "CircleObject",
attrName: "circleObjectOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "ContainerWidth",
attrName: "containerWidthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




