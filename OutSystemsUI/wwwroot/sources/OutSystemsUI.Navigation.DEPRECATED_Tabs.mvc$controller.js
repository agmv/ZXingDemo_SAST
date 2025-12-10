import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_TranslationsResources from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$translationsResources.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureEnd_CalculateMiddleRightJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureEnd.CalculateMiddleRightJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureEnd_CalculateMiddleLeftJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureEnd.CalculateMiddleLeftJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_SetRTLObserver_SetActionAsObjJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.SetRTLObserver.SetActionAsObjJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_UpdateUI_MoveMenuJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.UpdateUI.MoveMenuJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_AddOverlay_AddOverlayJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.AddOverlay.AddOverlayJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_RemoveActive_RemoveActiveJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.RemoveActive.RemoveActiveJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_SetTabs_SetTabsJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.SetTabs.SetTabsJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_OnDestroy_DestroyJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.OnDestroy.DestroyJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_RemoveNoTransitionJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureStart.RemoveNoTransitionJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CheckIfContainsClassJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureStart.CheckIfContainsClassJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CleanAnimationClassesJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureStart.CleanAnimationClassesJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CheckTabsInsidePopupJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureStart.CheckTabsInsidePopupJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_CheckTabsContentJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.TabsOnClick.CheckTabsContentJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_RemoveHeaderClassJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.TabsOnClick.RemoveHeaderClassJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_AddHeaderClassJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.TabsOnClick.AddHeaderClassJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_ChangeTab_changeTabJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.ChangeTab.changeTabJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_RemoveTransition_RemoveNoTransitionJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.RemoveTransition.RemoveNoTransitionJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_RemoveNoTransitionJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureMove.RemoveNoTransitionJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_UpdateUIJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureMove.UpdateUIJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_PreventDefaultWDirectionJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureMove.PreventDefaultWDirectionJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_CalculateIntervalJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.GestureMove.CalculateIntervalJS.js";
import OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.OnReady.InitJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
setTabs$Action: function () {
return controller.executeActionInsideJSNode(controller._setTabs$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetTabs");
},
updateUI$Action: function () {
return controller.executeActionInsideJSNode(controller._updateUI$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateUI");
},
removeTransition$Action: function () {
return controller.executeActionInsideJSNode(controller._removeTransition$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "RemoveTransition");
},
onOrientationChange$Action: function () {
return controller.executeActionInsideJSNode(controller._onOrientationChange$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnOrientationChange");
},
tabsOnClick$Action: function (tabNumberIn) {
tabNumberIn = (tabNumberIn === undefined) ? 0 : tabNumberIn;
return controller.executeActionInsideJSNode(controller._tabsOnClick$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(tabNumberIn, OS.DataTypes.DataTypes.Integer)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "TabsOnClick");
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
get _gestureEnd$Action() {if(!(this.hasOwnProperty("__gestureEnd$Action"))) {
this.__gestureEnd$Action = function (offsetXIn, offsetYIn, timeTakenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureEnd", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "6913774b-cb25-4726-94d1-d46e9d1e3a15");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GestureEnd");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$vars"))());
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.timeTakenInLocal = timeTakenIn;
var calculateMiddleRightJSResult = new OS.DataTypes.VariableHolder();
var calculateMiddleLeftJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isWebAppVar))) {
// Just Clicked?
return OS.Flow.executeSequence(function () {
if((!((vars.value.offsetXInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)) && vars.value.offsetYInLocal.equals(OS.BuiltinFunctions.integerToDecimal(0)))))) {
return OS.Flow.executeSequence(function () {
if((!(model.variables.containsClassVar))) {
var block1 = false;
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
block1 = false;
var block3 = false;
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
block3 = false;
var block4 = false;
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
block4 = false;
return OS.Flow.doWhileAsync(function () {
return false;
}, function () {
if((model.variables.isRTLVar)) {
// Is Left?
if((!((model.variables.dragDirectionHVar === "left")))) {
return OS.Flow.breakAsync();
}

} else {
// Is Left?
if(((model.variables.dragDirectionHVar === "left"))) {
return OS.Flow.breakAsync();
}

}

return OS.Flow.executeSequence(function () {
if(((model.variables.activeTabVar > 0))) {
calculateMiddleRightJSResult.value = OS.Logger.startActiveSpan("CalculateMiddleRight", function (span) {
if(span) {
span.setAttribute("code.function", "CalculateMiddleRight");
span.setAttribute("outsystems.function.key", "8b313935-e819-4929-9788-50070cc6c57a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureEnd_CalculateMiddleRightJS, "CalculateMiddleRight", "GestureEnd", {
TabsWidth: OS.DataConversion.JSNodeParamConverter.to(model.variables.tabsWidthVar, OS.DataTypes.DataTypes.Integer),
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer),
MiddleX: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$calculateMiddleRightJSResult"))();
jsNodeResult.middleXOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MiddleX, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Did it pass half?
return OS.Flow.executeSequence(function () {
if((((OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar)).lt(OS.BuiltinFunctions.integerToDecimal(calculateMiddleRightJSResult.value.middleXOut)) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)) && ((model.variables.dragDirectionVar) !== ("vertical"))))) {
// Is not first tab?
return OS.Flow.executeSequence(function () {
if(((model.variables.activeTabVar > 0))) {
// Execute Action: RemoveActive
controller._removeActive$Action(callContext);
// Stop move and set tab
// IsMoving = False
model.variables.isMovingVar = false;
// ActiveTab = ActiveTab - 1
model.variables.activeTabVar = (model.variables.activeTabVar - 1);
// Execute Action: ChangeTab
controller._changeTab$Action(model.variables.activeTabVar, callContext);
// Trigger Event: OnTabChange
return controller.onTabChange$Action(model.variables.activeTabVar, callContext);
}

});
} else {
// IsMoving = False
model.variables.isMovingVar = false;
}

}).then(function () {
// Execute Action: SetTabs
controller._setTabs$Action(callContext);
// jump to block4
block4 = true;
return OS.Flow.breakAsync();
});
} else {
// jump to block3
block3 = true;
return OS.Flow.breakAsync();
}

});
}).then(function () {
if((block3 || block4)) {
return OS.Flow.breakAsync();
}

}).then(function () {
return OS.Flow.executeSequence(function () {
if(((((model.variables.activeTabVar + 1)) !== (model.variables.tabsNumberVar)))) {
calculateMiddleLeftJSResult.value = OS.Logger.startActiveSpan("CalculateMiddleLeft", function (span) {
if(span) {
span.setAttribute("code.function", "CalculateMiddleLeft");
span.setAttribute("outsystems.function.key", "dde58fa6-e0d2-4bf0-a631-52aad82cc358");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureEnd_CalculateMiddleLeftJS, "CalculateMiddleLeft", "GestureEnd", {
TabsWidth: OS.DataConversion.JSNodeParamConverter.to(model.variables.tabsWidthVar, OS.DataTypes.DataTypes.Integer),
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer),
MiddleX: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$calculateMiddleLeftJSResult"))();
jsNodeResult.middleXOut = OS.DataConversion.JSNodeParamConverter.from($parameters.MiddleX, OS.DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Did it pass half?
return OS.Flow.executeSequence(function () {
if((((OS.BuiltinFunctions.abs(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar)).gt(OS.BuiltinFunctions.integerToDecimal(calculateMiddleLeftJSResult.value.middleXOut)) || OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).div(vars.value.timeTakenInLocal).gt(model.variables.velocityVar)) && ((model.variables.dragDirectionVar) !== ("vertical"))))) {
// Is not last tab?
return OS.Flow.executeSequence(function () {
if(((model.variables.activeTabVar <= model.variables.tabsNumberVar))) {
// Execute Action: RemoveActive2
controller._removeActive$Action(callContext);
// ActiveTab = ActiveTab + 1
model.variables.activeTabVar = (model.variables.activeTabVar + 1);
// IsMoving = False
model.variables.isMovingVar = false;
// Execute Action: ChangeTab2
controller._changeTab$Action(model.variables.activeTabVar, callContext);
// Trigger Event: OnTabChange2
return controller.onTabChange$Action(model.variables.activeTabVar, callContext);
}

});
} else {
// Stop move and set tab
// IsMoving = False
model.variables.isMovingVar = false;
}

}).then(function () {
// Execute Action: SetTabs2
controller._setTabs$Action(callContext);
});
} else {
// jump to block3
block3 = true;
return OS.Flow.breakAsync();
}

});
});
}).then(function () {
if(block3) {
return OS.Flow.breakAsync();
}

}).then(function () {
if((model.variables.isWebAppVar)) {
// jump to block1
block1 = true;
return OS.Flow.breakAsync();
} else {
if((model.variables.isVerticalIn)) {
// jump to block1
block1 = true;
return OS.Flow.breakAsync();
} else {
// Execute Action: AddOverlay
controller._addOverlay$Action(idService.getId("tabs"), callContext);
// jump to block1
block1 = true;
return OS.Flow.breakAsync();
}

}

});
}).then(function () {
if(block1) {
return OS.Flow.breakAsync();
}

}).then(function () {
// IsMoving = False
model.variables.isMovingVar = false;
// Execute Action: RemoveTransition2
controller._removeTransition$Action(callContext);
return OS.Flow.returnAsync();

});
}).then(function () {
// Execute Action: RemoveTransition3
controller._removeTransition$Action(callContext);
return OS.Flow.returnAsync();

});
}

});
}

}).then(function () {
// IsMoving = False
model.variables.isMovingVar = false;
// Execute Action: RemoveTransition
controller._removeTransition$Action(callContext);
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

get _setRTLObserver$Action() {if(!(this.hasOwnProperty("__setRTLObserver$Action"))) {
this.__setRTLObserver$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetRTLObserver", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "7271aa1a-e16a-488a-987c-3e0415f6e65a");
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
span.setAttribute("outsystems.function.key", "9716bfc2-4c5f-443c-a02f-768ab3fe5811");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_SetRTLObserver_SetActionAsObjJS, "SetActionAsObj", "SetRTLObserver", {
Action: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.SetRTLObserver$setActionAsObjJSResult"))();
jsNodeResult.actionOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Action, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
SetTabs: controller.clientActionProxies.setTabs$Action
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

get _updateUI$Action() {if(!(this.hasOwnProperty("__updateUI$Action"))) {
this.__updateUI$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "7b05c837-e197-4040-a26c-fe2f63715c77");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateUI");
callContext = controller.callContext(callContext);
if((model.variables.isMovingVar)) {
OS.Logger.startActiveSpan("MoveMenu", function (span) {
if(span) {
span.setAttribute("code.function", "MoveMenu");
span.setAttribute("outsystems.function.key", "011a6c83-66a6-4699-b0e8-383bbc492558");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_UpdateUI_MoveMenuJS, "MoveMenu", "UpdateUI", {
OffsetX: OS.DataConversion.JSNodeParamConverter.to(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar), OS.DataTypes.DataTypes.Decimal),
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
UpdateUI: controller.clientActionProxies.updateUI$Action
}, {});
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

return this.__updateUI$Action;
}set _updateUI$Action(value) {this.__updateUI$Action = value;
}

get _addOverlay$Action() {if(!(this.hasOwnProperty("__addOverlay$Action"))) {
this.__addOverlay$Action = function (idIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("AddOverlay", function (span) {
if(span) {
span.setAttribute("code.function", "AddOverlay");
span.setAttribute("outsystems.function.key", "7c9ca5ce-2740-4aaa-91bf-7dc3908e1615");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddOverlay");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.AddOverlay$vars"))());
vars.value.idInLocal = idIn;
OS.Logger.startActiveSpan("AddOverlay", function (span) {
if(span) {
span.setAttribute("code.function", "AddOverlay");
span.setAttribute("outsystems.function.key", "1ba12126-783f-491a-8cb6-12068833c7eb");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_AddOverlay_AddOverlayJS, "AddOverlay", "AddOverlay", {
Id: OS.DataConversion.JSNodeParamConverter.to(vars.value.idInLocal, OS.DataTypes.DataTypes.Text),
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer)
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

return this.__addOverlay$Action;
}set _addOverlay$Action(value) {this.__addOverlay$Action = value;
}

get _removeActive$Action() {if(!(this.hasOwnProperty("__removeActive$Action"))) {
this.__removeActive$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RemoveActive", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveActive");
span.setAttribute("outsystems.function.key", "80733716-484d-4f19-8a18-51805f5b9924");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveActive");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveActive", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveActive");
span.setAttribute("outsystems.function.key", "6ba6bdec-caf3-40eb-a394-cfa752ec8280");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_RemoveActive_RemoveActiveJS, "RemoveActive", "RemoveActive", {
activeTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer),
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
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

return this.__removeActive$Action;
}set _removeActive$Action(value) {this.__removeActive$Action = value;
}

get _onOrientationChange$Action() {if(!(this.hasOwnProperty("__onOrientationChange$Action"))) {
this.__onOrientationChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnOrientationChange", function (span) {
if(span) {
span.setAttribute("code.function", "OnOrientationChange");
span.setAttribute("outsystems.function.key", "8a5757aa-7dca-4208-9046-98ca5cb72f4a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnOrientationChange");
callContext = controller.callContext(callContext);
// Execute Action: SetTabs
controller._setTabs$Action(callContext);
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

get _setTabs$Action() {if(!(this.hasOwnProperty("__setTabs$Action"))) {
this.__setTabs$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetTabs", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabs");
span.setAttribute("outsystems.function.key", "8b9ed755-89ca-43de-933e-774560758946");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetTabs");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("SetTabs", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabs");
span.setAttribute("outsystems.function.key", "85a1f440-df6b-431d-b866-52ed92ada6cd");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_SetTabs_SetTabsJS, "SetTabs", "SetTabs", {
StartingTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.startingTabIn, OS.DataTypes.DataTypes.Integer),
IsVertical: OS.DataConversion.JSNodeParamConverter.to(model.variables.isVerticalIn, OS.DataTypes.DataTypes.Boolean),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(model.variables.isRTLVar, OS.DataTypes.DataTypes.Boolean),
id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text),
IsFirstTimeLoad: OS.DataConversion.JSNodeParamConverter.to(model.variables.isFirstTimeLoadVar, OS.DataTypes.DataTypes.Boolean),
IsWebApp: OS.DataConversion.JSNodeParamConverter.to(model.variables.isWebAppVar, OS.DataTypes.DataTypes.Boolean),
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {
RemoveTransition: controller.clientActionProxies.removeTransition$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((model.variables.isFirstTimeLoadVar)) {
// IsFirstTimeLoad = False
model.variables.isFirstTimeLoadVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__setTabs$Action;
}set _setTabs$Action(value) {this.__setTabs$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "92c85224-2b2b-4814-ad6a-2a77cecea06a");
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
span.setAttribute("outsystems.function.key", "30c868c4-4fa1-45b0-be45-96863e975c0d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_OnDestroy_DestroyJS, "Destroy", "OnDestroy", null, function ($parameters) {
}, {
OnOrientationChange: controller.clientActionProxies.onOrientationChange$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsFirstTimeLoad = True
model.variables.isFirstTimeLoadVar = true;
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

get _gestureStart$Action() {if(!(this.hasOwnProperty("__gestureStart$Action"))) {
this.__gestureStart$Action = function (xIn, yIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureStart", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "a1e27a1f-1412-4743-8be7-36ce99fc61a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureStart");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
var checkIfContainsClassJSResult = new OS.DataTypes.VariableHolder();
var cleanAnimationClassesJSResult = new OS.DataTypes.VariableHolder();
var checkTabsInsidePopupJSResult = new OS.DataTypes.VariableHolder();
checkTabsInsidePopupJSResult.value = OS.Logger.startActiveSpan("CheckTabsInsidePopup", function (span) {
if(span) {
span.setAttribute("code.function", "CheckTabsInsidePopup");
span.setAttribute("outsystems.function.key", "ce46c30c-bf43-42ca-b030-f46881ee392c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CheckTabsInsidePopupJS, "CheckTabsInsidePopup", "GestureStart", {
TabsInsidePopup: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$checkTabsInsidePopupJSResult"))();
jsNodeResult.tabsInsidePopupOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TabsInsidePopup, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((checkTabsInsidePopupJSResult.value.tabsInsidePopupOut)) {
// IsWebApp = CheckTabsInsidePopup.TabsInsidePopup
model.variables.isWebAppVar = checkTabsInsidePopupJSResult.value.tabsInsidePopupOut;
} else {
cleanAnimationClassesJSResult.value = OS.Logger.startActiveSpan("CleanAnimationClasses", function (span) {
if(span) {
span.setAttribute("code.function", "CleanAnimationClasses");
span.setAttribute("outsystems.function.key", "934ddc36-13ea-4371-947b-7b413a8133a5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CleanAnimationClassesJS, "CleanAnimationClasses", "GestureStart", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text),
Width: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
TabsNumber: OS.DataConversion.JSNodeParamConverter.to(0, OS.DataTypes.DataTypes.Integer),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$cleanAnimationClassesJSResult"))();
jsNodeResult.widthOut = OS.DataConversion.JSNodeParamConverter.from($parameters.Width, OS.DataTypes.DataTypes.Integer);
jsNodeResult.tabsNumberOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TabsNumber, OS.DataTypes.DataTypes.Integer);
jsNodeResult.isRTLOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsRTL, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
checkIfContainsClassJSResult.value = OS.Logger.startActiveSpan("CheckIfContainsClass", function (span) {
if(span) {
span.setAttribute("code.function", "CheckIfContainsClass");
span.setAttribute("outsystems.function.key", "7ab0b79f-417d-4e6f-8d5c-6d39e16f375d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_CheckIfContainsClassJS, "CheckIfContainsClass", "GestureStart", {
TabId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text),
ContainsClass: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$checkIfContainsClassJSResult"))();
jsNodeResult.containsClassOut = OS.DataConversion.JSNodeParamConverter.from($parameters.ContainsClass, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsMoving = True
model.variables.isMovingVar = true;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// TabsWidth = CleanAnimationClasses.Width
model.variables.tabsWidthVar = cleanAnimationClassesJSResult.value.widthOut;
// DragDirection = ""
model.variables.dragDirectionVar = "";
// TabsNumber = CleanAnimationClasses.TabsNumber
model.variables.tabsNumberVar = cleanAnimationClassesJSResult.value.tabsNumberOut;
// DragDirectionH = ""
model.variables.dragDirectionHVar = "";
// IsRTL = CleanAnimationClasses.IsRTL
model.variables.isRTLVar = cleanAnimationClassesJSResult.value.isRTLOut;
// MoveX = If
model.variables.moveXVar = ((model.variables.isRTLVar) ? ((model.variables.activeTabVar * model.variables.tabsWidthVar)) : (((-model.variables.activeTabVar) * model.variables.tabsWidthVar)));
// FirstTime = True
model.variables.firstTimeVar = true;
// ContainsClass = CheckIfContainsClass.ContainsClass
model.variables.containsClassVar = checkIfContainsClassJSResult.value.containsClassOut;
if((model.variables.containsClassVar)) {
OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "6a8adc30-062a-415a-8185-cf6bd5444ca2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureStart_RemoveNoTransitionJS, "RemoveNoTransition", "GestureStart", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
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

get _tabsOnClick$Action() {if(!(this.hasOwnProperty("__tabsOnClick$Action"))) {
this.__tabsOnClick$Action = function (tabNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("TabsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnClick");
span.setAttribute("outsystems.function.key", "d580e120-7fdb-41b7-87f3-5b1ce9cd2cf2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("TabsOnClick");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.TabsOnClick$vars"))());
vars.value.tabNumberInLocal = tabNumberIn;
var checkTabsContentJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
checkTabsContentJSResult.value = OS.Logger.startActiveSpan("CheckTabsContent", function (span) {
if(span) {
span.setAttribute("code.function", "CheckTabsContent");
span.setAttribute("outsystems.function.key", "448965c0-24c9-4308-a0fc-85058ce7b07c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_CheckTabsContentJS, "CheckTabsContent", "TabsOnClick", {
TabNumber: OS.DataConversion.JSNodeParamConverter.to(vars.value.tabNumberInLocal, OS.DataTypes.DataTypes.Integer),
TabsId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text),
HasContentTab: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
TabsInsidePopup: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.TabsOnClick$checkTabsContentJSResult"))();
jsNodeResult.hasContentTabOut = OS.DataConversion.JSNodeParamConverter.from($parameters.HasContentTab, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.tabsInsidePopupOut = OS.DataConversion.JSNodeParamConverter.from($parameters.TabsInsidePopup, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
if((checkTabsContentJSResult.value.tabsInsidePopupOut)) {
// IsWebApp = CheckTabsContent.TabsInsidePopup
model.variables.isWebAppVar = checkTabsContentJSResult.value.tabsInsidePopupOut;
}

return OS.Flow.executeSequence(function () {
if((checkTabsContentJSResult.value.hasContentTabOut)) {
if((((model.variables.activeTabVar) !== (vars.value.tabNumberInLocal)))) {
// Execute Action: RemoveActive
controller._removeActive$Action(callContext);
}

// ActiveTab = TabNumber
model.variables.activeTabVar = vars.value.tabNumberInLocal;
// Execute Action: ChangeTab
controller._changeTab$Action(vars.value.tabNumberInLocal, callContext);
// Execute Action: SetTabs
controller._setTabs$Action(callContext);
if((!(model.variables.isWebAppVar))) {
if((!(model.variables.isVerticalIn))) {
// Execute Action: AddOverlay
controller._addOverlay$Action(idService.getId("tabs"), callContext);
}

}

// Trigger Event: OnTabChange
return controller.onTabChange$Action(model.variables.activeTabVar, callContext);
} else {
OS.Logger.startActiveSpan("RemoveHeaderClass", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveHeaderClass");
span.setAttribute("outsystems.function.key", "6d08ff80-9fb7-48ff-8246-d647eb98e82c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_RemoveHeaderClassJS, "RemoveHeaderClass", "TabsOnClick", {
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer),
TabsId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// ActiveTab = TabNumber
model.variables.activeTabVar = vars.value.tabNumberInLocal;
OS.Logger.startActiveSpan("AddHeaderClass", function (span) {
if(span) {
span.setAttribute("code.function", "AddHeaderClass");
span.setAttribute("outsystems.function.key", "f1708554-3812-4dff-82bb-c7989717c4dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_TabsOnClick_AddHeaderClassJS, "AddHeaderClass", "TabsOnClick", {
TabsId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text),
TabNumber: OS.DataConversion.JSNodeParamConverter.to(vars.value.tabNumberInLocal, OS.DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Trigger Event: OnTabChange2
return controller.onTabChange$Action(model.variables.activeTabVar, callContext);
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

return this.__tabsOnClick$Action;
}set _tabsOnClick$Action(value) {this.__tabsOnClick$Action = value;
}

get _changeTab$Action() {if(!(this.hasOwnProperty("__changeTab$Action"))) {
this.__changeTab$Action = function (tabNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ChangeTab", function (span) {
if(span) {
span.setAttribute("code.function", "ChangeTab");
span.setAttribute("outsystems.function.key", "e88ddbeb-8a52-4105-9965-2a32b838b09e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ChangeTab");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.ChangeTab$vars"))());
vars.value.tabNumberInLocal = tabNumberIn;
OS.Logger.startActiveSpan("changeTab", function (span) {
if(span) {
span.setAttribute("code.function", "changeTab");
span.setAttribute("outsystems.function.key", "2ad82a1a-6b5a-46b3-9888-3cf84675a3f7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_ChangeTab_changeTabJS, "changeTab", "ChangeTab", {
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(vars.value.tabNumberInLocal, OS.DataTypes.DataTypes.Integer),
id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
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

return this.__changeTab$Action;
}set _changeTab$Action(value) {this.__changeTab$Action = value;
}

get _removeTransition$Action() {if(!(this.hasOwnProperty("__removeTransition$Action"))) {
this.__removeTransition$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("RemoveTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveTransition");
span.setAttribute("outsystems.function.key", "e927596a-1214-47c3-8eea-bb7b5f6bd9e4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveTransition");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "d380d843-1f6c-43de-97b2-8ff230aff18c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_RemoveTransition_RemoveNoTransitionJS, "RemoveNoTransition", "RemoveTransition", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
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

return this.__removeTransition$Action;
}set _removeTransition$Action(value) {this.__removeTransition$Action = value;
}

get _gestureMove$Action() {if(!(this.hasOwnProperty("__gestureMove$Action"))) {
this.__gestureMove$Action = function (xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GestureMove", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "f51f626e-d448-418d-906a-b1c95c97a00b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GestureMove");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureMove$vars"))());
vars.value.xInLocal = xIn;
vars.value.yInLocal = yIn;
vars.value.offsetXInLocal = offsetXIn;
vars.value.offsetYInLocal = offsetYIn;
vars.value.evtInLocal = evtIn;
var calculateIntervalJSResult = new OS.DataTypes.VariableHolder();
if((!(model.variables.isWebAppVar))) {
if((model.variables.containsClassVar)) {
// IsMoving = False
model.variables.isMovingVar = false;
// ContainsClass = True
model.variables.containsClassVar = true;
} else {
// No direction set?
if(((model.variables.dragDirectionVar === ""))) {
// Set drag direction
// DragDirection = If
model.variables.dragDirectionVar = ((OS.BuiltinFunctions.abs(vars.value.offsetXInLocal).gte(OS.BuiltinFunctions.abs(vars.value.offsetYInLocal))) ? ("horizontal") : ("vertical"));
OS.Logger.startActiveSpan("UpdateUI", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "32580d45-1c32-4573-89e9-d2bc4369ff92");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_UpdateUIJS, "UpdateUI", "GestureMove", null, function ($parameters) {
}, {
UpdateUI: controller.clientActionProxies.updateUI$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Is vertical?
if(((model.variables.dragDirectionVar === "vertical"))) {
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// IsMoving = False
model.variables.isMovingVar = false;
OS.Logger.startActiveSpan("RemoveNoTransition", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveNoTransition");
span.setAttribute("outsystems.function.key", "12104059-cd7e-47f7-866c-c22866a72ba9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_RemoveNoTransitionJS, "RemoveNoTransition", "GestureMove", {
Id: OS.DataConversion.JSNodeParamConverter.to(idService.getId("tabs"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
var block1 = false;
do {
block1 = false;
var block2 = false;
do {
block2 = false;
do {
OS.Logger.startActiveSpan("PreventDefaultWDirection", function (span) {
if(span) {
span.setAttribute("code.function", "PreventDefaultWDirection");
span.setAttribute("outsystems.function.key", "4f0665ce-892e-483c-8e96-b067e8a9067a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_PreventDefaultWDirectionJS, "PreventDefaultWDirection", "GestureMove", {
Evt: OS.DataConversion.JSNodeParamConverter.to(vars.value.evtInLocal, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set drag direction
// DragDirectionH = If
model.variables.dragDirectionHVar = ((vars.value.offsetXInLocal.gt(OS.BuiltinFunctions.integerToDecimal(0))) ? ("right") : ("left"));
if((model.variables.isRTLVar)) {
// TabsLimitationLeft = MoveX + X - LastX > 0
vars.value.tabsLimitationLeftVar = OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal(0));
// TabsLimitationRight = MoveX + X - LastX > ActiveTab + 1 * TabsWidth
vars.value.tabsLimitationRightVar = OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal(((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar)));
// IsBLimitsLeft = MoveX + X - LastX > ActiveTab - 1 * TabsWidth and MoveX + X - LastX < ActiveTab + 1 * TabsWidth
vars.value.isBLimitsLeftVar = (OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal(((model.variables.activeTabVar - 1) * model.variables.tabsWidthVar))) && OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar))));
// IsBLimitsRight = MoveX + X - LastX > 0 and MoveX + X - LastX < ActiveTab + 1 * TabsWidth
vars.value.isBLimitsRightVar = (OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal(0)) && OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar))));
// isLeft?
if((!((model.variables.dragDirectionHVar === "left")))) {
break;
}

} else {
// TabsLimitationLeft = MoveX + X - LastX < 0
vars.value.tabsLimitationLeftVar = OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(0));
// TabsLimitationRight = MoveX + X - LastX < -ActiveTab + 1 * TabsWidth
vars.value.tabsLimitationRightVar = OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal((-((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar))));
// IsBLimitsLeft = MoveX + X - LastX < -ActiveTab - 1 * TabsWidth and MoveX + X - LastX > -ActiveTab + 1 * TabsWidth
vars.value.isBLimitsLeftVar = (OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal((-((model.variables.activeTabVar - 1) * model.variables.tabsWidthVar)))) && OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal((-((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar)))));
// IsBLimitsRight = MoveX + X - LastX < 0 and MoveX + X - LastX > -ActiveTab + 1 * TabsWidth
vars.value.isBLimitsRightVar = (OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).lt(OS.BuiltinFunctions.integerToDecimal(0)) && OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(vars.value.xInLocal.minus(model.variables.lastXVar)).gt(OS.BuiltinFunctions.integerToDecimal((-((model.variables.activeTabVar + 1) * model.variables.tabsWidthVar)))));
// is Left?
if(((model.variables.dragDirectionHVar === "left"))) {
break;
}

}

// Tabs limitations
if(((((model.variables.activeTabVar) !== (0)) || vars.value.tabsLimitationLeftVar))) {
// Is Between limits?
if((vars.value.isBLimitsLeftVar)) {
// jump to block2
block2 = true;
break;
} else {
// jump to block1
block1 = true;
break;
}

} else {
// jump to block1
block1 = true;
break;
}

} while(false)
;
if((block1 || block2)) {
break;
}

// Tabs limitations
if((((((model.variables.activeTabVar + 1)) !== (model.variables.tabsNumberVar)) || vars.value.tabsLimitationRightVar))) {
// Is Between limits?
if((!(vars.value.isBLimitsRightVar))) {
// jump to block1
block1 = true;
break;
}

} else {
// jump to block1
block1 = true;
break;
}

} while(false)
;
if(block1) {
break;
}

calculateIntervalJSResult.value = OS.Logger.startActiveSpan("CalculateInterval", function (span) {
if(span) {
span.setAttribute("code.function", "CalculateInterval");
span.setAttribute("outsystems.function.key", "e06adf2e-b27a-42fa-b0ca-dd1a40c3bc9f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_GestureMove_CalculateIntervalJS, "CalculateInterval", "GestureMove", {
LastX: OS.DataConversion.JSNodeParamConverter.to(model.variables.lastXVar, OS.DataTypes.DataTypes.Decimal),
TabsNumber: OS.DataConversion.JSNodeParamConverter.to(model.variables.tabsNumberVar, OS.DataTypes.DataTypes.Integer),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(model.variables.isRTLVar, OS.DataTypes.DataTypes.Boolean),
TabsWidth: OS.DataConversion.JSNodeParamConverter.to(model.variables.tabsWidthVar, OS.DataTypes.DataTypes.Integer),
X: OS.DataConversion.JSNodeParamConverter.to(vars.value.xInLocal, OS.DataTypes.DataTypes.Decimal),
FirstTime: OS.DataConversion.JSNodeParamConverter.to(model.variables.firstTimeVar, OS.DataTypes.DataTypes.Boolean),
interval: OS.DataConversion.JSNodeParamConverter.to(OS.DataTypes.Decimal.defaultValue, OS.DataTypes.DataTypes.Decimal)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureMove$calculateIntervalJSResult"))();
jsNodeResult.intervalOut = OS.DataConversion.JSNodeParamConverter.from($parameters.interval, OS.DataTypes.DataTypes.Decimal);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Update menu X axis offset
// MoveX = MoveX + CalculateInterval.interval
model.variables.moveXVar = OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(OS.BuiltinFunctions.integerToDecimal(model.variables.moveXVar).plus(calculateIntervalJSResult.value.intervalOut)));
} while(false)
;
// Update Last Positions
// LastY = Y
model.variables.lastYVar = vars.value.yInLocal;
// LastX = X
model.variables.lastXVar = vars.value.xInLocal;
// FirstTime = False
model.variables.firstTimeVar = false;
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

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (idIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f77f5e1e-721f-44fe-8448-ed2e8cb22f7c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.OnReady$vars"))());
vars.value.idInLocal = idIn;
var initJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// IsWebApp = IsWebApp()
model.variables.isWebAppVar = OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut;
// IsLayoutNative = IsLayoutNative()
model.variables.isLayoutNativeVar = OutSystemsUIController.default.isLayoutNative$Action(callContext).isNativeOut;
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "d5e06c9a-dd84-4238-ab89-c0e1e46de6d6");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Navigation_DEPRECATED_Tabs_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
IsWebApp: OS.DataConversion.JSNodeParamConverter.to(model.variables.isWebAppVar, OS.DataTypes.DataTypes.Boolean),
ActiveTab: OS.DataConversion.JSNodeParamConverter.to(model.variables.activeTabVar, OS.DataTypes.DataTypes.Integer),
Id: OS.DataConversion.JSNodeParamConverter.to(vars.value.idInLocal, OS.DataTypes.DataTypes.Text),
IsRTL: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.OnReady$initJSResult"))();
jsNodeResult.isRTLOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsRTL, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {
OnOrientationChange: controller.clientActionProxies.onOrientationChange$Action,
TabsOnClick: controller.clientActionProxies.tabsOnClick$Action,
SetTabs: controller.clientActionProxies.setTabs$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: SetRTLObserver
return controller._setRTLObserver$Action(callContext).then(function () {
// IsRTL = Init.IsRTL
model.variables.isRTLVar = initJSResult.value.isRTLOut;
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

get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ff913d27-e76b-4289-9f7f-7ad227d8ea1f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// ActiveTab = StartingTab
model.variables.activeTabVar = model.variables.startingTabIn;
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


gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureEnd");
span.setAttribute("outsystems.function.key", "6913774b-cb25-4726-94d1-d46e9d1e3a15");
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

setRTLObserver$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetRTLObserver__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetRTLObserver");
span.setAttribute("outsystems.function.key", "7271aa1a-e16a-488a-987c-3e0415f6e65a");
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

updateUI$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("UpdateUI__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUI");
span.setAttribute("outsystems.function.key", "7b05c837-e197-4040-a26c-fe2f63715c77");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateUI$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

addOverlay$Action(idIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("AddOverlay__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddOverlay");
span.setAttribute("outsystems.function.key", "7c9ca5ce-2740-4aaa-91bf-7dc3908e1615");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._addOverlay$Action, callContext, idIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeActive$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RemoveActive__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveActive");
span.setAttribute("outsystems.function.key", "80733716-484d-4f19-8a18-51805f5b9924");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeActive$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8a5757aa-7dca-4208-9046-98ca5cb72f4a");
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

setTabs$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetTabs__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetTabs");
span.setAttribute("outsystems.function.key", "8b9ed755-89ca-43de-933e-774560758946");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setTabs$Action, callContext);
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
span.setAttribute("outsystems.function.key", "92c85224-2b2b-4814-ad6a-2a77cecea06a");
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

gestureStart$Action(xIn, yIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureStart");
span.setAttribute("outsystems.function.key", "a1e27a1f-1412-4743-8be7-36ce99fc61a4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureStart$Action, callContext, xIn, yIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

tabsOnClick$Action(tabNumberIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("TabsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnClick");
span.setAttribute("outsystems.function.key", "d580e120-7fdb-41b7-87f3-5b1ce9cd2cf2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._tabsOnClick$Action, callContext, tabNumberIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

changeTab$Action(tabNumberIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ChangeTab__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ChangeTab");
span.setAttribute("outsystems.function.key", "e88ddbeb-8a52-4105-9965-2a32b838b09e");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._changeTab$Action, callContext, tabNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeTransition$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("RemoveTransition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveTransition");
span.setAttribute("outsystems.function.key", "e927596a-1214-47c3-8eea-bb7b5f6bd9e4");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeTransition$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

gestureMove$Action(xIn, yIn, offsetXIn, offsetYIn, evtIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GestureMove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GestureMove");
span.setAttribute("outsystems.function.key", "f51f626e-d448-418d-906a-b1c95c97a00b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._gestureMove$Action, callContext, xIn, yIn, offsetXIn, offsetYIn, evtIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(idIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "f77f5e1e-721f-44fe-8448-ed2e8cb22f7c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext, idIn);
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
span.setAttribute("outsystems.function.key", "ff913d27-e76b-4289-9f7f-7ad227d8ea1f");
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

get onTabChange$Action() {if(!(this.hasOwnProperty("_onTabChange$Action"))) {
this._onTabChange$Action = function () {
return Promise.resolve();
};
}

return this._onTabChange$Action;
}set onTabChange$Action(value) {this._onTabChange$Action = value;
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

return controller.onReady$Action(idService.getId("tabs"), callContext);

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

return controller.setTabs$Action(callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$vars", [{
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
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$calculateMiddleRightJSResult", [{
name: "MiddleX",
attrName: "middleXOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureEnd$calculateMiddleLeftJSResult", [{
name: "MiddleX",
attrName: "middleXOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.SetRTLObserver$setActionAsObjJSResult", [{
name: "Action",
attrName: "actionOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.AddOverlay$vars", [{
name: "Id",
attrName: "idInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$checkIfContainsClassJSResult", [{
name: "ContainsClass",
attrName: "containsClassOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$cleanAnimationClassesJSResult", [{
name: "Width",
attrName: "widthOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "TabsNumber",
attrName: "tabsNumberOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IsRTL",
attrName: "isRTLOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureStart$checkTabsInsidePopupJSResult", [{
name: "TabsInsidePopup",
attrName: "tabsInsidePopupOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.TabsOnClick$vars", [{
name: "TabNumber",
attrName: "tabNumberInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.TabsOnClick$checkTabsContentJSResult", [{
name: "HasContentTab",
attrName: "hasContentTabOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "TabsInsidePopup",
attrName: "tabsInsidePopupOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.ChangeTab$vars", [{
name: "TabNumber",
attrName: "tabNumberInLocal",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureMove$vars", [{
name: "X",
attrName: "xInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
name: "Y",
attrName: "yInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}, {
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
}, {
name: "TabsLimitationLeft",
attrName: "tabsLimitationLeftVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "TabsLimitationRight",
attrName: "tabsLimitationRightVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsBLimitsLeft",
attrName: "isBLimitsLeftVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsBLimitsRight",
attrName: "isBLimitsRightVar",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.GestureMove$calculateIntervalJSResult", [{
name: "interval",
attrName: "intervalOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS.DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.OnReady$vars", [{
name: "Id",
attrName: "idInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Navigation.DEPRECATED_Tabs.OnReady$initJSResult", [{
name: "IsRTL",
attrName: "isRTLOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




