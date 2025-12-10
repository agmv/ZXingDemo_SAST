import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnDestroy_DestroyJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.OnDestroy.DestroyJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_ValuesChange_GetSelectedValueJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.ValuesChange.GetSelectedValueJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnReady_InitSliderJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.OnReady.InitSliderJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_SetRTLObserver_SetActionAsObjJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.SetRTLObserver.SetActionAsObjJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnParametersChanged_CheckObjectStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.OnParametersChanged.CheckObjectStatusJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnParametersChanged_UpdateValueJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.OnParametersChanged.UpdateValueJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
valuesChange$Action: function (valuesIn) {
valuesIn = (valuesIn === undefined) ? null : valuesIn;
return controller.executeActionInsideJSNode(controller._valuesChange$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(valuesIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ValuesChange");
},
toggleSlidingStatus$Action: function () {
return controller.executeActionInsideJSNode(controller._toggleSlidingStatus$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ToggleSlidingStatus");
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
get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "0c89483a-2be5-49f2-850e-d2acc14c9049");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveRTLObserver
OutSystemsUIController.default.removeRTLObserver$Action(model.variables.rTLCallbackVar, callContext);
OS.Logger.startActiveSpan("Destroy", function (span) {
if(span) {
span.setAttribute("code.function", "Destroy");
span.setAttribute("outsystems.function.key", "2bb42f6f-c8d6-4063-a4bc-89a8055c6219");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnDestroy_DestroyJS, "Destroy", "OnDestroy", {
SliderObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.sliderObjectVar, OS.DataTypes.DataTypes.Object)
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "47b3198b-55cb-4c9d-8584-35ecad8b522b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// CurrentInitialValue = InitialIntervalStart
model.variables.currentInitialValueVar = model.variables.initialIntervalStartIn;
// CurrentEndValue = InitialIntervalEnd
model.variables.currentEndValueVar = model.variables.initialIntervalEndIn;
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

get _toggleSlidingStatus$Action() {if(!(this.hasOwnProperty("__toggleSlidingStatus$Action"))) {
this.__toggleSlidingStatus$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ToggleSlidingStatus", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleSlidingStatus");
span.setAttribute("outsystems.function.key", "51b2348d-d050-4ce8-a24e-1ce72bcc80a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ToggleSlidingStatus");
callContext = controller.callContext(callContext);
// IsSliding = notIsSliding
model.variables.isSlidingVar = (!(model.variables.isSlidingVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__toggleSlidingStatus$Action;
}set _toggleSlidingStatus$Action(value) {this.__toggleSlidingStatus$Action = value;
}

get _valuesChange$Action() {if(!(this.hasOwnProperty("__valuesChange$Action"))) {
this.__valuesChange$Action = function (valuesIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ValuesChange", function (span) {
if(span) {
span.setAttribute("code.function", "ValuesChange");
span.setAttribute("outsystems.function.key", "67cfae42-6668-49ea-8759-75cbf610c6c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ValuesChange");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.ValuesChange$vars"))());
vars.value.valuesInLocal = valuesIn;
var getSelectedValueJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
getSelectedValueJSResult.value = OS.Logger.startActiveSpan("GetSelectedValue", function (span) {
if(span) {
span.setAttribute("code.function", "GetSelectedValue");
span.setAttribute("outsystems.function.key", "1fd13c41-b765-4623-9b10-2b1f8ff69c88");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_ValuesChange_GetSelectedValueJS, "GetSelectedValue", "ValuesChange", {
values: OS.DataConversion.JSNodeParamConverter.to(vars.value.valuesInLocal, OS.DataTypes.DataTypes.Object),
IntervalStart: OS.DataConversion.JSNodeParamConverter.to(OS.DataTypes.Decimal.defaultValue, OS.DataTypes.DataTypes.Decimal),
IntervalEnd: OS.DataConversion.JSNodeParamConverter.to(OS.DataTypes.Decimal.defaultValue, OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.ValuesChange$getSelectedValueJSResult"))();
jsNodeResult.intervalStartOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IntervalStart, OS.DataTypes.DataTypes.Decimal);
jsNodeResult.intervalEndOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IntervalEnd, OS.DataTypes.DataTypes.Decimal);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// CurrentInitialValue = GetSelectedValue.IntervalStart
model.variables.currentInitialValueVar = getSelectedValueJSResult.value.intervalStartOut;
// CurrentEndValue = GetSelectedValue.IntervalEnd
model.variables.currentEndValueVar = getSelectedValueJSResult.value.intervalEndOut;
// Trigger Event: OnChange
return controller.onChange$Action(model.variables.currentInitialValueVar, model.variables.currentEndValueVar, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__valuesChange$Action;
}set _valuesChange$Action(value) {this.__valuesChange$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "7e835950-6fc2-48d0-921c-05468fc75123");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var isRTLVar = new OS.DataTypes.VariableHolder();
var initSliderJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: SetRTLObserver
return controller._setRTLObserver$Action(callContext).then(function () {
// Execute Action: IsRTL
isRTLVar.value = OutSystemsUIController.default.isRTL$Action(callContext);

// SetDirection
// CurrentOptions.Direction = If
model.variables.currentOptionsVar.directionAttr = ((isRTLVar.value.isRTLOut) ? ("rtl") : ("ltr"));
initSliderJSResult.value = OS.Logger.startActiveSpan("InitSlider", function (span) {
if(span) {
span.setAttribute("code.function", "InitSlider");
span.setAttribute("outsystems.function.key", "8f16ef9f-1ae8-4337-aa9f-d242f0b3f455");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnReady_InitSliderJS, "InitSlider", "OnReady", {
ChangeEventDuringSlide: OS.DataConversion.JSNodeParamConverter.to(model.variables.changeEventDuringSlideIn, OS.DataTypes.DataTypes.Boolean),
Min: OS.DataConversion.JSNodeParamConverter.to(model.variables.minValueIn, OS.DataTypes.DataTypes.Decimal),
Step: OS.DataConversion.JSNodeParamConverter.to(model.variables.stepIn, OS.DataTypes.DataTypes.Decimal),
Max: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxValueIn, OS.DataTypes.DataTypes.Decimal),
AdvancedFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.advancedFormatIn, OS.DataTypes.DataTypes.Text),
InitialIntervalEnd: OS.DataConversion.JSNodeParamConverter.to(model.variables.initialIntervalEndIn, OS.DataTypes.DataTypes.Decimal),
Direction: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentOptionsVar.directionAttr, OS.DataTypes.DataTypes.Text),
PipsStep: OS.DataConversion.JSNodeParamConverter.to(model.variables.pipsStepIn, OS.DataTypes.DataTypes.Integer),
ShowPips: OS.DataConversion.JSNodeParamConverter.to(model.variables.showPipsIn, OS.DataTypes.DataTypes.Boolean),
SliderContainerId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("RangeSliderInterval"), OS.DataTypes.DataTypes.Text),
IsVertical: OS.DataConversion.JSNodeParamConverter.to(model.variables.isVerticalIn, OS.DataTypes.DataTypes.Boolean),
InitialIntervalStart: OS.DataConversion.JSNodeParamConverter.to(model.variables.initialIntervalStartIn, OS.DataTypes.DataTypes.Decimal),
SliderObject: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnReady$initSliderJSResult"))();
jsNodeResult.sliderObjectOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SliderObject, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
ValuesChange: controller.clientActionProxies.valuesChange$Action,
ToggleSlidingStatus: controller.clientActionProxies.toggleSlidingStatus$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// CurrentOptions
// SliderObject = InitSlider.SliderObject
model.variables.sliderObjectVar = initSliderJSResult.value.sliderObjectOut;
// CurrentOptions.ChangeEventDuringSlide = ChangeEventDuringSlide
model.variables.currentOptionsVar.changeEventDuringSlideAttr = model.variables.changeEventDuringSlideIn;
// CurrentOptions.MaxValue = MaxValue
model.variables.currentOptionsVar.maxValueAttr = model.variables.maxValueIn;
// CurrentOptions.MinValue = MinValue
model.variables.currentOptionsVar.minValueAttr = model.variables.minValueIn;
// CurrentOptions.PipsStep = PipsStep
model.variables.currentOptionsVar.pipsStepAttr = model.variables.pipsStepIn;
// CurrentOptions.ShowPips = ShowPips
model.variables.currentOptionsVar.showPipsAttr = model.variables.showPipsIn;
// CurrentOptions.Step = Step
model.variables.currentOptionsVar.stepAttr = model.variables.stepIn;
// CurrentOptions.IsDisabled = IsDisabled
model.variables.currentOptionsVar.isDisabledAttr = model.variables.isDisabledIn;
// CurrentOptions.IsVertical = IsVertical
model.variables.currentOptionsVar.isVerticalAttr = model.variables.isVerticalIn;
// CurrentOptions.VerticalHeight = VerticalHeight
model.variables.currentOptionsVar.verticalHeightAttr = model.variables.verticalHeightIn;
// CurrentOptions.InitialIntervalStart = InitialIntervalStart
model.variables.currentOptionsVar.initialIntervalStartAttr = model.variables.initialIntervalStartIn;
// CurrentOptions.InitialIntervalEnd = InitialIntervalEnd
model.variables.currentOptionsVar.initialIntervalEndAttr = model.variables.initialIntervalEndIn;
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

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _setRTLObserver$Action() {if(!(this.hasOwnProperty("__setRTLObserver$Action"))) {
this.__setRTLObserver$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetRTLObserver", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "965b62b8-b6e8-4c3f-9c98-d8feab08c60e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetRTLObserver");
callContext = controller.callContext(callContext);
var setActionAsObjJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
setActionAsObjJSResult.value = OS.Logger.startActiveSpan("SetActionAsObj", function (span) {
if(span) {
span.setAttribute("code.function", "SetActionAsObj");
span.setAttribute("outsystems.function.key", "409ff84e-827c-446c-85a7-337a528e0231");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_SetRTLObserver_SetActionAsObjJS, "SetActionAsObj", "SetRTLObserver", {
Action: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.SetRTLObserver$setActionAsObjJSResult"))();
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

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "db867865-c2a6-476b-875b-98db2b2ad06f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnParametersChanged$vars"))());
var isRTLVar = new OS.DataTypes.VariableHolder();
var checkObjectStatusJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: IsRTL
isRTLVar.value = OutSystemsUIController.default.isRTL$Action(callContext);

// DirectionChanged?
// DirectionApplied = If
vars.value.directionAppliedVar = ((isRTLVar.value.isRTLOut) ? ("rtl") : ("ltr"));
if(((!(model.variables.currentOptionsVar.initialIntervalStartAttr.equals(model.variables.initialIntervalStartIn)) || !(model.variables.currentOptionsVar.initialIntervalEndAttr.equals(model.variables.initialIntervalEndIn))))) {
if((!(model.variables.isSlidingVar))) {
OS.Logger.startActiveSpan("UpdateValue", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateValue");
span.setAttribute("outsystems.function.key", "ff15add3-accd-485c-825c-13674bc03952");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnParametersChanged_UpdateValueJS, "UpdateValue", "OnParametersChanged", {
Value2: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(model.variables.initialIntervalEndIn)), OS.DataTypes.DataTypes.Integer),
SliderObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.sliderObjectVar, OS.DataTypes.DataTypes.Object),
Value1: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(model.variables.initialIntervalStartIn)), OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// UpdateValues
// CurrentInitialValue = InitialIntervalStart
model.variables.currentInitialValueVar = model.variables.initialIntervalStartIn;
// CurrentEndValue = InitialIntervalEnd
model.variables.currentEndValueVar = model.variables.initialIntervalEndIn;
// CurrentOptions.InitialIntervalStart = InitialIntervalStart
model.variables.currentOptionsVar.initialIntervalStartAttr = model.variables.initialIntervalStartIn;
// CurrentOptions.InitialIntervalEnd = InitialIntervalEnd
model.variables.currentOptionsVar.initialIntervalEndAttr = model.variables.initialIntervalEndIn;
// CurrentOptions.Direction = DirectionApplied
model.variables.currentOptionsVar.directionAttr = vars.value.directionAppliedVar;
}

}

// InitialValue changed?
return OS.Flow.executeSequence(function () {
if(((((((((((!(model.variables.minValueIn.equals(model.variables.currentOptionsVar.minValueAttr)) || !(model.variables.maxValueIn.equals(model.variables.currentOptionsVar.maxValueAttr))) || !(model.variables.stepIn.equals(model.variables.currentOptionsVar.stepAttr))) || ((model.variables.showPipsIn) !== (model.variables.currentOptionsVar.showPipsAttr))) || ((model.variables.pipsStepIn) !== (model.variables.currentOptionsVar.pipsStepAttr))) || ((model.variables.changeEventDuringSlideIn) !== (model.variables.currentOptionsVar.changeEventDuringSlideAttr))) || ((model.variables.isDisabledIn) !== (model.variables.currentOptionsVar.isDisabledAttr))) || ((model.variables.isVerticalIn) !== (model.variables.currentOptionsVar.isVerticalAttr))) || ((model.variables.verticalHeightIn) !== (model.variables.currentOptionsVar.verticalHeightAttr))) || ((vars.value.directionAppliedVar) !== (model.variables.currentOptionsVar.directionAttr))))) {
checkObjectStatusJSResult.value = OS.Logger.startActiveSpan("CheckObjectStatus", function (span) {
if(span) {
span.setAttribute("code.function", "CheckObjectStatus");
span.setAttribute("outsystems.function.key", "d0d60fd8-4251-4818-9200-231434619a80");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderInterval_mvc_controller_OnParametersChanged_CheckObjectStatusJS, "CheckObjectStatus", "OnParametersChanged", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.sliderObjectVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnParametersChanged$checkObjectStatusJSResult"))();
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

// UpdateValues
// InitialIntervalStart = CurrentInitialValue
model.variables.initialIntervalStartIn = model.variables.currentInitialValueVar;
// InitialIntervalEnd = CurrentEndValue
model.variables.initialIntervalEndIn = model.variables.currentEndValueVar;
// CurrentOptions.Direction = DirectionApplied
model.variables.currentOptionsVar.directionAttr = vars.value.directionAppliedVar;
// Execute Action: Init
return controller._onReady$Action(callContext);
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


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "0c89483a-2be5-49f2-850e-d2acc14c9049");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "47b3198b-55cb-4c9d-8584-35ecad8b522b");
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

toggleSlidingStatus$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ToggleSlidingStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleSlidingStatus");
span.setAttribute("outsystems.function.key", "51b2348d-d050-4ce8-a24e-1ce72bcc80a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._toggleSlidingStatus$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

valuesChange$Action(valuesIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ValuesChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValuesChange");
span.setAttribute("outsystems.function.key", "67cfae42-6668-49ea-8759-75cbf610c6c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._valuesChange$Action, callContext, valuesIn);
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
span.setAttribute("outsystems.function.key", "7e835950-6fc2-48d0-921c-05468fc75123");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
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
span.setAttribute("outsystems.function.key", "965b62b8-b6e8-4c3f-9c98-d8feab08c60e");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "db867865-c2a6-476b-875b-98db2b2ad06f");
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.ValuesChange$vars", [{
name: "values",
attrName: "valuesInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.ValuesChange$getSelectedValueJSResult", [{
name: "IntervalStart",
attrName: "intervalStartOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "IntervalEnd",
attrName: "intervalEndOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnReady$initSliderJSResult", [{
name: "SliderObject",
attrName: "sliderObjectOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.SetRTLObserver$setActionAsObjJSResult", [{
name: "Action",
attrName: "actionOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnParametersChanged$vars", [{
name: "DirectionApplied",
attrName: "directionAppliedVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.OnParametersChanged$checkObjectStatusJSResult", [{
name: "ObjectIsDefined",
attrName: "objectIsDefinedOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




