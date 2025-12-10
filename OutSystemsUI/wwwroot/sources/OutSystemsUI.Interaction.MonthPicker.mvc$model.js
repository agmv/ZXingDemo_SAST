import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_6f97d9724e66f51b47133aa003a9e610Structure());
}, false, OutSystemsUIModel.ST_6f97d9724e66f51b47133aa003a9e610Structure), 
this.attr("DateFormat", "dateFormatIn", "DateFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "MM/YYYY";
}, false), 
this.attr("_dateFormatInDataFetchStatus", "_dateFormatInDataFetchStatus", "_dateFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InitialMonth", "initialMonthIn", "InitialMonth", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, false, OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("_initialMonthInDataFetchStatus", "_initialMonthInDataFetchStatus", "_initialMonthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MinMonth", "minMonthIn", "MinMonth", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, false, OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("_minMonthInDataFetchStatus", "_minMonthInDataFetchStatus", "_minMonthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxMonth", "maxMonthIn", "MaxMonth", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure());
}, false, OutSystemsUIModel.ST_5c08eaa15b890a2d617cabe547c34f0bStructure), 
this.attr("_maxMonthInDataFetchStatus", "_maxMonthInDataFetchStatus", "_maxMonthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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

if("InitialMonth" in inputs) {
this.variables.initialMonthIn = inputs.InitialMonth;
if("_initialMonthInDataFetchStatus" in inputs) {
this.variables._initialMonthInDataFetchStatus = inputs._initialMonthInDataFetchStatus;
}

}

if("MinMonth" in inputs) {
this.variables.minMonthIn = inputs.MinMonth;
if("_minMonthInDataFetchStatus" in inputs) {
this.variables._minMonthInDataFetchStatus = inputs._minMonthInDataFetchStatus;
}

}

if("MaxMonth" in inputs) {
this.variables.maxMonthIn = inputs.MaxMonth;
if("_maxMonthInDataFetchStatus" in inputs) {
this.variables._maxMonthInDataFetchStatus = inputs._maxMonthInDataFetchStatus;
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




