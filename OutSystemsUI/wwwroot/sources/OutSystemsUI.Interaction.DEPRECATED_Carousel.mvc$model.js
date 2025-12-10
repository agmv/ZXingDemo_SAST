import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUI_Utilities_TouchEvents_mvcModel from "./OutSystemsUI.Utilities.TouchEvents.mvc$model.js";
import OutSystemsUI_Utilities_MouseEvents_mvcModel from "./OutSystemsUI.Utilities.MouseEvents.mvc$model.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AutplayObj", "autplayObjVar", "AutplayObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("CarouselObj", "carouselObjVar", "CarouselObj", true, false, OS.DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("Velocity", "velocityVar", "Velocity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.3"));
}, false), 
this.attr("IsAnimating", "isAnimatingVar", "IsAnimating", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ContainsClass", "containsClassVar", "ContainsClass", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DragDirection", "dragDirectionVar", "DragDirection", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("currentDevice", "currentDeviceVar", "currentDevice", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("AddDragEvents", "addDragEventsVar", "AddDragEvents", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Navigation", "navigationIn", "Navigation", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_navigationInDataFetchStatus", "_navigationInDataFetchStatus", "_navigationInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Dots", "dotsIn", "Dots", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_dotsInDataFetchStatus", "_dotsInDataFetchStatus", "_dotsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Margin", "marginIn", "Margin", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_marginInDataFetchStatus", "_marginInDataFetchStatus", "_marginInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Padding", "paddingIn", "Padding", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_paddingInDataFetchStatus", "_paddingInDataFetchStatus", "_paddingInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Autoplay", "autoplayIn", "Autoplay", true, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsUIModel.staticEntities.autoplay.disabled;
}, false), 
this.attr("_autoplayInDataFetchStatus", "_autoplayInDataFetchStatus", "_autoplayInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Scale", "scaleIn", "Scale", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_scaleInDataFetchStatus", "_scaleInDataFetchStatus", "_scaleInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Loop", "loopIn", "Loop", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_loopInDataFetchStatus", "_loopInDataFetchStatus", "_loopInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Center", "centerIn", "Center", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_centerInDataFetchStatus", "_centerInDataFetchStatus", "_centerInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InitialPosition", "initialPositionIn", "InitialPosition", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_initialPositionInDataFetchStatus", "_initialPositionInDataFetchStatus", "_initialPositionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsPhone", "itemsPhoneIn", "ItemsPhone", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("_itemsPhoneInDataFetchStatus", "_itemsPhoneInDataFetchStatus", "_itemsPhoneInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsTablet", "itemsTabletIn", "ItemsTablet", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("_itemsTabletInDataFetchStatus", "_itemsTabletInDataFetchStatus", "_itemsTabletInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsDesktop", "itemsDesktopIn", "ItemsDesktop", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("_itemsDesktopInDataFetchStatus", "_itemsDesktopInDataFetchStatus", "_itemsDesktopInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("Navigation" in inputs) {
this.variables.navigationIn = inputs.Navigation;
if("_navigationInDataFetchStatus" in inputs) {
this.variables._navigationInDataFetchStatus = inputs._navigationInDataFetchStatus;
}

}

if("Dots" in inputs) {
this.variables.dotsIn = inputs.Dots;
if("_dotsInDataFetchStatus" in inputs) {
this.variables._dotsInDataFetchStatus = inputs._dotsInDataFetchStatus;
}

}

if("Margin" in inputs) {
this.variables.marginIn = inputs.Margin;
if("_marginInDataFetchStatus" in inputs) {
this.variables._marginInDataFetchStatus = inputs._marginInDataFetchStatus;
}

}

if("Padding" in inputs) {
this.variables.paddingIn = inputs.Padding;
if("_paddingInDataFetchStatus" in inputs) {
this.variables._paddingInDataFetchStatus = inputs._paddingInDataFetchStatus;
}

}

if("Autoplay" in inputs) {
this.variables.autoplayIn = inputs.Autoplay;
if("_autoplayInDataFetchStatus" in inputs) {
this.variables._autoplayInDataFetchStatus = inputs._autoplayInDataFetchStatus;
}

}

if("Scale" in inputs) {
this.variables.scaleIn = inputs.Scale;
if("_scaleInDataFetchStatus" in inputs) {
this.variables._scaleInDataFetchStatus = inputs._scaleInDataFetchStatus;
}

}

if("Loop" in inputs) {
this.variables.loopIn = inputs.Loop;
if("_loopInDataFetchStatus" in inputs) {
this.variables._loopInDataFetchStatus = inputs._loopInDataFetchStatus;
}

}

if("Center" in inputs) {
this.variables.centerIn = inputs.Center;
if("_centerInDataFetchStatus" in inputs) {
this.variables._centerInDataFetchStatus = inputs._centerInDataFetchStatus;
}

}

if("InitialPosition" in inputs) {
this.variables.initialPositionIn = inputs.InitialPosition;
if("_initialPositionInDataFetchStatus" in inputs) {
this.variables._initialPositionInDataFetchStatus = inputs._initialPositionInDataFetchStatus;
}

}

if("ItemsPhone" in inputs) {
this.variables.itemsPhoneIn = inputs.ItemsPhone;
if("_itemsPhoneInDataFetchStatus" in inputs) {
this.variables._itemsPhoneInDataFetchStatus = inputs._itemsPhoneInDataFetchStatus;
}

}

if("ItemsTablet" in inputs) {
this.variables.itemsTabletIn = inputs.ItemsTablet;
if("_itemsTabletInDataFetchStatus" in inputs) {
this.variables._itemsTabletInDataFetchStatus = inputs._itemsTabletInDataFetchStatus;
}

}

if("ItemsDesktop" in inputs) {
this.variables.itemsDesktopIn = inputs.ItemsDesktop;
if("_itemsDesktopInDataFetchStatus" in inputs) {
this.variables._itemsDesktopInDataFetchStatus = inputs._itemsDesktopInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS.Model.ModelFactory(Model);




