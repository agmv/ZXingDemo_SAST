import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DropdownTags_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DropdownTags.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DropdownTags_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.DropdownTags.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DropdownTags_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
initializedHandler$Action: function (dropdownTagsIdIn) {
dropdownTagsIdIn = (dropdownTagsIdIn === undefined) ? "" : dropdownTagsIdIn;
return controller.executeActionInsideJSNode(controller._initializedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(dropdownTagsIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializedHandler");
},
onSelectHandler$Action: function (dropdownTagsIdIn, selectedOptionsJSONIn) {
dropdownTagsIdIn = (dropdownTagsIdIn === undefined) ? "" : dropdownTagsIdIn;
selectedOptionsJSONIn = (selectedOptionsJSONIn === undefined) ? "" : selectedOptionsJSONIn;
return controller.executeActionInsideJSNode(controller._onSelectHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(dropdownTagsIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(selectedOptionsJSONIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSelectHandler");
}
};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _onSelectHandler$Action() {if(!(this.hasOwnProperty("__onSelectHandler$Action"))) {
this.__onSelectHandler$Action = function (dropdownTagsIdIn, selectedOptionsJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSelectHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectHandler");
span.setAttribute("outsystems.function.key", "0286fa4f-ec59-438d-86d9-26da5e52a8d0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSelectHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DropdownTags.OnSelectHandler$vars"))());
vars.value.dropdownTagsIdInLocal = dropdownTagsIdIn;
vars.value.selectedOptionsJSONInLocal = selectedOptionsJSONIn;
var jSONDeserializeDropdownOptionVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType((OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: JSONDeserializeDropdownOption
jSONDeserializeDropdownOptionVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.selectedOptionsJSONInLocal, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)), false);
// Trigger Event: OnChanged
return controller.onChanged$Action(vars.value.dropdownTagsIdInLocal, jSONDeserializeDropdownOptionVar.value.dataOut, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onSelectHandler$Action;
}set _onSelectHandler$Action(value) {this.__onSelectHandler$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "04a46e57-eb19-48a0-bb07-5d56f2ee386e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Dropdown Tags", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.OptionsList = OptionsList
model.variables.internalConfigsVar.optionsListAttr = model.variables.optionsListIn;
// InternalConfigs.StartingSelection = StartingSelection
model.variables.internalConfigsVar.startingSelectionAttr = model.variables.startingSelectionIn;
// InternalConfigs.Prompt = If
model.variables.internalConfigsVar.promptAttr = (((model.variables.promptIn === "")) ? (model.variables.prompt_DefaultVar) : (model.variables.promptIn));
// InternalConfigs.IsDisabled = OptionalConfigs.IsDisabled
model.variables.internalConfigsVar.isDisabledAttr = model.variables.optionalConfigsIn.isDisabledAttr;
// InternalConfigs.NoResultsText = If
model.variables.internalConfigsVar.noResultsTextAttr = (((model.variables.optionalConfigsIn.noResultsTextAttr === "")) ? (model.variables.noResultsText_DefaultVar) : (model.variables.optionalConfigsIn.noResultsTextAttr));
// InternalConfigs.SearchPrompt = If
model.variables.internalConfigsVar.searchPromptAttr = (((model.variables.optionalConfigsIn.searchPromptAttr === "")) ? (model.variables.searchPrompt_DefaultVar) : (model.variables.optionalConfigsIn.searchPromptAttr));
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.NoOptionsText = If
model.variables.internalConfigsVar.noOptionsTextAttr = (((model.variables.optionalConfigsIn.noOptionsTextAttr === "")) ? (model.variables.noOptionsText_DefaultVar) : (model.variables.optionalConfigsIn.noOptionsTextAttr));
// InternalConfigs.SanitizeDropdownValues = OptionalConfigs.SanitizeDropdownValues
model.variables.internalConfigsVar.sanitizeDropdownValuesAttr = model.variables.optionalConfigsIn.sanitizeDropdownValuesAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: DropdownCreate
OutSystemsUIController.default.dropdownCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.dropdownType.tags, OutSystemsUIModel.staticEntities.dropdownProvider.virtualSelect, serialize_configsVar.value.jSONOut, callContext);
// Execute Action: RegisterCallbacks
controller._registerCallbacks$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onInitialize$Action;
}set _onInitialize$Action(value) {this.__onInitialize$Action = value;
}

get _initializedHandler$Action() {if(!(this.hasOwnProperty("__initializedHandler$Action"))) {
this.__initializedHandler$Action = function (dropdownTagsIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "17553bde-0e5a-4d07-8f41-c64222d5d2dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DropdownTags.InitializedHandler$vars"))());
vars.value.dropdownTagsIdInLocal = dropdownTagsIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.dropdownTagsIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__initializedHandler$Action;
}set _initializedHandler$Action(value) {this.__initializedHandler$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "302dfbab-7c15-40be-b908-459a089fe2ff");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var internalConfigs_OptionsListJSONVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var optionsListJSONVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var startingSelectionJSONVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var internalConfigs_StartingSelectionJSONVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: OptionsListJSON
optionsListJSONVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.optionsListIn, false, false);
// JSON Serialize: InternalConfigs_OptionsListJSON
internalConfigs_OptionsListJSONVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar.optionsListAttr, false, false);
// OptionsList?
if((((optionsListJSONVar.value.jSONOut) !== (internalConfigs_OptionsListJSONVar.value.jSONOut)))) {
// Set OptionsList
// InternalConfigs.OptionsList = OptionsList
model.variables.internalConfigsVar.optionsListAttr = model.variables.optionsListIn;
// Execute Action: Update_OptionsList
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "OptionsList", optionsListJSONVar.value.jSONOut, callContext);
}

