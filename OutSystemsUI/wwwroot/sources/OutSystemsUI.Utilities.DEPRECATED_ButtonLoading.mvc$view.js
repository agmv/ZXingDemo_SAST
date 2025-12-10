import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Utilities.DEPRECATED_ButtonLoading.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Utilities.DEPRECATED_ButtonLoading.mvc$controller.js";
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
content: _this.props.placeholders.button,
extendedProperties: {
"aria-label": model.getCachedValue(idService.getId("Button.aria-label"), function () {
return ((model.variables.isLoadingIn) ? (OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("56KsdoiGHUSxdwyRc1Cq8Q#Value.2001303836.1", "Loading")) : (""));
}, function () {
return model.variables.isLoadingIn;
}),
role: model.getCachedValue(idService.getId("Button.role"), function () {
return ((model.variables.isLoadingIn) ? ("status") : (""));
}, function () {
return model.variables.isLoadingIn;
}),
"aria-live": "polite",
"aria-atomic": "true"
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Button.Style"), function () {
return ((("osui-deprecated " + ((model.variables.isLoadingIn) ? (" is--loading") : (""))) + ((model.variables.showLoadingAndLabelIn) ? (" btn-show-label") : (""))) + (((model.variables.extendedClassIn === "")) ? ("") : ((" " + model.variables.extendedClassIn))));
}, function () {
return model.variables.isLoadingIn;
}, function () {
return model.variables.showLoadingAndLabelIn;
}, function () {
return model.variables.extendedClassIn;
}),
_idProps: {
service: idService,
name: "Button"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isLoadingInDataFetchStatus, model.variables._showLoadingAndLabelInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_ButtonLoading",
functionKey: "674138cc-2ee5-4c1d-b4a2-ba120f547fd8",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Utilities.DEPRECATED_ButtonLoading",
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
