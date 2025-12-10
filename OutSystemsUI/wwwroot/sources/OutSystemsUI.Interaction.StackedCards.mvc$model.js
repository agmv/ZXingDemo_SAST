import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import OutSystemsUI_Utilities_TouchEvents_mvcModel from "./OutSystemsUI.Utilities.TouchEvents.mvc$model.js";
import OutSystemsUI_Utilities_MouseEvents_mvcModel from "./OutSystemsUI.Utilities.MouseEvents.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MaxElements", "maxElementsVar", "MaxElements", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("CurrentPosition", "currentPositionVar", "CurrentPosition", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("Velocity", "velocityVar", "Velocity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.3"));
}, false), 
this.attr("LeftObj", "leftObjVar", "LeftObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("RightObj", "rightObjVar", "RightObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("TopObj", "topObjVar", "TopObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("ListElNodesObj", "listElNodesObjVar", "ListElNodesObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("ListElNodesWidth", "listElNodesWidthVar", "ListElNodesWidth", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("CurrentElementObj", "currentElementObjVar", "CurrentElementObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("StackedCardsObj", "stackedCardsObjVar", "StackedCardsObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("IsFirstTime", "isFirstTimeVar", "IsFirstTime", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("ElementHeight", "elementHeightVar", "ElementHeight", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, false), 
this.attr("WcagText", "wcagTextVar", "WcagText", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StackedOptions", "stackedOptionsIn", "StackedOptions", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.stackedCardsPosition.bottom;
}, false), 
this.attr("_stackedOptionsInDataFetchStatus", "_stackedOptionsInDataFetchStatus", "_stackedOptionsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Rotate", "rotateIn", "Rotate", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_rotateInDataFetchStatus", "_rotateInDataFetchStatus", "_rotateInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Items", "itemsIn", "Items", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 5;
}, false), 
this.attr("_itemsInDataFetchStatus", "_itemsInDataFetchStatus", "_itemsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ElementsMargin", "elementsMarginIn", "ElementsMargin", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 5;
}, false), 
this.attr("_elementsMarginInDataFetchStatus", "_elementsMarginInDataFetchStatus", "_elementsMarginInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("UseOverlays", "useOverlaysIn", "UseOverlays", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_useOverlaysInDataFetchStatus", "_useOverlaysInDataFetchStatus", "_useOverlaysInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Utilities_TouchEvents_mvcModel.hasValidationWidgets || OutSystemsUI_Utilities_MouseEvents_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StackedOptions" in inputs) {
this.variables.stackedOptionsIn = inputs.StackedOptions;
if("_stackedOptionsInDataFetchStatus" in inputs) {
this.variables._stackedOptionsInDataFetchStatus = inputs._stackedOptionsInDataFetchStatus;
}

}

if("Rotate" in inputs) {
this.variables.rotateIn = inputs.Rotate;
if("_rotateInDataFetchStatus" in inputs) {
this.variables._rotateInDataFetchStatus = inputs._rotateInDataFetchStatus;
}

}

if("Items" in inputs) {
this.variables.itemsIn = inputs.Items;
if("_itemsInDataFetchStatus" in inputs) {
this.variables._itemsInDataFetchStatus = inputs._itemsInDataFetchStatus;
}

}

if("ElementsMargin" in inputs) {
this.variables.elementsMarginIn = inputs.ElementsMargin;
if("_elementsMarginInDataFetchStatus" in inputs) {
this.variables._elementsMarginInDataFetchStatus = inputs._elementsMarginInDataFetchStatus;
}

}

if("UseOverlays" in inputs) {
this.variables.useOverlaysIn = inputs.UseOverlays;
if("_useOverlaysInDataFetchStatus" in inputs) {
this.variables._useOverlaysInDataFetchStatus = inputs._useOverlaysInDataFetchStatus;
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




