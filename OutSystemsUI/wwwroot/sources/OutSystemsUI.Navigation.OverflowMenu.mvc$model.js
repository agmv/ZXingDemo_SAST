import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_6e6632cfd831e4e0f6a401872bea6eccStructure());
}, false, OutSystemsUIModel.ST_6e6632cfd831e4e0f6a401872bea6eccStructure), 
this.attr("BalloonShape", "balloonShapeIn", "BalloonShape", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.shape.softRounded;
}, false), 
this.attr("_balloonShapeInDataFetchStatus", "_balloonShapeInDataFetchStatus", "_balloonShapeInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("BalloonPosition", "balloonPositionIn", "BalloonPosition", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_balloonPositionInDataFetchStatus", "_balloonPositionInDataFetchStatus", "_balloonPositionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("BalloonShape" in inputs) {
this.variables.balloonShapeIn = inputs.BalloonShape;
if("_balloonShapeInDataFetchStatus" in inputs) {
this.variables._balloonShapeInDataFetchStatus = inputs._balloonShapeInDataFetchStatus;
}

}

if("BalloonPosition" in inputs) {
this.variables.balloonPositionIn = inputs.BalloonPosition;
if("_balloonPositionInDataFetchStatus" in inputs) {
this.variables._balloonPositionInDataFetchStatus = inputs._balloonPositionInDataFetchStatus;
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




