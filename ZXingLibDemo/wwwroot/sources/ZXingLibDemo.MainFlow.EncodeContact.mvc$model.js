import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";

var OS = OSRuntimeCore;

class ContactCardBarcodeDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Image", "imageOut", "Image", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ContactCardBarcodeDataActRec(new ContactCardBarcodeDataActRec.RecordClass({
imageOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

ContactCardBarcodeDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ContactData", "contactDataVar", "ContactData", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new Extension_ZXingLibModel.ST_10cb4adb0f851163080c748983a654c9Structure());
}, false, Extension_ZXingLibModel.ST_10cb4adb0f851163080c748983a654c9Structure), 
this.attr("IsMeCard", "isMeCardVar", "IsMeCard", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ContactCardBarcode", "contactCardBarcodeDataAct", "ContactCardBarcode", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ContactCardBarcodeDataActRec());
}, true, ContactCardBarcodeDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Input_Prefix: OS.Model.ValidationWidgetRecord,
Input_FirstName: OS.Model.ValidationWidgetRecord,
Input_MiddleNames: OS.Model.ValidationWidgetRecord,
Input_LastName: OS.Model.ValidationWidgetRecord,
Input_Suffix: OS.Model.ValidationWidgetRecord,
Input_FullName: OS.Model.ValidationWidgetRecord,
Input_Title2: OS.Model.ValidationWidgetRecord,
Input_Organization: OS.Model.ValidationWidgetRecord,
Input_PhoneNumber: OS.Model.ValidationWidgetRecord,
Input_PhoneNumber2: OS.Model.ValidationWidgetRecord,
Input_PhoneNumber3: OS.Model.ValidationWidgetRecord,
Input_Email: OS.Model.ValidationWidgetRecord,
Input_Address: OS.Model.ValidationWidgetRecord,
Input_Website: OS.Model.ValidationWidgetRecord,
TextArea_notes: OS.Model.ValidationWidgetRecord
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




