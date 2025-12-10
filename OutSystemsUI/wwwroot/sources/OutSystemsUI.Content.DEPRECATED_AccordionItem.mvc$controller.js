import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_TranslationsResources from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$translationsResources.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_ToggleClassJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.OnClick.ToggleClassJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_UpdateAttributeJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.OnClick.UpdateAttributeJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_CloseAllJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.OnClick.CloseAllJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_Collapse_CollapseJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.Collapse.CollapseJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.OnReady.InitJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnReady_SetGlobalActionsJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.OnReady.SetGlobalActionsJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_SetAriaAttributes_SetAttributesJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.SetAriaAttributes.SetAttributesJS.js";
import OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_Expand_ExpandJS from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.Expand.ExpandJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
setAriaAttributes$Action: function (isExpandIn, elemIdIn) {
isExpandIn = (isExpandIn === undefined) ? false : isExpandIn;
elemIdIn = (elemIdIn === undefined) ? "" : elemIdIn;
return controller.executeActionInsideJSNode(controller._setAriaAttributes$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(isExpandIn, OS.DataTypes.DataTypes.Boolean), OS.DataConversion.JSNodeParamConverter.from(elemIdIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SetAriaAttributes");
},
expand$Action: function (isKeypressIn) {
isKeypressIn = (isKeypressIn === undefined) ? false : isKeypressIn;
return controller.executeActionInsideJSNode(controller._expand$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(isKeypressIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Expand");
},
collapse$Action: function (isKeypressIn) {
isKeypressIn = (isKeypressIn === undefined) ? false : isKeypressIn;
return controller.executeActionInsideJSNode(controller._collapse$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(isKeypressIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Collapse");
},
onClick$Action: function (elemIdIn, isKeypressIn) {
elemIdIn = (elemIdIn === undefined) ? "" : elemIdIn;
isKeypressIn = (isKeypressIn === undefined) ? false : isKeypressIn;
return controller.executeActionInsideJSNode(controller._onClick$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(elemIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(isKeypressIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnClick");
},
onUpdate$Action: function (multipleItemsIn) {
multipleItemsIn = (multipleItemsIn === undefined) ? false : multipleItemsIn;
return controller.executeActionInsideJSNode(controller._onUpdate$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(multipleItemsIn, OS.DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnUpdate");
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
get _onClick$Action() {if(!(this.hasOwnProperty("__onClick$Action"))) {
this.__onClick$Action = function (elemIdIn, isKeypressIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "3589177e-d0d9-4e85-99ff-0e683d7b90e1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClick");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnClick$vars"))());
vars.value.elemIdInLocal = elemIdIn;
vars.value.isKeypressInLocal = isKeypressIn;
var toggleClassJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isDisabledIn))) {
return OS.Flow.executeSequence(function () {
if((model.variables.hasContentVar)) {
if((model.variables.hasWrapperVar)) {
if((!(model.variables.isMultipleItemsVar))) {
OS.Logger.startActiveSpan("CloseAll", function (span) {
if(span) {
span.setAttribute("code.function", "CloseAll");
span.setAttribute("outsystems.function.key", "b80bc200-06ea-47e2-bfef-dccc4134a69b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_CloseAllJS, "CloseAll", "OnClick", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(vars.value.elemIdInLocal, OS.DataTypes.DataTypes.Text),
AccordionObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.accordionObjVar, OS.DataTypes.DataTypes.Object)
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

if((model.variables.isExpandedIn)) {
// Execute Action: Collapse
controller._collapse$Action(vars.value.isKeypressInLocal, callContext);
} else {
// Execute Action: Expand
controller._expand$Action(vars.value.isKeypressInLocal, callContext);
}

// Trigger Event: OnToggle
return controller.onToggle$Action(model.variables.isExpandedIn, callContext).then(function () {
OS.Logger.startActiveSpan("UpdateAttribute", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateAttribute");
span.setAttribute("outsystems.function.key", "9d159cef-381f-41c5-b2dd-ab6b6be4118d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_UpdateAttributeJS, "UpdateAttribute", "OnClick", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(vars.value.elemIdInLocal, OS.DataTypes.DataTypes.Text),
IsExpanded: OS.DataConversion.JSNodeParamConverter.to(model.variables.isExpandedIn, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
});
} else {
toggleClassJSResult.value = OS.Logger.startActiveSpan("ToggleClass", function (span) {
if(span) {
span.setAttribute("code.function", "ToggleClass");
span.setAttribute("outsystems.function.key", "75f73221-263d-4ec8-99d0-038afbd8222f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnClick_ToggleClassJS, "ToggleClass", "OnClick", {
IsExpanded: OS.DataConversion.JSNodeParamConverter.to(model.variables.isExpandedIn, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SectionItem"), OS.DataTypes.DataTypes.Text),
IsOpen: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnClick$toggleClassJSResult"))();
jsNodeResult.isOpenOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsOpen, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsExpanded = ToggleClass.IsOpen
model.variables.isExpandedIn = toggleClassJSResult.value.isOpenOut;
// Trigger Event: OnToggle2
return controller.onToggle$Action(model.variables.isExpandedIn, callContext);
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

return this.__onClick$Action;
}set _onClick$Action(value) {this.__onClick$Action = value;
}

get _collapse$Action() {if(!(this.hasOwnProperty("__collapse$Action"))) {
this.__collapse$Action = function (isKeypressIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Collapse", function (span) {
if(span) {
span.setAttribute("code.function", "Collapse");
span.setAttribute("outsystems.function.key", "3613f210-9378-4979-befd-e5da83547025");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Collapse");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.Collapse$vars"))());
vars.value.isKeypressInLocal = isKeypressIn;
OS.Logger.startActiveSpan("Collapse", function (span) {
if(span) {
span.setAttribute("code.function", "Collapse");
span.setAttribute("outsystems.function.key", "12dd49a6-9f1c-455e-9d41-98f0be7c17ec");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_Collapse_CollapseJS, "Collapse", "Collapse", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SectionItem"), OS.DataTypes.DataTypes.Text),
IsKeypress: OS.DataConversion.JSNodeParamConverter.to(vars.value.isKeypressInLocal, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
SetAriaAttributes: controller.clientActionProxies.setAriaAttributes$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsExpanded = False
model.variables.isExpandedIn = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__collapse$Action;
}set _collapse$Action(value) {this.__collapse$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (idIn, isParameterChangeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "53d63b67-1341-4cfe-9d78-ae723d0f1058");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnReady$vars"))());
vars.value.idInLocal = idIn;
vars.value.isParameterChangeInLocal = isParameterChangeIn;
var initJSResult = new OS.DataTypes.VariableHolder();
initJSResult.value = OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "4e2a0121-88a5-45f9-bdcc-d4094729b765");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnReady_InitJS, "Init", "OnReady", {
TitleId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("TitleWrapper"), OS.DataTypes.DataTypes.Text),
Id: OS.DataConversion.JSNodeParamConverter.to(vars.value.idInLocal, OS.DataTypes.DataTypes.Text),
IsExpanded: OS.DataConversion.JSNodeParamConverter.to(model.variables.isExpandedIn, OS.DataTypes.DataTypes.Boolean),
IsParameterChange: OS.DataConversion.JSNodeParamConverter.to(vars.value.isParameterChangeInLocal, OS.DataTypes.DataTypes.Boolean),
ContentPlaceholderId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("Content"), OS.DataTypes.DataTypes.Text),
ContentId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("ContentWrapper"), OS.DataTypes.DataTypes.Text),
IsMultipleItems: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
AccordionObj: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
HasWrapper: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean),
HasContent: OS.DataConversion.JSNodeParamConverter.to(false, OS.DataTypes.DataTypes.Boolean)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnReady$initJSResult"))();
jsNodeResult.isMultipleItemsOut = OS.DataConversion.JSNodeParamConverter.from($parameters.IsMultipleItems, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.accordionObjOut = OS.DataConversion.JSNodeParamConverter.from($parameters.AccordionObj, OS.DataTypes.DataTypes.Object);
jsNodeResult.hasWrapperOut = OS.DataConversion.JSNodeParamConverter.from($parameters.HasWrapper, OS.DataTypes.DataTypes.Boolean);
jsNodeResult.hasContentOut = OS.DataConversion.JSNodeParamConverter.from($parameters.HasContent, OS.DataTypes.DataTypes.Boolean);
return jsNodeResult;
}, {
Expand: controller.clientActionProxies.expand$Action,
Collapse: controller.clientActionProxies.collapse$Action,
OnClick: controller.clientActionProxies.onClick$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsMultipleItems = Init.IsMultipleItems
model.variables.isMultipleItemsVar = initJSResult.value.isMultipleItemsOut;
// AccordionObj = Init.AccordionObj
model.variables.accordionObjVar = initJSResult.value.accordionObjOut;
// HasWrapper = Init.HasWrapper
model.variables.hasWrapperVar = initJSResult.value.hasWrapperOut;
// IsWebApp = IsWebApp() or IsLayoutNative()
model.variables.isWebAppVar = (OutSystemsUIController.default.isWebApp$Action(callContext).isWebAppOut || OutSystemsUIController.default.isLayoutNative$Action(callContext).isNativeOut);
// HasContent = Init.HasContent
model.variables.hasContentVar = initJSResult.value.hasContentOut;
OS.Logger.startActiveSpan("SetGlobalActions", function (span) {
if(span) {
span.setAttribute("code.function", "SetGlobalActions");
span.setAttribute("outsystems.function.key", "7ed0df66-4c35-48c9-aef1-2d364c80ccb9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_OnReady_SetGlobalActionsJS, "SetGlobalActions", "OnReady", {
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SectionItem"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
Collapse: controller.clientActionProxies.collapse$Action,
Expand: controller.clientActionProxies.expand$Action,
OnUpdate: controller.clientActionProxies.onUpdate$Action
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

get _setAriaAttributes$Action() {if(!(this.hasOwnProperty("__setAriaAttributes$Action"))) {
this.__setAriaAttributes$Action = function (isExpandIn, elemIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetAriaAttributes", function (span) {
if(span) {
span.setAttribute("code.function", "SetAriaAttributes");
span.setAttribute("outsystems.function.key", "7f6298a2-fae4-4892-bf9f-d9066e01090c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetAriaAttributes");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.SetAriaAttributes$vars"))());
vars.value.isExpandInLocal = isExpandIn;
vars.value.elemIdInLocal = elemIdIn;
OS.Logger.startActiveSpan("SetAttributes", function (span) {
if(span) {
span.setAttribute("code.function", "SetAttributes");
span.setAttribute("outsystems.function.key", "be54c63d-499f-48f4-9bd7-3913b2be9499");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_SetAriaAttributes_SetAttributesJS, "SetAttributes", "SetAriaAttributes", {
IsExpand: OS.DataConversion.JSNodeParamConverter.to(vars.value.isExpandInLocal, OS.DataTypes.DataTypes.Boolean),
ElementId: OS.DataConversion.JSNodeParamConverter.to(vars.value.elemIdInLocal, OS.DataTypes.DataTypes.Text)
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

return this.__setAriaAttributes$Action;
}set _setAriaAttributes$Action(value) {this.__setAriaAttributes$Action = value;
}

get _onUpdate$Action() {if(!(this.hasOwnProperty("__onUpdate$Action"))) {
this.__onUpdate$Action = function (multipleItemsIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnUpdate", function (span) {
if(span) {
span.setAttribute("code.function", "OnUpdate");
span.setAttribute("outsystems.function.key", "9ab6d530-4d83-4448-a709-463a5014bab1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnUpdate");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnUpdate$vars"))());
vars.value.multipleItemsInLocal = multipleItemsIn;
// IsMultipleItems = MultipleItems
model.variables.isMultipleItemsVar = vars.value.multipleItemsInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__onUpdate$Action;
}set _onUpdate$Action(value) {this.__onUpdate$Action = value;
}

get _expand$Action() {if(!(this.hasOwnProperty("__expand$Action"))) {
this.__expand$Action = function (isKeypressIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Expand", function (span) {
if(span) {
span.setAttribute("code.function", "Expand");
span.setAttribute("outsystems.function.key", "fa0ddb9e-95b2-4a17-9de4-1bc625559e10");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Expand");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.Expand$vars"))());
vars.value.isKeypressInLocal = isKeypressIn;
OS.Logger.startActiveSpan("Expand", function (span) {
if(span) {
span.setAttribute("code.function", "Expand");
span.setAttribute("outsystems.function.key", "ee07a203-c5c4-451b-993a-cf2028c3a822");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Content_DEPRECATED_AccordionItem_mvc_controller_Expand_ExpandJS, "Expand", "Expand", {
IsKeypress: OS.DataConversion.JSNodeParamConverter.to(vars.value.isKeypressInLocal, OS.DataTypes.DataTypes.Boolean),
WidgetId: OS.DataConversion.JSNodeParamConverter.to(idService.getId("SectionItem"), OS.DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
SetAriaAttributes: controller.clientActionProxies.setAriaAttributes$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IsExpanded = True
model.variables.isExpandedIn = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__expand$Action;
}set _expand$Action(value) {this.__expand$Action = value;
}


onClick$Action(elemIdIn, isKeypressIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "3589177e-d0d9-4e85-99ff-0e683d7b90e1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClick$Action, callContext, elemIdIn, isKeypressIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

collapse$Action(isKeypressIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Collapse__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Collapse");
span.setAttribute("outsystems.function.key", "3613f210-9378-4979-befd-e5da83547025");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._collapse$Action, callContext, isKeypressIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(idIn, isParameterChangeIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "53d63b67-1341-4cfe-9d78-ae723d0f1058");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext, idIn, isParameterChangeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setAriaAttributes$Action(isExpandIn, elemIdIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetAriaAttributes__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetAriaAttributes");
span.setAttribute("outsystems.function.key", "7f6298a2-fae4-4892-bf9f-d9066e01090c");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setAriaAttributes$Action, callContext, isExpandIn, elemIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onUpdate$Action(multipleItemsIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnUpdate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnUpdate");
span.setAttribute("outsystems.function.key", "9ab6d530-4d83-4448-a709-463a5014bab1");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onUpdate$Action, callContext, multipleItemsIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

expand$Action(isKeypressIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Expand__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Expand");
span.setAttribute("outsystems.function.key", "fa0ddb9e-95b2-4a17-9de4-1bc625559e10");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._expand$Action, callContext, isKeypressIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onToggle$Action() {if(!(this.hasOwnProperty("_onToggle$Action"))) {
this._onToggle$Action = function () {
return Promise.resolve();
};
}

return this._onToggle$Action;
}set onToggle$Action(value) {this._onToggle$Action = value;
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

return controller.onReady$Action(idService.getId("SectionItem"), false, callContext);

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
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(idService.getId("SectionItem"), true, callContext);

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
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnClick$vars", [{
name: "ElemId",
attrName: "elemIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsKeypress",
attrName: "isKeypressInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnClick$toggleClassJSResult", [{
name: "IsOpen",
attrName: "isOpenOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.Collapse$vars", [{
name: "IsKeypress",
attrName: "isKeypressInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnReady$vars", [{
name: "Id",
attrName: "idInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsParameterChange",
attrName: "isParameterChangeInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnReady$initJSResult", [{
name: "IsMultipleItems",
attrName: "isMultipleItemsOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "AccordionObj",
attrName: "accordionObjOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "HasWrapper",
attrName: "hasWrapperOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "HasContent",
attrName: "hasContentOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.SetAriaAttributes$vars", [{
name: "IsExpand",
attrName: "isExpandInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ElemId",
attrName: "elemIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.OnUpdate$vars", [{
name: "MultipleItems",
attrName: "multipleItemsInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Content.DEPRECATED_AccordionItem.Expand$vars", [{
name: "IsKeypress",
attrName: "isKeypressInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




