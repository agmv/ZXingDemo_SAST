import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DatePickerRange_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DatePickerRange.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DatePickerRange_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.DatePickerRange.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DatePickerRange_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onChangeDateHandler$Action: function (datepickerIdIn, selectedStartDateIn, selectedEndDateIn) {
datepickerIdIn = (datepickerIdIn === undefined) ? "" : datepickerIdIn;
selectedStartDateIn = (selectedStartDateIn === undefined) ? "" : selectedStartDateIn;
selectedEndDateIn = (selectedEndDateIn === undefined) ? "" : selectedEndDateIn;
return controller.executeActionInsideJSNode(controller._onChangeDateHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(datepickerIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(selectedStartDateIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(selectedEndDateIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnChangeDateHandler");
},
initializedHandler$Action: function (datepickerIdIn) {
datepickerIdIn = (datepickerIdIn === undefined) ? "" : datepickerIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(datepickerIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "019302ec-c2ed-4441-bc88-eba2657a395e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// InitialStartDate?
if((!(model.variables.optionalConfigsIn.initialStartDateAttr.equals(OS.BuiltinFunctions.dateTimeToDate(model.variables.internal_ConfigsVar.initialStartDateAttr))))) {
// Set InitialStartDate
// Internal_Configs.InitialStartDate = OptionalConfigs.InitialStartDate
model.variables.internal_ConfigsVar.initialStartDateAttr = model.variables.optionalConfigsIn.initialStartDateAttr;
// Execute Action: Update_InitialStartDate
OutSystemsUIController.default.datePickerChangeDateTimeProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "InitialStartDate", model.variables.internal_ConfigsVar.initialStartDateAttr, callContext);
}

// InitialEndDate?
if((!(model.variables.optionalConfigsIn.initialEndDateAttr.equals(OS.BuiltinFunctions.dateTimeToDate(model.variables.internal_ConfigsVar.initialEndDateAttr))))) {
// Set InitialEndDate
// Internal_Configs.InitialEndDate = OptionalConfigs.InitialEndDate
model.variables.internal_ConfigsVar.initialEndDateAttr = model.variables.optionalConfigsIn.initialEndDateAttr;
// Execute Action: Update_InitialEndDate
OutSystemsUIController.default.datePickerChangeDateTimeProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "InitialEndDate", model.variables.internal_ConfigsVar.initialEndDateAttr, callContext);
}

// MinDate?
if((!(model.variables.optionalConfigsIn.minDateAttr.equals(OS.BuiltinFunctions.dateTimeToDate(model.variables.internal_ConfigsVar.minDateAttr))))) {
// Set MinDate
// Internal_Configs.MinDate = OptionalConfigs.MinDate
model.variables.internal_ConfigsVar.minDateAttr = model.variables.optionalConfigsIn.minDateAttr;
// Execute Action: Update_MinDate
OutSystemsUIController.default.datePickerChangeDateTimeProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "MinDate", model.variables.internal_ConfigsVar.minDateAttr, callContext);
}

// MaxDate?
if((!(model.variables.optionalConfigsIn.maxDateAttr.equals(OS.BuiltinFunctions.dateTimeToDate(model.variables.internal_ConfigsVar.maxDateAttr))))) {
// Set MaxDate
// Internal_Configs.MaxDate = OptionalConfigs.MaxDate
model.variables.internal_ConfigsVar.maxDateAttr = model.variables.optionalConfigsIn.maxDateAttr;
// Execute Action: Update_MaxDate
OutSystemsUIController.default.datePickerChangeDateTimeProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "MaxDate", model.variables.internal_ConfigsVar.maxDateAttr, callContext);
}

// InputDateFormat?
if((((model.variables.dateFormatIn) !== (model.variables.internal_ConfigsVar.dateFormatAttr)))) {
// Set InputDateFormat
// Internal_Configs.DateFormat = DateFormat
model.variables.internal_ConfigsVar.dateFormatAttr = model.variables.dateFormatIn;
// Execute Action: Update_DateFormat
OutSystemsUIController.default.datePickerChangeTextProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "DateFormat", model.variables.internal_ConfigsVar.dateFormatAttr, callContext);
}

// ShowTodayButton?
if((((model.variables.showTodayButtonIn) !== (model.variables.internal_ConfigsVar.showTodayButtonAttr)))) {
// Set ShowTodayButton
// Internal_Configs.ShowTodayButton = ShowTodayButton
model.variables.internal_ConfigsVar.showTodayButtonAttr = model.variables.showTodayButtonIn;
// Execute Action: Update_ShowTodayButton
OutSystemsUIController.default.datePickerChangeBooleanProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "ShowTodayButton", model.variables.internal_ConfigsVar.showTodayButtonAttr, callContext);
}

