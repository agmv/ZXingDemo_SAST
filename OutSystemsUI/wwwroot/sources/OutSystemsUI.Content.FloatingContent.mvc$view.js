import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.FloatingContent.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.FloatingContent.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("FloatingContent.Style"), function () {
return ((((((("floating-content " + "floating-content-") + model.variables.positionIn) + ((model.variables.useFullWidthIn) ? (" floating-content-full-width") : (""))) + ((model.variables.useFullHeightIn) ? (" floating-content-full-height") : (""))) + ((model.variables.useMarginIn) ? (" floating-content-margin") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.positionIn;
}, function () {
return model.variables.useFullWidthIn;
}, function () {
return model.variables.useFullHeightIn;
}, function () {
return model.variables.useMarginIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "FloatingContent"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._positionInDataFetchStatus, model.variables._useFullWidthInDataFetchStatus, model.variables._useFullHeightInDataFetchStatus, model.variables._useMarginInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "FloatingContent",
functionKey: "2f661817-c5e7-4aee-80d6-5521f8f66189",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.FloatingContent",
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
