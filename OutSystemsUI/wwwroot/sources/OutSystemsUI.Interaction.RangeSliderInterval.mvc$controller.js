import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_RangeSliderInterval_mvc_TranslationsResources from "./OutSystemsUI.Interaction.RangeSliderInterval.mvc$translationsResources.js";
import OutSystemsUI_Interaction_RangeSliderInterval_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.RangeSliderInterval.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_RangeSliderInterval_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onValueChangeHandler$Action: function (rangeSliderIntervalIdIn, intervalStartIn, intervalEndIn) {
rangeSliderIntervalIdIn = (rangeSliderIntervalIdIn === undefined) ? "" : rangeSliderIntervalIdIn;
intervalStartIn = (intervalStartIn === undefined) ? "" : intervalStartIn;
intervalEndIn = (intervalEndIn === undefined) ? "" : intervalEndIn;
return controller.executeActionInsideJSNode(controller._onValueChangeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(rangeSliderIntervalIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(intervalStartIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(intervalEndIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnValueChangeHandler");
},
intializeHandler$Action: function (widgetIdIn) {
widgetIdIn = (widgetIdIn === undefined) ? "" : widgetIdIn;
return controller.executeActionInsideJSNode(controller._intializeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(widgetIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
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
get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "05a0cfd8-5243-4a14-9771-bed76e50d63c");
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
span.setAttribute("outsystems.function.key", "d655c937-fc38-46c3-bbdf-0bcaefbe6664");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_RangeSliderInterval_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnValueChange: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
RangeSliderInitializedObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.RegisterCallbacks$getCallbackHandlersJSResult"))();
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

get _intializeHandler$Action() {if(!(this.hasOwnProperty("__intializeHandler$Action"))) {
this.__intializeHandler$Action = function (widgetIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("IntializeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "IntializeHandler");
span.setAttribute("outsystems.function.key", "3fa10c1a-65de-4d7f-8f41-8cf118c4eff2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("IntializeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.IntializeHandler$vars"))());
vars.value.widgetIdInLocal = widgetIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.widgetIdInLocal, callContext);
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6de9a0d8-084f-43ce-9579-f5a941af60ad");
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

if((!(model.variables.startingValueFromIn.equals(model.variables.internalConfigsVar.startingValueFromAttr)))) {
// InternalConfigs.StartingValueFrom = StartingValueFrom
model.variables.internalConfigsVar.startingValueFromAttr = model.variables.startingValueFromIn;
// Execute Action: Update_StartingValueStart
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingValueFrom", model.variables.internalConfigsVar.startingValueFromAttr, callContext);
}

if((!(model.variables.startingValueToIn.equals(model.variables.internalConfigsVar.startingValueToAttr)))) {
// InternalConfigs.StartingValueTo = StartingValueTo
model.variables.internalConfigsVar.startingValueToAttr = model.variables.startingValueToIn;
// Execute Action: Update_StartingValueEnd
OutSystemsUIController.default.rangeSliderChangeDecimalProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingValueTo", model.variables.internalConfigsVar.startingValueToAttr, callContext);
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

get _onValueChangeHandler$Action() {if(!(this.hasOwnProperty("__onValueChangeHandler$Action"))) {
this.__onValueChangeHandler$Action = function (rangeSliderIntervalIdIn, intervalStartIn, intervalEndIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnValueChangeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnValueChangeHandler");
span.setAttribute("outsystems.function.key", "7a29a9b0-8354-45ab-8fda-94ccbb24386c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnValueChangeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.OnValueChangeHandler$vars"))());
vars.value.rangeSliderIntervalIdInLocal = rangeSliderIntervalIdIn;
vars.value.intervalStartInLocal = intervalStartIn;
vars.value.intervalEndInLocal = intervalEndIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnValueChange
return controller.onValueChange$Action(vars.value.rangeSliderIntervalIdInLocal, OS.BuiltinFunctions.textToDecimal(vars.value.intervalStartInLocal), OS.BuiltinFunctions.textToDecimal(vars.value.intervalEndInLocal), callContext);
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "7f07fde9-2ebd-4979-8506-1a667c936128");
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
// InternalConfigs.Orientation = Orientation
model.variables.internalConfigsVar.orientationAttr = model.variables.orientationIn;
// InternalConfigs.Size = Size
model.variables.internalConfigsVar.sizeAttr = model.variables.sizeIn;
// InternalConfigs.StartingValueFrom = StartingValueFrom
model.variables.internalConfigsVar.startingValueFromAttr = model.variables.startingValueFromIn;
// InternalConfigs.StartingValueTo = StartingValueTo
model.variables.internalConfigsVar.startingValueToAttr = model.variables.startingValueToIn;
// InternalConfigs.ShowFloatingLabel = OptionalConfigs.ShowFloatingLabel
model.variables.internalConfigsVar.showFloatingLabelAttr = model.variables.optionalConfigsIn.showFloatingLabelAttr;
// InternalConfigs.InitialValueFrom = InternalConfigs.StartingValueFrom
model.variables.internalConfigsVar.initialValueFromAttr = model.variables.internalConfigsVar.startingValueFromAttr;
// InternalConfigs.InitialValueTo = InternalConfigs.StartingValueTo
model.variables.internalConfigsVar.initialValueToAttr = model.variables.internalConfigsVar.startingValueToAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: RangeSliderCreate
OutSystemsUIController.default.rangeSliderCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, OutSystemsUIModel.staticEntities.rangeSliderType.interval, OutSystemsUIModel.staticEntities.rangeSliderProvider.noUiSlider, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "ad39730f-0bc0-4b9c-a406-14ceed9fce3a");
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "c139aaae-549c-4d7c-9244-51e2a43add7c");
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


registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "05a0cfd8-5243-4a14-9771-bed76e50d63c");
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

intializeHandler$Action(widgetIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("IntializeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IntializeHandler");
span.setAttribute("outsystems.function.key", "3fa10c1a-65de-4d7f-8f41-8cf118c4eff2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._intializeHandler$Action, callContext, widgetIdIn);
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
span.setAttribute("outsystems.function.key", "6de9a0d8-084f-43ce-9579-f5a941af60ad");
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

onValueChangeHandler$Action(rangeSliderIntervalIdIn, intervalStartIn, intervalEndIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnValueChangeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnValueChangeHandler");
span.setAttribute("outsystems.function.key", "7a29a9b0-8354-45ab-8fda-94ccbb24386c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onValueChangeHandler$Action, callContext, rangeSliderIntervalIdIn, intervalStartIn, intervalEndIn);
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
span.setAttribute("outsystems.function.key", "7f07fde9-2ebd-4979-8506-1a667c936128");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "ad39730f-0bc0-4b9c-a406-14ceed9fce3a");
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

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "c139aaae-549c-4d7c-9244-51e2a43add7c");
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

get onValueChange$Action() {if(!(this.hasOwnProperty("_onValueChange$Action"))) {
this._onValueChange$Action = function () {
return Promise.resolve();
};
}

return this._onValueChange$Action;
}set onValueChange$Action(value) {this._onValueChange$Action = value;
}

get initialized$Action() {if(!(this.hasOwnProperty("_initialized$Action"))) {
this._initialized$Action = function () {
return Promise.resolve();
};
}

return this._initialized$Action;
}set initialized$Action(value) {this._initialized$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.RegisterCallbacks$getCallbackHandlersJSResult", [{
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.IntializeHandler$vars", [{
name: "WidgetId",
attrName: "widgetIdInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.RangeSliderInterval.OnValueChangeHandler$vars", [{
name: "RangeSliderIntervalId",
attrName: "rangeSliderIntervalIdInLocal",
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
}, {
name: "IntervalEnd",
attrName: "intervalEndInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




