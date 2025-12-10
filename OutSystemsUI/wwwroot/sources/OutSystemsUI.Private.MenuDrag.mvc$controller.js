import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_MenuDrag_mvc_TranslationsResources from "./OutSystemsUI.Private.MenuDrag.mvc$translationsResources.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_UpdateUI_MoveMenuJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.UpdateUI.MoveMenuJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureStart_CheckMenuOpenJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureStart.CheckMenuOpenJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_PreventDefaultWDirectionJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureMove.PreventDefaultWDirectionJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_UpdateUIJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureMove.UpdateUIJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_SetOpacityJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureMove.SetOpacityJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_RemoveClasses2JS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureEnd.RemoveClasses2JS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_GoBackJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureEnd.GoBackJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_RemoveTransitionJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureEnd.RemoveTransitionJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_SendMenuToStartJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureEnd.SendMenuToStartJS.js";
import OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_OpenEnitreMenuJS from "./OutSystemsUI.Private.MenuDrag.mvc$controller.GestureEnd.OpenEnitreMenuJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_MenuDrag_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
updateUI$Action: function () {
return controller.executeActionInsideJSNode(controller._updateUI$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateUI");
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
get _updateUI$Action() {if(!(this.hasOwnProperty("__updateUI$Action"))) {
this.__updateUI$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "1ba81c37-e16f-4a2f-a8af-db4c95bd986c");
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
span.setAttribute("outsystems.function.key", "2b611f92-55f2-43b4-b949-fcbf86c08a31");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_UpdateUI_MoveMenuJS, "MoveMenu", "UpdateUI", {
MoveX: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar), OS.DataTypes.DataTypes.Decimal),
MenuWidth: OS.DataConversion.JSNodeParamConverter.to(model.variables.menuWidthVar, OS.DataTypes.DataTypes.Integer)
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
span.setAttribute("outsystems.function.key", "2edab965-ca41-4ce5-98d6-11b5a53fbaa5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureStart$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
var checkMenuOpenJSResult = new OS.DataTypes.VariableHolder();
// Menu is moving
// IsMoving = True
model.variables.isMovingVar = true;
checkMenuOpenJSResult.value = OS.Logger.startActiveSpan("CheckMenuOpen", function (span) {
if(span) {
span.setAttribute("code.function", "CheckMenuOpen");
span.setAttribute("outsystems.function.key", "3916f9f2-ebcb-49a5-bb56-0dc1bf36d525");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureStart_CheckMenuOpenJS, "CheckMenuOpen", "GestureStart", {
BackExists: OS.DataConversion.JSNodeParamConverter.to(model.variables.backExistsVar, OS.DataTypes.DataTypes.Boolean),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
MenuWidth: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
isBurgerIconVisible: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
isBackIconVisible: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
IsMenuHidden: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
isRTL: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureStart$checkMenuOpenJSResult"))();
jsNodeResult.isOpenOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsOpen, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.menuWidthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MenuWidth, OS.DataTypes.DataTypes.Integer);
jsNodeResult.isBurgerIconVisibleOut = OS.DataConversion.JSNodeParamConverter.from($parameters.isBurgerIconVisible, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.isBackIconVisibleOut = OS.DataConversion.JSNodeParamConverter.from($parameters.isBackIconVisible, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.isMenuHiddenOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsMenuHidden, OS.DataTypes.DataTypes.Boolean);
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
// BackExists = CheckMenuOpen.isBackIconVisible
model.variables.backExistsVar = checkMenuOpenJSResult.value.isBackIconVisibleOut;
// BurgerMenuExists = CheckMenuOpen.isBurgerIconVisible
model.variables.burgerMenuExistsVar = checkMenuOpenJSResult.value.isBurgerIconVisibleOut;
// IsMenuHidden = CheckMenuOpen.IsMenuHidden
model.variables.isMenuHiddenVar = checkMenuOpenJSResult.value.isMenuHiddenOut;
// IsOpen = CheckMenuOpen.IsOpen
model.variables.isOpenVar = checkMenuOpenJSResult.value.isOpenOut;
// MenuWidth = CheckMenuOpen.MenuWidth
model.variables.menuWidthVar = checkMenuOpenJSResult.value.menuWidthOut;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// IsRTL = CheckMenuOpen.isRTL
model.variables.isRTLVar = checkMenuOpenJSResult.value.isRTLOut;
// MoveX = If
model.variables.moveXVar = ((model.variables.burgerMenuExistsVar) ? (((model.variables.isOpenVar) ? (0) : (((model.variables.isRTLVar) ? (model.variables.menuWidthVar) : ((-model.variables.menuWidthVar)))))) : (((-model.variables.menuWidthVar) * 2)));
// DragDirection = ""
model.variables.dragDirectionVar = "";
// PreventDefault = True
model.variables.preventDefaultVar = true;
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

get _gestureMove$Action() {if(!(this.hasOwnProperty("__gestureMove$Action"))) {
this.__gestureMove$Action = function (xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "a6eae758-cf0d-4ab9-8108-4130d328e4cb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureMove$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.evtInLocal = evtIn;
// No direction set?
if(((model.variables.dragDirectionVar === ""))) {
// Set drag direction
// DragDirection = If
model.variables.dragDirectionVar = ((OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal)).gte(OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(vars.value.offsetYInLocal)))) ? ("horizontal") : ("vertical"));
OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "83afda8f-f5e7-4097-b49c-2f0f2245701c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_UpdateUIJS, "UpdateUI", "GestureMove", null, function ($parameters) {
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

if((!(model.variables.floatingActionsExistsVar))) {
// Menu Icons Conditions
if((!(((model.variables.backExistsVar || (!(model.variables.burgerMenuExistsVar))) || model.variables.isMenuHiddenVar)))) {
// Is vertical?
if(((model.variables.dragDirectionVar === "vertical"))) {
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
} else {
do {
OS.Logger.startActiveSpan("PreventDefaultWDirection", function (span) {
if(span) {
span.setAttribute("code.function", "PreventDefaultWDirection");
span.setAttribute("outsystems.function.key", "6b30f03e-692c-4d3e-8c25-940d87d1cb8a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_PreventDefaultWDirectionJS, "PreventDefaultWDirection", "GestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.isRTLVar)) {
if((!((((model.variables.moveXVar + (vars.value.xInLocal - model.variables.lastXVar)) < model.variables.menuWidthVar) && ((model.variables.moveXVar + (vars.value.xInLocal - model.variables.lastXVar)) >= 0))))) {
break;
}

} else {
if((!((((model.variables.moveXVar + (vars.value.xInLocal - model.variables.lastXVar)) > (-model.variables.menuWidthVar)) && ((model.variables.moveXVar + (vars.value.xInLocal - model.variables.lastXVar)) <= 0))))) {
break;
}

}

// Update menu X axis offset
// MoveX = MoveX + X - LastX
model.variables.moveXVar = (model.variables.moveXVar + (vars.value.xInLocal - model.variables.lastXVar));
} while(false)
;
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
OS.Logger.startActiveSpan("SetOpacity", function (span) {
if(span) {
span.setAttribute("code.function", "SetOpacity");
span.setAttribute("outsystems.function.key", "9107af14-b920-4ff0-a3a9-731a9e3c5187");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureMove_SetOpacityJS, "SetOpacity", "GestureMove", {
MenuWidth: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.integerToDecimal(model.variables.menuWidthVar), OS.DataTypes.DataTypes.Decimal),
MoveX: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar), OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

}

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

get _gestureEnd$Action() {if(!(this.hasOwnProperty("__gestureEnd$Action"))) {
this.__gestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "c15a446e-4445-4338-b309-5752aa2fca41");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
// Set not moving
// IsMoving = False
model.variables.isMovingVar = false;
if((!(model.variables.isMenuHiddenVar))) {
// Just Clicked?
if((((vars.value.offsetXInLocal === 0) && (vars.value.offsetYInLocal === 0)))) {
if((!(model.variables.isOpenVar))) {
return ;

}

} else {
if((model.variables.backExistsVar)) {
if((model.variables.isRTLVar)) {
if((!((vars.value.offsetXInLocal < 0)))) {
return ;

}

} else {
if((!((vars.value.offsetXInLocal > 0)))) {
return ;

}

}

OS.Logger.startActiveSpan("GoBack", function (span) {
if(span) {
span.setAttribute("code.function", "GoBack");
span.setAttribute("outsystems.function.key", "4b482ff3-db51-4660-a898-088f5f8535e2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_GoBackJS, "GoBack", "GestureEnd", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return ;

} else {
var block2 = false;
do {
block2 = false;
do {
if((model.variables.isOpenVar)) {
// Closed one third?
if(((OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal).lt(OS.BuiltinFunctions.integerToDecimal(((-1) * model.variables.menuWidthVar)).div(OS.BuiltinFunctions.integerToDecimal(2))) || OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal)).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
break;
}

} else {
// Opened two thirds?
if((!((OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal).gt(OS.BuiltinFunctions.integerToDecimal((1 * model.variables.menuWidthVar)).div(OS.BuiltinFunctions.integerToDecimal(2))) || OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(vars.value.offsetXInLocal)).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar))))) {
break;
}

}

OS.Logger.startActiveSpan("OpenEnitreMenu", function (span) {
if(span) {
span.setAttribute("code.function", "OpenEnitreMenu");
span.setAttribute("outsystems.function.key", "eaf67b09-5acb-4c6b-9fa8-b473a4b8d39c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_OpenEnitreMenuJS, "OpenEnitreMenu", "GestureEnd", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsOpen = True
model.variables.isOpenVar = true;
// jump to block2
block2 = true;
break;
} while(false)
;
if(block2) {
break;
}

OS.Logger.startActiveSpan("SendMenuToStart", function (span) {
if(span) {
span.setAttribute("code.function", "SendMenuToStart");
span.setAttribute("outsystems.function.key", "a72e6e80-c501-40bc-8b89-4276193878b3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_SendMenuToStartJS, "SendMenuToStart", "GestureEnd", {
IsRTL: OS.DataConversion.JSNodeParamConverter.to(model.variables.isRTLVar, OS.DataTypes.DataTypes.Boolean),
OffsetX: OS.DataConversion.JSNodeParamConverter.to(vars.value.offsetXInLocal, OS.DataTypes.DataTypes.Integer),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenVar, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Are you dragging on the opposite direction with the menu open
if(((((vars.value.offsetXInLocal < 0) && (!(model.variables.isRTLVar))) || ((vars.value.offsetXInLocal > 0) && model.variables.isRTLVar)))) {
// IsOpen = False
model.variables.isOpenVar = false;
}

} while(false)
;
OS.Logger.startActiveSpan("RemoveTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveTransition");
span.setAttribute("outsystems.function.key", "a138cdb7-0416-4403-bb05-d6ab893bf0e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_RemoveTransitionJS, "RemoveTransition", "GestureEnd", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return ;

}

}

}

OS.Logger.startActiveSpan("RemoveClasses2", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveClasses2");
span.setAttribute("outsystems.function.key", "42d4b26c-de52-4c76-b02e-170190b9b2c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_MenuDrag_mvc_controller_GestureEnd_RemoveClasses2JS, "RemoveClasses2", "GestureEnd", null, function ($parameters) {
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

return this.__gestureEnd$Action;
}set _gestureEnd$Action(value) {this.__gestureEnd$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c17bf31e-03cf-426a-9387-3c55b572d02e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Set initial conditions
// IsOpen = False
model.variables.isOpenVar = false;
// MenuWidth = 0
model.variables.menuWidthVar = 0;
// LastX = 0
model.variables.lastXVar = 0;
// LastY = 0
model.variables.lastYVar = 0;
// MoveX = 0
model.variables.moveXVar = 0;
// DragDirection = ""
model.variables.dragDirectionVar = "";
// PreventDefault = False
model.variables.preventDefaultVar = false;
// FloatingActionsExists = False
model.variables.floatingActionsExistsVar = false;
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


updateUI$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateUI__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "1ba81c37-e16f-4a2f-a8af-db4c95bd986c");
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
span.setAttribute("outsystems.function.key", "2edab965-ca41-4ce5-98d6-11b5a53fbaa5");
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

gestureMove$Action(xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "a6eae758-cf0d-4ab9-8108-4130d328e4cb");
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

gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "c15a446e-4445-4338-b309-5752aa2fca41");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureEnd$Action, callContext, offsetXIn, offsetYIn, timeTakenIn);
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
span.setAttribute("outsystems.function.key", "c17bf31e-03cf-426a-9387-3c55b572d02e");
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
this._onReadyEventHandler = null;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureStart$vars", [{
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
Controller.registerVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureStart$checkMenuOpenJSResult", [{
name: "IsOpen",
attrName: "isOpenOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "MenuWidth",
attrName: "menuWidthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "isBurgerIconVisible",
attrName: "isBurgerIconVisibleOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "isBackIconVisible",
attrName: "isBackIconVisibleOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsMenuHidden",
attrName: "isMenuHiddenOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureMove$vars", [{
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
name: "Evt",
attrName: "evtInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.MenuDrag.GestureEnd$vars", [{
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
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




