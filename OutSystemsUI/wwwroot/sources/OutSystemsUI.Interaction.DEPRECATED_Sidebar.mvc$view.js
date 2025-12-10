import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { AdvancedHtml as OSWidgets$AdvancedHtml, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Utilities_TouchEvents_mvc_view from "./OutSystemsUI.Utilities.TouchEvents.mvc$view.js";
import ModelFactory from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DEPRECATED_Sidebar.mvc$controller.js";
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
return [createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
className: model.getCachedValue(idService.getId("Sidebar.class"), function () {
return ((("sidebar" + ((model.variables.isOpenIn) ? (" sidebar-open") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isOpenIn;
}, function () {
return model.variables.extendedClassIn;
}),
role: "complementary",
"aria-haspopup": "true",
tabIndex: model.getCachedValue(idService.getId("Sidebar.tabindex"), function () {
return ((model.variables.isOpenIn) ? ("0") : ("-1"));
}, function () {
return model.variables.isOpenIn;
}),
"aria-hidden": model.getCachedValue(idService.getId("Sidebar.aria-hidden"), function () {
return ((model.variables.isOpenIn) ? ("false") : ("true"));
}, function () {
return model.variables.isOpenIn;
})
},
tag: "aside",
_idProps: {
service: idService,
name: "Sidebar"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.header,
style: "sidebar-header padding ph",
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
style: "sidebar-content padding",
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}), $if(false, false, this, function () {
return [];
}, function () {
return [$if(model.variables.needsDragVar, false, this, function () {
return [createElement(OutSystemsUI_Utilities_TouchEvents_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Sidebar")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
move$Action: function (xIn, yIn, offsetXIn, offsetYIn, evtIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureMove$Action(xIn, yIn, offsetXIn, offsetYIn, evtIn, controller.callContext(eventHandlerContext));

;
},
start$Action: function (xIn, yIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureStart$Action(xIn, yIn, controller.callContext(eventHandlerContext));

;
},
end$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.gestureEnd$Action(offsetXIn, offsetYIn, timeTakenIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "3",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_Sidebar",
functionKey: "fa6ceac7-9b3a-4821-a8ee-33ca5bc6f5cc",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DEPRECATED_Sidebar",
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
