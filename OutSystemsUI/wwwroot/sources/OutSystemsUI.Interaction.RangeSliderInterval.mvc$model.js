import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure());
}, false, OutSystemsUIModel.ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure), 
this.attr("MinValue", "minValueIn", "MinValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_minValueInDataFetchStatus", "_minValueInDataFetchStatus", "_minValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxValue", "maxValueIn", "MaxValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_maxValueInDataFetchStatus", "_maxValueInDataFetchStatus", "_maxValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StartingValueFrom", "startingValueFromIn", "StartingValueFrom", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_startingValueFromInDataFetchStatus", "_startingValueFromInDataFetchStatus", "_startingValueFromInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StartingValueTo", "startingValueToIn", "StartingValueTo", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_startingValueToInDataFetchStatus", "_startingValueToInDataFetchStatus", "_startingValueToInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Orientation", "orientationIn", "Orientation", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.orientation.horizontal;
}, false), 
this.attr("_orientationInDataFetchStatus", "_orientationInDataFetchStatus", "_orientationInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Size", "sizeIn", "Size", true, false, OS.DataTypes.DataTypes.Text, function () {
return "100%";
}, false), 
this.attr("_sizeInDataFetchStatus", "_sizeInDataFetchStatus", "_sizeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_7167810326c75456a7ce120ed2dbd76bStructure());
}, false, OutSystemsUIModel.ST_7167810326c75456a7ce120ed2dbd76bStructure), 
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
if("MinValue" in inputs) {
this.variables.minValueIn = inputs.MinValue;
if("_minValueInDataFetchStatus" in inputs) {
this.variables._minValueInDataFetchStatus = inputs._minValueInDataFetchStatus;
}

}

if("MaxValue" in inputs) {
this.variables.maxValueIn = inputs.MaxValue;
if("_maxValueInDataFetchStatus" in inputs) {
this.variables._maxValueInDataFetchStatus = inputs._maxValueInDataFetchStatus;
}

}

if("StartingValueFrom" in inputs) {
this.variables.startingValueFromIn = inputs.StartingValueFrom;
if("_startingValueFromInDataFetchStatus" in inputs) {
this.variables._startingValueFromInDataFetchStatus = inputs._startingValueFromInDataFetchStatus;
}

}

if("StartingValueTo" in inputs) {
this.variables.startingValueToIn = inputs.StartingValueTo;
if("_startingValueToInDataFetchStatus" in inputs) {
this.variables._startingValueToInDataFetchStatus = inputs._startingValueToInDataFetchStatus;
}

}

if("Orientation" in inputs) {
this.variables.orientationIn = inputs.Orientation;
if("_orientationInDataFetchStatus" in inputs) {
this.variables._orientationInDataFetchStatus = inputs._orientationInDataFetchStatus;
}

}

if("Size" in inputs) {
this.variables.sizeIn = inputs.Size;
if("_sizeInDataFetchStatus" in inputs) {
this.variables._sizeInDataFetchStatus = inputs._sizeInDataFetchStatus;
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




