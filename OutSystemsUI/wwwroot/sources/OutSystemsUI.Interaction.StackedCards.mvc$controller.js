import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Interaction_StackedCards_mvc_TranslationsResources from "./OutSystemsUI.Interaction.StackedCards.mvc$translationsResources.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_CurrentElement_GetCurrentElementJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.CurrentElement.GetCurrentElementJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionTop_OnActionTopJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.OnActionTop.OnActionTopJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlayLeft_ResetOverlayLeftJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.ResetOverlayLeft.ResetOverlayLeftJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_SetZindex_SetZindexJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.SetZindex.SetZindexJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_RemoveNoTransition_PrepareElementsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.RemoveNoTransition.PrepareElementsJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_OnReady_WaitListRenderJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.OnReady.WaitListRenderJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_UpdateLastActive_A11S_UpdateLastActive_A11SJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.UpdateLastActive_A11S.UpdateLastActive_A11SJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_TransformUi_TransformUiJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.TransformUi.TransformUiJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureEnd_RemoveZindexObjJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.GestureEnd.RemoveZindexObjJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlays_ResetOverlaysJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.ResetOverlays.ResetOverlaysJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionLeft_OnActionLeftJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.OnActionLeft.OnActionLeftJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_SetActiveHidden_SetActiveHiddenElementJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.SetActiveHidden.SetActiveHiddenElementJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlayRight_ResetOverlayRightJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.ResetOverlayRight.ResetOverlayRightJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureMove_SetZindexObjsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.GestureMove.SetZindexObjsJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureMove_PreventDefaultWDirectionJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.GestureMove.PreventDefaultWDirectionJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_GetObjectsAndActionsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.Init.GetObjectsAndActionsJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_GetElNodesWidthJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.Init.GetElNodesWidthJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_PrepareElementsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.Init.PrepareElementsJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_UpdateUi_UpdateUiJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.UpdateUi.UpdateUiJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_BackToMiddle_RemoveOpacityJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.BackToMiddle.RemoveOpacityJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionRight_OnActionRightJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.OnActionRight.OnActionRightJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_CountElements_CountElementsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.CountElements.CountElementsJS.js";
import OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureStart_PrepareElementsJS from "./OutSystemsUI.Interaction.StackedCards.mvc$controller.GestureStart.PrepareElementsJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Interaction_StackedCards_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onSwipeTop$Action: function () {
return controller.executeActionInsideJSNode(controller._onSwipeTop$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSwipeTop");
},
resetOverlays$Action: function () {
return controller.executeActionInsideJSNode(controller._resetOverlays$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ResetOverlays");
},
init$Action: function (listElNodesIn) {
listElNodesIn = (listElNodesIn === undefined) ? null : listElNodesIn;
return controller.executeActionInsideJSNode(controller._init$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(listElNodesIn, OS.DataTypes.DataTypes.Object)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Init");
},
onSwipeLeft$Action: function () {
return controller.executeActionInsideJSNode(controller._onSwipeLeft$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSwipeLeft");
},
resetOverlayLeft$Action: function () {
return controller.executeActionInsideJSNode(controller._resetOverlayLeft$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ResetOverlayLeft");
},
onSwipeRight$Action: function () {
return controller.executeActionInsideJSNode(controller._onSwipeRight$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnSwipeRight");
},
onListRemoveUpdate$Action: function () {
return controller.executeActionInsideJSNode(controller._onListRemoveUpdate$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnListRemoveUpdate");
},
onActionLeft$Action: function () {
return controller.executeActionInsideJSNode(controller._onActionLeft$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnActionLeft");
},
onActionRight$Action: function () {
return controller.executeActionInsideJSNode(controller._onActionRight$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnActionRight");
},
onActionTop$Action: function () {
return controller.executeActionInsideJSNode(controller._onActionTop$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnActionTop");
},
resetOverlayRight$Action: function () {
return controller.executeActionInsideJSNode(controller._resetOverlayRight$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "ResetOverlayRight");
},
setZindex$Action: function (zindexIn) {
zindexIn = (zindexIn === undefined) ? 0 : zindexIn;
return controller.executeActionInsideJSNode(controller._setZindex$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(zindexIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetZindex");
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
get _currentElement$Action() {if(!(this.hasOwnProperty("__currentElement$Action"))) {
this.__currentElement$Action = function (swipedEventDirectionIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CurrentElement", function (span) {
if(span) {
span.setAttribute("code.function", "CurrentElement");
span.setAttribute("outsystems.function.key", "09285ada-83ed-4d01-9e34-c5442000bd37");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CurrentElement");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.CurrentElement$vars"))());
vars.value.swipedEventDirectionInLocal = swipedEventDirectionIn;
var getCurrentElementJSResult = new OS.DataTypes.VariableHolder();
getCurrentElementJSResult.value = OS.Logger.startActiveSpan("GetCurrentElement", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrentElement");
span.setAttribute("outsystems.function.key", "344e1527-5e2b-4f5f-a892-6fd4a6771ad8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_CurrentElement_GetCurrentElementJS, "GetCurrentElement", "CurrentElement", {
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
CurElObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.CurrentElement$getCurrentElementJSResult"))();
jsNodeResult.curElObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.CurElObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// CurrentElementObj = GetCurrentElement.CurElObj
model.variables.currentElementObjVar = getCurrentElementJSResult.value.curElObjOut;
// ItemNumber = CurrentPosition + 1
vars.value.itemNumberVar = (model.variables.currentPositionVar + 1);
if(((vars.value.swipedEventDirectionInLocal === OutSystemsUIModel.staticEntities.animationType.bottomToTop))) {
// WcagText = "Action top. Item " + ItemNumber + " of " + MaxElements + ","
model.variables.wcagTextVar = ((((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("wPetsfO980e_wcj0rZVv7g#Value.-1856704016.1", "Action top. Item ") + (vars.value.itemNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("wPetsfO980e_wcj0rZVv7g#Value.1063177.1", " of ")) + (model.variables.maxElementsVar).toString()) + ",");
} else {
if((vars.value.swipedEventDirectionInLocal === OutSystemsUIModel.staticEntities.animationType.leftToRight)) {
// WcagText = "Action right. Item " + ItemNumber + " of " + MaxElements + ","
model.variables.wcagTextVar = ((((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("pXuLZqfjUEGV2fDXLlxSQg#Value.-188090167.1", "Action right. Item ") + (vars.value.itemNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("pXuLZqfjUEGV2fDXLlxSQg#Value.1063177.1", " of ")) + (model.variables.maxElementsVar).toString()) + ",");
} else {
if((vars.value.swipedEventDirectionInLocal === OutSystemsUIModel.staticEntities.animationType.rightToLeft)) {
// WcagText = "Action left. Item " + ItemNumber + " of " + MaxElements + ","
model.variables.wcagTextVar = ((((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CoUCd1OfnkauUUCKTQ1NJg#Value.-1602973654.1", "Action left. Item ") + (vars.value.itemNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CoUCd1OfnkauUUCKTQ1NJg#Value.1063177.1", " of ")) + (model.variables.maxElementsVar).toString()) + ",");
} else {
// WcagText = "Item " + ItemNumber + " of " + MaxElements + ","
model.variables.wcagTextVar = ((((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("FsMrFrQg4E6EIdNk0eYhGg#Value.70973261.1", "Item ") + (vars.value.itemNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("FsMrFrQg4E6EIdNk0eYhGg#Value.1063177.1", " of ")) + (model.variables.maxElementsVar).toString()) + ",");
}

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

return this.__currentElement$Action;
}set _currentElement$Action(value) {this.__currentElement$Action = value;
}

get _onActionTop$Action() {if(!(this.hasOwnProperty("__onActionTop$Action"))) {
this.__onActionTop$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnActionTop", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionTop");
span.setAttribute("outsystems.function.key", "0b9c7269-7c09-4001-93e0-8abe95fcaa92");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnActionTop");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("OnActionTop", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionTop");
span.setAttribute("outsystems.function.key", "326b7aee-6ac5-439a-90c4-2e28be731d86");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionTop_OnActionTopJS, "OnActionTop", "OnActionTop", {
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {
OnSwipeTop: controller.clientActionProxies.onSwipeTop$Action,
ResetOverlays: controller.clientActionProxies.resetOverlays$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(1), model.variables.topObjVar, callContext);
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

return this.__onActionTop$Action;
}set _onActionTop$Action(value) {this.__onActionTop$Action = value;
}

get _resetOverlayLeft$Action() {if(!(this.hasOwnProperty("__resetOverlayLeft$Action"))) {
this.__resetOverlayLeft$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ResetOverlayLeft", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayLeft");
span.setAttribute("outsystems.function.key", "17303808-79cb-4930-9745-6b7cea178f18");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetOverlayLeft");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
if((model.variables.useOverlaysIn)) {
OS.Logger.startActiveSpan("ResetOverlayLeft", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayLeft");
span.setAttribute("outsystems.function.key", "50f70528-6e93-40a8-890b-676e2ac7fcb0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlayLeft_ResetOverlayLeftJS, "ResetOverlayLeft", "ResetOverlayLeft", {
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer),
IsFirstTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.isFirstTimeVar, OS.DataTypes.DataTypes.Boolean),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsFirstTime = False
model.variables.isFirstTimeVar = false;
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

return this.__resetOverlayLeft$Action;
}set _resetOverlayLeft$Action(value) {this.__resetOverlayLeft$Action = value;
}

get _setZindex$Action() {if(!(this.hasOwnProperty("__setZindex$Action"))) {
this.__setZindex$Action = function (zindexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetZindex", function (span) {
if(span) {
span.setAttribute("code.function", "SetZindex");
span.setAttribute("outsystems.function.key", "27a69323-91a9-4677-9bc3-cd5aa380e0fd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetZindex");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.SetZindex$vars"))());
vars.value.zindexInLocal = zindexIn;
OS.Logger.startActiveSpan("SetZindex", function (span) {
if(span) {
span.setAttribute("code.function", "SetZindex");
span.setAttribute("outsystems.function.key", "498d7ea5-b3d6-4c57-8589-e03f59121af0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_SetZindex_SetZindexJS, "SetZindex", "SetZindex", {
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
Zindex: OS.DataConversion.JSNodeParamConverter.to(vars.value.zindexInLocal, OS.DataTypes.DataTypes.Integer),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer)
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

return this.__setZindex$Action;
}set _setZindex$Action(value) {this.__setZindex$Action = value;
}

get _removeNoTransition$Action() {if(!(this.hasOwnProperty("__removeNoTransition$Action"))) {
this.__removeNoTransition$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "28aaa088-267c-4403-bad7-e3fee2988a81");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveNoTransition");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("PrepareElements", function (span) {
if(span) {
span.setAttribute("code.function", "PrepareElements");
span.setAttribute("outsystems.function.key", "93b3f8c2-3107-43a6-a095-f92d1bfa3dc4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_RemoveNoTransition_PrepareElementsJS, "PrepareElements", "RemoveNoTransition", {
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__removeNoTransition$Action;
}set _removeNoTransition$Action(value) {this.__removeNoTransition$Action = value;
}

get _onListRemoveUpdate$Action() {if(!(this.hasOwnProperty("__onListRemoveUpdate$Action"))) {
this.__onListRemoveUpdate$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnListRemoveUpdate", function (span) {
if(span) {
span.setAttribute("code.function", "OnListRemoveUpdate");
span.setAttribute("outsystems.function.key", "3823664a-cb2f-475f-8ca3-4a5368903b77");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnListRemoveUpdate");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: RemoveNoTransition
controller._removeNoTransition$Action(callContext);
// Trigger Event: OnItemChange
return controller.onItemChange$Action(0, callContext).then(function () {
// CurrentPosition = 0
model.variables.currentPositionVar = 0;
// Execute Action: UpdateUi
controller._updateUi$Action(callContext);
// Execute Action: CountElements
controller._countElements$Action(callContext);
// Execute Action: CurrentElement
controller._currentElement$Action("", callContext);
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

return this.__onListRemoveUpdate$Action;
}set _onListRemoveUpdate$Action(value) {this.__onListRemoveUpdate$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "3dd87b39-a5e3-4aa4-a1eb-d1259e8f1e6e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("WaitListRender", function (span) {
if(span) {
span.setAttribute("code.function", "WaitListRender");
span.setAttribute("outsystems.function.key", "62188ccb-a41f-474f-a4df-f17270511437");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_OnReady_WaitListRenderJS, "WaitListRender", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("stackedcards"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
Init: controller.clientActionProxies.init$Action
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

return this.__onReady$Action;
}set _onReady$Action(value) {this.__onReady$Action = value;
}

get _updateLastActive_A11S$Action() {if(!(this.hasOwnProperty("__updateLastActive_A11S$Action"))) {
this.__updateLastActive_A11S$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateLastActive_A11S", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateLastActive_A11S");
span.setAttribute("outsystems.function.key", "4345b987-165b-44ec-9a22-541f35c5e6e0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateLastActive_A11S");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("UpdateLastActive_A11S", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateLastActive_A11S");
span.setAttribute("outsystems.function.key", "2ab33967-3cc0-4a5a-9c6c-0aa54355c25c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_UpdateLastActive_A11S_UpdateLastActive_A11SJS, "UpdateLastActive_A11S", "UpdateLastActive_A11S", {
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer)
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

return this.__updateLastActive_A11S$Action;
}set _updateLastActive_A11S$Action(value) {this.__updateLastActive_A11S$Action = value;
}

get _transformUi$Action() {if(!(this.hasOwnProperty("__transformUi$Action"))) {
this.__transformUi$Action = function (moveXIn, moveYIn, opacityIn, elementObjIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TransformUi", function (span) {
if(span) {
span.setAttribute("code.function", "TransformUi");
span.setAttribute("outsystems.function.key", "4eb5e242-7828-4237-bf94-be2dfa3b47f7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TransformUi");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.TransformUi$vars"))());
vars.value.moveXInLocal = moveXIn;
vars.value.moveYInLocal = moveYIn;
vars.value.opacityInLocal = opacityIn;
vars.value.elementObjInLocal = elementObjIn;
OS.Logger.startActiveSpan("TransformUi", function (span) {
if(span) {
span.setAttribute("code.function", "TransformUi");
span.setAttribute("outsystems.function.key", "027f03fb-8181-4554-95ba-4924728cdc58");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_TransformUi_TransformUiJS, "TransformUi", "TransformUi", {
MoveX: OS.DataConversion.JSNodeParamConverter.to(vars.value.moveXInLocal, OS.DataTypes.DataTypes.Decimal),
Rotate: OS.DataConversion.JSNodeParamConverter.to(model.variables.rotateIn, OS.DataTypes.DataTypes.Boolean),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text),
ElementObj: OS.DataConversion.JSNodeParamConverter.to(vars.value.elementObjInLocal, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
MoveY: OS.DataConversion.JSNodeParamConverter.to(vars.value.moveYInLocal, OS.DataTypes.DataTypes.Decimal),
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer),
Opacity: OS.DataConversion.JSNodeParamConverter.to(vars.value.opacityInLocal, OS.DataTypes.DataTypes.Decimal)
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

return this.__transformUi$Action;
}set _transformUi$Action(value) {this.__transformUi$Action = value;
}

get _onSwipeTop$Action() {if(!(this.hasOwnProperty("__onSwipeTop$Action"))) {
this.__onSwipeTop$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSwipeTop", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeTop");
span.setAttribute("outsystems.function.key", "632d88bc-172b-490b-98a2-a70cfe2117ed");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSwipeTop");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: RemoveNoTransition
controller._removeNoTransition$Action(callContext);
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), model.variables.currentElementObjVar, callContext);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUiLeftObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), model.variables.leftObjVar, callContext);
// Execute Action: TransformUiRightObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), model.variables.rightObjVar, callContext);
// Execute Action: TransformUiTopObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), model.variables.topObjVar, callContext);
// Execute Action: ResetOverlays
controller._resetOverlays$Action(callContext);
} else {
// Execute Action: UpdateLastActive_A11S
controller._updateLastActive_A11S$Action(callContext);
}

// CurrentPosition = CurrentPosition + 1
model.variables.currentPositionVar = (model.variables.currentPositionVar + 1);
// Trigger Event: OnTopSwipe
return controller.onTopSwipe$Action((model.variables.currentPositionVar - 1), callContext).then(function () {
// Trigger Event: OnItemChange
return controller.onItemChange$Action((model.variables.currentPositionVar - 1), callContext);
}).then(function () {
// Execute Action: UpdateUi
controller._updateUi$Action(callContext);
// Execute Action: CurrentElement
controller._currentElement$Action(OutSystemsUIModel.staticEntities.animationType.bottomToTop, callContext);
// Execute Action: SetActiveHidden
controller._setActiveHidden$Action(callContext);
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

return this.__onSwipeTop$Action;
}set _onSwipeTop$Action(value) {this.__onSwipeTop$Action = value;
}

get _gestureEnd$Action() {if(!(this.hasOwnProperty("__gestureEnd$Action"))) {
this.__gestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "6ba8b182-7335-4f6e-8c49-d3a029b49d56");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
var block2 = false;
// IsTop?
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
block2 = false;
// IsTop?
return OS.Flow.executeSequence(function () {
if((((vars.value.offsetYInLocal.lt(model.variables.elementHeightVar.times(OS.BuiltinFunctions.integerToDecimal((-1)))) && vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(model.variables.listElNodesWidthVar).div(OS.BuiltinFunctions.integerToDecimal(2)).times(OS.BuiltinFunctions.integerToDecimal((-1))))) && vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(model.variables.listElNodesWidthVar).div(OS.BuiltinFunctions.integerToDecimal(2)))))) {
// DidItMoveToTop?
return OS.Flow.executeSequence(function () {
if(((vars.value.offsetYInLocal.lt(model.variables.elementHeightVar.times(OS.BuiltinFunctions.integerToDecimal((-1)))) || OS.BuiltinFunctions.abs(vars.value.offsetYInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
// Execute Action: OnSwipeTop
return controller._onSwipeTop$Action(callContext).then(function () {
return OS.Flow.returnAsync();

});
}

});
} else {
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
return OS.Flow.executeSequence(function () {
if((vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0)))) {
// DidItMoveToLeft?
return OS.Flow.executeSequence(function () {
if(((vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(model.variables.listElNodesWidthVar).div(OS.BuiltinFunctions.integerToDecimal(2)).times(OS.BuiltinFunctions.integerToDecimal((-1)))) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
// Execute Action: OnSwipeLeft
return controller._onSwipeLeft$Action(callContext).then(function () {
return OS.Flow.breakAsync();
});
}

});
} else {
return OS.Flow.executeSequence(function () {
if(vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0))) {
// DidItMoveToRight?
return OS.Flow.executeSequence(function () {
if(((vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(model.variables.listElNodesWidthVar).div(OS.BuiltinFunctions.integerToDecimal(2))) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)))) {
// Execute Action: OnSwipeRight
return controller._onSwipeRight$Action(callContext).then(function () {
return OS.Flow.breakAsync();
});
}

});
} else {
// jump to block2
block2 = true;
return OS.Flow.breakAsync();
}

});
}

}).then(function () {
// Execute Action: BackToMiddle2
controller._backToMiddle$Action(callContext);
});
}).then(function () {
if(block2) {
return OS.Flow.breakAsync();
}

}).then(function () {
if((model.variables.useOverlaysIn)) {
// This is a fix to use with some existing patterns e.g.: FlipContent
OS.Logger.startActiveSpan("RemoveZindexObj", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveZindexObj");
span.setAttribute("outsystems.function.key", "05de1bb2-0a43-4789-a892-6e470ae33b4b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureEnd_RemoveZindexObjJS, "RemoveZindexObj", "GestureEnd", {
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("stackedcards"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return OS.Flow.returnAsync();

} else {
return OS.Flow.returnAsync();

}

});
}

});
}).then(function () {
// Execute Action: BackToMiddle
controller._backToMiddle$Action(callContext);
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

return this.__gestureEnd$Action;
}set _gestureEnd$Action(value) {this.__gestureEnd$Action = value;
}

get _resetOverlays$Action() {if(!(this.hasOwnProperty("__resetOverlays$Action"))) {
this.__resetOverlays$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ResetOverlays", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlays");
span.setAttribute("outsystems.function.key", "76ac2c97-cedc-4dbf-a84e-b81e569f7e1f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetOverlays");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
if((model.variables.useOverlaysIn)) {
OS.Logger.startActiveSpan("ResetOverlays", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlays");
span.setAttribute("outsystems.function.key", "c1073acc-91fc-40cd-b9fe-03ef56dc0995");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlays_ResetOverlaysJS, "ResetOverlays", "ResetOverlays", {
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
IsFirstTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.isFirstTimeVar, OS.DataTypes.DataTypes.Boolean),
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsFirstTime = False
model.variables.isFirstTimeVar = false;
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

return this.__resetOverlays$Action;
}set _resetOverlays$Action(value) {this.__resetOverlays$Action = value;
}

get _onSwipeLeft$Action() {if(!(this.hasOwnProperty("__onSwipeLeft$Action"))) {
this.__onSwipeLeft$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSwipeLeft", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeLeft");
span.setAttribute("outsystems.function.key", "82816fe7-2c38-4a92-9280-63d642c3647c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSwipeLeft");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: RemoveNoTransition
controller._removeNoTransition$Action(callContext);
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.currentElementObjVar, callContext);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUiLeftObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.leftObjVar, callContext);
// Execute Action: TransformUiTop
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal((-1000)), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.topObjVar, callContext);
// Execute Action: ResetOverlayLeft
controller._resetOverlayLeft$Action(callContext);
} else {
// Execute Action: UpdateLastActive_A11S
controller._updateLastActive_A11S$Action(callContext);
}

// CurrentPosition = CurrentPosition + 1
model.variables.currentPositionVar = (model.variables.currentPositionVar + 1);
// Trigger Event: OnLeftSwipe
return controller.onLeftSwipe$Action((model.variables.currentPositionVar - 1), callContext).then(function () {
// Trigger Event: OnItemChange
return controller.onItemChange$Action((model.variables.currentPositionVar - 1), callContext);
}).then(function () {
// Execute Action: UpdateUi
controller._updateUi$Action(callContext);
// Execute Action: CurrentElement
controller._currentElement$Action(OutSystemsUIModel.staticEntities.animationType.rightToLeft, callContext);
// Execute Action: SetActiveHidden
controller._setActiveHidden$Action(callContext);
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

return this.__onSwipeLeft$Action;
}set _onSwipeLeft$Action(value) {this.__onSwipeLeft$Action = value;
}

get _onSwipeRight$Action() {if(!(this.hasOwnProperty("__onSwipeRight$Action"))) {
this.__onSwipeRight$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnSwipeRight", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeRight");
span.setAttribute("outsystems.function.key", "9278664c-15e4-47c0-aad1-feb5d30ff63a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSwipeRight");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: RemoveNoTransition
controller._removeNoTransition$Action(callContext);
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(1000), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.currentElementObjVar, callContext);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUiRightObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(1000), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.rightObjVar, callContext);
// Execute Action: TransformUiTopObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(1000), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.topObjVar, callContext);
// Execute Action: ResetOverlayRight
controller._resetOverlayRight$Action(callContext);
} else {
// Execute Action: UpdateLastActive_A11S
controller._updateLastActive_A11S$Action(callContext);
}

// CurrentPosition = CurrentPosition + 1
model.variables.currentPositionVar = (model.variables.currentPositionVar + 1);
// Trigger Event: OnRightSwipe
return controller.onRightSwipe$Action((model.variables.currentPositionVar - 1), callContext).then(function () {
// Trigger Event: OnItemChange
return controller.onItemChange$Action((model.variables.currentPositionVar - 1), callContext);
}).then(function () {
// Execute Action: UpdateUi
controller._updateUi$Action(callContext);
// Execute Action: CurrentElement
controller._currentElement$Action(OutSystemsUIModel.staticEntities.animationType.leftToRight, callContext);
// Execute Action: SetActiveHidden
controller._setActiveHidden$Action(callContext);
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

return this.__onSwipeRight$Action;
}set _onSwipeRight$Action(value) {this.__onSwipeRight$Action = value;
}

get _onActionLeft$Action() {if(!(this.hasOwnProperty("__onActionLeft$Action"))) {
this.__onActionLeft$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnActionLeft", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionLeft");
span.setAttribute("outsystems.function.key", "9a9cb240-29ce-4745-ab3e-b92026928fc1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnActionLeft");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("OnActionLeft", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionLeft");
span.setAttribute("outsystems.function.key", "44af5572-462b-4cc4-bc67-d3cef605e53a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionLeft_OnActionLeftJS, "OnActionLeft", "OnActionLeft", {
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
OnSwipeLeft: controller.clientActionProxies.onSwipeLeft$Action,
ResetOverlayLeft: controller.clientActionProxies.resetOverlayLeft$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(1), model.variables.leftObjVar, callContext);
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

return this.__onActionLeft$Action;
}set _onActionLeft$Action(value) {this.__onActionLeft$Action = value;
}

get _setActiveHidden$Action() {if(!(this.hasOwnProperty("__setActiveHidden$Action"))) {
this.__setActiveHidden$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetActiveHidden", function (span) {
if(span) {
span.setAttribute("code.function", "SetActiveHidden");
span.setAttribute("outsystems.function.key", "b254e538-ff8e-43a7-8a8b-a3f2ace460a8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetActiveHidden");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar <= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("SetActiveHiddenElement", function (span) {
if(span) {
span.setAttribute("code.function", "SetActiveHiddenElement");
span.setAttribute("outsystems.function.key", "a3ee11c4-cc23-42f6-b0d7-e1c7a6090962");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_SetActiveHidden_SetActiveHiddenElementJS, "SetActiveHiddenElement", "SetActiveHidden", {
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setActiveHidden$Action;
}set _setActiveHidden$Action(value) {this.__setActiveHidden$Action = value;
}

get _resetOverlayRight$Action() {if(!(this.hasOwnProperty("__resetOverlayRight$Action"))) {
this.__resetOverlayRight$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ResetOverlayRight", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayRight");
span.setAttribute("outsystems.function.key", "b634745d-d238-4165-9c98-47ce046dd48e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetOverlayRight");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
if((model.variables.useOverlaysIn)) {
OS.Logger.startActiveSpan("ResetOverlayRight", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayRight");
span.setAttribute("outsystems.function.key", "5c343574-6fbb-42ca-8dc2-3d8df193a2d2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_ResetOverlayRight_ResetOverlayRightJS, "ResetOverlayRight", "ResetOverlayRight", {
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer),
IsFirstTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.isFirstTimeVar, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsFirstTime = False
model.variables.isFirstTimeVar = false;
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

return this.__resetOverlayRight$Action;
}set _resetOverlayRight$Action(value) {this.__resetOverlayRight$Action = value;
}

get _gestureMove$Action() {if(!(this.hasOwnProperty("__gestureMove$Action"))) {
this.__gestureMove$Action = function (offsetXIn, offsetYIn, evtIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "cb74a1f0-97d1-4315-a158-9315584cb18d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureMove$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.evtInLocal = evtIn;
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("PreventDefaultWDirection", function (span) {
if(span) {
span.setAttribute("code.function", "PreventDefaultWDirection");
span.setAttribute("outsystems.function.key", "58949533-ca41-4b0b-bfd5-0d08164e2205");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureMove_PreventDefaultWDirectionJS, "PreventDefaultWDirection", "GestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: TransformUi
controller._transformUi$Action(vars.value.offsetXInLocal, vars.value.offsetYInLocal, OS.BuiltinFunctions.integerToDecimal(1), model.variables.currentElementObjVar, callContext);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUiTopObj
controller._transformUi$Action(vars.value.offsetXInLocal, vars.value.offsetYInLocal, ((OS.BuiltinFunctions.round(vars.value.offsetYInLocal.plus(model.variables.elementHeightVar.div(OS.BuiltinFunctions.integerToDecimal(2))).div(OS.BuiltinFunctions.integerToDecimal(100)).times(OS.BuiltinFunctions.integerToDecimal((-1))), 16).gt(OS.BuiltinFunctions.integerToDecimal(1))) ? (OS.BuiltinFunctions.integerToDecimal(1)) : (OS.BuiltinFunctions.round(vars.value.offsetYInLocal.plus(model.variables.elementHeightVar.div(OS.BuiltinFunctions.integerToDecimal(2))).div(OS.BuiltinFunctions.integerToDecimal(100)).times(OS.BuiltinFunctions.integerToDecimal((-1))), 16))), model.variables.topObjVar, callContext);
if((vars.value.offsetXInLocal.lt(OS.BuiltinFunctions.integerToDecimal(0)))) {
// Execute Action: TransformUiLeftObj
controller._transformUi$Action(vars.value.offsetXInLocal, vars.value.offsetYInLocal, ((OS.BuiltinFunctions.round(vars.value.offsetXInLocal.div(OS.BuiltinFunctions.integerToDecimal(100)).times(OS.BuiltinFunctions.integerToDecimal((-1))), 16).gt(OS.BuiltinFunctions.integerToDecimal(1))) ? (OS.BuiltinFunctions.integerToDecimal(1)) : (OS.BuiltinFunctions.round(vars.value.offsetXInLocal.div(OS.BuiltinFunctions.integerToDecimal(100)).times(OS.BuiltinFunctions.integerToDecimal((-1))), 16))), model.variables.leftObjVar, callContext);
// Execute Action: TransformUiRightObj2
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.rightObjVar, callContext);
} else {
if(vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0))) {
// Execute Action: TransformUiRightObj
controller._transformUi$Action(vars.value.offsetXInLocal, vars.value.offsetYInLocal, ((OS.BuiltinFunctions.round(vars.value.offsetXInLocal.div(OS.BuiltinFunctions.integerToDecimal(100)), 16).gt(OS.BuiltinFunctions.integerToDecimal(1))) ? (OS.BuiltinFunctions.integerToDecimal(1)) : (OS.BuiltinFunctions.round(vars.value.offsetXInLocal.div(OS.BuiltinFunctions.integerToDecimal(100)), 16))), model.variables.rightObjVar, callContext);
// Execute Action: TransformUiLeftObj2
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.leftObjVar, callContext);
} else {
return ;

}

}

if((model.variables.useOverlaysIn)) {
// This is a fix to use with some existing patterns on e.g.: FlipContent
OS.Logger.startActiveSpan("SetZindexObjs", function (span) {
if(span) {
span.setAttribute("code.function", "SetZindexObjs");
span.setAttribute("outsystems.function.key", "40364b13-7d32-4b87-9616-60d3f205b8aa");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureMove_SetZindexObjsJS, "SetZindexObjs", "GestureMove", {
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object)
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

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (listElNodesIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "d2ad269e-2535-42c6-860f-4189da7963cf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$vars"))());
vars.value.listElNodesInLocal = listElNodesIn;
var getObjectsAndActionsJSResult = new OS.DataTypes.VariableHolder();
var getElNodesWidthJSResult = new OS.DataTypes.VariableHolder();
getObjectsAndActionsJSResult.value = OS.Logger.startActiveSpan("GetObjectsAndActions", function (span) {
if(span) {
span.setAttribute("code.function", "GetObjectsAndActions");
span.setAttribute("outsystems.function.key", "2400112b-ba9c-4204-bc89-3b15113ac514");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_GetObjectsAndActionsJS, "GetObjectsAndActions", "Init", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("stackedcards"), OS.DataTypes.DataTypes.Text),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
RightObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
MessageObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
StackedCardsObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$getObjectsAndActionsJSResult"))();
jsNodeResult.leftObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.LeftObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.rightObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.RightObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.topObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TopObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.messageObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MessageObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.stackedCardsObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.StackedCardsObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
OnSwipeLeft: controller.clientActionProxies.onSwipeLeft$Action,
OnSwipeRight: controller.clientActionProxies.onSwipeRight$Action,
OnSwipeTop: controller.clientActionProxies.onSwipeTop$Action,
OnListRemoveUpdate: controller.clientActionProxies.onListRemoveUpdate$Action,
ResetOverlays: controller.clientActionProxies.resetOverlays$Action,
OnActionLeft: controller.clientActionProxies.onActionLeft$Action,
OnActionRight: controller.clientActionProxies.onActionRight$Action,
OnActionTop: controller.clientActionProxies.onActionTop$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ObjVariables
// ListElNodesObj = ListElNodes
model.variables.listElNodesObjVar = vars.value.listElNodesInLocal;
// LeftObj = GetObjectsAndActions.LeftObj
model.variables.leftObjVar = getObjectsAndActionsJSResult.value.leftObjOut;
// RightObj = GetObjectsAndActions.RightObj
model.variables.rightObjVar = getObjectsAndActionsJSResult.value.rightObjOut;
// TopObj = GetObjectsAndActions.TopObj
model.variables.topObjVar = getObjectsAndActionsJSResult.value.topObjOut;
// StackedCardsObj = GetObjectsAndActions.StackedCardsObj
model.variables.stackedCardsObjVar = getObjectsAndActionsJSResult.value.stackedCardsObjOut;
// Execute Action: CountElements
controller._countElements$Action(callContext);
// Execute Action: CurrentElement
controller._currentElement$Action("", callContext);
getElNodesWidthJSResult.value = OS.Logger.startActiveSpan("GetElNodesWidth", function (span) {
if(span) {
span.setAttribute("code.function", "GetElNodesWidth");
span.setAttribute("outsystems.function.key", "579cf0b8-094e-4e48-885f-a483bee6d969");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_GetElNodesWidthJS, "GetElNodesWidth", "Init", {
StackedCardsObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedCardsObjVar, OS.DataTypes.DataTypes.Object),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
ListElNodesWidth: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
CurElObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$getElNodesWidthJSResult"))();
jsNodeResult.listElNodesWidthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ListElNodesWidth, OS.DataTypes.DataTypes.Integer);
jsNodeResult.curElObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.CurElObj, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// AssignElNodesWidth
// ListElNodesWidth = GetElNodesWidth.ListElNodesWidth
model.variables.listElNodesWidthVar = getElNodesWidthJSResult.value.listElNodesWidthOut;
// Execute Action: UpdateUi
controller._updateUi$Action(callContext);
OS.Logger.startActiveSpan("PrepareElements", function (span) {
if(span) {
span.setAttribute("code.function", "PrepareElements");
span.setAttribute("outsystems.function.key", "74216712-0f75-44ea-b8ce-41969070960d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_Init_PrepareElementsJS, "PrepareElements", "Init", {
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer),
MaxElements: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxElementsVar, OS.DataTypes.DataTypes.Integer),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text),
StackedCardsObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedCardsObjVar, OS.DataTypes.DataTypes.Object),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("stackedcards"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnActionLeft: controller.clientActionProxies.onActionLeft$Action,
OnActionRight: controller.clientActionProxies.onActionRight$Action,
OnActionTop: controller.clientActionProxies.onActionTop$Action
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

return this.__init$Action;
}set _init$Action(value) {this.__init$Action = value;
}

get _updateUi$Action() {if(!(this.hasOwnProperty("__updateUi$Action"))) {
this.__updateUi$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateUi", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUi");
span.setAttribute("outsystems.function.key", "e1290daf-9eb5-47e5-b1c9-6e81f7a13469");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateUi");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("UpdateUi", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUi");
span.setAttribute("outsystems.function.key", "70b7caf9-16b6-4d12-831a-a5f50ed14fa9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_UpdateUi_UpdateUiJS, "UpdateUi", "UpdateUi", {
ElementsMargin: OS.DataConversion.JSNodeParamConverter.to(model.variables.elementsMarginIn, OS.DataTypes.DataTypes.Integer),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
StackedOptions: OS.DataConversion.JSNodeParamConverter.to(model.variables.stackedOptionsIn, OS.DataTypes.DataTypes.Text),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
Items: OS.DataConversion.JSNodeParamConverter.to(model.variables.itemsIn, OS.DataTypes.DataTypes.Integer),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object)
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

return this.__updateUi$Action;
}set _updateUi$Action(value) {this.__updateUi$Action = value;
}

get _backToMiddle$Action() {if(!(this.hasOwnProperty("__backToMiddle$Action"))) {
this.__backToMiddle$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("BackToMiddle", function (span) {
if(span) {
span.setAttribute("code.function", "BackToMiddle");
span.setAttribute("outsystems.function.key", "ecd4830d-2b80-4cb6-8ca9-a6e4331d90d5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("BackToMiddle");
callContext = controller.callContext(callContext);
// Execute Action: RemoveNoTransition
controller._removeNoTransition$Action(callContext);
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(1), model.variables.currentElementObjVar, callContext);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUiLeftObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.leftObjVar, callContext);
// Execute Action: TransformUiRightObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.rightObjVar, callContext);
// Execute Action: TransformUiTopObj
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), model.variables.topObjVar, callContext);
}

// Execute Action: SetZindex
controller._setZindex$Action(5, callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("RemoveOpacity", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOpacity");
span.setAttribute("outsystems.function.key", "87c5157f-2af9-4aaf-8e42-5674d95d0d8e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_BackToMiddle_RemoveOpacityJS, "RemoveOpacity", "BackToMiddle", {
MaxElements: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxElementsVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__backToMiddle$Action;
}set _backToMiddle$Action(value) {this.__backToMiddle$Action = value;
}

get _onActionRight$Action() {if(!(this.hasOwnProperty("__onActionRight$Action"))) {
this.__onActionRight$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnActionRight", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionRight");
span.setAttribute("outsystems.function.key", "ee1ba588-1d46-4b3a-b246-9e012bc584f9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnActionRight");
callContext = controller.callContext(callContext);
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
OS.Logger.startActiveSpan("OnActionRight", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionRight");
span.setAttribute("outsystems.function.key", "f565e679-b5aa-4318-93c5-6999131addef");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_OnActionRight_OnActionRightJS, "OnActionRight", "OnActionRight", {
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {
OnSwipeRight: controller.clientActionProxies.onSwipeRight$Action,
ResetOverlayRight: controller.clientActionProxies.resetOverlayRight$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.useOverlaysIn)) {
// Execute Action: TransformUi
controller._transformUi$Action(OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(0), OS.BuiltinFunctions.integerToDecimal(1), model.variables.rightObjVar, callContext);
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

return this.__onActionRight$Action;
}set _onActionRight$Action(value) {this.__onActionRight$Action = value;
}

get _countElements$Action() {if(!(this.hasOwnProperty("__countElements$Action"))) {
this.__countElements$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("CountElements", function (span) {
if(span) {
span.setAttribute("code.function", "CountElements");
span.setAttribute("outsystems.function.key", "f5b471f0-e468-4a5f-9b29-20aa572bd746");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CountElements");
callContext = controller.callContext(callContext);
var countElementsJSResult = new OS.DataTypes.VariableHolder();
countElementsJSResult.value = OS.Logger.startActiveSpan("CountElements", function (span) {
if(span) {
span.setAttribute("code.function", "CountElements");
span.setAttribute("outsystems.function.key", "4d993c6b-4d2a-446a-bc3b-1759153aaaf5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_CountElements_CountElementsJS, "CountElements", "CountElements", {
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
MaxElements: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.CountElements$countElementsJSResult"))();
jsNodeResult.maxElementsOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MaxElements, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// MaxElements = CountElements.MaxElements
model.variables.maxElementsVar = countElementsJSResult.value.maxElementsOut;
if(((model.variables.itemsIn > model.variables.maxElementsVar))) {
// Items = MaxElements
model.variables.itemsIn = model.variables.maxElementsVar;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__countElements$Action;
}set _countElements$Action(value) {this.__countElements$Action = value;
}

get _gestureStart$Action() {if(!(this.hasOwnProperty("__gestureStart$Action"))) {
this.__gestureStart$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureStart", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "fedd719e-f9d6-45ca-a572-aabae7347d05");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureStart");
callContext = controller.callContext(callContext);
var prepareElementsJSResult = new OS.DataTypes.VariableHolder();
if((!((model.variables.currentPositionVar >= model.variables.maxElementsVar)))) {
prepareElementsJSResult.value = OS.Logger.startActiveSpan("PrepareElements", function (span) {
if(span) {
span.setAttribute("code.function", "PrepareElements");
span.setAttribute("outsystems.function.key", "7cf8b400-f9b8-4b2e-9279-5d93ef58c917");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Interaction_StackedCards_mvc_controller_GestureStart_PrepareElementsJS, "PrepareElements", "GestureStart", {
MaxElements: OS.DataConversion.JSNodeParamConverter.to(model.variables.maxElementsVar, OS.DataTypes.DataTypes.Integer),
RightObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.rightObjVar, OS.DataTypes.DataTypes.Object),
CurrentPosition: OS.DataConversion.JSNodeParamConverter.to(model.variables.currentPositionVar, OS.DataTypes.DataTypes.Integer),
ListElNodesObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.listElNodesObjVar, OS.DataTypes.DataTypes.Object),
LeftObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.leftObjVar, OS.DataTypes.DataTypes.Object),
TopObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.topObjVar, OS.DataTypes.DataTypes.Object),
UseOverlays: OS.DataConversion.JSNodeParamConverter.to(model.variables.useOverlaysIn, OS.DataTypes.DataTypes.Boolean),
GetElementHeight: OS.DataConversion.JSNodeParamConverter.to(OS.DataTypes.Decimal.defaultValue, OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureStart$prepareElementsJSResult"))();
jsNodeResult.getElementHeightOut = OS.DataConversion.JSNodeParamConverter.from($parameters.GetElementHeight, OS.DataTypes.DataTypes.Decimal);
return jsNodeResult;
}, {
SetZindex: controller.clientActionProxies.setZindex$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ElementHeight = PrepareElements.GetElementHeight
model.variables.elementHeightVar = prepareElementsJSResult.value.getElementHeightOut;
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


currentElement$Action(swipedEventDirectionIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CurrentElement__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CurrentElement");
span.setAttribute("outsystems.function.key", "09285ada-83ed-4d01-9e34-c5442000bd37");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._currentElement$Action, callContext, swipedEventDirectionIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onActionTop$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnActionTop__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionTop");
span.setAttribute("outsystems.function.key", "0b9c7269-7c09-4001-93e0-8abe95fcaa92");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onActionTop$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

resetOverlayLeft$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ResetOverlayLeft__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayLeft");
span.setAttribute("outsystems.function.key", "17303808-79cb-4930-9745-6b7cea178f18");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._resetOverlayLeft$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setZindex$Action(zindexIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetZindex__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetZindex");
span.setAttribute("outsystems.function.key", "27a69323-91a9-4677-9bc3-cd5aa380e0fd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setZindex$Action, callContext, zindexIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeNoTransition$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RemoveNoTransition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "28aaa088-267c-4403-bad7-e3fee2988a81");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeNoTransition$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onListRemoveUpdate$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnListRemoveUpdate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnListRemoveUpdate");
span.setAttribute("outsystems.function.key", "3823664a-cb2f-475f-8ca3-4a5368903b77");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onListRemoveUpdate$Action, callContext);
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
span.setAttribute("outsystems.function.key", "3dd87b39-a5e3-4aa4-a1eb-d1259e8f1e6e");
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

updateLastActive_A11S$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateLastActive_A11S__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateLastActive_A11S");
span.setAttribute("outsystems.function.key", "4345b987-165b-44ec-9a22-541f35c5e6e0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateLastActive_A11S$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

transformUi$Action(moveXIn, moveYIn, opacityIn, elementObjIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TransformUi__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TransformUi");
span.setAttribute("outsystems.function.key", "4eb5e242-7828-4237-bf94-be2dfa3b47f7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._transformUi$Action, callContext, moveXIn, moveYIn, opacityIn, elementObjIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onSwipeTop$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSwipeTop__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeTop");
span.setAttribute("outsystems.function.key", "632d88bc-172b-490b-98a2-a70cfe2117ed");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSwipeTop$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "6ba8b182-7335-4f6e-8c49-d3a029b49d56");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._gestureEnd$Action, callContext, offsetXIn, offsetYIn, timeTakenIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

resetOverlays$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ResetOverlays__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlays");
span.setAttribute("outsystems.function.key", "76ac2c97-cedc-4dbf-a84e-b81e569f7e1f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._resetOverlays$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onSwipeLeft$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSwipeLeft__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeLeft");
span.setAttribute("outsystems.function.key", "82816fe7-2c38-4a92-9280-63d642c3647c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSwipeLeft$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSwipeRight$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnSwipeRight__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSwipeRight");
span.setAttribute("outsystems.function.key", "9278664c-15e4-47c0-aad1-feb5d30ff63a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSwipeRight$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onActionLeft$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnActionLeft__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionLeft");
span.setAttribute("outsystems.function.key", "9a9cb240-29ce-4745-ab3e-b92026928fc1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onActionLeft$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setActiveHidden$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetActiveHidden__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetActiveHidden");
span.setAttribute("outsystems.function.key", "b254e538-ff8e-43a7-8a8b-a3f2ace460a8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setActiveHidden$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

resetOverlayRight$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ResetOverlayRight__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetOverlayRight");
span.setAttribute("outsystems.function.key", "b634745d-d238-4165-9c98-47ce046dd48e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._resetOverlayRight$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureMove$Action(offsetXIn, offsetYIn, evtIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "cb74a1f0-97d1-4315-a158-9315584cb18d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureMove$Action, callContext, offsetXIn, offsetYIn, evtIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

init$Action(listElNodesIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "d2ad269e-2535-42c6-860f-4189da7963cf");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._init$Action, callContext, listElNodesIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

updateUi$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateUi__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUi");
span.setAttribute("outsystems.function.key", "e1290daf-9eb5-47e5-b1c9-6e81f7a13469");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateUi$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

backToMiddle$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("BackToMiddle__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "BackToMiddle");
span.setAttribute("outsystems.function.key", "ecd4830d-2b80-4cb6-8ca9-a6e4331d90d5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._backToMiddle$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onActionRight$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnActionRight__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnActionRight");
span.setAttribute("outsystems.function.key", "ee1ba588-1d46-4b3a-b246-9e012bc584f9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onActionRight$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

countElements$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("CountElements__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CountElements");
span.setAttribute("outsystems.function.key", "f5b471f0-e468-4a5f-9b29-20aa572bd746");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._countElements$Action, callContext);
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
span.setAttribute("outsystems.function.key", "fedd719e-f9d6-45ca-a572-aabae7347d05");
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

get onLeftSwipe$Action() {if(!(this.hasOwnProperty("_onLeftSwipe$Action"))) {
this._onLeftSwipe$Action = function () {
return Promise.resolve();
};
}

return this._onLeftSwipe$Action;
}set onLeftSwipe$Action(value) {this._onLeftSwipe$Action = value;
}

get onTopSwipe$Action() {if(!(this.hasOwnProperty("_onTopSwipe$Action"))) {
this._onTopSwipe$Action = function () {
return Promise.resolve();
};
}

return this._onTopSwipe$Action;
}set onTopSwipe$Action(value) {this._onTopSwipe$Action = value;
}

get onRightSwipe$Action() {if(!(this.hasOwnProperty("_onRightSwipe$Action"))) {
this._onRightSwipe$Action = function () {
return Promise.resolve();
};
}

return this._onRightSwipe$Action;
}set onRightSwipe$Action(value) {this._onRightSwipe$Action = value;
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
this._onDestroyEventHandler = null;
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = null;
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
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.CurrentElement$vars", [{
name: "SwipedEventDirection",
attrName: "swipedEventDirectionInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ItemNumber",
attrName: "itemNumberVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.CurrentElement$getCurrentElementJSResult", [{
name: "CurElObj",
attrName: "curElObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.SetZindex$vars", [{
name: "Zindex",
attrName: "zindexInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.TransformUi$vars", [{
name: "MoveX",
attrName: "moveXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "MoveY",
attrName: "moveYInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Opacity",
attrName: "opacityInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "ElementObj",
attrName: "elementObjInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureEnd$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
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
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureMove$vars", [{
name: "OffsetX",
attrName: "offsetXInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "OffsetY",
attrName: "offsetYInLocal",
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
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$vars", [{
name: "ListElNodes",
attrName: "listElNodesInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$getObjectsAndActionsJSResult", [{
name: "LeftObj",
attrName: "leftObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "RightObj",
attrName: "rightObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "TopObj",
attrName: "topObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "MessageObj",
attrName: "messageObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "StackedCardsObj",
attrName: "stackedCardsObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.Init$getElNodesWidthJSResult", [{
name: "ListElNodesWidth",
attrName: "listElNodesWidthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "CurElObj",
attrName: "curElObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.CountElements$countElementsJSResult", [{
name: "MaxElements",
attrName: "maxElementsOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Interaction.StackedCards.GestureStart$prepareElementsJSResult", [{
name: "GetElementHeight",
attrName: "getElementHeightOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




