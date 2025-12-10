import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_cd3e064c4ee8b37ab96945c09d5d2155Structure());
}, false, OutSystemsUIModel.ST_cd3e064c4ee8b37ab96945c09d5d2155Structure), 
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
this.attr("TimeFormat", "timeFormatIn", "TimeFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.datePickerTimeFormat.disabled;
}, false), 
this.attr("_timeFormatInDataFetchStatus", "_timeFormatInDataFetchStatus", "_timeFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_bc4abb4233d9ce894e855c520a20c76fStructure());
}, false, OutSystemsUIModel.ST_bc4abb4233d9ce894e855c520a20c76fStructure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ExtendedClass", "extendedClassIn", "ExtendedClass", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_extendedClassInDataFetchStatus", "_extendedClassInDataFetchStatus", "_extendedClassInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
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

if("TimeFormat" in inputs) {
this.variables.timeFormatIn = inputs.TimeFormat;
if("_timeFormatInDataFetchStatus" in inputs) {
this.variables._timeFormatInDataFetchStatus = inputs._timeFormatInDataFetchStatus;
}

}

if("OptionalConfigs" in inputs) {
this.variables.optionalConfigsIn = inputs.OptionalConfigs;
if("_optionalConfigsInDataFetchStatus" in inputs) {
this.variables._optionalConfigsInDataFetchStatus = inputs._optionalConfigsInDataFetchStatus;
}

}

if("ExtendedClass" in inputs) {
this.variables.extendedClassIn = inputs.ExtendedClass;
if("_extendedClassInDataFetchStatus" in inputs) {
this.variables._extendedClassInDataFetchStatus = inputs._extendedClassInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




