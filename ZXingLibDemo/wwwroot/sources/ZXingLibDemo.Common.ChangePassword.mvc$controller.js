import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as System_Model from "./System_.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
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
this.dataFetchDependenciesOriginal = {
getUserDetail$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserDetail$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getUserDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getUserDetail$AggrRefresh"))) {
this._getUserDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserDetail", "screenservices/ZXingLibDemo/Common/ChangePassword/ScreenDataSetGetUserDetail", "cFGKfCwXRgiuqIx9mcaiKQ", maxRecords, startIndex, function (b) {
model.variables.getUserDetailAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserDetailAggr.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getUserDetailAggr.constructor));
}, undefined, undefined, undefined, callContext, undefined, false);
}.bind(this);
return OS.Logger.startActiveSpan("GetUserDetail", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDetail");
span.setAttribute("outsystems.function.key", "99935c79-947f-49d9-a2bc-096c0afc7b20");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_AGGREGATE_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getUserDetail$AggrRefresh;
}set getUserDetail$AggrRefresh(value) {this._getUserDetail$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserDetail$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _passwordPolicyCompliant$Action() {if(!(this.hasOwnProperty("__passwordPolicyCompliant$Action"))) {
this.__passwordPolicyCompliant$Action = function (isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("PasswordPolicyCompliant", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "07728f75-ef37-4ffd-849b-433e8232002e");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PasswordPolicyCompliant");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.Common.ChangePassword.PasswordPolicyCompliant$vars"))());
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

get _input_OldPasswordOnChange$Action() {if(!(this.hasOwnProperty("__input_OldPasswordOnChange$Action"))) {
this.__input_OldPasswordOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Input_OldPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_OldPasswordOnChange");
span.setAttribute("outsystems.function.key", "63c4eaad-2473-4408-859f-e6820a94c7a3");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_OldPasswordOnChange");
callContext = controller.callContext(callContext);
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

return this.__input_OldPasswordOnChange$Action;
}set _input_OldPasswordOnChange$Action(value) {this.__input_OldPasswordOnChange$Action = value;
}

get _setNewPasswordOnClick$Action() {if(!(this.hasOwnProperty("__setNewPasswordOnClick$Action"))) {
this.__setNewPasswordOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetNewPasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetNewPasswordOnClick");
span.setAttribute("outsystems.function.key", "944ade75-c90e-4b11-8da9-58b8d75db121");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetNewPasswordOnClick");
callContext = controller.callContext(callContext);
var changePasswordVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Passwords matches?
return OS.Flow.executeSequence(function () {
if(((model.variables.newPasswordVar === model.variables.confirmPasswordVar))) {
// Execute Action: ChangePassword
model.flush();
return OS.SystemActions.changePassword(model.variables.getUserDetailAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, model.variables.newPasswordVar, model.variables.oldPasswordVar, callContext).then(function (value) {
changePasswordVar.value = value;
}).then(function () {
// Success?
if((changePasswordVar.value.changePasswordResultOut.successAttr)) {
OS.FeedbackMessageService.showFeedbackMessage("Password successfully changed!", /*Success*/ 1);
// Destination: /ZXingLibDemo/UserProfile
return OS.Flow.returnAsync(OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "UserProfile", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true));
} else {
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// Invalid Credentials?
if((changePasswordVar.value.changePasswordResultOut.changePasswordFailureReasonAttr.invalidCredentialsAttr)) {
// Password invalid
// Input_OldPassword.Valid = False
model.widgets.get(idService.getId("Input_OldPassword")).validAttr = false;
// Input_OldPassword.ValidationMessage = "Incorrect password."
model.widgets.get(idService.getId("Input_OldPassword")).validationMessageAttr = "Incorrect password.";
} else {
// Password Complexity Failed?
if((changePasswordVar.value.changePasswordResultOut.changePasswordFailureReasonAttr.passwordComplexityPolicyFailedAttr)) {
// Complexity Failed
// Input_NewPassword.Valid = False
model.widgets.get(idService.getId("Input_NewPassword")).validAttr = false;
// Input_NewPassword.ValidationMessage = "Password doesn't meet the requirements."
model.widgets.get(idService.getId("Input_NewPassword")).validationMessageAttr = "Password doesn\'t meet the requirements.";
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
OS.FeedbackMessageService.showFeedbackMessage("An unknown error occurred. Please try again later.", /*Error*/ 3);
}

}

}

});
} else {
// Passwords don't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "Password and Confirm password don't match."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = "Password and Confirm password don\'t match.";
// IsExecuting = false
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

return this.__setNewPasswordOnClick$Action;
}set _setNewPasswordOnClick$Action(value) {this.__setNewPasswordOnClick$Action = value;
}

get _setIsButtonEnabled$Action() {if(!(this.hasOwnProperty("__setIsButtonEnabled$Action"))) {
this.__setIsButtonEnabled$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetIsButtonEnabled", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "98a42af6-fda1-4ebd-9c87-d5c7dee35c93");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetIsButtonEnabled");
callContext = controller.callContext(callContext);
// Is OldPassword empty?
if(((model.variables.oldPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword empty?
if(((model.variables.newPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword compliant?
if((model.variables.isNewPasswordCompliantVar)) {
// Is ConfirmPassword empty?
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

get _onToggleConfirmPasswordVisibility$Action() {if(!(this.hasOwnProperty("__onToggleConfirmPasswordVisibility$Action"))) {
this.__onToggleConfirmPasswordVisibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnToggleConfirmPasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleConfirmPasswordVisibility");
span.setAttribute("outsystems.function.key", "b8ed2f84-1636-4cb8-ba83-794fb7df506b");
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

get _onToggleNewPasswordVisibility$Action() {if(!(this.hasOwnProperty("__onToggleNewPasswordVisibility$Action"))) {
this.__onToggleNewPasswordVisibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnToggleNewPasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleNewPasswordVisibility");
span.setAttribute("outsystems.function.key", "bb2480a2-2568-4d6b-bd97-9e3a21650114");
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

get _input_ConfirmPasswordOnChange$Action() {if(!(this.hasOwnProperty("__input_ConfirmPasswordOnChange$Action"))) {
this.__input_ConfirmPasswordOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Input_ConfirmPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "da321b80-6d94-4e9d-916d-2c73bb41746a");
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "f3b60a7a-65ad-4ea9-97f6-9b913c5ba8d9");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// IsExternalUser
if((OS.SystemActions.isExternalUser(callContext).isExternalUserOut)) {
// Destination: /ZXingLibDemo/InvalidPermissions
return OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "InvalidPermissions", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true);
}

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


passwordPolicyCompliant$Action(isValidIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("PasswordPolicyCompliant__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "07728f75-ef37-4ffd-849b-433e8232002e");
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

input_OldPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Input_OldPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_OldPasswordOnChange");
span.setAttribute("outsystems.function.key", "63c4eaad-2473-4408-859f-e6820a94c7a3");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_OldPasswordOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setNewPasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetNewPasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetNewPasswordOnClick");
span.setAttribute("outsystems.function.key", "944ade75-c90e-4b11-8da9-58b8d75db121");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._setNewPasswordOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "98a42af6-fda1-4ebd-9c87-d5c7dee35c93");
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

onToggleConfirmPasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnToggleConfirmPasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleConfirmPasswordVisibility");
span.setAttribute("outsystems.function.key", "b8ed2f84-1636-4cb8-ba83-794fb7df506b");
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

onToggleNewPasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnToggleNewPasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnToggleNewPasswordVisibility");
span.setAttribute("outsystems.function.key", "bb2480a2-2568-4d6b-bd97-9e3a21650114");
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

input_ConfirmPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Input_ConfirmPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "da321b80-6d94-4e9d-916d-2c73bb41746a");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "f3b60a7a-65ad-4ea9-97f6-9b913c5ba8d9");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
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
OS.Authorization.ensureUserHasRole({
roles: [ZXingLibDemoController.default.roles.ZXingLibDemo]
});
}

getDefaultTimeout() {
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ZXingLibDemo.Common.ChangePassword.PasswordPolicyCompliant$vars", [{
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




