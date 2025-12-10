import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ItemInPhone", "itemInPhoneIn", "ItemInPhone", true, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "1";
}, false), 
this.attr("_itemInPhoneInDataFetchStatus", "_itemInPhoneInDataFetchStatus", "_itemInPhoneInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsInTablet", "itemsInTabletIn", "ItemsInTablet", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 3;
}, false), 
this.attr("_itemsInTabletInDataFetchStatus", "_itemsInTabletInDataFetchStatus", "_itemsInTabletInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsInDesktop", "itemsInDesktopIn", "ItemsInDesktop", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 4;
}, false), 
this.attr("_itemsInDesktopInDataFetchStatus", "_itemsInDesktopInDataFetchStatus", "_itemsInDesktopInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GutterSize", "gutterSizeIn", "GutterSize", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.space.base;
}, false), 
this.attr("_gutterSizeInDataFetchStatus", "_gutterSizeInDataFetchStatus", "_gutterSizeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("ItemInPhone" in inputs) {
this.variables.itemInPhoneIn = inputs.ItemInPhone;
if("_itemInPhoneInDataFetchStatus" in inputs) {
this.variables._itemInPhoneInDataFetchStatus = inputs._itemInPhoneInDataFetchStatus;
}

}

if("ItemsInTablet" in inputs) {
this.variables.itemsInTabletIn = inputs.ItemsInTablet;
if("_itemsInTabletInDataFetchStatus" in inputs) {
this.variables._itemsInTabletInDataFetchStatus = inputs._itemsInTabletInDataFetchStatus;
}

}

if("ItemsInDesktop" in inputs) {
this.variables.itemsInDesktopIn = inputs.ItemsInDesktop;
if("_itemsInDesktopInDataFetchStatus" in inputs) {
this.variables._itemsInDesktopInDataFetchStatus = inputs._itemsInDesktopInDataFetchStatus;
}

}

if("GutterSize" in inputs) {
this.variables.gutterSizeIn = inputs.GutterSize;
if("_gutterSizeInDataFetchStatus" in inputs) {
this.variables._gutterSizeInDataFetchStatus = inputs._gutterSizeInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




