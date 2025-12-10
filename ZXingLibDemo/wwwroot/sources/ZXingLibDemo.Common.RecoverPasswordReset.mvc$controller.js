import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import * as System_Model from "./System_.model.js";
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
get _onToggleConfirmPasswordVisibility$Action() {if(!(this.hasOwnProperty("__onToggleConfirmPasswordVisibility$Action"))) {
this.__onToggleConfirmPasswordVisibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnToggleConfirmPasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleConfirmPasswordVisibility");
span.setAttribute("outsystems.function.key", "1d6f1416-e59d-4785-a0f6-447ea5c5c298");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnToggleConfirmPasswordVisibility");
callContext = controller.callContext(callContext);
var showPasswordVar = new OS.DataTypes.VariableHolder();
// IsConfirmPasswordVisible = notIsConfirmPasswordVisible
model.variables.isConfirmPasswordVisibleVar = (!(model.variables.isConfirmPasswordVisibleVar));
// Execute Action: ShowPassword
showPasswordVar.value = OutSystemsUIController.default.showPassword$Action(idService.getId("Input_ConfirmPassword"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onToggleConfirmPasswordVisibility$Action;
}set _onToggleConfirmPasswordVisibility$Action(value) {this.__onToggleConfirmPasswordVisibility$Action = value;
}

get _passwordPolicyCompliant$Action() {if(!(this.hasOwnProperty("__passwordPolicyCompliant$Action"))) {
this.__passwordPolicyCompliant$Action = function (isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("PasswordPolicyCompliant", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "5daacc87-042d-496f-b2e5-ceeb36778e92");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PasswordPolicyCompliant");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.Common.RecoverPasswordReset.PasswordPolicyCompliant$vars"))());
vars.value.isValidInLocal = isValidIn;
// IsNewPasswordCompliant = IsValid
model.variables.isNewPasswordCompliantVar = vars.value.isValidInLocal;
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__passwordPolicyCompliant$Action;
}set _passwordPolicyCompliant$Action(value) {this.__passwordPolicyCompliant$Action = value;
}

get _input_ConfirmPasswordOnChange$Action() {if(!(this.hasOwnProperty("__input_ConfirmPasswordOnChange$Action"))) {
this.__input_ConfirmPasswordOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Input_ConfirmPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "5eca7252-a4ae-44bb-af74-76a5230b6146");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_ConfirmPasswordOnChange");
callContext = controller.callContext(callContext);
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
// IsEmpty
if(((model.variables.confirmPasswordVar === ""))) {
// ClearErrors
// Input_ConfirmPassword.Valid = True
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = true;
// Input_ConfirmPassword.ValidationMessage = ""
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = "";
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__input_ConfirmPasswordOnChange$Action;
}set _input_ConfirmPasswordOnChange$Action(value) {this.__input_ConfirmPasswordOnChange$Action = value;
}

get _onToggleNewPasswordVisibility$Action() {if(!(this.hasOwnProperty("__onToggleNewPasswordVisibility$Action"))) {
this.__onToggleNewPasswordVisibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnToggleNewPasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleNewPasswordVisibility");
span.setAttribute("outsystems.function.key", "6b47eae9-6b58-4c2a-99b5-a23367bdea3a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnToggleNewPasswordVisibility");
callContext = controller.callContext(callContext);
var showPasswordVar = new OS.DataTypes.VariableHolder();
// IsPasswordVisible = notIsPasswordVisible
model.variables.isPasswordVisibleVar = (!(model.variables.isPasswordVisibleVar));
// Execute Action: ShowPassword
showPasswordVar.value = OutSystemsUIController.default.showPassword$Action(idService.getId("Input_NewPassword"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onToggleNewPasswordVisibility$Action;
}set _onToggleNewPasswordVisibility$Action(value) {this.__onToggleNewPasswordVisibility$Action = value;
}

get _savePasswordOnClick$Action() {if(!(this.hasOwnProperty("__savePasswordOnClick$Action"))) {
this.__savePasswordOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SavePasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SavePasswordOnClick");
span.setAttribute("outsystems.function.key", "8ee08f37-32b0-43ca-87e0-c49da7dcae74");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SavePasswordOnClick");
callContext = controller.callContext(callContext);
var doLoginVar = new OS.DataTypes.VariableHolder();
var finishResetPasswordVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("PasswordResetForm")).validAttr)) {
return OS.Flow.executeSequence(function () {
if((model.variables.isButtonEnabledVar)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Passwords match?
return OS.Flow.executeSequence(function () {
if(((model.variables.newPasswordVar === model.variables.confirmPasswordVar))) {
// Execute Action: FinishResetPassword
model.flush();
return OS.SystemActions.finishResetPassword(model.variables.emailIn, model.variables.verificationCodeIn, model.variables.newPasswordVar, callContext).then(function (value) {
finishResetPasswordVar.value = value;
}).then(function () {
// Reset successful?
return OS.Flow.executeSequence(function () {
if((finishResetPasswordVar.value.finishResetPasswordResultOut.successAttr)) {
// Password changed successfully
OS.FeedbackMessageService.showFeedbackMessage("Your password was changed successfully!", /*Success*/ 1);
// Execute Action: DoLogin
model.flush();
return ZXingLibDemoController.default.doLogin$Action(model.variables.emailIn, model.variables.newPasswordVar, callContext).then(function (value) {
doLoginVar.value = value;
}).then(function () {
// Success?
if((doLoginVar.value.successOut)) {
// Destination: /ZXingLibDemo/
return OS.Flow.returnAsync(OS.Navigation.navigateTo(OS.Navigation.generateScreenURL(OS.BuiltinFunctions.getOwnerURLPath(), {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Destination: /ZXingLibDemo/Login
return OS.Flow.returnAsync(OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "Login", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true));
}

});
} else {
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// Password Complexity Failed?
if((finishResetPasswordVar.value.finishResetPasswordResultOut.finishResetPasswordFailureReasonAttr.passwordComplexityPolicyFailedAttr)) {
// Password invalid
// Input_NewPassword.Valid = False
model.widgets.get(idService.getId("Input_NewPassword")).validAttr = false;
// Input_NewPassword.ValidationMessage = "The password does not meet the requirements."
model.widgets.get(idService.getId("Input_NewPassword")).validationMessageAttr = "The password does not meet the requirements.";
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Invalid Reset Token?
if((finishResetPasswordVar.value.finishResetPasswordResultOut.finishResetPasswordFailureReasonAttr.invalidVerificationCodeAttr)) {
// Invalid code
// Input_Code.Valid = False
model.widgets.get(idService.getId("Input_Code")).validAttr = false;
// Input_Code.ValidationMessage = "The code is invalid."
model.widgets.get(idService.getId("Input_Code")).validationMessageAttr = "The code is invalid.";
} else {
// Unkown Error
OS.FeedbackMessageService.showFeedbackMessage("An unknown error occured. Please try again later.", /*Error*/ 3);
}

}

}

});
});
} else {
// Password doesn't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "Passwords doesn't match."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = "Passwords doesn\'t match.";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
}

});
} else {
// Disable Button
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
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

return this.__savePasswordOnClick$Action;
}set _savePasswordOnClick$Action(value) {this.__savePasswordOnClick$Action = value;
}

get _input_CodeOnChange$Action() {if(!(this.hasOwnProperty("__input_CodeOnChange$Action"))) {
this.__input_CodeOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Input_CodeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_CodeOnChange");
span.setAttribute("outsystems.function.key", "d76a7e1a-9641-4607-8a3d-e1ae1c1ddb89");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_CodeOnChange");
callContext = controller.callContext(callContext);
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
// IsEmpty
if(((model.variables.verificationCodeIn === ""))) {
// ClearErrors
// Input_Code.Valid = True
model.widgets.get(idService.getId("Input_Code")).validAttr = true;
// Input_Code.ValidationMessage = ""
model.widgets.get(idService.getId("Input_Code")).validationMessageAttr = "";
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__input_CodeOnChange$Action;
}set _input_CodeOnChange$Action(value) {this.__input_CodeOnChange$Action = value;
}

get _setIsButtonEnabled$Action() {if(!(this.hasOwnProperty("__setIsButtonEnabled$Action"))) {
this.__setIsButtonEnabled$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetIsButtonEnabled", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "f0bf0d0f-6564-4593-957b-d6e4b44703ee");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetIsButtonEnabled");
callContext = controller.callContext(callContext);
// Is Code Empty?
if(((model.variables.verificationCodeIn === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword Empty?
if(((model.variables.newPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword Compliant?
if((model.variables.isNewPasswordCompliantVar)) {
// Is ConfirmPassword Empty?
if(((model.variables.confirmPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// EnableButton
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
}

} else {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
}

}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setIsButtonEnabled$Action;
}set _setIsButtonEnabled$Action(value) {this.__setIsButtonEnabled$Action = value;
}


onToggleConfirmPasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnToggleConfirmPasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleConfirmPasswordVisibility");
span.setAttribute("outsystems.function.key", "1d6f1416-e59d-4785-a0f6-447ea5c5c298");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onToggleConfirmPasswordVisibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

passwordPolicyCompliant$Action(isValidIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("PasswordPolicyCompliant__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "5daacc87-042d-496f-b2e5-ceeb36778e92");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._passwordPolicyCompliant$Action, callContext, isValidIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_ConfirmPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Input_ConfirmPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "5eca7252-a4ae-44bb-af74-76a5230b6146");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_ConfirmPasswordOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onToggleNewPasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnToggleNewPasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleNewPasswordVisibility");
span.setAttribute("outsystems.function.key", "6b47eae9-6b58-4c2a-99b5-a23367bdea3a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onToggleNewPasswordVisibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

savePasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SavePasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SavePasswordOnClick");
span.setAttribute("outsystems.function.key", "8ee08f37-32b0-43ca-87e0-c49da7dcae74");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._savePasswordOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

input_CodeOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Input_CodeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_CodeOnChange");
span.setAttribute("outsystems.function.key", "d76a7e1a-9641-4607-8a3d-e1ae1c1ddb89");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_CodeOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "f0bf0d0f-6564-4593-957b-d6e4b44703ee");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setIsButtonEnabled$Action, callContext);
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
Controller.registerVariableGroupType("ZXingLibDemo.Common.RecoverPasswordReset.PasswordPolicyCompliant$vars", [{
name: "IsValid",
attrName: "isValidInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




