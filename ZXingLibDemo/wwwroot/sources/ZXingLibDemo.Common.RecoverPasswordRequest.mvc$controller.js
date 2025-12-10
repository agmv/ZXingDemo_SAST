import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
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
get sendResetPasswordEmail$ServerAction() {if(!(this.hasOwnProperty("_sendResetPasswordEmail$ServerAction"))) {
this._sendResetPasswordEmail$ServerAction = function (applicationNameIn, customerEmailIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SendResetPasswordEmail", function (span) {
if(span) {
span.setAttribute("code.function", "SendResetPasswordEmail");
span.setAttribute("outsystems.function.key", "82e5273e-87b6-4b68-8444-51cff0af2c32");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
var inputs = {
ApplicationName: OS.DataConversion.ServerDataConverter.to(applicationNameIn, OS.DataTypes.DataTypes.Text),
CustomerEmail: OS.DataConversion.ServerDataConverter.to(customerEmailIn, OS.DataTypes.DataTypes.Email)
};
return controller.callServerAction("SendResetPasswordEmail", "screenservices/ZXingLibDemo/Common/RecoverPasswordRequest/ActionSendResetPasswordEmail", "ZQ3JIWE5Y0g+GWpXfIJc8A", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ZXingLibDemo.Common.RecoverPasswordRequest$ActionSendResetPasswordEmail"))();
executeServerActionResult.successOut = OS.DataConversion.ServerDataConverter.from(outputs.Success, OS.DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
}

return this._sendResetPasswordEmail$ServerAction;
}set sendResetPasswordEmail$ServerAction(value) {this._sendResetPasswordEmail$ServerAction = value;
}


// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _resetPasswordOnClick$Action() {if(!(this.hasOwnProperty("__resetPasswordOnClick$Action"))) {
this.__resetPasswordOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ResetPasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ResetPasswordOnClick");
span.setAttribute("outsystems.function.key", "3aad2e06-92b3-4cc7-8b61-e9d6e85af93b");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ResetPasswordOnClick");
callContext = controller.callContext(callContext);
var sendResetPasswordEmailVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("RecoverPasswordForm")).validAttr)) {
// IsExecuting = True
model.variables.isExecutingVar = true;
// Execute Action: SendResetPasswordEmail
model.flush();
return controller.sendResetPasswordEmail$ServerAction(OS.BuiltinFunctions.getAppName(), model.variables.emailVar, callContext).then(function (value) {
sendResetPasswordEmailVar.value = value;
}).then(function () {
// Success?
if((sendResetPasswordEmailVar.value.successOut)) {
// IsExecuting
// IsExecuting = False
model.variables.isExecutingVar = false;
// Destination: /ZXingLibDemo/RecoverPasswordReset
return OS.Flow.returnAsync(OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "RecoverPasswordReset", {
Email: OS.DataConversion.ServerDataConverter.to(model.variables.emailVar, OS.DataTypes.DataTypes.Email)
}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS.FeedbackMessageService.showFeedbackMessage("An error has occured. Please try again later.", /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
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

return this.__resetPasswordOnClick$Action;
}set _resetPasswordOnClick$Action(value) {this.__resetPasswordOnClick$Action = value;
}


resetPasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ResetPasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetPasswordOnClick");
span.setAttribute("outsystems.function.key", "3aad2e06-92b3-4cc7-8b61-e9d6e85af93b");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._resetPasswordOnClick$Action, callContext);
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
Controller.registerVariableGroupType("ZXingLibDemo.Common.RecoverPasswordRequest$ActionSendResetPasswordEmail", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




