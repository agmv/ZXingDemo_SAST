import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder, Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.DatePickerRange.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DatePickerRange.mvc$controller.js";
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
content: _this.props.placeholders.datepicker,
extendedProperties: {
name: model.variables.internal_ConfigsVar.uniqueIdAttr
},
style: "osui-datepicker",
_idProps: {
service: idService,
name: "Datepicker"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-datepicker-a11y wcag-hide-text",
visible: true,
_idProps: {
service: idService,
name: "DatepickerAccessibilityInfo"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EOeKgp5GWkqt+p8c4v8MzQ#Value", "Use arrow down key to open the calendar; Use arrow keys to navigate through calendar days; Use cmd or ctrl + right or left arrow keys to navigate through months; Use cmd or ctrl + up or down arrow keys to navigate through years;"))), $if(true, false, this, function () {
return [];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DatePickerRange",
functionKey: "950628e8-8fbb-4f1a-a106-9137cf710955",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DatePickerRange",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.Flatpickr.js", "scripts/OutSystemsUI.UserScripts.FlatpickrLocale.js", "scripts/OutSystemsUI.UserScripts.OutSystemsUI.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
