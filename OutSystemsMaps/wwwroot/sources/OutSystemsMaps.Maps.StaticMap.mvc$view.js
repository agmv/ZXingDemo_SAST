import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsMaps_Styles_MapCSS_mvc_view from "./OutSystemsMaps.Styles.MapCSS.mvc$view.js";
import ModelFactory from "./OutSystemsMaps.Maps.StaticMap.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Maps.StaticMap.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("_1zkAGo6Vkiwq7DtqMpmxw.Style"), function () {
return ("map-wrapper hide-true-branch" + (((model.variables.internal_ConfigsVar.extendedClassAttr === "")) ? ("") : ((" " + model.variables.internal_ConfigsVar.extendedClassAttr))));
}, function () {
return model.variables.internal_ConfigsVar.extendedClassAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"data-type": "map-container",
name: model.variables.internal_ConfigsVar.uniqueIdAttr
},
style: "map-container map-preview",
visible: true,
_idProps: {
service: idService,
name: "MapContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Image, {
image: OS.Navigation.VersionedURL.getVersionedUrl("img/OutSystemsMaps.MapPreview.jpg"),
style: "staticMap-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "runtime-staticMap-container-hide",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsMaps_Styles_MapCSS_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "4",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "StaticMap",
functionKey: "fb8e4ce1-5f3d-44ab-bb61-71704a7f3494",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Maps.StaticMap",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsMaps.UserScripts.markerclusterer.js", "scripts/OutSystemsMaps.UserScripts.OutSystemsMaps.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsMaps_Styles_MapCSS_mvc_view];
};


return ELEM;
};

export default componentFactory()
