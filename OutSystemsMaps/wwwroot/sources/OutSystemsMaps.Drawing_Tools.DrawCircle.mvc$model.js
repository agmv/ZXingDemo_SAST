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
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_5d8d0b250562ec29250400c2b0c3eb66Structure());
}, false, OutSystemsMapsModel.ST_5d8d0b250562ec29250400c2b0c3eb66Structure), 
this.attr("AllowDrag", "allowDragIn", "AllowDrag", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowDragInDataFetchStatus", "_allowDragInDataFetchStatus", "_allowDragInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AllowEdit", "allowEditIn", "AllowEdit", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowEditInDataFetchStatus", "_allowEditInDataFetchStatus", "_allowEditInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Stroke", "strokeIn", "Stroke", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, false, OutSystemsMapsModel.ST_c2a46cf64d2acc4b38d805712495224cStructure), 
this.attr("_strokeInDataFetchStatus", "_strokeInDataFetchStatus", "_strokeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Fill", "fillIn", "Fill", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure());
}, false, OutSystemsMapsModel.ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure), 
this.attr("_fillInDataFetchStatus", "_fillInDataFetchStatus", "_fillInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("AllowDrag" in inputs) {
this.variables.allowDragIn = inputs.AllowDrag;
if("_allowDragInDataFetchStatus" in inputs) {
this.variables._allowDragInDataFetchStatus = inputs._allowDragInDataFetchStatus;
}

}

if("AllowEdit" in inputs) {
this.variables.allowEditIn = inputs.AllowEdit;
if("_allowEditInDataFetchStatus" in inputs) {
this.variables._allowEditInDataFetchStatus = inputs._allowEditInDataFetchStatus;
}

}

if("Stroke" in inputs) {
this.variables.strokeIn = inputs.Stroke;
if("_strokeInDataFetchStatus" in inputs) {
this.variables._strokeInDataFetchStatus = inputs._strokeInDataFetchStatus;
}

}

if("Fill" in inputs) {
this.variables.fillIn = inputs.Fill;
if("_fillInDataFetchStatus" in inputs) {
this.variables._fillInDataFetchStatus = inputs._fillInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




