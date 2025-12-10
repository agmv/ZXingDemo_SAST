import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
class Controller extends 
OS.Controller.BaseController {
getDefaultTimeout() {
return ZXingLibDemoController.default.defaultTimeout;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnException", function (span) {
if(span) {
span.setAttribute("code.function", "OnException");
span.setAttribute("outsystems.function.key", "1a118907-e7fa-4938-90a2-703c8abe0fca.#FlowExceptionHandler");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {var securityExceptionVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var allExceptionsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var dataBaseExceptionVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var communicationExceptionVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
OS.Logger.debug("Common.OnException", OS.Exceptions.getMessage(ex));
if(OS.ErrorHandling.ignoreError(ex, callContext)) {
return OS.ErrorHandling.IGNORED_ERROR_RESULT;
}

try {OS.Logger.debug("Common.OnException", OS.Exceptions.getMessage(ex));
// Handle Error: SecurityException
if(OS.Exceptions.isInstanceOf(ex, OS.Exceptions.Exceptions.SecurityException)) {
securityExceptionVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("SecurityException", function (span) {
if(span) {
span.setAttribute("code.function", "SecurityException");
span.setAttribute("outsystems.function.key", "1db0d2fa-26aa-479a-9520-99a3a5d75a3a");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {// Logged User?
if(((((OS.BuiltinFunctions.getUserId()).toString()) !== (OS.BuiltinFunctions.nullTextIdentifier())))) {
// Destination: /ZXingLibDemo/InvalidPermissions
return OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "InvalidPermissions", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true);
} else {
// LastRequest
// LastURL = GetBookmarkableURL
ZXingLibDemoClientVariables.setLastURL(OS.BuiltinFunctions.getBookmarkableURL());
// Destination: /ZXingLibDemo/Login
return OS.Navigation.navigateTo(OS.Navigation.generateScreenURL("ZXingLibDemo", "Login", {}), OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Handle Error: DataBaseException
if(OS.Exceptions.isInstanceOf(ex, OS.Exceptions.Exceptions.DataBaseException)) {
OS.Logger.error(null, ex, null, null, 1);
dataBaseExceptionVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("DataBaseException", function (span) {
if(span) {
span.setAttribute("code.function", "DataBaseException");
span.setAttribute("outsystems.function.key", "44c56eca-8792-4354-8872-391470dce2a3");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {OS.FeedbackMessageService.showFeedbackMessage("There was a problem with the database request. Please contact the administrator", /*Error*/ 3);
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
return ;

} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Handle Error: CommunicationException
if(OS.Exceptions.isInstanceOf(ex, OS.Exceptions.Exceptions.CommunicationException)) {
OS.Logger.error(null, ex, null, null, 1);
communicationExceptionVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("CommunicationException", function (span) {
if(span) {
span.setAttribute("code.function", "CommunicationException");
span.setAttribute("outsystems.function.key", "9f3a4c50-96da-4e7b-99b9-25a7b45412e3");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {OS.FeedbackMessageService.showFeedbackMessage("There was a problem communicating with the server. Please try again or contact your administrator", /*Error*/ 3);
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
return ;

} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Handle Error: AllExceptions
if(!(OS.Exceptions.isSystem(ex))) {
OS.Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "22e99060-a32a-4cfa-acb6-7bd2cacb7ce1");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {OS.FeedbackMessageService.showFeedbackMessage("There was a problem. Please contact the administrator", /*Error*/ 3);
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
return ;

} finally {
if(span) {
span.end();
}

}

}, 1);
}

throw ex;
} catch (unhandledEx) {
OS.Logger.debug("Common.OnException", OS.Exceptions.getMessage(ex));
return OS.ErrorHandling.defaultErrorHandler(unhandledEx, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);


};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

}



export default new Controller();




