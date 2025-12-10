import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.DEPRECATED_FlipContent.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.DEPRECATED_FlipContent.mvc$controller.js";
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
tabIndex: "0"
},
style: model.getCachedValue(idService.getId("FlipWrapper.Style"), function () {
return ((("osui-deprecated flip-content" + (((!(model.variables.isFlippedIn))) ? ("") : (" flipped"))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isFlippedIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "FlipWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isFlippedInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.toggleFlip$Action(controller.callContext(eventHandlerContext));
});
;
}
},
extendedProperties: {
tabIndex: "-1",
role: "button",
"data-flipped": (model.variables.isFlippedIn ? "True" : "False")
},
style: "flip-content-container",
visible: true,
_idProps: {
service: idService,
name: "FlipContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.isFlippedIn)), false, this, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.cardFront,
extendedProperties: {
"aria-hidden": model.getCachedValue(idService.getId("CardFront.aria-hidden"), function () {
return ((model.variables.isFlippedIn) ? ("true") : ("false"));
}, function () {
return model.variables.isFlippedIn;
})
},
style: "flip-content-front",
_idProps: {
service: idService,
name: "CardFront"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.cardBack,
extendedProperties: {
"aria-hidden": model.getCachedValue(idService.getId("CardBack.aria-hidden"), function () {
return ((model.variables.isFlippedIn) ? ("false") : ("true"));
}, function () {
return model.variables.isFlippedIn;
})
},
style: "flip-content-back",
_idProps: {
service: idService,
name: "CardBack"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_FlipContent",
functionKey: "6c247e15-dadb-4256-aa37-2d35c63b07cf",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.DEPRECATED_FlipContent",
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
