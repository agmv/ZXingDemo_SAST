import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_OverflowMenu_mvc_TranslationsResources from "./OutSystemsUI.Navigation.OverflowMenu.mvc$translationsResources.js";
import OutSystemsUI_Navigation_OverflowMenu_mvc_controller_RegisterCallback_GetCallbackHandlerJS from "./OutSystemsUI.Navigation.OverflowMenu.mvc$controller.RegisterCallback.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_OverflowMenu_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
initializeHandler$Action: function (overflowMenuIdIn) {
overflowMenuIdIn = (overflowMenuIdIn === undefined) ? "" : overflowMenuIdIn;
return controller.executeActionInsideJSNode(controller._initializeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(overflowMenuIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializeHandler");
},
onMenuToggleHandler$Action: function (overflowMenuIdIn, isOpenIn) {
overflowMenuIdIn = (overflowMenuIdIn === undefined) ? "" : overflowMenuIdIn;
isOpenIn = (isOpenIn === undefined) ? false : isOpenIn;
return controller.executeActionInsideJSNode(controller._onMenuToggleHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(overflowMenuIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(isOpenIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnMenuToggleHandler");
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
get _initializeHandler$Action() {if(!(this.hasOwnProperty("__initializeHandler$Action"))) {
this.__initializeHandler$Action = function (overflowMenuIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeHandler");
span.setAttribute("outsystems.function.key", "118021e0-a01b-4c4e-ba76-61af189bfd3e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.InitializeHandler$vars"))());
vars.value.overflowMenuIdInLocal = overflowMenuIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.overflowMenuIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__initializeHandler$Action;
}set _initializeHandler$Action(value) {this.__initializeHandler$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "1c0cfc36-99c6-49ff-9503-94d70aa79e96");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create OverflowMenu", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Internal Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.BalloonPosition = BalloonPosition
model.variables.internalConfigsVar.balloonPositionAttr = model.variables.balloonPositionIn;
// InternalConfigs.BalloonShape = BalloonShape
model.variables.internalConfigsVar.balloonShapeAttr = model.variables.balloonShapeIn;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: OverflowMenuCreate
OutSystemsUIController.default.overflowMenuCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, callContext);
// Execute Action: RegisterCallback
controller._registerCallback$Action(callContext);
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

get _onMenuToggleHandler$Action() {if(!(this.hasOwnProperty("__onMenuToggleHandler$Action"))) {
this.__onMenuToggleHandler$Action = function (overflowMenuIdIn, isOpenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnMenuToggleHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnMenuToggleHandler");
span.setAttribute("outsystems.function.key", "45947b1e-ab33-44d4-a836-3c3de0afd709");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnMenuToggleHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.OnMenuToggleHandler$vars"))());
vars.value.overflowMenuIdInLocal = overflowMenuIdIn;
vars.value.isOpenInLocal = isOpenIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnMenuToggle
return controller.onMenuToggle$Action(vars.value.overflowMenuIdInLocal, vars.value.isOpenInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onMenuToggleHandler$Action;
}set _onMenuToggleHandler$Action(value) {this.__onMenuToggleHandler$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "545bec1b-948b-4f1c-8dcd-75dd6a1ccc40");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.internalConfigsVar.balloonPositionAttr) !== (model.variables.balloonPositionIn)))) {
// InternalConfigs.BalloonPosition = BalloonPosition
model.variables.internalConfigsVar.balloonPositionAttr = model.variables.balloonPositionIn;
// Execute Action: Update_Position
OutSystemsUIController.default.overflowMenuChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Position", model.variables.internalConfigsVar.balloonPositionAttr, callContext);
}

if((((model.variables.internalConfigsVar.balloonShapeAttr) !== (model.variables.balloonShapeIn)))) {
// InternalConfigs.BalloonShape = BalloonShape
model.variables.internalConfigsVar.balloonShapeAttr = model.variables.balloonShapeIn;
// Execute Action: Update_Shape
OutSystemsUIController.default.overflowMenuChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Shape", model.variables.internalConfigsVar.balloonShapeAttr, callContext);
}

if((((model.variables.internalConfigsVar.extendedClassAttr) !== (model.variables.extendedClassIn)))) {
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.overflowMenuChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internalConfigsVar.extendedClassAttr, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "55189666-9dc8-4c75-aef4-6c11cf331b44");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: OverflowMenuInitialize
OutSystemsUIController.default.overflowMenuInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "OverflowMenu created", callContext);
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
span.setAttribute("outsystems.function.key", "87eba5cd-1fe3-42f3-873b-d67692c6686d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: OverflowMenuDestroy
OutSystemsUIController.default.overflowMenuDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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

get _registerCallback$Action() {if(!(this.hasOwnProperty("__registerCallback$Action"))) {
this.__registerCallback$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallback", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "d8f9cef8-b99d-4b40-8da2-559762c6ec06");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RegisterCallback");
callContext = controller.callContext(callContext);
var getCallbackHandlerJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlerJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandler", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandler");
span.setAttribute("outsystems.function.key", "94010e60-acfe-4235-949a-adc3f7aecee3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_OverflowMenu_mvc_controller_RegisterCallback_GetCallbackHandlerJS, "GetCallbackHandler", "RegisterCallback", {
InitializeObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnToggleObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.RegisterCallback$getCallbackHandlerJSResult"))();
jsNodeResult.initializeObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.InitializeObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.onToggleObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnToggleObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
InitializeHandler: controller.clientActionProxies.initializeHandler$Action,
OnMenuToggleHandler: controller.clientActionProxies.onMenuToggleHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: OverflowMenuRegisterInitialize
OutSystemsUIController.default.overflowMenuRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlerJSResult.value.initializeObjOut, callContext);
// Execute Action: OverflowMenuRegisterOnToggle
OutSystemsUIController.default.overflowMenuRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onToggle, getCallbackHandlerJSResult.value.onToggleObjOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__registerCallback$Action;
}set _registerCallback$Action(value) {this.__registerCallback$Action = value;
}


initializeHandler$Action(overflowMenuIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeHandler");
span.setAttribute("outsystems.function.key", "118021e0-a01b-4c4e-ba76-61af189bfd3e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializeHandler$Action, callContext, overflowMenuIdIn);
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
span.setAttribute("outsystems.function.key", "1c0cfc36-99c6-49ff-9503-94d70aa79e96");
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

onMenuToggleHandler$Action(overflowMenuIdIn, isOpenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnMenuToggleHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnMenuToggleHandler");
span.setAttribute("outsystems.function.key", "45947b1e-ab33-44d4-a836-3c3de0afd709");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onMenuToggleHandler$Action, callContext, overflowMenuIdIn, isOpenIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "545bec1b-948b-4f1c-8dcd-75dd6a1ccc40");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
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
span.setAttribute("outsystems.function.key", "55189666-9dc8-4c75-aef4-6c11cf331b44");
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
span.setAttribute("outsystems.function.key", "87eba5cd-1fe3-42f3-873b-d67692c6686d");
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

registerCallback$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "d8f9cef8-b99d-4b40-8da2-559762c6ec06");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._registerCallback$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
}

get onMenuToggle$Action() {if(!(this.hasOwnProperty("_onMenuToggle$Action"))) {
this._onMenuToggle$Action = function () {
return Promise.resolve();
};
}

return this._onMenuToggle$Action;
}set onMenuToggle$Action(value) {this._onMenuToggle$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.InitializeHandler$vars", [{
name: "OverflowMenuId",
attrName: "overflowMenuIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.OnMenuToggleHandler$vars", [{
name: "OverflowMenuId",
attrName: "overflowMenuIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsOpen",
attrName: "isOpenInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.OverflowMenu.RegisterCallback$getCallbackHandlerJSResult", [{
name: "InitializeObj",
attrName: "initializeObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnToggleObj",
attrName: "onToggleObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




