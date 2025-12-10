import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_613242ff7dd22d356200cb1f89298a39Structure());
}, false, OutSystemsUIModel.ST_613242ff7dd22d356200cb1f89298a39Structure), 
this.attr("TimeFormat", "timeFormatIn", "TimeFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_timeFormatInDataFetchStatus", "_timeFormatInDataFetchStatus", "_timeFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Is24Hours", "is24HoursIn", "Is24Hours", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_is24HoursInDataFetchStatus", "_is24HoursInDataFetchStatus", "_is24HoursInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InitialTime", "initialTimeIn", "InitialTime", true, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_initialTimeInDataFetchStatus", "_initialTimeInDataFetchStatus", "_initialTimeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_b96c67f06fdfae580256b7081d85460dStructure());
}, false, OutSystemsUIModel.ST_b96c67f06fdfae580256b7081d85460dStructure), 
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
if("TimeFormat" in inputs) {
this.variables.timeFormatIn = inputs.TimeFormat;
if("_timeFormatInDataFetchStatus" in inputs) {
this.variables._timeFormatInDataFetchStatus = inputs._timeFormatInDataFetchStatus;
}

}

if("Is24Hours" in inputs) {
this.variables.is24HoursIn = inputs.Is24Hours;
if("_is24HoursInDataFetchStatus" in inputs) {
this.variables._is24HoursInDataFetchStatus = inputs._is24HoursInDataFetchStatus;
}

}

if("InitialTime" in inputs) {
this.variables.initialTimeIn = inputs.InitialTime;
if("_initialTimeInDataFetchStatus" in inputs) {
this.variables._initialTimeInDataFetchStatus = inputs._initialTimeInDataFetchStatus;
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




