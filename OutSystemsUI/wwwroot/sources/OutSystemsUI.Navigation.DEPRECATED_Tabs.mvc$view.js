import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Utilities_TouchEvents_mvc_view from "./OutSystemsUI.Utilities.TouchEvents.mvc$view.js";
import ModelFactory from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Navigation.DEPRECATED_Tabs.mvc$controller.js";
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
style: model.getCachedValue(idService.getId("tabs.Style"), function () {
return (((((("osui-deprecated tabs" + " ") + ((model.variables.isJustifiedIn) ? (" justified") : (""))) + (((!(model.variables.isVerticalIn))) ? (" tabs-horizontal") : (" tabs-vertical"))) + (((!(model.variables.isRightIn))) ? ("") : (" tabs-header-right"))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isJustifiedIn;
}, function () {
return model.variables.isVerticalIn;
}, function () {
return model.variables.isRightIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "tabs"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isJustifiedInDataFetchStatus, model.variables._isVerticalInDataFetchStatus, model.variables._isRightInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.header,
extendedProperties: {
role: "tablist"
},
style: "tabs-header",
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(model.variables.isWebAppVar, false, this, function () {
return [];
}, function () {
return [$if((!(model.variables.isVerticalIn)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tabs-overlay",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tabs-content",
visible: true,
_idProps: {
service: idService,
name: "tabscontent"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: model.getCachedValue(idService.getId("Content.Style"), function () {
return ("tabs-content-wrapper no-transition" + (((!(model.variables.isLayoutNativeVar))) ? (" no-transform") : ("")));
}, function () {
return model.variables.isLayoutNativeVar;
}),
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}))), $if((!(model.variables.isWebAppVar)), false, this, function () {
return [$if(false, false, this, function () {
return [];
}, function () {
return [createElement(OutSystemsUI_Utilities_TouchEvents_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("tabscontent")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, controller.callContext(eventHandlerContext));
});
;
},
start$Action: function (xIn, yIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureStart$Action(xIn, yIn, controller.callContext(eventHandlerContext));

;
},
move$Action: function (xIn, yIn, offsetXIn, offsetYIn, evtIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureMove$Action(xIn, yIn, offsetXIn, offsetYIn, evtIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "5",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_Tabs",
functionKey: "997c16d1-7112-466a-8c69-13fc494e6e86",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Navigation.DEPRECATED_Tabs",
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
return [OutSystemsUI_Utilities_TouchEvents_mvc_view];
};


return ELEM;
};

export default componentFactory()
