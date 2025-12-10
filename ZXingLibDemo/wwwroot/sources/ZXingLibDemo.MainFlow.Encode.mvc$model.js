import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";

var OS = OSRuntimeCore;

class GetBarcodeDefaultsDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Code", "codeOut", "Code", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ZXingLibDemoModel.EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord());
}, true, ZXingLibDemoModel.EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetBarcodeDefaultsDataActRec(new GetBarcodeDefaultsDataActRec.RecordClass({
codeOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

GetBarcodeDefaultsDataActRec.init();

class GetCodesDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Formats", "formatsOut", "Formats", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetCodesDataActRec(new GetCodesDataActRec.RecordClass({
formatsOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCodesDataActRec.init();

class EncodeBarcodeImageDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Image", "imageOut", "Image", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EncodeBarcodeImageDataActRec(new EncodeBarcodeImageDataActRec.RecordClass({
imageOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

EncodeBarcodeImageDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Filename", "filenameVar", "Filename", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("BarcodeFormat", "barcodeFormatVar", "BarcodeFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Value", "valueVar", "Value", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Width", "widthVar", "Width", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("Height", "heightVar", "Height", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("OverlayImage", "overlayImageVar", "OverlayImage", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("IsPureBarcode", "isPureBarcodeVar", "IsPureBarcode", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("UseGS1Format", "useGS1FormatVar", "UseGS1Format", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("QRCodeVersion", "qRCodeVersionVar", "QRCodeVersion", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("Margin", "marginVar", "Margin", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("NoPadding", "noPaddingVar", "NoPadding", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("Encoding", "encodingVar", "Encoding", true, false, OS.DataTypes.DataTypes.Text, function () {
return "UTF-8";
}, false), 
this.attr("ErrorCorrection", "errorCorrectionVar", "ErrorCorrection", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ForceShape", "forceShapeVar", "ForceShape", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetBarcodeDefaults", "getBarcodeDefaultsDataAct", "GetBarcodeDefaults", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetBarcodeDefaultsDataActRec());
}, true, GetBarcodeDefaultsDataActRec), 
this.attr("GetCodes", "getCodesDataAct", "GetCodes", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new GetCodesDataActRec());
}, true, GetCodesDataActRec), 
this.attr("EncodeBarcodeImage", "encodeBarcodeImageDataAct", "EncodeBarcodeImage", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new EncodeBarcodeImageDataActRec());
}, true, EncodeBarcodeImageDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Dropdown_Code: OS.Model.ValidationWidgetRecord,
TextArea_TextVar: OS.Model.ValidationWidgetRecord,
Input_Width: OS.Model.ValidationWidgetRecord,
Input_Height: OS.Model.ValidationWidgetRecord,
Input_Margin: OS.Model.ValidationWidgetRecord,
Checkbox3: OS.Model.ValidationWidgetRecord,
Input_Encoding: OS.Model.ValidationWidgetRecord,
Input_QRCodeVersion: OS.Model.ValidationWidgetRecord,
Input_ForceShape: OS.Model.ValidationWidgetRecord,
Checkbox2: OS.Model.ValidationWidgetRecord,
Checkbox1: OS.Model.ValidationWidgetRecord,
Input_ErrorCorrection: OS.Model.ValidationWidgetRecord,
Input_OverlayImage: OS.Model.ValidationWidgetRecord
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




