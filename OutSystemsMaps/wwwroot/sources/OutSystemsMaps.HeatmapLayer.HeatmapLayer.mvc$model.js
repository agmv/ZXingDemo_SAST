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
this.attr("Internal_HeatmapLayer_Configs", "internal_HeatmapLayer_ConfigsVar", "Internal_HeatmapLayer_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_f2c047cd8082950bd1961446a5ec1949Structure());
}, false, OutSystemsMapsModel.ST_f2c047cd8082950bd1961446a5ec1949Structure), 
this.attr("StringifiedGradient", "stringifiedGradientVar", "StringifiedGradient", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("PointsHashCode", "pointsHashCodeVar", "PointsHashCode", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.BuiltinFunctions.integerToLongInteger((-999));
}, false), 
this.attr("Points", "pointsIn", "Points", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure))), 
this.attr("_pointsInDataFetchStatus", "_pointsInDataFetchStatus", "_pointsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_c84e2ea85c3f77e3b083b2b79806c17aStructure());
}, false, OutSystemsMapsModel.ST_c84e2ea85c3f77e3b083b2b79806c17aStructure), 
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("Points" in inputs) {
this.variables.pointsIn = inputs.Points;
if("_pointsInDataFetchStatus" in inputs) {
this.variables._pointsInDataFetchStatus = inputs._pointsInDataFetchStatus;
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




