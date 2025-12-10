import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.Alert.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.Alert.mvc$controller.js";
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
role: model.getCachedValue(idService.getId("Alert.role"), function () {
return ((((model.variables.alertTypeIn === OutSystemsUIModel.staticEntities.alert.error) || (model.variables.alertTypeIn === OutSystemsUIModel.staticEntities.alert.warning))) ? ("alert") : ("status"));
}, function () {
return model.variables.alertTypeIn;
}),
"aria-live": "polite",
"aria-atomic": "true",
tabIndex: "0"
},
style: (((("alert" + " ") + model.variables.alertTypeIn) + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
name: "Alert"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._alertTypeInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true"
},
gridProperties: {
classes: "OSInline"
},
style: "alert-icon",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.alertTypeIn === OutSystemsUIModel.staticEntities.alert.success), false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if((model.variables.alertTypeIn === OutSystemsUIModel.staticEntities.alert.info), false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "info-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if((model.variables.alertTypeIn === OutSystemsUIModel.staticEntities.alert.error), false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon3"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "warning",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon4"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.messageText,
style: "alert-message",
_idProps: {
service: idService,
name: "MessageText"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Alert",
functionKey: "3f398694-7451-4ab4-ad1d-b27e38ed9490",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.Alert",
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
