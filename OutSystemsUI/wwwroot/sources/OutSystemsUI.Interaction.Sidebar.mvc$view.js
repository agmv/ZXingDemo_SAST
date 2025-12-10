import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { AdvancedHtml as OSWidgets$AdvancedHtml, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.Sidebar.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.Sidebar.mvc$controller.js";
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
return [createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
className: "osui-sidebar",
name: model.variables.internalConfigsVar.uniqueIdAttr
},
tag: "aside",
_idProps: {
service: idService,
name: "Sidebar"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.header,
style: "osui-sidebar__header ph",
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "osui-sidebar__content ph",
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
codeFunction: "Sidebar",
functionKey: "8dbd8a4f-a81a-4fe1-9206-f0f7e108babe",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.Sidebar",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.OutSystemsUI.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
