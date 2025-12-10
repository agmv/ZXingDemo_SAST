import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Adaptive.MasterDetail.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Adaptive.MasterDetail.mvc$controller.js";
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
style: model.getCachedValue(idService.getId("SplitScreenWrapper.Style"), function () {
return ("split-screen-wrapper" + ((((model.variables.heightIn) !== (""))) ? (" is--full-height") : (" is--screen-size")));
}, function () {
return model.variables.heightIn;
}),
visible: true,
_idProps: {
service: idService,
name: "SplitScreenWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._heightInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.leftContent,
gridProperties: {
classes: "OSInline"
},
style: "split-left",
_idProps: {
service: idService,
name: "LeftContent"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "split-right",
visible: true,
_idProps: {
service: idService,
name: "SplitRight"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
style: "split-right-close",
visible: true,
_idProps: {
service: idService,
name: "SplitRightClose"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onDetailClose$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
name: "SplitRightCloseLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
name: "Icon1"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "split-right-content",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.isPhoneVar)), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "wcag-hide-text focus-item top",
value: "",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.rightContent,
style: "split-right--placeholder",
_idProps: {
service: idService,
name: "RightContent"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((!(model.variables.isPhoneVar)), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "wcag-hide-text focus-item bottom",
value: "",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "MasterDetail",
functionKey: "446147b1-9704-4d0c-913c-046a4b89bed8",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Adaptive.MasterDetail",
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
