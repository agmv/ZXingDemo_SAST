import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Utilities_SwipeEvents_mvc_TranslationsResources from "./OutSystemsUI.Utilities.SwipeEvents.mvc$translationsResources.js";
import OutSystemsUI_Utilities_SwipeEvents_mvc_controller_OnGestureMove_PreventDefautJS from "./OutSystemsUI.Utilities.SwipeEvents.mvc$controller.OnGestureMove.PreventDefautJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Utilities_SwipeEvents_mvc_TranslationsResources);
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
get _onGestureMove$Action() {if(!(this.hasOwnProperty("__onGestureMove$Action"))) {
this.__onGestureMove$Action = function (evtIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnGestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureMove");
span.setAttribute("outsystems.function.key", "63f847c6-2810-4053-ab3f-f1fbefd0e82f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnGestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.SwipeEvents.OnGestureMove$vars"))());
vars.value.evtInLocal = evtIn;
OS.Logger.startActiveSpan("PreventDefaut", function (span) {
if(span) {
span.setAttribute("code.function", "PreventDefaut");
span.setAttribute("outsystems.function.key", "47ddf9aa-1b6e-4030-8a0d-59de197cef2d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Utilities_SwipeEvents_mvc_controller_OnGestureMove_PreventDefautJS, "PreventDefaut", "OnGestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onGestureMove$Action;
}set _onGestureMove$Action(value) {this.__onGestureMove$Action = value;
}

get _onGestureEnd$Action() {if(!(this.hasOwnProperty("__onGestureEnd$Action"))) {
this.__onGestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnGestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureEnd");
span.setAttribute("outsystems.function.key", "7bf33394-2b38-456a-8126-015dd4015e17");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnGestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.SwipeEvents.OnGestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
return OS.Flow.executeAsyncFlow(function () {
// Swype Detected?
return OS.Flow.executeSequence(function () {
if((((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gt(OS.BuiltinFunctions.integerToDecimal(model.variables.thresholdVar)) || OS.BuiltinFunctions.abs(vars.value.offsetYInLocal).gt(OS.BuiltinFunctions.integerToDecimal(model.variables.thresholdVar))) && (OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar) || OS.BuiltinFunctions.abs(vars.value.offsetYInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar))))) {
// Horizontal?
return OS.Flow.executeSequence(function () {
if((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gt(OS.BuiltinFunctions.abs(vars.value.offsetYInLocal)))) {
// Right?
return OS.Flow.executeSequence(function () {
if((vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0)))) {
// Trigger Event: SwipeRight
return controller.swipeRight$Action(callContext);
} else {
// Trigger Event: SwipeLeft
return controller.swipeLeft$Action(callContext);
}

});
} else {
// Down?
return OS.Flow.executeSequence(function () {
if((vars.value.offsetYInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0)))) {
// Trigger Event: SwipeDown
return controller.swipeDown$Action(callContext);
} else {
// Trigger Event: SwipeUp
return controller.swipeUp$Action(callContext);
}

});
}

});
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

return this.__onGestureEnd$Action;
}set _onGestureEnd$Action(value) {this.__onGestureEnd$Action = value;
}


onGestureMove$Action(evtIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnGestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureMove");
span.setAttribute("outsystems.function.key", "63f847c6-2810-4053-ab3f-f1fbefd0e82f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onGestureMove$Action, callContext, evtIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onGestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnGestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureEnd");
span.setAttribute("outsystems.function.key", "7bf33394-2b38-456a-8126-015dd4015e17");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onGestureEnd$Action, callContext, offsetXIn, offsetYIn, timeTakenIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get swipeUp$Action() {if(!(this.hasOwnProperty("_swipeUp$Action"))) {
this._swipeUp$Action = function () {
return Promise.resolve();
};
}

return this._swipeUp$Action;
}set swipeUp$Action(value) {this._swipeUp$Action = value;
}

get swipeLeft$Action() {if(!(this.hasOwnProperty("_swipeLeft$Action"))) {
this._swipeLeft$Action = function () {
return Promise.resolve();
};
}

return this._swipeLeft$Action;
}set swipeLeft$Action(value) {this._swipeLeft$Action = value;
}

get swipeRight$Action() {if(!(this.hasOwnProperty("_swipeRight$Action"))) {
this._swipeRight$Action = function () {
return Promise.resolve();
};
}

return this._swipeRight$Action;
}set swipeRight$Action(value) {this._swipeRight$Action = value;
}

get swipeDown$Action() {if(!(this.hasOwnProperty("_swipeDown$Action"))) {
this._swipeDown$Action = function () {
return Promise.resolve();
};
}

return this._swipeDown$Action;
}set swipeDown$Action(value) {this._swipeDown$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
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
this._onParametersChangedEventHandler = null;
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
Controller.registerVariableGroupType("OutSystemsUI.Utilities.SwipeEvents.OnGestureMove$vars", [{
name: "Evt",
attrName: "evtInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Utilities.SwipeEvents.OnGestureEnd$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "TimeTaken",
attrName: "timeTakenInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




