import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.DEPRECATED_Tooltip.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.DEPRECATED_Tooltip.mvc$controller.js";
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
style: (("osui-deprecated tooltip" + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
name: "TooltipWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
extendedProperties: {
"aria-controls": idService.getId("Tooltip"),
role: "button",
tabIndex: "0",
"aria-expanded": model.getCachedValue(idService.getId("Content.aria-expanded"), function () {
return ((model.variables.isVisibleIn) ? ("true") : ("false"));
}, function () {
return model.variables.isVisibleIn;
}),
"aria-haspopup": "true"
},
gridProperties: {
classes: "OSInline"
},
style: "tooltip-content",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(false, false, this, function () {
return [];
}, function () {
return [$if(model.variables.isVisibleIn, false, this, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.tooltip,
extendedProperties: {
tabIndex: "0",
"aria-hidden": model.getCachedValue(idService.getId("Tooltip.aria-hidden"), function () {
return ((model.variables.isVisibleIn) ? ("false") : ("true"));
}, function () {
return model.variables.isVisibleIn;
}),
"aria-live": "polite",
"aria-atomic": "true",
role: "tooltip"
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("Tooltip.Style"), function () {
return ("tooltip-wrapper" + ((false) ? ("") : ((" " + model.variables.positionIn))));
}, function () {
return model.variables.positionIn;
}),
_idProps: {
service: idService,
name: "Tooltip"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._positionInDataFetchStatus)
})];
}, function () {
return [];
})];
})), $if((model.variables.isVisibleIn && (!(model.variables.isHoverIn))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true"
},
gridProperties: {
classes: "OSInline"
},
style: "tooltip-background",
visible: true,
_idProps: {
service: idService,
name: "TooltipBackground"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_Tooltip",
functionKey: "7bd5a125-92da-45ff-bf30-0fc684a6e66d",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.DEPRECATED_Tooltip",
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
