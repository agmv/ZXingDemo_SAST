import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TimeoutId", "timeoutIdVar", "TimeoutId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("IntervalId", "intervalIdVar", "IntervalId", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MinimumDisplayTimeMs", "minimumDisplayTimeMsIn", "MinimumDisplayTimeMs", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1000;
}, false), 
this.attr("_minimumDisplayTimeMsInDataFetchStatus", "_minimumDisplayTimeMsInDataFetchStatus", "_minimumDisplayTimeMsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("MinimumDisplayTimeMs" in inputs) {
this.variables.minimumDisplayTimeMsIn = inputs.MinimumDisplayTimeMs;
if("_minimumDisplayTimeMsInDataFetchStatus" in inputs) {
this.variables._minimumDisplayTimeMsInDataFetchStatus = inputs._minimumDisplayTimeMsInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




