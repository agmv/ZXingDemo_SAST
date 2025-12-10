import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureEnd_JsAnimateLeaveScreenJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnGestureEnd.JsAnimateLeaveScreenJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureEnd_JsAnimateEnterScreenJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnGestureEnd.JsAnimateEnterScreenJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureMove_JsPreventDefaultWDirectionJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnGestureMove.JsPreventDefaultWDirectionJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureMove_JsUpdateUIJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnGestureMove.JsUpdateUIJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureStart_JsCleanAnimationClassesJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnGestureStart.JsCleanAnimationClassesJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsInitWebJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnReady.JsInitWebJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsInitMobileJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnReady.JsInitMobileJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsAddKeypressEventJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OnReady.JsAddKeypressEventJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OpenCloseNotification_JsOpenNotificationJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OpenCloseNotification.JsOpenNotificationJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OpenCloseNotification_JsCloseNotificationJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.OpenCloseNotification.JsCloseNotificationJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_UpdateUI_JsMoveNotificationJS from "./OutSystemsUI.Interaction.DEPRECATED_Notification.mvc$controller.UpdateUI.JsMoveNotificationJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
updateUI$Action: function () {
return controller.executeActionInsideJSNode(controller._updateUI$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateUI");
},
onNotificationClose$Action: function () {
return controller.executeActionInsideJSNode(controller._onNotificationClose$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnNotificationClose");
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
get _onGestureEnd$Action() {if(!(this.hasOwnProperty("__onGestureEnd$Action"))) {
this.__onGestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnGestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureEnd");
span.setAttribute("outsystems.function.key", "34c0481a-4d73-4272-bb47-4e7d2d3acf9b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnGestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
return OS.Flow.executeAsyncFlow(function () {
// Just Clicked?
return OS.Flow.executeSequence(function () {
if((!((vars.value.offsetXInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)) && vars.value.offsetYInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)))))) {
// Moved more than half?
return OS.Flow.executeSequence(function () {
if((((OS.BuiltinFunctions.abs(model.variables.moveYVar).gt(OS.BuiltinFunctions.integerToDecimal(model.variables.notificationHeightVar).div(OS.BuiltinFunctions.integerToDecimal(2))) || OS.BuiltinFunctions.abs(vars.value.offsetYInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)) && vars.value.offsetYInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0))))) {
// Execute Action: CloseNotification
return controller._onNotificationClose$Action(callContext);
} else {
// Script to animate the notification when entering the screen.
OS.Logger.startActiveSpan("JsAnimateEnterScreen", function (span) {
if(span) {
span.setAttribute("code.function", "JsAnimateEnterScreen");
span.setAttribute("outsystems.function.key", "62ce7ad0-0bc0-45f7-aabf-4ba9627a3d38");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureEnd_JsAnimateEnterScreenJS, "JsAnimateEnterScreen", "OnGestureEnd", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set Not Moving
// IsMoving = False
model.variables.isMovingVar = false;
return OS.Flow.returnAsync();

}

});
}

}).then(function () {
// Script to animate the notification when leaving the screen.
OS.Logger.startActiveSpan("JsAnimateLeaveScreen", function (span) {
if(span) {
span.setAttribute("code.function", "JsAnimateLeaveScreen");
span.setAttribute("outsystems.function.key", "41705feb-a049-44d3-b1bb-9565084954bf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureEnd_JsAnimateLeaveScreenJS, "JsAnimateLeaveScreen", "OnGestureEnd", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set Not Moving
// IsMoving = False
model.variables.isMovingVar = false;
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

return this.__onGestureEnd$Action;
}set _onGestureEnd$Action(value) {this.__onGestureEnd$Action = value;
}

get _onGestureMove$Action() {if(!(this.hasOwnProperty("__onGestureMove$Action"))) {
this.__onGestureMove$Action = function (offsetXIn, offsetYIn, evtIn, xIn, yIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnGestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureMove");
span.setAttribute("outsystems.function.key", "412fa1e4-377e-4e32-abc7-445d98ed4e25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnGestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureMove$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.evtInLocal = evtIn;
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
// No direction set?
if(((model.variables.dragDirectionVar === ""))) {
// Set drag direction
// DragDirection = If
model.variables.dragDirectionVar = ((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gte(OS.BuiltinFunctions.abs(vars.value.offsetYInLocal))) ? ("horizontal") : ("vertical"));
// Script to update the UI on the drag event.
OS.Logger.startActiveSpan("JsUpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "JsUpdateUI");
span.setAttribute("outsystems.function.key", "68320426-b33a-4b13-93f6-2e608ff61e6b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureMove_JsUpdateUIJS, "JsUpdateUI", "OnGestureMove", null, function ($parameters) {
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

// Is vertical?
if(((model.variables.dragDirectionVar === "vertical"))) {
// Script to prevent default on W direction.
OS.Logger.startActiveSpan("JsPreventDefaultWDirection", function (span) {
if(span) {
span.setAttribute("code.function", "JsPreventDefaultWDirection");
span.setAttribute("outsystems.function.key", "01aba80b-3c99-4574-8f32-ff3539153377");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureMove_JsPreventDefaultWDirectionJS, "JsPreventDefaultWDirection", "OnGestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Dragging inside bounds?
if(((vars.value.offsetYInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0)) && vars.value.offsetYInLocal.gt(OS.BuiltinFunctions.integerToDecimal(((-1) * model.variables.notificationHeightVar)))))) {
// Update Last Positions
// MoveY = OffsetY
model.variables.moveYVar = vars.value.offsetYInLocal;
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
} else {
// At limit?
if((vars.value.offsetYInLocal.gt(OS.BuiltinFunctions.integerToDecimal(((-1) * model.variables.notificationHeightVar))))) {
// Set Position
// MoveY = 0
model.variables.moveYVar = OS.BuiltinFunctions.integerToDecimal(0);
}

}

} else {
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

return this.__onGestureMove$Action;
}set _onGestureMove$Action(value) {this.__onGestureMove$Action = value;
}

get _onGestureStart$Action() {if(!(this.hasOwnProperty("__onGestureStart$Action"))) {
this.__onGestureStart$Action = function (xIn, yIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnGestureStart", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureStart");
span.setAttribute("outsystems.function.key", "570784d3-aa6c-4c14-b708-130f035059b0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnGestureStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureStart$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
var jsCleanAnimationClassesJSResult = new OS.DataTypes.VariableHolder();
// Script to clean the animation classes.
jsCleanAnimationClassesJSResult.value = OS.Logger.startActiveSpan("JsCleanAnimationClasses", function (span) {
if(span) {
span.setAttribute("code.function", "JsCleanAnimationClasses");
span.setAttribute("outsystems.function.key", "e7bdde34-7ec7-4b00-a9a2-b80661ee6c06");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnGestureStart_JsCleanAnimationClassesJS, "JsCleanAnimationClasses", "OnGestureStart", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text),
Height: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureStart$jsCleanAnimationClassesJSResult"))();
jsNodeResult.heightOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Height, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Update local vars
// HasNoTransition = True
model.variables.hasNoTransitionVar = true;
// IsMoving = True
model.variables.isMovingVar = true;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// MoveY = 0
model.variables.moveYVar = OS.BuiltinFunctions.integerToDecimal(0);
// NotificationHeight = JsCleanAnimationClasses.Height
model.variables.notificationHeightVar = jsCleanAnimationClassesJSResult.value.heightOut;
// DragDirection = ""
model.variables.dragDirectionVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onGestureStart$Action;
}set _onGestureStart$Action(value) {this.__onGestureStart$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "6c0d1eea-6917-425e-82f1-83eb3df62167");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Init Statuses
// IsNotificationOpen = IsOpen
model.variables.isNotificationOpenVar = model.variables.isOpenIn;
// IsWebApp = IsWebApp()
model.variables.isWebAppVar = OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut;
// Script to add an event listener to handle the ESC on key down in order to close the notification.
OS.Logger.startActiveSpan("JsAddKeypressEvent", function (span) {
if(span) {
span.setAttribute("code.function", "JsAddKeypressEvent");
span.setAttribute("outsystems.function.key", "ef9c95a5-bdfc-4e93-b8bf-dbc65a7a1855");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsAddKeypressEventJS, "JsAddKeypressEvent", "OnReady", null, function ($parameters) {
}, {
OnNotificationClose: controller.clientActionProxies.onNotificationClose$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Is Web App?
if(((OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut === true))) {
// Script to init all allneeded for the web context.
OS.Logger.startActiveSpan("JsInitWeb", function (span) {
if(span) {
span.setAttribute("code.function", "JsInitWeb");
span.setAttribute("outsystems.function.key", "31d41f9f-0398-44f2-943d-8a30d4e03930");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsInitWebJS, "JsInitWeb", "OnReady", {
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
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
// Script to init all allneeded for the mobile context.
OS.Logger.startActiveSpan("JsInitMobile", function (span) {
if(span) {
span.setAttribute("code.function", "JsInitMobile");
span.setAttribute("outsystems.function.key", "b394e52a-5f49-44f6-b002-5fe531f3c9cc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OnReady_JsInitMobileJS, "JsInitMobile", "OnReady", {
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
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

get _onNotificationClose$Action() {if(!(this.hasOwnProperty("__onNotificationClose$Action"))) {
this.__onNotificationClose$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnNotificationClose", function (span) {
if(span) {
span.setAttribute("code.function", "OnNotificationClose");
span.setAttribute("outsystems.function.key", "79ea26d9-2ce4-4647-a018-379d8e91eaf4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnNotificationClose");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: OpenCloseNotification
controller._openCloseNotification$Action(false, callContext);
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

return this.__onNotificationClose$Action;
}set _onNotificationClose$Action(value) {this.__onNotificationClose$Action = value;
}

get _openCloseNotification$Action() {if(!(this.hasOwnProperty("__openCloseNotification$Action"))) {
this.__openCloseNotification$Action = function (isOpenOrCloseIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OpenCloseNotification", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCloseNotification");
span.setAttribute("outsystems.function.key", "7b93fc98-28fd-4915-a512-2611e3d77d4e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenCloseNotification");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OpenCloseNotification$vars"))());
vars.value.isOpenOrCloseInLocal = isOpenOrCloseIn;
// Set Internal Status
// IsNotificationOpen = IsOpenOrClose
model.variables.isNotificationOpenVar = vars.value.isOpenOrCloseInLocal;
// Will Open?
if((vars.value.isOpenOrCloseInLocal)) {
// Script to open the notification.
OS.Logger.startActiveSpan("JsOpenNotification", function (span) {
if(span) {
span.setAttribute("code.function", "JsOpenNotification");
span.setAttribute("outsystems.function.key", "88387b6f-165f-4694-9378-f1bfb188df40");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OpenCloseNotification_JsOpenNotificationJS, "JsOpenNotification", "OpenCloseNotification", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
// Script to close the notification.
OS.Logger.startActiveSpan("JsCloseNotification", function (span) {
if(span) {
span.setAttribute("code.function", "JsCloseNotification");
span.setAttribute("outsystems.function.key", "f835efbf-46bd-416e-8df4-705859f27809");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_OpenCloseNotification_JsCloseNotificationJS, "JsCloseNotification", "OpenCloseNotification", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text)
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

return this.__openCloseNotification$Action;
}set _openCloseNotification$Action(value) {this.__openCloseNotification$Action = value;
}

get _updateUI$Action() {if(!(this.hasOwnProperty("__updateUI$Action"))) {
this.__updateUI$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "9e95e41e-473d-4f09-8474-7c353e7690b4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateUI");
callContext = controller.callContext(callContext);
if((model.variables.isMovingVar)) {
// Script to force the UI update.
OS.Logger.startActiveSpan("JsMoveNotification", function (span) {
if(span) {
span.setAttribute("code.function", "JsMoveNotification");
span.setAttribute("outsystems.function.key", "dee19364-afb7-44b7-bc9a-79f93da74a08");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Notification_mvc_controller_UpdateUI_JsMoveNotificationJS, "JsMoveNotification", "UpdateUI", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("notification"), OS.DataTypes.DataTypes.Text),
OffsetY: OS.DataConversion.JSNodeParamConverter.to(model.variables.moveYVar, OS.DataTypes.DataTypes.Decimal)
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


onGestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnGestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureEnd");
span.setAttribute("outsystems.function.key", "34c0481a-4d73-4272-bb47-4e7d2d3acf9b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onGestureEnd$Action, callContext, offsetXIn, offsetYIn, timeTakenIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onGestureMove$Action(offsetXIn, offsetYIn, evtIn, xIn, yIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnGestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureMove");
span.setAttribute("outsystems.function.key", "412fa1e4-377e-4e32-abc7-445d98ed4e25");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onGestureMove$Action, callContext, offsetXIn, offsetYIn, evtIn, xIn, yIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onGestureStart$Action(xIn, yIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnGestureStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnGestureStart");
span.setAttribute("outsystems.function.key", "570784d3-aa6c-4c14-b708-130f035059b0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onGestureStart$Action, callContext, xIn, yIn);
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
span.setAttribute("outsystems.function.key", "6c0d1eea-6917-425e-82f1-83eb3df62167");
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

onNotificationClose$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnNotificationClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnNotificationClose");
span.setAttribute("outsystems.function.key", "79ea26d9-2ce4-4647-a018-379d8e91eaf4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onNotificationClose$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openCloseNotification$Action(isOpenOrCloseIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OpenCloseNotification__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCloseNotification");
span.setAttribute("outsystems.function.key", "7b93fc98-28fd-4915-a512-2611e3d77d4e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openCloseNotification$Action, callContext, isOpenOrCloseIn);
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
span.setAttribute("outsystems.function.key", "9e95e41e-473d-4f09-8474-7c353e7690b4");
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

return controller.openCloseNotification$Action(model.variables.isOpenIn, callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureEnd$vars", [{
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
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureMove$vars", [{
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
}, {
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureStart$vars", [{
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OnGestureStart$jsCleanAnimationClassesJSResult", [{
name: "Height",
attrName: "heightOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Notification.OpenCloseNotification$vars", [{
name: "IsOpenOrClose",
attrName: "isOpenOrCloseInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




