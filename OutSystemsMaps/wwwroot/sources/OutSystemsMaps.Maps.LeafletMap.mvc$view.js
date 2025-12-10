import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsMaps_Styles_ImagesCSS_mvc_view from "./OutSystemsMaps.Styles.ImagesCSS.mvc$view.js";
import OutSystemsMaps_Styles_MapCSS_mvc_view from "./OutSystemsMaps.Styles.MapCSS.mvc$view.js";
import OutSystemsMaps_Styles_LeafletCSS_mvc_view from "./OutSystemsMaps.Styles.LeafletCSS.mvc$view.js";
import OutSystemsMaps_Styles_LeafletRoutingCSS_mvc_view from "./OutSystemsMaps.Styles.LeafletRoutingCSS.mvc$view.js";
import OutSystemsMaps_Styles_LeafletDrawCSS_mvc_view from "./OutSystemsMaps.Styles.LeafletDrawCSS.mvc$view.js";
import ModelFactory from "./OutSystemsMaps.Maps.LeafletMap.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Maps.LeafletMap.mvc$controller.js";
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
style: model.getCachedValue(idService.getId("bjw4Na038kCFvmn_VwOz1Q.Style"), function () {
return ("map-wrapper" + (((model.variables.internal_ConfigsVar.extendedClassAttr === "")) ? ("") : ((" " + model.variables.internal_ConfigsVar.extendedClassAttr))));
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
style: "map-container provider-leaflet",
visible: true,
_idProps: {
service: idService,
name: "MapContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "map-preview",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "map-preview-ss",
visible: false,
_idProps: {
service: idService,
name: "MapImagePreview"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "control-zoom",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS.Navigation.VersionedURL.getVersionedUrl("img/OutSystemsMaps.controlzoom.png"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "map-preview-message-container",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "map-preview-height",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "map-preview-location",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}))), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.addOns_Placeholder,
style: "map-preview-addons",
_idProps: {
service: idService,
name: "AddOns_Placeholder"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "runtime-map-container",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsMaps_Styles_ImagesCSS_mvc_view, {
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
uuid: "11",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsMaps_Styles_MapCSS_mvc_view, {
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
uuid: "12",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsMaps_Styles_LeafletCSS_mvc_view, {
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
uuid: "13",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsMaps_Styles_LeafletRoutingCSS_mvc_view, {
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
uuid: "14",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsMaps_Styles_LeafletDrawCSS_mvc_view, {
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
uuid: "15",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.events_Placeholder,
style: "map-preview-events",
_idProps: {
service: idService,
name: "Events_Placeholder"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "LeafletMap",
functionKey: "8a41269a-921f-4905-9ab1-cd1a2da04470",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Maps.LeafletMap",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsMaps.UserScripts.Leaflet.js", "scripts/OutSystemsMaps.UserScripts.LeafletDraw.js", "scripts/OutSystemsMaps.UserScripts.LeafletPathDrag.js", "scripts/OutSystemsMaps.UserScripts.LeafletEditable.js", "scripts/OutSystemsMaps.UserScripts.LeafletRoutingMachine.js", "scripts/OutSystemsMaps.UserScripts.markerclusterer.js", "scripts/OutSystemsMaps.UserScripts.OutSystemsMaps.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsMaps_Styles_ImagesCSS_mvc_view, OutSystemsMaps_Styles_MapCSS_mvc_view, OutSystemsMaps_Styles_LeafletCSS_mvc_view, OutSystemsMaps_Styles_LeafletRoutingCSS_mvc_view, OutSystemsMaps_Styles_LeafletDrawCSS_mvc_view];
};


return ELEM;
};

export default componentFactory()
