import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_TranslationsResources from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$translationsResources.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_Accessibility_SetAccessibilityParamsJS from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$controller.Accessibility.SetAccessibilityParamsJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_CloseMenu_CloseJS from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$controller.CloseMenu.CloseJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OnReady_SetGlobalActionsJS from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$controller.OnReady.SetGlobalActionsJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$controller.OnReady.InitJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OpenMenu_CloseAllJS from "./OutSystemsUI.Navigation.DEPRECATED_Submenu.mvc$controller.OpenMenu.CloseAllJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
closeMenu$Action: function () {
return controller.executeActionInsideJSNode(controller._closeMenu$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "CloseMenu");
},
openMenu$Action: function () {
return controller.executeActionInsideJSNode(controller._openMenu$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OpenMenu");
},
onMenuClick$Action: function () {
return controller.executeActionInsideJSNode(controller._onMenuClick$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnMenuClick");
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
get _accessibility$Action() {if(!(this.hasOwnProperty("__accessibility$Action"))) {
this.__accessibility$Action = function (itemIDIn, isOpenedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Accessibility", function (span) {
if(span) {
span.setAttribute("code.function", "Accessibility");
span.setAttribute("outsystems.function.key", "01cee7d5-4fa1-4206-87d8-ef00b98f0f88");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Accessibility");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.Accessibility$vars"))());
vars.value.itemIDInLocal = itemIDIn;
vars.value.isOpenedInLocal = isOpenedIn;
OS.Logger.startActiveSpan("SetAccessibilityParams", function (span) {
if(span) {
span.setAttribute("code.function", "SetAccessibilityParams");
span.setAttribute("outsystems.function.key", "d98e9c63-8074-471c-8934-dce914a509c2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_Accessibility_SetAccessibilityParamsJS, "SetAccessibilityParams", "Accessibility", {
SubmenuId: OS.DataConversion.JSNodeParamConverter.to(vars.value.itemIDInLocal, OS.DataTypes.DataTypes.Text),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(vars.value.isOpenedInLocal, OS.DataTypes.DataTypes.Boolean)
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

return this.__accessibility$Action;
}set _accessibility$Action(value) {this.__accessibility$Action = value;
}

get _onMenuClick$Action() {if(!(this.hasOwnProperty("__onMenuClick$Action"))) {
this.__onMenuClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnMenuClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnMenuClick");
span.setAttribute("outsystems.function.key", "1e9ff0ff-5065-4d02-8c1b-17215e8fa0de");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnMenuClick");
callContext = controller.callContext(callContext);
if((model.variables.isOpenVar)) {
// Execute Action: CloseMenu
controller._closeMenu$Action(callContext);
} else {
// Execute Action: OpenMenu
controller._openMenu$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onMenuClick$Action;
}set _onMenuClick$Action(value) {this.__onMenuClick$Action = value;
}

get _closeMenu$Action() {if(!(this.hasOwnProperty("__closeMenu$Action"))) {
this.__closeMenu$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CloseMenu", function (span) {
if(span) {
span.setAttribute("code.function", "CloseMenu");
span.setAttribute("outsystems.function.key", "7768b5c7-f99d-47bc-a6e1-7e8551ff74ea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseMenu");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Close", function (span) {
if(span) {
span.setAttribute("code.function", "Close");
span.setAttribute("outsystems.function.key", "16ead7d3-cc48-4100-90fc-1eafd5759ce2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_CloseMenu_CloseJS, "Close", "CloseMenu", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Submenu"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsOpen = False
model.variables.isOpenVar = false;
// Execute Action: Accessibility
controller._accessibility$Action(idService.getId("Submenu"), model.variables.isOpenVar, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__closeMenu$Action;
}set _closeMenu$Action(value) {this.__closeMenu$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (idIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c0c2de82-13bc-4ecb-8d1f-f32b7d21a1dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.OnReady$vars"))());
vars.value.idInLocal = idIn;
var initJSResult = new OS.DataTypes.VariableHolder();
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "fc6b7791-36ed-4ceb-a3be-7c9f0a29f394");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
HeaderId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SubMenuHeader"), OS.DataTypes.DataTypes.Text),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Submenu"), OS.DataTypes.DataTypes.Text),
HasItems: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.OnReady$initJSResult"))();
jsNodeResult.hasItemsOut = OS.DataConversion.JSNodeParamConverter.from($parameters.HasItems, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {
CloseMenu: controller.clientActionProxies.closeMenu$Action,
OnMenuClick: controller.clientActionProxies.onMenuClick$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// HasItems = Init.HasItems
model.variables.hasItemsVar = initJSResult.value.hasItemsOut;
OS.Logger.startActiveSpan("SetGlobalActions", function (span) {
if(span) {
span.setAttribute("code.function", "SetGlobalActions");
span.setAttribute("outsystems.function.key", "5187be2a-f066-4672-9f2b-8fa96bc446ea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OnReady_SetGlobalActionsJS, "SetGlobalActions", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(vars.value.idInLocal, OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
CloseMenu: controller.clientActionProxies.closeMenu$Action,
OpenMenu: controller.clientActionProxies.openMenu$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: Accessibility
controller._accessibility$Action(idService.getId("Submenu"), false, callContext);
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

get _openMenu$Action() {if(!(this.hasOwnProperty("__openMenu$Action"))) {
this.__openMenu$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OpenMenu", function (span) {
if(span) {
span.setAttribute("code.function", "OpenMenu");
span.setAttribute("outsystems.function.key", "f452f84e-3e17-4ceb-83b3-608fe85517c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenMenu");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("CloseAll", function (span) {
if(span) {
span.setAttribute("code.function", "CloseAll");
span.setAttribute("outsystems.function.key", "fdbb6c48-8b90-4c59-a540-633487d12402");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Submenu_mvc_controller_OpenMenu_CloseAllJS, "CloseAll", "OpenMenu", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Submenu"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsOpen = True
model.variables.isOpenVar = true;
// Execute Action: Accessibility
controller._accessibility$Action(idService.getId("Submenu"), model.variables.isOpenVar, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__openMenu$Action;
}set _openMenu$Action(value) {this.__openMenu$Action = value;
}


accessibility$Action(itemIDIn, isOpenedIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Accessibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Accessibility");
span.setAttribute("outsystems.function.key", "01cee7d5-4fa1-4206-87d8-ef00b98f0f88");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._accessibility$Action, callContext, itemIDIn, isOpenedIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onMenuClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnMenuClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnMenuClick");
span.setAttribute("outsystems.function.key", "1e9ff0ff-5065-4d02-8c1b-17215e8fa0de");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onMenuClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

closeMenu$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CloseMenu__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseMenu");
span.setAttribute("outsystems.function.key", "7768b5c7-f99d-47bc-a6e1-7e8551ff74ea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeMenu$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(idIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c0c2de82-13bc-4ecb-8d1f-f32b7d21a1dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext, idIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openMenu$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OpenMenu__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenMenu");
span.setAttribute("outsystems.function.key", "f452f84e-3e17-4ceb-83b3-608fe85517c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openMenu$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

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

return controller.onReady$Action(idService.getId("Submenu"), callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.Accessibility$vars", [{
name: "ItemID",
attrName: "itemIDInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsOpened",
attrName: "isOpenedInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.OnReady$vars", [{
name: "Id",
attrName: "idInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Submenu.OnReady$initJSResult", [{
name: "HasItems",
attrName: "hasItemsOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




