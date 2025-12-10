import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.SectionGroup.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.SectionGroup.mvc$controller.js";
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
style: model.getCachedValue(idService.getId("SectionGroup.Style"), function () {
return (((("section-group" + " ") + ((model.variables.hasStickyTitlesIn) ? ("is--sticky") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.hasStickyTitlesIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "SectionGroup"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._hasStickyTitlesInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.sections,
style: model.getCachedValue(idService.getId("Sections.Style"), function () {
return (((model.variables.hasStickyTitlesIn && (!(model.variables.isEdgeVar)))) ? ("sticky") : (""));
}, function () {
return model.variables.hasStickyTitlesIn;
}, function () {
return model.variables.isEdgeVar;
}),
_idProps: {
service: idService,
name: "Sections"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._hasStickyTitlesInDataFetchStatus)
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "SectionGroup",
functionKey: "36b183d9-5fd6-4ebc-94b2-1aab7396d93e",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.SectionGroup",
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
