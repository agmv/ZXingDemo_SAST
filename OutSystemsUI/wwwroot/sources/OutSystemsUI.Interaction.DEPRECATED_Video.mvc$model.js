import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsPlaying", "isPlayingVar", "IsPlaying", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("VideoURL", "videoURLIn", "VideoURL", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_videoURLInDataFetchStatus", "_videoURLInDataFetchStatus", "_videoURLInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("PosterURL", "posterURLIn", "PosterURL", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_posterURLInDataFetchStatus", "_posterURLInDataFetchStatus", "_posterURLInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Width", "widthIn", "Width", true, false, OS.DataTypes.DataTypes.Text, function () {
return "100%";
}, false), 
this.attr("_widthInDataFetchStatus", "_widthInDataFetchStatus", "_widthInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Height", "heightIn", "Height", true, false, OS.DataTypes.DataTypes.Text, function () {
return "100%";
}, false), 
this.attr("_heightInDataFetchStatus", "_heightInDataFetchStatus", "_heightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Muted", "mutedIn", "Muted", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_mutedInDataFetchStatus", "_mutedInDataFetchStatus", "_mutedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Loop", "loopIn", "Loop", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_loopInDataFetchStatus", "_loopInDataFetchStatus", "_loopInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Controls", "controlsIn", "Controls", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_controlsInDataFetchStatus", "_controlsInDataFetchStatus", "_controlsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Autoplay", "autoplayIn", "Autoplay", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_autoplayInDataFetchStatus", "_autoplayInDataFetchStatus", "_autoplayInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("VideoURL" in inputs) {
this.variables.videoURLIn = inputs.VideoURL;
if("_videoURLInDataFetchStatus" in inputs) {
this.variables._videoURLInDataFetchStatus = inputs._videoURLInDataFetchStatus;
}

}

if("PosterURL" in inputs) {
this.variables.posterURLIn = inputs.PosterURL;
if("_posterURLInDataFetchStatus" in inputs) {
this.variables._posterURLInDataFetchStatus = inputs._posterURLInDataFetchStatus;
}

}

if("Width" in inputs) {
this.variables.widthIn = inputs.Width;
if("_widthInDataFetchStatus" in inputs) {
this.variables._widthInDataFetchStatus = inputs._widthInDataFetchStatus;
}

}

if("Height" in inputs) {
this.variables.heightIn = inputs.Height;
if("_heightInDataFetchStatus" in inputs) {
this.variables._heightInDataFetchStatus = inputs._heightInDataFetchStatus;
}

}

if("Muted" in inputs) {
this.variables.mutedIn = inputs.Muted;
if("_mutedInDataFetchStatus" in inputs) {
this.variables._mutedInDataFetchStatus = inputs._mutedInDataFetchStatus;
}

}

if("Loop" in inputs) {
this.variables.loopIn = inputs.Loop;
if("_loopInDataFetchStatus" in inputs) {
this.variables._loopInDataFetchStatus = inputs._loopInDataFetchStatus;
}

}

if("Controls" in inputs) {
this.variables.controlsIn = inputs.Controls;
if("_controlsInDataFetchStatus" in inputs) {
this.variables._controlsInDataFetchStatus = inputs._controlsInDataFetchStatus;
}

}

if("Autoplay" in inputs) {
this.variables.autoplayIn = inputs.Autoplay;
if("_autoplayInDataFetchStatus" in inputs) {
this.variables._autoplayInDataFetchStatus = inputs._autoplayInDataFetchStatus;
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




