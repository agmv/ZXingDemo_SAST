import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnDestroy_OnDestroyJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnDestroy.OnDestroyJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnParametersChanged_CheckOpenJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnParametersChanged.CheckOpenJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureMove_PreventDefautJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureMove.PreventDefautJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureMove_UpdateUIJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureMove.UpdateUIJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_UpdateUI_MoveMenuJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.UpdateUI.MoveMenuJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureStart_CheckSideBarOpenJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureStart.CheckSideBarOpenJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureStart_AddNoTransitionJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureStart.AddNoTransitionJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_OpenEnitreSideBarJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureEnd.OpenEnitreSideBarJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_RemoveNoTransitionJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureEnd.RemoveNoTransitionJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_SendSideBarToStartJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.GestureEnd.SendSideBarToStartJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_CheckIsSidebarListJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnReady.CheckIsSidebarListJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_InitWebJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnReady.InitWebJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_InitMobileJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnReady.InitMobileJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_CheckRenderBarJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.OnReady.CheckRenderBarJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_Accessibility_AddKeypressEventJS from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.Accessibility.AddKeypressEventJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
updateUI$Action: function () {
return controller.executeActionInsideJSNode(controller._updateUI$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateUI");
},
onParametersChanged$Action: function () {
return controller.executeActionInsideJSNode(controller._onParametersChanged$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnParametersChanged");
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
get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "100f38de-dbb9-4002-8526-ec90d03f515a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
if((model.variables.isSidebarListVar)) {
OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "751846e4-e62b-426f-8233-adb4083c2bb3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnDestroy_OnDestroyJS, "OnDestroy", "OnDestroy", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "128bee6c-aa55-45c7-9db6-a407f803510c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Set initial conditions
// IsOpen = IsOpen
model.variables.isOpenIn = model.variables.isOpenIn;
// SidebarWidth = 0
model.variables.sidebarWidthVar = 0;
// LastX = 0
model.variables.lastXVar = OS.BuiltinFunctions.integerToDecimal(0);
// LastY = 0
model.variables.lastYVar = OS.BuiltinFunctions.integerToDecimal(0);
// MoveX = 0
model.variables.moveXVar = OS.BuiltinFunctions.integerToDecimal(0);
// DragDirection = ""
model.variables.dragDirectionVar = "";
// PreventDefault = False
model.variables.preventDefaultVar = false;
// RenderBar = RenderBar
model.variables.renderBarVar = model.variables.renderBarVar;
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "14f51915-5a3a-472f-a9f4-79d4d6b6893c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var checkOpenJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
checkOpenJSResult.value = OS.Logger.startActiveSpan("CheckOpen", function (span) {
if(span) {
span.setAttribute("code.function", "CheckOpen");
span.setAttribute("outsystems.function.key", "023a5d43-bceb-4cee-b1e9-85df4a800d49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnParametersChanged_CheckOpenJS, "CheckOpen", "OnParametersChanged", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text),
IsOpenIf: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnParametersChanged$checkOpenJSResult"))();
jsNodeResult.isOpenIfOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsOpenIf, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsOpen = CheckOpen.IsOpenIf
model.variables.isOpenIn = checkOpenJSResult.value.isOpenIfOut;
// Trigger Event: OnToggle
return controller.onToggle$Action(callContext).then(function () {
// Execute Action: Accessibility
controller._accessibility$Action(callContext);
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _gestureMove$Action() {if(!(this.hasOwnProperty("__gestureMove$Action"))) {
this.__gestureMove$Action = function (xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "26fe007e-d032-4581-8da9-1dde18e9694b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureMove$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.evtInLocal = evtIn;
// No direction set?
if(((model.variables.dragDirectionVar === ""))) {
// Set drag direction
// DragDirection = If
model.variables.dragDirectionVar = ((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gte(OS.BuiltinFunctions.abs(vars.value.offsetYInLocal))) ? ("horizontal") : ("vertical"));
OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "8b2ef727-a52e-40fa-b796-6f247bda430e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureMove_UpdateUIJS, "UpdateUI", "GestureMove", null, function ($parameters) {
}, {
UpdateUI: controller.clientActionProxies.updateUI$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Is scrolling?
if(((model.variables.dragDirectionVar === "vertical"))) {
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
} else {
do {
OS.Logger.startActiveSpan("PreventDefaut", function (span) {
if(span) {
span.setAttribute("code.function", "PreventDefaut");
span.setAttribute("outsystems.function.key", "60b35e69-7b9e-4ceb-bda2-4280a7c2a56e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureMove_PreventDefautJS, "PreventDefaut", "GestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsRTL?
if((model.variables.isRTLVar)) {
// Dragging inside bounds?
if((!((model.variables.moveXVar.plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal((-model.variables.sidebarWidthVar))) && model.variables.moveXVar.plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(0)))))) {
break;
}

} else {
// Dragging inside bounds?
if((!((model.variables.moveXVar.plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(model.variables.sidebarWidthVar)) && model.variables.moveXVar.plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal(0)))))) {
break;
}

}

// Update menu X axis offset
// MoveX = MoveX + X - LastX
model.variables.moveXVar = model.variables.moveXVar.plus(vars.value.xInLocal.minus(model.variables.lastXVar));
} while(false)
;
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__gestureMove$Action;
}set _gestureMove$Action(value) {this.__gestureMove$Action = value;
}

get _updateUI$Action() {if(!(this.hasOwnProperty("__updateUI$Action"))) {
this.__updateUI$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "56ace189-3836-42ee-b39a-8f0e7bb32a35");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateUI");
callContext = controller.callContext(callContext);
if((model.variables.isMovingVar)) {
OS.Logger.startActiveSpan("MoveMenu", function (span) {
if(span) {
span.setAttribute("code.function", "MoveMenu");
span.setAttribute("outsystems.function.key", "52982dd5-5927-4b37-a4b0-0a973d047735");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_UpdateUI_MoveMenuJS, "MoveMenu", "UpdateUI", {
OffsetX: OS.DataConversion.JSNodeParamConverter.to(model.variables.moveXVar, OS.DataTypes.DataTypes.Decimal),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
UpdateUI: controller.clientActionProxies.updateUI$Action
}, {});
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

return this.__updateUI$Action;
}set _updateUI$Action(value) {this.__updateUI$Action = value;
}

get _gestureStart$Action() {if(!(this.hasOwnProperty("__gestureStart$Action"))) {
this.__gestureStart$Action = function (xIn, yIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureStart", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "5b5ee4c9-69bd-42c1-97e4-f7bbd4cd66e6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureStart$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
var checkSideBarOpenJSResult = new OS.DataTypes.VariableHolder();
// SideBar is moving
// IsMoving = True
model.variables.isMovingVar = true;
checkSideBarOpenJSResult.value = OS.Logger.startActiveSpan("CheckSideBarOpen", function (span) {
if(span) {
span.setAttribute("code.function", "CheckSideBarOpen");
span.setAttribute("outsystems.function.key", "5fb52bf5-7c1b-48ab-930c-714ce8657c15");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureStart_CheckSideBarOpenJS, "CheckSideBarOpen", "GestureStart", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
SidebarWidth: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
isRTL: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureStart$checkSideBarOpenJSResult"))();
jsNodeResult.isOpenOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsOpen, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.sidebarWidthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SidebarWidth, OS.DataTypes.DataTypes.Integer);
jsNodeResult.isRTLOut = OS.DataConversion.JSNodeParamConverter.from($parameters.isRTL, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set initial conditions
// IsOpen = CheckSideBarOpen.IsOpen
model.variables.isOpenIn = checkSideBarOpenJSResult.value.isOpenOut;
// SidebarWidth = CheckSideBarOpen.SidebarWidth
model.variables.sidebarWidthVar = checkSideBarOpenJSResult.value.sidebarWidthOut;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// IsRTL = CheckSideBarOpen.isRTL
model.variables.isRTLVar = checkSideBarOpenJSResult.value.isRTLOut;
// MoveX = If
model.variables.moveXVar = OS.BuiltinFunctions.integerToDecimal(((model.variables.isOpenIn) ? (0) : (((model.variables.isRTLVar) ? ((-model.variables.sidebarWidthVar)) : (model.variables.sidebarWidthVar)))));
// DragDirection = ""
model.variables.dragDirectionVar = "";
// PreventDefault = True
model.variables.preventDefaultVar = true;
OS.Logger.startActiveSpan("AddNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "AddNoTransition");
span.setAttribute("outsystems.function.key", "cea44fe4-e3e2-4276-9f21-487e041f1186");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureStart_AddNoTransitionJS, "AddNoTransition", "GestureStart", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
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

return this.__gestureStart$Action;
}set _gestureStart$Action(value) {this.__gestureStart$Action = value;
}

get _gestureEnd$Action() {if(!(this.hasOwnProperty("__gestureEnd$Action"))) {
this.__gestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "db8a970a-ea84-470c-82de-1782b49a2ef8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
return OS.Flow.executeAsyncFlow(function () {
// Set not moving
// IsMoving = False
model.variables.isMovingVar = false;
OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "30c17ebe-7861-4b20-9431-caef86d9fee9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_RemoveNoTransitionJS, "RemoveNoTransition", "GestureEnd", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Just Clicked?
return OS.Flow.executeSequence(function () {
if((!((vars.value.offsetXInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)) && vars.value.offsetYInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)))))) {
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
if((model.variables.isRTLVar)) {
// IntervalExpressionForClose = MoveX < -SidebarWidth / 2
vars.value.intervalExpressionForCloseVar = model.variables.moveXVar.lt(OS.BuiltinFunctions.integerToDecimal((-model.variables.sidebarWidthVar)).div(OS.BuiltinFunctions.integerToDecimal(2)));
// IntervalExpressionForOpen = MoveX > -SidebarWidth / 2
vars.value.intervalExpressionForOpenVar = model.variables.moveXVar.gt(OS.BuiltinFunctions.integerToDecimal((-model.variables.sidebarWidthVar)).div(OS.BuiltinFunctions.integerToDecimal(2)));
// OffsetExpression = OffsetX < 0
vars.value.offsetExpressionVar = vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0));
} else {
// IntervalExpressionForClose = MoveX > -SidebarWidth / 2
vars.value.intervalExpressionForCloseVar = model.variables.moveXVar.gt(OS.BuiltinFunctions.integerToDecimal((-model.variables.sidebarWidthVar)).div(OS.BuiltinFunctions.integerToDecimal(2)));
// IntervalExpressionForOpen = MoveX < SidebarWidth / 2
vars.value.intervalExpressionForOpenVar = model.variables.moveXVar.lt(OS.BuiltinFunctions.integerToDecimal(model.variables.sidebarWidthVar).div(OS.BuiltinFunctions.integerToDecimal(2)));
// OffsetExpression = OffsetX > 0
vars.value.offsetExpressionVar = vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0));
}

if((model.variables.isOpenIn)) {
// Closed one third? 
if((((vars.value.intervalExpressionForCloseVar && OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)) && vars.value.offsetExpressionVar))) {
return OS.Flow.breakAsync();
}

} else {
// Opened two thirds?
if((!((vars.value.intervalExpressionForOpenVar || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar))))) {
return OS.Flow.breakAsync();
}

}

OS.Logger.startActiveSpan("OpenEnitreSideBar", function (span) {
if(span) {
span.setAttribute("code.function", "OpenEnitreSideBar");
span.setAttribute("outsystems.function.key", "12faa36f-4624-4456-a109-07757ac60f6c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_OpenEnitreSideBarJS, "OpenEnitreSideBar", "GestureEnd", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Open Sidebar
// IsOpen = True
model.variables.isOpenIn = true;
// Trigger Event: OnToggle
return controller.onToggle$Action(callContext).then(function () {
return OS.Flow.returnAsync();

});
}).then(function () {
OS.Logger.startActiveSpan("SendSideBarToStart", function (span) {
if(span) {
span.setAttribute("code.function", "SendSideBarToStart");
span.setAttribute("outsystems.function.key", "930f9900-cb79-4f9a-8aa0-5ccebce61a6b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_GestureEnd_SendSideBarToStartJS, "SendSideBarToStart", "GestureEnd", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Close Sidebar
// IsOpen = False
model.variables.isOpenIn = false;
// Trigger Event: OnToggle2
return controller.onToggle$Action(callContext);
});
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__gestureEnd$Action;
}set _gestureEnd$Action(value) {this.__gestureEnd$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "e6ab98fc-70d9-4a5d-bf31-cbfcc4b0262b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var isSidebarDraggableVar = new OS.DataTypes.VariableHolder();
var checkIsSidebarListJSResult = new OS.DataTypes.VariableHolder();
var checkRenderBarJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
checkIsSidebarListJSResult.value = OS.Logger.startActiveSpan("CheckIsSidebarList", function (span) {
if(span) {
span.setAttribute("code.function", "CheckIsSidebarList");
span.setAttribute("outsystems.function.key", "0dbfdd80-b33e-4719-bc64-c49ea73b155f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_CheckIsSidebarListJS, "CheckIsSidebarList", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text),
IsList: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnReady$checkIsSidebarListJSResult"))();
jsNodeResult.isListOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsList, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsSidebarList = CheckIsSidebarList.IsList
model.variables.isSidebarListVar = checkIsSidebarListJSResult.value.isListOut;
// IsWebApp?
if(((OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut === true))) {
OS.Logger.startActiveSpan("InitWeb", function (span) {
if(span) {
span.setAttribute("code.function", "InitWeb");
span.setAttribute("outsystems.function.key", "1d98710f-6bb4-4670-a8af-8bd6996b9335");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_InitWebJS, "InitWeb", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
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
span.setAttribute("outsystems.function.key", "32545021-8f1b-485a-9428-0711744ada49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_InitMobileJS, "InitMobile", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
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

checkRenderBarJSResult.value = OS.Logger.startActiveSpan("CheckRenderBar", function (span) {
if(span) {
span.setAttribute("code.function", "CheckRenderBar");
span.setAttribute("outsystems.function.key", "c9bfa605-2aff-45e6-bf50-90d4d6ec3546");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_OnReady_CheckRenderBarJS, "CheckRenderBar", "OnReady", {
RenderMenu: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnReady$checkRenderBarJSResult"))();
jsNodeResult.renderMenuOut = OS.DataConversion.JSNodeParamConverter.from($parameters.RenderMenu, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// RenderBar = CheckRenderBar.RenderMenu
model.variables.renderBarVar = checkRenderBarJSResult.value.renderMenuOut;
// Execute Action: IsSidebarDraggable
model.flush();
return OutSystemsUIController.default.isMenuDraggable$Action(callContext).then(function (value) {
isSidebarDraggableVar.value = value;
}).then(function () {
// NeedsDrag = IsSidebarDraggable.AddDrag
model.variables.needsDragVar = isSidebarDraggableVar.value.addDragOut;
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _accessibility$Action() {if(!(this.hasOwnProperty("__accessibility$Action"))) {
this.__accessibility$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Accessibility", function (span) {
if(span) {
span.setAttribute("code.function", "Accessibility");
span.setAttribute("outsystems.function.key", "ebce1f38-28ee-4e84-887a-c6e9192bb72f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Accessibility");
callContext = controller.callContext(callContext);
var setFocusVar = new OS.DataTypes.VariableHolder();
OS.Logger.startActiveSpan("AddKeypressEvent", function (span) {
if(span) {
span.setAttribute("code.function", "AddKeypressEvent");
span.setAttribute("outsystems.function.key", "ccff382a-4afb-494b-8616-063fc9374e37");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Sidebar_mvc_controller_Accessibility_AddKeypressEventJS, "AddKeypressEvent", "Accessibility", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Sidebar"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnParametersChanged: controller.clientActionProxies.onParametersChanged$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.isOpenIn)) {
// Execute Action: SetFocus
setFocusVar.value = OutSystemsUIController.default.setFocus$Action(idService.getId("Sidebar"), callContext);

}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__accessibility$Action;
}set _accessibility$Action(value) {this.__accessibility$Action = value;
}


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "100f38de-dbb9-4002-8526-ec90d03f515a");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "128bee6c-aa55-45c7-9db6-a407f803510c");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "14f51915-5a3a-472f-a9f4-79d4d6b6893c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

gestureMove$Action(xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "26fe007e-d032-4581-8da9-1dde18e9694b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureMove$Action, callContext, xIn, yIn, offsetXIn, offsetYIn, evtIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

updateUI$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateUI__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "56ace189-3836-42ee-b39a-8f0e7bb32a35");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateUI$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureStart$Action(xIn, yIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "5b5ee4c9-69bd-42c1-97e4-f7bbd4cd66e6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureStart$Action, callContext, xIn, yIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "db8a970a-ea84-470c-82de-1782b49a2ef8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._gestureEnd$Action, callContext, offsetXIn, offsetYIn, timeTakenIn);
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
span.setAttribute("outsystems.function.key", "e6ab98fc-70d9-4a5d-bf31-cbfcc4b0262b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

accessibility$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Accessibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Accessibility");
span.setAttribute("outsystems.function.key", "ebce1f38-28ee-4e84-887a-c6e9192bb72f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._accessibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onToggle$Action() {if(!(this.hasOwnProperty("_onToggle$Action"))) {
this._onToggle$Action = function () {
return Promise.resolve();
};
}

return this._onToggle$Action;
}set onToggle$Action(value) {this._onToggle$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnParametersChanged$checkOpenJSResult", [{
name: "IsOpenIf",
attrName: "isOpenIfOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureMove$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Evt",
attrName: "evtInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureStart$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureStart$checkSideBarOpenJSResult", [{
name: "IsOpen",
attrName: "isOpenOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "SidebarWidth",
attrName: "sidebarWidthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "isRTL",
attrName: "isRTLOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.GestureEnd$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "TimeTaken",
attrName: "timeTakenInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "IntervalExpressionForClose",
attrName: "intervalExpressionForCloseVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "OffsetExpression",
attrName: "offsetExpressionVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IntervalExpressionForOpen",
attrName: "intervalExpressionForOpenVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnReady$checkIsSidebarListJSResult", [{
name: "IsList",
attrName: "isListOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Sidebar.OnReady$checkRenderBarJSResult", [{
name: "RenderMenu",
attrName: "renderMenuOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




