import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure());
}, false, OutSystemsUIModel.ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure), 
this.attr("StartsExpanded", "startsExpandedIn", "StartsExpanded", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_startsExpandedInDataFetchStatus", "_startsExpandedInDataFetchStatus", "_startsExpandedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Icon", "iconIn", "Icon", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.accordionIconType.caret;
}, false), 
this.attr("_iconInDataFetchStatus", "_iconInDataFetchStatus", "_iconInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IconPosition", "iconPositionIn", "IconPosition", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.accordionIconPosition.right;
}, false), 
this.attr("_iconPositionInDataFetchStatus", "_iconPositionInDataFetchStatus", "_iconPositionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsDisabled", "isDisabledIn", "IsDisabled", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("StartsExpanded" in inputs) {
this.variables.startsExpandedIn = inputs.StartsExpanded;
if("_startsExpandedInDataFetchStatus" in inputs) {
this.variables._startsExpandedInDataFetchStatus = inputs._startsExpandedInDataFetchStatus;
}

}

if("Icon" in inputs) {
this.variables.iconIn = inputs.Icon;
if("_iconInDataFetchStatus" in inputs) {
this.variables._iconInDataFetchStatus = inputs._iconInDataFetchStatus;
}

}

if("IconPosition" in inputs) {
this.variables.iconPositionIn = inputs.IconPosition;
if("_iconPositionInDataFetchStatus" in inputs) {
this.variables._iconPositionInDataFetchStatus = inputs._iconPositionInDataFetchStatus;
}

}

if("IsDisabled" in inputs) {
this.variables.isDisabledIn = inputs.IsDisabled;
if("_isDisabledInDataFetchStatus" in inputs) {
this.variables._isDisabledInDataFetchStatus = inputs._isDisabledInDataFetchStatus;
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




