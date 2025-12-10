import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Private.ApplicationLoadEvents.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Private.ApplicationLoadEvents.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsUIModel from "./OutSystemsUI.model.js";
import * as OutSystemsUIController from "./OutSystemsUI.controller.js";

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
return createElement("div", props.rootNodeProperties);
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ApplicationLoadEvents",
functionKey: "e90e438e-4ef3-4e36-bc75-f3cbb3c2b15e",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Private.ApplicationLoadEvents",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return [];
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
