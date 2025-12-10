import { withBaseWebScreen, Widget, useTracing } from "@outsystems/runtime-view-js";
import ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view from "./ZXingLibDemo.Layouts.LayoutTopMenu.mvc$view.js";
import ZXingLibDemo_Common_Menu_mvc_view from "./ZXingLibDemo.Common.Menu.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Content_Card_mvc_view from "./OutSystemsUI.Content.Card.mvc$view.js";
import { Link as OSWidgets$Link, Icon as OSWidgets$Icon, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import ModelFactory from "./ZXingLibDemo.MainFlow.About.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.MainFlow.About.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import {default as ZXingLibDemoClientVariables} from "./ZXingLibDemo.clientVariables.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(ZXingLibDemo_Common_Menu_mvc_view, {
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
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return ["About"];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Content_Card_mvc_view, {
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
uuid: "2",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return ["ZXing Lib is an OutSystems library available that provides actions that allow you to encode or decode barcodes in different formats: CODE 39, CODE 128, QR, EAN13, EAN8, AZTEC, DATA_MATRIX, etc. through ", createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
target: "_blank"
},
style: "margin-left-none",
transition: OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default),
url: OS.Navigation.generateScreenURL("http://code.google.com/p/zxing/", {}),
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, "ZXing library (namely the .NET port) ", createElement(OSWidgets$Icon, {
gridProperties: {
marginLeft: "0"
},
icon: "external-link",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Text, {
style: "margin-right-none",
text: [".", createElement("br")],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: []
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "About",
functionKey: "390e18bb-c9c7-4fdf-818a-4aedb7928967",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "MainFlow.About",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function () {
return "About";
}
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsUI.OutSystemsUI.css", "css/ZXingLibDemo.ZXingLibDemo.css", "css/ZXingLibDemo.ZXingLibDemo.extra.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view, ZXingLibDemo_Common_Menu_mvc_view, OutSystemsUI_Content_Card_mvc_view];
};


return ELEM;
};

export default componentFactory()
