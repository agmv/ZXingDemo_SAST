import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnDestroy_DestroyJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.OnDestroy.DestroyJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_ValuesChange_GetSelectedValueJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.ValuesChange.GetSelectedValueJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnReady_InitSliderJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.OnReady.InitSliderJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_SetRTLObserver_SetActionAsObjJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.SetRTLObserver.SetActionAsObjJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnParametersChanged_UpdateValueJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.OnParametersChanged.UpdateValueJS.js";
import OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnParametersChanged_CheckObjectStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.mvc$controller.OnParametersChanged.CheckObjectStatusJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
valuesChange$Action: function (valueIn) {
valueIn = (valueIn === undefined) ? null : valueIn;
return controller.executeActionInsideJSNode(controller._valuesChange$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(valueIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
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
span.setAttribute("outsystems.function.key", "23567576-3e16-4a31-8511-9acaec3d809b");
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
span.setAttribute("outsystems.function.key", "79586378-afa1-423e-9f3b-32d87aa672e3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnDestroy_DestroyJS, "Destroy", "OnDestroy", {
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

get _valuesChange$Action() {if(!(this.hasOwnProperty("__valuesChange$Action"))) {
this.__valuesChange$Action = function (valueIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ValuesChange", function (span) {
if(span) {
span.setAttribute("code.function", "ValuesChange");
span.setAttribute("outsystems.function.key", "45e083dd-1139-4cfc-a0a0-79f41275c96f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ValuesChange");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.ValuesChange$vars"))());
vars.value.valueInLocal = valueIn;
var getSelectedValueJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
getSelectedValueJSResult.value = OS.Logger.startActiveSpan("GetSelectedValue", function (span) {
if(span) {
span.setAttribute("code.function", "GetSelectedValue");
span.setAttribute("outsystems.function.key", "28b2b04c-903c-42a6-b9e7-b5a12657fa66");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_ValuesChange_GetSelectedValueJS, "GetSelectedValue", "ValuesChange", {
InValue: OS.DataConversion.JSNodeParamConverter.to(vars.value.valueInLocal, OS.DataTypes.DataTypes.Object),
Value: OS.DataConversion.JSNodeParamConverter.to(OS.DataTypes.Decimal.defaultValue, OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.ValuesChange$getSelectedValueJSResult"))();
jsNodeResult.valueOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Value, OS.DataTypes.DataTypes.Decimal);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return OS.Flow.executeSequence(function () {
if((!(model.variables.currentValueVar.equals(getSelectedValueJSResult.value.valueOut)))) {
// CurrentValue = GetSelectedValue.Value
model.variables.currentValueVar = getSelectedValueJSResult.value.valueOut;
// Trigger Event: OnChange
return controller.onChange$Action(model.variables.currentValueVar, callContext);
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
span.setAttribute("outsystems.function.key", "6357684e-8a5a-45e8-a484-9d4b3c95df2b");
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
span.setAttribute("outsystems.function.key", "299999b6-9e0b-4f50-b8ce-ff2eed6cb6f2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnReady_InitSliderJS, "InitSlider", "OnReady", {
IsVertical: OS.DataConversion.JSNodeParamConverter.to(model.variables.isVerticalIn, OS.DataTypes.DataTypes.Boolean),
ChangeEventDuringSlide: OS.DataConversion.JSNodeParamConverter.to(model.variables.changeEventDuringSlideIn, OS.DataTypes.DataTypes.Boolean),
Direction: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentOptionsVar.directionAttr, OS.DataTypes.DataTypes.Text),
Max: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxValueIn, OS.DataTypes.DataTypes.Decimal),
AdvancedFormat: OS.DataConversion.JSNodeParamConverter.to(model.variables.advancedFormatIn, OS.DataTypes.DataTypes.Text),
SliderContainerId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("RangeSlider"), OS.DataTypes.DataTypes.Text),
Step: OS.DataConversion.JSNodeParamConverter.to(model.variables.stepIn, OS.DataTypes.DataTypes.Decimal),
ShowPips: OS.DataConversion.JSNodeParamConverter.to(model.variables.showPipsIn, OS.DataTypes.DataTypes.Boolean),
Initial: OS.DataConversion.JSNodeParamConverter.to(model.variables.initialValueIn, OS.DataTypes.DataTypes.Decimal),
Min: OS.DataConversion.JSNodeParamConverter.to(model.variables.minValueIn, OS.DataTypes.DataTypes.Decimal),
PipsStep: OS.DataConversion.JSNodeParamConverter.to(model.variables.pipsStepIn, OS.DataTypes.DataTypes.Integer),
SliderObject: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnReady$initSliderJSResult"))();
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
// CurrentOptions.InitialValue = InitialValue
model.variables.currentOptionsVar.initialValueAttr = model.variables.initialValueIn;
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
span.setAttribute("outsystems.function.key", "63e9937b-718d-4133-904b-428be852ceaf");
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
span.setAttribute("outsystems.function.key", "a94ffa59-1da5-4424-b1ba-8d6021cf7d5e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_SetRTLObserver_SetActionAsObjJS, "SetActionAsObj", "SetRTLObserver", {
Action: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.SetRTLObserver$setActionAsObjJSResult"))();
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
span.setAttribute("outsystems.function.key", "732060cb-9463-46b0-92f9-1b78f5598d91");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnParametersChanged$vars"))());
var isRTLVar = new OS.DataTypes.VariableHolder();
var checkObjectStatusJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: IsRTL
isRTLVar.value = OutSystemsUIController.default.isRTL$Action(callContext);

// DirectionChanged?
// DirectionApplied = If
vars.value.directionAppliedVar = ((isRTLVar.value.isRTLOut) ? ("rtl") : ("ltr"));
if((!(model.variables.currentOptionsVar.initialValueAttr.equals(model.variables.initialValueIn)))) {
if((!(model.variables.isSlidingVar))) {
OS.Logger.startActiveSpan("UpdateValue", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateValue");
span.setAttribute("outsystems.function.key", "09e02fa8-8e82-422e-8407-3617c35e1481");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnParametersChanged_UpdateValueJS, "UpdateValue", "OnParametersChanged", {
Value: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(model.variables.initialValueIn)), OS.DataTypes.DataTypes.Integer),
SliderObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.sliderObjectVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// UpdateValues
// CurrentOptions.InitialValue = InitialValue
model.variables.currentOptionsVar.initialValueAttr = model.variables.initialValueIn;
// CurrentValue = InitialValue
model.variables.currentValueVar = model.variables.initialValueIn;
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
span.setAttribute("outsystems.function.key", "4c3390a0-2af1-47cd-ac7e-81c6825f1647");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_RangeSliderV2_mvc_controller_OnParametersChanged_CheckObjectStatusJS, "CheckObjectStatus", "OnParametersChanged", {
Object: OS.DataConversion.JSNodeParamConverter.to(model.variables.sliderObjectVar, OS.DataTypes.DataTypes.Object),
ObjectIsDefined: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnParametersChanged$checkObjectStatusJSResult"))();
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
// InitialValue = CurrentValue
model.variables.initialValueIn = model.variables.currentValueVar;
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a8049275-94ed-4cd8-bd4c-4f5cda42058b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// CurrentValue = InitialValue
model.variables.currentValueVar = model.variables.initialValueIn;
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
span.setAttribute("outsystems.function.key", "e806affa-0575-4a2a-a96f-a479d5cbeaf8");
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


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "23567576-3e16-4a31-8511-9acaec3d809b");
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

valuesChange$Action(valueIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ValuesChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValuesChange");
span.setAttribute("outsystems.function.key", "45e083dd-1139-4cfc-a0a0-79f41275c96f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._valuesChange$Action, callContext, valueIn);
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
span.setAttribute("outsystems.function.key", "6357684e-8a5a-45e8-a484-9d4b3c95df2b");
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
span.setAttribute("outsystems.function.key", "63e9937b-718d-4133-904b-428be852ceaf");
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
span.setAttribute("outsystems.function.key", "732060cb-9463-46b0-92f9-1b78f5598d91");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a8049275-94ed-4cd8-bd4c-4f5cda42058b");
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
span.setAttribute("outsystems.function.key", "e806affa-0575-4a2a-a96f-a479d5cbeaf8");
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.ValuesChange$vars", [{
name: "value",
attrName: "valueInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.ValuesChange$getSelectedValueJSResult", [{
name: "Value",
attrName: "valueOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnReady$initSliderJSResult", [{
name: "SliderObject",
attrName: "sliderObjectOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.SetRTLObserver$setActionAsObjJSResult", [{
name: "Action",
attrName: "actionOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnParametersChanged$vars", [{
name: "DirectionApplied",
attrName: "directionAppliedVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_RangeSliderV2.OnParametersChanged$checkObjectStatusJSResult", [{
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




