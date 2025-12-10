import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsOpen", "isOpenVar", "IsOpen", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsInsideBottomBar", "isInsideBottomBarVar", "IsInsideBottomBar", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DOMElem", "dOMElemVar", "DOMElem", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("IsExpanded", "isExpandedIn", "IsExpanded", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isExpandedInDataFetchStatus", "_isExpandedInDataFetchStatus", "_isExpandedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsHover", "isHoverIn", "IsHover", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isHoverInDataFetchStatus", "_isHoverInDataFetchStatus", "_isHoverInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("IsExpanded" in inputs) {
this.variables.isExpandedIn = inputs.IsExpanded;
if("_isExpandedInDataFetchStatus" in inputs) {
this.variables._isExpandedInDataFetchStatus = inputs._isExpandedInDataFetchStatus;
}

}

if("IsHover" in inputs) {
this.variables.isHoverIn = inputs.IsHover;
if("_isHoverInDataFetchStatus" in inputs) {
this.variables._isHoverInDataFetchStatus = inputs._isHoverInDataFetchStatus;
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




