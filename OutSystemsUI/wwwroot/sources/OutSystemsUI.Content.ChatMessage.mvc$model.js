import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StatusVisible", "statusVisibleVar", "StatusVisible", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("TimeEmpty", "timeEmptyVar", "TimeEmpty", true, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("IsWebApp", "isWebAppVar", "IsWebApp", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DisplayOnRight", "displayOnRightIn", "DisplayOnRight", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_displayOnRightInDataFetchStatus", "_displayOnRightInDataFetchStatus", "_displayOnRightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Time", "timeIn", "Time", true, false, OS.DataTypes.DataTypes.Time, function () {
return OS.DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_timeInDataFetchStatus", "_timeInDataFetchStatus", "_timeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MessageStatus", "messageStatusIn", "MessageStatus", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_messageStatusInDataFetchStatus", "_messageStatusInDataFetchStatus", "_messageStatusInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("DisplayOnRight" in inputs) {
this.variables.displayOnRightIn = inputs.DisplayOnRight;
if("_displayOnRightInDataFetchStatus" in inputs) {
this.variables._displayOnRightInDataFetchStatus = inputs._displayOnRightInDataFetchStatus;
}

}

if("Time" in inputs) {
this.variables.timeIn = inputs.Time;
if("_timeInDataFetchStatus" in inputs) {
this.variables._timeInDataFetchStatus = inputs._timeInDataFetchStatus;
}

}

if("MessageStatus" in inputs) {
this.variables.messageStatusIn = inputs.MessageStatus;
if("_messageStatusInDataFetchStatus" in inputs) {
this.variables._messageStatusInDataFetchStatus = inputs._messageStatusInDataFetchStatus;
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




