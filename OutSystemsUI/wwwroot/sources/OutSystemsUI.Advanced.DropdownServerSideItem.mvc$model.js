import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure());
}, false, OutSystemsUIModel.ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure), 
this.attr("ItemId", "itemIdIn", "ItemId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_itemIdInDataFetchStatus", "_itemIdInDataFetchStatus", "_itemIdInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsSelected", "isSelectedIn", "IsSelected", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isSelectedInDataFetchStatus", "_isSelectedInDataFetchStatus", "_isSelectedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("ItemId" in inputs) {
this.variables.itemIdIn = inputs.ItemId;
if("_itemIdInDataFetchStatus" in inputs) {
this.variables._itemIdInDataFetchStatus = inputs._itemIdInDataFetchStatus;
}

}

if("IsSelected" in inputs) {
this.variables.isSelectedIn = inputs.IsSelected;
if("_isSelectedInDataFetchStatus" in inputs) {
this.variables._isSelectedInDataFetchStatus = inputs._isSelectedInDataFetchStatus;
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




