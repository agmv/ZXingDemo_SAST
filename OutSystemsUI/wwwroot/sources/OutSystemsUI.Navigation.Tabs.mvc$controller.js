import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_Tabs_mvc_TranslationsResources from "./OutSystemsUI.Navigation.Tabs.mvc$translationsResources.js";
import OutSystemsUI_Navigation_Tabs_mvc_controller_RegisterCallback_GetCallbackHandlerJS from "./OutSystemsUI.Navigation.Tabs.mvc$controller.RegisterCallback.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_Tabs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
initializedHandler$Action: function (tabsIdIn) {
tabsIdIn = (tabsIdIn === undefined) ? "" : tabsIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(tabsIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializedHandler");
},
onTabChangeHandler$Action: function (tabsIdIn, currentActiveTabIn) {
tabsIdIn = (tabsIdIn === undefined) ? "" : tabsIdIn;
currentActiveTabIn = (currentActiveTabIn === undefined) ? 0 : currentActiveTabIn;
return controller.executeActionInsideJSNode(controller._onTabChangeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(tabsIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(currentActiveTabIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnTabChangeHandler");
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
get _registerCallback$Action() {if(!(this.hasOwnProperty("__registerCallback$Action"))) {
this.__registerCallback$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallback", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "11e96aaa-70a8-4668-8df4-3d7e25b3a75e");
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
span.setAttribute("outsystems.function.key", "66849ead-107e-48e5-a2b7-7e242c30a66b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Tabs_mvc_controller_RegisterCallback_GetCallbackHandlerJS, "GetCallbackHandler", "RegisterCallback", {
IntializedHandler: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnChange: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Tabs.RegisterCallback$getCallbackHandlerJSResult"))();
jsNodeResult.intializedHandlerOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IntializedHandler, OS.DataTypes.DataTypes.Object);
jsNodeResult.onChangeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnChange, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
InitializedHandler: controller.clientActionProxies.initializedHandler$Action,
OnTabChangeHandler: controller.clientActionProxies.onTabChangeHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: TabsRegisterInitializedCallback
OutSystemsUIController.default.tabsRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlerJSResult.value.intializedHandlerOut, callContext);
// Execute Action: TabsRegisterOnChangeCallback
OutSystemsUIController.default.tabsRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onChange, getCallbackHandlerJSResult.value.onChangeOut, callContext);
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

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (tabsIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "27280cce-f4dc-4adf-9fba-cf1482e03854");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Tabs.InitializedHandler$vars"))());
vars.value.tabsIdInLocal = tabsIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.tabsIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__initializedHandler$Action;
}set _initializedHandler$Action(value) {this.__initializedHandler$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "42ccda6f-41b3-4660-986f-b34150a4d85c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Tabs", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.StartingTab = StartingTab
model.variables.internalConfigsVar.startingTabAttr = model.variables.startingTabIn;
// InternalConfigs.TabsOrientation = TabsOrientation
model.variables.internalConfigsVar.tabsOrientationAttr = model.variables.tabsOrientationIn;
// InternalConfigs.TabsVerticalPosition = TabsVerticalPosition
model.variables.internalConfigsVar.tabsVerticalPositionAttr = model.variables.tabsVerticalPositionIn;
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// InternalConfigs.JustifyHeaders = OptionalConfigs.JustifyHeaders
model.variables.internalConfigsVar.justifyHeadersAttr = model.variables.optionalConfigsIn.justifyHeadersAttr;
// InternalConfigs.ContentAutoHeight = OptionalConfigs.ContentAutoHeight
model.variables.internalConfigsVar.contentAutoHeightAttr = model.variables.optionalConfigsIn.contentAutoHeightAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: TabsCreate
OutSystemsUIController.default.tabsCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "7d14b681-7504-4541-ae36-f5406edf8efe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: TabsInitialize
OutSystemsUIController.default.tabsInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Tabs created", callContext);
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
span.setAttribute("outsystems.function.key", "890346e2-f639-4266-b0d5-1db2ea681631");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: TabsDestroy
OutSystemsUIController.default.tabsDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "f0d416cc-e6c0-4332-bf4e-41f84d176769");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.startingTabIn) !== (model.variables.internalConfigsVar.startingTabAttr)))) {
// InternalConfigs.StartingTab = StartingTab
model.variables.internalConfigsVar.startingTabAttr = model.variables.startingTabIn;
// Execute Action: Update_StartingTab
OutSystemsUIController.default.tabsChangeIntegerProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingTab", model.variables.internalConfigsVar.startingTabAttr, callContext);
}

if((((model.variables.tabsOrientationIn) !== (model.variables.internalConfigsVar.tabsOrientationAttr)))) {
// InternalConfigs.TabsOrientation = TabsOrientation
model.variables.internalConfigsVar.tabsOrientationAttr = model.variables.tabsOrientationIn;
// Execute Action: Update_TabsOrientation
OutSystemsUIController.default.tabsChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "TabsOrientation", model.variables.internalConfigsVar.tabsOrientationAttr, callContext);
}

