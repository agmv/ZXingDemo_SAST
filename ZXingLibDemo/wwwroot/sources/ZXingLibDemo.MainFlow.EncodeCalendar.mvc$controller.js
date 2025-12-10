import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import ZXingLibDemoLanguageResources from "./ZXingLibDemo.languageResources.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
calendarEventBarcode$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
calendarEventBarcode$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get calendarEventBarcode$DataActRefresh() {if(!(this.hasOwnProperty("_calendarEventBarcode$DataActRefresh"))) {
this._calendarEventBarcode$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionCalendarEventBarcode", "screenservices/ZXingLibDemo/MainFlow/EncodeCalendar/DataActionCalendarEventBarcode", "po6+0t1OeNpJfi1Cuay75A", function (b) {
model.variables.calendarEventBarcodeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.calendarEventBarcodeDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.calendarEventBarcodeDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._onAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("CalendarEventBarcode", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarEventBarcode");
span.setAttribute("outsystems.function.key", "a6deb6dc-9335-4d25-b785-bd6e40a20a9c");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._calendarEventBarcode$DataActRefresh;
}set calendarEventBarcode$DataActRefresh(value) {this._calendarEventBarcode$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["calendarEventBarcode$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _startDateOnSelected$Action() {if(!(this.hasOwnProperty("__startDateOnSelected$Action"))) {
this.__startDateOnSelected$Action = function (selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("StartDateOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "StartDateOnSelected");
span.setAttribute("outsystems.function.key", "96c62768-d6b3-41cb-9221-198894b83d82");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("StartDateOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.MainFlow.EncodeCalendar.StartDateOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// CalendarEventData.startDateTime = SelectedDateTime
model.variables.calendarEventDataVar.startDateTimeAttr = vars.value.selectedDateTimeInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__startDateOnSelected$Action;
}set _startDateOnSelected$Action(value) {this.__startDateOnSelected$Action = value;
}

get _calendarEventEncodeOnClick$Action() {if(!(this.hasOwnProperty("__calendarEventEncodeOnClick$Action"))) {
this.__calendarEventEncodeOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CalendarEventEncodeOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarEventEncodeOnClick");
span.setAttribute("outsystems.function.key", "a9db049a-6a9c-4c1c-9a61-492ba593aac1");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("CalendarEventEncodeOnClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// Show loading Pop-up
// IsLoading = True
ZXingLibDemoClientVariables.setIsLoading(true);
// Refresh Query: CalendarEventBarcode
var result = controller.calendarEventBarcode$DataActRefresh(callContext);
model.flush();
return result;
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

return this.__calendarEventEncodeOnClick$Action;
}set _calendarEventEncodeOnClick$Action(value) {this.__calendarEventEncodeOnClick$Action = value;
}

get _onAfterFetch$Action() {if(!(this.hasOwnProperty("__onAfterFetch$Action"))) {
this.__onAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "ad2accb2-c2fa-478a-86ff-b5fce8513b16");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnAfterFetch");
callContext = controller.callContext(callContext);
// Hide Loading Pop-up
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onAfterFetch$Action;
}set _onAfterFetch$Action(value) {this.__onAfterFetch$Action = value;
}

get _endDateOnSelected$Action() {if(!(this.hasOwnProperty("__endDateOnSelected$Action"))) {
this.__endDateOnSelected$Action = function (selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("EndDateOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "EndDateOnSelected");
span.setAttribute("outsystems.function.key", "f0bf8ac5-b105-4b49-9e62-5932e7876cdf");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("EndDateOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ZXingLibDemo.MainFlow.EncodeCalendar.EndDateOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// CalendarEventData.endDateTime = SelectedDateTime
model.variables.calendarEventDataVar.endDateTimeAttr = vars.value.selectedDateTimeInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__endDateOnSelected$Action;
}set _endDateOnSelected$Action(value) {this.__endDateOnSelected$Action = value;
}


startDateOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("StartDateOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartDateOnSelected");
span.setAttribute("outsystems.function.key", "96c62768-d6b3-41cb-9221-198894b83d82");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._startDateOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

calendarEventEncodeOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CalendarEventEncodeOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarEventEncodeOnClick");
span.setAttribute("outsystems.function.key", "a9db049a-6a9c-4c1c-9a61-492ba593aac1");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._calendarEventEncodeOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnAfterFetch");
span.setAttribute("outsystems.function.key", "ad2accb2-c2fa-478a-86ff-b5fce8513b16");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

endDateOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("EndDateOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EndDateOnSelected");
span.setAttribute("outsystems.function.key", "f0bf8ac5-b105-4b49-9e62-5932e7876cdf");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._endDateOnSelected$Action, callContext, selectedDateTimeIn);
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
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ZXingLibDemo.MainFlow.EncodeCalendar.StartDateOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS.DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ZXingLibDemo.MainFlow.EncodeCalendar.EndDateOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS.DataTypes.DateTime.defaultValue;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




