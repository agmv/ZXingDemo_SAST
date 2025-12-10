import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, AdvancedHtml as OSWidgets$AdvancedHtml, Link as OSWidgets$Link, Placeholder as OSWidgets$Placeholder, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Private_LightBox_mvc_view from "./OutSystemsUI.Private.LightBox.mvc$view.js";
import ModelFactory from "./OutSystemsUI.Interaction.LightboxImage.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.LightboxImage.mvc$controller.js";
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
style: (("lightbox-item" + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
name: "LightboxItem"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$AdvancedHtml, {
tag: "figure",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
href: model.variables.imageURLIn,
"data-group": model.variables.groupIn,
"data-zoom": OS.BuiltinFunctions.decimalToText(model.variables.imageZoomIn),
"data-size": "",
"aria-label": model.getCachedValue(idService.getId("31z+J0CNWkaRvU5y7uSVuw.aria-label"), function () {
return ((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("S8G2GmL_0Eeo8g0k6DXhfA#Value.1520983273.1", "Click to open ") + ((((model.variables.titleIn) !== (""))) ? (model.variables.titleIn) : (((((model.variables.groupIn) !== (""))) ? (model.variables.groupIn) : (""))))) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("S8G2GmL_0Eeo8g0k6DXhfA#Value.1445063251.1", " image."));
}, function () {
return model.variables.titleIn;
}, function () {
return model.variables.groupIn;
})
},
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onImgClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.thumbnail,
style: "lightbox-content-thumbnail",
_idProps: {
service: idService,
name: "Thumbnail"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
style: "display: none !important;"
},
tag: "figcaption",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: model.variables.titleIn,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._titleInDataFetchStatus)
})))), createElement(OutSystemsUI_Private_LightBox_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
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
uuid: "6",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "LightboxImage",
functionKey: "120d8541-d847-45a7-a57a-b20cf68b4a15",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.LightboxImage",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.Lightbox.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Private_LightBox_mvc_view];
};


return ELEM;
};

export default componentFactory()
