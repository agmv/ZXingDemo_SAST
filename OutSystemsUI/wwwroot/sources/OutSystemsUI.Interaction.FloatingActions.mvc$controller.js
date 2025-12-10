import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_FloatingActions_mvc_TranslationsResources from "./OutSystemsUI.Interaction.FloatingActions.mvc$translationsResources.js";
import OutSystemsUI_Interaction_FloatingActions_mvc_controller_ToggleTabIndex_ToggleTabindexJS from "./OutSystemsUI.Interaction.FloatingActions.mvc$controller.ToggleTabIndex.ToggleTabindexJS.js";
import OutSystemsUI_Interaction_FloatingActions_mvc_controller_ToggleClick_ToggleEventsJS from "./OutSystemsUI.Interaction.FloatingActions.mvc$controller.ToggleClick.ToggleEventsJS.js";
import OutSystemsUI_Interaction_FloatingActions_mvc_controller_OnDestroy_RemoveListenersJS from "./OutSystemsUI.Interaction.FloatingActions.mvc$controller.OnDestroy.RemoveListenersJS.js";
import OutSystemsUI_Interaction_FloatingActions_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Interaction.FloatingActions.mvc$controller.OnReady.InitJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_FloatingActions_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
toggleClick$Action: function () {
return controller.executeActionInsideJSNode(controller._toggleClick$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ToggleClick");
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
get _toggleTabIndex$Action() {if(!(this.hasOwnProperty("__toggleTabIndex$Action"))) {
this.__toggleTabIndex$Action = function (isOnReadyIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ToggleTabIndex", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleTabIndex");
span.setAttribute("outsystems.function.key", "29d31763-39dc-402c-accf-885aa26821cf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ToggleTabIndex");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.FloatingActions.ToggleTabIndex$vars"))());
vars.value.isOnReadyInLocal = isOnReadyIn;
OS.Logger.startActiveSpan("ToggleTabindex", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleTabindex");
span.setAttribute("outsystems.function.key", "58b69787-38ec-4545-b626-07227e79dcc4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_FloatingActions_mvc_controller_ToggleTabIndex_ToggleTabindexJS, "ToggleTabindex", "ToggleTabIndex", {
FloatingId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("FloatingActions"), OS.DataTypes.DataTypes.Text),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenVar, OS.DataTypes.DataTypes.Boolean),
IsOnReady: OS.DataConversion.JSNodeParamConverter.to(vars.value.isOnReadyInLocal, OS.DataTypes.DataTypes.Boolean)
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

return this.__toggleTabIndex$Action;
}set _toggleTabIndex$Action(value) {this.__toggleTabIndex$Action = value;
}

get _toggleClick$Action() {if(!(this.hasOwnProperty("__toggleClick$Action"))) {
this.__toggleClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ToggleClick", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleClick");
span.setAttribute("outsystems.function.key", "31d358ed-3616-4147-bb35-6a3e1d49d077");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ToggleClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// IsOpen = notIsOpen
model.variables.isOpenVar = (!(model.variables.isOpenVar));
// Execute Action: ToggleTabIndex
controller._toggleTabIndex$Action(false, callContext);
OS.Logger.startActiveSpan("ToggleEvents", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleEvents");
span.setAttribute("outsystems.function.key", "9420947e-8b82-4b77-bde9-e14d0132c9be");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_FloatingActions_mvc_controller_ToggleClick_ToggleEventsJS, "ToggleEvents", "ToggleClick", {
IsHover: OS.DataConversion.JSNodeParamConverter.to(model.variables.isHoverIn, OS.DataTypes.DataTypes.Boolean),
FloatingId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("FloatingActions"), OS.DataTypes.DataTypes.Text),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(model.variables.isOpenVar, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
ToggleClick: controller.clientActionProxies.toggleClick$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Trigger Event: OnToggle
return controller.onToggle$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__toggleClick$Action;
}set _toggleClick$Action(value) {this.__toggleClick$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "33db59cc-c99b-47c7-82bf-c82a4b2064a2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveListeners", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveListeners");
span.setAttribute("outsystems.function.key", "e52833aa-c522-43e1-8753-05e26e996caa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_FloatingActions_mvc_controller_OnDestroy_RemoveListenersJS, "RemoveListeners", "OnDestroy", {
DOMElem: OS.DataConversion.JSNodeParamConverter.to(model.variables.dOMElemVar, OS.DataTypes.DataTypes.Object),
IsHover: OS.DataConversion.JSNodeParamConverter.to(model.variables.isHoverIn, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
ToggleClick: controller.clientActionProxies.toggleClick$Action
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

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f0df47d1-66cd-4177-9377-cbf0531cc1da");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var initJSResult = new OS.DataTypes.VariableHolder();
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "7fe34239-7a27-424e-afa6-3fcd67be6836");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_FloatingActions_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
IsExpanded: OS.DataConversion.JSNodeParamConverter.to(model.variables.isExpandedIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("FloatingActions"), OS.DataTypes.DataTypes.Text),
IsHover: OS.DataConversion.JSNodeParamConverter.to(model.variables.isHoverIn, OS.DataTypes.DataTypes.Boolean),
IsInsideBottomBar: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
DOMElem: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.FloatingActions.OnReady$initJSResult"))();
jsNodeResult.isInsideBottomBarOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsInsideBottomBar, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.dOMElemOut = OS.DataConversion.JSNodeParamConverter.from($parameters.DOMElem, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
ToggleClick: controller.clientActionProxies.toggleClick$Action,
MoveElement: OutSystemsUIController.default.clientActionProxies.moveElement$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set vars
// IsOpen = IsExpanded
model.variables.isOpenVar = model.variables.isExpandedIn;
// IsInsideBottomBar = Init.IsInsideBottomBar
model.variables.isInsideBottomBarVar = initJSResult.value.isInsideBottomBarOut;
// DOMElem = Init.DOMElem
model.variables.dOMElemVar = initJSResult.value.dOMElemOut;
// Execute Action: ToggleTabIndex
controller._toggleTabIndex$Action(true, callContext);
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


toggleTabIndex$Action(isOnReadyIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ToggleTabIndex__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleTabIndex");
span.setAttribute("outsystems.function.key", "29d31763-39dc-402c-accf-885aa26821cf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._toggleTabIndex$Action, callContext, isOnReadyIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

toggleClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ToggleClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleClick");
span.setAttribute("outsystems.function.key", "31d358ed-3616-4147-bb35-6a3e1d49d077");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._toggleClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "33db59cc-c99b-47c7-82bf-c82a4b2064a2");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f0df47d1-66cd-4177-9377-cbf0531cc1da");
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.FloatingActions.ToggleTabIndex$vars", [{
name: "IsOnReady",
attrName: "isOnReadyInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.FloatingActions.OnReady$initJSResult", [{
name: "IsInsideBottomBar",
attrName: "isInsideBottomBarOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "DOMElem",
attrName: "dOMElemOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




