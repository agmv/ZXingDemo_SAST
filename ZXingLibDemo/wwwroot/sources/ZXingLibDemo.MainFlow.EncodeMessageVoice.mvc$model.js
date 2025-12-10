import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";

var OS = OSRuntimeCore;

class MessageBarcodeDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Image", "imageOut", "Image", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new MessageBarcodeDataActRec(new MessageBarcodeDataActRec.RecordClass({
imageOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

MessageBarcodeDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Email", "emailVar", "Email", true, false, OS.DataTypes.DataTypes.Email, function () {
return "";
}, false), 
this.attr("PhoneNumber", "phoneNumberVar", "PhoneNumber", true, false, OS.DataTypes.DataTypes.PhoneNumber, function () {
return "";
}, false), 
this.attr("SMS", "sMSVar", "SMS", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("MessageType", "messageTypeVar", "MessageType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("MessageBarcode", "messageBarcodeDataAct", "MessageBarcode", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new MessageBarcodeDataActRec());
}, true, MessageBarcodeDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Input_Email2: OS.Model.ValidationWidgetRecord,
Input_PhoneNumber2: OS.Model.ValidationWidgetRecord,
Input_SMS: OS.Model.ValidationWidgetRecord
};
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

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




