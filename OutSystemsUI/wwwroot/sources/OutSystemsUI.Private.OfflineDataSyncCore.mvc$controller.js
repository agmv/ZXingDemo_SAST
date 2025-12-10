import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_TranslationsResources from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$translationsResources.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnResume_GetSyncOnResumeJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.OnResume.GetSyncOnResumeJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnDestroy_UnregisterAPIJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.OnDestroy.UnregisterAPIJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_Init_RegisterAPIJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.Init.RegisterAPIJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_TriggerSyncStartEventJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.SyncWrapper.TriggerSyncStartEventJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_TriggerSyncErrorEventOfflineJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.SyncWrapper.TriggerSyncErrorEventOfflineJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_SuspendSyncJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.SyncWrapper.SuspendSyncJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnNetworkStatusChanged_GetSyncOnOnlineJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.OnNetworkStatusChanged.GetSyncOnOnlineJS.js";
import OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnInitialize_InitJS from "./OutSystemsUI.Private.OfflineDataSyncCore.mvc$controller.OnInitialize.InitJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_OfflineDataSyncCore_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
syncWrapper$Action: function (syncUnitIn) {
syncUnitIn = (syncUnitIn === undefined) ? "" : syncUnitIn;
return controller.executeActionInsideJSNode(controller._syncWrapper$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(syncUnitIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SyncWrapper");
},
onResume$Action: function () {
return controller.executeActionInsideJSNode(controller._onResume$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnResume");
},
triggerOnSyncStart$Action: function (syncUnitIn) {
syncUnitIn = (syncUnitIn === undefined) ? "" : syncUnitIn;
return controller.executeActionInsideJSNode(controller._triggerOnSyncStart$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(syncUnitIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnSyncStart");
},
triggerOnSyncComplete$Action: function (syncUnitIn) {
syncUnitIn = (syncUnitIn === undefined) ? "" : syncUnitIn;
return controller.executeActionInsideJSNode(controller._triggerOnSyncComplete$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(syncUnitIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnSyncComplete");
},
triggerOnSyncError$Action: function (syncUnitIn, errorMessageIn) {
syncUnitIn = (syncUnitIn === undefined) ? "" : syncUnitIn;
errorMessageIn = (errorMessageIn === undefined) ? "" : errorMessageIn;
return controller.executeActionInsideJSNode(controller._triggerOnSyncError$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(syncUnitIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(errorMessageIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TriggerOnSyncError");
},
init$Action: function () {
return controller.executeActionInsideJSNode(controller._init$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Init");
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
get _onResume$Action() {if(!(this.hasOwnProperty("__onResume$Action"))) {
this.__onResume$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnResume", function (span) {
if(span) {
span.setAttribute("code.function", "OnResume");
span.setAttribute("outsystems.function.key", "14293896-871c-4058-aa3d-af51f72aa5d3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnResume");
callContext = controller.callContext(callContext);
var getSyncOnResumeJSResult = new OS.DataTypes.VariableHolder();
getSyncOnResumeJSResult.value = OS.Logger.startActiveSpan("GetSyncOnResume", function (span) {
if(span) {
span.setAttribute("code.function", "GetSyncOnResume");
span.setAttribute("outsystems.function.key", "74a2daa4-833a-4371-83d4-52ac8c3b41cc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnResume_GetSyncOnResumeJS, "GetSyncOnResume", "OnResume", {
SyncOnResume: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnResume$getSyncOnResumeJSResult"))();
jsNodeResult.syncOnResumeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SyncOnResume, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SyncOnResume?
if((getSyncOnResumeJSResult.value.syncOnResumeOut)) {
// Execute Action: StartOfflineDataSync
OutSystemsUIController.default.startOfflineDataSync$Action("", false, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onResume$Action;
}set _onResume$Action(value) {this.__onResume$Action = value;
}

get _triggerOnSyncComplete$Action() {if(!(this.hasOwnProperty("__triggerOnSyncComplete$Action"))) {
this.__triggerOnSyncComplete$Action = function (syncUnitIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnSyncComplete", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncComplete");
span.setAttribute("outsystems.function.key", "2b7c13c9-b832-4a5c-819e-433ee4c2e7c2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnSyncComplete");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncComplete$vars"))());
vars.value.syncUnitInLocal = syncUnitIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnSyncComplete
return controller.onSyncComplete$Action(vars.value.syncUnitInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnSyncComplete$Action;
}set _triggerOnSyncComplete$Action(value) {this.__triggerOnSyncComplete$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "6748572e-bbba-4d38-9f70-985703470710");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("UnregisterAPI", function (span) {
if(span) {
span.setAttribute("code.function", "UnregisterAPI");
span.setAttribute("outsystems.function.key", "6d0bac8a-e52c-46e3-903b-10388e772eb7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnDestroy_UnregisterAPIJS, "UnregisterAPI", "OnDestroy", {
Token: OS.DataConversion.JSNodeParamConverter.to(model.variables.instanceTokenVar, OS.DataTypes.DataTypes.Text)
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

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "8a8d0761-ccc0-4066-985e-6bde68f0e337");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var registerAPIJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
registerAPIJSResult.value = OS.Logger.startActiveSpan("RegisterAPI", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterAPI");
span.setAttribute("outsystems.function.key", "525a7a36-324a-43eb-8ae7-c2d2c4cf9fbc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_Init_RegisterAPIJS, "RegisterAPI", "Init", {
Token: OS.DataConversion.JSNodeParamConverter.to("", OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.Init$registerAPIJSResult"))();
jsNodeResult.tokenOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Token, OS.DataTypes.DataTypes.Text);
return jsNodeResult;
}, {
SyncWrapper: controller.clientActionProxies.syncWrapper$Action,
OnResume: controller.clientActionProxies.onResume$Action,
TriggerOnSyncStart: controller.clientActionProxies.triggerOnSyncStart$Action,
TriggerOnSyncComplete: controller.clientActionProxies.triggerOnSyncComplete$Action,
TriggerOnSyncError: controller.clientActionProxies.triggerOnSyncError$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// InstanceToken = RegisterAPI.Token
model.variables.instanceTokenVar = registerAPIJSResult.value.tokenOut;
// Trigger Event: OnConfigure
return controller.onConfigure$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__init$Action;
}set _init$Action(value) {this.__init$Action = value;
}

get _syncWrapper$Action() {if(!(this.hasOwnProperty("__syncWrapper$Action"))) {
this.__syncWrapper$Action = function (syncUnitIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SyncWrapper", function (span) {
if(span) {
span.setAttribute("code.function", "SyncWrapper");
span.setAttribute("outsystems.function.key", "ca6d52eb-44a7-4ce2-90de-8b8c817d6190");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SyncWrapper");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.SyncWrapper$vars"))());
vars.value.syncUnitInLocal = syncUnitIn;
var securityExceptionVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var allExceptionsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.ErrorHandlerOutputType());
var getNetworkStatusVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
OS.Logger.startActiveSpan("TriggerSyncStartEvent", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerSyncStartEvent");
span.setAttribute("outsystems.function.key", "32c97ed8-43a2-4c62-b4f4-1bfb6fe7bea6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_TriggerSyncStartEventJS, "TriggerSyncStartEvent", "SyncWrapper", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: GetNetworkStatus
getNetworkStatusVar.value = OutSystemsUIController.default.getNetworkStatus$Action(callContext);

// IsOnline?
return OS.Flow.executeSequence(function () {
if((getNetworkStatusVar.value.isOnlineOut)) {
// Trigger Event: OnSync
return controller.onSync$Action(vars.value.syncUnitInLocal, callContext);
} else {
OS.Logger.startActiveSpan("SuspendSync", function (span) {
if(span) {
span.setAttribute("code.function", "SuspendSync");
span.setAttribute("outsystems.function.key", "d62ef2f7-26d9-43f2-84af-52a295a00214");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_SuspendSyncJS, "SuspendSync", "SyncWrapper", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
OS.Logger.startActiveSpan("TriggerSyncErrorEventOffline", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerSyncErrorEventOffline");
span.setAttribute("outsystems.function.key", "9c71fca2-b9ad-47c2-9d89-5472449be3df");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_SyncWrapper_TriggerSyncErrorEventOfflineJS, "TriggerSyncErrorEventOffline", "SyncWrapper", {
ErrorMessage: OS.DataConversion.JSNodeParamConverter.to(OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("oV_BjLEnd0WhUVEpy1YP+g#Value.2001762002.1", "Unable to synchronize data. Device has no network connectivity."), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

});
}).catch(function (ex) {
OS.Logger.debug("OfflineDataSyncCore.SyncWrapper", OS.Exceptions.getMessage(ex));
// Handle Error: SecurityException
if(OS.Exceptions.isInstanceOf(ex, OS.Exceptions.Exceptions.SecurityException)) {
OS.Logger.error(null, ex, null, null, 1);
securityExceptionVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("SecurityException", function (span) {
if(span) {
span.setAttribute("code.function", "SecurityException");
span.setAttribute("outsystems.function.key", "353e2e82-2354-47bf-9ade-d68d91aadbcd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS.Flow.tryFinally(function () {
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: EndWithSecurityError
OutSystemsUIController.default.endOfflineDataSync$Action(true, securityExceptionVar.value.exceptionMessageAttr, false, callContext);
return OS.Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: AllExceptions
if(!(OS.Exceptions.isSystem(ex))) {
OS.Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS.Exceptions.getMessage(ex);
return OS.Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "3619f65a-6be8-4f6b-84f1-070777b99282");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS.Flow.tryFinally(function () {
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: EndWithError
OutSystemsUIController.default.endOfflineDataSync$Action(true, allExceptionsVar.value.exceptionMessageAttr, true, callContext);
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

return this.__syncWrapper$Action;
}set _syncWrapper$Action(value) {this.__syncWrapper$Action = value;
}

get _triggerOnSyncStart$Action() {if(!(this.hasOwnProperty("__triggerOnSyncStart$Action"))) {
this.__triggerOnSyncStart$Action = function (syncUnitIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnSyncStart", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncStart");
span.setAttribute("outsystems.function.key", "cb8d5016-281a-43de-9f28-9329be438a24");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnSyncStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncStart$vars"))());
vars.value.syncUnitInLocal = syncUnitIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnSyncStart
return controller.onSyncStart$Action(vars.value.syncUnitInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnSyncStart$Action;
}set _triggerOnSyncStart$Action(value) {this.__triggerOnSyncStart$Action = value;
}

get _triggerOnSyncError$Action() {if(!(this.hasOwnProperty("__triggerOnSyncError$Action"))) {
this.__triggerOnSyncError$Action = function (syncUnitIn, errorMessageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TriggerOnSyncError", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncError");
span.setAttribute("outsystems.function.key", "da41dbee-5d6e-459b-8925-760a7b8af7c1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TriggerOnSyncError");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncError$vars"))());
vars.value.syncUnitInLocal = syncUnitIn;
vars.value.errorMessageInLocal = errorMessageIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnSyncError
return controller.onSyncError$Action(vars.value.syncUnitInLocal, vars.value.errorMessageInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__triggerOnSyncError$Action;
}set _triggerOnSyncError$Action(value) {this.__triggerOnSyncError$Action = value;
}

get _onNetworkStatusChanged$Action() {if(!(this.hasOwnProperty("__onNetworkStatusChanged$Action"))) {
this.__onNetworkStatusChanged$Action = function (isOnlineIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnNetworkStatusChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnNetworkStatusChanged");
span.setAttribute("outsystems.function.key", "e3c84ba7-3587-4d12-b82a-448f02c33f82");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnNetworkStatusChanged");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnNetworkStatusChanged$vars"))());
vars.value.isOnlineInLocal = isOnlineIn;
var getSyncOnOnlineJSResult = new OS.DataTypes.VariableHolder();
getSyncOnOnlineJSResult.value = OS.Logger.startActiveSpan("GetSyncOnOnline", function (span) {
if(span) {
span.setAttribute("code.function", "GetSyncOnOnline");
span.setAttribute("outsystems.function.key", "50f90b6b-abc3-4c6f-ac91-2b6425433d8e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnNetworkStatusChanged_GetSyncOnOnlineJS, "GetSyncOnOnline", "OnNetworkStatusChanged", {
SyncOnOnline: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnNetworkStatusChanged$getSyncOnOnlineJSResult"))();
jsNodeResult.syncOnOnlineOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SyncOnOnline, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if(((vars.value.isOnlineInLocal && getSyncOnOnlineJSResult.value.syncOnOnlineOut))) {
// Execute Action: StartOfflineDataSync
OutSystemsUIController.default.startOfflineDataSync$Action("", false, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onNetworkStatusChanged$Action;
}set _onNetworkStatusChanged$Action(value) {this.__onNetworkStatusChanged$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "e4f71bd8-c160-4dd5-bf3f-f41d5a156bc8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "bcc3a0d1-25fe-4c2d-8d0d-9bd904c8acaf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_OfflineDataSyncCore_mvc_controller_OnInitialize_InitJS, "Init", "OnInitialize", null, function ($parameters) {
}, {
Init: controller.clientActionProxies.init$Action
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

return this.__onInitialize$Action;
}set _onInitialize$Action(value) {this.__onInitialize$Action = value;
}


onResume$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnResume__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnResume");
span.setAttribute("outsystems.function.key", "14293896-871c-4058-aa3d-af51f72aa5d3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onResume$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

triggerOnSyncComplete$Action(syncUnitIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnSyncComplete__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncComplete");
span.setAttribute("outsystems.function.key", "2b7c13c9-b832-4a5c-819e-433ee4c2e7c2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnSyncComplete$Action, callContext, syncUnitIn);
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
span.setAttribute("outsystems.function.key", "6748572e-bbba-4d38-9f70-985703470710");
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

init$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "8a8d0761-ccc0-4066-985e-6bde68f0e337");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._init$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

syncWrapper$Action(syncUnitIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SyncWrapper__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SyncWrapper");
span.setAttribute("outsystems.function.key", "ca6d52eb-44a7-4ce2-90de-8b8c817d6190");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._syncWrapper$Action, callContext, syncUnitIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

triggerOnSyncStart$Action(syncUnitIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnSyncStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncStart");
span.setAttribute("outsystems.function.key", "cb8d5016-281a-43de-9f28-9329be438a24");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnSyncStart$Action, callContext, syncUnitIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

triggerOnSyncError$Action(syncUnitIn, errorMessageIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TriggerOnSyncError__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TriggerOnSyncError");
span.setAttribute("outsystems.function.key", "da41dbee-5d6e-459b-8925-760a7b8af7c1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._triggerOnSyncError$Action, callContext, syncUnitIn, errorMessageIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onNetworkStatusChanged$Action(isOnlineIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnNetworkStatusChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnNetworkStatusChanged");
span.setAttribute("outsystems.function.key", "e3c84ba7-3587-4d12-b82a-448f02c33f82");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onNetworkStatusChanged$Action, callContext, isOnlineIn);
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
span.setAttribute("outsystems.function.key", "e4f71bd8-c160-4dd5-bf3f-f41d5a156bc8");
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

get onSyncError$Action() {if(!(this.hasOwnProperty("_onSyncError$Action"))) {
this._onSyncError$Action = function () {
return Promise.resolve();
};
}

return this._onSyncError$Action;
}set onSyncError$Action(value) {this._onSyncError$Action = value;
}

get onConfigure$Action() {if(!(this.hasOwnProperty("_onConfigure$Action"))) {
this._onConfigure$Action = function () {
return Promise.resolve();
};
}

return this._onConfigure$Action;
}set onConfigure$Action(value) {this._onConfigure$Action = value;
}

get onSyncComplete$Action() {if(!(this.hasOwnProperty("_onSyncComplete$Action"))) {
this._onSyncComplete$Action = function () {
return Promise.resolve();
};
}

return this._onSyncComplete$Action;
}set onSyncComplete$Action(value) {this._onSyncComplete$Action = value;
}

get onSync$Action() {if(!(this.hasOwnProperty("_onSync$Action"))) {
this._onSync$Action = function () {
return Promise.resolve();
};
}

return this._onSync$Action;
}set onSync$Action(value) {this._onSync$Action = value;
}

get onSyncStart$Action() {if(!(this.hasOwnProperty("_onSyncStart$Action"))) {
this._onSyncStart$Action = function () {
return Promise.resolve();
};
}

return this._onSyncStart$Action;
}set onSyncStart$Action(value) {this._onSyncStart$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnResume$getSyncOnResumeJSResult", [{
name: "SyncOnResume",
attrName: "syncOnResumeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncComplete$vars", [{
name: "SyncUnit",
attrName: "syncUnitInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.Init$registerAPIJSResult", [{
name: "Token",
attrName: "tokenOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.SyncWrapper$vars", [{
name: "SyncUnit",
attrName: "syncUnitInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncStart$vars", [{
name: "SyncUnit",
attrName: "syncUnitInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.TriggerOnSyncError$vars", [{
name: "SyncUnit",
attrName: "syncUnitInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ErrorMessage",
attrName: "errorMessageInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnNetworkStatusChanged$vars", [{
name: "IsOnline",
attrName: "isOnlineInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.OfflineDataSyncCore.OnNetworkStatusChanged$getSyncOnOnlineJSResult", [{
name: "SyncOnOnline",
attrName: "syncOnOnlineOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




