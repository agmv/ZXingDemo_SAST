import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as System_Model from "./System_.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
class Controller extends 
OS.Controller.BaseModuleController {
constructor(model, messagesProvider, idService, translationResources) {
super(model, messagesProvider, idService, translationResources);
}

get clientActionProxies() {if(!(this.hasOwnProperty("_clientActionProxies"))) {
this._clientActionProxies = {};
}

return this._clientActionProxies;
}set clientActionProxies(value) {this._clientActionProxies = value;
}

checkZXingLibDemoRole$Action(callContext) {
var outVars = new OS.SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS.Authorization.hasRole({
roleKey: this.roles.ZXingLibDemo.roleKey
});
return outVars;

}


get roles() {if(!(this.hasOwnProperty("_roles"))) {
this._roles = {
ZXingLibDemo: {
roleKey: "61918b7a-e496-4b63-992b-b83299b21e43.ab2a6b39-1f30-4f20-a069-cf5d18b076f4",
roleException: new OS.Exceptions.Exceptions.NotRegisteredException("ZXingLibDemo.NotZXingLibDemo", "ZXingLibDemo role required")
}
};
}

return this._roles;
}set roles(value) {this._roles = value;
}

get defaultTimeout() {if(!(this.hasOwnProperty("_defaultTimeout"))) {
this._defaultTimeout = 10;
}

return this._defaultTimeout;
}set defaultTimeout(value) {this._defaultTimeout = value;
}

getDefaultTimeout() {
return this.defaultTimeout;
}

}

var ZXingLibDemoController = new Controller();

var controller = ZXingLibDemoController;
ZXingLibDemoController.doLogin$Action = function (usernameIn, passwordIn, callContext) {
return OS.Logger.startActiveSpan("DoLogin", function (span) {
if(span) {
span.setAttribute("code.function", "DoLogin");
span.setAttribute("outsystems.function.key", "c45e4ea0-ddd3-4e73-abfc-ba43af7d5ab7");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

return OS.Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.DoLogin$vars"))());
vars.value.usernameInLocal = usernameIn;
vars.value.passwordInLocal = passwordIn;
var loginVar = new OS.DataTypes.VariableHolder();
var outVars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.DoLogin$outVars"))());
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: Login
return OS.SystemActions.login(vars.value.usernameInLocal, vars.value.passwordInLocal, callContext).then(function (value) {
loginVar.value = value;
}).then(function () {
// Success?
if((loginVar.value.userLoginResultOut.successAttr)) {
// Success = True
// Success = True
outVars.value.successOut = true;
} else {
// Invalid credentials?
if((loginVar.value.userLoginResultOut.userLoginFailureReasonAttr.invalidCredentialsAttr)) {
// Set error message
// ErrorMessage = "Invalid credentials."
outVars.value.errorMessageOut = "Invalid credentials.";
} else {
// Too many failed login attempts?
if((loginVar.value.userLoginResultOut.userLoginFailureReasonAttr.tooManyFailedLoginAttemptsAttr)) {
// Set error message
// ErrorMessage = "Too many failed login attempts. Please try again in " + Login.UserLoginResult.RetryAfterSeconds + " seconds."
outVars.value.errorMessageOut = (("Too many failed login attempts. Please try again in " + (loginVar.value.userLoginResultOut.retryAfterSecondsAttr).toString()) + " seconds.");
} else {
// Set error message
// ErrorMessage = "Login operation failed."
outVars.value.errorMessageOut = "Login operation failed.";
}

}

}

});
}).then(function () {
return outVars.value;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
ZXingLibDemoController.constructor.registerVariableGroupType("ZXingLibDemo.DoLogin$vars", [{
name: "Username",
attrName: "usernameInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Password",
attrName: "passwordInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ZXingLibDemoController.constructor.registerVariableGroupType("ZXingLibDemo.DoLogin$outVars", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ZXingLibDemoController.clientActionProxies.doLogin$Action = function (usernameIn, passwordIn) {
usernameIn = (usernameIn === undefined) ? "" : usernameIn;
passwordIn = (passwordIn === undefined) ? "" : passwordIn;
return controller.executeActionInsideJSNode(ZXingLibDemoController.default.doLogin$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(usernameIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(passwordIn, OS.DataTypes.DataTypes.Text)), OS.Controller.BaseViewController.activeScreen ? OS.Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Success: OS.DataConversion.JSNodeParamConverter.to(actionResults.successOut, OS.DataTypes.DataTypes.Boolean),
ErrorMessage: OS.DataConversion.JSNodeParamConverter.to(actionResults.errorMessageOut, OS.DataTypes.DataTypes.Text)
};
});
};


export default ZXingLibDemoController;





