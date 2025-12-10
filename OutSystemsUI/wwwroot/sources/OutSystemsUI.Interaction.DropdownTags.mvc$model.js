import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

var OS = OSRuntimeCore;


class VariablesRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InternalConfigs", "internalConfigsVar", "InternalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_f2d4817754eec123207470e41d7a01d7Structure());
}, false, OutSystemsUIModel.ST_f2d4817754eec123207470e41d7a01d7Structure), 
this.attr("NoOptionsText_Default", "noOptionsText_DefaultVar", "NoOptionsText_Default", true, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, false), 
this.attr("NoResultsText_Default", "noResultsText_DefaultVar", "NoResultsText_Default", true, false, OS.DataTypes.DataTypes.Text, function () {
return "There are no options to show.";
}, false), 
this.attr("Prompt_Default", "prompt_DefaultVar", "Prompt_Default", true, false, OS.DataTypes.DataTypes.Text, function () {
return "Select...";
}, false), 
this.attr("SearchPrompt_Default", "searchPrompt_DefaultVar", "SearchPrompt_Default", true, false, OS.DataTypes.DataTypes.Text, function () {
return "Search...";
}, false), 
this.attr("OptionsList", "optionsListIn", "OptionsList", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("_optionsListInDataFetchStatus", "_optionsListInDataFetchStatus", "_optionsListInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StartingSelection", "startingSelectionIn", "StartingSelection", true, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))());
}, false, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))), 
this.attr("_startingSelectionInDataFetchStatus", "_startingSelectionInDataFetchStatus", "_startingSelectionInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Prompt", "promptIn", "Prompt", true, false, OS.DataTypes.DataTypes.Text, function () {
return "Select...";
}, false), 
this.attr("_promptInDataFetchStatus", "_promptInDataFetchStatus", "_promptInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OptionalConfigs", "optionalConfigsIn", "OptionalConfigs", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new OutSystemsUIModel.ST_34444d0742578c128ebc8b2594439346Structure());
}, false, OutSystemsUIModel.ST_34444d0742578c128ebc8b2594439346Structure), 
this.attr("_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", "_optionalConfigsInDataFetchStatus", true, false, OS.DataTypes.DataTypes.Integer, function () {
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
if("OptionsList" in inputs) {
this.variables.optionsListIn = inputs.OptionsList;
if("_optionsListInDataFetchStatus" in inputs) {
this.variables._optionsListInDataFetchStatus = inputs._optionsListInDataFetchStatus;
}

}

if("StartingSelection" in inputs) {
this.variables.startingSelectionIn = inputs.StartingSelection;
if("_startingSelectionInDataFetchStatus" in inputs) {
this.variables._startingSelectionInDataFetchStatus = inputs._startingSelectionInDataFetchStatus;
}

}

if("Prompt" in inputs) {
this.variables.promptIn = inputs.Prompt;
if("_promptInDataFetchStatus" in inputs) {
this.variables._promptInDataFetchStatus = inputs._promptInDataFetchStatus;
}

}

if("OptionalConfigs" in inputs) {
this.variables.optionalConfigsIn = inputs.OptionalConfigs;
if("_optionalConfigsInDataFetchStatus" in inputs) {
this.variables._optionalConfigsInDataFetchStatus = inputs._optionalConfigsInDataFetchStatus;
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




