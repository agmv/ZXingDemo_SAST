import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import OutSystemsUI_Private_LightBox_mvcModel from "./OutSystemsUI.Private.LightBox.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("LightboxObj", "lightboxObjVar", "LightboxObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("Title", "titleIn", "Title", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_titleInDataFetchStatus", "_titleInDataFetchStatus", "_titleInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Group", "groupIn", "Group", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_groupInDataFetchStatus", "_groupInDataFetchStatus", "_groupInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ImageURL", "imageURLIn", "ImageURL", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_imageURLInDataFetchStatus", "_imageURLInDataFetchStatus", "_imageURLInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ImageZoom", "imageZoomIn", "ImageZoom", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(2);
}, false), 
this.attr("_imageZoomInDataFetchStatus", "_imageZoomInDataFetchStatus", "_imageZoomInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = OutSystemsUI_Private_LightBox_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("Title" in inputs) {
this.variables.titleIn = inputs.Title;
if("_titleInDataFetchStatus" in inputs) {
this.variables._titleInDataFetchStatus = inputs._titleInDataFetchStatus;
}

}

if("Group" in inputs) {
this.variables.groupIn = inputs.Group;
if("_groupInDataFetchStatus" in inputs) {
this.variables._groupInDataFetchStatus = inputs._groupInDataFetchStatus;
}

}

if("ImageURL" in inputs) {
this.variables.imageURLIn = inputs.ImageURL;
if("_imageURLInDataFetchStatus" in inputs) {
this.variables._imageURLInDataFetchStatus = inputs._imageURLInDataFetchStatus;
}

}

if("ImageZoom" in inputs) {
this.variables.imageZoomIn = inputs.ImageZoom;
if("_imageZoomInDataFetchStatus" in inputs) {
this.variables._imageZoomInDataFetchStatus = inputs._imageZoomInDataFetchStatus;
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




