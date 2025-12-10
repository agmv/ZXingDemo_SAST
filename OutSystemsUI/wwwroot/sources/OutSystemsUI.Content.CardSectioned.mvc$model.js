import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UsePadding", "usePaddingIn", "UsePadding", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_usePaddingInDataFetchStatus", "_usePaddingInDataFetchStatus", "_usePaddingInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsVertical", "isVerticalIn", "IsVertical", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ImagePadding", "imagePaddingIn", "ImagePadding", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_imagePaddingInDataFetchStatus", "_imagePaddingInDataFetchStatus", "_imagePaddingInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("UsePadding" in inputs) {
this.variables.usePaddingIn = inputs.UsePadding;
if("_usePaddingInDataFetchStatus" in inputs) {
this.variables._usePaddingInDataFetchStatus = inputs._usePaddingInDataFetchStatus;
}

}

if("IsVertical" in inputs) {
this.variables.isVerticalIn = inputs.IsVertical;
if("_isVerticalInDataFetchStatus" in inputs) {
this.variables._isVerticalInDataFetchStatus = inputs._isVerticalInDataFetchStatus;
}

}

if("ImagePadding" in inputs) {
this.variables.imagePaddingIn = inputs.ImagePadding;
if("_imagePaddingInDataFetchStatus" in inputs) {
this.variables._imagePaddingInDataFetchStatus = inputs._imagePaddingInDataFetchStatus;
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




