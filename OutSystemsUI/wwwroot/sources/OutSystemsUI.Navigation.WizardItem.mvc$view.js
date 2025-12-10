import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Navigation.WizardItem.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Navigation.WizardItem.mvc$controller.js";
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
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.triggerClick$Action(controller.callContext(eventHandlerContext));
});
;
},
onKeyPress: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wizardItemOnKeypress$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
role: "tab",
tabIndex: "0"
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("WizardWrapperItem.Style"), function () {
return (((("wizard-wrapper-item" + (((model.variables.statusIn === OS.BuiltinFunctions.nullTextIdentifier())) ? ("") : ((" " + model.variables.statusIn)))) + ((model.variables.useTopLabelIn) ? (" label-top") : (" label-bottom"))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.statusIn;
}, function () {
return model.variables.useTopLabelIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "WizardWrapperItem"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._statusInDataFetchStatus, model.variables._useTopLabelInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "wizard-item-icon-wrapper",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.icon,
style: "wizard-item-icon",
_idProps: {
service: idService,
name: "Icon"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.label,
extendedProperties: {
"aria-current": model.getCachedValue(idService.getId("Label.aria-current"), function () {
return (((model.variables.statusIn === OutSystemsUIModel.staticEntities.steps.active)) ? ("step") : (""));
}, function () {
return model.variables.statusIn;
})
},
style: "wizard-item-label ph",
_idProps: {
service: idService,
name: "Label"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "WizardItem",
functionKey: "a464a45b-2897-42b1-ab7d-a8ca3ccc3d1c",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Navigation.WizardItem",
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
