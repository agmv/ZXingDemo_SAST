import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_Shape_Configs", "internal_Shape_ConfigsVar", "Internal_Shape_Configs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure());
}, false, OutSystemsMapsModel.ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure), 
this.attr("LocationsHashcode", "locationsHashcodeVar", "LocationsHashcode", true, false, OS.DataTypes.DataTypes.LongInteger, function () {
return OS.BuiltinFunctions.integerToLongInteger((-999));
}, false), 
this.attr("Locations", "locationsIn", "Locations", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, false, OS.DataTypes.TextList), 
this.attr("_locationsInDataFetchStatus", "_locationsInDataFetchStatus", "_locationsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Center", "centerIn", "Center", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_centerInDataFetchStatus", "_centerInDataFetchStatus", "_centerInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Radius", "radiusIn", "Radius", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_radiusInDataFetchStatus", "_radiusInDataFetchStatus", "_radiusInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsMapsModel.ST_f021741499f997a32540fab3dfcdbbfaStructure());
}, false, OutSystemsMapsModel.ST_f021741499f997a32540fab3dfcdbbfaStructure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("UniqueId", "uniqueIdIn", "UniqueId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_uniqueIdInDataFetchStatus", "_uniqueIdInDataFetchStatus", "_uniqueIdInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShapeType", "shapeTypeIn", "ShapeType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_shapeTypeInDataFetchStatus", "_shapeTypeInDataFetchStatus", "_shapeTypeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Bounds", "boundsIn", "Bounds", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_boundsInDataFetchStatus", "_boundsInDataFetchStatus", "_boundsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("Locations" in inputs) {
this.variables.locationsIn = inputs.Locations;
if("_locationsInDataFetchStatus" in inputs) {
this.variables._locationsInDataFetchStatus = inputs._locationsInDataFetchStatus;
}

}

if("Center" in inputs) {
this.variables.centerIn = inputs.Center;
if("_centerInDataFetchStatus" in inputs) {
this.variables._centerInDataFetchStatus = inputs._centerInDataFetchStatus;
}

}

if("Radius" in inputs) {
this.variables.radiusIn = inputs.Radius;
if("_radiusInDataFetchStatus" in inputs) {
this.variables._radiusInDataFetchStatus = inputs._radiusInDataFetchStatus;
}

}

if("OptionalConfigs" in inputs) {
this.variables.optionalConfigsIn = inputs.OptionalConfigs;
if("_optionalConfigsInDataFetchStatus" in inputs) {
this.variables._optionalConfigsInDataFetchStatus = inputs._optionalConfigsInDataFetchStatus;
}

}

if("UniqueId" in inputs) {
this.variables.uniqueIdIn = inputs.UniqueId;
if("_uniqueIdInDataFetchStatus" in inputs) {
this.variables._uniqueIdInDataFetchStatus = inputs._uniqueIdInDataFetchStatus;
}

}

if("ShapeType" in inputs) {
this.variables.shapeTypeIn = inputs.ShapeType;
if("_shapeTypeInDataFetchStatus" in inputs) {
this.variables._shapeTypeInDataFetchStatus = inputs._shapeTypeInDataFetchStatus;
}

}

if("Bounds" in inputs) {
this.variables.boundsIn = inputs.Bounds;
if("_boundsInDataFetchStatus" in inputs) {
this.variables._boundsInDataFetchStatus = inputs._boundsInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




