import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_Video_mvc_TranslationsResources from "./OutSystemsUI.Interaction.Video.mvc$translationsResources.js";
import OutSystemsUI_Interaction_Video_mvc_controller_RegisterCallback_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.Video.mvc$controller.RegisterCallback.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_Video_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
initializedHandler$Action: function (videoIdIn) {
videoIdIn = (videoIdIn === undefined) ? "" : videoIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(videoIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializedHandler");
},
stateChangedHandler$Action: function (videoIdIn, videoStateIn) {
videoIdIn = (videoIdIn === undefined) ? "" : videoIdIn;
videoStateIn = (videoStateIn === undefined) ? OutSystemsUIModel.staticEntities.videoState.unstarted : videoStateIn;
return controller.executeActionInsideJSNode(controller._stateChangedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(videoIdIn, OS.DataTypes.DataTypes.Text), videoStateIn), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "StateChangedHandler");
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
get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "3b85d814-3bcf-4421-992e-714542a082d7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var jSONSerialize_CaptionsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Video", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// JSON Serialize: JSONSerialize_Captions
jSONSerialize_CaptionsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.captionsIn, false, false);
// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.URL = URL
model.variables.internalConfigsVar.uRLAttr = model.variables.uRLIn;
// InternalConfigs.Controls = Controls
model.variables.internalConfigsVar.controlsAttr = model.variables.controlsIn;
// InternalConfigs.Width = Width
model.variables.internalConfigsVar.widthAttr = model.variables.widthIn;
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.Captions = JSONSerialize_Captions.JSON
model.variables.internalConfigsVar.captionsAttr = jSONSerialize_CaptionsVar.value.jSONOut;
// InternalConfigs.Autoplay = OptionalConfigs.Autoplay
model.variables.internalConfigsVar.autoplayAttr = model.variables.optionalConfigsIn.autoplayAttr;
// InternalConfigs.Loop = OptionalConfigs.Loop
model.variables.internalConfigsVar.loopAttr = model.variables.optionalConfigsIn.loopAttr;
// InternalConfigs.Muted = OptionalConfigs.Muted
model.variables.internalConfigsVar.mutedAttr = model.variables.optionalConfigsIn.mutedAttr;
// InternalConfigs.PosterURL = OptionalConfigs.PosterURL
model.variables.internalConfigsVar.posterURLAttr = model.variables.optionalConfigsIn.posterURLAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: VideoCreate
OutSystemsUIController.default.videoCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, callContext);
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

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (videoIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "5cd40f32-5d7c-4ae4-b5ea-94ca19ef71c5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Video.InitializedHandler$vars"))());
vars.value.videoIdInLocal = videoIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.videoIdInLocal, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6c6aa3b6-d45a-4778-9c60-cfbe2b7dbafb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.internalConfigsVar.autoplayAttr) !== (model.variables.optionalConfigsIn.autoplayAttr)))) {
// InternalConfigs.Autoplay = OptionalConfigs.Autoplay
model.variables.internalConfigsVar.autoplayAttr = model.variables.optionalConfigsIn.autoplayAttr;
// Execute Action: Update_Autoplay
OutSystemsUIController.default.videoChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Autoplay", model.variables.internalConfigsVar.autoplayAttr, callContext);
}

if((((model.variables.internalConfigsVar.controlsAttr) !== (model.variables.controlsIn)))) {
// InternalConfigs.Controls = Controls
model.variables.internalConfigsVar.controlsAttr = model.variables.controlsIn;
// Execute Action: Update_Controls
OutSystemsUIController.default.videoChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Controls", model.variables.internalConfigsVar.controlsAttr, callContext);
}

if((((model.variables.internalConfigsVar.loopAttr) !== (model.variables.optionalConfigsIn.loopAttr)))) {
// InternalConfigs.Loop = OptionalConfigs.Loop
model.variables.internalConfigsVar.loopAttr = model.variables.optionalConfigsIn.loopAttr;
// Execute Action: Update_Loop
OutSystemsUIController.default.videoChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Loop", model.variables.internalConfigsVar.loopAttr, callContext);
}

if((((model.variables.internalConfigsVar.mutedAttr) !== (model.variables.optionalConfigsIn.mutedAttr)))) {
// InternalConfigs.Muted = OptionalConfigs.Muted
model.variables.internalConfigsVar.mutedAttr = model.variables.optionalConfigsIn.mutedAttr;
// Execute Action: Update_Muted
OutSystemsUIController.default.videoChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Muted", model.variables.internalConfigsVar.mutedAttr, callContext);
}

if((((model.variables.internalConfigsVar.uRLAttr) !== (model.variables.uRLIn)))) {
// InternalConfigs.URL = URL
model.variables.internalConfigsVar.uRLAttr = model.variables.uRLIn;
// Execute Action: Update_URL
OutSystemsUIController.default.videoChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "URL", model.variables.internalConfigsVar.uRLAttr, callContext);
}

