import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMaps_Shapes_Generic_mvcModel from "./OutSystemsMaps.Shapes.Generic.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdVar", "UniqueId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("BoundsString", "boundsStringVar", "BoundsString", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Bounds", "boundsVar", "Bounds", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_5fb6f64676b0133fcb572480a766fc9cStructure());
}, false, OutSystemsMapsModel.ST_5fb6f64676b0133fcb572480a766fc9cStructure), 
this.attr("North", "northIn", "North", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_northInDataFetchStatus", "_northInDataFetchStatus", "_northInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("South", "southIn", "South", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_southInDataFetchStatus", "_southInDataFetchStatus", "_southInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("East", "eastIn", "East", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_eastInDataFetchStatus", "_eastInDataFetchStatus", "_eastInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("West", "westIn", "West", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_westInDataFetchStatus", "_westInDataFetchStatus", "_westInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_fbded4e930a61a57761a37f0b1ea8d40Structure());
}, false, OutSystemsMapsModel.ST_fbded4e930a61a57761a37f0b1ea8d40Structure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = OutSystemsMaps_Shapes_Generic_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("North" in inputs) {
this.variables.northIn = inputs.North;
if("_northInDataFetchStatus" in inputs) {
this.variables._northInDataFetchStatus = inputs._northInDataFetchStatus;
}

}

if("South" in inputs) {
this.variables.southIn = inputs.South;
if("_southInDataFetchStatus" in inputs) {
this.variables._southInDataFetchStatus = inputs._southInDataFetchStatus;
}

}

if("East" in inputs) {
this.variables.eastIn = inputs.East;
if("_eastInDataFetchStatus" in inputs) {
this.variables._eastInDataFetchStatus = inputs._eastInDataFetchStatus;
}

}

if("West" in inputs) {
this.variables.westIn = inputs.West;
if("_westInDataFetchStatus" in inputs) {
this.variables._westInDataFetchStatus = inputs._westInDataFetchStatus;
}

}

if("OptionalConfigs" in inputs) {
this.variables.optionalConfigsIn = inputs.OptionalConfigs;
if("_optionalConfigsInDataFetchStatus" in inputs) {
this.variables._optionalConfigsInDataFetchStatus = inputs._optionalConfigsInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




