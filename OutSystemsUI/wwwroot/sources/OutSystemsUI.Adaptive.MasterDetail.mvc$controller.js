import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_TranslationsResources from "./OutSystemsUI.Adaptive.MasterDetail.mvc$translationsResources.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnDetailOpen_OpenRightContentJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.OnDetailOpen.OpenRightContentJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_FocusTrap_FocusTrapJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.FocusTrap.FocusTrapJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_SetAttributes_setAttributesJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.SetAttributes.setAttributesJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnParametersChanged_ToogleRightContentJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.OnParametersChanged.ToogleRightContentJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnDetailClose_CloseRightContentJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.OnDetailClose.CloseRightContentJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.OnReady.InitJS.js";
import OutSystemsUI_Adaptive_MasterDetail_mvc_controller_FocusOnSpan_FocusOnSpanJS from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.FocusOnSpan.FocusOnSpanJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Adaptive_MasterDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
getActiveElement$Action: function (objectIn) {
objectIn = (objectIn === undefined) ? null : objectIn;
return controller.executeActionInsideJSNode(controller._getActiveElement$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(objectIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "GetActiveElement");
},
focusTrap$Action: function (eventIn) {
eventIn = (eventIn === undefined) ? null : eventIn;
return controller.executeActionInsideJSNode(controller._focusTrap$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(eventIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "FocusTrap");
},
setAttributes$Action: function () {
return controller.executeActionInsideJSNode(controller._setAttributes$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetAttributes");
},
onDetailClose$Action: function () {
return controller.executeActionInsideJSNode(controller._onDetailClose$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnDetailClose");
},
onDetailOpen$Action: function () {
return controller.executeActionInsideJSNode(controller._onDetailOpen$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnDetailOpen");
},
focusOnSpan$Action: function (eventIn) {
eventIn = (eventIn === undefined) ? null : eventIn;
return controller.executeActionInsideJSNode(controller._focusOnSpan$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(eventIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "FocusOnSpan");
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
get _onDetailOpen$Action() {if(!(this.hasOwnProperty("__onDetailOpen$Action"))) {
this.__onDetailOpen$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDetailOpen", function (span) {
if(span) {
span.setAttribute("code.function", "OnDetailOpen");
span.setAttribute("outsystems.function.key", "0604b7db-ef2d-4028-9f0b-3f273ae6ab54");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDetailOpen");
callContext = controller.callContext(callContext);
// OpenedOnPhone = True
model.variables.openedOnPhoneIn = true;
OS.Logger.startActiveSpan("OpenRightContent", function (span) {
if(span) {
span.setAttribute("code.function", "OpenRightContent");
span.setAttribute("outsystems.function.key", "36f84bd3-bb8c-4730-9c7f-45c474cf9f1d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnDetailOpen_OpenRightContentJS, "OpenRightContent", "OnDetailOpen", {
ElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitScreenWrapper"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
GetActiveElement: controller.clientActionProxies.getActiveElement$Action,
FocusTrap: controller.clientActionProxies.focusTrap$Action,
SetAttributes: controller.clientActionProxies.setAttributes$Action
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

return this.__onDetailOpen$Action;
}set _onDetailOpen$Action(value) {this.__onDetailOpen$Action = value;
}

get _focusTrap$Action() {if(!(this.hasOwnProperty("__focusTrap$Action"))) {
this.__focusTrap$Action = function (eventIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("FocusTrap", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "06e3e2ae-96c0-41a4-8fd7-844934e53d64");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("FocusTrap");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.FocusTrap$vars"))());
vars.value.eventInLocal = eventIn;
OS.Logger.startActiveSpan("FocusTrap", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "7c38bc9b-49e9-4fd0-9185-d3e8dcf51cde");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_FocusTrap_FocusTrapJS, "FocusTrap", "FocusTrap", {
RightPanelId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("RightContent"), OS.DataTypes.DataTypes.Text),
Event: OS.DataConversion.JSNodeParamConverter.to(vars.value.eventInLocal, OS.DataTypes.DataTypes.Object),
CloseButtonId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitRightCloseLink"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnDetailClose: controller.clientActionProxies.onDetailClose$Action
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

return this.__focusTrap$Action;
}set _focusTrap$Action(value) {this.__focusTrap$Action = value;
}

get _getActiveElement$Action() {if(!(this.hasOwnProperty("__getActiveElement$Action"))) {
this.__getActiveElement$Action = function (objectIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GetActiveElement", function (span) {
if(span) {
span.setAttribute("code.function", "GetActiveElement");
span.setAttribute("outsystems.function.key", "2666f0e6-d65c-4da6-86b1-c6763b43b96a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetActiveElement");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.GetActiveElement$vars"))());
vars.value.objectInLocal = objectIn;
// ActiveDOMElem = Object
model.variables.activeDOMElemVar = vars.value.objectInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__getActiveElement$Action;
}set _getActiveElement$Action(value) {this.__getActiveElement$Action = value;
}

get _setAttributes$Action() {if(!(this.hasOwnProperty("__setAttributes$Action"))) {
this.__setAttributes$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetAttributes", function (span) {
if(span) {
span.setAttribute("code.function", "SetAttributes");
span.setAttribute("outsystems.function.key", "27ce612c-621f-4b5c-8245-ddcb93d3b1b8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetAttributes");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("setAttributes", function (span) {
if(span) {
span.setAttribute("code.function", "setAttributes");
span.setAttribute("outsystems.function.key", "cb9476a3-792f-49d3-accf-cb353c5125f2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_SetAttributes_setAttributesJS, "setAttributes", "SetAttributes", {
IsOpenedOnPhone: OS.DataConversion.JSNodeParamConverter.to(model.variables.openedOnPhoneIn, OS.DataTypes.DataTypes.Boolean),
RightPanelId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitRight"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
SetAttributes: controller.clientActionProxies.setAttributes$Action
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

return this.__setAttributes$Action;
}set _setAttributes$Action(value) {this.__setAttributes$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "37546d33-937e-4fbf-9b03-944b19d99444");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("ToogleRightContent", function (span) {
if(span) {
span.setAttribute("code.function", "ToogleRightContent");
span.setAttribute("outsystems.function.key", "125f8646-248e-46a0-96ab-c8488edabda6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnParametersChanged_ToogleRightContentJS, "ToogleRightContent", "OnParametersChanged", {
ToOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.openedOnPhoneIn, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
OnDetailOpen: controller.clientActionProxies.onDetailOpen$Action,
OnDetailClose: controller.clientActionProxies.onDetailClose$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: OnReady
controller._onReady$Action(callContext);
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

get _onDetailClose$Action() {if(!(this.hasOwnProperty("__onDetailClose$Action"))) {
this.__onDetailClose$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDetailClose", function (span) {
if(span) {
span.setAttribute("code.function", "OnDetailClose");
span.setAttribute("outsystems.function.key", "63a229b4-32da-440e-816b-d8fccd2b83f3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDetailClose");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// OpenedOnPhone = False
model.variables.openedOnPhoneIn = false;
OS.Logger.startActiveSpan("CloseRightContent", function (span) {
if(span) {
span.setAttribute("code.function", "CloseRightContent");
span.setAttribute("outsystems.function.key", "e35b1c27-2b5f-4ec5-ba10-fa7dae20c359");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnDetailClose_CloseRightContentJS, "CloseRightContent", "OnDetailClose", {
ActiveDOMElem: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeDOMElemVar, OS.DataTypes.DataTypes.Object),
ElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitScreenWrapper"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
FocusTrap: controller.clientActionProxies.focusTrap$Action,
SetAttributes: controller.clientActionProxies.setAttributes$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Trigger Event: DetailClose
return controller.detailClose$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onDetailClose$Action;
}set _onDetailClose$Action(value) {this.__onDetailClose$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "6dbb74e8-b68a-422a-9f19-645dd268e3f1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var initJSResult = new OS.DataTypes.VariableHolder();
// IsWebApp = IsWebApp() = True
model.variables.isWebAppVar = (OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut === true);
// IsLayoutNative = IsLayoutNative()
model.variables.isLayoutNativeVar = OutSystemsUIController.default.isLayoutNative$Action(callContext).isNativeOut;
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "bdfb04db-5358-44d9-90ef-efea034dbf58");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
LeftPercentage: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftPercentageIn, OS.DataTypes.DataTypes.Decimal),
IsLayoutNative: OS.DataConversion.JSNodeParamConverter.to(model.variables.isLayoutNativeVar, OS.DataTypes.DataTypes.Boolean),
ElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitScreenWrapper"), OS.DataTypes.DataTypes.Text),
IsWebApp: OS.DataConversion.JSNodeParamConverter.to(model.variables.isWebAppVar, OS.DataTypes.DataTypes.Boolean),
Height: OS.DataConversion.JSNodeParamConverter.to(model.variables.heightIn, OS.DataTypes.DataTypes.Text),
RightClose: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SplitRightClose"), OS.DataTypes.DataTypes.Text),
IsPhone: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.OnReady$initJSResult"))();
jsNodeResult.isPhoneOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsPhone, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {
MoveElement: OutSystemsUIController.default.clientActionProxies.moveElement$Action,
FocusOnSpan: controller.clientActionProxies.focusOnSpan$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsPhone = Init.IsPhone
model.variables.isPhoneVar = initJSResult.value.isPhoneOut;
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

get _focusOnSpan$Action() {if(!(this.hasOwnProperty("__focusOnSpan$Action"))) {
this.__focusOnSpan$Action = function (eventIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("FocusOnSpan", function (span) {
if(span) {
span.setAttribute("code.function", "FocusOnSpan");
span.setAttribute("outsystems.function.key", "a23dd7c2-b5a9-41cb-a101-3875b23bc286");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("FocusOnSpan");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.FocusOnSpan$vars"))());
vars.value.eventInLocal = eventIn;
OS.Logger.startActiveSpan("FocusOnSpan", function (span) {
if(span) {
span.setAttribute("code.function", "FocusOnSpan");
span.setAttribute("outsystems.function.key", "e6d277a0-993d-4012-9626-4c609ca996e3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Adaptive_MasterDetail_mvc_controller_FocusOnSpan_FocusOnSpanJS, "FocusOnSpan", "FocusOnSpan", {
event: OS.DataConversion.JSNodeParamConverter.to(vars.value.eventInLocal, OS.DataTypes.DataTypes.Object)
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

return this.__focusOnSpan$Action;
}set _focusOnSpan$Action(value) {this.__focusOnSpan$Action = value;
}


onDetailOpen$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDetailOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDetailOpen");
span.setAttribute("outsystems.function.key", "0604b7db-ef2d-4028-9f0b-3f273ae6ab54");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDetailOpen$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

focusTrap$Action(eventIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("FocusTrap__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "06e3e2ae-96c0-41a4-8fd7-844934e53d64");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._focusTrap$Action, callContext, eventIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getActiveElement$Action(objectIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetActiveElement__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetActiveElement");
span.setAttribute("outsystems.function.key", "2666f0e6-d65c-4da6-86b1-c6763b43b96a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getActiveElement$Action, callContext, objectIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setAttributes$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetAttributes__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetAttributes");
span.setAttribute("outsystems.function.key", "27ce612c-621f-4b5c-8245-ddcb93d3b1b8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setAttributes$Action, callContext);
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
span.setAttribute("outsystems.function.key", "37546d33-937e-4fbf-9b03-944b19d99444");
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

onDetailClose$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDetailClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDetailClose");
span.setAttribute("outsystems.function.key", "63a229b4-32da-440e-816b-d8fccd2b83f3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onDetailClose$Action, callContext);
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
span.setAttribute("outsystems.function.key", "6dbb74e8-b68a-422a-9f19-645dd268e3f1");
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

focusOnSpan$Action(eventIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("FocusOnSpan__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FocusOnSpan");
span.setAttribute("outsystems.function.key", "a23dd7c2-b5a9-41cb-a101-3875b23bc286");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._focusOnSpan$Action, callContext, eventIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get detailClose$Action() {if(!(this.hasOwnProperty("_detailClose$Action"))) {
this._detailClose$Action = function () {
return Promise.resolve();
};
}

return this._detailClose$Action;
}set detailClose$Action(value) {this._detailClose$Action = value;
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
this._onDestroyEventHandler = null;
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
Controller.registerVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.FocusTrap$vars", [{
name: "Event",
attrName: "eventInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.GetActiveElement$vars", [{
name: "Object",
attrName: "objectInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.OnReady$initJSResult", [{
name: "IsPhone",
attrName: "isPhoneOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Adaptive.MasterDetail.FocusOnSpan$vars", [{
name: "event",
attrName: "eventInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




