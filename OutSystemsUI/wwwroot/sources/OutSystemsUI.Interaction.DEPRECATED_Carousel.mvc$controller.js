import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_TranslationsResources from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$translationsResources.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GetMaxElementsJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GoTo.GetMaxElementsJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GoToTargetJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GoTo.GoToTargetJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GoToLastJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GoTo.GoToLastJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_SetInterval_AutoplayLoopJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.SetInterval.AutoplayLoopJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Init_InitCarouselJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.Init.InitCarouselJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Update_UpdateJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.Update.UpdateJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_ClearInterval_ClearIntervalJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.ClearInterval.ClearIntervalJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnOrientationChange_OnOrientationChangeJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.OnOrientationChange.OnOrientationChangeJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_AddNoTransitionClassesJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureStart.AddNoTransitionClassesJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_RemoveNoTransitionJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureStart.RemoveNoTransitionJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_CheckIfContainsClassJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureStart.CheckIfContainsClassJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureMove_AddNoTransitionClassesJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureMove.AddNoTransitionClassesJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureMove_TransformUiJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureMove.TransformUiJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_PrepareElementsJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureEnd.PrepareElementsJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_ChangeIsAnimatingStatusJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureEnd.ChangeIsAnimatingStatusJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_BackToMiddleJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.GestureEnd.BackToMiddleJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Previous_PreviousJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.Previous.PreviousJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnReady_CallingInitJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.OnReady.CallingInitJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Next_NextJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.Next.NextJS.js";
import OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnDestroy_RemoveListnerOnOrientationJS from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.OnDestroy.RemoveListnerOnOrientationJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
previous$Action: function () {
return controller.executeActionInsideJSNode(controller._previous$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Previous");
},
next$Action: function () {
return controller.executeActionInsideJSNode(controller._next$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Next");
},
goTo$Action: function (targetIn) {
targetIn = (targetIn === undefined) ? 0 : targetIn;
return controller.executeActionInsideJSNode(controller._goTo$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(targetIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "GoTo");
},
update$Action: function () {
return controller.executeActionInsideJSNode(controller._update$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Update");
},
changeIsAnimatingStatus$Action: function () {
return controller.executeActionInsideJSNode(controller._changeIsAnimatingStatus$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ChangeIsAnimatingStatus");
},
onOrientationChange$Action: function () {
return controller.executeActionInsideJSNode(controller._onOrientationChange$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnOrientationChange");
},
init$Action: function () {
return controller.executeActionInsideJSNode(controller._init$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Init");
},
setEventsStatus$Action: function (addEventsIn) {
addEventsIn = (addEventsIn === undefined) ? false : addEventsIn;
return controller.executeActionInsideJSNode(controller._setEventsStatus$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(addEventsIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetEventsStatus");
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
get _setEventsStatus$Action() {if(!(this.hasOwnProperty("__setEventsStatus$Action"))) {
this.__setEventsStatus$Action = function (addEventsIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetEventsStatus", function (span) {
if(span) {
span.setAttribute("code.function", "SetEventsStatus");
span.setAttribute("outsystems.function.key", "05b06c27-4413-4847-a720-dfa352e6c1e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetEventsStatus");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetEventsStatus$vars"))());
vars.value.addEventsInLocal = addEventsIn;
// AddDragEvents = AddEvents
model.variables.addDragEventsVar = vars.value.addEventsInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setEventsStatus$Action;
}set _setEventsStatus$Action(value) {this.__setEventsStatus$Action = value;
}

get _changeIsAnimatingStatus$Action() {if(!(this.hasOwnProperty("__changeIsAnimatingStatus$Action"))) {
this.__changeIsAnimatingStatus$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ChangeIsAnimatingStatus", function (span) {
if(span) {
span.setAttribute("code.function", "ChangeIsAnimatingStatus");
span.setAttribute("outsystems.function.key", "32cd0b58-7afc-47c1-ba19-5eb9137ce740");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ChangeIsAnimatingStatus");
callContext = controller.callContext(callContext);
// IsAnimating = False
model.variables.isAnimatingVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__changeIsAnimatingStatus$Action;
}set _changeIsAnimatingStatus$Action(value) {this.__changeIsAnimatingStatus$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "438904d8-b289-42d3-8513-d55609df5b42");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// Execute Action: Update
controller._update$Action(callContext);
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

get _goTo$Action() {if(!(this.hasOwnProperty("__goTo$Action"))) {
this.__goTo$Action = function (targetIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GoTo", function (span) {
if(span) {
span.setAttribute("code.function", "GoTo");
span.setAttribute("outsystems.function.key", "54fe6009-a951-4d1b-bd9c-493cc337bffe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GoTo");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GoTo$vars"))());
vars.value.targetInLocal = targetIn;
var getMaxElementsJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
getMaxElementsJSResult.value = OS.Logger.startActiveSpan("GetMaxElements", function (span) {
if(span) {
span.setAttribute("code.function", "GetMaxElements");
span.setAttribute("outsystems.function.key", "392651b0-970c-4727-b381-fbc38c805364");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GetMaxElementsJS, "GetMaxElements", "GoTo", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object),
MaxElements: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GoTo$getMaxElementsJSResult"))();
jsNodeResult.maxElementsOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MaxElements, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Autoplay?
if((((model.variables.autoplayIn) !== (OutSystemsUIModel.staticEntities.autoplay.disabled)))) {
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
// Execute Action: SetInterval
controller._setInterval$Action(callContext);
}

// elementExists?
if(((vars.value.targetInLocal >= getMaxElementsJSResult.value.maxElementsOut))) {
OS.Logger.startActiveSpan("GoToLast", function (span) {
if(span) {
span.setAttribute("code.function", "GoToLast");
span.setAttribute("outsystems.function.key", "d9f5ed93-6a7a-4453-a54f-65c74619986c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GoToLastJS, "GoToLast", "GoTo", {
Target: OS.DataConversion.JSNodeParamConverter.to((getMaxElementsJSResult.value.maxElementsOut - 1), OS.DataTypes.DataTypes.Integer),
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
OS.Logger.startActiveSpan("GoToTarget", function (span) {
if(span) {
span.setAttribute("code.function", "GoToTarget");
span.setAttribute("outsystems.function.key", "cfa9b203-da74-4814-8d03-ef856d3c104c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GoTo_GoToTargetJS, "GoToTarget", "GoTo", {
Target: OS.DataConversion.JSNodeParamConverter.to(vars.value.targetInLocal, OS.DataTypes.DataTypes.Integer),
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Trigger Event: OnItemChange
return controller.onItemChange$Action(vars.value.targetInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__goTo$Action;
}set _goTo$Action(value) {this.__goTo$Action = value;
}

get _setInterval$Action() {if(!(this.hasOwnProperty("__setInterval$Action"))) {
this.__setInterval$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetInterval", function (span) {
if(span) {
span.setAttribute("code.function", "SetInterval");
span.setAttribute("outsystems.function.key", "75b816a0-1829-4bfe-b11e-2f5b4848d6a7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetInterval");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetInterval$vars"))());
var autoplayLoopJSResult = new OS.DataTypes.VariableHolder();
if(((model.variables.autoplayIn === OutSystemsUIModel.staticEntities.autoplay.slow))) {
// AutoplayValue = 8000
vars.value.autoplayValueVar = 8000;
} else {
if((model.variables.autoplayIn === OutSystemsUIModel.staticEntities.autoplay.normal)) {
// AutoplayValue = 5000
vars.value.autoplayValueVar = 5000;
} else {
if((model.variables.autoplayIn === OutSystemsUIModel.staticEntities.autoplay.fast)) {
// AutoplayValue = 2000
vars.value.autoplayValueVar = 2000;
} else {
return ;

}

}

}

autoplayLoopJSResult.value = OS.Logger.startActiveSpan("AutoplayLoop", function (span) {
if(span) {
span.setAttribute("code.function", "AutoplayLoop");
span.setAttribute("outsystems.function.key", "d533cfe7-d7df-40f5-a6b3-920989c456e3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_SetInterval_AutoplayLoopJS, "AutoplayLoop", "SetInterval", {
Autoplay: OS.DataConversion.JSNodeParamConverter.to(vars.value.autoplayValueVar, OS.DataTypes.DataTypes.Integer),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(OutSystemsUIController.default.isRTL$Action(callContext).isRTLOut, OS.DataTypes.DataTypes.Boolean),
AutoplayObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetInterval$autoplayLoopJSResult"))();
jsNodeResult.autoplayObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.AutoplayObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
Previous: controller.clientActionProxies.previous$Action,
Next: controller.clientActionProxies.next$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// AutplayObj = AutoplayLoop.AutoplayObj
model.variables.autplayObjVar = autoplayLoopJSResult.value.autoplayObjOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setInterval$Action;
}set _setInterval$Action(value) {this.__setInterval$Action = value;
}

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "7e61790d-5054-451c-af26-f4ac1f98916b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("InitCarousel", function (span) {
if(span) {
span.setAttribute("code.function", "InitCarousel");
span.setAttribute("outsystems.function.key", "0ddeff0a-bef5-45b0-9458-4a7a2a0ed66b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Init_InitCarouselJS, "InitCarousel", "Init", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("carousel"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
IsRTL: OutSystemsUIController.default.clientActionProxies.isRTL$Action,
Previous: controller.clientActionProxies.previous$Action,
Next: controller.clientActionProxies.next$Action,
GoTo: controller.clientActionProxies.goTo$Action,
Update: controller.clientActionProxies.update$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Autoplay?
if((((model.variables.autoplayIn) !== (OutSystemsUIModel.staticEntities.autoplay.disabled)))) {
// Execute Action: SetInterval
controller._setInterval$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__init$Action;
}set _init$Action(value) {this.__init$Action = value;
}

get _update$Action() {if(!(this.hasOwnProperty("__update$Action"))) {
this.__update$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Update", function (span) {
if(span) {
span.setAttribute("code.function", "Update");
span.setAttribute("outsystems.function.key", "8643ab2e-e5f2-440b-b34e-309fed5f386e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Update");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Update", function (span) {
if(span) {
span.setAttribute("code.function", "Update");
span.setAttribute("outsystems.function.key", "b499df7f-d929-4e8a-a59c-03d1933c4510");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Update_UpdateJS, "Update", "Update", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__update$Action;
}set _update$Action(value) {this.__update$Action = value;
}

get _clearInterval$Action() {if(!(this.hasOwnProperty("__clearInterval$Action"))) {
this.__clearInterval$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ClearInterval", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval");
span.setAttribute("outsystems.function.key", "86528668-5f60-4106-90ca-3a7849b972fe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearInterval");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("ClearInterval", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval");
span.setAttribute("outsystems.function.key", "5402e476-4d9f-41fa-ac01-fe02296c83ed");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_ClearInterval_ClearIntervalJS, "ClearInterval", "ClearInterval", {
AutoplayObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.autplayObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__clearInterval$Action;
}set _clearInterval$Action(value) {this.__clearInterval$Action = value;
}

get _onOrientationChange$Action() {if(!(this.hasOwnProperty("__onOrientationChange$Action"))) {
this.__onOrientationChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnOrientationChange", function (span) {
if(span) {
span.setAttribute("code.function", "OnOrientationChange");
span.setAttribute("outsystems.function.key", "98ff6576-8a54-46e4-b018-0de7b3e65261");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnOrientationChange");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("OnOrientationChange", function (span) {
if(span) {
span.setAttribute("code.function", "OnOrientationChange");
span.setAttribute("outsystems.function.key", "2c4f5ebb-e73a-4742-b9f9-e9bd816bb562");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnOrientationChange_OnOrientationChangeJS, "OnOrientationChange", "OnOrientationChange", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__onOrientationChange$Action;
}set _onOrientationChange$Action(value) {this.__onOrientationChange$Action = value;
}

get _gestureStart$Action() {if(!(this.hasOwnProperty("__gestureStart$Action"))) {
this.__gestureStart$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureStart", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "99f7a8c1-7d21-4126-8eb8-0ce92ab948dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureStart");
callContext = controller.callContext(callContext);
var checkIfContainsClassJSResult = new OS.DataTypes.VariableHolder();
if((!(model.variables.isAnimatingVar))) {
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
checkIfContainsClassJSResult.value = OS.Logger.startActiveSpan("CheckIfContainsClass", function (span) {
if(span) {
span.setAttribute("code.function", "CheckIfContainsClass");
span.setAttribute("outsystems.function.key", "9d701cba-ed63-42a5-8e0e-d14100ee8283");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_CheckIfContainsClassJS, "CheckIfContainsClass", "GestureStart", {
CarouselId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("carousel"), OS.DataTypes.DataTypes.Text),
ContainsClass: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureStart$checkIfContainsClassJSResult"))();
jsNodeResult.containsClassOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ContainsClass, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ContainsClass = CheckIfContainsClass.ContainsClass
model.variables.containsClassVar = checkIfContainsClassJSResult.value.containsClassOut;
if((model.variables.containsClassVar)) {
OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "794416e7-f1f1-40f7-9aa7-7ac75fa7640a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_RemoveNoTransitionJS, "RemoveNoTransition", "GestureStart", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("carousel"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
OS.Logger.startActiveSpan("AddNoTransitionClasses", function (span) {
if(span) {
span.setAttribute("code.function", "AddNoTransitionClasses");
span.setAttribute("outsystems.function.key", "710941d4-81c2-4985-ae9e-849fc68607c6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureStart_AddNoTransitionClassesJS, "AddNoTransitionClasses", "GestureStart", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__gestureStart$Action;
}set _gestureStart$Action(value) {this.__gestureStart$Action = value;
}

get _gestureMove$Action() {if(!(this.hasOwnProperty("__gestureMove$Action"))) {
this.__gestureMove$Action = function (offsetXIn, evtIn, offsetYIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "abee9ce7-c001-49d8-9309-7d7c6a910f2f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureMove$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.evtInLocal = evtIn;
vars.value.offsetYInLocal = offsetYIn;
if((!(model.variables.isAnimatingVar))) {
if((model.variables.containsClassVar)) {
// ContainsClass = True
model.variables.containsClassVar = true;
} else {
// No direction set?
do {
// No direction set?
if(((model.variables.dragDirectionVar === ""))) {
// Set drag direction
// DragDirection = If
model.variables.dragDirectionVar = ((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gte(OS.BuiltinFunctions.abs(vars.value.offsetYInLocal))) ? ("horizontal") : ("vertical"));
// Is vertical?
if(((model.variables.dragDirectionVar === "vertical"))) {
OS.Logger.startActiveSpan("AddNoTransitionClasses", function (span) {
if(span) {
span.setAttribute("code.function", "AddNoTransitionClasses");
span.setAttribute("outsystems.function.key", "63026c11-062f-432d-b6e3-b3bc76d8b255");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureMove_AddNoTransitionClassesJS, "AddNoTransitionClasses", "GestureMove", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
break;
}

}

OS.Logger.startActiveSpan("TransformUi", function (span) {
if(span) {
span.setAttribute("code.function", "TransformUi");
span.setAttribute("outsystems.function.key", "cc317888-77aa-4eff-8ee1-09177db9e320");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureMove_TransformUiJS, "TransformUi", "GestureMove", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object),
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object),
OffsetX: OS.DataConversion.JSNodeParamConverter.to(vars.value.offsetXInLocal, OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} while(false)
;
// DragDirection = ""
model.variables.dragDirectionVar = "";
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__gestureMove$Action;
}set _gestureMove$Action(value) {this.__gestureMove$Action = value;
}

get _gestureEnd$Action() {if(!(this.hasOwnProperty("__gestureEnd$Action"))) {
this.__gestureEnd$Action = function (offsetXIn, timeTakenIn, elementhWidthIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "ac401a1f-6288-4ee6-b6c7-60f0207ac447");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.timeTakenInLocal = timeTakenIn;
vars.value.elementhWidthInLocal = elementhWidthIn;
var prepareElementsJSResult = new OS.DataTypes.VariableHolder();
if((!(model.variables.isAnimatingVar))) {
if((model.variables.containsClassVar)) {
// ContainsClass = True
model.variables.containsClassVar = true;
} else {
do {
// RemoveNoTransitionClasses and GetElementWidth
prepareElementsJSResult.value = OS.Logger.startActiveSpan("PrepareElements", function (span) {
if(span) {
span.setAttribute("code.function", "PrepareElements");
span.setAttribute("outsystems.function.key", "3e3e963a-1cd4-45b5-95ac-c91809b2ac5a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_PrepareElementsJS, "PrepareElements", "GestureEnd", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object),
ElementWidth: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureEnd$prepareElementsJSResult"))();
jsNodeResult.elementWidthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ElementWidth, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ElementhWidth = PrepareElements.ElementWidth
vars.value.elementhWidthInLocal = prepareElementsJSResult.value.elementWidthOut;
if((vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0)))) {
// DidItPassHalf?
if(((vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(vars.value.elementhWidthInLocal).div(OS.BuiltinFunctions.integerToDecimal(3))) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
// Execute Action: Previous
controller._previous$Action(callContext);
break;
}

} else {
if(vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0))) {
// DidItPassHalf?
if(((vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(vars.value.elementhWidthInLocal).div(OS.BuiltinFunctions.integerToDecimal(3)).times(OS.BuiltinFunctions.integerToDecimal((-1)))) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
// Execute Action: Next
controller._next$Action(callContext);
break;
}

}

}

OS.Logger.startActiveSpan("BackToMiddle", function (span) {
if(span) {
span.setAttribute("code.function", "BackToMiddle");
span.setAttribute("outsystems.function.key", "bc532309-3973-4e54-b938-66d6eb9f285b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_BackToMiddleJS, "BackToMiddle", "GestureEnd", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
// Execute Action: SetInterval
controller._setInterval$Action(callContext);
} while(false)
;
// IsAnimating = True
model.variables.isAnimatingVar = true;
OS.Logger.startActiveSpan("ChangeIsAnimatingStatus", function (span) {
if(span) {
span.setAttribute("code.function", "ChangeIsAnimatingStatus");
span.setAttribute("outsystems.function.key", "673b19a3-ac9a-4c7d-8eb0-050581e9748c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_GestureEnd_ChangeIsAnimatingStatusJS, "ChangeIsAnimatingStatus", "GestureEnd", null, function ($parameters) {
}, {
ChangeIsAnimatingStatus: controller.clientActionProxies.changeIsAnimatingStatus$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__gestureEnd$Action;
}set _gestureEnd$Action(value) {this.__gestureEnd$Action = value;
}

get _previous$Action() {if(!(this.hasOwnProperty("__previous$Action"))) {
this.__previous$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Previous", function (span) {
if(span) {
span.setAttribute("code.function", "Previous");
span.setAttribute("outsystems.function.key", "ad22897d-dbec-4833-9e65-6a8cbeae8670");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Previous");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Previous", function (span) {
if(span) {
span.setAttribute("code.function", "Previous");
span.setAttribute("outsystems.function.key", "6528ab34-7cf7-4f8c-a5c3-0eba036c6385");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Previous_PreviousJS, "Previous", "Previous", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(OutSystemsUIController.default.isRTL$Action(callContext).isRTLOut, OS.DataTypes.DataTypes.Boolean)
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

return this.__previous$Action;
}set _previous$Action(value) {this.__previous$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c735a917-2d2b-427b-9a23-79b4126fb436");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var callingInitJSResult = new OS.DataTypes.VariableHolder();
// currentDevice = GetDeviceType()
model.variables.currentDeviceVar = OutSystemsUIController.default.getDeviceType$Action(callContext).deviceOut;
callingInitJSResult.value = OS.Logger.startActiveSpan("CallingInit", function (span) {
if(span) {
span.setAttribute("code.function", "CallingInit");
span.setAttribute("outsystems.function.key", "728a8bf4-00c6-4882-90a7-d832797ea7f6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnReady_CallingInitJS, "CallingInit", "OnReady", {
Padding: OS.DataConversion.JSNodeParamConverter.to(model.variables.paddingIn, OS.DataTypes.DataTypes.Integer),
InitialPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.initialPositionIn, OS.DataTypes.DataTypes.Integer),
Center: OS.DataConversion.JSNodeParamConverter.to(model.variables.centerIn, OS.DataTypes.DataTypes.Boolean),
NextArrow: OS.DataConversion.JSNodeParamConverter.to(idService.getId("NextArrow"), OS.DataTypes.DataTypes.Text),
Scale: OS.DataConversion.JSNodeParamConverter.to(model.variables.scaleIn, OS.DataTypes.DataTypes.Boolean),
ItemsDesktop: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsDesktopIn, OS.DataTypes.DataTypes.Integer),
PreviousArrow: OS.DataConversion.JSNodeParamConverter.to(idService.getId("PreviousArrow"), OS.DataTypes.DataTypes.Text),
ItemsTablet: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsTabletIn, OS.DataTypes.DataTypes.Integer),
ItemsPhone: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsPhoneIn, OS.DataTypes.DataTypes.Integer),
Loop: OS.DataConversion.JSNodeParamConverter.to(model.variables.loopIn, OS.DataTypes.DataTypes.Boolean),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(OutSystemsUIController.default.isRTL$Action(callContext).isRTLOut, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("carousel"), OS.DataTypes.DataTypes.Text),
Margin: OS.DataConversion.JSNodeParamConverter.to(model.variables.marginIn, OS.DataTypes.DataTypes.Integer),
Dots: OS.DataConversion.JSNodeParamConverter.to(model.variables.dotsIn, OS.DataTypes.DataTypes.Boolean),
currentDevice: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentDeviceVar, OS.DataTypes.DataTypes.Text),
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.OnReady$callingInitJSResult"))();
jsNodeResult.carouselObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.CarouselObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnOrientationChange: controller.clientActionProxies.onOrientationChange$Action,
Previous: controller.clientActionProxies.previous$Action,
Next: controller.clientActionProxies.next$Action,
Init: controller.clientActionProxies.init$Action,
GoTo: controller.clientActionProxies.goTo$Action,
SetEventsStatus: controller.clientActionProxies.setEventsStatus$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// CarouselObj = CallingInit.CarouselObj
model.variables.carouselObjVar = callingInitJSResult.value.carouselObjOut;
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

get _next$Action() {if(!(this.hasOwnProperty("__next$Action"))) {
this.__next$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Next", function (span) {
if(span) {
span.setAttribute("code.function", "Next");
span.setAttribute("outsystems.function.key", "d21da5fc-ff5a-4b99-aa21-843e731dec3b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Next");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Next", function (span) {
if(span) {
span.setAttribute("code.function", "Next");
span.setAttribute("outsystems.function.key", "94ca10d9-03d6-4cee-bedb-e66a822e978f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_Next_NextJS, "Next", "Next", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(OutSystemsUIController.default.isRTL$Action(callContext).isRTLOut, OS.DataTypes.DataTypes.Boolean)
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

return this.__next$Action;
}set _next$Action(value) {this.__next$Action = value;
}

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "e99bf484-8beb-4a15-ab81-e34d94155016");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// IsAnimating = False
model.variables.isAnimatingVar = false;
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
span.setAttribute("outsystems.function.key", "f1b5f7dd-1b63-4db9-89dd-d96395229c85");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// JS Node to remove EventListner orientationchange
OS.Logger.startActiveSpan("RemoveListnerOnOrientation", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveListnerOnOrientation");
span.setAttribute("outsystems.function.key", "f62223f6-fc64-46f7-975d-d7666749127c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_DEPRECATED_Carousel_mvc_controller_OnDestroy_RemoveListnerOnOrientationJS, "RemoveListnerOnOrientation", "OnDestroy", {
CarouselObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.carouselObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {
OnOrientationChange: controller.clientActionProxies.onOrientationChange$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Autoplay?
if((((model.variables.autoplayIn) !== (OutSystemsUIModel.staticEntities.autoplay.disabled)))) {
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
}

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


setEventsStatus$Action(addEventsIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetEventsStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetEventsStatus");
span.setAttribute("outsystems.function.key", "05b06c27-4413-4847-a720-dfa352e6c1e7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setEventsStatus$Action, callContext, addEventsIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

changeIsAnimatingStatus$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ChangeIsAnimatingStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ChangeIsAnimatingStatus");
span.setAttribute("outsystems.function.key", "32cd0b58-7afc-47c1-ba19-5eb9137ce740");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._changeIsAnimatingStatus$Action, callContext);
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
span.setAttribute("outsystems.function.key", "438904d8-b289-42d3-8513-d55609df5b42");
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

goTo$Action(targetIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GoTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GoTo");
span.setAttribute("outsystems.function.key", "54fe6009-a951-4d1b-bd9c-493cc337bffe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._goTo$Action, callContext, targetIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setInterval$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetInterval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetInterval");
span.setAttribute("outsystems.function.key", "75b816a0-1829-4bfe-b11e-2f5b4848d6a7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setInterval$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

init$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "7e61790d-5054-451c-af26-f4ac1f98916b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._init$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

update$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Update__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Update");
span.setAttribute("outsystems.function.key", "8643ab2e-e5f2-440b-b34e-309fed5f386e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._update$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearInterval$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ClearInterval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval");
span.setAttribute("outsystems.function.key", "86528668-5f60-4106-90ca-3a7849b972fe");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearInterval$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onOrientationChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnOrientationChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnOrientationChange");
span.setAttribute("outsystems.function.key", "98ff6576-8a54-46e4-b018-0de7b3e65261");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onOrientationChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureStart$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "99f7a8c1-7d21-4126-8eb8-0ce92ab948dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureStart$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureMove$Action(offsetXIn, evtIn, offsetYIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "abee9ce7-c001-49d8-9309-7d7c6a910f2f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureMove$Action, callContext, offsetXIn, evtIn, offsetYIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureEnd$Action(offsetXIn, timeTakenIn, elementhWidthIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "ac401a1f-6288-4ee6-b6c7-60f0207ac447");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureEnd$Action, callContext, offsetXIn, timeTakenIn, elementhWidthIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

previous$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Previous__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Previous");
span.setAttribute("outsystems.function.key", "ad22897d-dbec-4833-9e65-6a8cbeae8670");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._previous$Action, callContext);
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
span.setAttribute("outsystems.function.key", "c735a917-2d2b-427b-9a23-79b4126fb436");
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

next$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Next__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Next");
span.setAttribute("outsystems.function.key", "d21da5fc-ff5a-4b99-aa21-843e731dec3b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._next$Action, callContext);
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
span.setAttribute("outsystems.function.key", "e99bf484-8beb-4a15-ab81-e34d94155016");
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
span.setAttribute("outsystems.function.key", "f1b5f7dd-1b63-4db9-89dd-d96395229c85");
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

get onItemChange$Action() {if(!(this.hasOwnProperty("_onItemChange$Action"))) {
this._onItemChange$Action = function () {
return Promise.resolve();
};
}

return this._onItemChange$Action;
}set onItemChange$Action(value) {this._onItemChange$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetEventsStatus$vars", [{
name: "AddEvents",
attrName: "addEventsInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GoTo$vars", [{
name: "Target",
attrName: "targetInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GoTo$getMaxElementsJSResult", [{
name: "MaxElements",
attrName: "maxElementsOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetInterval$vars", [{
name: "AutoplayValue",
attrName: "autoplayValueVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.SetInterval$autoplayLoopJSResult", [{
name: "AutoplayObj",
attrName: "autoplayObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureStart$checkIfContainsClassJSResult", [{
name: "ContainsClass",
attrName: "containsClassOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureMove$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Evt",
attrName: "evtInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureEnd$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "TimeTaken",
attrName: "timeTakenInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "ElementhWidth",
attrName: "elementhWidthInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.GestureEnd$prepareElementsJSResult", [{
name: "ElementWidth",
attrName: "elementWidthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.DEPRECATED_Carousel.OnReady$callingInitJSResult", [{
name: "CarouselObj",
attrName: "carouselObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




