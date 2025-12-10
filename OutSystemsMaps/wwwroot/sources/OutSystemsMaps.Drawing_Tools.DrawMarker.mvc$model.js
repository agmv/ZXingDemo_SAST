import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdVar", "UniqueId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Internal_DrawingTools_Configs", "internal_DrawingTools_ConfigsVar", "Internal_DrawingTools_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_60018fad8b9768f5644ffadf96040a85Structure());
}, false, OutSystemsMapsModel.ST_60018fad8b9768f5644ffadf96040a85Structure), 
this.attr("IconURL", "iconURLIn", "IconURL", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_iconURLInDataFetchStatus", "_iconURLInDataFetchStatus", "_iconURLInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AllowDrag", "allowDragIn", "AllowDrag", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowDragInDataFetchStatus", "_allowDragInDataFetchStatus", "_allowDragInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("IconURL" in inputs) {
this.variables.iconURLIn = inputs.IconURL;
if("_iconURLInDataFetchStatus" in inputs) {
this.variables._iconURLInDataFetchStatus = inputs._iconURLInDataFetchStatus;
}

}

if("AllowDrag" in inputs) {
this.variables.allowDragIn = inputs.AllowDrag;
if("_allowDragInDataFetchStatus" in inputs) {
this.variables._allowDragInDataFetchStatus = inputs._allowDragInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




