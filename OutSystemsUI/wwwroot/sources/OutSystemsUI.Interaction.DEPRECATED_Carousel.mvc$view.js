import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Utilities_TouchEvents_mvc_view from "./OutSystemsUI.Utilities.TouchEvents.mvc$view.js";
import OutSystemsUI_Utilities_MouseEvents_mvc_view from "./OutSystemsUI.Utilities.MouseEvents.mvc$view.js";
import ModelFactory from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DEPRECATED_Carousel.mvc$controller.js";
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
style: (("padding: 0 " + (model.variables.paddingIn).toString()) + "px"),
"aria-live": "polite",
"aria-atomic": "True"
},
style: "osui-deprecated carousel init",
visible: true,
_idProps: {
service: idService,
name: "carousel"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "carousel-container",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.carouselItems,
extendedProperties: {
tabIndex: "0",
"aria-live": model.getCachedValue(idService.getId("CarouselItems.aria-live"), function () {
return (((model.variables.autoplayIn === OutSystemsUIModel.staticEntities.autoplay.disabled)) ? ("off") : ("polite"));
}, function () {
return model.variables.autoplayIn;
}),
"aria-atomic": "false"
},
style: "carousel-container-content",
_idProps: {
service: idService,
name: "CarouselItems"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "button",
"aria-label": OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("Tm0JMu3mrUu7ENYpnn+kjA#Value.473077404.1", "Previous Item")
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("PreviousArrow.Style"), function () {
return ("carousel-navigation carousel-navigation-left " + ((model.variables.navigationIn) ? ("") : (" hidden")));
}, function () {
return model.variables.navigationIn;
}),
visible: true,
_idProps: {
service: idService,
name: "PreviousArrow"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._navigationInDataFetchStatus)
}, createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "button",
"aria-label": OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("66qvLNLtf0SDfyVXGpsi3A#Value.-1133226976.1", "Next Item")
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("NextArrow.Style"), function () {
return ("carousel-navigation carousel-navigation-right" + ((model.variables.navigationIn) ? ("") : (" hidden")));
}, function () {
return model.variables.navigationIn;
}),
visible: true,
_idProps: {
service: idService,
name: "NextArrow"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._navigationInDataFetchStatus)
}, createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "navigation"
},
style: model.getCachedValue(idService.getId("+O3MenVcVUabQRQhNXZ1jg.Style"), function () {
return ("carousel-dots-container " + ((model.variables.dotsIn) ? ("") : ("disabled")));
}, function () {
return model.variables.dotsIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._dotsInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "hide-on-service-studio",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.addDragEventsVar, false, this, function () {
return [createElement(OutSystemsUI_Utilities_TouchEvents_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("carousel")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
move$Action: function (xIn, yIn, offsetXIn, offsetYIn, evtIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureMove$Action(offsetXIn, evtIn, offsetYIn, controller.callContext(eventHandlerContext));

;
},
start$Action: function (xIn, yIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureStart$Action(controller.callContext(eventHandlerContext));

;
},
end$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureEnd$Action(offsetXIn, timeTakenIn, 0, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "9",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsUI_Utilities_MouseEvents_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("carousel")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureEnd$Action(offsetXIn, timeTakenIn, 0, controller.callContext(eventHandlerContext));

;
},
start$Action: function (xIn, yIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureStart$Action(controller.callContext(eventHandlerContext));

;
},
move$Action: function (xIn, yIn, offsetXIn, offsetYIn, evtIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureMove$Action(offsetXIn, evtIn, offsetYIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "10",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_Carousel",
functionKey: "1d13818f-fcae-4e73-9a6a-a4110a462263",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DEPRECATED_Carousel",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.DEPRECATED_Carousel.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_TouchEvents_mvc_view, OutSystemsUI_Utilities_MouseEvents_mvc_view];
};


return ELEM;
};

export default componentFactory()
