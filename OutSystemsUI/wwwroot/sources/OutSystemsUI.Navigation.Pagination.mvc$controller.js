import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_Pagination_mvc_TranslationsResources from "./OutSystemsUI.Navigation.Pagination.mvc$translationsResources.js";
import OutSystemsUI_Navigation_Pagination_mvc_controller_GoTo_JsSetFocusOnButtonJS from "./OutSystemsUI.Navigation.Pagination.mvc$controller.GoTo.JsSetFocusOnButtonJS.js";
import OutSystemsUI_Navigation_Pagination_mvc_controller_InputOnChange_SetListenerJS from "./OutSystemsUI.Navigation.Pagination.mvc$controller.InputOnChange.SetListenerJS.js";
import OutSystemsUI_Navigation_Pagination_mvc_controller_InitPagination_JsCalculateGoToValueJS from "./OutSystemsUI.Navigation.Pagination.mvc$controller.InitPagination.JsCalculateGoToValueJS.js";
import OutSystemsUI_Navigation_Pagination_mvc_controller_InitPagination_JsGetTotalPagesJS from "./OutSystemsUI.Navigation.Pagination.mvc$controller.InitPagination.JsGetTotalPagesJS.js";
import OutSystemsUI_Navigation_Pagination_mvc_controller_OnDestroy_RemoveListenerJS from "./OutSystemsUI.Navigation.Pagination.mvc$controller.OnDestroy.RemoveListenerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_Pagination_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
goTo$Action: function (newStartIndexIn, edgeFocusableElemIdIn) {
newStartIndexIn = (newStartIndexIn === undefined) ? 0 : newStartIndexIn;
edgeFocusableElemIdIn = (edgeFocusableElemIdIn === undefined) ? "" : edgeFocusableElemIdIn;
return controller.executeActionInsideJSNode(controller._goTo$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(newStartIndexIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(edgeFocusableElemIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "GoTo");
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
get _goTo$Action() {if(!(this.hasOwnProperty("__goTo$Action"))) {
this.__goTo$Action = function (newStartIndexIn, edgeFocusableElemIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GoTo", function (span) {
if(span) {
span.setAttribute("code.function", "GoTo");
span.setAttribute("outsystems.function.key", "1f1386a6-3649-467c-8610-6b60e052983d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GoTo");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.GoTo$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
vars.value.edgeFocusableElemIdInLocal = edgeFocusableElemIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnNavigate
return controller.onNavigate$Action(vars.value.newStartIndexInLocal, callContext).then(function () {
// Set GoToValue
// GoToValue = SelectedPageButton
model.variables.goToValueVar = model.variables.selectedPageButtonVar;
}).then(function () {
// Show Go To Page?
if((!(model.variables.showGoToPageIn))) {
OS.Logger.startActiveSpan("JsSetFocusOnButton", function (span) {
if(span) {
span.setAttribute("code.function", "JsSetFocusOnButton");
span.setAttribute("outsystems.function.key", "aee436f4-f76d-4605-9a99-0bf50cda562f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Pagination_mvc_controller_GoTo_JsSetFocusOnButtonJS, "JsSetFocusOnButton", "GoTo", {
PaginationListId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("PaginationList"), OS.DataTypes.DataTypes.Text),
EdgeFocusableElemId: OS.DataConversion.JSNodeParamConverter.to(vars.value.edgeFocusableElemIdInLocal, OS.DataTypes.DataTypes.Text),
FirstButtonElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("btnFirstPage"), OS.DataTypes.DataTypes.Text),
LastButtonElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("buttonLastPage"), OS.DataTypes.DataTypes.Text),
IsLastButton: OS.DataConversion.JSNodeParamConverter.to((model.variables.goToValueVar === model.variables.lastPageNumberVar), OS.DataTypes.DataTypes.Boolean),
IsFirstButton: OS.DataConversion.JSNodeParamConverter.to((model.variables.goToValueVar === 1), OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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

return this.__goTo$Action;
}set _goTo$Action(value) {this.__goTo$Action = value;
}

get _inputOnChange$Action() {if(!(this.hasOwnProperty("__inputOnChange$Action"))) {
this.__inputOnChange$Action = function (isBlurIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InputOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "InputOnChange");
span.setAttribute("outsystems.function.key", "c9bde713-b63b-4473-9607-af72cf2c6330");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InputOnChange");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.InputOnChange$vars"))());
vars.value.isBlurInLocal = isBlurIn;
var setListenerJSResult = new OS.DataTypes.VariableHolder();
setListenerJSResult.value = OS.Logger.startActiveSpan("SetListener", function (span) {
if(span) {
span.setAttribute("code.function", "SetListener");
span.setAttribute("outsystems.function.key", "d78d0de4-f6ff-41ab-a611-04bcb964db80");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Pagination_mvc_controller_InputOnChange_SetListenerJS, "SetListener", "InputOnChange", {
IsBlur: OS.DataConversion.JSNodeParamConverter.to(vars.value.isBlurInLocal, OS.DataTypes.DataTypes.Boolean),
InputElementId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Input_SelectedPageButton"), OS.DataTypes.DataTypes.Text),
MaxRecords: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxRecordsIn, OS.DataTypes.DataTypes.Integer),
Value: OS.DataConversion.JSNodeParamConverter.to(model.variables.goToValueVar, OS.DataTypes.DataTypes.Integer),
TotalPages: OS.DataConversion.JSNodeParamConverter.to(model.variables.totalPagesVar, OS.DataTypes.DataTypes.Integer),
GotoValue: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
KeypressCallbackObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.InputOnChange$setListenerJSResult"))();
jsNodeResult.gotoValueOut = OS.DataConversion.JSNodeParamConverter.from($parameters.GotoValue, OS.DataTypes.DataTypes.Integer);
jsNodeResult.keypressCallbackObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.KeypressCallbackObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
GoTo: controller.clientActionProxies.goTo$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set Go To Value and Callback
// GoToValue = SetListener.GotoValue
model.variables.goToValueVar = setListenerJSResult.value.gotoValueOut;
// KeypressCallback = SetListener.KeypressCallbackObj
model.variables.keypressCallbackVar = setListenerJSResult.value.keypressCallbackObjOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__inputOnChange$Action;
}set _inputOnChange$Action(value) {this.__inputOnChange$Action = value;
}

get _initPagination$Action() {if(!(this.hasOwnProperty("__initPagination$Action"))) {
this.__initPagination$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitPagination", function (span) {
if(span) {
span.setAttribute("code.function", "InitPagination");
span.setAttribute("outsystems.function.key", "e2838a95-004e-4516-bb42-a826bb628034");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitPagination");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$vars"))());
var jsCalculateGoToValueJSResult = new OS.DataTypes.VariableHolder();
var jsGetTotalPagesJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if(((model.variables.maxRecordsIn >= 1))) {
// Script to get the total number of pages.
jsGetTotalPagesJSResult.value = OS.Logger.startActiveSpan("JsGetTotalPages", function (span) {
if(span) {
span.setAttribute("code.function", "JsGetTotalPages");
span.setAttribute("outsystems.function.key", "6d2daf7a-2980-4e40-9c0d-df9d5b6935c7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Pagination_mvc_controller_InitPagination_JsGetTotalPagesJS, "JsGetTotalPages", "InitPagination", {
TotalCount: OS.DataConversion.JSNodeParamConverter.to(model.variables.totalCountIn, OS.DataTypes.DataTypes.LongInteger),
MaxRecords: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.integerToLongInteger(model.variables.maxRecordsIn), OS.DataTypes.DataTypes.LongInteger),
TotalPages: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$jsGetTotalPagesJSResult"))();
jsNodeResult.totalPagesOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TotalPages, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SelectedPageButton = StartIndex / MaxRecords + 1
model.variables.selectedPageButtonVar = OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(OS.BuiltinFunctions.integerToDecimal(model.variables.startIndexIn).div(OS.BuiltinFunctions.integerToDecimal(model.variables.maxRecordsIn)).plus(OS.BuiltinFunctions.integerToDecimal(1))));
// Execute Action: LoadOutSystemsUIScript
model.flush();
return OutSystemsUIController.default.loadOutSystemsUIScript$Action(callContext).then(function () {
// Is Phone?
if((OutSystemsUIController.default.isPhone$Action(callContext).isPhoneOut)) {
// Set Phone
// MaxPagesToShow = 1
vars.value.maxPagesToShowVar = 1;
// IsPhone = True
model.variables.isPhoneVar = true;
}

// Set Defaults
// TotalPages = JsGetTotalPages.TotalPages
model.variables.totalPagesVar = jsGetTotalPagesJSResult.value.totalPagesOut;
// LastPageNumber = JsGetTotalPages.TotalPages + 1
model.variables.lastPageNumberVar = (jsGetTotalPagesJSResult.value.totalPagesOut + 1);
// PagesToCreate = If
vars.value.pagesToCreateVar = (((model.variables.totalPagesVar === 4)) ? (3) : (((((model.variables.totalPagesVar - 2) > vars.value.maxPagesToShowVar)) ? (vars.value.maxPagesToShowVar) : ((((model.variables.totalPagesVar > 3)) ? ((model.variables.totalPagesVar - 2)) : (model.variables.totalPagesVar))))));
// CurrentPage = If
vars.value.currentPageVar = ((((vars.value.maxPagesToShowVar === 1) && (model.variables.totalPagesVar > 4))) ? ((((model.variables.selectedPageButtonVar <= 1)) ? (model.variables.selectedPageButtonVar) : (((((model.variables.selectedPageButtonVar + 1) <= model.variables.totalPagesVar)) ? ((model.variables.selectedPageButtonVar - 1)) : ((model.variables.totalPagesVar - vars.value.pagesToCreateVar)))))) : ((((model.variables.totalPagesVar === 3)) ? ((((model.variables.selectedPageButtonVar <= 4)) ? (1) : (((((model.variables.selectedPageButtonVar + 1) <= model.variables.totalPagesVar)) ? ((model.variables.selectedPageButtonVar - 2)) : ((model.variables.totalPagesVar - vars.value.pagesToCreateVar)))))) : ((((model.variables.selectedPageButtonVar <= 3)) ? (1) : (((((model.variables.selectedPageButtonVar + 1) <= model.variables.totalPagesVar)) ? ((model.variables.selectedPageButtonVar - 2)) : ((model.variables.totalPagesVar - vars.value.pagesToCreateVar)))))))));
// Script to calculate the initial go to value.
jsCalculateGoToValueJSResult.value = OS.Logger.startActiveSpan("JsCalculateGoToValue", function (span) {
if(span) {
span.setAttribute("code.function", "JsCalculateGoToValue");
span.setAttribute("outsystems.function.key", "5e4b648f-e609-45e1-922f-f0f3e57fc9f1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Pagination_mvc_controller_InitPagination_JsCalculateGoToValueJS, "JsCalculateGoToValue", "InitPagination", {
MaxRecords: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxRecordsIn, OS.DataTypes.DataTypes.Integer),
TotalPages: OS.DataConversion.JSNodeParamConverter.to(model.variables.totalPagesVar, OS.DataTypes.DataTypes.Integer),
StartIndex: OS.DataConversion.JSNodeParamConverter.to(model.variables.startIndexIn, OS.DataTypes.DataTypes.Integer),
Value: OS.DataConversion.JSNodeParamConverter.to(model.variables.goToValueVar, OS.DataTypes.DataTypes.Integer),
GotoValue: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$jsCalculateGoToValueJSResult"))();
jsNodeResult.gotoValueOut = OS.DataConversion.JSNodeParamConverter.from($parameters.GotoValue, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set GoToValue
// GoToValue = JsCalculateGoToValue.GotoValue
model.variables.goToValueVar = jsCalculateGoToValueJSResult.value.gotoValueOut;
if((model.variables.totalCountIn.equals(OS.BuiltinFunctions.integerToLongInteger(0)))) {
// Hide
// IsVisible = False
model.variables.isVisibleVar = false;
} else {
// Execute Action: ListClear
OS.SystemActions.listClear(model.variables.middleNavigationPagesVar, callContext);
// MiddleNav.Length < PagesToCreate
while (((model.variables.middleNavigationPagesVar.length < vars.value.pagesToCreateVar))) {
// AddPagesToList
// ListNavigationPage.Page = CurrentPage + 1
vars.value.listNavigationPageVar.pageAttr = (vars.value.currentPageVar + 1);
// ListNavigationPage.StartIndex = CurrentPage * MaxRecords
vars.value.listNavigationPageVar.startIndexAttr = (vars.value.currentPageVar * model.variables.maxRecordsIn);
// Execute Action: AppendPage
OS.SystemActions.listAppend(model.variables.middleNavigationPagesVar, vars.value.listNavigationPageVar, callContext);
// CurrentPage +=1
// CurrentPage = CurrentPage + 1
vars.value.currentPageVar = (vars.value.currentPageVar + 1);
}

// Execute Action: ListSort
OS.SystemActions.listSort(model.variables.middleNavigationPagesVar, function (p) {
return p.pageAttr;
}, true, callContext);
// IsVisible = True
model.variables.isVisibleVar = true;
}

});
} else {
// Hide
// IsVisible = False
model.variables.isVisibleVar = false;
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

return this.__initPagination$Action;
}set _initPagination$Action(value) {this.__initPagination$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "faf55aa3-972e-4e42-aa47-4c9a4a0fd6cc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveListener", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveListener");
span.setAttribute("outsystems.function.key", "fab2a5c3-d3ee-4e83-b072-e1d2c00faa94");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_Pagination_mvc_controller_OnDestroy_RemoveListenerJS, "RemoveListener", "OnDestroy", {
KeypressCallback: OS.DataConversion.JSNodeParamConverter.to(model.variables.keypressCallbackVar, OS.DataTypes.DataTypes.Object),
InputElemId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Input_SelectedPageButton"), OS.DataTypes.DataTypes.Text)
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


goTo$Action(newStartIndexIn, edgeFocusableElemIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GoTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GoTo");
span.setAttribute("outsystems.function.key", "1f1386a6-3649-467c-8610-6b60e052983d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._goTo$Action, callContext, newStartIndexIn, edgeFocusableElemIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

inputOnChange$Action(isBlurIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InputOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InputOnChange");
span.setAttribute("outsystems.function.key", "c9bde713-b63b-4473-9607-af72cf2c6330");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._inputOnChange$Action, callContext, isBlurIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

initPagination$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitPagination__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitPagination");
span.setAttribute("outsystems.function.key", "e2838a95-004e-4516-bb42-a826bb628034");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initPagination$Action, callContext);
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
span.setAttribute("outsystems.function.key", "faf55aa3-972e-4e42-aa47-4c9a4a0fd6cc");
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

get onNavigate$Action() {if(!(this.hasOwnProperty("_onNavigate$Action"))) {
this._onNavigate$Action = function () {
return Promise.resolve();
};
}

return this._onNavigate$Action;
}set onNavigate$Action(value) {this._onNavigate$Action = value;
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

return controller.initPagination$Action(callContext);

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

return controller.initPagination$Action(callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.GoTo$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "EdgeFocusableElemId",
attrName: "edgeFocusableElemIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.InputOnChange$vars", [{
name: "IsBlur",
attrName: "isBlurInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.InputOnChange$setListenerJSResult", [{
name: "GotoValue",
attrName: "gotoValueOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "KeypressCallbackObj",
attrName: "keypressCallbackObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$vars", [{
name: "PagesToCreate",
attrName: "pagesToCreateVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "CurrentPage",
attrName: "currentPageVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "ListNavigationPage",
attrName: "listNavigationPageVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Record,
defaultValue: function () {
return new OutSystemsUIModel.ST_28a47f2e64dd49f0d3d29e55f70be394Structure();
},
complexType: OutSystemsUIModel.ST_28a47f2e64dd49f0d3d29e55f70be394Structure
}, {
name: "MaxPagesToShow",
attrName: "maxPagesToShowVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 3;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$jsCalculateGoToValueJSResult", [{
name: "GotoValue",
attrName: "gotoValueOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.Pagination.InitPagination$jsGetTotalPagesJSResult", [{
name: "TotalPages",
attrName: "totalPagesOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




