import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_Init_InitJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$controller.Init.InitJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_OnParametersChanged_CheckObjectStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$controller.OnParametersChanged.CheckObjectStatusJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_GetValueOnSelect_GetValueOnSelectJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$controller.GetValueOnSelect.GetValueOnSelectJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_OnDestroy_OnDestroyJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$controller.OnDestroy.OnDestroyJS.js";
import OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_SetRTLObserver_SetActionAsObjJS from "./OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.mvc$controller.SetRTLObserver.SetActionAsObjJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onShowDropdown$Action: function () {
return controller.executeActionInsideJSNode(controller._onShowDropdown$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnShowDropdown");
},
onHideDropdown$Action: function () {
return controller.executeActionInsideJSNode(controller._onHideDropdown$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnHideDropdown");
},
getValueOnSelect$Action: function (eventIn) {
eventIn = (eventIn === undefined) ? null : eventIn;
return controller.executeActionInsideJSNode(controller._getValueOnSelect$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(eventIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "GetValueOnSelect");
},
onChangeListener$Action: function (valueIn, labelIn) {
valueIn = (valueIn === undefined) ? "" : valueIn;
labelIn = (labelIn === undefined) ? "" : labelIn;
return controller.executeActionInsideJSNode(controller._onChangeListener$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(valueIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(labelIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnChangeListener");
},
onParametersChanged$Action: function () {
return controller.executeActionInsideJSNode(controller._onParametersChanged$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnParametersChanged");
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
get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "0ac7e55c-0662-48a5-814c-9b51a81f21a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.Init$vars"))());
var isRTLVar = new OS.DataTypes.VariableHolder();
var listIndexOfVar = new OS.DataTypes.VariableHolder();
var initJSResult = new OS.DataTypes.VariableHolder();
var jSONSerializeItemListVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS.SystemActions.listIndexOf(model.variables.itemListIn, function (p) {
return (p.valueAttr === model.variables.selectedItemIn.valueAttr);
}, callContext);

// Set Selected Position
// SelectedPosition = ListIndexOf.Position
vars.value.selectedPositionVar = listIndexOfVar.value.positionOut;
// JSON Serialize: JSONSerializeItemList
jSONSerializeItemListVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.itemListIn, true, false);
// Execute Action: SetRTLObserver
return controller._setRTLObserver$Action(callContext).then(function () {
// Execute Action: IsRTL
isRTLVar.value = OutSystemsUIController.default.isRTL$Action(callContext);

// Script to initialize the dropdown search.
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "dd1dbe21-9330-4aca-b094-d85a4b7eab05");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_Init_InitJS, "Init", "Init", {
EmptyValue: OS.DataConversion.JSNodeParamConverter.to(model.variables.emptyTextIn, OS.DataTypes.DataTypes.Text),
searchPlaceholderValue: OS.DataConversion.JSNodeParamConverter.to(model.variables.searchPromptIn, OS.DataTypes.DataTypes.Text),
IsDisabled: OS.DataConversion.JSNodeParamConverter.to(model.variables.isDisabledIn, OS.DataTypes.DataTypes.Boolean),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(isRTLVar.value.isRTLOut, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("DropdownSelect"), OS.DataTypes.DataTypes.Text),
ExtendedClass: OS.DataConversion.JSNodeParamConverter.to(model.variables.extendedClassIn, OS.DataTypes.DataTypes.Text),
ItemList: OS.DataConversion.JSNodeParamConverter.to(jSONSerializeItemListVar.value.jSONOut, OS.DataTypes.DataTypes.Text),
noResultsText: OS.DataConversion.JSNodeParamConverter.to(model.variables.noResultsTextIn, OS.DataTypes.DataTypes.Text),
SelectedPosition: OS.DataConversion.JSNodeParamConverter.to(vars.value.selectedPositionVar, OS.DataTypes.DataTypes.Integer),
NullValue: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.nullIdentifier(), OS.DataTypes.DataTypes.Integer),
AdvancedFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.advancedFormatIn, OS.DataTypes.DataTypes.Text),
ChoicesObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.Init$initJSResult"))();
jsNodeResult.choicesObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ChoicesObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnShowDropdown: controller.clientActionProxies.onShowDropdown$Action,
OnHideDropdown: controller.clientActionProxies.onHideDropdown$Action,
GetValueOnSelect: controller.clientActionProxies.getValueOnSelect$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set Choices Object
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "293458e2-4c85-4900-9cc7-123495d9b9f5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var checkObjectStatusJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isSelectingVar))) {
// Script to check the object status.
checkObjectStatusJSResult.value = OS.Logger.startActiveSpan("CheckObjectStatus", function (span) {
if(span) {
span.setAttribute("code.function", "CheckObjectStatus");
span.setAttribute("outsystems.function.key", "e11407c1-d2b6-411b-a7c9-09dfd907ff87");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_OnParametersChanged_CheckObjectStatusJS, "CheckObjectStatus", "OnParametersChanged", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.choicesObjVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.OnParametersChanged$checkObjectStatusJSResult"))();
jsNodeResult.objectIsDefinedOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ObjectIsDefined, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ObjectIsDefined
if((checkObjectStatusJSResult.value.objectIsDefinedOut)) {
// Execute Action: OnDestroy
controller._onDestroy$Action(callContext);
}

// Execute Action: Init
return controller._init$Action(callContext);
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

get _getValueOnSelect$Action() {if(!(this.hasOwnProperty("__getValueOnSelect$Action"))) {
this.__getValueOnSelect$Action = function (eventIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GetValueOnSelect", function (span) {
if(span) {
span.setAttribute("code.function", "GetValueOnSelect");
span.setAttribute("outsystems.function.key", "32f2f3f5-c99d-4d58-aa25-c45c9a72912b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetValueOnSelect");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.GetValueOnSelect$vars"))());
vars.value.eventInLocal = eventIn;
OS.Logger.startActiveSpan("GetValueOnSelect", function (span) {
if(span) {
span.setAttribute("code.function", "GetValueOnSelect");
span.setAttribute("outsystems.function.key", "1534ebef-2a0e-465f-90a7-ec32cc8d8204");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_GetValueOnSelect_GetValueOnSelectJS, "GetValueOnSelect", "GetValueOnSelect", {
Event: OS.DataConversion.JSNodeParamConverter.to(vars.value.eventInLocal, OS.DataTypes.DataTypes.Object),
NullText: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.nullTextIdentifier(), OS.DataTypes.DataTypes.Text),
NullValue: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.nullIdentifier(), OS.DataTypes.DataTypes.Integer)
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

return this.__getValueOnSelect$Action;
}set _getValueOnSelect$Action(value) {this.__getValueOnSelect$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "37c97061-2fc8-4870-8614-da0e95ad1539");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveRTLObserver
OutSystemsUIController.default.removeRTLObserver$Action(model.variables.rTLCallbackVar, callContext);
// Script to destroy the dropdown search object.
OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "45cd2772-b271-4cd1-9f5f-9b0bfb85ae66");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_OnDestroy_OnDestroyJS, "OnDestroy", "OnDestroy", {
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

get _onChangeListener$Action() {if(!(this.hasOwnProperty("__onChangeListener$Action"))) {
this.__onChangeListener$Action = function (valueIn, labelIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnChangeListener", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeListener");
span.setAttribute("outsystems.function.key", "4f1a5451-3b0e-439c-a536-27506338e7bd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChangeListener");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.OnChangeListener$vars"))());
vars.value.valueInLocal = valueIn;
vars.value.labelInLocal = labelIn;
return OS.Flow.executeAsyncFlow(function () {
// Set Selected Item
// SelectedItem.Value = Value
model.variables.selectedItemIn.valueAttr = vars.value.valueInLocal;
// SelectedItem.Text = Label
model.variables.selectedItemIn.textAttr = vars.value.labelInLocal;
// Trigger Event: OnSelect
return controller.onSelect$Action(model.variables.selectedItemIn, callContext);
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

get _onHideDropdown$Action() {if(!(this.hasOwnProperty("__onHideDropdown$Action"))) {
this.__onHideDropdown$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnHideDropdown", function (span) {
if(span) {
span.setAttribute("code.function", "OnHideDropdown");
span.setAttribute("outsystems.function.key", "75a64464-a8da-4adb-b62a-b239d3854637");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnHideDropdown");
callContext = controller.callContext(callContext);
// Set IsSelecting - False
// IsSelecting = False
model.variables.isSelectingVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onHideDropdown$Action;
}set _onHideDropdown$Action(value) {this.__onHideDropdown$Action = value;
}

get _setRTLObserver$Action() {if(!(this.hasOwnProperty("__setRTLObserver$Action"))) {
this.__setRTLObserver$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetRTLObserver", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "7d9addcf-d911-4a69-99c9-2cb7535c51d3");
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
span.setAttribute("outsystems.function.key", "812ee537-a0ad-4110-b82d-e4956ecd59fa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_DropdownSearch_mvc_controller_SetRTLObserver_SetActionAsObjJS, "SetActionAsObj", "SetRTLObserver", {
Action: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.SetRTLObserver$setActionAsObjJSResult"))();
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

get _onShowDropdown$Action() {if(!(this.hasOwnProperty("__onShowDropdown$Action"))) {
this.__onShowDropdown$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnShowDropdown", function (span) {
if(span) {
span.setAttribute("code.function", "OnShowDropdown");
span.setAttribute("outsystems.function.key", "93746062-3605-45e8-898a-fa55189f9d3d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnShowDropdown");
callContext = controller.callContext(callContext);
// Set IsSelecting - True
// IsSelecting = True
model.variables.isSelectingVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onShowDropdown$Action;
}set _onShowDropdown$Action(value) {this.__onShowDropdown$Action = value;
}


init$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "0ac7e55c-0662-48a5-814c-9b51a81f21a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._init$Action, callContext);
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
span.setAttribute("outsystems.function.key", "293458e2-4c85-4900-9cc7-123495d9b9f5");
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

getValueOnSelect$Action(eventIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetValueOnSelect__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetValueOnSelect");
span.setAttribute("outsystems.function.key", "32f2f3f5-c99d-4d58-aa25-c45c9a72912b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getValueOnSelect$Action, callContext, eventIn);
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
span.setAttribute("outsystems.function.key", "37c97061-2fc8-4870-8614-da0e95ad1539");
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

onChangeListener$Action(valueIn, labelIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnChangeListener__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeListener");
span.setAttribute("outsystems.function.key", "4f1a5451-3b0e-439c-a536-27506338e7bd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onChangeListener$Action, callContext, valueIn, labelIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onHideDropdown$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnHideDropdown__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnHideDropdown");
span.setAttribute("outsystems.function.key", "75a64464-a8da-4adb-b62a-b239d3854637");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onHideDropdown$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setRTLObserver$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetRTLObserver__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "7d9addcf-d911-4a69-99c9-2cb7535c51d3");
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

onShowDropdown$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnShowDropdown__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnShowDropdown");
span.setAttribute("outsystems.function.key", "93746062-3605-45e8-898a-fa55189f9d3d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onShowDropdown$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onSelect$Action() {if(!(this.hasOwnProperty("_onSelect$Action"))) {
this._onSelect$Action = function () {
return Promise.resolve();
};
}

return this._onSelect$Action;
}set onSelect$Action(value) {this._onSelect$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.init$Action(callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.Init$vars", [{
name: "SelectedPosition",
attrName: "selectedPositionVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return (-1);
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.Init$initJSResult", [{
name: "ChoicesObj",
attrName: "choicesObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.OnParametersChanged$checkObjectStatusJSResult", [{
name: "ObjectIsDefined",
attrName: "objectIsDefinedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.GetValueOnSelect$vars", [{
name: "Event",
attrName: "eventInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.OnChangeListener$vars", [{
name: "Value",
attrName: "valueInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Label",
attrName: "labelInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_DropdownSearch.SetRTLObserver$setActionAsObjJSResult", [{
name: "Action",
attrName: "actionOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




