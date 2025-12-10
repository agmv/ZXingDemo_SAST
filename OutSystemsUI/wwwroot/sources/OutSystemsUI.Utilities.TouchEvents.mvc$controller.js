import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Utilities_TouchEvents_mvc_TranslationsResources from "./OutSystemsUI.Utilities.TouchEvents.mvc$translationsResources.js";
import OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnDestroy_DestroyJS from "./OutSystemsUI.Utilities.TouchEvents.mvc$controller.OnDestroy.DestroyJS.js";
import OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnParametersChanged_SetPreventDefaultJS from "./OutSystemsUI.Utilities.TouchEvents.mvc$controller.OnParametersChanged.SetPreventDefaultJS.js";
import OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnReady_BindEventsJS from "./OutSystemsUI.Utilities.TouchEvents.mvc$controller.OnReady.BindEventsJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Utilities_TouchEvents_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onStart$Action: function (xIn, yIn) {
xIn = (xIn === undefined) ? 0 : xIn;
yIn = (yIn === undefined) ? 0 : yIn;
return controller.executeActionInsideJSNode(controller._onStart$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(xIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(yIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnStart");
},
onMove$Action: function (evtIn, xIn, yIn, offsetXIn, offsetYIn) {
evtIn = (evtIn === undefined) ? null : evtIn;
xIn = (xIn === undefined) ? 0 : xIn;
yIn = (yIn === undefined) ? 0 : yIn;
offsetXIn = (offsetXIn === undefined) ? 0 : offsetXIn;
offsetYIn = (offsetYIn === undefined) ? 0 : offsetYIn;
return controller.executeActionInsideJSNode(controller._onMove$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(evtIn, OS.DataTypes.DataTypes.Object), OS.DataConversion.JSNodeParamConverter.from(xIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(yIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(offsetXIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(offsetYIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnMove");
},
onEnd$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
xIn = (xIn === undefined) ? 0 : xIn;
yIn = (yIn === undefined) ? 0 : yIn;
offsetXIn = (offsetXIn === undefined) ? 0 : offsetXIn;
offsetYIn = (offsetYIn === undefined) ? 0 : offsetYIn;
timeTakenIn = (timeTakenIn === undefined) ? 0 : timeTakenIn;
return controller.executeActionInsideJSNode(controller._onEnd$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(xIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(yIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(offsetXIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(offsetYIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(timeTakenIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnEnd");
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
get _onStart$Action() {if(!(this.hasOwnProperty("__onStart$Action"))) {
this.__onStart$Action = function (xIn, yIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnStart", function (span) {
if(span) {
span.setAttribute("code.function", "OnStart");
span.setAttribute("outsystems.function.key", "26d42584-6aad-42ba-b6a6-af457dbde3dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnStart$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Start
return controller.start$Action(OS.BuiltinFunctions.integerToDecimal(vars.value.xInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.yInLocal), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onStart$Action;
}set _onStart$Action(value) {this.__onStart$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "29fa4a6b-7c1b-4b43-9aab-25ae16d77e0c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// IsBound = False
model.variables.isBoundVar = false;
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

get _onEnd$Action() {if(!(this.hasOwnProperty("__onEnd$Action"))) {
this.__onEnd$Action = function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnEnd", function (span) {
if(span) {
span.setAttribute("code.function", "OnEnd");
span.setAttribute("outsystems.function.key", "45362b2b-228a-4fec-be43-1a5d30c812e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnEnd$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: End
return controller.end$Action(OS.BuiltinFunctions.integerToDecimal(vars.value.xInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.yInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.offsetYInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.timeTakenInLocal), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onEnd$Action;
}set _onEnd$Action(value) {this.__onEnd$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "77e35339-36cd-4c7d-9b40-860a408690b5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Destroy", function (span) {
if(span) {
span.setAttribute("code.function", "Destroy");
span.setAttribute("outsystems.function.key", "05b84817-cd04-4c8f-b31d-ac434a1df1a2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnDestroy_DestroyJS, "Destroy", "OnDestroy", {
Obj: OS.DataConversion.JSNodeParamConverter.to(model.variables.gestureObjVar, OS.DataTypes.DataTypes.Object)
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "781cafa2-eb23-4db4-b88a-8a3a0a950daa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("SetPreventDefault", function (span) {
if(span) {
span.setAttribute("code.function", "SetPreventDefault");
span.setAttribute("outsystems.function.key", "f377c854-b051-41ca-8856-504b1de6f09a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnParametersChanged_SetPreventDefaultJS, "SetPreventDefault", "OnParametersChanged", {
Obj: OS.DataConversion.JSNodeParamConverter.to(model.variables.gestureObjVar, OS.DataTypes.DataTypes.Object),
Prevent: OS.DataConversion.JSNodeParamConverter.to(model.variables.preventDefaultsIn, OS.DataTypes.DataTypes.Boolean)
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

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _onMove$Action() {if(!(this.hasOwnProperty("__onMove$Action"))) {
this.__onMove$Action = function (evtIn, xIn, yIn, offsetXIn, offsetYIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnMove", function (span) {
if(span) {
span.setAttribute("code.function", "OnMove");
span.setAttribute("outsystems.function.key", "c32859ec-39df-407f-9ee5-62a833953fdd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnMove$vars"))());
vars.value.evtInLocal = evtIn;
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Move
return controller.move$Action(OS.BuiltinFunctions.integerToDecimal(vars.value.xInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.yInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal), OS.BuiltinFunctions.integerToDecimal(vars.value.offsetYInLocal), vars.value.evtInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onMove$Action;
}set _onMove$Action(value) {this.__onMove$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "e30c4ccf-79af-435b-afa0-03bc6f32ff92");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var bindEventsJSResult = new OS.DataTypes.VariableHolder();
bindEventsJSResult.value = OS.Logger.startActiveSpan("BindEvents", function (span) {
if(span) {
span.setAttribute("code.function", "BindEvents");
span.setAttribute("outsystems.function.key", "efd5eeb8-635f-4a7f-824c-43f2dbe67dbb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Utilities_TouchEvents_mvc_controller_OnReady_BindEventsJS, "BindEvents", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(model.variables.widgetIdIn, OS.DataTypes.DataTypes.Text),
isBound: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
Obj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnReady$bindEventsJSResult"))();
jsNodeResult.isBoundOut = OS.DataConversion.JSNodeParamConverter.from($parameters.isBound, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.objOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Obj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnStart: controller.clientActionProxies.onStart$Action,
OnMove: controller.clientActionProxies.onMove$Action,
OnEnd: controller.clientActionProxies.onEnd$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsBound = BindEvents.isBound
model.variables.isBoundVar = bindEventsJSResult.value.isBoundOut;
// GestureObj = BindEvents.Obj
model.variables.gestureObjVar = bindEventsJSResult.value.objOut;
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


onStart$Action(xIn, yIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnStart");
span.setAttribute("outsystems.function.key", "26d42584-6aad-42ba-b6a6-af457dbde3dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onStart$Action, callContext, xIn, yIn);
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
span.setAttribute("outsystems.function.key", "29fa4a6b-7c1b-4b43-9aab-25ae16d77e0c");
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

onEnd$Action(xIn, yIn, offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnEnd");
span.setAttribute("outsystems.function.key", "45362b2b-228a-4fec-be43-1a5d30c812e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onEnd$Action, callContext, xIn, yIn, offsetXIn, offsetYIn, timeTakenIn);
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
span.setAttribute("outsystems.function.key", "77e35339-36cd-4c7d-9b40-860a408690b5");
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
span.setAttribute("outsystems.function.key", "781cafa2-eb23-4db4-b88a-8a3a0a950daa");
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

onMove$Action(evtIn, xIn, yIn, offsetXIn, offsetYIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnMove");
span.setAttribute("outsystems.function.key", "c32859ec-39df-407f-9ee5-62a833953fdd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onMove$Action, callContext, evtIn, xIn, yIn, offsetXIn, offsetYIn);
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
span.setAttribute("outsystems.function.key", "e30c4ccf-79af-435b-afa0-03bc6f32ff92");
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

get start$Action() {if(!(this.hasOwnProperty("_start$Action"))) {
this._start$Action = function () {
return Promise.resolve();
};
}

return this._start$Action;
}set start$Action(value) {this._start$Action = value;
}

get move$Action() {if(!(this.hasOwnProperty("_move$Action"))) {
this._move$Action = function () {
return Promise.resolve();
};
}

return this._move$Action;
}set move$Action(value) {this._move$Action = value;
}

get end$Action() {if(!(this.hasOwnProperty("_end$Action"))) {
this._end$Action = function () {
return Promise.resolve();
};
}

return this._end$Action;
}set end$Action(value) {this._end$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnStart$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnEnd$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "TimeTaken",
attrName: "timeTakenInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnMove$vars", [{
name: "Evt",
attrName: "evtInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Utilities.TouchEvents.OnReady$bindEventsJSResult", [{
name: "isBound",
attrName: "isBoundOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Obj",
attrName: "objOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




