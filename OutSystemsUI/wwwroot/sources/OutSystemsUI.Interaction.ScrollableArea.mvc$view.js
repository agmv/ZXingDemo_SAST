import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.ScrollableArea.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Content.Style"), function () {
return (((("scrollable-area-content " + model.variables.orientationIn) + "-scroll ") + (((model.variables.scrollbarStyleIn === OutSystemsUIModel.staticEntities.scrollbarStyle.compact)) ? ("compact") : ((((model.variables.scrollbarStyleIn === OutSystemsUIModel.staticEntities.scrollbarStyle.none)) ? ("none") : (""))))) + (((model.variables.extendedClassIn === "")) ? ("") : ((" " + model.variables.extendedClassIn))));
}, function () {
return model.variables.orientationIn;
}, function () {
return model.variables.scrollbarStyleIn;
}, function () {
return model.variables.extendedClassIn;
}),
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._orientationInDataFetchStatus, model.variables._scrollbarStyleInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ScrollableArea",
functionKey: "52c33e9f-72b4-4d92-9f0c-01c51e409a2b",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.ScrollableArea",
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
