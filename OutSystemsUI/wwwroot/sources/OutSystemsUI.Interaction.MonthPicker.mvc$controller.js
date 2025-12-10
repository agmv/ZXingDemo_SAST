import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_MonthPicker_mvc_TranslationsResources from "./OutSystemsUI.Interaction.MonthPicker.mvc$translationsResources.js";
import OutSystemsUI_Interaction_MonthPicker_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.MonthPicker.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_MonthPicker_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onSelectedMonthHandler$Action: function (monthpickerIdIn, selectedMonthIn, selectedMonthOrderIn, selectedYearIn) {
monthpickerIdIn = (monthpickerIdIn === undefined) ? "" : monthpickerIdIn;
selectedMonthIn = (selectedMonthIn === undefined) ? "" : selectedMonthIn;
selectedMonthOrderIn = (selectedMonthOrderIn === undefined) ? 0 : selectedMonthOrderIn;
selectedYearIn = (selectedYearIn === undefined) ? 0 : selectedYearIn;
return controller.executeActionInsideJSNode(controller._onSelectedMonthHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(monthpickerIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(selectedMonthIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(selectedMonthOrderIn, OS.DataTypes.DataTypes.Integer), OS.DataConversion.JSNodeParamConverter.from(selectedYearIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSelectedMonthHandler");
},
initializedHandler$Action: function (monthpickerIdIn) {
monthpickerIdIn = (monthpickerIdIn === undefined) ? "" : monthpickerIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(monthpickerIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializedHandler");
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
get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "08109cc0-f954-48a2-94d0-af7e59f0d6d4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_ConfigsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create TimePicker", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);

// Execute Action: SetServerDateFormat
OutSystemsUIController.default.setServerDateFormat$Action(callContext);
// Execute Action: SetLocalLanguage
OutSystemsUIController.default.setLocalLanguage$Action(callContext);
// Set Initial Configs
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.DateFormat = DateFormat
model.variables.internal_ConfigsVar.dateFormatAttr = model.variables.dateFormatIn;
// Internal_Configs.InitialMonth = InitialMonth
model.variables.internal_ConfigsVar.initialMonthAttr = model.variables.initialMonthIn;
// Internal_Configs.MinMonth = MinMonth
model.variables.internal_ConfigsVar.minMonthAttr = model.variables.minMonthIn;
// Internal_Configs.MaxMonth = MaxMonth
model.variables.internal_ConfigsVar.maxMonthAttr = model.variables.maxMonthIn;
// Internal_Configs.ExtendedClass = ExtendedClass
model.variables.internal_ConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// JSON Serialize: Serialize_Configs
serialize_ConfigsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar, true, false);
// Execute Action: MonthPickerCreate
OutSystemsUIController.default.monthPickerCreate$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, serialize_ConfigsVar.value.jSONOut, OutSystemsUIModel.staticEntities.datePickerProvider.flatpickr, callContext);
// Execute Action: RegisterCallbacks
controller._registerCallbacks$Action(callContext);
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

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (monthpickerIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "19e4a025-4102-4917-9338-7f142a4b91f0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.MonthPicker.InitializedHandler$vars"))());
vars.value.monthpickerIdInLocal = monthpickerIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.monthpickerIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__initializedHandler$Action;
}set _initializedHandler$Action(value) {this.__initializedHandler$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "41e70982-d2e8-4a89-87c3-726eae0a8ae8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: MonthPickerInitialize
OutSystemsUIController.default.monthPickerInitialize$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "TimePicker created", callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "55134d98-171a-4e4e-a56a-181e306ad6c5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.dateFormatIn) !== (model.variables.internal_ConfigsVar.dateFormatAttr)))) {
// DateFormat
// Internal_Configs.DateFormat = DateFormat
model.variables.internal_ConfigsVar.dateFormatAttr = model.variables.dateFormatIn;
// Execute Action: Update_DateFormat
OutSystemsUIController.default.monthPickerChangeTextProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "DateFormat", model.variables.internal_ConfigsVar.dateFormatAttr, callContext);
}