if((((model.variables.tabsVerticalPositionIn) !== (model.variables.internalConfigsVar.tabsVerticalPositionAttr)))) {
// InternalConfigs.TabsVerticalPosition = TabsVerticalPosition
model.variables.internalConfigsVar.tabsVerticalPositionAttr = model.variables.tabsVerticalPositionIn;
// Execute Action: Update_TabsVerticalPosition
OutSystemsUIController.default.tabsChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "TabsVerticalPosition", model.variables.internalConfigsVar.tabsVerticalPositionAttr, callContext);
}

if((((model.variables.heightIn) !== (model.variables.internalConfigsVar.heightAttr)))) {
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// Execute Action: Update_Height
OutSystemsUIController.default.tabsChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Height", model.variables.internalConfigsVar.heightAttr, callContext);
}

if((((model.variables.optionalConfigsIn.contentAutoHeightAttr) !== (model.variables.internalConfigsVar.contentAutoHeightAttr)))) {
// InternalConfigs.ContentAutoHeight = OptionalConfigs.ContentAutoHeight
model.variables.internalConfigsVar.contentAutoHeightAttr = model.variables.optionalConfigsIn.contentAutoHeightAttr;
// Execute Action: Update_ContentAutoHeight
OutSystemsUIController.default.tabsChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ContentAutoHeight", model.variables.internalConfigsVar.contentAutoHeightAttr, callContext);
}

if((((model.variables.optionalConfigsIn.justifyHeadersAttr) !== (model.variables.internalConfigsVar.justifyHeadersAttr)))) {
// InternalConfigs.JustifyHeaders = OptionalConfigs.JustifyHeaders
model.variables.internalConfigsVar.justifyHeadersAttr = model.variables.optionalConfigsIn.justifyHeadersAttr;
// Execute Action: Update_JustifyHeaders
OutSystemsUIController.default.tabsChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "JustifyHeaders", model.variables.internalConfigsVar.justifyHeadersAttr, callContext);
}

if((((model.variables.extendedClassIn) !== (model.variables.internalConfigsVar.extendedClassAttr)))) {
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.tabsChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.extendedClassIn, callContext);
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

get _onTabChangeHandler$Action() {if(!(this.hasOwnProperty("__onTabChangeHandler$Action"))) {
this.__onTabChangeHandler$Action = function (tabsIdIn, currentActiveTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnTabChangeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnTabChangeHandler");
span.setAttribute("outsystems.function.key", "f65fe446-321a-4141-9258-6ebd704cc406");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnTabChangeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Tabs.OnTabChangeHandler$vars"))());
vars.value.tabsIdInLocal = tabsIdIn;
vars.value.currentActiveTabInLocal = currentActiveTabIn;
return OS.Flow.executeAsyncFlow(function () {
// InternalConfigs.StartingTab = CurrentActiveTab
model.variables.internalConfigsVar.startingTabAttr = vars.value.currentActiveTabInLocal;
// Trigger Event: OnSelectValue
return controller.onTabChange$Action(vars.value.tabsIdInLocal, vars.value.currentActiveTabInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onTabChangeHandler$Action;
}set _onTabChangeHandler$Action(value) {this.__onTabChangeHandler$Action = value;
}


registerCallback$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "11e96aaa-70a8-4668-8df4-3d7e25b3a75e");
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

initializedHandler$Action(tabsIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "27280cce-f4dc-4adf-9fba-cf1482e03854");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, tabsIdIn);
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
span.setAttribute("outsystems.function.key", "42ccda6f-41b3-4660-986f-b34150a4d85c");
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
span.setAttribute("outsystems.function.key", "7d14b681-7504-4541-ae36-f5406edf8efe");
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
span.setAttribute("outsystems.function.key", "890346e2-f639-4266-b0d5-1db2ea681631");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "f0d416cc-e6c0-4332-bf4e-41f84d176769");
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

onTabChangeHandler$Action(tabsIdIn, currentActiveTabIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnTabChangeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnTabChangeHandler");
span.setAttribute("outsystems.function.key", "f65fe446-321a-4141-9258-6ebd704cc406");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onTabChangeHandler$Action, callContext, tabsIdIn, currentActiveTabIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onTabChange$Action() {if(!(this.hasOwnProperty("_onTabChange$Action"))) {
this._onTabChange$Action = function () {
return Promise.resolve();
};
}

return this._onTabChange$Action;
}set onTabChange$Action(value) {this._onTabChange$Action = value;
}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Tabs.RegisterCallback$getCallbackHandlerJSResult", [{
name: "IntializedHandler",
attrName: "intializedHandlerOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnChange",
attrName: "onChangeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Tabs.InitializedHandler$vars", [{
name: "TabsId",
attrName: "tabsIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Tabs.OnTabChangeHandler$vars", [{
name: "TabsId",
attrName: "tabsIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "CurrentActiveTab",
attrName: "currentActiveTabInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




