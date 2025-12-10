import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_Carousel_mvc_TranslationsResources from "./OutSystemsUI.Interaction.Carousel.mvc$translationsResources.js";
import OutSystemsUI_Interaction_Carousel_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS from "./OutSystemsUI.Interaction.Carousel.mvc$controller.RegisterCallbacks.GetCallbackHandlersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_Carousel_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onSlideMovedHandler$Action: function (carouselIdIn, indexIn) {
carouselIdIn = (carouselIdIn === undefined) ? "" : carouselIdIn;
indexIn = (indexIn === undefined) ? 0 : indexIn;
return controller.executeActionInsideJSNode(controller._onSlideMovedHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(carouselIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(indexIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSlideMovedHandler");
},
initializeHandler$Action: function (carouselIdIn) {
carouselIdIn = (carouselIdIn === undefined) ? "" : carouselIdIn;
return controller.executeActionInsideJSNode(controller._initializeHandler$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(carouselIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "InitializeHandler");
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
span.setAttribute("outsystems.function.key", "1c69d0f1-3724-475c-b06f-bae9655df488");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: CarouselDestroy
OutSystemsUIController.default.carouselDestroy$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
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

get _initializeHandler$Action() {if(!(this.hasOwnProperty("__initializeHandler$Action"))) {
this.__initializeHandler$Action = function (carouselIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializeHandler", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeHandler");
span.setAttribute("outsystems.function.key", "2878f020-349a-4095-92b5-64914bdbefc7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializeHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Carousel.InitializeHandler$vars"))());
vars.value.carouselIdInLocal = carouselIdIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: Initialized
return controller.initialized$Action(vars.value.carouselIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__initializeHandler$Action;
}set _initializeHandler$Action(value) {this.__initializeHandler$Action = value;
}

get _onSlideMovedHandler$Action() {if(!(this.hasOwnProperty("__onSlideMovedHandler$Action"))) {
this.__onSlideMovedHandler$Action = function (carouselIdIn, indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSlideMovedHandler", function (span) {
if(span) {
span.setAttribute("code.function", "OnSlideMovedHandler");
span.setAttribute("outsystems.function.key", "2b489ae5-936e-4624-b650-e33d88fbc446");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSlideMovedHandler");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Carousel.OnSlideMovedHandler$vars"))());
vars.value.carouselIdInLocal = carouselIdIn;
vars.value.indexInLocal = indexIn;
return OS.Flow.executeAsyncFlow(function () {
// Trigger Event: OnSlideMoved
return controller.onSlideMoved$Action(vars.value.carouselIdInLocal, vars.value.indexInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__onSlideMovedHandler$Action;
}set _onSlideMovedHandler$Action(value) {this.__onSlideMovedHandler$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "4c5a128f-3f2a-4cb0-b2f3-031aef45cb2d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
if((((model.variables.navigationIn) !== (model.variables.internalConfigsVar.navigationAttr)))) {
// Navigation
// InternalConfigs.Navigation = Navigation
model.variables.internalConfigsVar.navigationAttr = model.variables.navigationIn;
// Execute Action: Update_Navigation
OutSystemsUIController.default.carouselChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Navigation", model.variables.internalConfigsVar.navigationAttr, callContext);
}

if((((model.variables.itemsPerSlideIn.desktopAttr) !== (model.variables.internalConfigsVar.itemsDesktopAttr)))) {
// ItemsDesktop
// InternalConfigs.ItemsDesktop = ItemsPerSlide.Desktop
model.variables.internalConfigsVar.itemsDesktopAttr = model.variables.itemsPerSlideIn.desktopAttr;
// Execute Action: Update_ItemsDesktop
OutSystemsUIController.default.carouselChangeIntegerProp$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ItemsDesktop", model.variables.internalConfigsVar.itemsDesktopAttr, callContext);
}

if((((model.variables.itemsPerSlideIn.tabletAttr) !== (model.variables.internalConfigsVar.itemsTabletAttr)))) {
// ItemsTablet
// InternalConfigs.ItemsTablet = ItemsPerSlide.Tablet
model.variables.internalConfigsVar.itemsTabletAttr = model.variables.itemsPerSlideIn.tabletAttr;
// Execute Action: Update_ItemsTablet
OutSystemsUIController.default.carouselChangeIntegerProp$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ItemsTablet", model.variables.internalConfigsVar.itemsTabletAttr, callContext);
}

if((((model.variables.itemsPerSlideIn.phoneAttr) !== (model.variables.internalConfigsVar.itemsPhoneAttr)))) {
// ItemsPhone
// InternalConfigs.ItemsPhone = ItemsPerSlide.Phone
model.variables.internalConfigsVar.itemsPhoneAttr = model.variables.itemsPerSlideIn.phoneAttr;
// Execute Action: Update_ItemsPhone
OutSystemsUIController.default.carouselChangeIntegerProp$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ItemsPhone", model.variables.internalConfigsVar.itemsPhoneAttr, callContext);
}

if((((model.variables.optionalConfigsIn.autoPlayAttr) !== (model.variables.internalConfigsVar.autoPlayAttr)))) {
// Autoplay
// InternalConfigs.AutoPlay = OptionalConfigs.AutoPlay
model.variables.internalConfigsVar.autoPlayAttr = model.variables.optionalConfigsIn.autoPlayAttr;
// Execute Action: Update_AutoPlay
OutSystemsUIController.default.carouselChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "AutoPlay", model.variables.internalConfigsVar.autoPlayAttr, callContext);
}

if((((model.variables.optionalConfigsIn.loopAttr) !== (model.variables.internalConfigsVar.loopAttr)))) {
// Loop
// InternalConfigs.Loop = OptionalConfigs.Loop
model.variables.internalConfigsVar.loopAttr = model.variables.optionalConfigsIn.loopAttr;
// Execute Action: Update_Loop
OutSystemsUIController.default.carouselChangeBooleanProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Loop", model.variables.internalConfigsVar.loopAttr, callContext);
}

if((((model.variables.optionalConfigsIn.paddingAttr) !== (model.variables.internalConfigsVar.paddingAttr)))) {
// Padding
// InternalConfigs.Padding = OptionalConfigs.Padding
model.variables.internalConfigsVar.paddingAttr = model.variables.optionalConfigsIn.paddingAttr;
// Execute Action: Update_Padding
OutSystemsUIController.default.carouselChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Padding", model.variables.internalConfigsVar.paddingAttr, callContext);
}

if((((model.variables.optionalConfigsIn.itemsGapAttr) !== (model.variables.internalConfigsVar.itemsGapAttr)))) {
// ItemsGap
// InternalConfigs.ItemsGap = OptionalConfigs.ItemsGap
model.variables.internalConfigsVar.itemsGapAttr = model.variables.optionalConfigsIn.itemsGapAttr;
// Execute Action: Update_Gap
OutSystemsUIController.default.carouselChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ItemsGap", model.variables.internalConfigsVar.itemsGapAttr, callContext);
}

if((((model.variables.optionalConfigsIn.startingPositionAttr) !== (model.variables.internalConfigsVar.startingPositionAttr)))) {
// StartingPosition
// InternalConfigs.StartingPosition = OptionalConfigs.StartingPosition
model.variables.internalConfigsVar.startingPositionAttr = model.variables.optionalConfigsIn.startingPositionAttr;
// Execute Action: Update_StartingPosition
OutSystemsUIController.default.carouselChangeIntegerProp$Action(model.variables.internalConfigsVar.uniqueIdAttr, "StartingPosition", model.variables.internalConfigsVar.startingPositionAttr, callContext);
}

if((((model.variables.heightIn) !== (model.variables.internalConfigsVar.heightAttr)))) {
// Height
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// Execute Action: Update_Height
OutSystemsUIController.default.carouselChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "Height", model.variables.internalConfigsVar.heightAttr, callContext);
}

if((((model.variables.extendedClassIn) !== (model.variables.internalConfigsVar.extendedClassAttr)))) {
// ExtendedClass
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// Execute Action: Update_ExtendedClass
OutSystemsUIController.default.carouselChangeTextProperty$Action(model.variables.internalConfigsVar.uniqueIdAttr, "ExtendedClass", model.variables.internalConfigsVar.extendedClassAttr, callContext);
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "55a88d23-f92e-4195-9c3a-18901ac10ad0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Execute Action: CarouselInitialize
OutSystemsUIController.default.carouselInitialize$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
// Execute Action: LogEnd
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Carousel created", callContext);
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
span.setAttribute("outsystems.function.key", "dafe53b9-d39c-4d96-baa2-2002b3bd13b5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsUIController.default.logEvent$Action(OutSystemsUIModel.staticEntities.logType.general, "Going to create Carousel", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsUIController.default.generateUniqueId$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);

// Set Initial Configs
// InternalConfigs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internalConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// InternalConfigs.ExtendedClass = ExtendedClass
model.variables.internalConfigsVar.extendedClassAttr = model.variables.extendedClassIn;
// InternalConfigs.Navigation = Navigation
model.variables.internalConfigsVar.navigationAttr = model.variables.navigationIn;
// InternalConfigs.Height = Height
model.variables.internalConfigsVar.heightAttr = model.variables.heightIn;
// InternalConfigs.AutoPlay = OptionalConfigs.AutoPlay
model.variables.internalConfigsVar.autoPlayAttr = model.variables.optionalConfigsIn.autoPlayAttr;
// InternalConfigs.Loop = OptionalConfigs.Loop
model.variables.internalConfigsVar.loopAttr = model.variables.optionalConfigsIn.loopAttr;
// InternalConfigs.Padding = OptionalConfigs.Padding
model.variables.internalConfigsVar.paddingAttr = model.variables.optionalConfigsIn.paddingAttr;
// InternalConfigs.ItemsGap = OptionalConfigs.ItemsGap
model.variables.internalConfigsVar.itemsGapAttr = model.variables.optionalConfigsIn.itemsGapAttr;
// InternalConfigs.StartingPosition = OptionalConfigs.StartingPosition
model.variables.internalConfigsVar.startingPositionAttr = model.variables.optionalConfigsIn.startingPositionAttr;
// InternalConfigs.ItemsDesktop = ItemsPerSlide.Desktop
model.variables.internalConfigsVar.itemsDesktopAttr = model.variables.itemsPerSlideIn.desktopAttr;
// InternalConfigs.ItemsTablet = ItemsPerSlide.Tablet
model.variables.internalConfigsVar.itemsTabletAttr = model.variables.itemsPerSlideIn.tabletAttr;
// InternalConfigs.ItemsPhone = ItemsPerSlide.Phone
model.variables.internalConfigsVar.itemsPhoneAttr = model.variables.itemsPerSlideIn.phoneAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internalConfigsVar, true, false);
// Execute Action: CarouselCreate
OutSystemsUIController.default.carouselCreate$Action(model.variables.internalConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, OutSystemsUIModel.staticEntities.carouselProvider.splide, callContext);
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

get _registerCallbacks$Action() {if(!(this.hasOwnProperty("__registerCallbacks$Action"))) {
this.__registerCallbacks$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RegisterCallbacks", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "e67db216-47ed-4faa-9f19-6598ecde7b6f");
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
span.setAttribute("outsystems.function.key", "12086b05-e58f-48cd-bdd4-a449983a20de");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_Carousel_mvc_controller_RegisterCallbacks_GetCallbackHandlersJS, "GetCallbackHandlers", "RegisterCallbacks", {
OnSlideMovedObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnCarouselInitializedObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.Carousel.RegisterCallbacks$getCallbackHandlersJSResult"))();
jsNodeResult.onSlideMovedObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnSlideMovedObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.onCarouselInitializedObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnCarouselInitializedObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnSlideMovedHandler: controller.clientActionProxies.onSlideMovedHandler$Action,
InitializeHandler: controller.clientActionProxies.initializeHandler$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: RegisterOnSlideMoved
OutSystemsUIController.default.carouselRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.carousel_OnSlideMoved, getCallbackHandlersJSResult.value.onSlideMovedObjOut, callContext);
// Execute Action: RegisterOnCarouselInitialized
OutSystemsUIController.default.carouselRegisterCallback$Action(model.variables.internalConfigsVar.uniqueIdAttr, OutSystemsUIModel.staticEntities.registeredCallbackEvents.initialized, getCallbackHandlersJSResult.value.onCarouselInitializedObjOut, callContext);
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

get _onRender$Action() {if(!(this.hasOwnProperty("__onRender$Action"))) {
this.__onRender$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnRender", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "ff217726-3e54-4696-a30d-8293d473e1b0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnRender");
callContext = controller.callContext(callContext);
// Execute Action: CarouselUpdateOnRender
OutSystemsUIController.default.carouselUpdateOnRender$Action(model.variables.internalConfigsVar.uniqueIdAttr, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onRender$Action;
}set _onRender$Action(value) {this.__onRender$Action = value;
}


onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "1c69d0f1-3724-475c-b06f-bae9655df488");
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

initializeHandler$Action(carouselIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializeHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeHandler");
span.setAttribute("outsystems.function.key", "2878f020-349a-4095-92b5-64914bdbefc7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializeHandler$Action, callContext, carouselIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSlideMovedHandler$Action(carouselIdIn, indexIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSlideMovedHandler__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSlideMovedHandler");
span.setAttribute("outsystems.function.key", "2b489ae5-936e-4624-b650-e33d88fbc446");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSlideMovedHandler$Action, callContext, carouselIdIn, indexIn);
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
span.setAttribute("outsystems.function.key", "4c5a128f-3f2a-4cb0-b2f3-031aef45cb2d");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "55a88d23-f92e-4195-9c3a-18901ac10ad0");
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
span.setAttribute("outsystems.function.key", "dafe53b9-d39c-4d96-baa2-2002b3bd13b5");
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

registerCallbacks$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RegisterCallbacks__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterCallbacks");
span.setAttribute("outsystems.function.key", "e67db216-47ed-4faa-9f19-6598ecde7b6f");
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

onRender$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnRender__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnRender");
span.setAttribute("outsystems.function.key", "ff217726-3e54-4696-a30d-8293d473e1b0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onRender$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onSlideMoved$Action() {if(!(this.hasOwnProperty("_onSlideMoved$Action"))) {
this._onSlideMoved$Action = function () {
return Promise.resolve();
};
}

return this._onSlideMoved$Action;
}set onSlideMoved$Action(value) {this._onSlideMoved$Action = value;
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
this._onRenderEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onRender$Action(callContext);

};
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Carousel.InitializeHandler$vars", [{
name: "CarouselId",
attrName: "carouselIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Carousel.OnSlideMovedHandler$vars", [{
name: "CarouselId",
attrName: "carouselIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Index",
attrName: "indexInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.Carousel.RegisterCallbacks$getCallbackHandlersJSResult", [{
name: "OnSlideMovedObj",
attrName: "onSlideMovedObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnCarouselInitializedObj",
attrName: "onCarouselInitializedObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




