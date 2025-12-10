import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUI_Utilities_TouchEvents_mvcModel from "./OutSystemsUI.Utilities.TouchEvents.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("HasNoTransition", "hasNoTransitionVar", "HasNoTransition", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("MoveY", "moveYVar", "MoveY", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("IsMoving", "isMovingVar", "IsMoving", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LastY", "lastYVar", "LastY", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("LastX", "lastXVar", "LastX", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("NotificationHeight", "notificationHeightVar", "NotificationHeight", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("DragDirection", "dragDirectionVar", "DragDirection", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Velocity", "velocityVar", "Velocity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.3"));
}, false), 
this.attr("IsNotificationOpen", "isNotificationOpenVar", "IsNotificationOpen", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsWebApp", "isWebAppVar", "IsWebApp", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsOpen", "isOpenIn", "IsOpen", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isOpenInDataFetchStatus", "_isOpenInDataFetchStatus", "_isOpenInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = OutSystemsUI_Utilities_TouchEvents_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("IsOpen" in inputs) {
this.variables.isOpenIn = inputs.IsOpen;
if("_isOpenInDataFetchStatus" in inputs) {
this.variables._isOpenInDataFetchStatus = inputs._isOpenInDataFetchStatus;
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




