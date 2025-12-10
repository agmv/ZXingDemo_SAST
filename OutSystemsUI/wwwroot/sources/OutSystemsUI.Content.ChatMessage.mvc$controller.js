import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Content_ChatMessage_mvc_TranslationsResources from "./OutSystemsUI.Content.ChatMessage.mvc$translationsResources.js";
import OutSystemsUI_Content_ChatMessage_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Content.ChatMessage.mvc$controller.OnReady.InitJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Content_ChatMessage_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
showStatus$Action: function () {
return controller.executeActionInsideJSNode(controller._showStatus$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ShowStatus");
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
get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "295f302f-24ad-4210-a1e0-cc0f919770a1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "c791d59a-d7ec-4c5c-ba80-c657ace9b0b1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_ChatMessage_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
ElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Message"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
ShowStatus: controller.clientActionProxies.showStatus$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set IsWebApp
// IsWebApp = IsWebApp()
model.variables.isWebAppVar = OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut;
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

get _showStatus$Action() {if(!(this.hasOwnProperty("__showStatus$Action"))) {
this.__showStatus$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ShowStatus", function (span) {
if(span) {
span.setAttribute("code.function", "ShowStatus");
span.setAttribute("outsystems.function.key", "eed9b917-8f91-4456-916a-368accad4615");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowStatus");
callContext = controller.callContext(callContext);
// Toggle StatusVisible
// StatusVisible = notStatusVisible
model.variables.statusVisibleVar = (!(model.variables.statusVisibleVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__showStatus$Action;
}set _showStatus$Action(value) {this.__showStatus$Action = value;
}


onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "295f302f-24ad-4210-a1e0-cc0f919770a1");
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

showStatus$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ShowStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowStatus");
span.setAttribute("outsystems.function.key", "eed9b917-8f91-4456-916a-368accad4615");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showStatus$Action, callContext);
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

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




