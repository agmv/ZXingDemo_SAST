import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_JsParseEventsJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.Init.JsParseEventsJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_ParseDisabledDatesJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.Init.ParseDisabledDatesJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_JsInitJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.Init.JsInitJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnParametersChanged_JsCheckObjectStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.OnParametersChanged.JsCheckObjectStatusJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnDestroy_JsCallDestroyFunctionJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.OnDestroy.JsCallDestroyFunctionJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_CheckFieldValue_JsGetFieldValueJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.CheckFieldValue.JsGetFieldValueJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnReady_JsGetInputTypeJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.OnReady.JsGetInputTypeJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_CheckValueOnFormValidation_JsSetValueAfterFormValidationJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.CheckValueOnFormValidation.JsSetValueAfterFormValidationJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Observer_JsObserverJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.Observer.JsObserverJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_SetValue_JsSetValueJS from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.SetValue.JsSetValueJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
selectDate$Action: function (calendarDateIn) {
calendarDateIn = (calendarDateIn === undefined) ? OS.DataTypes.DateTime.defaultValue : calendarDateIn;
return controller.executeActionInsideJSNode(controller._selectDate$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(calendarDateIn, OS.DataTypes.DataTypes.DateTime)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SelectDate");
},
checkFieldValue$Action: function () {
return controller.executeActionInsideJSNode(controller._checkFieldValue$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "CheckFieldValue");
},
checkValueOnFormValidation$Action: function (dateFormatParamIn) {
dateFormatParamIn = (dateFormatParamIn === undefined) ? "" : dateFormatParamIn;
return controller.executeActionInsideJSNode(controller._checkValueOnFormValidation$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(dateFormatParamIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "CheckValueOnFormValidation");
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
get _selectDate$Action() {if(!(this.hasOwnProperty("__selectDate$Action"))) {
this.__selectDate$Action = function (calendarDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SelectDate", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDate");
span.setAttribute("outsystems.function.key", "160a0e7c-83e6-4a60-99b8-8a27f81f1042");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SelectDate");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.SelectDate$vars"))());
vars.value.calendarDateInLocal = calendarDateIn;
return OS.Flow.executeAsyncFlow(function () {
// Set Selected date and Field as filled in
// SelectedDate = CalendarDate
model.variables.selectedDateVar = vars.value.calendarDateInLocal;
// IsFieldEmpty = False
model.variables.isFieldEmptyVar = false;
return OS.Flow.executeSequence(function () {
if((model.variables.selectIntervalIn)) {
// StartDate not null?
if((!(model.variables.startDateVar.equals(OS.BuiltinFunctions.nullDate())))) {
// EndDate = SelectedDate
model.variables.endDateVar = model.variables.selectedDateVar;
if((model.variables.startDateVar.gt(model.variables.endDateVar))) {
// Set Start and EndDate
// EndDate = StartDate
model.variables.endDateVar = model.variables.startDateVar;
// StartDate = SelectedDate
model.variables.startDateVar = model.variables.selectedDateVar;
}

} else {
// Set StartDate
// StartDate = SelectedDate
model.variables.startDateVar = model.variables.selectedDateVar;
}

// Trigger Event: OnSelectInterval
return controller.onSelect$Action(model.variables.startDateVar, model.variables.endDateVar, callContext);
} else {
// Set StartDate
// StartDate = SelectedDate
model.variables.startDateVar = model.variables.selectedDateVar;
// Trigger Event: OnSelect
return controller.onSelect$Action(model.variables.startDateVar, OS.BuiltinFunctions.nullDate(), callContext);
}

}).then(function () {
// Execute Action: SetValue
controller._setValue$Action(callContext);
// Is Select Interval?
if((model.variables.selectIntervalIn)) {
// EndDate null?
if((!(model.variables.endDateVar.equals(OS.BuiltinFunctions.nullDate())))) {
// Reset Dates
// StartDate = NullDate
model.variables.startDateVar = OS.BuiltinFunctions.nullDate();
// EndDate = NullDate
model.variables.endDateVar = OS.BuiltinFunctions.nullDate();
}

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

return this.__selectDate$Action;
}set _selectDate$Action(value) {this.__selectDate$Action = value;
}

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "21b4759d-75e4-4adf-b669-c7d970b7df76");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var dEPRECATED_DatepickerExposeTranslationsVar = new OS.DataTypes.VariableHolder();
var jsParseEventsJSResult = new OS.DataTypes.VariableHolder();
var parseDisabledDatesJSResult = new OS.DataTypes.VariableHolder();
var jsInitJSResult = new OS.DataTypes.VariableHolder();
var serializeDisabledDatesVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var serializeEventsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: SerializeEvents
serializeEventsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.eventListIn, true, false, OS.DataTypes.DataTypes.DateTime);
// JSON Serialize: SerializeDisabledDates
serializeDisabledDatesVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.disabledDaysListIn, true, false, OS.DataTypes.DataTypes.DateTime);
// Script responsible for parsing the inputted events.
jsParseEventsJSResult.value = OS.Logger.startActiveSpan("JsParseEvents", function (span) {
if(span) {
span.setAttribute("code.function", "JsParseEvents");
span.setAttribute("outsystems.function.key", "0420e0ac-4b64-42ce-b5d1-dadd2bba0281");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_JsParseEventsJS, "JsParseEvents", "Init", {
EventList: OS.DataConversion.JSNodeParamConverter.to(serializeEventsVar.value.jSONOut, OS.DataTypes.DataTypes.Text),
Events: OS.DataConversion.JSNodeParamConverter.to("", OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$jsParseEventsJSResult"))();
jsNodeResult.eventsOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Events, OS.DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Script responsible for parsing the inputted disabled dates.
parseDisabledDatesJSResult.value = OS.Logger.startActiveSpan("ParseDisabledDates", function (span) {
if(span) {
span.setAttribute("code.function", "ParseDisabledDates");
span.setAttribute("outsystems.function.key", "79d108f5-767d-4e9c-930e-b449ea42b5d3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_ParseDisabledDatesJS, "ParseDisabledDates", "Init", {
EventList: OS.DataConversion.JSNodeParamConverter.to(serializeDisabledDatesVar.value.jSONOut, OS.DataTypes.DataTypes.Text),
DisabledDates: OS.DataConversion.JSNodeParamConverter.to("", OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$parseDisabledDatesJSResult"))();
jsNodeResult.disabledDatesOut = OS.DataConversion.JSNodeParamConverter.from($parameters.DisabledDates, OS.DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set IsBound
// IsBound = If
model.variables.isBoundVar = ((((model.variables.inputWidgetIdIn === "") && (model.variables.buttonWidgetIdIn === ""))) ? (false) : (true));
// Execute Action: DEPRECATED_DatepickerExposeTranslations
dEPRECATED_DatepickerExposeTranslationsVar.value = OutSystemsUIController.default.dEPRECATED_DatepickerExposeTranslations$Action(callContext);

// Execute Action: Observer
controller._observer$Action(callContext);
// Script responsible to initialize the calendar object.
jsInitJSResult.value = OS.Logger.startActiveSpan("JsInit", function (span) {
if(span) {
span.setAttribute("code.function", "JsInit");
span.setAttribute("outsystems.function.key", "85f274f3-e8c2-4a35-bdfd-f343774ebe76");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Init_JsInitJS, "JsInit", "Init", {
TranslateMidnight: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).midnightAttr, OS.DataTypes.DataTypes.Text),
TranslateNavigation: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).navigationAttr, OS.DataTypes.DataTypes.Text),
TranslateDaysInRange: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).daysInRangeAttr, OS.DataTypes.DataTypes.Text),
TranslateYear: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).yearAttr, OS.DataTypes.DataTypes.Text),
DisabledWeekDays: OS.DataConversion.JSNodeParamConverter.to(model.variables.disabledWeekDaysIn, OS.DataTypes.DataTypes.Text),
Format: OS.DataConversion.JSNodeParamConverter.to(model.variables.dateFormatIn, OS.DataTypes.DataTypes.Text),
TranslateCalendarDates: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).calendarDatesAttr, OS.DataTypes.DataTypes.Text),
selectInterval: OS.DataConversion.JSNodeParamConverter.to(model.variables.selectIntervalIn, OS.DataTypes.DataTypes.Boolean),
FirstDay: OS.DataConversion.JSNodeParamConverter.to(model.variables.firstWeekDayIn, OS.DataTypes.DataTypes.Integer),
TranslateDaySelected: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).daySelectedAttr, OS.DataTypes.DataTypes.Text),
ShowWeekNumbers: OS.DataConversion.JSNodeParamConverter.to(model.variables.showWeekNumbersIn, OS.DataTypes.DataTypes.Boolean),
TranslateNextMonth: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).nextMonthAttr, OS.DataTypes.DataTypes.Text),
TranslateCloseCalendar: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).closeCalendarAttr, OS.DataTypes.DataTypes.Text),
TranslateGoToToday: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).goToTodayAttr, OS.DataTypes.DataTypes.Text),
InputWidgetid: OS.DataConversion.JSNodeParamConverter.to((((model.variables.inputWidgetIdIn === "")) ? (idService.getId("DateInput")) : (model.variables.inputWidgetIdIn)), OS.DataTypes.DataTypes.Text),
TranslateIsDisabled: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).isDisabledAttr, OS.DataTypes.DataTypes.Text),
TranslateCalendar: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).calendarAttr, OS.DataTypes.DataTypes.Text),
TranslateDateSelected: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).dateSelectedAttr, OS.DataTypes.DataTypes.Text),
TranslateWeekdaysShort: OS.DataConversion.JSNodeParamConverter.to((((((((((((((dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort1Attr + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort2Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort3Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort4Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort5Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort6Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysShortAttr.getCurrent(callContext.iterationContext).weekdayShort7Attr) + ","), OS.DataTypes.DataTypes.Text),
CalendarId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Calendar"), OS.DataTypes.DataTypes.Text),
Events: OS.DataConversion.JSNodeParamConverter.to(jsParseEventsJSResult.value.eventsOut, OS.DataTypes.DataTypes.Text),
TranslateTodayButton: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).todayButtonAttr, OS.DataTypes.DataTypes.Text),
TranslatePreviousMonth: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).previousMonthAttr, OS.DataTypes.DataTypes.Text),
TranslateEndRange: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).endRangeAttr, OS.DataTypes.DataTypes.Text),
AdvancedFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.advancedFormatIn, OS.DataTypes.DataTypes.Text),
IsBound: OS.DataConversion.JSNodeParamConverter.to(model.variables.isBoundVar, OS.DataTypes.DataTypes.Boolean),
showTodayButton: OS.DataConversion.JSNodeParamConverter.to(model.variables.showTodayButtonIn, OS.DataTypes.DataTypes.Boolean),
ButtonWidgetId: OS.DataConversion.JSNodeParamConverter.to(model.variables.buttonWidgetIdIn, OS.DataTypes.DataTypes.Text),
MinDate: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.dateTimeToDate(model.variables.minDateIn), OS.DataTypes.DataTypes.Date),
MaxDate: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.dateTimeToDate(model.variables.maxDateIn), OS.DataTypes.DataTypes.Date),
TranslateOpenCalendar: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).openCalendarAttr, OS.DataTypes.DataTypes.Text),
TranslateMonthPrevious: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).monthPreviousAttr, OS.DataTypes.DataTypes.Text),
TranslateHasEvent: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).hasEventAttr, OS.DataTypes.DataTypes.Text),
TranslateMonths: OS.DataConversion.JSNodeParamConverter.to((((((((((((((((((((((((dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month1Attr + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month2Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month3Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month4Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month5Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month6Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month7Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month8Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month9Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month10Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month11Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).monthsAttr.getCurrent(callContext.iterationContext).month12Attr) + ","), OS.DataTypes.DataTypes.Text),
TranslateShortcutsDialog: OS.DataConversion.JSNodeParamConverter.to((((((((((((((((dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog1Attr + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog2Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog3Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog4Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog5Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog6Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog7Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).shortcutsDialogAttr.getCurrent(callContext.iterationContext).shortcutsDialog8Attr) + ","), OS.DataTypes.DataTypes.Text),
DisabledDates: OS.DataConversion.JSNodeParamConverter.to(parseDisabledDatesJSResult.value.disabledDatesOut, OS.DataTypes.DataTypes.Text),
TranslateNoon: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).noonAttr, OS.DataTypes.DataTypes.Text),
TranslateIsToday: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).isTodayAttr, OS.DataTypes.DataTypes.Text),
Show24HourFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.show24HourFormatIn, OS.DataTypes.DataTypes.Boolean),
InitialDate: OS.DataConversion.JSNodeParamConverter.to(model.variables.initialDateIn, OS.DataTypes.DataTypes.DateTime),
TranslateMonth: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).monthAttr, OS.DataTypes.DataTypes.Text),
TranslateEnterCalendar: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).enterCalendarAttr, OS.DataTypes.DataTypes.Text),
FieldType: OS.DataConversion.JSNodeParamConverter.to(model.variables.fieldTypeVar, OS.DataTypes.DataTypes.Text),
TranslateMonthNext: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).monthNextAttr, OS.DataTypes.DataTypes.Text),
ShowTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.showTimeIn, OS.DataTypes.DataTypes.Boolean),
TranslateKeyboardShortcuts: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).keyboardShortcutsAttr, OS.DataTypes.DataTypes.Text),
TranslateWeekdays: OS.DataConversion.JSNodeParamConverter.to((((((((((((((dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday1Attr + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday2Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday3Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday4Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday5Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday6Attr) + ",") + dEPRECATED_DatepickerExposeTranslationsVar.value.i18nDefaultsOut.getCurrent(callContext.iterationContext).weekdaysAttr.getCurrent(callContext.iterationContext).weekday7Attr) + ","), OS.DataTypes.DataTypes.Text),
StartEmpty: OS.DataConversion.JSNodeParamConverter.to(model.variables.startEmptyIn, OS.DataTypes.DataTypes.Boolean),
TranslateDialogButton: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).dialogButtonAttr, OS.DataTypes.DataTypes.Text),
TranslateStartRange: OS.DataConversion.JSNodeParamConverter.to(dEPRECATED_DatepickerExposeTranslationsVar.value.i18nAccessibilityOut.getCurrent(callContext.iterationContext).startRangeAttr, OS.DataTypes.DataTypes.Text),
CalendarObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
disableInputOverride: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
ObserverFormClassObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$jsInitJSResult"))();
jsNodeResult.calendarObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.CalendarObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.disableInputOverrideOut = OS.DataConversion.JSNodeParamConverter.from($parameters.disableInputOverride, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.observerFormClassObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObserverFormClassObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
SelectDate: controller.clientActionProxies.selectDate$Action,
CheckFieldValue: controller.clientActionProxies.checkFieldValue$Action,
CheckValueOnFormValidation: controller.clientActionProxies.checkValueOnFormValidation$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set Objects
// CalendarObj = JsInit.CalendarObj
model.variables.calendarObjVar = jsInitJSResult.value.calendarObjOut;
// DisableInputOverride = JsInit.disableInputOverride
model.variables.disableInputOverrideVar = jsInitJSResult.value.disableInputOverrideOut;
// ObserverFormClassObj = JsInit.ObserverFormClassObj
model.variables.observerFormClassObjVar = jsInitJSResult.value.observerFormClassObjOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__init$Action;
}set _init$Action(value) {this.__init$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "495909b7-aacb-4ef5-9192-2b8fb10043a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var jsCheckObjectStatusJSResult = new OS.DataTypes.VariableHolder();
// Script to check if the calendar object exists.
jsCheckObjectStatusJSResult.value = OS.Logger.startActiveSpan("JsCheckObjectStatus", function (span) {
if(span) {
span.setAttribute("code.function", "JsCheckObjectStatus");
span.setAttribute("outsystems.function.key", "d99f7070-38ff-4ba1-878b-10586ed8366d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnParametersChanged_JsCheckObjectStatusJS, "JsCheckObjectStatus", "OnParametersChanged", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.calendarObjVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.OnParametersChanged$jsCheckObjectStatusJSResult"))();
jsNodeResult.objectIsDefinedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObjectIsDefined, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Is Calendar Object Defined?
if((jsCheckObjectStatusJSResult.value.objectIsDefinedOut)) {
// Execute Action: OnDestroy
controller._onDestroy$Action(callContext);
}

// Execute Action: Init
controller._init$Action(callContext);
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
span.setAttribute("outsystems.function.key", "4c188fc8-744d-4b10-8aa7-2217a97f4d31");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Script to destroy the calendar object and disconnect all existent observers.
OS.Logger.startActiveSpan("JsCallDestroyFunction", function (span) {
if(span) {
span.setAttribute("code.function", "JsCallDestroyFunction");
span.setAttribute("outsystems.function.key", "7d07cf2b-7720-41e9-9af7-f4c46996eb02");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnDestroy_JsCallDestroyFunctionJS, "JsCallDestroyFunction", "OnDestroy", {
ObserverLangObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.observerLangObjVar, OS.DataTypes.DataTypes.Object),
CalendarObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.calendarObjVar, OS.DataTypes.DataTypes.Object),
ObserverFormClassObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.observerFormClassObjVar, OS.DataTypes.DataTypes.Object)
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

get _checkFieldValue$Action() {if(!(this.hasOwnProperty("__checkFieldValue$Action"))) {
this.__checkFieldValue$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CheckFieldValue", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFieldValue");
span.setAttribute("outsystems.function.key", "79c06614-0874-46e5-8940-bb4b491f829b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckFieldValue");
callContext = controller.callContext(callContext);
var jsGetFieldValueJSResult = new OS.DataTypes.VariableHolder();
// Script to check the value on the input field.
jsGetFieldValueJSResult.value = OS.Logger.startActiveSpan("JsGetFieldValue", function (span) {
if(span) {
span.setAttribute("code.function", "JsGetFieldValue");
span.setAttribute("outsystems.function.key", "197a69b2-ff37-4204-a786-00ab3a230dca");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_CheckFieldValue_JsGetFieldValueJS, "JsGetFieldValue", "CheckFieldValue", {
InputWidgetId: OS.DataConversion.JSNodeParamConverter.to((((model.variables.inputWidgetIdIn === "")) ? (idService.getId("DateInput")) : (model.variables.inputWidgetIdIn)), OS.DataTypes.DataTypes.Text),
FieldValue: OS.DataConversion.JSNodeParamConverter.to("", OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.CheckFieldValue$jsGetFieldValueJSResult"))();
jsNodeResult.fieldValueOut = OS.DataConversion.JSNodeParamConverter.from($parameters.FieldValue, OS.DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Has Value?
if((!(((jsGetFieldValueJSResult.value.fieldValueOut) !== (""))))) {
// Set as Empty
// IsFieldEmpty = True
model.variables.isFieldEmptyVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__checkFieldValue$Action;
}set _checkFieldValue$Action(value) {this.__checkFieldValue$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "9141a2b0-7e45-4fc9-a6d3-ef88a25b4a9b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var jsGetInputTypeJSResult = new OS.DataTypes.VariableHolder();
// Script to get the input type.
jsGetInputTypeJSResult.value = OS.Logger.startActiveSpan("JsGetInputType", function (span) {
if(span) {
span.setAttribute("code.function", "JsGetInputType");
span.setAttribute("outsystems.function.key", "cc0d033a-d193-405d-951d-d84e9d59a8d5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_OnReady_JsGetInputTypeJS, "JsGetInputType", "OnReady", {
InputWidgetId: OS.DataConversion.JSNodeParamConverter.to((((model.variables.inputWidgetIdIn === "")) ? (idService.getId("DateInput")) : (model.variables.inputWidgetIdIn)), OS.DataTypes.DataTypes.Text),
FieldType: OS.DataConversion.JSNodeParamConverter.to("", OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.OnReady$jsGetInputTypeJSResult"))();
jsNodeResult.fieldTypeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.FieldType, OS.DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set FieldType
// FieldType = JsGetInputType.FieldType
model.variables.fieldTypeVar = jsGetInputTypeJSResult.value.fieldTypeOut;
// Execute Action: Init
controller._init$Action(callContext);
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

get _checkValueOnFormValidation$Action() {if(!(this.hasOwnProperty("__checkValueOnFormValidation$Action"))) {
this.__checkValueOnFormValidation$Action = function (dateFormatParamIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CheckValueOnFormValidation", function (span) {
if(span) {
span.setAttribute("code.function", "CheckValueOnFormValidation");
span.setAttribute("outsystems.function.key", "b1edafc4-4790-4ea6-891a-a14feae0a18e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckValueOnFormValidation");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.CheckValueOnFormValidation$vars"))());
vars.value.dateFormatParamInLocal = dateFormatParamIn;
// No Date or Empty Field?
if(((model.variables.selectedDateVar.equals(OS.BuiltinFunctions.nullDate()) || model.variables.isFieldEmptyVar))) {
// Set IsNull
// IsNull = True
vars.value.isNullVar = true;
}

// Script to set the value after the form validation ran.
OS.Logger.startActiveSpan("JsSetValueAfterFormValidation", function (span) {
if(span) {
span.setAttribute("code.function", "JsSetValueAfterFormValidation");
span.setAttribute("outsystems.function.key", "88af8f21-31cb-43d7-af7f-ab4fc3cf1a35");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_CheckValueOnFormValidation_JsSetValueAfterFormValidationJS, "JsSetValueAfterFormValidation", "CheckValueOnFormValidation", {
SelectedDate: OS.DataConversion.JSNodeParamConverter.to(model.variables.selectedDateVar, OS.DataTypes.DataTypes.DateTime),
IsNull: OS.DataConversion.JSNodeParamConverter.to(vars.value.isNullVar, OS.DataTypes.DataTypes.Boolean),
DateFormat: OS.DataConversion.JSNodeParamConverter.to(vars.value.dateFormatParamInLocal, OS.DataTypes.DataTypes.Text),
Obj: OS.DataConversion.JSNodeParamConverter.to(model.variables.calendarObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__checkValueOnFormValidation$Action;
}set _checkValueOnFormValidation$Action(value) {this.__checkValueOnFormValidation$Action = value;
}

get _observer$Action() {if(!(this.hasOwnProperty("__observer$Action"))) {
this.__observer$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Observer", function (span) {
if(span) {
span.setAttribute("code.function", "Observer");
span.setAttribute("outsystems.function.key", "bc0ccfd0-5803-4926-9000-0d48325aa21c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Observer");
callContext = controller.callContext(callContext);
var jsObserverJSResult = new OS.DataTypes.VariableHolder();
// Script responsible to initialize the observer for the document language.
jsObserverJSResult.value = OS.Logger.startActiveSpan("JsObserver", function (span) {
if(span) {
span.setAttribute("code.function", "JsObserver");
span.setAttribute("outsystems.function.key", "35422029-14f1-4ca2-a961-97bfcad57085");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_Observer_JsObserverJS, "JsObserver", "Observer", {
ObserverLangObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Observer$jsObserverJSResult"))();
jsNodeResult.observerLangObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObserverLangObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnParametersChanged: controller.clientActionProxies.onParametersChanged$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Store ObserverLangObj
// ObserverLangObj = JsObserver.ObserverLangObj
model.variables.observerLangObjVar = jsObserverJSResult.value.observerLangObjOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__observer$Action;
}set _observer$Action(value) {this.__observer$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c1181714-d5e5-4119-a635-e74ff93a5d69");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// MaxDate null?
if((model.variables.maxDateIn.equals(OS.BuiltinFunctions.nullDate()))) {
// Set MaxDate
// MaxDate = AddYears
model.variables.maxDateIn = OS.BuiltinFunctions.addYears(OS.BuiltinFunctions.currDateTime(), 100);
}

// InitialDate null?
if((model.variables.initialDateIn.equals(OS.BuiltinFunctions.nullDate()))) {
// Set InitialDate
// InitialDate = CurrDateTime
model.variables.initialDateIn = OS.BuiltinFunctions.currDateTime();
}

// Start with value?
if(((!(model.variables.startEmptyIn)))) {
// Set SelectedDate
// SelectedDate = InitialDate
model.variables.selectedDateVar = model.variables.initialDateIn;
}

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

get _setValue$Action() {if(!(this.hasOwnProperty("__setValue$Action"))) {
this.__setValue$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetValue", function (span) {
if(span) {
span.setAttribute("code.function", "SetValue");
span.setAttribute("outsystems.function.key", "fc2204db-22af-4387-a976-a07b968107aa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetValue");
callContext = controller.callContext(callContext);
// Script to set an input value.
OS.Logger.startActiveSpan("JsSetValue", function (span) {
if(span) {
span.setAttribute("code.function", "JsSetValue");
span.setAttribute("outsystems.function.key", "5dd8a0df-c33f-47b1-8384-66fffc70ae49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DatePicker_mvc_controller_SetValue_JsSetValueJS, "JsSetValue", "SetValue", {
ShowTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.showTimeIn, OS.DataTypes.DataTypes.Boolean),
FieldType: OS.DataConversion.JSNodeParamConverter.to(model.variables.fieldTypeVar, OS.DataTypes.DataTypes.Text),
IsInputBounded: OS.DataConversion.JSNodeParamConverter.to(((model.variables.inputWidgetIdIn) !== ("")), OS.DataTypes.DataTypes.Boolean),
CalendarObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.calendarObjVar, OS.DataTypes.DataTypes.Object),
InputWidgetId: OS.DataConversion.JSNodeParamConverter.to((((model.variables.inputWidgetIdIn === "")) ? (idService.getId("DateInput")) : (model.variables.inputWidgetIdIn)), OS.DataTypes.DataTypes.Text),
IsEndDateNull: OS.DataConversion.JSNodeParamConverter.to(model.variables.endDateVar.equals(OS.BuiltinFunctions.nullDate()), OS.DataTypes.DataTypes.Boolean),
IsInterval: OS.DataConversion.JSNodeParamConverter.to(model.variables.selectIntervalIn, OS.DataTypes.DataTypes.Boolean),
CurrentStartDate: OS.DataConversion.JSNodeParamConverter.to(((model.variables.showTimeIn) ? (model.variables.startDateVar) : (OS.BuiltinFunctions.dateTimeToDate(model.variables.startDateVar))), OS.DataTypes.DataTypes.DateTime),
disableInputOverride: OS.DataConversion.JSNodeParamConverter.to(model.variables.disableInputOverrideVar, OS.DataTypes.DataTypes.Boolean),
Format: OS.DataConversion.JSNodeParamConverter.to(model.variables.dateFormatIn, OS.DataTypes.DataTypes.Text),
CurrentEndDate: OS.DataConversion.JSNodeParamConverter.to(((model.variables.showTimeIn) ? (model.variables.endDateVar) : (OS.BuiltinFunctions.dateTimeToDate(model.variables.endDateVar))), OS.DataTypes.DataTypes.DateTime)
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

return this.__setValue$Action;
}set _setValue$Action(value) {this.__setValue$Action = value;
}


selectDate$Action(calendarDateIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SelectDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDate");
span.setAttribute("outsystems.function.key", "160a0e7c-83e6-4a60-99b8-8a27f81f1042");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._selectDate$Action, callContext, calendarDateIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

init$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "21b4759d-75e4-4adf-b669-c7d970b7df76");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._init$Action, callContext);
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
span.setAttribute("outsystems.function.key", "495909b7-aacb-4ef5-9192-2b8fb10043a4");
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
span.setAttribute("outsystems.function.key", "4c188fc8-744d-4b10-8aa7-2217a97f4d31");
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

checkFieldValue$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CheckFieldValue__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFieldValue");
span.setAttribute("outsystems.function.key", "79c06614-0874-46e5-8940-bb4b491f829b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkFieldValue$Action, callContext);
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
span.setAttribute("outsystems.function.key", "9141a2b0-7e45-4fc9-a6d3-ef88a25b4a9b");
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

checkValueOnFormValidation$Action(dateFormatParamIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CheckValueOnFormValidation__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckValueOnFormValidation");
span.setAttribute("outsystems.function.key", "b1edafc4-4790-4ea6-891a-a14feae0a18e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkValueOnFormValidation$Action, callContext, dateFormatParamIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

observer$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Observer__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Observer");
span.setAttribute("outsystems.function.key", "bc0ccfd0-5803-4926-9000-0d48325aa21c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._observer$Action, callContext);
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
span.setAttribute("outsystems.function.key", "c1181714-d5e5-4119-a635-e74ff93a5d69");
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

setValue$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetValue__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetValue");
span.setAttribute("outsystems.function.key", "fc2204db-22af-4387-a976-a07b968107aa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setValue$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onSelect$Action() {if(!(this.hasOwnProperty("_onSelect$Action"))) {
this._onSelect$Action = function () {
return Promise.resolve();
};
}

return this._onSelect$Action;
}set onSelect$Action(value) {this._onSelect$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.SelectDate$vars", [{
name: "CalendarDate",
attrName: "calendarDateInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS.DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$jsParseEventsJSResult", [{
name: "Events",
attrName: "eventsOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$parseDisabledDatesJSResult", [{
name: "DisabledDates",
attrName: "disabledDatesOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Init$jsInitJSResult", [{
name: "CalendarObj",
attrName: "calendarObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "disableInputOverride",
attrName: "disableInputOverrideOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ObserverFormClassObj",
attrName: "observerFormClassObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.OnParametersChanged$jsCheckObjectStatusJSResult", [{
name: "ObjectIsDefined",
attrName: "objectIsDefinedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.CheckFieldValue$jsGetFieldValueJSResult", [{
name: "FieldValue",
attrName: "fieldValueOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.OnReady$jsGetInputTypeJSResult", [{
name: "FieldType",
attrName: "fieldTypeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.CheckValueOnFormValidation$vars", [{
name: "DateFormatParam",
attrName: "dateFormatParamInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsNull",
attrName: "isNullVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DatePicker.Observer$jsObserverJSResult", [{
name: "ObserverLangObj",
attrName: "observerLangObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




