import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_configs", "internal_configsVar", "Internal_configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_546a3060996e070a522a708cd2d94c23Structure());
}, false, OutSystemsUIModel.ST_546a3060996e070a522a708cd2d94c23Structure), 
this.attr("RowItemsDesktop", "rowItemsDesktopIn", "RowItemsDesktop", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 4;
}, false), 
this.attr("_rowItemsDesktopInDataFetchStatus", "_rowItemsDesktopInDataFetchStatus", "_rowItemsDesktopInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RowItemsTablet", "rowItemsTabletIn", "RowItemsTablet", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 3;
}, false), 
this.attr("_rowItemsTabletInDataFetchStatus", "_rowItemsTabletInDataFetchStatus", "_rowItemsTabletInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RowItemsPhone", "rowItemsPhoneIn", "RowItemsPhone", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("_rowItemsPhoneInDataFetchStatus", "_rowItemsPhoneInDataFetchStatus", "_rowItemsPhoneInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsGap", "itemsGapIn", "ItemsGap", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.space.base;
}, false), 
this.attr("_itemsGapInDataFetchStatus", "_itemsGapInDataFetchStatus", "_itemsGapInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("RowItemsDesktop" in inputs) {
this.variables.rowItemsDesktopIn = inputs.RowItemsDesktop;
if("_rowItemsDesktopInDataFetchStatus" in inputs) {
this.variables._rowItemsDesktopInDataFetchStatus = inputs._rowItemsDesktopInDataFetchStatus;
}

}

if("RowItemsTablet" in inputs) {
this.variables.rowItemsTabletIn = inputs.RowItemsTablet;
if("_rowItemsTabletInDataFetchStatus" in inputs) {
this.variables._rowItemsTabletInDataFetchStatus = inputs._rowItemsTabletInDataFetchStatus;
}

}

if("RowItemsPhone" in inputs) {
this.variables.rowItemsPhoneIn = inputs.RowItemsPhone;
if("_rowItemsPhoneInDataFetchStatus" in inputs) {
this.variables._rowItemsPhoneInDataFetchStatus = inputs._rowItemsPhoneInDataFetchStatus;
}

}

if("ItemsGap" in inputs) {
this.variables.itemsGapIn = inputs.ItemsGap;
if("_itemsGapInDataFetchStatus" in inputs) {
this.variables._itemsGapInDataFetchStatus = inputs._itemsGapInDataFetchStatus;
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




