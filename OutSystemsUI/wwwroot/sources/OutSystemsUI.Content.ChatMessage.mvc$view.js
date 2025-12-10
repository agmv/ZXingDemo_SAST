import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Placeholder as OSWidgets$Placeholder, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.ChatMessage.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.ChatMessage.mvc$controller.js";
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
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("VjFGZ2RcTE+OPnsB3rtx7Q.Style"), function () {
return ((("chat" + (((!(model.variables.displayOnRightIn))) ? (" left") : (" right"))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.displayOnRightIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._displayOnRightInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-live": "polite",
"aria-atomic": "true"
},
style: "wcag-hide-text",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("YKGVnI2EtEOvHleP3K6seg.Value"), function () {
return ((model.variables.statusVisibleVar) ? (model.variables.messageStatusIn) : (""));
}, function () {
return model.variables.statusVisibleVar;
}, function () {
return model.variables.messageStatusIn;
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._messageStatusInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "chat-photo",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.image,
gridProperties: {
classes: "OSInline"
},
_idProps: {
service: idService,
name: "Image"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "chat-message-wrapper",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showStatus$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
"aria-controls": idService.getId("Status"),
role: "button",
tabIndex: "0",
"aria-expanded": model.getCachedValue(idService.getId("Message.aria-expanded"), function () {
return ((model.variables.statusVisibleVar) ? ("true") : ("false"));
}, function () {
return model.variables.statusVisibleVar;
})
},
gridProperties: {
classes: "OSInline"
},
style: "chat-message padding",
visible: true,
_idProps: {
service: idService,
name: "Message"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
gridProperties: {
classes: "OSInline"
},
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
"aria-hidden": "false",
role: "status"
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Status.Style"), function () {
return (("chat-message-status " + ((((model.variables.messageStatusIn) !== (OutSystemsUIModel.staticEntities.messageStatus.hidden))) ? ("") : (" hidden"))) + ((model.variables.isWebAppVar) ? (" ") : (" text-note")));
}, function () {
return model.variables.messageStatusIn;
}, function () {
return model.variables.isWebAppVar;
}),
visible: model.variables.statusVisibleVar,
_idProps: {
service: idService,
name: "Status"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._messageStatusInDataFetchStatus)
}, $if(!(model.variables.timeIn.equals(model.variables.timeEmptyVar)), false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "clock-o",
iconSize: /*FontSize*/ 0,
style: model.getCachedValue(idService.getId("Hvn7YfC0o0SjnVEQI_Pd_g.Style"), function () {
return ("icon " + ((model.variables.isWebAppVar) ? (" padding-right-xs") : (" text-note padding-right")));
}, function () {
return model.variables.isWebAppVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
role: "status"
},
style: model.getCachedValue(idService.getId("1hZGl5A6Z0i36hshwQr7Wg.Style"), function () {
return ((model.variables.isWebAppVar) ? (" padding-right-xs") : (" padding-right"));
}, function () {
return model.variables.isWebAppVar;
}),
value: model.getCachedValue(idService.getId("1hZGl5A6Z0i36hshwQr7Wg.Value"), function () {
return OS.BuiltinFunctions.substr(OS.BuiltinFunctions.timeToText(model.variables.timeIn), 0, 5);
}, function () {
return model.variables.timeIn;
}),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._timeInDataFetchStatus)
})];
}, function () {
return [];
}), $if((model.variables.messageStatusIn === OutSystemsUIModel.staticEntities.messageStatus.sent), false, this, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
role: "status"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon6"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if((model.variables.messageStatusIn === OutSystemsUIModel.staticEntities.messageStatus.received), false, this, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
role: "status"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
role: "status"
},
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon text-green",
visible: true,
_idProps: {
service: idService,
name: "Icon8"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ChatMessage",
functionKey: "8677baf2-1ed0-437e-8e4e-ca1417f004d7",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.ChatMessage",
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