// FirstWeekDay?
if((((model.variables.optionalConfigsIn.firstWeekDayAttr) !== (model.variables.internal_ConfigsVar.firstWeekDayAttr)))) {
// Set FirstWeekDay
// Internal_Configs.FirstWeekDay = OptionalConfigs.FirstWeekDay
model.variables.internal_ConfigsVar.firstWeekDayAttr = model.variables.optionalConfigsIn.firstWeekDayAttr;
// Execute Action: Update_FirstWeekDay
OutSystemsUIController.default.datePickerChangeIntegerProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "FirstWeekDay", OS.BuiltinFunctions.integerToLongInteger(model.variables.internal_ConfigsVar.firstWeekDayAttr), callContext);
}

// ShowWeekNumbers?
if((((model.variables.optionalConfigsIn.showWeekNumbersAttr) !== (model.variables.internal_ConfigsVar.showWeekNumbersAttr)))) {
// Set ShowWeekNumbers
// Internal_Configs.ShowWeekNumbers = OptionalConfigs.ShowWeekNumbers
model.variables.internal_ConfigsVar.showWeekNumbersAttr = model.variables.optionalConfigsIn.showWeekNumbersAttr;
// Execute Action: Update_ShowWeekNumbers
OutSystemsUIController.default.datePickerChangeBooleanProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "ShowWeekNumbers", model.variables.internal_ConfigsVar.showWeekNumbersAttr, callContext);
}

// ExtendedClass?
if((((model.variables.extendedClassIn) !== (model.variables.internal_ConfigsVar.extendedClassAttr)))) {
// Set ExtendedClass
// Internal_Configs.ExtendedClass = ExtendedClass
model.variables.internal_ConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.datePickerChangeTextProperty$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internal_ConfigsVar.extendedClassAttr, callContext);
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

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (datepickerIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "0dac7de8-e03e-4c57-858c-36017f90f7ac");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.InitializedHandler$vars"))());
vars.value.datepickerIdInLocal = datepickerIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.datepickerIdInLocal, callContext);
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "12baa1c6-00d6-47ed-afbf-2871a2610852");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: DatePickerDestroy
OutSystemsUIController.default.datePickerDestroy$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
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
span.setAttribute("outsystems.function.key", "52bbd27d-9a1f-4627-bccd-67466478ab11");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: DatePickerInitialize
OutSystemsUIController.default.datePickerInitialize$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "DatePicker created", callContext);
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

get _onRender$Action() {if(!(this.hasOwnProperty("__onRender$Action"))) {
this.__onRender$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnRender", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "6920730f-6552-45de-bf62-86d97771ab69");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnRender");
callContext = controller.callContext(callContext);
// Execute Action: DatePickerOnRender
OutSystemsUIController.default.datePickerOnRender$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
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

get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "aa7da42f-5720-4b42-baab-04679b598ef0");
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
span.setAttribute("outsystems.function.key", "e2ce2bd3-a021-4541-af18-73a176fe2a49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DatePickerRange_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnChange: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnInitialize: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.RegisterCallbacks$getCallbackHandlersJSResult"))();
jsNodeResult.onChangeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnChange, OS.DataTypes.DataTypes.Object);
jsNodeResult.onInitializeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnInitialize, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnChangeDateHandler: controller.clientActionProxies.onChangeDateHandler$Action,
InitializedHandler: controller.clientActionProxies.initializedHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RegisterOnChange
OutSystemsUIController.default.datePickerRegisterCallback$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onChange, getCallbackHandlersJSResult.value.onChangeOut, callContext);
// Execute Action: RegisterOnInitialize
OutSystemsUIController.default.datePickerRegisterCallback$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlersJSResult.value.onInitializeOut, callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ae07e533-12f3-4883-95f5-3ff0a311f53e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create DatePicker", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);

