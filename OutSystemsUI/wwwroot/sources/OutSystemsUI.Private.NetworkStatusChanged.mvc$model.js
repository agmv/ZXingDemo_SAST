import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsOnline", "isOnlineVar", "IsOnline", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("OfflineActionReference", "offlineActionReferenceVar", "OfflineActionReference", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("OnlineActionReference", "onlineActionReferenceVar", "OnlineActionReference", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("DeviceReadyActionReference", "deviceReadyActionReferenceVar", "DeviceReadyActionReference", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




