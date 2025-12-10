import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import ZXingLibDemoLanguageResources from "./ZXingLibDemo.languageResources.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";
import ZXingLibDemo_CommonController from "./ZXingLibDemo.Common.controller.js";

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
get _onTogglePasswordVisibility$Action() {if(!(this.hasOwnProperty("__onTogglePasswordVisibility$Action"))) {
this.__onTogglePasswordVisibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnTogglePasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "26c085d1-acb2-40e4-8d40-9d907dc2e86d");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnTogglePasswordVisibility");
callContext = controller.callContext(callContext);
var showPasswordVar = new OS.DataTypes.VariableHolder();
// IsPasswordVisible = notIsPasswordVisible
model.variables.isPasswordVisibleVar = (!(model.variables.isPasswordVisibleVar));
// Execute Action: ShowPassword
showPasswordVar.value = OutSystemsUIController.default.showPassword$Action("", callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onTogglePasswordVisibility$Action;
}set _onTogglePasswordVisibility$Action(value) {this.__onTogglePasswordVisibility$Action = value;
}

get _loginOnClick$Action() {if(!(this.hasOwnProperty("__loginOnClick$Action"))) {
this.__loginOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("LoginOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClick");
span.setAttribute("outsystems.function.key", "fb636e0c-5502-414e-8a4e-7a424b00b5b4");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("LoginOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var doLoginVar = new OS.DataTypes.VariableHolder();
var checkZXingLibDemoRoleVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("LoginForm")).validAttr)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Execute Action: FeedbackMessageClose
OutSystemsUIController.default.feedbackMessageClose$Action(callContext);
// Execute Action: DoLogin
model.flush();
return ZXingLibDemoController.default.doLogin$Action(model.variables.userEmailVar, model.variables.passwordVar, callContext).then(function (value) {
doLoginVar.value = value;
}).then(function () {
// Execute Action: CheckZXingLibDemoRole
checkZXingLibDemoRoleVar.value = ZXingLibDemoController.default.checkZXingLibDemoRole$Action(callContext);

}).then(function () {
// Has Role?
if((checkZXingLibDemoRoleVar.value.hasRoleOut)) {
// Success?
if((doLoginVar.value.successOut)) {
// Destination: /ZXingLibDemo/
return OS.Flow.returnAsync(OS.Navigation.navigateTo(OS.Navigation.generateScreenURL((((ZXingLibDemoClientVariables.getLastURL() === "")) ? (OS.BuiltinFunctions.getOwnerURLPath()) : (ZXingLibDemoClientVariables.getLastURL())), {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Fade), callContext, true));
} else {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// ErrorMessage
OS.FeedbackMessageService.showFeedbackMessage(doLoginVar.value.errorMessageOut, /*Error*/ 3);
}

} else {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// No Permission
OS.FeedbackMessageService.showFeedbackMessage("No permission.", /*Error*/ 3);
}

});
}

});
}).catch(function (ex) {
OS.Logger.debug("Login.LoginOnClick", OS.Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS.Exceptions.isSystem(ex))) {
OS.Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "afe930a8-feb9-4864-971c-54a89221df8a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS.Flow.tryFinally(function () {
return OS.Flow.executeAsyncFlow(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
OS.FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
return OS.Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__loginOnClick$Action;
}set _loginOnClick$Action(value) {this.__loginOnClick$Action = value;
}


onTogglePasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnTogglePasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "26c085d1-acb2-40e4-8d40-9d907dc2e86d");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onTogglePasswordVisibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

loginOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("LoginOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClick");
span.setAttribute("outsystems.function.key", "fb636e0c-5502-414e-8a4e-7a424b00b5b4");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._loginOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
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
return ZXingLibDemo_CommonController.default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




