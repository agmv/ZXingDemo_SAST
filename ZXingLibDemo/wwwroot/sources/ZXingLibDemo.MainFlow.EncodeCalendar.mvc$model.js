import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;

class CalendarEventBarcodeDataActRec extends 
OS.Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Image", "imageOut", "Image", true, false, OS.DataTypes.DataTypes.BinaryData, function () {
return OS.DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS.Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new CalendarEventBarcodeDataActRec(new CalendarEventBarcodeDataActRec.RecordClass({
imageOut: OS.DataTypes.ImmutableBase.getData(str)
}));
}

}

CalendarEventBarcodeDataActRec.init();


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("CalendarEventData", "calendarEventDataVar", "CalendarEventData", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new Extension_ZXingLibModel.ST_8738e857d4fb6695d1e17d4c03428ee2Structure());
}, false, Extension_ZXingLibModel.ST_8738e857d4fb6695d1e17d4c03428ee2Structure), 
this.attr("CalendarEventBarcode", "calendarEventBarcodeDataAct", "CalendarEventBarcode", true, true, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new CalendarEventBarcodeDataActRec());
}, true, CalendarEventBarcodeDataActRec)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS.Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS.Model.ValidationWidgetRecord,
Input_Title: OS.Model.ValidationWidgetRecord,
Checkbox3: OS.Model.ValidationWidgetRecord,
Input_StartDateTime: OS.Model.ValidationWidgetRecord,
Input_EndDateTime: OS.Model.ValidationWidgetRecord,
Input_Location: OS.Model.ValidationWidgetRecord,
TextArea_description: OS.Model.ValidationWidgetRecord,
Input_eventClass: OS.Model.ValidationWidgetRecord,
Input_organizer: OS.Model.ValidationWidgetRecord,
Input_priority: OS.Model.ValidationWidgetRecord,
Checkbox1: OS.Model.ValidationWidgetRecord
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




