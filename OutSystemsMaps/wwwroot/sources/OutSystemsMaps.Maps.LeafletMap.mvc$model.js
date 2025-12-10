import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMaps_Styles_ImagesCSS_mvcModel from "./OutSystemsMaps.Styles.ImagesCSS.mvc$model.js";
import OutSystemsMaps_Styles_MapCSS_mvcModel from "./OutSystemsMaps.Styles.MapCSS.mvc$model.js";
import OutSystemsMaps_Styles_LeafletCSS_mvcModel from "./OutSystemsMaps.Styles.LeafletCSS.mvc$model.js";
import OutSystemsMaps_Styles_LeafletRoutingCSS_mvcModel from "./OutSystemsMaps.Styles.LeafletRoutingCSS.mvc$model.js";
import OutSystemsMaps_Styles_LeafletDrawCSS_mvcModel from "./OutSystemsMaps.Styles.LeafletDrawCSS.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Configs", "internal_ConfigsVar", "Internal_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure());
}, false, OutSystemsMapsModel.ST_78d3133d124713193d703c2644ecd39bStructure), 
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
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_597877eac22877030461f6d98995be4aStructure());
}, false, OutSystemsMapsModel.ST_597877eac22877030461f6d98995be4aStructure), 
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
Model._hasValidationWidgetsValue = ((((OutSystemsMaps_Styles_ImagesCSS_mvcModel.hasValidationWidgets || OutSystemsMaps_Styles_MapCSS_mvcModel.hasValidationWidgets) || OutSystemsMaps_Styles_LeafletCSS_mvcModel.hasValidationWidgets) || OutSystemsMaps_Styles_LeafletRoutingCSS_mvcModel.hasValidationWidgets) || OutSystemsMaps_Styles_LeafletDrawCSS_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
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




