import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import ZXingLibDemoLanguageResources from "./ZXingLibDemo.languageResources.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
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
get _onRender$Action() {if(!(this.hasOwnProperty("__onRender$Action"))) {
this.__onRender$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnRender", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "663c0ab9-8ace-4453-a696-2883195a0480");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnRender");
callContext = controller.callContext(callContext);
var setActiveMenuItemsVar = new OS.DataTypes.VariableHolder();
var setMenuListenersVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: SetMenuListeners
model.flush();
return OutSystemsUIController.default.setMenuListeners$Action("", callContext).then(function (value) {
setMenuListenersVar.value = value;
}).then(function () {
// Execute Action: SetActiveMenuItems
model.flush();
return OutSystemsUIController.default.setActiveMenuItems$Action("", model.variables.activeItemIn, model.variables.activeSubItemIn, callContext).then(function (value) {
setActiveMenuItemsVar.value = value;
});
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

return this.__onRender$Action;
}set _onRender$Action(value) {this.__onRender$Action = value;
}

get _hideMenu$Action() {if(!(this.hasOwnProperty("__hideMenu$Action"))) {
this.__hideMenu$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("HideMenu", function (span) {
if(span) {
span.setAttribute("code.function", "HideMenu");
span.setAttribute("outsystems.function.key", "745b3af9-3377-42ce-8564-04895cbed2c8");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("HideMenu");
callContext = controller.callContext(callContext);
var toggleSideMenuVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: ToggleSideMenu
model.flush();
return OutSystemsUIController.default.toggleSideMenu$Action(callContext).then(function (value) {
toggleSideMenuVar.value = value;
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

return this.__hideMenu$Action;
}set _hideMenu$Action(value) {this.__hideMenu$Action = value;
}


onRender$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnRender__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "663c0ab9-8ace-4453-a696-2883195a0480");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onRender$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

hideMenu$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("HideMenu__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "HideMenu");
span.setAttribute("outsystems.function.key", "745b3af9-3377-42ce-8564-04895cbed2c8");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._hideMenu$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
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
this._onReadyEventHandler = null;
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onRender$Action(callContext);

};
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

return controller.onRender$Action(callContext);

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
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




