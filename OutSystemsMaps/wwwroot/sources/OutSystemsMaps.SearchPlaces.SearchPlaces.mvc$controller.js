import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";
import OutSystemsMapsLanguageResources from "./OutSystemsMaps.languageResources.js";
import OutSystemsMaps_SearchPlaces_SearchPlaces_mvc_controller_SubscribeEvents_GetCallbackHandlerJS from "./OutSystemsMaps.SearchPlaces.SearchPlaces.mvc$controller.SubscribeEvents.GetCallbackHandlerJS.js";

var OS = OSRuntimeCore;
{class ControllerInner extends 
OS.Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService);
var controller = this.controller;
this.clientActionProxies = {
searchPlacesOnError_Callback$Action: function (searchPlacesObjIn, searchPlacesIdIn, errorCodeIn, extraErrorMessageIn) {
searchPlacesObjIn = (searchPlacesObjIn === undefined) ? null : searchPlacesObjIn;
searchPlacesIdIn = (searchPlacesIdIn === undefined) ? "" : searchPlacesIdIn;
errorCodeIn = (errorCodeIn === undefined) ? "" : errorCodeIn;
extraErrorMessageIn = (extraErrorMessageIn === undefined) ? "" : extraErrorMessageIn;
return controller.executeActionInsideJSNode(controller._searchPlacesOnError_Callback$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(searchPlacesObjIn, OS.DataTypes.DataTypes.Object), OS.DataConversion.JSNodeParamConverter.from(searchPlacesIdIn, OS.DataTypes.DataTypes.Text), errorCodeIn, OS.DataConversion.JSNodeParamConverter.from(extraErrorMessageIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SearchPlacesOnError_Callback");
},
searchPlacesOnPlaceSelect_Callback$Action: function (searchPlacesObjIn, searchPlacesIdIn, nameIn, coordinatesIn, addressIn) {
searchPlacesObjIn = (searchPlacesObjIn === undefined) ? null : searchPlacesObjIn;
searchPlacesIdIn = (searchPlacesIdIn === undefined) ? "" : searchPlacesIdIn;
nameIn = (nameIn === undefined) ? "" : nameIn;
coordinatesIn = (coordinatesIn === undefined) ? "" : coordinatesIn;
addressIn = (addressIn === undefined) ? "" : addressIn;
return controller.executeActionInsideJSNode(controller._searchPlacesOnPlaceSelect_Callback$Action.bind(controller, OS.DataConversion.JSNodeParamConverter.from(searchPlacesObjIn, OS.DataTypes.DataTypes.Object), OS.DataConversion.JSNodeParamConverter.from(searchPlacesIdIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(nameIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(coordinatesIn, OS.DataTypes.DataTypes.Text), OS.DataConversion.JSNodeParamConverter.from(addressIn, OS.DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "SearchPlacesOnPlaceSelect_Callback");
}
};
this.dataFetchDependenciesOriginal = {
getApiVersion$DataActRefresh: -1,
getServerAPIKey$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getApiVersion$DataActRefresh: [],
getServerAPIKey$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = false;
}

// Server Actions - Methods
get getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction() {if(!(this.hasOwnProperty("_getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction"))) {
this._getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction = function (searchPlacesErrorCodeIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("GetSearchPlacesErrorBySearchPlacesErrorCode", function (span) {
if(span) {
span.setAttribute("code.function", "GetSearchPlacesErrorBySearchPlacesErrorCode");
span.setAttribute("outsystems.function.key", "765f9c11-4bf8-432b-97fc-90c9845f8fe8");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS.Flow.tryFinally(function () {
var inputs = {
SearchPlacesErrorCode: OS.DataConversion.ServerDataConverter.to(searchPlacesErrorCodeIn, OS.DataTypes.DataTypes.Text)
};
return controller.callServerAction("GetSearchPlacesErrorBySearchPlacesErrorCode", "screenservices/OutSystemsMaps/SearchPlaces/SearchPlaces/ActionGetSearchPlacesErrorBySearchPlacesErrorCode", "3hhUEU7Ppvah3oqUJMYQKA", inputs, controller.callContext(callContext), undefined, undefined, false).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces$ActionGetSearchPlacesErrorBySearchPlacesErrorCode"))();
executeServerActionResult.errorMessageOut = OS.DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS.DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
}

return this._getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction;
}set getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction(value) {this._getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction = value;
}


// Aggregates and Data Actions
get getApiVersion$DataActRefresh() {if(!(this.hasOwnProperty("_getApiVersion$DataActRefresh"))) {
this._getApiVersion$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApiVersion", "screenservices/OutSystemsMaps/SearchPlaces/SearchPlaces/DataActionGetApiVersion", "W7oDqG0MFaHlqkUIo+i8Sw", function (b) {
model.variables.getApiVersionDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApiVersionDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getApiVersionDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
controller._obtainMapAPIVersion_OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetApiVersion", function (span) {
if(span) {
span.setAttribute("code.function", "GetApiVersion");
span.setAttribute("outsystems.function.key", "063846bf-5a70-4e57-a81c-60bd9d542d5a");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

return this._getApiVersion$DataActRefresh;
}set getApiVersion$DataActRefresh(value) {this._getApiVersion$DataActRefresh = value;
}

get getServerAPIKey$DataActRefresh() {if(!(this.hasOwnProperty("_getServerAPIKey$DataActRefresh"))) {
this._getServerAPIKey$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetServerAPIKey", "screenservices/OutSystemsMaps/SearchPlaces/SearchPlaces/DataActionGetServerAPIKey", "WFv389nwOUTdQT3xqOYXCQ", function (b) {
model.variables.getServerAPIKeyDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getServerAPIKeyDataAct.replaceWith(OS.DataConversion.ServerDataConverter.from(json, model.variables.getServerAPIKeyDataAct.constructor));
}, undefined, undefined, undefined, callContext, undefined, false).then(function () {
return controller._obtainMapKey_OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS.Logger.startActiveSpan("GetServerAPIKey", function (span) {
if(span) {
span.setAttribute("code.function", "GetServerAPIKey");
span.setAttribute("outsystems.function.key", "cb90eace-6f3d-42be-958b-96aa48ac65d9");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

return this._getServerAPIKey$DataActRefresh;
}set getServerAPIKey$DataActRefresh(value) {this._getServerAPIKey$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApiVersion$DataActRefresh", "getServerAPIKey$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
get _onInitialize$Action() {if(!(this.hasOwnProperty("__onInitialize$Action"))) {
this.__onInitialize$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "15c30196-4770-4695-a0f2-bdfdd44c5da2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var generateUniqueIdVar = new OS.DataTypes.VariableHolder();
var serialize_configsVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var searchAreaSerializeVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var countriesSerializeVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
// Execute Action: LogStart
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Going to create Map", callContext);
// Execute Action: GenerateUniqueId
generateUniqueIdVar.value = OutSystemsMapsController.default.generateUniqueId$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);

// UniqueId = GenerateUniqueId.Unique_ID
model.variables.uniqueIdVar = generateUniqueIdVar.value.unique_IDOut;
// SearchArea
// SearchArea.North = OptionalConfigs.SearchArea.North
model.variables.searchAreaVar.northAttr = model.variables.optionalConfigsIn.searchAreaAttr.northAttr;
// SearchArea.South = OptionalConfigs.SearchArea.South
model.variables.searchAreaVar.southAttr = model.variables.optionalConfigsIn.searchAreaAttr.southAttr;
// SearchArea.East = OptionalConfigs.SearchArea.East
model.variables.searchAreaVar.eastAttr = model.variables.optionalConfigsIn.searchAreaAttr.eastAttr;
// SearchArea.West = OptionalConfigs.SearchArea.West
model.variables.searchAreaVar.westAttr = model.variables.optionalConfigsIn.searchAreaAttr.westAttr;
// JSON Serialize: SearchAreaSerialize
searchAreaSerializeVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.searchAreaVar, true, false);
// JSON Serialize: CountriesSerialize
countriesSerializeVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.optionalConfigsIn.countriesAttr, true, false, OS.DataTypes.DataTypes.Text);
// Assign Jsons
// SearchAreaString = SearchAreaSerialize.JSON
model.variables.searchAreaStringVar = searchAreaSerializeVar.value.jSONOut;
// CountriesString = CountriesSerialize.JSON
model.variables.countriesStringVar = countriesSerializeVar.value.jSONOut;
// Configs_Local
// Internal_Configs.Internal_to_provider_configs.apiKey = APIKey
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr = model.variables.aPIKeyIn;
// Internal_Configs.UniqueId = GenerateUniqueId.Unique_ID
model.variables.internal_ConfigsVar.uniqueIdAttr = generateUniqueIdVar.value.unique_IDOut;
// Internal_Configs.Internal_to_provider_configs.countries = OptionalConfigs.Countries
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.countriesAttr = model.variables.optionalConfigsIn.countriesAttr;
// Internal_Configs.Internal_to_provider_configs.searchArea = OptionalConfigs.SearchArea
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.searchAreaAttr = model.variables.optionalConfigsIn.searchAreaAttr;
// Internal_Configs.Internal_to_provider_configs.searchType = OptionalConfigs.SearchType
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.searchTypeAttr = model.variables.optionalConfigsIn.searchTypeAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalConfigsIn.localizationAttr.regionAttr;
// JSON Serialize: Serialize_configs
serialize_configsVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.internal_ConfigsVar.internal_to_provider_configsAttr, true, false);
// Execute Action: CreateSearchPlaces
OutSystemsMapsController.default.createSearchPlaces$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, serialize_configsVar.value.jSONOut, callContext);
// Execute Action: LogEnd
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Map created", callContext);
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

get _obtainMapKey_OnAfterFetch$Action() {if(!(this.hasOwnProperty("__obtainMapKey_OnAfterFetch$Action"))) {
this.__obtainMapKey_OnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "30554b4c-8e83-4d42-b07a-16cb514a1cb7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("ObtainMapKey_OnAfterFetch");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// IsSecondRound = True
model.variables.isSecondRoundVar = true;
// Execute Action: SetApiKey
return controller._setApiKey$Action(model.variables.getServerAPIKeyDataAct.serverAPIKeyOut, callContext).then(function () {
// Execute Action: SetProviderVersion
OutSystemsMapsController.default.setProviderVersion$Action(OutSystemsMapsModel.staticEntities.provider.google, model.variables.getServerAPIKeyDataAct.googleMapsApiVersionOut, false, callContext);
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

return this.__obtainMapKey_OnAfterFetch$Action;
}set _obtainMapKey_OnAfterFetch$Action(value) {this.__obtainMapKey_OnAfterFetch$Action = value;
}

get _searchPlacesOnPlaceSelect_Callback$Action() {if(!(this.hasOwnProperty("__searchPlacesOnPlaceSelect_Callback$Action"))) {
this.__searchPlacesOnPlaceSelect_Callback$Action = function (searchPlacesObjIn, searchPlacesIdIn, nameIn, coordinatesIn, addressIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SearchPlacesOnPlaceSelect_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "SearchPlacesOnPlaceSelect_Callback");
span.setAttribute("outsystems.function.key", "3380fcf1-5e2a-48d2-85ed-7af224bc9bde");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchPlacesOnPlaceSelect_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SearchPlacesOnPlaceSelect_Callback$vars"))());
vars.value.searchPlacesObjInLocal = searchPlacesObjIn;
vars.value.searchPlacesIdInLocal = searchPlacesIdIn;
vars.value.nameInLocal = nameIn;
vars.value.coordinatesInLocal = coordinatesIn;
vars.value.addressInLocal = addressIn;
var jSONDeserializeCoordinatesVar = new OS.DataTypes.VariableHolder(new (OS.Controller.BaseController.getJSONDeserializeOutputType(OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure))());
return OS.Flow.executeAsyncFlow(function () {
// JSON Deserialize: JSONDeserializeCoordinates
jSONDeserializeCoordinatesVar.value.dataOut = OS.JSONUtils.deserializeFromJSON(vars.value.coordinatesInLocal, OutSystemsMapsModel.ST_0e474756a4be14d378c73cd05f602bcdStructure, false);
// Trigger Event: OnPlaceSelect
return controller.onPlaceSelect$Action(vars.value.searchPlacesIdInLocal, vars.value.nameInLocal, jSONDeserializeCoordinatesVar.value.dataOut, vars.value.addressInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};
}

return this.__searchPlacesOnPlaceSelect_Callback$Action;
}set _searchPlacesOnPlaceSelect_Callback$Action(value) {this.__searchPlacesOnPlaceSelect_Callback$Action = value;
}

get _onReady$Action() {if(!(this.hasOwnProperty("__onReady$Action"))) {
this.__onReady$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "5488f24f-20b7-41b6-bc11-719e09cc13ac");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: SubscribeEvents
controller._subscribeEvents$Action(callContext);
// Execute Action: InitializeProviderSearchPlaces
return controller._initializeProviderSearchPlaces$Action(callContext);
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

get _onDestroy$Action() {if(!(this.hasOwnProperty("__onDestroy$Action"))) {
this.__onDestroy$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "64f168e6-1c0a-4f8d-acfd-41df4fd06347");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: RemoveSearchPlaces
OutSystemsMapsController.default.removeSearchPlaces$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
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

get _searchPlacesOnError_Callback$Action() {if(!(this.hasOwnProperty("__searchPlacesOnError_Callback$Action"))) {
this.__searchPlacesOnError_Callback$Action = function (searchPlacesObjIn, searchPlacesIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SearchPlacesOnError_Callback", function (span) {
if(span) {
span.setAttribute("code.function", "SearchPlacesOnError_Callback");
span.setAttribute("outsystems.function.key", "6eb0cbd1-4040-4308-9652-ac7ae8cc98e5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchPlacesOnError_Callback");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SearchPlacesOnError_Callback$vars"))());
vars.value.searchPlacesObjInLocal = searchPlacesObjIn;
vars.value.searchPlacesIdInLocal = searchPlacesIdIn;
vars.value.errorCodeInLocal = errorCodeIn;
vars.value.extraErrorMessageInLocal = extraErrorMessageIn;
var getSearchPlacesErrorBySearchPlacesErrorCodeVar = new OS.DataTypes.VariableHolder();
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: GetSearchPlacesErrorBySearchPlacesErrorCode
model.flush();
return controller.getSearchPlacesErrorBySearchPlacesErrorCode$ServerAction(vars.value.errorCodeInLocal, callContext).then(function (value) {
getSearchPlacesErrorBySearchPlacesErrorCodeVar.value = value;
}).then(function () {
// Trigger Event: OnError
return controller.onError$Action(((((vars.value.extraErrorMessageInLocal) !== (""))) ? ((getSearchPlacesErrorBySearchPlacesErrorCodeVar.value.errorMessageOut + vars.value.extraErrorMessageInLocal)) : (getSearchPlacesErrorBySearchPlacesErrorCodeVar.value.errorMessageOut)), callContext);
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

return this.__searchPlacesOnError_Callback$Action;
}set _searchPlacesOnError_Callback$Action(value) {this.__searchPlacesOnError_Callback$Action = value;
}

get _setApiKey$Action() {if(!(this.hasOwnProperty("__setApiKey$Action"))) {
this.__setApiKey$Action = function (mapAPIKeyIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SetApiKey", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "716f7c29-5932-4efb-805d-e9074d117011");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("SetApiKey");
callContext = controller.callContext(callContext);
var vars = new OS.DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SetApiKey$vars"))());
vars.value.mapAPIKeyInLocal = mapAPIKeyIn;
return OS.Flow.executeAsyncFlow(function () {
return OS.Flow.executeSequence(function () {
if(((model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr === ""))) {
// Set APIKey
// APIKey = MapAPIKey
model.variables.aPIKeyIn = vars.value.mapAPIKeyInLocal;
// Internal_Configs.Internal_to_provider_configs.apiKey = MapAPIKey
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr = vars.value.mapAPIKeyInLocal;
// Execute Action: ChangeSearchPlacesApiKey
OutSystemsMapsController.default.changeSearchPlacesApiKey$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.aPIKeyIn, callContext);
// Execute Action: InitializeProviderSearchPlaces
return controller._initializeProviderSearchPlaces$Action(callContext);
} else {
// Trigger Event: OnError
return controller.onError$Action("The APIKey can\'t be empty.", callContext);
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

return this.__setApiKey$Action;
}set _setApiKey$Action(value) {this.__setApiKey$Action = value;
}

get _obtainMapAPIVersion_OnAfterFetch$Action() {if(!(this.hasOwnProperty("__obtainMapAPIVersion_OnAfterFetch$Action"))) {
this.__obtainMapAPIVersion_OnAfterFetch$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("ObtainMapAPIVersion_OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapAPIVersion_OnAfterFetch");
span.setAttribute("outsystems.function.key", "a5f73438-9cc6-4734-8c56-9dae29b3a7a3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ObtainMapAPIVersion_OnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: SetProviderVersion
OutSystemsMapsController.default.setProviderVersion$Action(OutSystemsMapsModel.staticEntities.provider.google, model.variables.getApiVersionDataAct.googleMapsApiVersionOut, false, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__obtainMapAPIVersion_OnAfterFetch$Action;
}set _obtainMapAPIVersion_OnAfterFetch$Action(value) {this.__obtainMapAPIVersion_OnAfterFetch$Action = value;
}

get _initializeProviderSearchPlaces$Action() {if(!(this.hasOwnProperty("__initializeProviderSearchPlaces$Action"))) {
this.__initializeProviderSearchPlaces$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("InitializeProviderSearchPlaces", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderSearchPlaces");
span.setAttribute("outsystems.function.key", "a97f01c4-e2b7-46d9-a403-0d6474cfbe47");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("InitializeProviderSearchPlaces");
callContext = controller.callContext(callContext);
return OS.Flow.executeAsyncFlow(function () {
// Execute Action: LogStart
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Going to instantiate Map", callContext);
// Has Maps Key?
return OS.Flow.executeSequence(function () {
if((!(((model.variables.aPIKeyIn) !== (""))))) {
return OS.Flow.executeSequence(function () {
if((!(model.variables.isSecondRoundVar))) {
// Refresh Query: GetServerAPIKey
var result = controller.getServerAPIKey$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Execute Action: LogEnd_Waiting
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Waiting for API Key from server", callContext);
return OS.Flow.returnAsync();

});
}

});
}

}).then(function () {
// Execute Action: InitSearchPlaces
OutSystemsMapsController.default.initSearchPlaces$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, callContext);
// Has Maps Key?
return OS.Flow.executeSequence(function () {
if((((model.variables.aPIKeyIn) !== ("")))) {
// Refresh Query: GetApiVersion
var result = controller.getApiVersion$DataActRefresh(callContext);
model.flush();
return result;
}

});
}).then(function () {
// Execute Action: LogEnd
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.general, "Map instantiated", callContext);
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

return this.__initializeProviderSearchPlaces$Action;
}set _initializeProviderSearchPlaces$Action(value) {this.__initializeProviderSearchPlaces$Action = value;
}

get _subscribeEvents$Action() {if(!(this.hasOwnProperty("__subscribeEvents$Action"))) {
this.__subscribeEvents$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("SubscribeEvents", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "b3561e37-e883-4311-9c0f-9caf12783838");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SubscribeEvents");
callContext = controller.callContext(callContext);
var getCallbackHandlerJSResult = new OS.DataTypes.VariableHolder();
getCallbackHandlerJSResult.value = OS.Logger.startActiveSpan("GetCallbackHandler", function (span) {
if(span) {
span.setAttribute("code.function", "GetCallbackHandler");
span.setAttribute("outsystems.function.key", "c02539b3-e22a-4354-932a-6e3f58c2984b");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(OutSystemsMaps_SearchPlaces_SearchPlaces_mvc_controller_SubscribeEvents_GetCallbackHandlerJS, "GetCallbackHandler", "SubscribeEvents", {
SearchPlacesOnError_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object),
SearchPlacesOnPlaceSelect_Callback: OS.DataConversion.JSNodeParamConverter.to(null, OS.DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SubscribeEvents$getCallbackHandlerJSResult"))();
jsNodeResult.searchPlacesOnError_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SearchPlacesOnError_Callback, OS.DataTypes.DataTypes.Object);
jsNodeResult.searchPlacesOnPlaceSelect_CallbackOut = OS.DataConversion.JSNodeParamConverter.from($parameters.SearchPlacesOnPlaceSelect_Callback, OS.DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
SearchPlacesOnError_Callback: controller.clientActionProxies.searchPlacesOnError_Callback$Action,
SearchPlacesOnPlaceSelect_Callback: controller.clientActionProxies.searchPlacesOnPlaceSelect_Callback$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: MapOnError_Subscribe
OutSystemsMapsController.default.searchPlacesEventSubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.searchPlacesEvent.onError, getCallbackHandlerJSResult.value.searchPlacesOnError_CallbackOut, callContext);
// Execute Action: MapOnPlaceSelect_Subscribe
OutSystemsMapsController.default.searchPlacesEventSubscribe$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, OutSystemsMapsModel.staticEntities.searchPlacesEvent.onPlaceSelect, getCallbackHandlerJSResult.value.searchPlacesOnPlaceSelect_CallbackOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
};
}

return this.__subscribeEvents$Action;
}set _subscribeEvents$Action(value) {this.__subscribeEvents$Action = value;
}

get _onParametersChanged$Action() {if(!(this.hasOwnProperty("__onParametersChanged$Action"))) {
this.__onParametersChanged$Action = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS.Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "d08fe428-62bd-41ed-ab8c-eb2cdf7e11dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var serialize_SearchAreaVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
var serialize_CountriesVar = new OS.DataTypes.VariableHolder(new OS.DataTypes.JSONSerializeOutputType());
return OS.Flow.executeAsyncFlow(function () {
// Bounds
// SearchArea.North = OptionalConfigs.SearchArea.North
model.variables.searchAreaVar.northAttr = model.variables.optionalConfigsIn.searchAreaAttr.northAttr;
// SearchArea.South = OptionalConfigs.SearchArea.South
model.variables.searchAreaVar.southAttr = model.variables.optionalConfigsIn.searchAreaAttr.southAttr;
// SearchArea.East = OptionalConfigs.SearchArea.East
model.variables.searchAreaVar.eastAttr = model.variables.optionalConfigsIn.searchAreaAttr.eastAttr;
// SearchArea.West = OptionalConfigs.SearchArea.West
model.variables.searchAreaVar.westAttr = model.variables.optionalConfigsIn.searchAreaAttr.westAttr;
// JSON Serialize: Serialize_SearchArea
serialize_SearchAreaVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.searchAreaVar, true, false);
// JSON Serialize: Serialize_Countries
serialize_CountriesVar.value.jSONOut = OS.JSONUtils.serializeToJSON(model.variables.optionalConfigsIn.countriesAttr, true, false, OS.DataTypes.DataTypes.Text);
// API Key changed?
return OS.Flow.executeSequence(function () {
if((((model.variables.aPIKeyIn) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.apiKeyAttr)))) {
// Execute Action: LogApiKeyChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter API Key has changed.", callContext);
// Execute Action: ChangeSearchPlacesApiKey
OutSystemsMapsController.default.changeSearchPlacesApiKey$Action(model.variables.internal_ConfigsVar.uniqueIdAttr, model.variables.aPIKeyIn, callContext);
// Execute Action: SetApiKey
return controller._setApiKey$Action(model.variables.aPIKeyIn, callContext);
}

}).then(function () {
// Localization changed?
if(((((model.variables.optionalConfigsIn.localizationAttr.languageAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr)) || ((model.variables.optionalConfigsIn.localizationAttr.regionAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr))))) {
// Execute Action: LogLocalizationChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Localization has changed.", callContext);
// Execute Action: ChangeSearchPlacesLocalization
OutSystemsMapsController.default.changeSearchPlacesLocalization$Action(idService.getId("Input_UniqueId"), model.variables.optionalConfigsIn.localizationAttr, callContext);
// Set new Localization
// Internal_Configs.Internal_to_provider_configs.localization.Language = OptionalConfigs.Localization.Language
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.languageAttr = model.variables.optionalConfigsIn.localizationAttr.languageAttr;
// Internal_Configs.Internal_to_provider_configs.localization.Region = OptionalConfigs.Localization.Region
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.localizationAttr.regionAttr = model.variables.optionalConfigsIn.localizationAttr.regionAttr;
}

// SearchArea changed?
if((((model.variables.searchAreaStringVar) !== (serialize_SearchAreaVar.value.jSONOut)))) {
// Execute Action: LogSearchAreaChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter SearchArea has changed.", callContext);
// Execute Action: ChangeSearchPlacesSearchArea
OutSystemsMapsController.default.changeSearchPlacesSearchArea$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.searchAreaAttr, callContext);
// Set SearchArea
// SearchAreaString = Serialize_SearchArea.JSON
model.variables.searchAreaStringVar = serialize_SearchAreaVar.value.jSONOut;
}

// SearchType changed?
if((((model.variables.optionalConfigsIn.searchTypeAttr) !== (model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.searchTypeAttr)))) {
// Execute Action: LogSearchTypeChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter SearchType has changed.", callContext);
// Execute Action: ChangeSearchPlacesSearchType
OutSystemsMapsController.default.changeSearchPlacesSearchType$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.searchTypeAttr, callContext);
// Set SearchType
// Internal_Configs.Internal_to_provider_configs.searchType = OptionalConfigs.SearchType
model.variables.internal_ConfigsVar.internal_to_provider_configsAttr.searchTypeAttr = model.variables.optionalConfigsIn.searchTypeAttr;
}

// Countries changed?
if((((model.variables.countriesStringVar) !== (serialize_CountriesVar.value.jSONOut)))) {
// Execute Action: LogCountriesChange
OutSystemsMapsController.default.logEvent$Action(OutSystemsMapsModel.staticEntities.logType.debug, "The parameter Countries has changed.", callContext);
// Execute Action: ChangeSearchPlacesCountries
OutSystemsMapsController.default.changeSearchPlacesCountries$Action(model.variables.uniqueIdVar, model.variables.optionalConfigsIn.countriesAttr, callContext);
// Set Countries
// CountriesString = Serialize_Countries.JSON
model.variables.countriesStringVar = serialize_CountriesVar.value.jSONOut;
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


onInitialize$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "15c30196-4770-4695-a0f2-bdfdd44c5da2");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

obtainMapKey_OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ObtainMapKey_OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapKey_OnAfterFetch");
span.setAttribute("outsystems.function.key", "30554b4c-8e83-4d42-b07a-16cb514a1cb7");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._obtainMapKey_OnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

searchPlacesOnPlaceSelect_Callback$Action(searchPlacesObjIn, searchPlacesIdIn, nameIn, coordinatesIn, addressIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SearchPlacesOnPlaceSelect_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchPlacesOnPlaceSelect_Callback");
span.setAttribute("outsystems.function.key", "3380fcf1-5e2a-48d2-85ed-7af224bc9bde");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._searchPlacesOnPlaceSelect_Callback$Action, callContext, searchPlacesObjIn, searchPlacesIdIn, nameIn, coordinatesIn, addressIn);
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
span.setAttribute("outsystems.function.key", "5488f24f-20b7-41b6-bc11-719e09cc13ac");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

onDestroy$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "64f168e6-1c0a-4f8d-acfd-41df4fd06347");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

searchPlacesOnError_Callback$Action(searchPlacesObjIn, searchPlacesIdIn, errorCodeIn, extraErrorMessageIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SearchPlacesOnError_Callback__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchPlacesOnError_Callback");
span.setAttribute("outsystems.function.key", "6eb0cbd1-4040-4308-9652-ac7ae8cc98e5");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._searchPlacesOnError_Callback$Action, callContext, searchPlacesObjIn, searchPlacesIdIn, errorCodeIn, extraErrorMessageIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setApiKey$Action(mapAPIKeyIn, callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SetApiKey__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetApiKey");
span.setAttribute("outsystems.function.key", "716f7c29-5932-4efb-805d-e9074d117011");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._setApiKey$Action, callContext, mapAPIKeyIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

obtainMapAPIVersion_OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("ObtainMapAPIVersion_OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ObtainMapAPIVersion_OnAfterFetch");
span.setAttribute("outsystems.function.key", "a5f73438-9cc6-4734-8c56-9dae29b3a7a3");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._obtainMapAPIVersion_OnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

initializeProviderSearchPlaces$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("InitializeProviderSearchPlaces__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitializeProviderSearchPlaces");
span.setAttribute("outsystems.function.key", "a97f01c4-e2b7-46d9-a403-0d6474cfbe47");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS.Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initializeProviderSearchPlaces$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

subscribeEvents$Action(callContext) {
var controller = this.controller;
return OS.Logger.startActiveSpan("SubscribeEvents__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SubscribeEvents");
span.setAttribute("outsystems.function.key", "b3561e37-e883-4311-9c0f-9caf12783838");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._subscribeEvents$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d08fe428-62bd-41ed-ab8c-eb2cdf7e11dc");
span.setAttribute("outsystems.function.owner.name", "OutSystemsMaps");
span.setAttribute("outsystems.function.owner.key", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
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

get onPlaceSelect$Action() {if(!(this.hasOwnProperty("_onPlaceSelect$Action"))) {
this._onPlaceSelect$Action = function () {
return Promise.resolve();
};
}

return this._onPlaceSelect$Action;
}set onPlaceSelect$Action(value) {this._onPlaceSelect$Action = value;
}

get onError$Action() {if(!(this.hasOwnProperty("_onError$Action"))) {
this._onError$Action = function () {
return Promise.resolve();
};
}

return this._onError$Action;
}set onError$Action(value) {this._onError$Action = value;
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
return OutSystemsMapsController.default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces$ActionGetSearchPlacesErrorBySearchPlacesErrorCode", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SearchPlacesOnPlaceSelect_Callback$vars", [{
name: "SearchPlacesObj",
attrName: "searchPlacesObjInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "SearchPlacesId",
attrName: "searchPlacesIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Name",
attrName: "nameInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Coordinates",
attrName: "coordinatesInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Address",
attrName: "addressInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SearchPlacesOnError_Callback$vars", [{
name: "SearchPlacesObj",
attrName: "searchPlacesObjInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "SearchPlacesId",
attrName: "searchPlacesIdInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ErrorCode",
attrName: "errorCodeInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ExtraErrorMessage",
attrName: "extraErrorMessageInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SetApiKey$vars", [{
name: "MapAPIKey",
attrName: "mapAPIKeyInLocal",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("OutSystemsMaps.SearchPlaces.SearchPlaces.SubscribeEvents$getCallbackHandlerJSResult", [{
name: "SearchPlacesOnError_Callback",
attrName: "searchPlacesOnError_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}, {
name: "SearchPlacesOnPlaceSelect_Callback",
attrName: "searchPlacesOnPlaceSelect_CallbackOut",
mandatory: true,
dataType: OS.DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS.Controller.ControllerFactory(Controller, OutSystemsMapsLanguageResources);