if((((model.variables.initialMonthIn) !== (model.variables.internal_ConfigsVar.initialMonthAttr)))) {
// InitialMonth
// Internal_Configs.InitialMonth = InitialMonth
model.variables.internal_ConfigsVar.initialMonthAttr = model.variables.initialMonthIn;
// Execute Action: Update_InitialMonth
OutSystemsUIController.default.monthPickerChangeMonthYearProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "InitialMonth", model.variables.internal_ConfigsVar.initialMonthAttr, callContext);
}

if((((model.variables.minMonthIn) !== (model.variables.internal_ConfigsVar.minMonthAttr)))) {
// MinMonth
// Internal_Configs.MinMonth = MinMonth
model.variables.internal_ConfigsVar.minMonthAttr = model.variables.minMonthIn;
// Execute Action: Update_MinMonth
OutSystemsUIController.default.monthPickerChangeMonthYearProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "MinMonth", model.variables.internal_ConfigsVar.minMonthAttr, callContext);
}

if((((model.variables.maxMonthIn) !== (model.variables.internal_ConfigsVar.maxMonthAttr)))) {
// MaxMonth
// Internal_Configs.MaxMonth = MaxMonth
model.variables.internal_ConfigsVar.maxMonthAttr = model.variables.maxMonthIn;
// Execute Action: Update_MaxMonth
OutSystemsUIController.default.monthPickerChangeMonthYearProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "MaxMonth", model.variables.internal_ConfigsVar.maxMonthAttr, callContext);
}

if((((model.variables.extendedClassIn) !== (model.variables.internal_ConfigsVar.extendedClassAttr)))) {
// ExtendedClass
// Internal_Configs.ExtendedClass = ExtendedClass
model.variables.internal_ConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.monthPickerChangeTextProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internal_ConfigsVar.extendedClassAttr, callContext);
}

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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "6a963539-b472-4ef0-83ae-e7cb30a1ae49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: MonthPickerDestroy
OutSystemsUIController.default.monthPickerDestroy$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
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

get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "a6925ab9-489c-4412-b894-f9c1ccbd4bb5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RegisterCallbacks");
callContext = controller.callContext(callContext);
var getCallbackHandlersJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlersJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandlers", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandlers");
span.setAttribute("outsystems.function.key", "a6e43191-37a3-4f8e-8c5f-bbec9b803652");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_MonthPicker_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnSelected: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnInitialized: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.MonthPicker.RegisterCallbacks$getCallbackHandlersJSResult"))();
jsNodeResult.onSelectedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnSelected, OS.DataTypes.DataTypes.Object);
jsNodeResult.onInitializedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnInitialized, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnSelectedMonthHandler: controller.clientActionProxies.onSelectedMonthHandler$Action,
InitializedHandler: controller.clientActionProxies.initializedHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: MonthPickerRegisterOnSelected
OutSystemsUIController.default.monthPickerRegisterCallback$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onSelected, getCallbackHandlersJSResult.value.onSelectedOut, callContext);
// Execute Action: MonthPickerRegisterOnInitiliazed
OutSystemsUIController.default.monthPickerRegisterCallback$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlersJSResult.value.onInitializedOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__registerCallbacks$Action;
}set _registerCallbacks$Action(value) {this.__registerCallbacks$Action = value;
}

get _onRender$Action() {if(!(this.hasOwnProperty("__onRender$Action"))) {
this.__onRender$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnRender", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "b834a1b3-f184-4524-aacb-077f05c0c2ab");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnRender");
callContext = controller.callContext(callContext);
// Execute Action: MonthPickerOnRender
OutSystemsUIController.default.monthPickerOnRender$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onRender$Action;
}set _onRender$Action(value) {this.__onRender$Action = value;
}

