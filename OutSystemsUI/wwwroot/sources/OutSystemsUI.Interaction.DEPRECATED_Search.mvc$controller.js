import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Search_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_Search.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Search_mvc_controller_OnReady_InputFilledJS from "./OutSystemsUI.Interaction.DEPRECATED_Search.mvc$controller.OnReady.InputFilledJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Search_mvc_controller_ExpandOrCollapse_FocusInputJS from "./OutSystemsUI.Interaction.DEPRECATED_Search.mvc$controller.ExpandOrCollapse.FocusInputJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_Search_mvc_TranslationsResources);
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
get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1067af2e-fab1-41e5-9991-ccb0ac831f20");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var inputFilledJSResult = new OS.DataTypes.VariableHolder();
inputFilledJSResult.value = OS.Logger.startActiveSpan("InputFilled", function (span) {
if(span) {
span.setAttribute("code.function", "InputFilled");
span.setAttribute("outsystems.function.key", "2a635bc4-0ac1-4edd-aff8-b976213bfa8d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Search_mvc_controller_OnReady_InputFilledJS, "InputFilled", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Input"), OS.DataTypes.DataTypes.Text),
HasValue: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Search.OnReady$inputFilledJSResult"))();
jsNodeResult.hasValueOut = OS.DataConversion.JSNodeParamConverter.from($parameters.HasValue, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((inputFilledJSResult.value.hasValueOut)) {
// Open Search
// IsOpen = True
model.variables.isOpenVar = true;
}

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

get _expandOrCollapse$Action() {if(!(this.hasOwnProperty("__expandOrCollapse$Action"))) {
this.__expandOrCollapse$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ExpandOrCollapse", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandOrCollapse");
span.setAttribute("outsystems.function.key", "d015dcab-70d6-458c-bbd5-e431783475de");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandOrCollapse");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Toggle Open
// IsOpen = notIsOpen
model.variables.isOpenVar = (!(model.variables.isOpenVar));
// Collapsed?
return OS.Flow.executeSequence(function () {
if(((!(model.variables.isOpenVar)))) {
// Trigger Event: OnCollapse
return controller.onCollapse$Action(callContext);
} else {
OS.Logger.startActiveSpan("FocusInput", function (span) {
if(span) {
span.setAttribute("code.function", "FocusInput");
span.setAttribute("outsystems.function.key", "7d3b16a1-00b6-4879-9107-6d8d3b04c49c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Search_mvc_controller_ExpandOrCollapse_FocusInputJS, "FocusInput", "ExpandOrCollapse", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Input"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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

return this.__expandOrCollapse$Action;
}set _expandOrCollapse$Action(value) {this.__expandOrCollapse$Action = value;
}


onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1067af2e-fab1-41e5-9991-ccb0ac831f20");
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

expandOrCollapse$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ExpandOrCollapse__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandOrCollapse");
span.setAttribute("outsystems.function.key", "d015dcab-70d6-458c-bbd5-e431783475de");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._expandOrCollapse$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onCollapse$Action() {if(!(this.hasOwnProperty("_onCollapse$Action"))) {
this._onCollapse$Action = function () {
return Promise.resolve();
};
}

return this._onCollapse$Action;
}set onCollapse$Action(value) {this._onCollapse$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Search.OnReady$inputFilledJSResult", [{
name: "HasValue",
attrName: "hasValueOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




