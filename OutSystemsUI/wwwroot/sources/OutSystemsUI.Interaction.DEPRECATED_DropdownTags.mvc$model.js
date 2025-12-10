import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ChoicesObj", "choicesObjVar", "ChoicesObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("SelectedItem", "selectedItemVar", "SelectedItem", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("SerializedSelected", "serializedSelectedVar", "SerializedSelected", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("SerializedList", "serializedListVar", "SerializedList", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsSelecting", "isSelectingVar", "IsSelecting", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OriginalOptions", "originalOptionsVar", "OriginalOptions", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.RC_98ce383abd92f0f4c51d49a4fcc3bfcc());
}, false, OutSystemsUIModel.RC_98ce383abd92f0f4c51d49a4fcc3bfcc), 
this.attr("CurrentList", "currentListVar", "CurrentList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))), 
this.attr("RTLCallback", "rTLCallbackVar", "RTLCallback", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("ItemList", "itemListIn", "ItemList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))), 
this.attr("_itemListInDataFetchStatus", "_itemListInDataFetchStatus", "_itemListInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SelectedItemsList", "selectedItemsListIn", "SelectedItemsList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))), 
this.attr("_selectedItemsListInDataFetchStatus", "_selectedItemsListInDataFetchStatus", "_selectedItemsListInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsRemoveItems", "isRemoveItemsIn", "IsRemoveItems", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_isRemoveItemsInDataFetchStatus", "_isRemoveItemsInDataFetchStatus", "_isRemoveItemsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsDisabled", "isDisabledIn", "IsDisabled", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SearchPrompt", "searchPromptIn", "SearchPrompt", true, false, OS.DataTypes.DataTypes.Text, function () {
return "Search";
}, false), 
this.attr("_searchPromptInDataFetchStatus", "_searchPromptInDataFetchStatus", "_searchPromptInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("NoResultsText", "noResultsTextIn", "NoResultsText", true, false, OS.DataTypes.DataTypes.Text, function () {
return "No results found";
}, false), 
this.attr("_noResultsTextInDataFetchStatus", "_noResultsTextInDataFetchStatus", "_noResultsTextInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AdvancedFormat", "advancedFormatIn", "AdvancedFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "{}";
}, false), 
this.attr("_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("ItemList" in inputs) {
this.variables.itemListIn = inputs.ItemList;
if("_itemListInDataFetchStatus" in inputs) {
this.variables._itemListInDataFetchStatus = inputs._itemListInDataFetchStatus;
}

}

if("SelectedItemsList" in inputs) {
this.variables.selectedItemsListIn = inputs.SelectedItemsList;
if("_selectedItemsListInDataFetchStatus" in inputs) {
this.variables._selectedItemsListInDataFetchStatus = inputs._selectedItemsListInDataFetchStatus;
}

}

if("IsRemoveItems" in inputs) {
this.variables.isRemoveItemsIn = inputs.IsRemoveItems;
if("_isRemoveItemsInDataFetchStatus" in inputs) {
this.variables._isRemoveItemsInDataFetchStatus = inputs._isRemoveItemsInDataFetchStatus;
}

}

if("IsDisabled" in inputs) {
this.variables.isDisabledIn = inputs.IsDisabled;
if("_isDisabledInDataFetchStatus" in inputs) {
this.variables._isDisabledInDataFetchStatus = inputs._isDisabledInDataFetchStatus;
}

}

if("SearchPrompt" in inputs) {
this.variables.searchPromptIn = inputs.SearchPrompt;
if("_searchPromptInDataFetchStatus" in inputs) {
this.variables._searchPromptInDataFetchStatus = inputs._searchPromptInDataFetchStatus;
}

}

if("NoResultsText" in inputs) {
this.variables.noResultsTextIn = inputs.NoResultsText;
if("_noResultsTextInDataFetchStatus" in inputs) {
this.variables._noResultsTextInDataFetchStatus = inputs._noResultsTextInDataFetchStatus;
}

}

if("AdvancedFormat" in inputs) {
this.variables.advancedFormatIn = inputs.AdvancedFormat;
if("_advancedFormatInDataFetchStatus" in inputs) {
this.variables._advancedFormatInDataFetchStatus = inputs._advancedFormatInDataFetchStatus;
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




