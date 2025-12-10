import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_OnDestroy_OnDestroyJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$controller.OnDestroy.OnDestroyJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_OnParametersChanged_CheckObjectStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$controller.OnParametersChanged.CheckObjectStatusJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_SetRTLObserver_SetActionAsObjJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$controller.SetRTLObserver.SetActionAsObjJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_GetCurrentList_GetCurrentListJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$controller.GetCurrentList.GetCurrentListJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_Init_InitJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownTags.mvc$controller.Init.InitJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onParametersChanged$Action: function () {
return controller.executeActionInsideJSNode(controller._onParametersChanged$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnParametersChanged");
},
onChangeListener$Action: function (currentListStringIn) {
currentListStringIn = (currentListStringIn === undefined) ? "" : currentListStringIn;
return controller.executeActionInsideJSNode(controller._onChangeListener$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(currentListStringIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnChangeListener");
},
getCurrentList$Action: function () {
return controller.executeActionInsideJSNode(controller._getCurrentList$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "GetCurrentList");
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
get _serializeData$Action() {if(!(this.hasOwnProperty("__serializeData$Action"))) {
this.__serializeData$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SerializeData", function (span) {
if(span) {
span.setAttribute("code.function", "SerializeData");
span.setAttribute("outsystems.function.key", "09b02542-64f7-413c-a3ed-36023e91c841");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SerializeData");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.SerializeData$vars"))());
var listIndexOfVar = new OS.DataTypes.VariableHolder();
var listIndexOfSelectedItemVar = new OS.DataTypes.VariableHolder();
var jSONSerializeItemsListVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var jSONSerializeSelectedVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// JSON Serialize: JSONSerializeItemsList
jSONSerializeItemsListVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.itemListIn, true, false);
// Set Serialized List
// SerializedList = JSONSerializeItemsList.JSON
model.variables.serializedListVar = jSONSerializeItemsListVar.value.jSONOut;
// Has >=1 Selected Items?
if(((model.variables.selectedItemsListIn.length >= 1))) {
// Selected Items
// Foreach SelectedItemsList
callContext.iterationContext.registerIterationStart(model.variables.selectedItemsListIn);
try {var selectedItemsListIterator = callContext.iterationContext.getIterator(model.variables.selectedItemsListIn);
var selectedItemsListIndexMax = (model.variables.selectedItemsListIn.length + 2);
var selectedItemsListIndex = 0;
while ((((selectedItemsListIndex < model.variables.selectedItemsListIn.length)) && (selectedItemsListIndexMax > 0))) {
selectedItemsListIterator.currentRowNumber = selectedItemsListIndex;
// Execute Action: ListIndexOf
listIndexOfVar.value = OS.SystemActions.listIndexOf(model.variables.itemListIn, function (p) {
return (p.valueAttr === model.variables.selectedItemsListIn.getItem(selectedItemsListIndex.valueOf()).valueAttr);
}, callContext);

// Execute Action: ListAppend
OS.SystemActions.listAppend(vars.value.selectedListVar, (listIndexOfVar.value.positionOut).toString(), callContext);
selectedItemsListIndexMax--;
selectedItemsListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.selectedItemsListIn);
}

// JSON Serialize: JSONSerializeSelected
jSONSerializeSelectedVar.value.jSONOut = OS.JSONUtils.serializeToJSON(vars.value.selectedListVar, true, false, OS.DataTypes.DataTypes.Text);
// Set SerializedSelected
// SerializedSelected = JSONSerializeSelected.JSON
model.variables.serializedSelectedVar = jSONSerializeSelectedVar.value.jSONOut;
} else {
// Execute Action: ListIndexOfSelectedItem
listIndexOfSelectedItemVar.value = OS.SystemActions.listIndexOf(model.variables.itemListIn, function (p) {
return (p.valueAttr === model.variables.selectedItemsListIn.getCurrent(callContext.iterationContext).valueAttr);
}, callContext);

// Set Selected Items and Clear SerializedSelected
// SelectedItem = ListIndexOfSelectedItem.Position
model.variables.selectedItemVar = listIndexOfSelectedItemVar.value.positionOut;
// SerializedSelected = ""
model.variables.serializedSelectedVar = "";
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__serializeData$Action;
}set _serializeData$Action(value) {this.__serializeData$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "52196e17-704f-4ed2-a3f6-ccbbe5108a49");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Init Original Options
// OriginalOptions.IsDisable = IsDisabled
model.variables.originalOptionsVar.isDisableAttr = model.variables.isDisabledIn;
// OriginalOptions.IsRemoveItems = IsRemoveItems
model.variables.originalOptionsVar.isRemoveItemsAttr = model.variables.isRemoveItemsIn;
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

get _onChangeListener$Action() {if(!(this.hasOwnProperty("__onChangeListener$Action"))) {
this.__onChangeListener$Action = function (currentListStringIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnChangeListener", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeListener");
span.setAttribute("outsystems.function.key", "584bd9e4-eded-4238-963e-5cb578d890a0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChangeListener");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.OnChangeListener$vars"))());
vars.value.currentListStringInLocal = currentListStringIn;
var jSONDeserializeDropdownListVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType((OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure))))());
return OS.Flow.executeAsyncFlow(function () {
// Set IsSelecting
// IsSelecting = True
model.variables.isSelectingVar = true;
// JSON Deserialize: JSONDeserializeDropdownList
jSONDeserializeDropdownListVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.currentListStringInLocal, (OS.GenericTypeCache.getGenericList(OutSystemsUIModel.ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure)), false);
// Set CurrentList
// CurrentList = JSONDeserializeDropdownList.Data
model.variables.currentListVar = jSONDeserializeDropdownListVar.value.dataOut;
// Trigger Event: OnChange
return controller.onChange$Action(jSONDeserializeDropdownListVar.value.dataOut, callContext).then(function () {
// Set not IsSelecting
// IsSelecting = False
model.variables.isSelectingVar = false;
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onChangeListener$Action;
}set _onChangeListener$Action(value) {this.__onChangeListener$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "6729ca13-9c62-4438-914b-2d00ab1efb0b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveRTLObserver
OutSystemsUIController.default.removeRTLObserver$Action(model.variables.rTLCallbackVar, callContext);
// Script to destroy the dropdown tags object.
OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "a97ce05f-a932-475f-9c31-f3646d9c0bd9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_OnDestroy_OnDestroyJS, "OnDestroy", "OnDestroy", {
ElementId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SelectableTags"), OS.DataTypes.DataTypes.Text),
ChoicesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.choicesObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6c5fd19d-6e48-4ed0-8b17-b450283402e5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var checkObjectStatusJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Selecting?
return OS.Flow.executeSequence(function () {
if((!(model.variables.isSelectingVar))) {
// Script to check the object status.
checkObjectStatusJSResult.value = OS.Logger.startActiveSpan("CheckObjectStatus", function (span) {
if(span) {
span.setAttribute("code.function", "CheckObjectStatus");
span.setAttribute("outsystems.function.key", "cb872051-8103-45a9-8d51-8fbbf543289d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_OnParametersChanged_CheckObjectStatusJS, "CheckObjectStatus", "OnParametersChanged", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.choicesObjVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.OnParametersChanged$checkObjectStatusJSResult"))();
jsNodeResult.objectIsDefinedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObjectIsDefined, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Is Object Defined?
return OS.Flow.executeSequence(function () {
if((checkObjectStatusJSResult.value.objectIsDefinedOut)) {
// Execute Action: OnDestroy
controller._onDestroy$Action(callContext);
// Execute Action: Update
return controller._init$Action(true, callContext);
} else {
// Execute Action: Init
return controller._init$Action(false, callContext);
}

});
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onParametersChanged$Action;
}set _onParametersChanged$Action(value) {this.__onParametersChanged$Action = value;
}

get _setRTLObserver$Action() {if(!(this.hasOwnProperty("__setRTLObserver$Action"))) {
this.__setRTLObserver$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetRTLObserver", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "85646980-657a-4b2c-87b5-36131718eaec");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetRTLObserver");
callContext = controller.callContext(callContext);
var setActionAsObjJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Script to set the object action to be attached to the observer for the RTL.
setActionAsObjJSResult.value = OS.Logger.startActiveSpan("SetActionAsObj", function (span) {
if(span) {
span.setAttribute("code.function", "SetActionAsObj");
span.setAttribute("outsystems.function.key", "1c488abc-7e85-442b-b6c8-ac6530dd1089");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_SetRTLObserver_SetActionAsObjJS, "SetActionAsObj", "SetRTLObserver", {
Action: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.SetRTLObserver$setActionAsObjJSResult"))();
jsNodeResult.actionOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Action, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnParametersChanged: controller.clientActionProxies.onParametersChanged$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// RTLCallback = SetActionAsObj.Action
model.variables.rTLCallbackVar = setActionAsObjJSResult.value.actionOut;
// Execute Action: AddRTLObserver
model.flush();
return OutSystemsUIController.default.addRTLObserver$Action(model.variables.rTLCallbackVar, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__setRTLObserver$Action;
}set _setRTLObserver$Action(value) {this.__setRTLObserver$Action = value;
}

get _getCurrentList$Action() {if(!(this.hasOwnProperty("__getCurrentList$Action"))) {
this.__getCurrentList$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GetCurrentList", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrentList");
span.setAttribute("outsystems.function.key", "ebe9b9c7-21a1-4ca7-8e39-831a0d16afad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetCurrentList");
callContext = controller.callContext(callContext);
// Script node to get the current items list.
OS.Logger.startActiveSpan("GetCurrentList", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrentList");
span.setAttribute("outsystems.function.key", "e11a9146-dfc2-4759-96cb-5514d2e1d384");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_GetCurrentList_GetCurrentListJS, "GetCurrentList", "GetCurrentList", {
ChoicesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.choicesObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {
OnChangeListener: controller.clientActionProxies.onChangeListener$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__getCurrentList$Action;
}set _getCurrentList$Action(value) {this.__getCurrentList$Action = value;
}

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (isParameterChangedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "f7731921-d0dc-4052-ab6b-6e56d6a57536");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.Init$vars"))());
vars.value.isParameterChangedInLocal = isParameterChangedIn;
var isRTLVar = new OS.DataTypes.VariableHolder();
var initJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
if((((vars.value.isParameterChangedInLocal && ((model.variables.originalOptionsVar.isDisableAttr) !== (model.variables.isDisabledIn))) || ((model.variables.originalOptionsVar.isRemoveItemsAttr) !== (model.variables.isRemoveItemsIn))))) {
// Set CurrentList / Disable / Remove
// OriginalOptions.IsDisable = IsDisabled
model.variables.originalOptionsVar.isDisableAttr = model.variables.isDisabledIn;
// OriginalOptions.IsRemoveItems = IsRemoveItems
model.variables.originalOptionsVar.isRemoveItemsAttr = model.variables.isRemoveItemsIn;
// SelectedItemsList = CurrentList
model.variables.selectedItemsListIn = model.variables.currentListVar;
} else {
// Set CurrentList
// CurrentList = SelectedItemsList
model.variables.currentListVar = model.variables.selectedItemsListIn;
}

// Execute Action: SerializeData
controller._serializeData$Action(callContext);
// Execute Action: SetRTLObserver
return controller._setRTLObserver$Action(callContext).then(function () {
// Execute Action: IsRTL
isRTLVar.value = OutSystemsUIController.default.isRTL$Action(callContext);

initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "666f8505-f1d0-428a-85e2-cc5fd285c903");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownTags_mvc_controller_Init_InitJS, "Init", "Init", {
SelectedList: OS.DataConversion.JSNodeParamConverter.to(model.variables.serializedSelectedVar, OS.DataTypes.DataTypes.Text),
ExtendedClass: OS.DataConversion.JSNodeParamConverter.to(model.variables.extendedClassIn, OS.DataTypes.DataTypes.Text),
EmptyValue: OS.DataConversion.JSNodeParamConverter.to(model.variables.searchPromptIn, OS.DataTypes.DataTypes.Text),
IsRemoveItems: OS.DataConversion.JSNodeParamConverter.to(model.variables.isRemoveItemsIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SelectableTags"), OS.DataTypes.DataTypes.Text),
SelectedPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.selectedItemVar, OS.DataTypes.DataTypes.Integer),
AdvancedFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.advancedFormatIn, OS.DataTypes.DataTypes.Text),
noResultsText: OS.DataConversion.JSNodeParamConverter.to(model.variables.noResultsTextIn, OS.DataTypes.DataTypes.Text),
ListItemsList: OS.DataConversion.JSNodeParamConverter.to(model.variables.serializedListVar, OS.DataTypes.DataTypes.Text),
IsUpdate: OS.DataConversion.JSNodeParamConverter.to(vars.value.isParameterChangedInLocal, OS.DataTypes.DataTypes.Boolean),
IsDisabled: OS.DataConversion.JSNodeParamConverter.to(model.variables.isDisabledIn, OS.DataTypes.DataTypes.Boolean),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(isRTLVar.value.isRTLOut, OS.DataTypes.DataTypes.Boolean),
ChoicesObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.Init$initJSResult"))();
jsNodeResult.choicesObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ChoicesObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
GetCurrentList: controller.clientActionProxies.getCurrentList$Action,
OnChangeListener: controller.clientActionProxies.onChangeListener$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ChoicesObj = Init.ChoicesObj
model.variables.choicesObjVar = initJSResult.value.choicesObjOut;
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__init$Action;
}set _init$Action(value) {this.__init$Action = value;
}


serializeData$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SerializeData__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SerializeData");
span.setAttribute("outsystems.function.key", "09b02542-64f7-413c-a3ed-36023e91c841");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._serializeData$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "52196e17-704f-4ed2-a3f6-ccbbe5108a49");
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

onChangeListener$Action(currentListStringIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnChangeListener__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeListener");
span.setAttribute("outsystems.function.key", "584bd9e4-eded-4238-963e-5cb578d890a0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onChangeListener$Action, callContext, currentListStringIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "6729ca13-9c62-4438-914b-2d00ab1efb0b");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6c5fd19d-6e48-4ed0-8b17-b450283402e5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setRTLObserver$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetRTLObserver__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "85646980-657a-4b2c-87b5-36131718eaec");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._setRTLObserver$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getCurrentList$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetCurrentList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrentList");
span.setAttribute("outsystems.function.key", "ebe9b9c7-21a1-4ca7-8e39-831a0d16afad");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getCurrentList$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

init$Action(isParameterChangedIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "f7731921-d0dc-4052-ab6b-6e56d6a57536");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._init$Action, callContext, isParameterChangedIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onChange$Action() {if(!(this.hasOwnProperty("_onChange$Action"))) {
this._onChange$Action = function () {
return Promise.resolve();
};
}

return this._onChange$Action;
}set onChange$Action(value) {this._onChange$Action = value;
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

return controller.init$Action(false, callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.SerializeData$vars", [{
name: "SelectedList",
attrName: "selectedListVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new OS.DataTypes.TextList();
},
complexType: OS.DataTypes.TextList
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.OnChangeListener$vars", [{
name: "CurrentListString",
attrName: "currentListStringInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.OnParametersChanged$checkObjectStatusJSResult", [{
name: "ObjectIsDefined",
attrName: "objectIsDefinedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.SetRTLObserver$setActionAsObjJSResult", [{
name: "Action",
attrName: "actionOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.Init$vars", [{
name: "IsParameterChanged",
attrName: "isParameterChangedInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownTags.Init$initJSResult", [{
name: "ChoicesObj",
attrName: "choicesObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