// JSON Serialize: StartingSelectionJSON
startingSelectionJSONVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.startingSelectionIn, false, false);
// JSON Serialize: InternalConfigs_StartingSelectionJSON
internalConfigs_StartingSelectionJSONVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar.startingSelectionAttr, false, false);
// StartingSelection?
if((((startingSelectionJSONVar.value.jSONOut) !== (internalConfigs_StartingSelectionJSONVar.value.jSONOut)))) {
// Set StartingSelection
// InternalConfigs.StartingSelection = StartingSelection
model.variables.internalConfigsVar.startingSelectionAttr = model.variables.startingSelectionIn;
// Execute Action: Update_StartingSelection
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingSelection", startingSelectionJSONVar.value.jSONOut, callContext);
}

// Prompt?
if((((model.variables.promptIn) !== (model.variables.internalConfigsVar.promptAttr)))) {
// Set Prompt
// InternalConfigs.Prompt = If
model.variables.internalConfigsVar.promptAttr = (((model.variables.promptIn === "")) ? (model.variables.prompt_DefaultVar) : (model.variables.promptIn));
// Execute Action: Update_Prompt
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Prompt", model.variables.internalConfigsVar.promptAttr, callContext);
}

// IsDisabled?
if((((model.variables.optionalConfigsIn.isDisabledAttr) !== (model.variables.internalConfigsVar.isDisabledAttr)))) {
// Set IsDisabled
// InternalConfigs.IsDisabled = OptionalConfigs.IsDisabled
model.variables.internalConfigsVar.isDisabledAttr = model.variables.optionalConfigsIn.isDisabledAttr;
// Execute Action: Update_IsDisabled
OutSystemsUIController.default.dropdownChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "IsDisabled", model.variables.internalConfigsVar.isDisabledAttr, callContext);
}

// NoResultsText?
if((((model.variables.optionalConfigsIn.noResultsTextAttr) !== (model.variables.internalConfigsVar.noResultsTextAttr)))) {
// Set NoResultsText
// InternalConfigs.NoResultsText = If
model.variables.internalConfigsVar.noResultsTextAttr = (((model.variables.optionalConfigsIn.noResultsTextAttr === "")) ? (model.variables.noResultsText_DefaultVar) : (model.variables.optionalConfigsIn.noResultsTextAttr));
// Execute Action: Update_NoResultsText
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "NoResultsText", model.variables.internalConfigsVar.noResultsTextAttr, callContext);
}

// NoOptionsText?
if((((model.variables.optionalConfigsIn.noOptionsTextAttr) !== (model.variables.internalConfigsVar.noOptionsTextAttr)))) {
// Set NoOptionsText
// InternalConfigs.NoOptionsText = If
model.variables.internalConfigsVar.noOptionsTextAttr = (((model.variables.optionalConfigsIn.noOptionsTextAttr === "")) ? (model.variables.noOptionsText_DefaultVar) : (model.variables.optionalConfigsIn.noOptionsTextAttr));
// Execute Action: Update_NoOptionsText
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "NoOptionsText", model.variables.internalConfigsVar.noOptionsTextAttr, callContext);
}

// SearchPrompt?
if((((model.variables.optionalConfigsIn.searchPromptAttr) !== (model.variables.internalConfigsVar.searchPromptAttr)))) {
// Set SearchPrompt
// InternalConfigs.SearchPrompt = If
model.variables.internalConfigsVar.searchPromptAttr = (((model.variables.optionalConfigsIn.searchPromptAttr === "")) ? (model.variables.searchPrompt_DefaultVar) : (model.variables.optionalConfigsIn.searchPromptAttr));
// Execute Action: Update_SearchPrompt
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "SearchPrompt", model.variables.internalConfigsVar.searchPromptAttr, callContext);
}

// SanitizeDropdownValues?
if((((model.variables.optionalConfigsIn.sanitizeDropdownValuesAttr) !== (model.variables.internalConfigsVar.sanitizeDropdownValuesAttr)))) {
// Set SanitizeDropdownValues
// InternalConfigs.SanitizeDropdownValues = OptionalConfigs.SanitizeDropdownValues
model.variables.internalConfigsVar.sanitizeDropdownValuesAttr = model.variables.optionalConfigsIn.sanitizeDropdownValuesAttr;
// Execute Action: Update_SanitizeDropdownValues
OutSystemsUIController.default.dropdownChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "SanitizeDropdownValues", model.variables.internalConfigsVar.sanitizeDropdownValuesAttr, callContext);
}

