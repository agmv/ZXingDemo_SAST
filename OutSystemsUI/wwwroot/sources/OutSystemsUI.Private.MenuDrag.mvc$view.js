import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import OutSystemsUI_Utilities_TouchEvents_mvc_view from "./OutSystemsUI.Utilities.TouchEvents.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Private.MenuDrag.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Private.MenuDrag.mvc$controller.js";
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
return [createElement(OutSystemsUI_Utilities_TouchEvents_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: model.variables.menuIdIn,
_widgetIdInDataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._menuIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function (xIn, yIn, offsetXIn, offsetYIn, timeTakenIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureEnd$Action(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(offsetXIn)), OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(offsetYIn)), timeTakenIn, controller.callContext(eventHandlerContext));

;
},
start$Action: function (xIn, yIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureStart$Action(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(xIn)), OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(yIn)), controller.callContext(eventHandlerContext));

;
},
move$Action: function (xIn, yIn, offsetXIn, offsetYIn, evtIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.gestureMove$Action(OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(xIn)), OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(yIn)), OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(offsetXIn)), OS.BuiltinFunctions.decimalToInteger(OS.BuiltinFunctions.trunc(offsetYIn)), evtIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "MenuDrag",
functionKey: "99cc2beb-5d4d-41af-838d-82eae4e36402",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Private.MenuDrag",
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
