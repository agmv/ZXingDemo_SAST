import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("CircleObj", "circleObjVar", "CircleObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("Size", "sizeVar", "Size", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("PreviousProgressColor", "previousProgressColorVar", "PreviousProgressColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Progress", "progressIn", "Progress", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_progressInDataFetchStatus", "_progressInDataFetchStatus", "_progressInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Text", "textIn", "Text", true, false, OS.DataTypes.DataTypes.Text, function () {
return "-";
}, false), 
this.attr("_textInDataFetchStatus", "_textInDataFetchStatus", "_textInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ProgressColor", "progressColorIn", "ProgressColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "rgba(0,0,0,0.6)";
}, false), 
this.attr("_progressColorInDataFetchStatus", "_progressColorInDataFetchStatus", "_progressColorInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("TrailColor", "trailColorIn", "TrailColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "rgba(0,0,0,0.2)";
}, false), 
this.attr("_trailColorInDataFetchStatus", "_trailColorInDataFetchStatus", "_trailColorInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("TextColor", "textColorIn", "TextColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#333";
}, false), 
this.attr("_textColorInDataFetchStatus", "_textColorInDataFetchStatus", "_textColorInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("CircleThickness", "circleThicknessIn", "CircleThickness", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 8;
}, false), 
this.attr("_circleThicknessInDataFetchStatus", "_circleThicknessInDataFetchStatus", "_circleThicknessInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AnimateInitialProgress", "animateInitialProgressIn", "AnimateInitialProgress", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_animateInitialProgressInDataFetchStatus", "_animateInitialProgressInDataFetchStatus", "_animateInitialProgressInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("Progress" in inputs) {
this.variables.progressIn = inputs.Progress;
if("_progressInDataFetchStatus" in inputs) {
this.variables._progressInDataFetchStatus = inputs._progressInDataFetchStatus;
}

}

if("Text" in inputs) {
this.variables.textIn = inputs.Text;
if("_textInDataFetchStatus" in inputs) {
this.variables._textInDataFetchStatus = inputs._textInDataFetchStatus;
}

}

if("ProgressColor" in inputs) {
this.variables.progressColorIn = inputs.ProgressColor;
if("_progressColorInDataFetchStatus" in inputs) {
this.variables._progressColorInDataFetchStatus = inputs._progressColorInDataFetchStatus;
}

}

if("TrailColor" in inputs) {
this.variables.trailColorIn = inputs.TrailColor;
if("_trailColorInDataFetchStatus" in inputs) {
this.variables._trailColorInDataFetchStatus = inputs._trailColorInDataFetchStatus;
}

}

if("TextColor" in inputs) {
this.variables.textColorIn = inputs.TextColor;
if("_textColorInDataFetchStatus" in inputs) {
this.variables._textColorInDataFetchStatus = inputs._textColorInDataFetchStatus;
}

}

if("CircleThickness" in inputs) {
this.variables.circleThicknessIn = inputs.CircleThickness;
if("_circleThicknessInDataFetchStatus" in inputs) {
this.variables._circleThicknessInDataFetchStatus = inputs._circleThicknessInDataFetchStatus;
}

}

if("AnimateInitialProgress" in inputs) {
this.variables.animateInitialProgressIn = inputs.AnimateInitialProgress;
if("_animateInitialProgressInDataFetchStatus" in inputs) {
this.variables._animateInitialProgressInDataFetchStatus = inputs._animateInitialProgressInDataFetchStatus;
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




