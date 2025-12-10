import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_ApplicationLoadEvents_mvc_TranslationsResources from "./OutSystemsUI.Private.ApplicationLoadEvents.mvc$translationsResources.js";
import OutSystemsUI_Private_ApplicationLoadEvents_mvc_controller_OnDestroy_clearTimeoutJS from "./OutSystemsUI.Private.ApplicationLoadEvents.mvc$controller.OnDestroy.clearTimeoutJS.js";
import OutSystemsUI_Private_ApplicationLoadEvents_mvc_controller_OnInitialize_RegisterListenersJS from "./OutSystemsUI.Private.ApplicationLoadEvents.mvc$controller.OnInitialize.RegisterListenersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_ApplicationLoadEvents_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
triggerOnUpgradeProgress$Action: function (completedIn, totalIn) {
completedIn = (completedIn === undefined) ? 0 : completedIn;
totalIn = (totalIn === undefined) ? 0 : totalIn;
return controller.executeActionInsideJSNode(controller._triggerOnUpgradeProgress$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(completedIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(totalIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnUpgradeProgress");
},
triggerOnLoadComplete$Action: function (redirectURLIn) {
redirectURLIn = (redirectURLIn === undefined) ? "" : redirectURLIn;
return controller.executeActionInsideJSNode(controller._triggerOnLoadComplete$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(redirectURLIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnLoadComplete");
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
get _triggerOnUpgradeProgress$Action() {if(!(this.hasOwnProperty("__triggerOnUpgradeProgress$Action"))) {
this.__triggerOnUpgradeProgress$Action = function (completedIn, totalIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnUpgradeProgress", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnUpgradeProgress");
span.setAttribute("outsystems.function.key", "1f2aa346-620a-4702-bff8-57054a79f47e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnUpgradeProgress");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.TriggerOnUpgradeProgress$vars"))());
vars.value.completedInLocal = completedIn;
vars.value.totalInLocal = totalIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnUpgradeProgress
return controller.onUpgradeProgress$Action(vars.value.completedInLocal, vars.value.totalInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnUpgradeProgress$Action;
}set _triggerOnUpgradeProgress$Action(value) {this.__triggerOnUpgradeProgress$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "21aaa761-4cf9-488e-9978-f0f4ae608dfe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Clears the timeout set on the initialize event.
OS.Logger.startActiveSpan("clearTimeout", function (span) {
if(span) {
span.setAttribute("code.function", "clearTimeout");
span.setAttribute("outsystems.function.key", "e89754eb-2fa0-472e-9ecc-0354279dafce");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_ApplicationLoadEvents_mvc_controller_OnDestroy_clearTimeoutJS, "clearTimeout", "OnDestroy", {
IntervalId: OS.DataConversion.JSNodeParamConverter.to(model.variables.intervalIdVar, OS.DataTypes.DataTypes.Integer),
TimeoutId: OS.DataConversion.JSNodeParamConverter.to(model.variables.timeoutIdVar, OS.DataTypes.DataTypes.Integer)
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

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _triggerOnLoadComplete$Action() {if(!(this.hasOwnProperty("__triggerOnLoadComplete$Action"))) {
this.__triggerOnLoadComplete$Action = function (redirectURLIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnLoadComplete", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnLoadComplete");
span.setAttribute("outsystems.function.key", "6b2229f9-cc4c-43a7-9d86-52d7cf210d38");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnLoadComplete");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.TriggerOnLoadComplete$vars"))());
vars.value.redirectURLInLocal = redirectURLIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnLoadComplete
return controller.onLoadComplete$Action(vars.value.redirectURLInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnLoadComplete$Action;
}set _triggerOnLoadComplete$Action(value) {this.__triggerOnLoadComplete$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "b069cb17-8354-42fd-869d-456bf6e7786c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var registerListenersJSResult = new OS.DataTypes.VariableHolder();
registerListenersJSResult.value = OS.Logger.startActiveSpan("RegisterListeners", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterListeners");
span.setAttribute("outsystems.function.key", "47eb6e89-b8ee-4d25-bd33-66ae57a8e765");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_ApplicationLoadEvents_mvc_controller_OnInitialize_RegisterListenersJS, "RegisterListeners", "OnInitialize", {
MinDisplayTimeMs: OS.DataConversion.JSNodeParamConverter.to(model.variables.minimumDisplayTimeMsIn, OS.DataTypes.DataTypes.Integer),
TimeoutId: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
IntervalId: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.OnInitialize$registerListenersJSResult"))();
jsNodeResult.timeoutIdOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TimeoutId, OS.DataTypes.DataTypes.Integer);
jsNodeResult.intervalIdOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IntervalId, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {
TriggerOnUpgradeProgress: controller.clientActionProxies.triggerOnUpgradeProgress$Action,
TriggerOnLoadComplete: controller.clientActionProxies.triggerOnLoadComplete$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// TimeoutId = RegisterListeners.TimeoutId
model.variables.timeoutIdVar = registerListenersJSResult.value.timeoutIdOut;
// IntervalId = RegisterListeners.IntervalId
model.variables.intervalIdVar = registerListenersJSResult.value.intervalIdOut;
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


triggerOnUpgradeProgress$Action(completedIn, totalIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnUpgradeProgress__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnUpgradeProgress");
span.setAttribute("outsystems.function.key", "1f2aa346-620a-4702-bff8-57054a79f47e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnUpgradeProgress$Action, callContext, completedIn, totalIn);
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
span.setAttribute("outsystems.function.key", "21aaa761-4cf9-488e-9978-f0f4ae608dfe");
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

triggerOnLoadComplete$Action(redirectURLIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnLoadComplete__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnLoadComplete");
span.setAttribute("outsystems.function.key", "6b2229f9-cc4c-43a7-9d86-52d7cf210d38");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnLoadComplete$Action, callContext, redirectURLIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "b069cb17-8354-42fd-869d-456bf6e7786c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
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

get onUpgradeProgress$Action() {if(!(this.hasOwnProperty("_onUpgradeProgress$Action"))) {
this._onUpgradeProgress$Action = function () {
return Promise.resolve();
};
}

return this._onUpgradeProgress$Action;
}set onUpgradeProgress$Action(value) {this._onUpgradeProgress$Action = value;
}

get onLoadComplete$Action() {if(!(this.hasOwnProperty("_onLoadComplete$Action"))) {
this._onLoadComplete$Action = function () {
return Promise.resolve();
};
}

return this._onLoadComplete$Action;
}set onLoadComplete$Action(value) {this._onLoadComplete$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.TriggerOnUpgradeProgress$vars", [{
name: "Completed",
attrName: "completedInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Total",
attrName: "totalInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.TriggerOnLoadComplete$vars", [{
name: "RedirectURL",
attrName: "redirectURLInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.ApplicationLoadEvents.OnInitialize$registerListenersJSResult", [{
name: "TimeoutId",
attrName: "timeoutIdOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IntervalId",
attrName: "intervalIdOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




