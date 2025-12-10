import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("CalendarObj", "calendarObjVar", "CalendarObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("SelectedDate", "selectedDateVar", "SelectedDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("StartDate", "startDateVar", "StartDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("EndDate", "endDateVar", "EndDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("InputVar", "inputVarVar", "InputVar", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsBound", "isBoundVar", "IsBound", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FieldType", "fieldTypeVar", "FieldType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsFieldEmpty", "isFieldEmptyVar", "IsFieldEmpty", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DisableInputOverride", "disableInputOverrideVar", "DisableInputOverride", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ObserverLangObj", "observerLangObjVar", "ObserverLangObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("ObserverFormClassObj", "observerFormClassObjVar", "ObserverFormClassObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("InputWidgetId", "inputWidgetIdIn", "InputWidgetId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_inputWidgetIdInDataFetchStatus", "_inputWidgetIdInDataFetchStatus", "_inputWidgetIdInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ButtonWidgetId", "buttonWidgetIdIn", "ButtonWidgetId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_buttonWidgetIdInDataFetchStatus", "_buttonWidgetIdInDataFetchStatus", "_buttonWidgetIdInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("EventList", "eventListIn", "EventList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.DateTimeList());
}, false, OS.DataTypes.DateTimeList), 
this.attr("_eventListInDataFetchStatus", "_eventListInDataFetchStatus", "_eventListInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MinDate", "minDateIn", "MinDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_minDateInDataFetchStatus", "_minDateInDataFetchStatus", "_minDateInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxDate", "maxDateIn", "MaxDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_maxDateInDataFetchStatus", "_maxDateInDataFetchStatus", "_maxDateInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InitialDate", "initialDateIn", "InitialDate", true, false, OS.DataTypes.DataTypes.DateTime, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_initialDateInDataFetchStatus", "_initialDateInDataFetchStatus", "_initialDateInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowWeekNumbers", "showWeekNumbersIn", "ShowWeekNumbers", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showWeekNumbersInDataFetchStatus", "_showWeekNumbersInDataFetchStatus", "_showWeekNumbersInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("FirstWeekDay", "firstWeekDayIn", "FirstWeekDay", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("_firstWeekDayInDataFetchStatus", "_firstWeekDayInDataFetchStatus", "_firstWeekDayInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowTime", "showTimeIn", "ShowTime", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showTimeInDataFetchStatus", "_showTimeInDataFetchStatus", "_showTimeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Show24HourFormat", "show24HourFormatIn", "Show24HourFormat", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_show24HourFormatInDataFetchStatus", "_show24HourFormatInDataFetchStatus", "_show24HourFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("DisabledDaysList", "disabledDaysListIn", "DisabledDaysList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.DateTimeList());
}, false, OS.DataTypes.DateTimeList), 
this.attr("_disabledDaysListInDataFetchStatus", "_disabledDaysListInDataFetchStatus", "_disabledDaysListInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("DisabledWeekDays", "disabledWeekDaysIn", "DisabledWeekDays", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_disabledWeekDaysInDataFetchStatus", "_disabledWeekDaysInDataFetchStatus", "_disabledWeekDaysInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SelectInterval", "selectIntervalIn", "SelectInterval", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_selectIntervalInDataFetchStatus", "_selectIntervalInDataFetchStatus", "_selectIntervalInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StartEmpty", "startEmptyIn", "StartEmpty", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_startEmptyInDataFetchStatus", "_startEmptyInDataFetchStatus", "_startEmptyInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("DateFormat", "dateFormatIn", "DateFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_dateFormatInDataFetchStatus", "_dateFormatInDataFetchStatus", "_dateFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowTodayButton", "showTodayButtonIn", "ShowTodayButton", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showTodayButtonInDataFetchStatus", "_showTodayButtonInDataFetchStatus", "_showTodayButtonInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AdvancedFormat", "advancedFormatIn", "AdvancedFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
DateInput: OS.Model.ValidationWidgetRecord
};
}

}

class Model extends 
OS.Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("InputWidgetId" in inputs) {
this.variables.inputWidgetIdIn = inputs.InputWidgetId;
if("_inputWidgetIdInDataFetchStatus" in inputs) {
this.variables._inputWidgetIdInDataFetchStatus = inputs._inputWidgetIdInDataFetchStatus;
}

}

