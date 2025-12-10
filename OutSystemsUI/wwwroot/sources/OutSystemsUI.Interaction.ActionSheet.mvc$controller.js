import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_TranslationsResources from "./OutSystemsUI.Interaction.ActionSheet.mvc$translationsResources.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_FocusTrap_FocusTrapJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.FocusTrap.FocusTrapJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_GetDOMElemJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnReady.GetDOMElemJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_AddMenuItemRoleJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnReady.AddMenuItemRoleJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_InitWebJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnReady.InitWebJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_InitMobileJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnReady.InitMobileJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_SetTabindex_SetTabindexJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.SetTabindex.SetTabindexJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_ToggleActionSheet_ToggleActionSheetJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.ToggleActionSheet.ToggleActionSheetJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnDestroy_RemoveDOMActionSheetJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnDestroy.RemoveDOMActionSheetJS.js";
import OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnCancelClick_FocusActiveDOMElemJS from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.OnCancelClick.FocusActiveDOMElemJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_ActionSheet_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onCancelClick$Action: function () {
return controller.executeActionInsideJSNode(controller._onCancelClick$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnCancelClick");
},
focusTrap$Action: function (eventIn) {
eventIn = (eventIn === undefined) ? null : eventIn;
return controller.executeActionInsideJSNode(controller._focusTrap$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(eventIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "FocusTrap");
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
get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0eb9ae92-0c32-42b3-8449-c3b402e7e9d3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// Execute Action: ToggleActionSheet
controller._toggleActionSheet$Action(callContext);
// Execute Action: SetTabindex
controller._setTabindex$Action(callContext);
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

get _focusTrap$Action() {if(!(this.hasOwnProperty("__focusTrap$Action"))) {
this.__focusTrap$Action = function (eventIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("FocusTrap", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "656282b1-4996-4ec4-a8ce-17f6bcd76799");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("FocusTrap");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.ActionSheet.FocusTrap$vars"))());
vars.value.eventInLocal = eventIn;
OS.Logger.startActiveSpan("FocusTrap", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "56109595-68b2-4e5a-af0b-7cb6371b0dcb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_FocusTrap_FocusTrapJS, "FocusTrap", "FocusTrap", {
CancelButtonId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetCancel"), OS.DataTypes.DataTypes.Text),
Buttons: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetButtons"), OS.DataTypes.DataTypes.Text),
Event: OS.DataConversion.JSNodeParamConverter.to(vars.value.eventInLocal, OS.DataTypes.DataTypes.Object),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnCancelClick: controller.clientActionProxies.onCancelClick$Action
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "71551b61-7ee8-44a1-9b9c-b64fae68bb22");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var getDOMElemJSResult = new OS.DataTypes.VariableHolder();
getDOMElemJSResult.value = OS.Logger.startActiveSpan("GetDOMElem", function (span) {
if(span) {
span.setAttribute("code.function", "GetDOMElem");
span.setAttribute("outsystems.function.key", "066ab5fd-fd61-4641-894f-46ce7404a56a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_GetDOMElemJS, "GetDOMElem", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text),
DOMElem: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.ActionSheet.OnReady$getDOMElemJSResult"))();
jsNodeResult.dOMElemOut = OS.DataConversion.JSNodeParamConverter.from($parameters.DOMElem, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set DOMElem
// DOMElem = GetDOMElem.DOMElem
model.variables.dOMElemVar = getDOMElemJSResult.value.dOMElemOut;
OS.Logger.startActiveSpan("AddMenuItemRole", function (span) {
if(span) {
span.setAttribute("code.function", "AddMenuItemRole");
span.setAttribute("outsystems.function.key", "18a36f6a-3fb5-43ec-aaa2-b149e3aa5469");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_AddMenuItemRoleJS, "AddMenuItemRole", "OnReady", {
Buttons: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetButtons"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if(((OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut === true))) {
OS.Logger.startActiveSpan("InitWeb", function (span) {
if(span) {
span.setAttribute("code.function", "InitWeb");
span.setAttribute("outsystems.function.key", "573c1904-4e75-4d61-af60-aae7dc9ba7a6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_InitWebJS, "InitWeb", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
MoveElement: OutSystemsUIController.default.clientActionProxies.moveElement$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
OS.Logger.startActiveSpan("InitMobile", function (span) {
if(span) {
span.setAttribute("code.function", "InitMobile");
span.setAttribute("outsystems.function.key", "c4541b70-767e-4a42-bfe4-c07ab26d7760");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnReady_InitMobileJS, "InitMobile", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
MoveElement: OutSystemsUIController.default.clientActionProxies.moveElement$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Execute Action: SetTabindex
controller._setTabindex$Action(callContext);
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

get _setTabindex$Action() {if(!(this.hasOwnProperty("__setTabindex$Action"))) {
this.__setTabindex$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetTabindex", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabindex");
span.setAttribute("outsystems.function.key", "93ca22b9-b12f-4385-bf37-88243a2d2e5c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetTabindex");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("SetTabindex", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabindex");
span.setAttribute("outsystems.function.key", "de33d9eb-cfec-452d-8002-128e093f01f2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_SetTabindex_SetTabindexJS, "SetTabindex", "SetTabindex", {
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenIn, OS.DataTypes.DataTypes.Boolean),
Buttons: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetButtons"), OS.DataTypes.DataTypes.Text)
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

return this.__setTabindex$Action;
}set _setTabindex$Action(value) {this.__setTabindex$Action = value;
}

get _toggleActionSheet$Action() {if(!(this.hasOwnProperty("__toggleActionSheet$Action"))) {
this.__toggleActionSheet$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ToggleActionSheet", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleActionSheet");
span.setAttribute("outsystems.function.key", "963ccc95-f559-4454-af1a-f331ea1f990c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ToggleActionSheet");
callContext = controller.callContext(callContext);
var toggleActionSheetJSResult = new OS.DataTypes.VariableHolder();
toggleActionSheetJSResult.value = OS.Logger.startActiveSpan("ToggleActionSheet", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleActionSheet");
span.setAttribute("outsystems.function.key", "794b7cdc-11f7-4c4e-8fb3-51700f9d13eb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_ToggleActionSheet_ToggleActionSheetJS, "ToggleActionSheet", "ToggleActionSheet", {
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text),
ActiveDOMElem: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.ActionSheet.ToggleActionSheet$toggleActionSheetJSResult"))();
jsNodeResult.activeDOMElemOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ActiveDOMElem, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
FocusTrap: controller.clientActionProxies.focusTrap$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ActiveDOMElem = ToggleActionSheet.ActiveDOMElem
model.variables.activeDOMElemVar = toggleActionSheetJSResult.value.activeDOMElemOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__toggleActionSheet$Action;
}set _toggleActionSheet$Action(value) {this.__toggleActionSheet$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "b394f792-04a4-4e97-8b29-0f5f11cd94ad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveDOMActionSheet", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveDOMActionSheet");
span.setAttribute("outsystems.function.key", "cd706fa6-2b08-459c-bc33-9abe45d4a362");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnDestroy_RemoveDOMActionSheetJS, "RemoveDOMActionSheet", "OnDestroy", {
DOMElem: OS.DataConversion.JSNodeParamConverter.to(model.variables.dOMElemVar, OS.DataTypes.DataTypes.Object)
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

get _onCancelClick$Action() {if(!(this.hasOwnProperty("__onCancelClick$Action"))) {
this.__onCancelClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnCancelClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnCancelClick");
span.setAttribute("outsystems.function.key", "e59fdf98-8593-40bd-9b4a-127c80db234d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnCancelClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
OS.Logger.startActiveSpan("FocusActiveDOMElem", function (span) {
if(span) {
span.setAttribute("code.function", "FocusActiveDOMElem");
span.setAttribute("outsystems.function.key", "42a83fdf-b9cc-48b8-8c96-9727485c66c2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_ActionSheet_mvc_controller_OnCancelClick_FocusActiveDOMElemJS, "FocusActiveDOMElem", "OnCancelClick", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ActionSheetContainer"), OS.DataTypes.DataTypes.Text),
ActiveDOMElem: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeDOMElemVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Trigger Event: OnClose
return controller.onClose$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onCancelClick$Action;
}set _onCancelClick$Action(value) {this.__onCancelClick$Action = value;
}


onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0eb9ae92-0c32-42b3-8449-c3b402e7e9d3");
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

focusTrap$Action(eventIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("FocusTrap__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FocusTrap");
span.setAttribute("outsystems.function.key", "656282b1-4996-4ec4-a8ce-17f6bcd76799");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "71551b61-7ee8-44a1-9b9c-b64fae68bb22");
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

setTabindex$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetTabindex__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabindex");
span.setAttribute("outsystems.function.key", "93ca22b9-b12f-4385-bf37-88243a2d2e5c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setTabindex$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

toggleActionSheet$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ToggleActionSheet__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleActionSheet");
span.setAttribute("outsystems.function.key", "963ccc95-f559-4454-af1a-f331ea1f990c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._toggleActionSheet$Action, callContext);
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
span.setAttribute("outsystems.function.key", "b394f792-04a4-4e97-8b29-0f5f11cd94ad");
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

onCancelClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnCancelClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnCancelClick");
span.setAttribute("outsystems.function.key", "e59fdf98-8593-40bd-9b4a-127c80db234d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onCancelClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onClose$Action() {if(!(this.hasOwnProperty("_onClose$Action"))) {
this._onClose$Action = function () {
return Promise.resolve();
};
}

return this._onClose$Action;
}set onClose$Action(value) {this._onClose$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.ActionSheet.FocusTrap$vars", [{
name: "Event",
attrName: "eventInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.ActionSheet.OnReady$getDOMElemJSResult", [{
name: "DOMElem",
attrName: "dOMElemOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.ActionSheet.ToggleActionSheet$toggleActionSheetJSResult", [{
name: "ActiveDOMElem",
attrName: "activeDOMElemOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




