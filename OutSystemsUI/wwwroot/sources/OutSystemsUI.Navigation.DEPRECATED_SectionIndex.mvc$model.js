import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsWebApp", "isWebAppVar", "IsWebApp", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsOldNative", "isOldNativeVar", "IsOldNative", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsLayoutNative", "isLayoutNativeVar", "IsLayoutNative", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("SectionIndexObj", "sectionIndexObjVar", "SectionIndexObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("IsSmooth", "isSmoothIn", "IsSmooth", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_isSmoothInDataFetchStatus", "_isSmoothInDataFetchStatus", "_isSmoothInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsFixed", "isFixedIn", "IsFixed", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_isFixedInDataFetchStatus", "_isFixedInDataFetchStatus", "_isFixedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("TopPosition", "topPositionIn", "TopPosition", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_topPositionInDataFetchStatus", "_topPositionInDataFetchStatus", "_topPositionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("IsSmooth" in inputs) {
this.variables.isSmoothIn = inputs.IsSmooth;
if("_isSmoothInDataFetchStatus" in inputs) {
this.variables._isSmoothInDataFetchStatus = inputs._isSmoothInDataFetchStatus;
}

}

if("IsFixed" in inputs) {
this.variables.isFixedIn = inputs.IsFixed;
if("_isFixedInDataFetchStatus" in inputs) {
this.variables._isFixedInDataFetchStatus = inputs._isFixedInDataFetchStatus;
}

}

if("TopPosition" in inputs) {
this.variables.topPositionIn = inputs.TopPosition;
if("_topPositionInDataFetchStatus" in inputs) {
this.variables._topPositionInDataFetchStatus = inputs._topPositionInDataFetchStatus;
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




