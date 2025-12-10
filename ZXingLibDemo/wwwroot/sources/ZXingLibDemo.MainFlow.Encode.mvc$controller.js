import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import ZXingLibDemoLanguageResources from "./ZXingLibDemo.languageResources.js";
import ZXingLibDemoClientVariables from "./ZXingLibDemo.clientVariables.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getBarcodeDefaults$DataActRefresh: -1,
getCodes$DataActRefresh: 0,
encodeBarcodeImage$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getBarcodeDefaults$DataActRefresh: [],
getCodes$DataActRefresh: [],
encodeBarcodeImage$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getBarcodeDefaults$DataActRefresh() {if(!(this.hasOwnProperty("_getBarcodeDefaults$DataActRefresh"))) {
this._getBarcodeDefaults$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetBarcodeDefaults", "screenservices/ZXingLibDemo/MainFlow/Encode/DataActionGetBarcodeDefaults", "RBpe8T9wm2kTVVTzVJUSLA", function (b) {
model.variables.getBarcodeDefaultsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBarcodeDefaultsDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getBarcodeDefaultsDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._getBarcodeDefaultsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetBarcodeDefaults", function (span) {
if(span) {
span.setAttribute("code.function", "GetBarcodeDefaults");
span.setAttribute("outsystems.function.key", "253bd61e-d384-4c20-9271-92846be493e4");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getBarcodeDefaults$DataActRefresh;
}set getBarcodeDefaults$DataActRefresh(value) {this._getBarcodeDefaults$DataActRefresh = value;
}

get getCodes$DataActRefresh() {if(!(this.hasOwnProperty("_getCodes$DataActRefresh"))) {
this._getCodes$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetCodes", "screenservices/ZXingLibDemo/MainFlow/Encode/DataActionGetCodes", "_tP6YRZeek8itMOg05_HuA", function (b) {
model.variables.getCodesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCodesDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getCodesDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false);
}.bind(this);
return OS.Logger.startActiveSpan("GetCodes", function (span) {
if(span) {
span.setAttribute("code.function", "GetCodes");
span.setAttribute("outsystems.function.key", "3b32149b-6ede-418a-a566-5985a5115560");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getCodes$DataActRefresh;
}set getCodes$DataActRefresh(value) {this._getCodes$DataActRefresh = value;
}

get encodeBarcodeImage$DataActRefresh() {if(!(this.hasOwnProperty("_encodeBarcodeImage$DataActRefresh"))) {
this._encodeBarcodeImage$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionEncodeBarcodeImage", "screenservices/ZXingLibDemo/MainFlow/Encode/DataActionEncodeBarcodeImage", "kCUwtJkfF_yHcuj3D9Fvdg", function (b) {
model.variables.encodeBarcodeImageDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.encodeBarcodeImageDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.encodeBarcodeImageDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._encodeOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("EncodeBarcodeImage", function (span) {
if(span) {
span.setAttribute("code.function", "EncodeBarcodeImage");
span.setAttribute("outsystems.function.key", "b0beabf0-27ad-40bb-8c3b-ae499bb333ca");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._encodeBarcodeImage$DataActRefresh;
}set encodeBarcodeImage$DataActRefresh(value) {this._encodeBarcodeImage$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getBarcodeDefaults$DataActRefresh", "getCodes$DataActRefresh", "encodeBarcodeImage$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _encodeOnAfterFetch$Action() {if(!(this.hasOwnProperty("__encodeOnAfterFetch$Action"))) {
this.__encodeOnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("EncodeOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "EncodeOnAfterFetch");
span.setAttribute("outsystems.function.key", "2408dd7d-624d-4a4b-b3ed-bc5cdb7dee4f");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("EncodeOnAfterFetch");
callContext = controller.callContext(callContext);
// Hide loading Pop-up
// IsLoading = False
ZXingLibDemoClientVariables.setIsLoading(false);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__encodeOnAfterFetch$Action;
}set _encodeOnAfterFetch$Action(value) {this.__encodeOnAfterFetch$Action = value;
}

get _dropdown_CodeOnChange$Action() {if(!(this.hasOwnProperty("__dropdown_CodeOnChange$Action"))) {
this.__dropdown_CodeOnChange$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("Dropdown_CodeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CodeOnChange");
span.setAttribute("outsystems.function.key", "356b1650-f7d9-42cf-aaa3-b80f883ac5d6");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_CodeOnChange");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Refresh Query: GetBarcodeDefaults
var result = controller.getBarcodeDefaults$DataActRefresh(callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__dropdown_CodeOnChange$Action;
}set _dropdown_CodeOnChange$Action(value) {this.__dropdown_CodeOnChange$Action = value;
}

get _getBarcodeDefaultsOnAfterFetch$Action() {if(!(this.hasOwnProperty("__getBarcodeDefaultsOnAfterFetch$Action"))) {
this.__getBarcodeDefaultsOnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GetBarcodeDefaultsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetBarcodeDefaultsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4d904d50-b4e5-4e3a-95e2-4c9362024b9b");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetBarcodeDefaultsOnAfterFetch");
callContext = controller.callContext(callContext);
// Value = GetBarcodeDefaults.Code.Sample
model.variables.valueVar = model.variables.getBarcodeDefaultsDataAct.codeOut.sampleAttr;
// Width = GetBarcodeDefaults.Code.Width
model.variables.widthVar = model.variables.getBarcodeDefaultsDataAct.codeOut.widthAttr;
// Height = GetBarcodeDefaults.Code.Height
model.variables.heightVar = model.variables.getBarcodeDefaultsDataAct.codeOut.heightAttr;
// Margin = GetBarcodeDefaults.Code.Margin
model.variables.marginVar = model.variables.getBarcodeDefaultsDataAct.codeOut.marginAttr;
// NoPadding = Margin = 0
model.variables.noPaddingVar = (model.variables.marginVar === 0);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__getBarcodeDefaultsOnAfterFetch$Action;
}set _getBarcodeDefaultsOnAfterFetch$Action(value) {this.__getBarcodeDefaultsOnAfterFetch$Action = value;
}

get _genericEncodeOnClick$Action() {if(!(this.hasOwnProperty("__genericEncodeOnClick$Action"))) {
this.__genericEncodeOnClick$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("GenericEncodeOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "GenericEncodeOnClick");
span.setAttribute("outsystems.function.key", "bc1fc031-a94a-4bc1-94cd-530962773dfa");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("GenericEncodeOnClick");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// Show loading Pop-up 
// IsLoading = True
ZXingLibDemoClientVariables.setIsLoading(true);
// Refresh Query: EncodeBarcodeImage
var result = controller.encodeBarcodeImage$DataActRefresh(callContext);
model.flush();
return result;
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

return this.__genericEncodeOnClick$Action;
}set _genericEncodeOnClick$Action(value) {this.__genericEncodeOnClick$Action = value;
}


encodeOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("EncodeOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EncodeOnAfterFetch");
span.setAttribute("outsystems.function.key", "2408dd7d-624d-4a4b-b3ed-bc5cdb7dee4f");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._encodeOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_CodeOnChange$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("Dropdown_CodeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CodeOnChange");
span.setAttribute("outsystems.function.key", "356b1650-f7d9-42cf-aaa3-b80f883ac5d6");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_CodeOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getBarcodeDefaultsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetBarcodeDefaultsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetBarcodeDefaultsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4d904d50-b4e5-4e3a-95e2-4c9362024b9b");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getBarcodeDefaultsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

genericEncodeOnClick$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GenericEncodeOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GenericEncodeOnClick");
span.setAttribute("outsystems.function.key", "bc1fc031-a94a-4bc1-94cd-530962773dfa");
span.setAttribute("outsystems.function.owner.name", "ZXingLibDemo");
span.setAttribute("outsystems.function.owner.key", "61918b7a-e496-4b63-992b-b83299b21e43");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._genericEncodeOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
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
return ZXingLibDemoController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables

}
export default new OS.Controller.ControllerFactory(Controller, ZXingLibDemoLanguageResources);




