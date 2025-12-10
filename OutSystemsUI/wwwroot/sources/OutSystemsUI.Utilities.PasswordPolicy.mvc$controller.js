import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import * as System_Model from "./System_.model.js";
import "./OutSystemsUI.referencesHealth.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Utilities_PasswordPolicy_mvc_TranslationsResources from "./OutSystemsUI.Utilities.PasswordPolicy.mvc$translationsResources.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Utilities_PasswordPolicy_mvc_TranslationsResources);
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
get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "0800c9f1-0d86-48cf-adb4-2a7ba6216122");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var getPasswordComplexityPolicyVar = new OS.DataTypes.VariableHolder();
// Execute Action: GetPasswordComplexityPolicy
getPasswordComplexityPolicyVar.value = OS.SystemActions.getPasswordComplexityPolicy(callContext);

// Set initial values
// PasswordComplexityPolicy = GetPasswordComplexityPolicy.PasswordComplexityPolicy
model.variables.passwordComplexityPolicyVar = getPasswordComplexityPolicyVar.value.passwordComplexityPolicyOut;
// PasswordValidationResult.IsValid = False
model.variables.passwordValidationResultVar.isValidAttr = false;
// PasswordValidationResult.MissingLowerCaseLetter = True
model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr = true;
// PasswordValidationResult.MissingMinimumLength = True
model.variables.passwordValidationResultVar.missingMinimumLengthAttr = true;
// PasswordValidationResult.MissingUpperCaseLetter = True
model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr = true;
// PasswordValidationResult.MissingNumber = True
model.variables.passwordValidationResultVar.missingNumberAttr = true;
// PasswordValidationResult.MissingSpecialCharacter = True
model.variables.passwordValidationResultVar.missingSpecialCharacterAttr = true;
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7f9bf3e7-8c2a-4fe7-b221-5485b960ba25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var validatePasswordComplexityVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: ValidatePasswordComplexity
validatePasswordComplexityVar.value = OS.SystemActions.validatePasswordComplexity(model.variables.passwordIn, callContext);

// PasswordValidationResult
// PasswordValidationResult.IsValid = ValidatePasswordComplexity.PasswordValidationResult.IsValid
model.variables.passwordValidationResultVar.isValidAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr;
// PasswordValidationResult.MissingLowerCaseLetter = ValidatePasswordComplexity.PasswordValidationResult.MissingLowerCaseLetter
model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingLowerCaseLetterAttr;
// PasswordValidationResult.MissingMinimumLength = ValidatePasswordComplexity.PasswordValidationResult.MissingMinimumLength
model.variables.passwordValidationResultVar.missingMinimumLengthAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingMinimumLengthAttr;
// PasswordValidationResult.MissingUpperCaseLetter = ValidatePasswordComplexity.PasswordValidationResult.MissingUpperCaseLetter
model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingUpperCaseLetterAttr;
// PasswordValidationResult.MissingNumber = ValidatePasswordComplexity.PasswordValidationResult.MissingNumber
model.variables.passwordValidationResultVar.missingNumberAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingNumberAttr;
// PasswordValidationResult.MissingSpecialCharacter = ValidatePasswordComplexity.PasswordValidationResult.MissingSpecialCharacter
model.variables.passwordValidationResultVar.missingSpecialCharacterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingSpecialCharacterAttr;
// Is valid?
if((validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr)) {
if((model.variables.isValidPasswordVar)) {
return OS.Flow.returnAsync();

} else {
// Set as valid
// IsValidPassword = True
model.variables.isValidPasswordVar = true;
}

} else {
if((model.variables.isValidPasswordVar)) {
// Set as invalid
// IsValidPassword = False
model.variables.isValidPasswordVar = false;
} else {
return OS.Flow.returnAsync();

}

}

// Trigger Event: Compliant
return controller.compliant$Action(validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}


onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "0800c9f1-0d86-48cf-adb4-2a7ba6216122");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7f9bf3e7-8c2a-4fe7-b221-5485b960ba25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get compliant$Action() {if(!(this.hasOwnProperty("_compliant$Action"))) {
this._compliant$Action = function () {
return Promise.resolve();
};
}

return this._compliant$Action;
}set compliant$Action(value) {this._compliant$Action = value;
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
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
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




