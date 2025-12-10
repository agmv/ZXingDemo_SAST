import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";

var OS = OSRuntimeCore;

class DecodeBarcodeDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Barcodes", "barcodesOut", "Barcodes", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(Extension_ZXingLibModel.ST_7750e71a4e018dabac19d9f560c2b017Structure))());
}, true, (OS.GenericTypeCache.getGenericList(Extension_ZXingLibModel.ST_7750e71a4e018dabac19d9f560c2b017Structure)))
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new DecodeBarcodeDataActRec(new DecodeBarcodeDataActRec.RecordClass({
barcodesOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

DecodeBarcodeDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("BarcodeBinaryData", "barcodeBinaryDataVar", "BarcodeBinaryData", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("Filename", "filenameVar", "Filename", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FormatHint", "formatHintVar", "FormatHint", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsDecodeMulti", "isDecodeMultiVar", "IsDecodeMulti", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DecodeBarcode", "decodeBarcodeDataAct", "DecodeBarcode", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new DecodeBarcodeDataActRec());
}, true, DecodeBarcodeDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Upload1: OS.Model.ValidationWidgetRecord,
Input_FormatHint: OS.Model.ValidationWidgetRecord
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




