import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_69c22c095aca285f3fb706e10e473ba5Structure());
}, false, OutSystemsUIModel.ST_69c22c095aca285f3fb706e10e473ba5Structure), 
this.attr("RatingValue", "ratingValueIn", "RatingValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_ratingValueInDataFetchStatus", "_ratingValueInDataFetchStatus", "_ratingValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RatingScale", "ratingScaleIn", "RatingScale", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 5;
}, false), 
this.attr("_ratingScaleInDataFetchStatus", "_ratingScaleInDataFetchStatus", "_ratingScaleInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsEdit", "isEditIn", "IsEdit", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isEditInDataFetchStatus", "_isEditInDataFetchStatus", "_isEditInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Size", "sizeIn", "Size", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_sizeInDataFetchStatus", "_sizeInDataFetchStatus", "_sizeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("RatingValue" in inputs) {
this.variables.ratingValueIn = inputs.RatingValue;
if("_ratingValueInDataFetchStatus" in inputs) {
this.variables._ratingValueInDataFetchStatus = inputs._ratingValueInDataFetchStatus;
}

}

if("RatingScale" in inputs) {
this.variables.ratingScaleIn = inputs.RatingScale;
if("_ratingScaleInDataFetchStatus" in inputs) {
this.variables._ratingScaleInDataFetchStatus = inputs._ratingScaleInDataFetchStatus;
}

}

if("IsEdit" in inputs) {
this.variables.isEditIn = inputs.IsEdit;
if("_isEditInDataFetchStatus" in inputs) {
this.variables._isEditInDataFetchStatus = inputs._isEditInDataFetchStatus;
}

}

if("Size" in inputs) {
this.variables.sizeIn = inputs.Size;
if("_sizeInDataFetchStatus" in inputs) {
this.variables._sizeInDataFetchStatus = inputs._sizeInDataFetchStatus;
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




