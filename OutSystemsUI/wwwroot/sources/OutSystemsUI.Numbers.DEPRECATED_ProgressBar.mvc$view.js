import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Numbers.DEPRECATED_ProgressBar.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Numbers.DEPRECATED_ProgressBar.mvc$controller.js";
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
tabIndex: "0",
role: "progressbar",
"aria-valuemin": "0",
"aria-valuemax": "100",
"aria-valuenow": (model.variables.progressIn).toString(),
"aria-label": "progressbar"
},
style: (((("progress-bar osui-deprecated" + " border-radius-") + model.variables.shapeIn) + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._shapeInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: model.getCachedValue(idService.getId("qWzvS19XhUWP4rjDuxjwow.style"), function () {
return ((("height: " + (model.variables.heightIn).toString()) + "px;") + ((((!(model.variables.animateInitialProgressIn)) || model.variables.animatedVar)) ? ((("width: " + (model.variables.progressIn).toString()) + "%;")) : ("width: 0;")));
}, function () {
return model.variables.heightIn;
}, function () {
return model.variables.animateInitialProgressIn;
}, function () {
return model.variables.animatedVar;
}, function () {
return model.variables.progressIn;
})
},
style: ((("progress background-" + model.variables.colorIn) + " border-radius-") + model.variables.shapeIn),
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._colorInDataFetchStatus, model.variables._shapeInDataFetchStatus)
}), createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
style: "progress-bar-text",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: model.getCachedValue(idService.getId("6Sj0xj6kA0qQZm8IESB8lw.Value"), function () {
return ((((model.variables.textIn) !== (""))) ? (model.variables.textIn) : (((model.variables.progressIn).toString() + "%")));
}, function () {
return model.variables.textIn;
}, function () {
return model.variables.progressIn;
}),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._textInDataFetchStatus, model.variables._progressInDataFetchStatus)
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_ProgressBar",
functionKey: "6cf954e5-d810-4b44-a697-649cb0d78733",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Numbers.DEPRECATED_ProgressBar",
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
