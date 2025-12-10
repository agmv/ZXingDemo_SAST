import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_LightBox_mvc_TranslationsResources from "./OutSystemsUI.Private.LightBox.mvc$translationsResources.js";
import OutSystemsUI_Private_LightBox_mvc_controller_CheckLightbox_CheckLightboxStatusJS from "./OutSystemsUI.Private.LightBox.mvc$controller.CheckLightbox.CheckLightboxStatusJS.js";
import OutSystemsUI_Private_LightBox_mvc_controller_CheckLightbox_AppendElementJS from "./OutSystemsUI.Private.LightBox.mvc$controller.CheckLightbox.AppendElementJS.js";
import OutSystemsUI_Private_LightBox_mvc_controller_OnReady_CallCheckLightboxJS from "./OutSystemsUI.Private.LightBox.mvc$controller.OnReady.CallCheckLightboxJS.js";
import OutSystemsUI_Private_LightBox_mvc_controller_OnDestroy_ClearTimeoutsJS from "./OutSystemsUI.Private.LightBox.mvc$controller.OnDestroy.ClearTimeoutsJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_LightBox_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
checkLightbox$Action: function () {
return controller.executeActionInsideJSNode(controller._checkLightbox$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "CheckLightbox");
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
get _checkLightbox$Action() {if(!(this.hasOwnProperty("__checkLightbox$Action"))) {
this.__checkLightbox$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CheckLightbox", function (span) {
if(span) {
span.setAttribute("code.function", "CheckLightbox");
span.setAttribute("outsystems.function.key", "44da6781-f472-4cbb-ab20-f3167bda4aa8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckLightbox");
callContext = controller.callContext(callContext);
var checkLightboxStatusJSResult = new OS.DataTypes.VariableHolder();
var appendElementJSResult = new OS.DataTypes.VariableHolder();
// Checks the Lightbox status.
checkLightboxStatusJSResult.value = OS.Logger.startActiveSpan("CheckLightboxStatus", function (span) {
if(span) {
span.setAttribute("code.function", "CheckLightboxStatus");
span.setAttribute("outsystems.function.key", "60de5ec5-19a6-4b28-af7c-3e339425ae61");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_LightBox_mvc_controller_CheckLightbox_CheckLightboxStatusJS, "CheckLightboxStatus", "CheckLightbox", {
ShowLightbox: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.LightBox.CheckLightbox$checkLightboxStatusJSResult"))();
jsNodeResult.showLightboxOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ShowLightbox, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set ShowLightbox
// ShowLightbox = CheckLightboxStatus.ShowLightbox
model.variables.showLightboxVar = checkLightboxStatusJSResult.value.showLightboxOut;
if((model.variables.showLightboxVar)) {
appendElementJSResult.value = OS.Logger.startActiveSpan("AppendElement", function (span) {
if(span) {
span.setAttribute("code.function", "AppendElement");
span.setAttribute("outsystems.function.key", "f41af8c4-78e6-4c42-8f51-2ae30c1b7634");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_LightBox_mvc_controller_CheckLightbox_AppendElementJS, "AppendElement", "CheckLightbox", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("pswp"), OS.DataTypes.DataTypes.Text),
TimeoutIdOut: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.LightBox.CheckLightbox$appendElementJSResult"))();
jsNodeResult.timeoutIdOutOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TimeoutIdOut, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {
MoveElement: OutSystemsUIController.default.clientActionProxies.moveElement$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set TimeoutId_AppendElement
// TimeoutId_AppendElement = AppendElement.TimeoutIdOut
model.variables.timeoutId_AppendElementVar = appendElementJSResult.value.timeoutIdOutOut;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__checkLightbox$Action;
}set _checkLightbox$Action(value) {this.__checkLightbox$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "520dd6b9-65f2-4b3a-88bc-b82b3455d0f5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Init ShowLightbox
// ShowLightbox = False
model.variables.showLightboxVar = false;
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "de1116f7-08d8-417e-9719-fd3f0e86f7ce");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var callCheckLightboxJSResult = new OS.DataTypes.VariableHolder();
callCheckLightboxJSResult.value = OS.Logger.startActiveSpan("CallCheckLightbox", function (span) {
if(span) {
span.setAttribute("code.function", "CallCheckLightbox");
span.setAttribute("outsystems.function.key", "0d1ccd59-a3ee-4569-accf-e2a7383c6ba3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_LightBox_mvc_controller_OnReady_CallCheckLightboxJS, "CallCheckLightbox", "OnReady", {
TimeoutIdOut: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.LightBox.OnReady$callCheckLightboxJSResult"))();
jsNodeResult.timeoutIdOutOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TimeoutIdOut, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {
CheckLightbox: controller.clientActionProxies.checkLightbox$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set TimeoutId_CheckLightbox
// TimeoutId_CheckLightbox = CallCheckLightbox.TimeoutIdOut
model.variables.timeoutId_CheckLightboxVar = callCheckLightboxJSResult.value.timeoutIdOutOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "f45a7752-cef3-4071-9938-56827c4b68fa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Clear the active timeouts.
OS.Logger.startActiveSpan("ClearTimeouts", function (span) {
if(span) {
span.setAttribute("code.function", "ClearTimeouts");
span.setAttribute("outsystems.function.key", "f92148b0-3f76-41de-ac46-c9d1de4ab62e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_LightBox_mvc_controller_OnDestroy_ClearTimeoutsJS, "ClearTimeouts", "OnDestroy", {
TimeoutId_AppendElement: OS.DataConversion.JSNodeParamConverter.to(model.variables.timeoutId_AppendElementVar, OS.DataTypes.DataTypes.Integer),
TimeoutId_CheckLightbox: OS.DataConversion.JSNodeParamConverter.to(model.variables.timeoutId_CheckLightboxVar, OS.DataTypes.DataTypes.Integer)
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


checkLightbox$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CheckLightbox__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckLightbox");
span.setAttribute("outsystems.function.key", "44da6781-f472-4cbb-ab20-f3167bda4aa8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkLightbox$Action, callContext);
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
span.setAttribute("outsystems.function.key", "520dd6b9-65f2-4b3a-88bc-b82b3455d0f5");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "de1116f7-08d8-417e-9719-fd3f0e86f7ce");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "f45a7752-cef3-4071-9938-56827c4b68fa");
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
Controller.registerVariableGroupType("OutSystemsUI.Private.LightBox.CheckLightbox$checkLightboxStatusJSResult", [{
name: "ShowLightbox",
attrName: "showLightboxOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.LightBox.CheckLightbox$appendElementJSResult", [{
name: "TimeoutIdOut",
attrName: "timeoutIdOutOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.LightBox.OnReady$callCheckLightboxJSResult", [{
name: "TimeoutIdOut",
attrName: "timeoutIdOutOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




