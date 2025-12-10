import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_PullToRefresh_mvc_TranslationsResources from "./OutSystemsUI.Private.PullToRefresh.mvc$translationsResources.js";
import OutSystemsUI_Private_PullToRefresh_mvc_controller_OnDestroy_JsDestroyWebPullToRefreshJS from "./OutSystemsUI.Private.PullToRefresh.mvc$controller.OnDestroy.JsDestroyWebPullToRefreshJS.js";
import OutSystemsUI_Private_PullToRefresh_mvc_controller_OnReady_JsInitWebPullToRefreshJS from "./OutSystemsUI.Private.PullToRefresh.mvc$controller.OnReady.JsInitWebPullToRefreshJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_PullToRefresh_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
triggerOnContentPull$Action: function () {
return controller.executeActionInsideJSNode(controller._triggerOnContentPull$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnContentPull");
},
updateStatus$Action: function (isRefreshingCbIn) {
isRefreshingCbIn = (isRefreshingCbIn === undefined) ? false : isRefreshingCbIn;
return controller.executeActionInsideJSNode(controller._updateStatus$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(isRefreshingCbIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateStatus");
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
get _triggerOnContentPull$Action() {if(!(this.hasOwnProperty("__triggerOnContentPull$Action"))) {
this.__triggerOnContentPull$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnContentPull", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnContentPull");
span.setAttribute("outsystems.function.key", "0d5a49ff-7ffe-43fe-8986-f235ff8db87b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnContentPull");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnContentPull
return controller.onContentPull$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnContentPull$Action;
}set _triggerOnContentPull$Action(value) {this.__triggerOnContentPull$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "309272ea-0708-4e6a-bcc0-ed98f72eb8dd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Javascript node to destroy the WebPullToRefresh instance.
OS.Logger.startActiveSpan("JsDestroyWebPullToRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "JsDestroyWebPullToRefresh");
span.setAttribute("outsystems.function.key", "7b1942b1-47cc-4427-84c5-09d7def524cb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_PullToRefresh_mvc_controller_OnDestroy_JsDestroyWebPullToRefreshJS, "JsDestroyWebPullToRefresh", "OnDestroy", null, function ($parameters) {
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

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "b1e7a8c6-6b93-4a7a-9c2e-7861d47a4dd7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Javascript node to initialize the WebPullToRefresh instance.
OS.Logger.startActiveSpan("JsInitWebPullToRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "JsInitWebPullToRefresh");
span.setAttribute("outsystems.function.key", "16a2eaaf-7d41-4b83-8f8d-19c3930027a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_PullToRefresh_mvc_controller_OnReady_JsInitWebPullToRefreshJS, "JsInitWebPullToRefresh", "OnReady", {
PullToRefreshA11YContainerId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ptrA11y"), OS.DataTypes.DataTypes.Text),
PullToRefreshContainerId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ptr"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
TriggerOnContentPull: controller.clientActionProxies.triggerOnContentPull$Action,
UpdateStatus: controller.clientActionProxies.updateStatus$Action
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

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _updateStatus$Action() {if(!(this.hasOwnProperty("__updateStatus$Action"))) {
this.__updateStatus$Action = function (isRefreshingCbIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateStatus", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateStatus");
span.setAttribute("outsystems.function.key", "baf9da5b-d633-4aab-af0f-8522cb2786f5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateStatus");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.PullToRefresh.UpdateStatus$vars"))());
vars.value.isRefreshingCbInLocal = isRefreshingCbIn;
// IsFirstTimeUsed = True
model.variables.isFirstTimeUsedVar = true;
// IsRefreshing = IsRefreshingCb
model.variables.isRefreshingVar = vars.value.isRefreshingCbInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__updateStatus$Action;
}set _updateStatus$Action(value) {this.__updateStatus$Action = value;
}


triggerOnContentPull$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnContentPull__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnContentPull");
span.setAttribute("outsystems.function.key", "0d5a49ff-7ffe-43fe-8986-f235ff8db87b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnContentPull$Action, callContext);
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
span.setAttribute("outsystems.function.key", "309272ea-0708-4e6a-bcc0-ed98f72eb8dd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "b1e7a8c6-6b93-4a7a-9c2e-7861d47a4dd7");
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

updateStatus$Action(isRefreshingCbIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateStatus");
span.setAttribute("outsystems.function.key", "baf9da5b-d633-4aab-af0f-8522cb2786f5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateStatus$Action, callContext, isRefreshingCbIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onContentPull$Action() {if(!(this.hasOwnProperty("_onContentPull$Action"))) {
this._onContentPull$Action = function () {
return Promise.resolve();
};
}

return this._onContentPull$Action;
}set onContentPull$Action(value) {this._onContentPull$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.PullToRefresh.UpdateStatus$vars", [{
name: "IsRefreshingCb",
attrName: "isRefreshingCbInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




