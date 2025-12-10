import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import OutSystemsUI_Utilities_TouchEvents_mvcModel from "./OutSystemsUI.Utilities.TouchEvents.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Threshold", "thresholdVar", "Threshold", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 10;
}, false), 
this.attr("Velocity", "velocityVar", "Velocity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.3"));
}, false), 
this.attr("WidgetId", "widgetIdIn", "WidgetId", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_widgetIdInDataFetchStatus", "_widgetIdInDataFetchStatus", "_widgetIdInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = OutSystemsUI_Utilities_TouchEvents_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("WidgetId" in inputs) {
this.variables.widgetIdIn = inputs.WidgetId;
if("_widgetIdInDataFetchStatus" in inputs) {
this.variables._widgetIdInDataFetchStatus = inputs._widgetIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




