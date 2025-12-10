import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Advanced.DropdownServerSide.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Advanced.DropdownServerSide.mvc$controller.js";
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
name: model.variables.internalConfigsVar.uniqueIdAttr
},
style: "osui-dropdown-serverside",
visible: true,
_idProps: {
service: idService,
name: "Dropdown"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-dropdown-serverside__selected-values-wrapper",
visible: true,
_idProps: {
service: idService,
name: "SelectedValuesWrapper"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.selectedValues,
style: "osui-dropdown-serverside__selected-values",
_idProps: {
service: idService,
name: "SelectedValues"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"data-uniqueid": model.variables.internalConfigsVar.uniqueIdAttr
},
style: "osui-dropdown-serverside__balloon osui-balloon",
visible: true,
_idProps: {
service: idService,
name: "Balloon"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-dropdown-serverside__balloon-container",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-dropdown-serverside__balloon-search-wrapper",
visible: true,
_idProps: {
service: idService,
name: "BalloonSearchWrapper"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.balloonSearchInput,
style: "osui-dropdown-serverside__balloon-search ph",
_idProps: {
service: idService,
name: "BalloonSearchInput"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.balloonSearchInputIcon,
style: "osui-dropdown-serverside__balloon-search-icon ph",
_idProps: {
service: idService,
name: "BalloonSearchInputIcon"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.balloonContent,
style: "osui-dropdown-serverside__balloon-content",
_idProps: {
service: idService,
name: "BalloonContent"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.balloonFooter,
style: "osui-dropdown-serverside__balloon-footer ph",
_idProps: {
service: idService,
name: "BalloonFooter"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DropdownServerSide",
functionKey: "55cca43f-dd56-4203-aab3-7bdb57042dc6",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Advanced.DropdownServerSide",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.OutSystemsUI.js", "scripts/OutSystemsUI.UserScripts.FloatingUICore.js", "scripts/OutSystemsUI.UserScripts.FloatingUIDom.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
