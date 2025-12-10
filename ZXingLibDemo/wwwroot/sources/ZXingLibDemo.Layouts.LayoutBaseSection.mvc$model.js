import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("BackgroundColor", "backgroundColorIn", "BackgroundColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_backgroundColorInDataFetchStatus", "_backgroundColorInDataFetchStatus", "_backgroundColorInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Padding", "paddingIn", "Padding", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_paddingInDataFetchStatus", "_paddingInDataFetchStatus", "_paddingInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("BackgroundColor" in inputs) {
this.variables.backgroundColorIn = inputs.BackgroundColor;
if("_backgroundColorInDataFetchStatus" in inputs) {
this.variables._backgroundColorInDataFetchStatus = inputs._backgroundColorInDataFetchStatus;
}

}

if("Padding" in inputs) {
this.variables.paddingIn = inputs.Padding;
if("_paddingInDataFetchStatus" in inputs) {
this.variables._paddingInDataFetchStatus = inputs._paddingInDataFetchStatus;
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