if((((model.variables.internalConfigsVar.posterURLAttr) !== (model.variables.optionalConfigsIn.posterURLAttr)))) {
// InternalConfigs.PosterURL = OptionalConfigs.PosterURL
model.variables.internalConfigsVar.posterURLAttr = model.variables.optionalConfigsIn.posterURLAttr;
// Execute Action: Update_PosterURL
OutSystemsUIController.default.videoChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "PosterURL", model.variables.internalConfigsVar.posterURLAttr, callContext);
}

if((((model.variables.internalConfigsVar.widthAttr) !== (model.variables.widthIn)))) {
// InternalConfigs.Width = Width
model.variables.internalConfigsVar.widthAttr = model.variables.widthIn;
// Execute Action: Update_Width
OutSystemsUIController.default.videoChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Width", model.variables.internalConfigsVar.widthAttr, callContext);
}

if((((model.variables.internalConfigsVar.heightAttr) !== (model.variables.heightIn)))) {
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// Execute Action: Update_Height
OutSystemsUIController.default.videoChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Height", model.variables.internalConfigsVar.heightAttr, callContext);
}

if((((model.variables.internalConfigsVar.extendedClassAttr) !== (model.variables.extendedClassIn)))) {
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.videoChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internalConfigsVar.extendedClassAttr, callContext);
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

get _registerCallback$Action() {if(!(this.hasOwnProperty("__registerCallback$Action"))) {
this.__registerCallback$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallback", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "7557ee72-e69a-47a5-ac15-a85432bd4396");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RegisterCallback");
callContext = controller.callContext(callContext);
var getCallbackHandlersJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlersJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandlers", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandlers");
span.setAttribute("outsystems.function.key", "ffa3728b-1e50-4cd8-ae16-0fde1b7c0447");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_Video_mvc_controller_RegisterCallback_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallback", {
Initialized: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnStateChanged: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Video.RegisterCallback$getCallbackHandlersJSResult"))();
jsNodeResult.initializedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Initialized, OS.DataTypes.DataTypes.Object);
jsNodeResult.onStateChangedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnStateChanged, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
InitializedHandler: controller.clientActionProxies.initializedHandler$Action,
StateChangedHandler: controller.clientActionProxies.stateChangedHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RegisterOnInitialize
OutSystemsUIController.default.videoRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Initialized", getCallbackHandlersJSResult.value.initializedOut, callContext);
// Execute Action: RegisterOnStateChanged
OutSystemsUIController.default.videoRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StateChanged", getCallbackHandlersJSResult.value.onStateChangedOut, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "af0a4422-d04e-4812-9c9a-129090e6c674");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: VideoInitialize
OutSystemsUIController.default.videoInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Video created", callContext);
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

get _stateChangedHandler$Action() {if(!(this.hasOwnProperty("__stateChangedHandler$Action"))) {
this.__stateChangedHandler$Action = function (videoIdIn, videoStateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("StateChangedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "StateChangedHandler");
span.setAttribute("outsystems.function.key", "bc48d14d-ca3e-4a77-88bf-b3ad1e71485c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("StateChangedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Video.StateChangedHandler$vars"))());
vars.value.videoIdInLocal = videoIdIn;
vars.value.videoStateInLocal = videoStateIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: StateChanged
return controller.stateChanged$Action(vars.value.videoIdInLocal, vars.value.videoStateInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__stateChangedHandler$Action;
}set _stateChangedHandler$Action(value) {this.__stateChangedHandler$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "c58becd8-7314-4c25-b6ec-3d571eae4e6d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: VideoDestroy
OutSystemsUIController.default.videoDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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


onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "3b85d814-3bcf-4421-992e-714542a082d7");
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

initializedHandler$Action(videoIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "5cd40f32-5d7c-4ae4-b5ea-94ca19ef71c5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, videoIdIn);
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
span.setAttribute("outsystems.function.key", "6c6aa3b6-d45a-4778-9c60-cfbe2b7dbafb");
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

registerCallback$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallback");
span.setAttribute("outsystems.function.key", "7557ee72-e69a-47a5-ac15-a85432bd4396");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "af0a4422-d04e-4812-9c9a-129090e6c674");
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

stateChangedHandler$Action(videoIdIn, videoStateIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("StateChangedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StateChangedHandler");
span.setAttribute("outsystems.function.key", "bc48d14d-ca3e-4a77-88bf-b3ad1e71485c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._stateChangedHandler$Action, callContext, videoIdIn, videoStateIn);
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
span.setAttribute("outsystems.function.key", "c58becd8-7314-4c25-b6ec-3d571eae4e6d");
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

get stateChanged$Action() {if(!(this.hasOwnProperty("_stateChanged$Action"))) {
this._stateChanged$Action = function () {
return Promise.resolve();
};
}

return this._stateChanged$Action;
}set stateChanged$Action(value) {this._stateChanged$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Video.InitializedHandler$vars", [{
name: "VideoId",
attrName: "videoIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Video.RegisterCallback$getCallbackHandlersJSResult", [{
name: "Initialized",
attrName: "initializedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnStateChanged",
attrName: "onStateChangedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Video.StateChangedHandler$vars", [{
name: "VideoId",
attrName: "videoIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "VideoState",
attrName: "videoStateInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return OutSystemsUIModel.staticEntities.videoState.unstarted;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




