import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Navigation.TimelineItem.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Navigation.TimelineItem.mvc$controller.js";
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
role: "listitem"
},
style: model.getCachedValue(idService.getId("96901qZm7EaVtIZ3SZz7gA.Style"), function () {
return ((("timeline-item" + ((model.variables.isActiveIn) ? (" active") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isActiveIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isActiveInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.left,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Left.Style"), function () {
return ("ph timeline-left" + ((model.variables.isActiveIn) ? (" text-primary-color") : ("")));
}, function () {
return model.variables.isActiveIn;
}),
_idProps: {
service: idService,
name: "Left"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isActiveInDataFetchStatus)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "timeline-icon",
visible: true,
_idProps: {
service: idService,
name: "TimelineIcon"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("NCGhlR37sk6vkMjwm9BEdw.Style"), function () {
return ("timeline-icon-line" + ((model.variables.isWebAppVar) ? ("") : (" background-primary-color")));
}, function () {
return model.variables.isWebAppVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.icon,
gridProperties: {
classes: "OSInline"
},
style: ("timeline-icon-container background-" + model.variables.colorIn),
_idProps: {
service: idService,
name: "Icon"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._colorInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "timeline-content",
visible: true,
_idProps: {
service: idService,
name: "TimelineContent"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.title,
style: model.getCachedValue(idService.getId("Title.Style"), function () {
return (((!(model.variables.isWebAppVar))) ? (("bold" + ((model.variables.isActiveIn) ? (" text-primary-color") : ("")))) : (""));
}, function () {
return model.variables.isWebAppVar;
}, function () {
return model.variables.isActiveIn;
}),
_idProps: {
service: idService,
name: "Title"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isActiveInDataFetchStatus)
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "timeline-content-inner",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.right,
gridProperties: {
classes: "OSInline"
},
style: "ph timeline-right",
_idProps: {
service: idService,
name: "Right"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "TimelineItem",
functionKey: "558b8633-fcbe-470f-9c6b-e13e0b3ca54a",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Navigation.TimelineItem",
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
