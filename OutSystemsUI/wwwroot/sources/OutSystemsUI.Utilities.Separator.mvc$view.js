import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Utilities.Separator.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Utilities.Separator.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("kWhV3I81UUyymP3TLEExTA.Style"), function () {
return (((!(model.variables.isVerticalIn))) ? (((("padding-top-" + model.variables.spaceIn) + " padding-bottom-") + model.variables.spaceIn)) : (((("separator-wrapper full-height padding-right-" + model.variables.spaceIn) + " padding-left-") + model.variables.spaceIn)));
}, function () {
return model.variables.isVerticalIn;
}, function () {
return model.variables.spaceIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isVerticalInDataFetchStatus, model.variables._spaceInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("2yAyXVm9l0qeV2aJqaE2cw.Style"), function () {
return (((((("separator" + (((!(model.variables.isVerticalIn))) ? (" separator-horizontal") : (" separator-vertical"))) + " ") + "background-") + model.variables.colorIn) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isVerticalIn;
}, function () {
return model.variables.colorIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isVerticalInDataFetchStatus, model.variables._colorInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Separator",
functionKey: "39080a9d-eba3-40c0-bcd0-df9437a23bd4",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Utilities.Separator",
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
