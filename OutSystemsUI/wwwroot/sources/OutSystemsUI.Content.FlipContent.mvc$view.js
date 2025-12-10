import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.FlipContent.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.FlipContent.mvc$controller.js";
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
name: model.variables.internalConfigsVar.uniqueIdAttr
},
style: "osui-flip-content",
visible: true,
_idProps: {
service: idService,
name: "FlipWrapper"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-flip-content__container",
visible: true,
_idProps: {
service: idService,
name: "FlipContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.internalConfigsVar.isFlippedAttr)), false, this, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.cardFront,
style: "osui-flip-content__container__front",
_idProps: {
service: idService,
name: "CardFront"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.cardBack,
style: "osui-flip-content__container__back",
_idProps: {
service: idService,
name: "CardBack"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "FlipContent",
functionKey: "724a06f1-42b7-4d07-8827-0363998527cc",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.FlipContent",
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
return [];
};


return ELEM;
};

export default componentFactory()
