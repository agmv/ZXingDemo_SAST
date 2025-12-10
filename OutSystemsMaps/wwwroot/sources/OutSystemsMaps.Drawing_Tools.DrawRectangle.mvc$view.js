import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsMaps.Drawing_Tools.DrawRectangle.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Drawing_Tools.DrawRectangle.mvc$controller.js";
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
style: "ss-drawingTools-icon",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
width: "27px"
},
image: OS.Navigation.VersionedURL.getVersionedUrl("img/OutSystemsMaps.ToolRectangle.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DrawRectangle",
functionKey: "b82eb216-b8e2-4042-accf-b1edab7d21af",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Drawing_Tools.DrawRectangle",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
