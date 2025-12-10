import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUI_Utilities_TouchEvents_mvcModel from "./OutSystemsUI.Utilities.TouchEvents.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ActiveTab", "activeTabVar", "ActiveTab", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("IsMoving", "isMovingVar", "IsMoving", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("TabsWidth", "tabsWidthVar", "TabsWidth", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("DragDirection", "dragDirectionVar", "DragDirection", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("LastX", "lastXVar", "LastX", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("LastY", "lastYVar", "LastY", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("MoveX", "moveXVar", "MoveX", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TabsNumber", "tabsNumberVar", "TabsNumber", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("DragDirectionH", "dragDirectionHVar", "DragDirectionH", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FirstTime", "firstTimeVar", "FirstTime", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Velocity", "velocityVar", "Velocity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.3"));
}, false), 
this.attr("IsRTL", "isRTLVar", "IsRTL", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ContainsClass", "containsClassVar", "ContainsClass", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsWebApp", "isWebAppVar", "IsWebApp", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsFirstTimeLoad", "isFirstTimeLoadVar", "IsFirstTimeLoad", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("IsLayoutNative", "isLayoutNativeVar", "IsLayoutNative", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RTLCallback", "rTLCallbackVar", "RTLCallback", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("StartingTab", "startingTabIn", "StartingTab", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_startingTabInDataFetchStatus", "_startingTabInDataFetchStatus", "_startingTabInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsJustified", "isJustifiedIn", "IsJustified", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isJustifiedInDataFetchStatus", "_isJustifiedInDataFetchStatus", "_isJustifiedInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsVertical", "isVerticalIn", "IsVertical", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsRight", "isRightIn", "IsRight", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isRightInDataFetchStatus", "_isRightInDataFetchStatus", "_isRightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = OutSystemsUI_Utilities_TouchEvents_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StartingTab" in inputs) {
this.variables.startingTabIn = inputs.StartingTab;
if("_startingTabInDataFetchStatus" in inputs) {
this.variables._startingTabInDataFetchStatus = inputs._startingTabInDataFetchStatus;
}

}

if("IsJustified" in inputs) {
this.variables.isJustifiedIn = inputs.IsJustified;
if("_isJustifiedInDataFetchStatus" in inputs) {
this.variables._isJustifiedInDataFetchStatus = inputs._isJustifiedInDataFetchStatus;
}

}

if("IsVertical" in inputs) {
this.variables.isVerticalIn = inputs.IsVertical;
if("_isVerticalInDataFetchStatus" in inputs) {
this.variables._isVerticalInDataFetchStatus = inputs._isVerticalInDataFetchStatus;
}

}

if("IsRight" in inputs) {
this.variables.isRightIn = inputs.IsRight;
if("_isRightInDataFetchStatus" in inputs) {
this.variables._isRightInDataFetchStatus = inputs._isRightInDataFetchStatus;
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




