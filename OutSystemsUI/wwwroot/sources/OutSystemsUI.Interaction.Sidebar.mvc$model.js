import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_963c357dbc45b19fade654e21b1521d0Structure());
}, false, OutSystemsUIModel.ST_963c357dbc45b19fade654e21b1521d0Structure), 
this.attr("StartsOpen", "startsOpenIn", "StartsOpen", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_startsOpenInDataFetchStatus", "_startsOpenInDataFetchStatus", "_startsOpenInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Direction", "directionIn", "Direction", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.direction.right;
}, false), 
this.attr("_directionInDataFetchStatus", "_directionInDataFetchStatus", "_directionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("HasOverlay", "hasOverlayIn", "HasOverlay", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_hasOverlayInDataFetchStatus", "_hasOverlayInDataFetchStatus", "_hasOverlayInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Width", "widthIn", "Width", true, false, OS.DataTypes.DataTypes.Text, function () {
return "500px";
}, false), 
this.attr("_widthInDataFetchStatus", "_widthInDataFetchStatus", "_widthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("StartsOpen" in inputs) {
this.variables.startsOpenIn = inputs.StartsOpen;
if("_startsOpenInDataFetchStatus" in inputs) {
this.variables._startsOpenInDataFetchStatus = inputs._startsOpenInDataFetchStatus;
}

}

if("Direction" in inputs) {
this.variables.directionIn = inputs.Direction;
if("_directionInDataFetchStatus" in inputs) {
this.variables._directionInDataFetchStatus = inputs._directionInDataFetchStatus;
}

}

if("HasOverlay" in inputs) {
this.variables.hasOverlayIn = inputs.HasOverlay;
if("_hasOverlayInDataFetchStatus" in inputs) {
this.variables._hasOverlayInDataFetchStatus = inputs._hasOverlayInDataFetchStatus;
}

}

if("Width" in inputs) {
this.variables.widthIn = inputs.Width;
if("_widthInDataFetchStatus" in inputs) {
this.variables._widthInDataFetchStatus = inputs._widthInDataFetchStatus;
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




