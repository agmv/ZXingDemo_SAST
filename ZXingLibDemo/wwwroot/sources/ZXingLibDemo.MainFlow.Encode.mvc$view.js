import { withBaseWebBlock, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Image as OSWidgets$Image, Container as OSWidgets$Container, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, TextArea as OSWidgets$TextArea, Expression as OSWidgets$Expression, Input as OSWidgets$Input, Checkbox as OSWidgets$Checkbox, Icon as OSWidgets$Icon, Upload as OSWidgets$Upload, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsMediumLeft.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ZXingLibDemo.MainFlow.Encode.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.MainFlow.Encode.mvc$controller.js";
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
style: "form",
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
return [$if(model.variables.encodeBarcodeImageDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Image, {
imageContent: model.variables.encodeBarcodeImageDataAct.imageOut,
style: "shadow-s",
type: /*Binary*/ 2,
_idProps: {
service: idService,
name: "BarcodeImage2"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.encodeBarcodeImageDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Code",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Code"), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
enabled: true,
labels: function (elem) {
return elem;
},
list: model.variables.getCodesDataAct.formatsOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_CodeOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem;
},
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.barcodeFormatVar, function (value) {
model.variables.barcodeFormatVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Code"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getCodesDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_TextVar",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Value"), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: 0px;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 5000,
style: "form-control",
textLines: 5,
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.valueVar, function (value) {
model.variables.valueVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_TextVar"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: var(--space-m);"
},
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-size-xs text-info",
value: model.getCachedValue(idService.getId("JA7CwisQFkuirqYTUJA4Vg.Value"), function () {
return ("Characters: " + (OS.BuiltinFunctions.length(model.variables.valueVar)).toString());
}, function () {
return model.variables.valueVar;
}),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "11",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Width",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Width"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Integer, model.variables.widthVar, function (value) {
model.variables.widthVar = value;
}),
_idProps: {
service: idService,
name: "Input_Width"
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Height",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Height"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Integer, model.variables.heightVar, function (value) {
model.variables.heightVar = value;
}),
_idProps: {
service: idService,
name: "Input_Height"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Margin",
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Margin"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: 0px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Integer, model.variables.marginVar, function (value) {
model.variables.marginVar = value;
}),
_idProps: {
service: idService,
name: "Input_Margin"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.marginVar), asPrimitiveValue(model.variables.heightVar), asPrimitiveValue(model.variables.widthVar)]
}), createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "21",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
targetWidget: "Checkbox3",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, "No padding"), createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS.DataTypes.DataTypes.Boolean, model.variables.noPaddingVar, function (value) {
model.variables.noPaddingVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Encoding",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encoding"), createElement(OSWidgets$Input, {
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
prompt: "e.g. UTF-8, ISO-8859-1",
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.encodingVar, function (value) {
model.variables.encodingVar = value;
}),
_idProps: {
service: idService,
name: "Input_Encoding"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [$if((model.variables.barcodeFormatVar === "QR_CODE"), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_QRCodeVersion",
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, "QR Code version"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: 0px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Integer, model.variables.qRCodeVersionVar, function (value) {
model.variables.qRCodeVersionVar = value;
}),
_idProps: {
service: idService,
name: "Input_QRCodeVersion"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if((model.variables.barcodeFormatVar === "DATA_MATRIX"), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_ForceShape",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Force Shape"), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: 0px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.forceShapeVar, function (value) {
model.variables.forceShapeVar = value;
}),
_idProps: {
service: idService,
name: "Input_ForceShape"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.forceShapeVar), asPrimitiveValue(model.variables.qRCodeVersionVar), asPrimitiveValue(model.variables.barcodeFormatVar), asPrimitiveValue(model.variables.encodingVar), asPrimitiveValue(model.variables.noPaddingVar)]
}), createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
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
uuid: "34",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if(((((((((model.variables.barcodeFormatVar === "ITF") || (model.variables.barcodeFormatVar === "CODE_128")) || (model.variables.barcodeFormatVar === "EAN_8")) || (model.variables.barcodeFormatVar === "EAN_13")) || (model.variables.barcodeFormatVar === "UPC_A")) || (model.variables.barcodeFormatVar === "UPC_E")) || (model.variables.barcodeFormatVar === "DATA_MATRIX")) || (model.variables.barcodeFormatVar === "QR_CODE")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
targetWidget: "Checkbox2",
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Use GS1 format"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS.DataTypes.DataTypes.Boolean, model.variables.useGS1FormatVar, function (value) {
model.variables.useGS1FormatVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if((((((((((((model.variables.barcodeFormatVar === "CODABAR") || (model.variables.barcodeFormatVar === "CODE_39")) || (model.variables.barcodeFormatVar === "CODE_93")) || (model.variables.barcodeFormatVar === "CODE_128")) || (model.variables.barcodeFormatVar === "EAN_8")) || (model.variables.barcodeFormatVar === "EAN_13")) || (model.variables.barcodeFormatVar === "ITF")) || (model.variables.barcodeFormatVar === "UPC_A")) || (model.variables.barcodeFormatVar === "UPC_E")) || (model.variables.barcodeFormatVar === "PLESSEY")) || (model.variables.barcodeFormatVar === "MSI")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
targetWidget: "Checkbox1",
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Show barcode only"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS.DataTypes.DataTypes.Boolean, model.variables.isPureBarcodeVar, function (value) {
model.variables.isPureBarcodeVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
})];
}),
column3: new Widget.PlaceholderContent(function () {
return [$if((((model.variables.barcodeFormatVar === "AZTEC") || (model.variables.barcodeFormatVar === "PDF_417")) || (model.variables.barcodeFormatVar === "QR_CODE")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_ErrorCorrection",
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Error correction ", createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
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
uuid: "45",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "info",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Specifies what degree of error correction to use, for example in QR Codes. Type depends on the encoder. ", createElement("br"), "            For example for QR codes it can be L (~7% correction), M (~15% correction), Q (~20% correction), and H (~30% correction).", createElement("br"), "            For Aztec it is integer representing the minimal percentage of error correction words. Note: an Aztec symbol should have a minimum of 25% EC words. ", createElement("br"), "            For PDF417 it is integer between 0 and 8"];
})
},
_dependencies: []
})), createElement(OSWidgets$Input, {
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
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.errorCorrectionVar, function (value) {
model.variables.errorCorrectionVar = value;
}),
_idProps: {
service: idService,
name: "Input_ErrorCorrection"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.errorCorrectionVar), asPrimitiveValue(model.variables.isPureBarcodeVar), asPrimitiveValue(model.variables.useGS1FormatVar), asPrimitiveValue(model.variables.barcodeFormatVar)]
}), $if((model.variables.barcodeFormatVar === "QR_CODE"), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
targetWidget: "Input_OverlayImage",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Overlay Image"), createElement(OSWidgets$Upload, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
accept: /*Any*/ 2,
fileContent: model.createVariable(OS.DataTypes.DataTypes.BinaryData, model.variables.overlayImageVar, function (value) {
model.variables.overlayImageVar = value;
}),
fileName: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.filenameVar, function (value) {
model.variables.filenameVar = value;
}),
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "upload",
_idProps: {
service: idService,
name: "Input_OverlayImage"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "paperclip",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("vvwGnSCibEq9uAMfbM1KLA.Value"), function () {
return (((model.variables.filenameVar === "")) ? ("Select file") : (model.variables.filenameVar));
}, function () {
return model.variables.filenameVar;
}),
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.genericEncodeOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Encode"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filenameVar), asPrimitiveValue(model.variables.overlayImageVar), asPrimitiveValue(model.variables.errorCorrectionVar), asPrimitiveValue(model.variables.isPureBarcodeVar), asPrimitiveValue(model.variables.useGS1FormatVar), asPrimitiveValue(model.variables.forceShapeVar), asPrimitiveValue(model.variables.qRCodeVersionVar), asPrimitiveValue(model.variables.encodingVar), asPrimitiveValue(model.variables.noPaddingVar), asPrimitiveValue(model.variables.marginVar), asPrimitiveValue(model.variables.heightVar), asPrimitiveValue(model.variables.widthVar), asPrimitiveValue(model.variables.valueVar), asPrimitiveValue(model.variables.getCodesDataAct.formatsOut), asPrimitiveValue(model.variables.barcodeFormatVar), asPrimitiveValue(model.variables.getCodesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.encodeBarcodeImageDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.encodeBarcodeImageDataAct.imageOut), asPrimitiveValue(model.variables.encodeBarcodeImageDataAct.isDataFetchedAttr)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Encode",
functionKey: "3fe4545e-7f49-4f3a-8776-f7dbc624ba66",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "MainFlow.Encode",
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
return [OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()
