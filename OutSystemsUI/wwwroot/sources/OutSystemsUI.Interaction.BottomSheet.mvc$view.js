import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, AdvancedHtml as OSWidgets$AdvancedHtml, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.BottomSheet.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.BottomSheet.mvc$controller.js";
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
extendedProperties: {
name: model.variables.internalConfigsVar.uniqueIdAttr
},
style: "osui-bottom-sheet",
visible: true,
_idProps: {
service: idService,
name: "BottomSheet"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
className: "osui-bottom-sheet__header"
},
tag: "header",
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.topBar,
style: "osui-bottom-sheet__header__top-bar",
_idProps: {
service: idService,
name: "TopBar"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "osui-bottom-sheet__content",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-bottom-sheet-overlay",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "BottomSheet",
functionKey: "4fb64c61-8941-44be-b854-da0b608a625b",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.BottomSheet",
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
