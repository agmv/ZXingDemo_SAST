import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Navigation.Wizard.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Navigation.Wizard.mvc$controller.js";
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
extendedProperties: {
role: "tablist",
"aria-orientation": model.getCachedValue(idService.getId("Content.aria-orientation"), function () {
return ((model.variables.isVerticalIn) ? ("vertical") : ("horizontal"));
}, function () {
return model.variables.isVerticalIn;
})
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Content.Style"), function () {
return ((("wizard-wrapper display-flex" + " ") + (((!(model.variables.isVerticalIn))) ? ("flex-direction-row") : ("wizard-vertical flex-direction-column"))) + (((model.variables.extendedClassIn === "")) ? ("") : ((" " + model.variables.extendedClassIn))));
}, function () {
return model.variables.isVerticalIn;
}, function () {
return model.variables.extendedClassIn;
}),
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isVerticalInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wizard",
functionKey: "d77eab3d-b0dd-4236-8453-6d0a8c9a770f",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Navigation.Wizard",
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
