import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SliderObject", "sliderObjectVar", "SliderObject", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("CurrentValue", "currentValueVar", "CurrentValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("CurrentOptions", "currentOptionsVar", "CurrentOptions", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.RC_c3613394da5ea68f302177112ad784ed());
}, false, OutSystemsUIModel.RC_c3613394da5ea68f302177112ad784ed), 
this.attr("IsSliding", "isSlidingVar", "IsSliding", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RTLCallback", "rTLCallbackVar", "RTLCallback", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("MinValue", "minValueIn", "MinValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_minValueInDataFetchStatus", "_minValueInDataFetchStatus", "_minValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxValue", "maxValueIn", "MaxValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_maxValueInDataFetchStatus", "_maxValueInDataFetchStatus", "_maxValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InitialValue", "initialValueIn", "InitialValue", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_initialValueInDataFetchStatus", "_initialValueInDataFetchStatus", "_initialValueInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Step", "stepIn", "Step", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, false), 
this.attr("_stepInDataFetchStatus", "_stepInDataFetchStatus", "_stepInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowPips", "showPipsIn", "ShowPips", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_showPipsInDataFetchStatus", "_showPipsInDataFetchStatus", "_showPipsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("PipsStep", "pipsStepIn", "PipsStep", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_pipsStepInDataFetchStatus", "_pipsStepInDataFetchStatus", "_pipsStepInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ChangeEventDuringSlide", "changeEventDuringSlideIn", "ChangeEventDuringSlide", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_changeEventDuringSlideInDataFetchStatus", "_changeEventDuringSlideInDataFetchStatus", "_changeEventDuringSlideInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsDisabled", "isDisabledIn", "IsDisabled", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", "_isDisabledInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsVertical", "isVerticalIn", "IsVertical", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", "_isVerticalInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("VerticalHeight", "verticalHeightIn", "VerticalHeight", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 100;
}, false), 
this.attr("_verticalHeightInDataFetchStatus", "_verticalHeightInDataFetchStatus", "_verticalHeightInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AdvancedFormat", "advancedFormatIn", "AdvancedFormat", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", "_advancedFormatInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("MinValue" in inputs) {
this.variables.minValueIn = inputs.MinValue;
if("_minValueInDataFetchStatus" in inputs) {
this.variables._minValueInDataFetchStatus = inputs._minValueInDataFetchStatus;
}

}

if("MaxValue" in inputs) {
this.variables.maxValueIn = inputs.MaxValue;
if("_maxValueInDataFetchStatus" in inputs) {
this.variables._maxValueInDataFetchStatus = inputs._maxValueInDataFetchStatus;
}

}

if("InitialValue" in inputs) {
this.variables.initialValueIn = inputs.InitialValue;
if("_initialValueInDataFetchStatus" in inputs) {
this.variables._initialValueInDataFetchStatus = inputs._initialValueInDataFetchStatus;
}

}

if("Step" in inputs) {
this.variables.stepIn = inputs.Step;
if("_stepInDataFetchStatus" in inputs) {
this.variables._stepInDataFetchStatus = inputs._stepInDataFetchStatus;
}

}

if("ShowPips" in inputs) {
this.variables.showPipsIn = inputs.ShowPips;
if("_showPipsInDataFetchStatus" in inputs) {
this.variables._showPipsInDataFetchStatus = inputs._showPipsInDataFetchStatus;
}

}

if("PipsStep" in inputs) {
this.variables.pipsStepIn = inputs.PipsStep;
if("_pipsStepInDataFetchStatus" in inputs) {
this.variables._pipsStepInDataFetchStatus = inputs._pipsStepInDataFetchStatus;
}

}

if("ChangeEventDuringSlide" in inputs) {
this.variables.changeEventDuringSlideIn = inputs.ChangeEventDuringSlide;
if("_changeEventDuringSlideInDataFetchStatus" in inputs) {
this.variables._changeEventDuringSlideInDataFetchStatus = inputs._changeEventDuringSlideInDataFetchStatus;
}

}

if("IsDisabled" in inputs) {
this.variables.isDisabledIn = inputs.IsDisabled;
if("_isDisabledInDataFetchStatus" in inputs) {
this.variables._isDisabledInDataFetchStatus = inputs._isDisabledInDataFetchStatus;
}

}

if("IsVertical" in inputs) {
this.variables.isVerticalIn = inputs.IsVertical;
if("_isVerticalInDataFetchStatus" in inputs) {
this.variables._isVerticalInDataFetchStatus = inputs._isVerticalInDataFetchStatus;
}

}

if("VerticalHeight" in inputs) {
this.variables.verticalHeightIn = inputs.VerticalHeight;
if("_verticalHeightInDataFetchStatus" in inputs) {
this.variables._verticalHeightInDataFetchStatus = inputs._verticalHeightInDataFetchStatus;
}

}

if("AdvancedFormat" in inputs) {
this.variables.advancedFormatIn = inputs.AdvancedFormat;
if("_advancedFormatInDataFetchStatus" in inputs) {
this.variables._advancedFormatInDataFetchStatus = inputs._advancedFormatInDataFetchStatus;
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




