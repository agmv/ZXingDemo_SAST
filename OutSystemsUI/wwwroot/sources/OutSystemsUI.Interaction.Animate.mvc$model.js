import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AnimationType", "animationTypeIn", "AnimationType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_animationTypeInDataFetchStatus", "_animationTypeInDataFetchStatus", "_animationTypeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Delay", "delayIn", "Delay", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_delayInDataFetchStatus", "_delayInDataFetchStatus", "_delayInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Speed", "speedIn", "Speed", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_speedInDataFetchStatus", "_speedInDataFetchStatus", "_speedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("AnimationType" in inputs) {
this.variables.animationTypeIn = inputs.AnimationType;
if("_animationTypeInDataFetchStatus" in inputs) {
this.variables._animationTypeInDataFetchStatus = inputs._animationTypeInDataFetchStatus;
}

}

if("Delay" in inputs) {
this.variables.delayIn = inputs.Delay;
if("_delayInDataFetchStatus" in inputs) {
this.variables._delayInDataFetchStatus = inputs._delayInDataFetchStatus;
}

}

if("Speed" in inputs) {
this.variables.speedIn = inputs.Speed;
if("_speedInDataFetchStatus" in inputs) {
this.variables._speedInDataFetchStatus = inputs._speedInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