get _onSelectedMonthHandler$Action() {if(!(this.hasOwnProperty("__onSelectedMonthHandler$Action"))) {
this.__onSelectedMonthHandler$Action = function (monthpickerIdIn, selectedMonthIn, selectedMonthOrderIn, selectedYearIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSelectedMonthHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectedMonthHandler");
span.setAttribute("outsystems.function.key", "d4dfb979-540c-4e32-9391-eeee5ab93344");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSelectedMonthHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.MonthPicker.OnSelectedMonthHandler$vars"))());
vars.value.monthpickerIdInLocal = monthpickerIdIn;
vars.value.selectedMonthInLocal = selectedMonthIn;
vars.value.selectedMonthOrderInLocal = selectedMonthOrderIn;
vars.value.selectedYearInLocal = selectedYearIn;
return OS.Flow.executeAsyncFlow(function () {
// No Selected Month?
if(((vars.value.selectedMonthInLocal === ""))) {
// Set Null Month
// SelectedMonth = NullTextIdentifier
vars.value.selectedMonthInLocal = OS.BuiltinFunctions.nullTextIdentifier();
}

// Invalid Year?
if(((vars.value.selectedYearInLocal === (-1)))) {
// Set Null Year
// SelectedYear = NullIdentifier
vars.value.selectedYearInLocal = OS.BuiltinFunctions.nullIdentifier();
}

// Trigger Event: OnSelected
return controller.onSelected$Action(vars.value.monthpickerIdInLocal, function () {
var rec = new OutSystemsUIModel.ST_71bc196daedd9ac0648bfd56a713859dStructure();
rec.monthAttr = OS.BuiltinFunctions.textToIdentifier(vars.value.selectedMonthInLocal);
rec.monthOrderAttr = vars.value.selectedMonthOrderInLocal;
rec.yearAttr = vars.value.selectedYearInLocal;
return rec;
}(), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onSelectedMonthHandler$Action;
}set _onSelectedMonthHandler$Action(value) {this.__onSelectedMonthHandler$Action = value;
}


onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "08109cc0-f954-48a2-94d0-af7e59f0d6d4");
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

initializedHandler$Action(monthpickerIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "19e4a025-4102-4917-9338-7f142a4b91f0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, monthpickerIdIn);
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
span.setAttribute("outsystems.function.key", "41e70982-d2e8-4a89-87c3-726eae0a8ae8");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "55134d98-171a-4e4e-a56a-181e306ad6c5");
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

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "6a963539-b472-4ef0-83ae-e7cb30a1ae49");
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

registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "a6925ab9-489c-4412-b894-f9c1ccbd4bb5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._registerCallbacks$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onRender$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnRender__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "b834a1b3-f184-4524-aacb-077f05c0c2ab");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onRender$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onSelectedMonthHandler$Action(monthpickerIdIn, selectedMonthIn, selectedMonthOrderIn, selectedYearIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSelectedMonthHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectedMonthHandler");
span.setAttribute("outsystems.function.key", "d4dfb979-540c-4e32-9391-eeee5ab93344");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSelectedMonthHandler$Action, callContext, monthpickerIdIn, selectedMonthIn, selectedMonthOrderIn, selectedYearIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
}

get onSelected$Action() {if(!(this.hasOwnProperty("_onSelected$Action"))) {
this._onSelected$Action = function () {
return Promise.resolve();
};
}

return this._onSelected$Action;
}set onSelected$Action(value) {this._onSelected$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.MonthPicker.InitializedHandler$vars", [{
name: "MonthpickerId",
attrName: "monthpickerIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.MonthPicker.RegisterCallbacks$getCallbackHandlersJSResult", [{
name: "OnSelected",
attrName: "onSelectedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnInitialized",
attrName: "onInitializedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.MonthPicker.OnSelectedMonthHandler$vars", [{
name: "MonthpickerId",
attrName: "monthpickerIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedMonth",
attrName: "selectedMonthInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedMonthOrder",
attrName: "selectedMonthOrderInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "SelectedYear",
attrName: "selectedYearInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




