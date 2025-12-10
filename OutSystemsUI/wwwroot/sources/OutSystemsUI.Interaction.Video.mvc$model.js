import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_87ed820dae13f311d79f7f394fc3790aStructure());
}, false, OutSystemsUIModel.ST_87ed820dae13f311d79f7f394fc3790aStructure), 
this.attr("URL", "uRLIn", "URL", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_uRLInDataFetchStatus", "_uRLInDataFetchStatus", "_uRLInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Controls", "controlsIn", "Controls", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_controlsInDataFetchStatus", "_controlsInDataFetchStatus", "_controlsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Width", "widthIn", "Width", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_widthInDataFetchStatus", "_widthInDataFetchStatus", "_widthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Height", "heightIn", "Height", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_heightInDataFetchStatus", "_heightInDataFetchStatus", "_heightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Captions", "captionsIn", "Captions", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure))), 
this.attr("_captionsInDataFetchStatus", "_captionsInDataFetchStatus", "_captionsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_6510d2524fe77fcc6c285159d4000cfbStructure());
}, false, OutSystemsUIModel.ST_6510d2524fe77fcc6c285159d4000cfbStructure), 
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
if("URL" in inputs) {
this.variables.uRLIn = inputs.URL;
if("_uRLInDataFetchStatus" in inputs) {
this.variables._uRLInDataFetchStatus = inputs._uRLInDataFetchStatus;
}

}

if("Controls" in inputs) {
this.variables.controlsIn = inputs.Controls;
if("_controlsInDataFetchStatus" in inputs) {
this.variables._controlsInDataFetchStatus = inputs._controlsInDataFetchStatus;
}

}

if("Width" in inputs) {
this.variables.widthIn = inputs.Width;
if("_widthInDataFetchStatus" in inputs) {
this.variables._widthInDataFetchStatus = inputs._widthInDataFetchStatus;
}

}

if("Height" in inputs) {
this.variables.heightIn = inputs.Height;
if("_heightInDataFetchStatus" in inputs) {
this.variables._heightInDataFetchStatus = inputs._heightInDataFetchStatus;
}

}

if("Captions" in inputs) {
this.variables.captionsIn = inputs.Captions;
if("_captionsInDataFetchStatus" in inputs) {
this.variables._captionsInDataFetchStatus = inputs._captionsInDataFetchStatus;
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




