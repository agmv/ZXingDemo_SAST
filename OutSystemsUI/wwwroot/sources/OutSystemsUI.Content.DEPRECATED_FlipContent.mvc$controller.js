import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Content_DEPRECATED_FlipContent_mvc_TranslationsResources from "./OutSystemsUI.Content.DEPRECATED_FlipContent.mvc$translationsResources.js";
import OutSystemsUI_Content_DEPRECATED_FlipContent_mvc_controller_OnReady_addEventListenerJS from "./OutSystemsUI.Content.DEPRECATED_FlipContent.mvc$controller.OnReady.addEventListenerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Content_DEPRECATED_FlipContent_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
toggleFlip$Action: function () {
return controller.executeActionInsideJSNode(controller._toggleFlip$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ToggleFlip");
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
get _toggleFlip$Action() {if(!(this.hasOwnProperty("__toggleFlip$Action"))) {
this.__toggleFlip$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ToggleFlip", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleFlip");
span.setAttribute("outsystems.function.key", "022e4a83-c68b-4d2e-99a6-546ffc54c9e0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ToggleFlip");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.variables.flipSelfIn)) {
// IsFlipped = notIsFlipped
model.variables.isFlippedIn = (!(model.variables.isFlippedIn));
// Trigger Event: OnFlip
return controller.onFlip$Action(model.variables.isFlippedIn, callContext);
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

return this.__toggleFlip$Action;
}set _toggleFlip$Action(value) {this.__toggleFlip$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "d4b34c2e-b5b9-48b2-ab9e-5bbcaa4ae1f3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
if((model.variables.flipSelfIn)) {
OS.Logger.startActiveSpan("addEventListener", function (span) {
if(span) {
span.setAttribute("code.function", "addEventListener");
span.setAttribute("outsystems.function.key", "2e3debc0-693d-4592-a4dd-739598285749");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_FlipContent_mvc_controller_OnReady_addEventListenerJS, "addEventListener", "OnReady", {
ElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("FlipContainer"), OS.DataTypes.DataTypes.Text),
WrappperId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("FlipWrapper"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
ToggleFlip: controller.clientActionProxies.toggleFlip$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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


toggleFlip$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ToggleFlip__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleFlip");
span.setAttribute("outsystems.function.key", "022e4a83-c68b-4d2e-99a6-546ffc54c9e0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._toggleFlip$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d4b34c2e-b5b9-48b2-ab9e-5bbcaa4ae1f3");
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

get onFlip$Action() {if(!(this.hasOwnProperty("_onFlip$Action"))) {
this._onFlip$Action = function () {
return Promise.resolve();
};
}

return this._onFlip$Action;
}set onFlip$Action(value) {this._onFlip$Action = value;
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