if("ButtonWidgetId" in inputs) {
this.variables.buttonWidgetIdIn = inputs.ButtonWidgetId;
if("_buttonWidgetIdInDataFetchStatus" in inputs) {
this.variables._buttonWidgetIdInDataFetchStatus = inputs._buttonWidgetIdInDataFetchStatus;
}

}

if("EventList" in inputs) {
this.variables.eventListIn = inputs.EventList;
if("_eventListInDataFetchStatus" in inputs) {
this.variables._eventListInDataFetchStatus = inputs._eventListInDataFetchStatus;
}

}

if("MinDate" in inputs) {
this.variables.minDateIn = inputs.MinDate;
if("_minDateInDataFetchStatus" in inputs) {
this.variables._minDateInDataFetchStatus = inputs._minDateInDataFetchStatus;
}

}

if("MaxDate" in inputs) {
this.variables.maxDateIn = inputs.MaxDate;
if("_maxDateInDataFetchStatus" in inputs) {
this.variables._maxDateInDataFetchStatus = inputs._maxDateInDataFetchStatus;
}

}

if("InitialDate" in inputs) {
this.variables.initialDateIn = inputs.InitialDate;
if("_initialDateInDataFetchStatus" in inputs) {
this.variables._initialDateInDataFetchStatus = inputs._initialDateInDataFetchStatus;
}

}

if("ShowWeekNumbers" in inputs) {
this.variables.showWeekNumbersIn = inputs.ShowWeekNumbers;
if("_showWeekNumbersInDataFetchStatus" in inputs) {
this.variables._showWeekNumbersInDataFetchStatus = inputs._showWeekNumbersInDataFetchStatus;
}

}

if("FirstWeekDay" in inputs) {
this.variables.firstWeekDayIn = inputs.FirstWeekDay;
if("_firstWeekDayInDataFetchStatus" in inputs) {
this.variables._firstWeekDayInDataFetchStatus = inputs._firstWeekDayInDataFetchStatus;
}

}

if("ShowTime" in inputs) {
this.variables.showTimeIn = inputs.ShowTime;
if("_showTimeInDataFetchStatus" in inputs) {
this.variables._showTimeInDataFetchStatus = inputs._showTimeInDataFetchStatus;
}

}

if("Show24HourFormat" in inputs) {
this.variables.show24HourFormatIn = inputs.Show24HourFormat;
if("_show24HourFormatInDataFetchStatus" in inputs) {
this.variables._show24HourFormatInDataFetchStatus = inputs._show24HourFormatInDataFetchStatus;
}

}

if("DisabledDaysList" in inputs) {
this.variables.disabledDaysListIn = inputs.DisabledDaysList;
if("_disabledDaysListInDataFetchStatus" in inputs) {
this.variables._disabledDaysListInDataFetchStatus = inputs._disabledDaysListInDataFetchStatus;
}

}

if("DisabledWeekDays" in inputs) {
this.variables.disabledWeekDaysIn = inputs.DisabledWeekDays;
if("_disabledWeekDaysInDataFetchStatus" in inputs) {
this.variables._disabledWeekDaysInDataFetchStatus = inputs._disabledWeekDaysInDataFetchStatus;
}

}

if("SelectInterval" in inputs) {
this.variables.selectIntervalIn = inputs.SelectInterval;
if("_selectIntervalInDataFetchStatus" in inputs) {
this.variables._selectIntervalInDataFetchStatus = inputs._selectIntervalInDataFetchStatus;
}

}

if("StartEmpty" in inputs) {
this.variables.startEmptyIn = inputs.StartEmpty;
if("_startEmptyInDataFetchStatus" in inputs) {
this.variables._startEmptyInDataFetchStatus = inputs._startEmptyInDataFetchStatus;
}

}

if("DateFormat" in inputs) {
this.variables.dateFormatIn = inputs.DateFormat;
if("_dateFormatInDataFetchStatus" in inputs) {
this.variables._dateFormatInDataFetchStatus = inputs._dateFormatInDataFetchStatus;
}

}

if("ShowTodayButton" in inputs) {
this.variables.showTodayButtonIn = inputs.ShowTodayButton;
if("_showTodayButtonInDataFetchStatus" in inputs) {
this.variables._showTodayButtonInDataFetchStatus = inputs._showTodayButtonInDataFetchStatus;
}

}

if("AdvancedFormat" in inputs) {
this.variables.advancedFormatIn = inputs.AdvancedFormat;
if("_advancedFormatInDataFetchStatus" in inputs) {
this.variables._advancedFormatInDataFetchStatus = inputs._advancedFormatInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