// Execute Action: SetServerDateFormat2
OutSystemsUIController.default.setServerDateFormat$Action(callContext);
// Execute Action: SetLocalLanguage
OutSystemsUIController.default.setLocalLanguage$Action(callContext);
// Set Initial Configs
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.DateFormat = DateFormat
model.variables.internal_ConfigsVar.dateFormatAttr = model.variables.dateFormatIn;
// Internal_Configs.InitialStartDate = OptionalConfigs.InitialStartDate
model.variables.internal_ConfigsVar.initialStartDateAttr = model.variables.optionalConfigsIn.initialStartDateAttr;
// Internal_Configs.ShowTodayButton = ShowTodayButton
model.variables.internal_ConfigsVar.showTodayButtonAttr = model.variables.showTodayButtonIn;
// Internal_Configs.InitialEndDate = OptionalConfigs.InitialEndDate
model.variables.internal_ConfigsVar.initialEndDateAttr = model.variables.optionalConfigsIn.initialEndDateAttr;
// Internal_Configs.FirstWeekDay = OptionalConfigs.FirstWeekDay
model.variables.internal_ConfigsVar.firstWeekDayAttr = model.variables.optionalConfigsIn.firstWeekDayAttr;
// Internal_Configs.MinDate = OptionalConfigs.MinDate
model.variables.internal_ConfigsVar.minDateAttr = model.variables.optionalConfigsIn.minDateAttr;
// Internal_Configs.MaxDate = OptionalConfigs.MaxDate
model.variables.internal_ConfigsVar.maxDateAttr = model.variables.optionalConfigsIn.maxDateAttr;
// Internal_Configs.ShowWeekNumbers = OptionalConfigs.ShowWeekNumbers
model.variables.internal_ConfigsVar.showWeekNumbersAttr = model.variables.optionalConfigsIn.showWeekNumbersAttr;
// Internal_Configs.ExtendedClass = ExtendedClass
model.variables.internal_ConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar, true, false);
// Execute Action: DatePickerCreate
OutSystemsUIController.default.datePickerCreate$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, OutSystemsUIModel.staticEntities.datePickerCalendarType.range, OutSystemsUIModel.staticEntities.datePickerProvider.flatpickr, callContext);
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

get _onChangeDateHandler$Action() {if(!(this.hasOwnProperty("__onChangeDateHandler$Action"))) {
this.__onChangeDateHandler$Action = function (datepickerIdIn, selectedStartDateIn, selectedEndDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnChangeDateHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeDateHandler");
span.setAttribute("outsystems.function.key", "afe56a1c-3bcd-4a0b-9637-acaa9d40feea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChangeDateHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.OnChangeDateHandler$vars"))());
vars.value.datepickerIdInLocal = datepickerIdIn;
vars.value.selectedStartDateInLocal = selectedStartDateIn;
vars.value.selectedEndDateInLocal = selectedEndDateIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnSelected
return controller.onSelected$Action(vars.value.datepickerIdInLocal, OS.BuiltinFunctions.textToDate(vars.value.selectedStartDateInLocal), OS.BuiltinFunctions.textToDate(vars.value.selectedEndDateInLocal), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onChangeDateHandler$Action;
}set _onChangeDateHandler$Action(value) {this.__onChangeDateHandler$Action = value;
}


onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "019302ec-c2ed-4441-bc88-eba2657a395e");
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

initializedHandler$Action(datepickerIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "0dac7de8-e03e-4c57-858c-36017f90f7ac");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, datepickerIdIn);
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
span.setAttribute("outsystems.function.key", "12baa1c6-00d6-47ed-afbf-2871a2610852");
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
span.setAttribute("outsystems.function.key", "52bbd27d-9a1f-4627-bccd-67466478ab11");
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

onRender$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnRender__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "6920730f-6552-45de-bf62-86d97771ab69");
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

registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "aa7da42f-5720-4b42-baab-04679b598ef0");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ae07e533-12f3-4883-95f5-3ff0a311f53e");
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

onChangeDateHandler$Action(datepickerIdIn, selectedStartDateIn, selectedEndDateIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnChangeDateHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeDateHandler");
span.setAttribute("outsystems.function.key", "afe56a1c-3bcd-4a0b-9637-acaa9d40feea");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onChangeDateHandler$Action, callContext, datepickerIdIn, selectedStartDateIn, selectedEndDateIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onSelected$Action() {if(!(this.hasOwnProperty("_onSelected$Action"))) {
this._onSelected$Action = function () {
return Promise.resolve();
};
}

return this._onSelected$Action;
}set onSelected$Action(value) {this._onSelected$Action = value;
}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.InitializedHandler$vars", [{
name: "DatepickerId",
attrName: "datepickerIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.RegisterCallbacks$getCallbackHandlersJSResult", [{
name: "OnChange",
attrName: "onChangeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnInitialize",
attrName: "onInitializeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DatePickerRange.OnChangeDateHandler$vars", [{
name: "DatepickerId",
attrName: "datepickerIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedStartDate",
attrName: "selectedStartDateInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedEndDate",
attrName: "selectedEndDateInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




