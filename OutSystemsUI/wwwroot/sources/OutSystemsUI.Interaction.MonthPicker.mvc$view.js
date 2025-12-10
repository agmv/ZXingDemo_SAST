import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder, Container as OSWidgets$Container, AdvancedHtml as OSWidgets$AdvancedHtml } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.MonthPicker.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.MonthPicker.mvc$controller.js";
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
content: _this.props.placeholders.monthPicker,
extendedProperties: {
name: model.variables.internal_ConfigsVar.uniqueIdAttr
},
style: "osui-monthpicker",
_idProps: {
service: idService,
name: "MonthPicker"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-monthpicker-a11y wcag-hide-text",
visible: true,
_idProps: {
service: idService,
name: "MonthPickerAccessibilityInfo"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XCj+U4g5pUebt75PgJVZKg#Value", "In order to be able to navigate through calendar with keyboard key:")), createElement(OSWidgets$AdvancedHtml, {
tag: "ul",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$AdvancedHtml, {
tag: "li",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("U3USctDCzU+hVFFCib4_6w#Value", "Use cmd or ctrl + right/left arrow keys to navigate through months;"))), createElement(OSWidgets$AdvancedHtml, {
tag: "li",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NjGSsgVONkOTKZiBZyawfA#Value", "Use cmd or ctrl + up/down arrow keys to navigate through years;"))))), $if(true, false, this, function () {
return [];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "MonthPicker",
functionKey: "c9a58908-0ad9-407c-a6d1-fd7a86e10760",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.MonthPicker",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.Flatpickr.js", "scripts/OutSystemsUI.UserScripts.FlatpickrMonthPlugin.js", "scripts/OutSystemsUI.UserScripts.FlatpickrLocale.js", "scripts/OutSystemsUI.UserScripts.OutSystemsUI.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
