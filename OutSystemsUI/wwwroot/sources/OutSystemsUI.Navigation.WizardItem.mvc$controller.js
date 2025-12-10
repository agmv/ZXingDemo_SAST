import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_WizardItem_mvc_TranslationsResources from "./OutSystemsUI.Navigation.WizardItem.mvc$translationsResources.js";
import OutSystemsUI_Navigation_WizardItem_mvc_controller_OnReady_SetAriaLabelJS from "./OutSystemsUI.Navigation.WizardItem.mvc$controller.OnReady.SetAriaLabelJS.js";
import OutSystemsUI_Navigation_WizardItem_mvc_controller_WizardItemOnKeypress_OnKeyPress_CheckEnterJS from "./OutSystemsUI.Navigation.WizardItem.mvc$controller.WizardItemOnKeypress.OnKeyPress_CheckEnterJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_WizardItem_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
triggerClick$Action: function () {
return controller.executeActionInsideJSNode(controller._triggerClick$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerClick");
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
span.setAttribute("outsystems.function.key", "134be174-3029-4947-8cb2-316417ab0c04");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("SetAriaLabel", function (span) {
if(span) {
span.setAttribute("code.function", "SetAriaLabel");
span.setAttribute("outsystems.function.key", "5e15b99f-7182-4f9e-b579-f7aed8d10959");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_WizardItem_mvc_controller_OnReady_SetAriaLabelJS, "SetAriaLabel", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("WizardWrapperItem"), OS.DataTypes.DataTypes.Text)
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

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _triggerClick$Action() {if(!(this.hasOwnProperty("__triggerClick$Action"))) {
this.__triggerClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerClick", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerClick");
span.setAttribute("outsystems.function.key", "34244f6e-370e-4c05-a372-278b11ab20f8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnClick
return controller.onClick$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerClick$Action;
}set _triggerClick$Action(value) {this.__triggerClick$Action = value;
}

get _wizardItemOnKeypress$Action() {if(!(this.hasOwnProperty("__wizardItemOnKeypress$Action"))) {
this.__wizardItemOnKeypress$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("WizardItemOnKeypress", function (span) {
if(span) {
span.setAttribute("code.function", "WizardItemOnKeypress");
span.setAttribute("outsystems.function.key", "7ec5b89d-888b-4353-b4b7-acc68a58ee22");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("WizardItemOnKeypress");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("OnKeyPress_CheckEnter", function (span) {
if(span) {
span.setAttribute("code.function", "OnKeyPress_CheckEnter");
span.setAttribute("outsystems.function.key", "42174d82-1844-4efd-9901-f8b9db0600e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_WizardItem_mvc_controller_WizardItemOnKeypress_OnKeyPress_CheckEnterJS, "OnKeyPress_CheckEnter", "WizardItemOnKeypress", null, function ($parameters) {
}, {
TriggerClick: controller.clientActionProxies.triggerClick$Action
}, {});
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

return this.__wizardItemOnKeypress$Action;
}set _wizardItemOnKeypress$Action(value) {this.__wizardItemOnKeypress$Action = value;
}


onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "134be174-3029-4947-8cb2-316417ab0c04");
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

triggerClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerClick");
span.setAttribute("outsystems.function.key", "34244f6e-370e-4c05-a372-278b11ab20f8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wizardItemOnKeypress$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("WizardItemOnKeypress__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "WizardItemOnKeypress");
span.setAttribute("outsystems.function.key", "7ec5b89d-888b-4353-b4b7-acc68a58ee22");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wizardItemOnKeypress$Action, callContext);
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




