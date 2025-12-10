import { withBaseWebBlock, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Image as OSWidgets$Image, Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsMediumLeft.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ModelFactory from "./ZXingLibDemo.MainFlow.EncodeMessageVoice.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.MainFlow.EncodeMessageVoice.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import {default as ZXingLibDemoClientVariables} from "./ZXingLibDemo.clientVariables.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form ",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ZXingLibDemoModel.staticEntities.breakColumns.all
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if(model.variables.messageBarcodeDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Image, {
imageContent: model.variables.messageBarcodeDataAct.imageOut,
style: "shadow-s",
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.messageBarcodeDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ZXingLibDemoModel.staticEntities.breakColumns.all
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "3",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 0px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Email2",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Email"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Email, model.variables.emailVar, function (value) {
model.variables.emailVar = value;
}),
_idProps: {
service: idService,
name: "Input_Email2"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PhoneNumber2",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, "PhoneNumber"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Phone*/ 6,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.PhoneNumber, model.variables.phoneNumberVar, function (value) {
model.variables.phoneNumberVar = value;
}),
_idProps: {
service: idService,
name: "Input_PhoneNumber2"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.phoneNumberVar), asPrimitiveValue(model.variables.emailVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_SMS",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, "SMS"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.sMSVar, function (value) {
model.variables.sMSVar = value;
}),
_idProps: {
service: idService,
name: "Input_SMS"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.encodePhoneOnClick$Action("call", controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encode Call"), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.encodePhoneOnClick$Action("facetime", controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encode Facetime"), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.encodePhoneOnClick$Action("email", controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encode Email"), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.encodePhoneOnClick$Action("sms", controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encode SMS"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.sMSVar), asPrimitiveValue(model.variables.phoneNumberVar), asPrimitiveValue(model.variables.emailVar), asPrimitiveValue(model.variables.messageBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.messageBarcodeDataAct.imageOut), asPrimitiveValue(model.variables.messageBarcodeDataAct.isDataFetchedAttr)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "EncodeMessageVoice",
functionKey: "c5a8de1b-3b67-4dc2-871f-0ba781c7c291",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "MainFlow.EncodeMessageVoice",
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
return [OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view];
};


return ELEM;
};

export default componentFactory()
