import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MiddleNavigationPages", "middleNavigationPagesVar", "MiddleNavigationPages", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_28a47f2e64dd49f0d3d29e55f70be394Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_28a47f2e64dd49f0d3d29e55f70be394Structure))), 
this.attr("SelectedPageButton", "selectedPageButtonVar", "SelectedPageButton", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TotalPages", "totalPagesVar", "TotalPages", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("LastPageNumber", "lastPageNumberVar", "LastPageNumber", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("IsVisible", "isVisibleVar", "IsVisible", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsPhone", "isPhoneVar", "IsPhone", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GoToValue", "goToValueVar", "GoToValue", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("KeypressCallback", "keypressCallbackVar", "KeypressCallback", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("StartIndex", "startIndexIn", "StartIndex", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_startIndexInDataFetchStatus", "_startIndexInDataFetchStatus", "_startIndexInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxRecords", "maxRecordsIn", "MaxRecords", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("TotalCount", "totalCountIn", "TotalCount", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_totalCountInDataFetchStatus", "_totalCountInDataFetchStatus", "_totalCountInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowGoToPage", "showGoToPageIn", "ShowGoToPage", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showGoToPageInDataFetchStatus", "_showGoToPageInDataFetchStatus", "_showGoToPageInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
return {
Input_SelectedPageButton: OS.Model.ValidationWidgetRecord
};
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

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("StartIndex" in inputs) {
this.variables.startIndexIn = inputs.StartIndex;
if("_startIndexInDataFetchStatus" in inputs) {
this.variables._startIndexInDataFetchStatus = inputs._startIndexInDataFetchStatus;
}

}

if("MaxRecords" in inputs) {
this.variables.maxRecordsIn = inputs.MaxRecords;
if("_maxRecordsInDataFetchStatus" in inputs) {
this.variables._maxRecordsInDataFetchStatus = inputs._maxRecordsInDataFetchStatus;
}

}

if("TotalCount" in inputs) {
this.variables.totalCountIn = inputs.TotalCount;
if("_totalCountInDataFetchStatus" in inputs) {
this.variables._totalCountInDataFetchStatus = inputs._totalCountInDataFetchStatus;
}

}

if("ShowGoToPage" in inputs) {
this.variables.showGoToPageIn = inputs.ShowGoToPage;
if("_showGoToPageInDataFetchStatus" in inputs) {
this.variables._showGoToPageInDataFetchStatus = inputs._showGoToPageInDataFetchStatus;
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




