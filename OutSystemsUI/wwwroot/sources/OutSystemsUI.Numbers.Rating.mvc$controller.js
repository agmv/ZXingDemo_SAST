import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Numbers_Rating_mvc_TranslationsResources from "./OutSystemsUI.Numbers.Rating.mvc$translationsResources.js";
import OutSystemsUI_Numbers_Rating_mvc_controller_RegisterCallback_GetCallbackHandlerJS from "./OutSystemsUI.Numbers.Rating.mvc$controller.RegisterCallback.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Numbers_Rating_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
initializedHandler$Action: function (ratingIdIn) {
ratingIdIn = (ratingIdIn === undefined) ? "" : ratingIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(ratingIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializedHandler");
},
onSelectHandler$Action: function (ratingIdIn, valueIn) {
ratingIdIn = (ratingIdIn === undefined) ? "" : ratingIdIn;
valueIn = (valueIn === undefined) ? OS.DataTypes.Decimal.defaultValue : valueIn;
return controller.executeActionInsideJSNode(controller._onSelectHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(ratingIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(valueIn, OS.DataTypes.DataTypes.Decimal)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSelectHandler");
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
span.setAttribute("outsystems.function.key", "53539d73-b016-454d-a464-0d732018b34f");
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
span.setAttribute("outsystems.function.key", "c0543a17-2259-43a9-a309-929c7db1184e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Numbers_Rating_mvc_controller_RegisterCallback_GetCallbackHandlerJS, "GetCallbackHandler", "RegisterCallback", {
OnInitializedHandler: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnSelectHandler: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Numbers.Rating.RegisterCallback$getCallbackHandlerJSResult"))();
jsNodeResult.onInitializedHandlerOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnInitializedHandler, OS.DataTypes.DataTypes.Object);
jsNodeResult.onSelectHandlerOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnSelectHandler, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
InitializedHandler: controller.clientActionProxies.initializedHandler$Action,
OnSelectHandler: controller.clientActionProxies.onSelectHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RatingRegisterInitializedCallback
OutSystemsUIController.default.ratingRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlerJSResult.value.onInitializedHandlerOut, callContext);
// Execute Action: RatingRegisterOnSelectCallback
OutSystemsUIController.default.ratingRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onSelected, getCallbackHandlerJSResult.value.onSelectHandlerOut, callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "7d3cd0a9-811e-4b40-abb4-14445aa1b8cb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Rating", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.RatingScale = RatingScale
model.variables.internalConfigsVar.ratingScaleAttr = model.variables.ratingScaleIn;
// InternalConfigs.RatingValue = RatingValue
model.variables.internalConfigsVar.ratingValueAttr = model.variables.ratingValueIn;
// InternalConfigs.IsEdit = IsEdit
model.variables.internalConfigsVar.isEditAttr = model.variables.isEditIn;
// InternalConfigs.Size = Size
model.variables.internalConfigsVar.sizeAttr = model.variables.sizeIn;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: RatingCreate
OutSystemsUIController.default.ratingCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, callContext);
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

get _onSelectHandler$Action() {if(!(this.hasOwnProperty("__onSelectHandler$Action"))) {
this.__onSelectHandler$Action = function (ratingIdIn, valueIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSelectHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectHandler");
span.setAttribute("outsystems.function.key", "87ba2f83-4e3a-4783-a105-7760ab2b2494");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSelectHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Numbers.Rating.OnSelectHandler$vars"))());
vars.value.ratingIdInLocal = ratingIdIn;
vars.value.valueInLocal = valueIn;
return OS.Flow.executeAsyncFlow(function () {
// InternalConfigs.RatingValue = Value
model.variables.internalConfigsVar.ratingValueAttr = vars.value.valueInLocal;
// Trigger Event: OnSelectValue
return controller.onSelect$Action(vars.value.ratingIdInLocal, vars.value.valueInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onSelectHandler$Action;
}set _onSelectHandler$Action(value) {this.__onSelectHandler$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "ab94f8d0-5183-4712-b3a4-7ea43e9f7ff1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: RatingInitialize
OutSystemsUIController.default.ratingInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Rating created", callContext);
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
span.setAttribute("outsystems.function.key", "b9b4e5d8-29df-4329-97ad-34959b7ca41f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RatingDestroy
OutSystemsUIController.default.ratingDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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
span.setAttribute("outsystems.function.key", "c6ee0d8b-03f8-4b01-b1e6-ad85f935a1bd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.ratingScaleIn > 0) && ((model.variables.ratingScaleIn) !== (model.variables.internalConfigsVar.ratingScaleAttr))))) {
// InternalConfigs.RatingScale = RatingScale
model.variables.internalConfigsVar.ratingScaleAttr = model.variables.ratingScaleIn;
// Execute Action: RatingChangeRatingScale
OutSystemsUIController.default.ratingChangeRatingScale$Action(model.variables.internalConfigsVar.uniqueIdAttr, model.variables.internalConfigsVar.ratingScaleAttr, callContext);
}

if((((OS.BuiltinFunctions.decimalToText(model.variables.ratingValueIn)) !== (OS.BuiltinFunctions.decimalToText(model.variables.internalConfigsVar.ratingValueAttr))))) {
// InternalConfigs.RatingValue = RatingValue
model.variables.internalConfigsVar.ratingValueAttr = model.variables.ratingValueIn;
// Execute Action: RatingChangeRatingValue
OutSystemsUIController.default.ratingChangeRatingValue$Action(model.variables.internalConfigsVar.uniqueIdAttr, model.variables.internalConfigsVar.ratingValueAttr, callContext);
}

if((((model.variables.isEditIn) !== (model.variables.internalConfigsVar.isEditAttr)))) {
// InternalConfigs.IsEdit = IsEdit
model.variables.internalConfigsVar.isEditAttr = model.variables.isEditIn;
// Execute Action: RatingChangeIsEdit
OutSystemsUIController.default.ratingChangeIsEdit$Action(model.variables.internalConfigsVar.uniqueIdAttr, model.variables.internalConfigsVar.isEditAttr, callContext);
}

if((((model.variables.sizeIn) !== (model.variables.internalConfigsVar.sizeAttr)))) {
// InternalConfigs.Size = Size
model.variables.internalConfigsVar.sizeAttr = model.variables.sizeIn;
// Execute Action: RatingChangeSize
OutSystemsUIController.default.ratingChangeSize$Action(model.variables.internalConfigsVar.uniqueIdAttr, model.variables.internalConfigsVar.sizeAttr, callContext);
}

if((((model.variables.extendedClassIn) !== (model.variables.internalConfigsVar.extendedClassAttr)))) {
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: RatingChangeExtendedClass
OutSystemsUIController.default.ratingChangeExtendedClass$Action(model.variables.internalConfigsVar.uniqueIdAttr, model.variables.internalConfigsVar.extendedClassAttr, callContext);
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

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (ratingIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "e0c56d54-1695-4da9-bde8-73653b4fbf5e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Numbers.Rating.InitializedHandler$vars"))());
vars.value.ratingIdInLocal = ratingIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.ratingIdInLocal, callContext);
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


registerCallback$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "53539d73-b016-454d-a464-0d732018b34f");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "7d3cd0a9-811e-4b40-abb4-14445aa1b8cb");
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

onSelectHandler$Action(ratingIdIn, valueIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSelectHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectHandler");
span.setAttribute("outsystems.function.key", "87ba2f83-4e3a-4783-a105-7760ab2b2494");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSelectHandler$Action, callContext, ratingIdIn, valueIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "ab94f8d0-5183-4712-b3a4-7ea43e9f7ff1");
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
span.setAttribute("outsystems.function.key", "b9b4e5d8-29df-4329-97ad-34959b7ca41f");
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
span.setAttribute("outsystems.function.key", "c6ee0d8b-03f8-4b01-b1e6-ad85f935a1bd");
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

initializedHandler$Action(ratingIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "e0c56d54-1695-4da9-bde8-73653b4fbf5e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, ratingIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onSelect$Action() {if(!(this.hasOwnProperty("_onSelect$Action"))) {
this._onSelect$Action = function () {
return Promise.resolve();
};
}

return this._onSelect$Action;
}set onSelect$Action(value) {this._onSelect$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Numbers.Rating.RegisterCallback$getCallbackHandlerJSResult", [{
name: "OnInitializedHandler",
attrName: "onInitializedHandlerOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnSelectHandler",
attrName: "onSelectHandlerOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Numbers.Rating.OnSelectHandler$vars", [{
name: "RatingId",
attrName: "ratingIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Value",
attrName: "valueInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Numbers.Rating.InitializedHandler$vars", [{
name: "RatingId",
attrName: "ratingIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




