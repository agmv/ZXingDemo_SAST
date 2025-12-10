import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMaps_Styles_MapCSS_mvcModel from "./OutSystemsMaps.Styles.MapCSS.mvc$model.js";

var OS = OSRuntimeCore;

class ObtainMapKeyDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ServerAPIKey", "serverAPIKeyOut", "ServerAPIKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ObtainMapKeyDataActRec(new ObtainMapKeyDataActRec.RecordClass({
serverAPIKeyOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

ObtainMapKeyDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure());
}, false, OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure), 
this.attr("MarkersHashcode", "markersHashcodeVar", "MarkersHashcode", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.BuiltinFunctions.integerToLongInteger((-999));
}, false), 
this.attr("IsSecondRound", "isSecondRoundVar", "IsSecondRound", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("APIKey", "aPIKeyIn", "APIKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_aPIKeyInDataFetchStatus", "_aPIKeyInDataFetchStatus", "_aPIKeyInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Center", "centerIn", "Center", true, false, OS.DataTypes.DataTypes.Text, function () {
return "42.3517926,-71.0467845";
}, false), 
this.attr("_centerInDataFetchStatus", "_centerInDataFetchStatus", "_centerInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Height", "heightIn", "Height", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_heightInDataFetchStatus", "_heightInDataFetchStatus", "_heightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StaticMarkers", "staticMarkersIn", "StaticMarkers", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_832344699c82a4f799a423f89bbe7297Structure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsMapsModel.ST_832344699c82a4f799a423f89bbe7297Structure))), 
this.attr("_staticMarkersInDataFetchStatus", "_staticMarkersInDataFetchStatus", "_staticMarkersInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalStaticMapConfigs", "optionalStaticMapConfigsIn", "OptionalStaticMapConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_b2c05afcf4810ad0d4384a01306bb0f3Structure());
}, false, OutSystemsMapsModel.ST_b2c05afcf4810ad0d4384a01306bb0f3Structure), 
this.attr("_optionalStaticMapConfigsInDataFetchStatus", "_optionalStaticMapConfigsInDataFetchStatus", "_optionalStaticMapConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ObtainMapKey", "obtainMapKeyDataAct", "ObtainMapKey", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ObtainMapKeyDataActRec());
}, true, ObtainMapKeyDataActRec)
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
Model._hasValidationWidgetsValue = OutSystemsMaps_Styles_MapCSS_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("APIKey" in inputs) {
this.variables.aPIKeyIn = inputs.APIKey;
if("_aPIKeyInDataFetchStatus" in inputs) {
this.variables._aPIKeyInDataFetchStatus = inputs._aPIKeyInDataFetchStatus;
}

}

if("Center" in inputs) {
this.variables.centerIn = inputs.Center;
if("_centerInDataFetchStatus" in inputs) {
this.variables._centerInDataFetchStatus = inputs._centerInDataFetchStatus;
}

}

if("Height" in inputs) {
this.variables.heightIn = inputs.Height;
if("_heightInDataFetchStatus" in inputs) {
this.variables._heightInDataFetchStatus = inputs._heightInDataFetchStatus;
}

}

if("StaticMarkers" in inputs) {
this.variables.staticMarkersIn = inputs.StaticMarkers;
if("_staticMarkersInDataFetchStatus" in inputs) {
this.variables._staticMarkersInDataFetchStatus = inputs._staticMarkersInDataFetchStatus;
}

}

if("OptionalStaticMapConfigs" in inputs) {
this.variables.optionalStaticMapConfigsIn = inputs.OptionalStaticMapConfigs;
if("_optionalStaticMapConfigsInDataFetchStatus" in inputs) {
this.variables._optionalStaticMapConfigsInDataFetchStatus = inputs._optionalStaticMapConfigsInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




