import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_RangeSlider_mvc_TranslationsResources from "./OutSystemsUI.Interaction.RangeSlider.mvc$translationsResources.js";
import OutSystemsUI_Interaction_RangeSlider_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.RangeSlider.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_RangeSlider_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onValueChangeHandler$Action: function (rangeSliderIdIn, intervalStartIn) {
rangeSliderIdIn = (rangeSliderIdIn === undefined) ? "" : rangeSliderIdIn;
intervalStartIn = (intervalStartIn === undefined) ? "" : intervalStartIn;
return controller.executeActionInsideJSNode(controller._onValueChangeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(rangeSliderIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(intervalStartIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnValueChangeHandler");
},
intializeHandler$Action: function (rangeSliderIdIn) {
rangeSliderIdIn = (rangeSliderIdIn === undefined) ? "" : rangeSliderIdIn;
return controller.executeActionInsideJSNode(controller._intializeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(rangeSliderIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "IntializeHandler");
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
get _onValueChangeHandler$Action() {if(!(this.hasOwnProperty("__onValueChangeHandler$Action"))) {
this.__onValueChangeHandler$Action = function (rangeSliderIdIn, intervalStartIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnValueChangeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnValueChangeHandler");
span.setAttribute("outsystems.function.key", "1361a9b6-1beb-4409-b47e-83cbbd245fba");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnValueChangeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSlider.OnValueChangeHandler$vars"))());
vars.value.rangeSliderIdInLocal = rangeSliderIdIn;
vars.value.intervalStartInLocal = intervalStartIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnValueChange
return controller.onValueChange$Action(vars.value.rangeSliderIdInLocal, OS.BuiltinFunctions.textToDecimal(vars.value.intervalStartInLocal), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onValueChangeHandler$Action;
}set _onValueChangeHandler$Action(value) {this.__onValueChangeHandler$Action = value;
}

get _intializeHandler$Action() {if(!(this.hasOwnProperty("__intializeHandler$Action"))) {
this.__intializeHandler$Action = function (rangeSliderIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("IntializeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "IntializeHandler");
span.setAttribute("outsystems.function.key", "63cd2688-bb61-4dc9-b6d0-d237b91b4236");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("IntializeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSlider.IntializeHandler$vars"))());
vars.value.rangeSliderIdInLocal = rangeSliderIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.rangeSliderIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__intializeHandler$Action;
}set _intializeHandler$Action(value) {this.__intializeHandler$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "b4b0bc25-c6a5-4dd8-ba9f-e432f42344e1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: RangeSliderInitialize
OutSystemsUIController.default.rangeSliderInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Rating created", callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "d270fa16-6463-462e-8fb2-34659db920ca");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Rating", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.MinValue = MinValue
model.variables.internalConfigsVar.minValueAttr = model.variables.minValueIn;
// InternalConfigs.MaxValue = MaxValue
model.variables.internalConfigsVar.maxValueAttr = model.variables.maxValueIn;
// InternalConfigs.StartingValueFrom = StartingValue
model.variables.internalConfigsVar.startingValueFromAttr = model.variables.startingValueIn;
// InternalConfigs.Orientation = Orientation
model.variables.internalConfigsVar.orientationAttr = model.variables.orientationIn;
// InternalConfigs.Size = Size
model.variables.internalConfigsVar.sizeAttr = model.variables.sizeIn;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.Step = OptionalConfigs.Step
model.variables.internalConfigsVar.stepAttr = model.variables.optionalConfigsIn.stepAttr;
// InternalConfigs.ShowTickMarks = OptionalConfigs.ShowTickMarks
model.variables.internalConfigsVar.showTickMarksAttr = model.variables.optionalConfigsIn.showTickMarksAttr;
// InternalConfigs.TickMarksInterval = OptionalConfigs.TickMarksInterval
model.variables.internalConfigsVar.tickMarksIntervalAttr = model.variables.optionalConfigsIn.tickMarksIntervalAttr;
// InternalConfigs.IsDisabled = OptionalConfigs.IsDisabled
model.variables.internalConfigsVar.isDisabledAttr = model.variables.optionalConfigsIn.isDisabledAttr;
// InternalConfigs.ShowFloatingLabel = OptionalConfigs.ShowFloatingLabel
model.variables.internalConfigsVar.showFloatingLabelAttr = model.variables.optionalConfigsIn.showFloatingLabelAttr;
// InternalConfigs.InitialValueFrom = InternalConfigs.StartingValueFrom
model.variables.internalConfigsVar.initialValueFromAttr = model.variables.internalConfigsVar.startingValueFromAttr;
// InternalConfigs.InitialValueTo = InternalConfigs.StartingValueTo
model.variables.internalConfigsVar.initialValueToAttr = model.variables.internalConfigsVar.startingValueToAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: RangeSliderCreate
OutSystemsUIController.default.rangeSliderCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, OutSystemsUIModel.staticEntities.rangeSliderType.single, OutSystemsUIModel.staticEntities.rangeSliderProvider.noUiSlider, callContext);
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "d879cdd5-51a2-4843-905c-629fb92f30d6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RangeSliderDestroy
OutSystemsUIController.default.rangeSliderDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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

get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "dc717829-1d1e-46f6-9149-fe2b0a624870");
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
span.setAttribute("outsystems.function.key", "aa36d172-de57-4add-ae06-2571de7bf2db");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_RangeSlider_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnValueChange: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
RangeSliderInitializedObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSlider.RegisterCallbacks$getCallbackHandlersJSResult"))();
jsNodeResult.onValueChangeOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnValueChange, OS.DataTypes.DataTypes.Object);
jsNodeResult.rangeSliderInitializedObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.RangeSliderInitializedObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnValueChangeHandler: controller.clientActionProxies.onValueChangeHandler$Action,
IntializeHandler: controller.clientActionProxies.intializeHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RegisterValueOnChange
OutSystemsUIController.default.rangeSliderRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.rangeSlider_OnValueChange, getCallbackHandlersJSResult.value.onValueChangeOut, callContext);
// Execute Action: RegisterOnRangeSliderInitialize
OutSystemsUIController.default.rangeSliderRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlersJSResult.value.rangeSliderInitializedObjOut, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "fc9fe426-6b50-4da5-9919-0d372125ece6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((!(model.variables.minValueIn.equals(model.variables.internalConfigsVar.minValueAttr)))) {
// InternalConfigs.MinValue = MinValue
model.variables.internalConfigsVar.minValueAttr = model.variables.minValueIn;
// Execute Action: Update_MinValue
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "MinValue", model.variables.internalConfigsVar.minValueAttr, callContext);
}

if((!(model.variables.maxValueIn.equals(model.variables.internalConfigsVar.maxValueAttr)))) {
// InternalConfigs.MaxValue = MaxValue
model.variables.internalConfigsVar.maxValueAttr = model.variables.maxValueIn;
// Execute Action: Update_MaxValue
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "MaxValue", model.variables.internalConfigsVar.maxValueAttr, callContext);
}

if((!(model.variables.startingValueIn.equals(model.variables.internalConfigsVar.startingValueFromAttr)))) {
// InternalConfigs.StartingValueFrom = StartingValue
model.variables.internalConfigsVar.startingValueFromAttr = model.variables.startingValueIn;
// Execute Action: Update_StartingValueStart
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingValueFrom", model.variables.internalConfigsVar.startingValueFromAttr, callContext);
}

if((!(model.variables.optionalConfigsIn.stepAttr.equals(model.variables.internalConfigsVar.stepAttr)))) {
// InternalConfigs.Step = OptionalConfigs.Step
model.variables.internalConfigsVar.stepAttr = model.variables.optionalConfigsIn.stepAttr;
// Execute Action: Update_Step
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Step", model.variables.internalConfigsVar.stepAttr, callContext);
}

if((((model.variables.optionalConfigsIn.showTickMarksAttr) !== (model.variables.internalConfigsVar.showTickMarksAttr)))) {
// InternalConfigs.ShowTickMarks = OptionalConfigs.ShowTickMarks
model.variables.internalConfigsVar.showTickMarksAttr = model.variables.optionalConfigsIn.showTickMarksAttr;
// Execute Action: Update_ShowTickMarks
OutSystemsUIController.default.rangeSliderChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ShowTickMarks", model.variables.internalConfigsVar.showTickMarksAttr, callContext);
}

if((((model.variables.optionalConfigsIn.tickMarksIntervalAttr) !== (model.variables.internalConfigsVar.tickMarksIntervalAttr)))) {
// InternalConfigs.TickMarksInterval = OptionalConfigs.TickMarksInterval
model.variables.internalConfigsVar.tickMarksIntervalAttr = model.variables.optionalConfigsIn.tickMarksIntervalAttr;
// Execute Action: Update_TickMarksInterval
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "TickMarksInterval", OS.BuiltinFunctions.integerToDecimal(model.variables.internalConfigsVar.tickMarksIntervalAttr), callContext);
}

if((((model.variables.optionalConfigsIn.isDisabledAttr) !== (model.variables.internalConfigsVar.isDisabledAttr)))) {
// InternalConfigs.IsDisabled = OptionalConfigs.IsDisabled
model.variables.internalConfigsVar.isDisabledAttr = model.variables.optionalConfigsIn.isDisabledAttr;
// Execute Action: Update_IsDisabled
OutSystemsUIController.default.rangeSliderChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "IsDisabled", model.variables.internalConfigsVar.isDisabledAttr, callContext);
}

if((((model.variables.orientationIn) !== (model.variables.internalConfigsVar.orientationAttr)))) {
// InternalConfigs.Orientation = Orientation
model.variables.internalConfigsVar.orientationAttr = model.variables.orientationIn;
// Execute Action: Update_Orientation
OutSystemsUIController.default.rangeSliderChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Orientation", model.variables.internalConfigsVar.orientationAttr, callContext);
}

if((((model.variables.sizeIn) !== (model.variables.internalConfigsVar.sizeAttr)))) {
// InternalConfigs.Size = Size
model.variables.internalConfigsVar.sizeAttr = model.variables.sizeIn;
// Execute Action: Update_Size
OutSystemsUIController.default.rangeSliderChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Size", model.variables.internalConfigsVar.sizeAttr, callContext);
}

if((((model.variables.optionalConfigsIn.showFloatingLabelAttr) !== (model.variables.internalConfigsVar.showFloatingLabelAttr)))) {
// InternalConfigs.ShowFloatingLabel = OptionalConfigs.ShowFloatingLabel
model.variables.internalConfigsVar.showFloatingLabelAttr = model.variables.optionalConfigsIn.showFloatingLabelAttr;
// Execute Action: Update_ShowFloatingLabel
OutSystemsUIController.default.rangeSliderChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ShowFloatingLabel", model.variables.optionalConfigsIn.showFloatingLabelAttr, callContext);
}

if((((model.variables.extendedClassIn) !== (model.variables.internalConfigsVar.extendedClassAttr)))) {
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.rangeSliderChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internalConfigsVar.extendedClassAttr, callContext);
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


onValueChangeHandler$Action(rangeSliderIdIn, intervalStartIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnValueChangeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnValueChangeHandler");
span.setAttribute("outsystems.function.key", "1361a9b6-1beb-4409-b47e-83cbbd245fba");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onValueChangeHandler$Action, callContext, rangeSliderIdIn, intervalStartIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

intializeHandler$Action(rangeSliderIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("IntializeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IntializeHandler");
span.setAttribute("outsystems.function.key", "63cd2688-bb61-4dc9-b6d0-d237b91b4236");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._intializeHandler$Action, callContext, rangeSliderIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "b4b0bc25-c6a5-4dd8-ba9f-e432f42344e1");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "d270fa16-6463-462e-8fb2-34659db920ca");
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

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "d879cdd5-51a2-4843-905c-629fb92f30d6");
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

registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "dc717829-1d1e-46f6-9149-fe2b0a624870");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "fc9fe426-6b50-4da5-9919-0d372125ece6");
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

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
}

get onValueChange$Action() {if(!(this.hasOwnProperty("_onValueChange$Action"))) {
this._onValueChange$Action = function () {
return Promise.resolve();
};
}

return this._onValueChange$Action;
}set onValueChange$Action(value) {this._onValueChange$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSlider.OnValueChangeHandler$vars", [{
name: "RangeSliderId",
attrName: "rangeSliderIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IntervalStart",
attrName: "intervalStartInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSlider.IntializeHandler$vars", [{
name: "RangeSliderId",
attrName: "rangeSliderIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSlider.RegisterCallbacks$getCallbackHandlersJSResult", [{
name: "OnValueChange",
attrName: "onValueChangeOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "RangeSliderInitializedObj",
attrName: "rangeSliderInitializedObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




