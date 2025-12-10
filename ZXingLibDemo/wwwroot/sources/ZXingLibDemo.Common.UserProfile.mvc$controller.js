import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as System_Model from "./System_.model.js";
import "./ZXingLibDemo.referencesHealth.js";
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
getUserById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods
get updateUser$ServerAction() {if(!(this.hasOwnProperty("_updateUser$ServerAction"))) {
this._updateUser$ServerAction = function (userUpdateInfoIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateUser", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUser");
span.setAttribute("outsystems.function.key", "07cdfda9-d775-4f13-8c33-3f2164d4abd6");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
var inputs = {
UserUpdateInfo: OS.DataConversion.ServerDataConverter.to(userUpdateInfoIn, OS.DataTypes.DataTypes.Record)
};
return controller.callServerAction("UpdateUser", "screenservices/ZXingLibDemo/Common/UserProfile/ActionUpdateUser", "f+w9TRZi1JqSKbln3hu0zw", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ZXingLibDemo.Common.UserProfile$ActionUpdateUser"))();
executeServerActionResult.updateUserResultOut = OS.DataConversion.ServerDataConverter.from(outputs.UpdateUserResult, OS.SystemStructures.UpdateUserResultRec);
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

return this._updateUser$ServerAction;
}set updateUser$ServerAction(value) {this._updateUser$ServerAction = value;
}


// Aggregates and Data Actions
get getUserById$AggrRefresh() {if(!(this.hasOwnProperty("_getUserById$AggrRefresh"))) {
this._getUserById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserById", "screenservices/ZXingLibDemo/Common/UserProfile/ScreenDataSetGetUserById", "FmEie9Rgofos5XNFsd2jOg", maxRecords, startIndex, function (b) {
model.variables.getUserByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserByIdAggr.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getUserByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._setIsButtonEnabled$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetUserById", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserById");
span.setAttribute("outsystems.function.key", "b5d62b22-7653-488a-8b08-2eaa8da04970");
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

return this._getUserById$AggrRefresh;
}set getUserById$AggrRefresh(value) {this._getUserById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _saveChangesOnClick$Action() {if(!(this.hasOwnProperty("__saveChangesOnClick$Action"))) {
this.__saveChangesOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SaveChangesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveChangesOnClick");
span.setAttribute("outsystems.function.key", "b52968ec-1930-4c88-82db-317164f104ad");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveChangesOnClick");
callContext = controller.callContext(callContext);
var updateUserVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: UpdateUser
model.flush();
return controller.updateUser$ServerAction(OS.DataConversion.JSConversions.typeConvertRecord(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr, new OS.SystemStructures.UserUpdateInfoRec(), function (source, target) {
target.nameAttr = source.nameAttr;
target.photoURLAttr = source.photoUrlAttr;
return target;
}), callContext).then(function (value) {
updateUserVar.value = value;
}).then(function () {
// Success?
if((updateUserVar.value.updateUserResultOut.successAttr)) {
// Update client variables
// UserName = GetUserById.List.Current.User.Name
ZXingLibDemoClientVariables.setUserName(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr);
// User updated successfully
OS.FeedbackMessageService.showFeedbackMessage("Your profile has been successfully updated!", /*Success*/ 1);
} else {
// Invalid credentials?
if((updateUserVar.value.updateUserResultOut.updateUserFailureReasonAttr.invalidCredentialsAttr)) {
// Invalid credentials.
OS.FeedbackMessageService.showFeedbackMessage("Invalid credentials.", /*Error*/ 3);
} else {
// Invalid Name?
if((updateUserVar.value.updateUserResultOut.updateUserFailureReasonAttr.invalidNameAttr)) {
// Invalid Name
OS.FeedbackMessageService.showFeedbackMessage("Name invalid.", /*Error*/ 3);
} else {
// Update user failed.
OS.FeedbackMessageService.showFeedbackMessage("Update user failed.", /*Error*/ 3);
}

}

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

return this.__saveChangesOnClick$Action;
}set _saveChangesOnClick$Action(value) {this.__saveChangesOnClick$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ba77697d-581a-4cd7-9d59-ffbde89f3750");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var isExternalUserVar = new OS.DataTypes.VariableHolder();
// Execute Action: IsExternalUser
isExternalUserVar.value = OS.SystemActions.isExternalUser(callContext);

// IsExternal = IsExternalUser.IsExternalUser
model.variables.isExternalVar = isExternalUserVar.value.isExternalUserOut;
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

get _setIsButtonEnabled$Action() {if(!(this.hasOwnProperty("__setIsButtonEnabled$Action"))) {
this.__setIsButtonEnabled$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetIsButtonEnabled", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "be2cab1a-a7ab-49c6-bb2b-2c38548d94a0");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetIsButtonEnabled");
callContext = controller.callContext(callContext);
// Set IsButtonEnabled
// IsButtonEnabled = notGetUserById.List.Current.User.Name = ""
model.variables.isButtonEnabledVar = (!((model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr === "")));
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

get _input_NameOnChange$Action() {if(!(this.hasOwnProperty("__input_NameOnChange$Action"))) {
this.__input_NameOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Input_NameOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_NameOnChange");
span.setAttribute("outsystems.function.key", "c0800096-aab1-4b53-b787-66181cd4fb0d");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_NameOnChange");
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

return this.__input_NameOnChange$Action;
}set _input_NameOnChange$Action(value) {this.__input_NameOnChange$Action = value;
}


saveChangesOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SaveChangesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveChangesOnClick");
span.setAttribute("outsystems.function.key", "b52968ec-1930-4c88-82db-317164f104ad");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveChangesOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "ba77697d-581a-4cd7-9d59-ffbde89f3750");
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

setIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "be2cab1a-a7ab-49c6-bb2b-2c38548d94a0");
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

input_NameOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Input_NameOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_NameOnChange");
span.setAttribute("outsystems.function.key", "c0800096-aab1-4b53-b787-66181cd4fb0d");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_NameOnChange$Action, callContext);
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
Controller.registerVariableGroupType("ZXingLibDemo.Common.UserProfile$ActionUpdateUser", [{
name: "UpdateUserResult",
attrName: "updateUserResultOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Record,
defaultValue: function () {
return new OS.SystemStructures.UpdateUserResultRec();
},
complexType: OS.SystemStructures.UpdateUserResultRec
}]);

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




