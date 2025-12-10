import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_TranslationsResources from "./OutSystemsUI.Navigation.DEPRECATED_SectionIndex.mvc$translationsResources.js";
import OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Navigation.DEPRECATED_SectionIndex.mvc$controller.OnReady.InitJS.js";
import OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnDestroy_DestroyJS from "./OutSystemsUI.Navigation.DEPRECATED_SectionIndex.mvc$controller.OnDestroy.DestroyJS.js";
import OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnDestroy_CheckObjectStatusJS from "./OutSystemsUI.Navigation.DEPRECATED_SectionIndex.mvc$controller.OnDestroy.CheckObjectStatusJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
setObject$Action: function (objIn) {
objIn = (objIn === undefined) ? null : objIn;
return controller.executeActionInsideJSNode(controller._setObject$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(objIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetObject");
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
get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (isUpdateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "13cbcb0a-f129-4939-b306-c2a143933883");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.OnReady$vars"))());
vars.value.isUpdateInLocal = isUpdateIn;
// Init Data
// IsWebApp = IsWebApp()
model.variables.isWebAppVar = OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut;
// IsOldNative = notIsWebApp() and notIsLayoutNative()
model.variables.isOldNativeVar = ((!(OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut)) && (!(OutSystemsUIController.default.isLayoutNative$Action(callContext).isNativeOut)));
// IsLayoutNative = IsLayoutNative()
model.variables.isLayoutNativeVar = OutSystemsUIController.default.isLayoutNative$Action(callContext).isNativeOut;
OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "e8f87beb-6973-448b-9a98-1640b06b430b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
IsUpdate: OS.DataConversion.JSNodeParamConverter.to(vars.value.isUpdateInLocal, OS.DataTypes.DataTypes.Boolean),
IsSmooth: OS.DataConversion.JSNodeParamConverter.to(model.variables.isSmoothIn, OS.DataTypes.DataTypes.Boolean),
IsWebApp: OS.DataConversion.JSNodeParamConverter.to(model.variables.isWebAppVar, OS.DataTypes.DataTypes.Boolean),
IsFixed: OS.DataConversion.JSNodeParamConverter.to(model.variables.isFixedIn, OS.DataTypes.DataTypes.Boolean),
IsLayoutNative: OS.DataConversion.JSNodeParamConverter.to(model.variables.isLayoutNativeVar, OS.DataTypes.DataTypes.Boolean),
TopPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.topPositionIn, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {
SetObject: controller.clientActionProxies.setObject$Action
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
span.setAttribute("outsystems.function.key", "aa9b485b-89d8-49a1-81f0-0567c7dc9ea4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
var checkObjectStatusJSResult = new OS.DataTypes.VariableHolder();
checkObjectStatusJSResult.value = OS.Logger.startActiveSpan("CheckObjectStatus", function (span) {
if(span) {
span.setAttribute("code.function", "CheckObjectStatus");
span.setAttribute("outsystems.function.key", "f4877717-ff2d-43bc-b1d6-c4cc24b89851");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnDestroy_CheckObjectStatusJS, "CheckObjectStatus", "OnDestroy", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.sectionIndexObjVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.OnDestroy$checkObjectStatusJSResult"))();
jsNodeResult.objectIsDefinedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObjectIsDefined, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ObjectIsDefined
if((checkObjectStatusJSResult.value.objectIsDefinedOut)) {
OS.Logger.startActiveSpan("Destroy", function (span) {
if(span) {
span.setAttribute("code.function", "Destroy");
span.setAttribute("outsystems.function.key", "63ab6791-7c16-4eda-8503-a6b872788132");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_SectionIndex_mvc_controller_OnDestroy_DestroyJS, "Destroy", "OnDestroy", {
Obj: OS.DataConversion.JSNodeParamConverter.to(model.variables.sectionIndexObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

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

get _setObject$Action() {if(!(this.hasOwnProperty("__setObject$Action"))) {
this.__setObject$Action = function (objIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetObject", function (span) {
if(span) {
span.setAttribute("code.function", "SetObject");
span.setAttribute("outsystems.function.key", "b5cbb2ca-6297-444a-82a3-08874946caad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetObject");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.SetObject$vars"))());
vars.value.objInLocal = objIn;
// SectionIndexObj = Obj
model.variables.sectionIndexObjVar = vars.value.objInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setObject$Action;
}set _setObject$Action(value) {this.__setObject$Action = value;
}


onReady$Action(isUpdateIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "13cbcb0a-f129-4939-b306-c2a143933883");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext, isUpdateIn);
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
span.setAttribute("outsystems.function.key", "aa9b485b-89d8-49a1-81f0-0567c7dc9ea4");
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

setObject$Action(objIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetObject__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetObject");
span.setAttribute("outsystems.function.key", "b5cbb2ca-6297-444a-82a3-08874946caad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setObject$Action, callContext, objIn);
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(false, callContext);

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
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(true, callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.OnReady$vars", [{
name: "IsUpdate",
attrName: "isUpdateInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.OnDestroy$checkObjectStatusJSResult", [{
name: "ObjectIsDefined",
attrName: "objectIsDefinedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_SectionIndex.SetObject$vars", [{
name: "Obj",
attrName: "objInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




