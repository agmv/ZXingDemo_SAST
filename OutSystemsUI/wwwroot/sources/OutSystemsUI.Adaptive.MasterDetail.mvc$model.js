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
this.attr("IsLayoutNative", "isLayoutNativeVar", "IsLayoutNative", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ActiveDOMElem", "activeDOMElemVar", "ActiveDOMElem", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("IsPhone", "isPhoneVar", "IsPhone", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LeftPercentage", "leftPercentageIn", "LeftPercentage", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(50);
}, false), 
this.attr("_leftPercentageInDataFetchStatus", "_leftPercentageInDataFetchStatus", "_leftPercentageInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OpenedOnPhone", "openedOnPhoneIn", "OpenedOnPhone", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_openedOnPhoneInDataFetchStatus", "_openedOnPhoneInDataFetchStatus", "_openedOnPhoneInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Height", "heightIn", "Height", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_heightInDataFetchStatus", "_heightInDataFetchStatus", "_heightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("LeftPercentage" in inputs) {
this.variables.leftPercentageIn = inputs.LeftPercentage;
if("_leftPercentageInDataFetchStatus" in inputs) {
this.variables._leftPercentageInDataFetchStatus = inputs._leftPercentageInDataFetchStatus;
}

}

if("OpenedOnPhone" in inputs) {
this.variables.openedOnPhoneIn = inputs.OpenedOnPhone;
if("_openedOnPhoneInDataFetchStatus" in inputs) {
this.variables._openedOnPhoneInDataFetchStatus = inputs._openedOnPhoneInDataFetchStatus;
}

}

if("Height" in inputs) {
this.variables.heightIn = inputs.Height;
if("_heightInDataFetchStatus" in inputs) {
this.variables._heightInDataFetchStatus = inputs._heightInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




