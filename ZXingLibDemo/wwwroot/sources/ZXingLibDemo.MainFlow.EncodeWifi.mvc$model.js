import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";

var OS = OSRuntimeCore;

class WifiCardBarcodeDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Image", "imageOut", "Image", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new WifiCardBarcodeDataActRec(new WifiCardBarcodeDataActRec.RecordClass({
imageOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

WifiCardBarcodeDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("WifiData", "wifiDataVar", "WifiData", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new Extension_ZXingLibModel.ST_af04a340a4a61afef041397e6f042234Structure());
}, false, Extension_ZXingLibModel.ST_af04a340a4a61afef041397e6f042234Structure), 
this.attr("WifiCardBarcode", "wifiCardBarcodeDataAct", "WifiCardBarcode", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new WifiCardBarcodeDataActRec());
}, true, WifiCardBarcodeDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Input_SSID: OS.Model.ValidationWidgetRecord,
Input_Password: OS.Model.ValidationWidgetRecord,
Input_authentication: OS.Model.ValidationWidgetRecord,
Checkbox4: OS.Model.ValidationWidgetRecord,
Input_EAPMethod: OS.Model.ValidationWidgetRecord,
Input_AnonymousIdentity: OS.Model.ValidationWidgetRecord,
Input_Identity: OS.Model.ValidationWidgetRecord,
Input_Phase2Method: OS.Model.ValidationWidgetRecord
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




