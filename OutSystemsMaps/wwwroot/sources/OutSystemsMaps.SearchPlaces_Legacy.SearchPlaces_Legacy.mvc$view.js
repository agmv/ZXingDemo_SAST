import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder, Image as OSWidgets$Image, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsMaps_Styles_Legacy_PlacesCSS_mvc_view from "./OutSystemsMaps.Styles_Legacy.PlacesCSS.mvc$view.js";
import ModelFactory from "./OutSystemsMaps.SearchPlaces_Legacy.SearchPlaces_Legacy.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.SearchPlaces_Legacy.SearchPlaces_Legacy.mvc$controller.js";
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
extendedProperties: {
name: model.variables.uniqueIdVar
},
gridProperties: {
classes: "OSInline",
width: "auto"
},
style: "ss-searchPlaces",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.input_Placeholder,
style: "ss-searchPlaces-placeholder",
_idProps: {
service: idService,
name: "Input_Placeholder"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ss-searchPlaces-dropdown",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS.Navigation.VersionedURL.getVersionedUrl("img/OutSystemsMaps.searchPlacesIcon.png"),
style: "ss-searchPlaces-dropdown-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "ss-searchPlaces-dropdown-bold",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-weight: bold;"
},
text: ["OutSystems US"],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "ss-searchPlaces-dropdown-text",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Thomson Place, Boston, MA, USA"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ss-searchPlaces-styles",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsMaps_Styles_Legacy_PlacesCSS_mvc_view, {
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
uuid: "8",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "SearchPlaces_Legacy",
functionKey: "a094a342-e9bb-4948-9be4-fde07e7d4422",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "SearchPlaces_Legacy.SearchPlaces_Legacy",
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
return [OutSystemsMaps_Styles_Legacy_PlacesCSS_mvc_view];
};


return ELEM;
};

export default componentFactory()
