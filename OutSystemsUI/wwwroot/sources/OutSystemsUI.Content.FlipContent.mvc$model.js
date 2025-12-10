import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_e828cdbd51e0c1ef095bd323f6e2875aStructure());
}, false, OutSystemsUIModel.ST_e828cdbd51e0c1ef095bd323f6e2875aStructure), 
this.attr("IsPatternBuilt", "isPatternBuiltVar", "IsPatternBuilt", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("StartsFlipped", "startsFlippedIn", "StartsFlipped", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_startsFlippedInDataFetchStatus", "_startsFlippedInDataFetchStatus", "_startsFlippedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("FlipOnClick", "flipOnClickIn", "FlipOnClick", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_flipOnClickInDataFetchStatus", "_flipOnClickInDataFetchStatus", "_flipOnClickInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("StartsFlipped" in inputs) {
this.variables.startsFlippedIn = inputs.StartsFlipped;
if("_startsFlippedInDataFetchStatus" in inputs) {
this.variables._startsFlippedInDataFetchStatus = inputs._startsFlippedInDataFetchStatus;
}

}

if("FlipOnClick" in inputs) {
this.variables.flipOnClickIn = inputs.FlipOnClick;
if("_flipOnClickInDataFetchStatus" in inputs) {
this.variables._flipOnClickInDataFetchStatus = inputs._flipOnClickInDataFetchStatus;
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




