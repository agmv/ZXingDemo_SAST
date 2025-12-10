import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";
import OutSystemsUILanguageResources from "./OutSystemsUI.languageResources.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_TranslationsResources from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$translationsResources.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_OnReady_InitJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.OnReady.InitJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_DeviceReady_SetEventListenersJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.DeviceReady.SetEventListenersJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_DeviceReady_SetActionReferencesJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.DeviceReady.SetActionReferencesJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_OnDestroy_RemoveEventHandlersJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.OnDestroy.RemoveEventHandlersJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SaveDeviceReadyCallbackJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.Init.SaveDeviceReadyCallbackJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_RegisterPluginInfoJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.Init.RegisterPluginInfoJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SetActionReferencesJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.Init.SetActionReferencesJS.js";
import OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SetEventListenersJS from "./OutSystemsUI.Private.NetworkStatusChanged.mvc$controller.Init.SetEventListenersJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, OutSystemsUI_Private_NetworkStatusChanged_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
init$Action: function () {
return controller.executeActionInsideJSNode(controller._init$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Init");
},
offline$Action: function () {
return controller.executeActionInsideJSNode(controller._offline$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Offline");
},
online$Action: function () {
return controller.executeActionInsideJSNode(controller._online$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Online");
},
deviceReady$Action: function () {
return controller.executeActionInsideJSNode(controller._deviceReady$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "DeviceReady");
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
get _offline$Action() {if(!(this.hasOwnProperty("__offline$Action"))) {
this.__offline$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Offline", function (span) {
if(span) {
span.setAttribute("code.function", "Offline");
span.setAttribute("outsystems.function.key", "55d4c313-1ef1-402a-b2c9-c25b76ba989b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Offline");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.variables.isOnlineVar)) {
// IsOnline = False
model.variables.isOnlineVar = false;
// Trigger Event: NetworkStatusChangedToOffline
return controller.networkStatusChanged$Action(model.variables.isOnlineVar, callContext);
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

return this.__offline$Action;
}set _offline$Action(value) {this.__offline$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "8096b967-a824-458c-bb27-37d40f5e437d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "f63cd93a-f8db-4061-a9d0-19b5a02819c0");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_OnReady_InitJS, "Init", "OnReady", null, function ($parameters) {
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

get _online$Action() {if(!(this.hasOwnProperty("__online$Action"))) {
this.__online$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Online", function (span) {
if(span) {
span.setAttribute("code.function", "Online");
span.setAttribute("outsystems.function.key", "b77f3935-1c8b-4868-9c2d-986d1026d56d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Online");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isOnlineVar))) {
// IsOnline = True
model.variables.isOnlineVar = true;
// Trigger Event: NetworkStatusChangedToOnline
return controller.networkStatusChanged$Action(model.variables.isOnlineVar, callContext);
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

return this.__online$Action;
}set _online$Action(value) {this.__online$Action = value;
}

get _deviceReady$Action() {if(!(this.hasOwnProperty("__deviceReady$Action"))) {
this.__deviceReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("DeviceReady", function (span) {
if(span) {
span.setAttribute("code.function", "DeviceReady");
span.setAttribute("outsystems.function.key", "c0ca0a6f-6e6b-4d1f-83c3-08f130fc0a26");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DeviceReady");
callContext = controller.callContext(callContext);
var setActionReferencesJSResult = new OS.DataTypes.VariableHolder();
setActionReferencesJSResult.value = OS.Logger.startActiveSpan("SetActionReferences", function (span) {
if(span) {
span.setAttribute("code.function", "SetActionReferences");
span.setAttribute("outsystems.function.key", "ecaa7673-bc02-4879-b7dd-d39fb6a51d44");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_DeviceReady_SetActionReferencesJS, "SetActionReferences", "DeviceReady", {
OfflineActionReference: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnlineActionReference: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.DeviceReady$setActionReferencesJSResult"))();
jsNodeResult.offlineActionReferenceOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OfflineActionReference, OS.DataTypes.DataTypes.Object);
jsNodeResult.onlineActionReferenceOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnlineActionReference, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
Offline: controller.clientActionProxies.offline$Action,
Online: controller.clientActionProxies.online$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SaveReferences
// OfflineActionReference = SetActionReferences.OfflineActionReference
model.variables.offlineActionReferenceVar = setActionReferencesJSResult.value.offlineActionReferenceOut;
// OnlineActionReference = SetActionReferences.OnlineActionReference
model.variables.onlineActionReferenceVar = setActionReferencesJSResult.value.onlineActionReferenceOut;
OS.Logger.startActiveSpan("SetEventListeners", function (span) {
if(span) {
span.setAttribute("code.function", "SetEventListeners");
span.setAttribute("outsystems.function.key", "4baef71b-e8d4-4c1c-acd1-557a86fa129b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_DeviceReady_SetEventListenersJS, "SetEventListeners", "DeviceReady", {
OnlineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.onlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
OfflineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.offlineActionReferenceVar, OS.DataTypes.DataTypes.Object)
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

return this.__deviceReady$Action;
}set _deviceReady$Action(value) {this.__deviceReady$Action = value;
}

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "d05ef9de-45c1-46c3-ba21-8a7a7cb0b481");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
OS.Logger.startActiveSpan("RemoveEventHandlers", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveEventHandlers");
span.setAttribute("outsystems.function.key", "6cf9288c-03bc-46d4-9e62-97d611052030");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_OnDestroy_RemoveEventHandlersJS, "RemoveEventHandlers", "OnDestroy", {
OnlineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.onlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
OfflineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.offlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
offlineHandlerObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.offlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
onlineHandlerObj: OS.DataConversion.JSNodeParamConverter.to(model.variables.onlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
deviceReadyActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.deviceReadyActionReferenceVar, OS.DataTypes.DataTypes.Object)
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

get _init$Action() {if(!(this.hasOwnProperty("__init$Action"))) {
this.__init$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Init", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "e9909a3f-b537-4a17-9f3d-1775923119c5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Init");
callContext = controller.callContext(callContext);
var getNetworkStatusVar = new OS.DataTypes.VariableHolder();
var saveDeviceReadyCallbackJSResult = new OS.DataTypes.VariableHolder();
var setActionReferencesJSResult = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: LoadOutSystemsUIScript
model.flush();
return OutSystemsUIController.default.loadOutSystemsUIScript$Action(callContext).then(function () {
// Execute Action: GetNetworkStatus
getNetworkStatusVar.value = OutSystemsUIController.default.getNetworkStatus$Action(callContext);

}).then(function () {
return OS.Flow.executeSequence(function () {
if((getNetworkStatusVar.value.isOnlineOut)) {
// Execute Action: Online
return controller._online$Action(callContext);
} else {
// Execute Action: Offline
return controller._offline$Action(callContext);
}

});
}).then(function () {
saveDeviceReadyCallbackJSResult.value = OS.Logger.startActiveSpan("SaveDeviceReadyCallback", function (span) {
if(span) {
span.setAttribute("code.function", "SaveDeviceReadyCallback");
span.setAttribute("outsystems.function.key", "473e7812-58c7-4257-999d-eb262263491d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SaveDeviceReadyCallbackJS, "SaveDeviceReadyCallback", "Init", {
DeviceReadyActionReference: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.Init$saveDeviceReadyCallbackJSResult"))();
jsNodeResult.deviceReadyActionReferenceOut = OS.DataConversion.JSNodeParamConverter.from($parameters.DeviceReadyActionReference, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
DeviceReady: controller.clientActionProxies.deviceReady$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SaveReference
// DeviceReadyActionReference = SaveDeviceReadyCallback.DeviceReadyActionReference
model.variables.deviceReadyActionReferenceVar = saveDeviceReadyCallbackJSResult.value.deviceReadyActionReferenceOut;
OS.Logger.startActiveSpan("RegisterPluginInfo", function (span) {
if(span) {
span.setAttribute("code.function", "RegisterPluginInfo");
span.setAttribute("outsystems.function.key", "69e51a3d-e2ad-495f-977b-1f6edffd4a5f");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_RegisterPluginInfoJS, "RegisterPluginInfo", "Init", {
DeviceReadyActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.deviceReadyActionReferenceVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
setActionReferencesJSResult.value = OS.Logger.startActiveSpan("SetActionReferences", function (span) {
if(span) {
span.setAttribute("code.function", "SetActionReferences");
span.setAttribute("outsystems.function.key", "8e02aff6-b2fc-4992-86d2-80129478d9fc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SetActionReferencesJS, "SetActionReferences", "Init", {
OfflineActionReference: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
OnlineActionReference: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.Init$setActionReferencesJSResult"))();
jsNodeResult.offlineActionReferenceOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OfflineActionReference, OS.DataTypes.DataTypes.Object);
jsNodeResult.onlineActionReferenceOut = OS.DataConversion.JSNodeParamConverter.from($parameters.OnlineActionReference, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
Offline: controller.clientActionProxies.offline$Action,
Online: controller.clientActionProxies.online$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SaveReferences
// OfflineActionReference = SetActionReferences.OfflineActionReference
model.variables.offlineActionReferenceVar = setActionReferencesJSResult.value.offlineActionReferenceOut;
// OnlineActionReference = SetActionReferences.OnlineActionReference
model.variables.onlineActionReferenceVar = setActionReferencesJSResult.value.onlineActionReferenceOut;
OS.Logger.startActiveSpan("SetEventListeners", function (span) {
if(span) {
span.setAttribute("code.function", "SetEventListeners");
span.setAttribute("outsystems.function.key", "bf8882b9-83b4-4cc8-9bc1-c250bb15b019");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsUI_Private_NetworkStatusChanged_mvc_controller_Init_SetEventListenersJS, "SetEventListeners", "Init", {
OfflineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.offlineActionReferenceVar, OS.DataTypes.DataTypes.Object),
OnlineActionReference: OS.DataConversion.JSNodeParamConverter.to(model.variables.onlineActionReferenceVar, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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


offline$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Offline__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Offline");
span.setAttribute("outsystems.function.key", "55d4c313-1ef1-402a-b2c9-c25b76ba989b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._offline$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8096b967-a824-458c-bb27-37d40f5e437d");
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

online$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Online__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Online");
span.setAttribute("outsystems.function.key", "b77f3935-1c8b-4868-9c2d-986d1026d56d");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._online$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

deviceReady$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("DeviceReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DeviceReady");
span.setAttribute("outsystems.function.key", "c0ca0a6f-6e6b-4d1f-83c3-08f130fc0a26");
span.setAttribute("outsystems.function.owner.name", "OutSystemsUI");
span.setAttribute("outsystems.function.owner.key", "8be17f2a-431c-4958-b894-c77b988a7271");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._deviceReady$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d05ef9de-45c1-46c3-ba21-8a7a7cb0b481");
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

init$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Init__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Init");
span.setAttribute("outsystems.function.key", "e9909a3f-b537-4a17-9f3d-1775923119c5");
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

get networkStatusChanged$Action() {if(!(this.hasOwnProperty("_networkStatusChanged$Action"))) {
this._networkStatusChanged$Action = function () {
return Promise.resolve();
};
}

return this._networkStatusChanged$Action;
}set networkStatusChanged$Action(value) {this._networkStatusChanged$Action = value;
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
Controller.registerVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.DeviceReady$setActionReferencesJSResult", [{
name: "OfflineActionReference",
attrName: "offlineActionReferenceOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnlineActionReference",
attrName: "onlineActionReferenceOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.Init$saveDeviceReadyCallbackJSResult", [{
name: "DeviceReadyActionReference",
attrName: "deviceReadyActionReferenceOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);
Controller.registerVariableGroupType("OutSystemsUI.Private.NetworkStatusChanged.Init$setActionReferencesJSResult", [{
name: "OfflineActionReference",
attrName: "offlineActionReferenceOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "OnlineActionReference",
attrName: "onlineActionReferenceOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsUILanguageResources);