// ExtendedClass?
if((((model.variables.extendedClassIn) !== (model.variables.internalConfigsVar.extendedClassAttr)))) {
// Set ExtendedClass
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.dropdownChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internalConfigsVar.extendedClassAttr, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "45dfa317-1288-4627-976b-b7826a3c8d08");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: DropdownDestroy
OutSystemsUIController.default.dropdownDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onDestroy$Action;
}set _onDestroy$Action(value) {this.__onDestroy$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "9877e362-ece7-4b96-8c6b-2d93fb7f7647");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: DropdownInitialize
OutSystemsUIController.default.dropdownInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Dropdown Tags created", callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "c05a16d9-0b37-41be-a849-137ee1a25982");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RegisterCallbacks");
callContext = controller.callContext(callContext);
var getCallbackHandlersJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlersJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandlers", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandlers");
span.setAttribute("outsystems.function.key", "91331e42-c451-44d3-9968-5423a831adbc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DropdownTags_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnSelected: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
Initialized: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DropdownTags.RegisterCallbacks$getCallbackHandlersJSResult"))();
jsNodeResult.onSelectedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnSelected, OS.DataTypes.DataTypes.Object);
jsNodeResult.initializedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Initialized, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
InitializedHandler: controller.clientActionProxies.initializedHandler$Action,
OnSelectHandler: controller.clientActionProxies.onSelectHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RegisterOnSelected
OutSystemsUIController.default.dropdownRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.onSelected, getCallbackHandlersJSResult.value.onSelectedOut, callContext);
// Execute Action: RegisterOnInitialize
OutSystemsUIController.default.dropdownRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlersJSResult.value.initializedOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__registerCallbacks$Action;
}set _registerCallbacks$Action(value) {this.__registerCallbacks$Action = value;
}


onSelectHandler$Action(dropdownTagsIdIn, selectedOptionsJSONIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSelectHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSelectHandler");
span.setAttribute("outsystems.function.key", "0286fa4f-ec59-438d-86d9-26da5e52a8d0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSelectHandler$Action, callContext, dropdownTagsIdIn, selectedOptionsJSONIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "04a46e57-eb19-48a0-bb07-5d56f2ee386e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

initializedHandler$Action(dropdownTagsIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializedHandler");
span.setAttribute("outsystems.function.key", "17553bde-0e5a-4d07-8f41-c64222d5d2dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializedHandler$Action, callContext, dropdownTagsIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "302dfbab-7c15-40be-b908-459a089fe2ff");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "45dfa317-1288-4627-976b-b7826a3c8d08");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDestroy$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "9877e362-ece7-4b96-8c6b-2d93fb7f7647");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "c05a16d9-0b37-41be-a849-137ee1a25982");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._registerCallbacks$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
}

get onChanged$Action() {if(!(this.hasOwnProperty("_onChanged$Action"))) {
this._onChanged$Action = function () {
return Promise.resolve();
};
}

return this._onChanged$Action;
}set onChanged$Action(value) {this._onChanged$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = null;
}

return this._onRenderEventHandler;
}set onRenderEventHandler(value) {this._onRenderEventHandler = value;
}

get onDestroyEventHandler() {if(!(this.hasOwnProperty("_onDestroyEventHandler"))) {
this._onDestroyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onDestroy$Action(callContext);

};
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
}

return this._onParametersChangedEventHandler;
}set onParametersChangedEventHandler(value) {this._onParametersChangedEventHandler = value;
}

// Sync Event Handler Actions
get onSyncStartEventHandler() {if(!(this.hasOwnProperty("_onSyncStartEventHandler"))) {
this._onSyncStartEventHandler = null;
}

return this._onSyncStartEventHandler;
}set onSyncStartEventHandler(value) {this._onSyncStartEventHandler = value;
}

get onSyncCompleteEventHandler() {if(!(this.hasOwnProperty("_onSyncCompleteEventHandler"))) {
this._onSyncCompleteEventHandler = null;
}

return this._onSyncCompleteEventHandler;
}set onSyncCompleteEventHandler(value) {this._onSyncCompleteEventHandler = value;
}

get onSyncErrorEventHandler() {if(!(this.hasOwnProperty("_onSyncErrorEventHandler"))) {
this._onSyncErrorEventHandler = null;
}

return this._onSyncErrorEventHandler;
}set onSyncErrorEventHandler(value) {this._onSyncErrorEventHandler = value;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex) {
return controller.handleError(ex);
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return OutSystemsUIController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DropdownTags.OnSelectHandler$vars", [{
name: "DropdownTagsId",
attrName: "dropdownTagsIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedOptionsJSON",
attrName: "selectedOptionsJSONInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DropdownTags.InitializedHandler$vars", [{
name: "DropdownTagsId",
attrName: "dropdownTagsIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DropdownTags.RegisterCallbacks$getCallbackHandlersJSResult", [{
name: "OnSelected",
attrName: "onSelectedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "Initialized",
attrName: "initializedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




