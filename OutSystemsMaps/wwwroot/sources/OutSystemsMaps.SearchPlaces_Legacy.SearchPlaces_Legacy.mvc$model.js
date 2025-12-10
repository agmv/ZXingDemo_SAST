import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMaps_Styles_Legacy_PlacesCSS_mvcModel from "./OutSystemsMaps.Styles_Legacy.PlacesCSS.mvc$model.js";

var OS = OSRuntimeCore;

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


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UniqueId", "uniqueIdVar", "UniqueId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsSecondRound", "isSecondRoundVar", "IsSecondRound", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_b0933bf7957301c22e5d9229ad792ac0Structure());
}, false, OutSystemsMapsModel.ST_b0933bf7957301c22e5d9229ad792ac0Structure), 
this.attr("SearchAreaString", "searchAreaStringVar", "SearchAreaString", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("SearchArea", "searchAreaVar", "SearchArea", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure());
}, false, OutSystemsMapsModel.ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure), 
this.attr("CountriesString", "countriesStringVar", "CountriesString", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("APIKey", "aPIKeyIn", "APIKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_aPIKeyInDataFetchStatus", "_aPIKeyInDataFetchStatus", "_aPIKeyInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_7cd861eaa819851d6fba6d8150ed8cc1Structure());
}, false, OutSystemsMapsModel.ST_7cd861eaa819851d6fba6d8150ed8cc1Structure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApiVersion", "getApiVersionDataAct", "GetApiVersion", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetApiVersionDataActRec());
}, true, GetApiVersionDataActRec), 
this.attr("GetServerAPIKey", "getServerAPIKeyDataAct", "GetServerAPIKey", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetServerAPIKeyDataActRec());
}, true, GetServerAPIKeyDataActRec)
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
Model._hasValidationWidgetsValue = OutSystemsMaps_Styles_Legacy_PlacesCSS_mvcModel.hasValidationWidgets;
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




