import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_InlineSVG_mvc_view from "./OutSystemsUI.Utilities.InlineSVG.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Numbers.ProgressCircle.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Numbers.ProgressCircle.mvc$controller.js";
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
extendedProperties: {
name: model.variables.internal_ConfigsVar.uniqueIdAttr
},
style: "osui-progress-circle",
visible: true,
_idProps: {
service: idService,
name: "ProgressCircle"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-progress-circle__container",
visible: true,
_idProps: {
service: idService,
name: "ProgressContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(("HideinPreview" === "True"), false, this, function () {
return [];
}, function () {
return [createElement(OutSystemsUI_Utilities_InlineSVG_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SVGCode: "<svg xmlns=\'http://www.w3.org/2000/svg\'>\r\n<circle class=\'osui-progress-circle__container__trail-path\'></circle>\r\n<circle class=\'osui-progress-circle__container__progress-path\'></circle>\r\n</svg>"
},
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
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "osui-progress-circle__content ph",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ProgressCircle",
functionKey: "ae7a1572-bf6e-49ca-9914-0979235a8c97",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Numbers.ProgressCircle",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.OutSystemsUI.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_InlineSVG_mvc_view];
};


return ELEM;
};

export default componentFactory()
