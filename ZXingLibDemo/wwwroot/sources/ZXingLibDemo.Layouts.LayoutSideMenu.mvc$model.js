import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import "./ZXingLibDemo.referencesHealth.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import ZXingLibDemo_Common_MenuIcon_mvcModel from "./ZXingLibDemo.Common.MenuIcon.mvc$model.js";
import ZXingLibDemo_Common_ApplicationTitle_mvcModel from "./ZXingLibDemo.Common.ApplicationTitle.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("HasFixedHeader", "hasFixedHeaderIn", "HasFixedHeader", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_hasFixedHeaderInDataFetchStatus", "_hasFixedHeaderInDataFetchStatus", "_hasFixedHeaderInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MenuBehavior", "menuBehaviorIn", "MenuBehavior", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_menuBehaviorInDataFetchStatus", "_menuBehaviorInDataFetchStatus", "_menuBehaviorInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("EnableAccessibilityFeatures", "enableAccessibilityFeaturesIn", "EnableAccessibilityFeatures", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_enableAccessibilityFeaturesInDataFetchStatus", "_enableAccessibilityFeaturesInDataFetchStatus", "_enableAccessibilityFeaturesInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = (ZXingLibDemo_Common_MenuIcon_mvcModel.hasValidationWidgets || ZXingLibDemo_Common_ApplicationTitle_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("HasFixedHeader" in inputs) {
this.variables.hasFixedHeaderIn = inputs.HasFixedHeader;
if("_hasFixedHeaderInDataFetchStatus" in inputs) {
this.variables._hasFixedHeaderInDataFetchStatus = inputs._hasFixedHeaderInDataFetchStatus;
}

}

if("MenuBehavior" in inputs) {
this.variables.menuBehaviorIn = inputs.MenuBehavior;
if("_menuBehaviorInDataFetchStatus" in inputs) {
this.variables._menuBehaviorInDataFetchStatus = inputs._menuBehaviorInDataFetchStatus;
}

}

if("EnableAccessibilityFeatures" in inputs) {
this.variables.enableAccessibilityFeaturesIn = inputs.EnableAccessibilityFeatures;
if("_enableAccessibilityFeaturesInDataFetchStatus" in inputs) {
this.variables._enableAccessibilityFeaturesInDataFetchStatus = inputs._enableAccessibilityFeaturesInDataFetchStatus;
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




