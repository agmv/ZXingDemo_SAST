import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMaps_Styles_ImagesCSS_mvcModel from "./OutSystemsMaps.Styles.ImagesCSS.mvc$model.js";
import OutSystemsMaps_Styles_MapCSS_mvcModel from "./OutSystemsMaps.Styles.MapCSS.mvc$model.js";

var OS = OSRuntimeCore;

class GetServerAPIKeyDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ServerAPIKey", "serverAPIKeyOut", "ServerAPIKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("GoogleMapsApiVersion", "googleMapsApiVersionOut", "GoogleMapsApiVersion", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetServerAPIKeyDataActRec.init();

class GetApiVersionDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("GoogleMapsApiVersion", "googleMapsApiVersionOut", "GoogleMapsApiVersion", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetApiVersionDataActRec(new GetApiVersionDataActRec.RecordClass({
googleMapsApiVersionOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApiVersionDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure());
}, false, OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure), 
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
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_d609eacb476c603df8b92eb374da99faStructure());
}, false, OutSystemsMapsModel.ST_d609eacb476c603df8b92eb374da99faStructure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetServerAPIKey", "getServerAPIKeyDataAct", "GetServerAPIKey", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetServerAPIKeyDataActRec());
}, true, GetServerAPIKeyDataActRec), 
this.attr("GetApiVersion", "getApiVersionDataAct", "GetApiVersion", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetApiVersionDataActRec());
}, true, GetApiVersionDataActRec)
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
Model._hasValidationWidgetsValue = (OutSystemsMaps_Styles_ImagesCSS_mvcModel.hasValidationWidgets || OutSystemsMaps_Styles_MapCSS_mvcModel.hasValidationWidgets);
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




