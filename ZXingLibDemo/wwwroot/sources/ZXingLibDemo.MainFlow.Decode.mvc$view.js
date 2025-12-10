import { withBaseWebBlock, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Upload as OSWidgets$Upload, Image as OSWidgets$Image, Container as OSWidgets$Container, Icon as OSWidgets$Icon, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, List as OSWidgets$List, ListItem as OSWidgets$ListItem, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsMediumLeft.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Content_CardItem_mvc_view from "./OutSystemsUI.Content.CardItem.mvc$view.js";
import OutSystemsUI_Interaction_LightboxImage_mvc_view from "./OutSystemsUI.Interaction.LightboxImage.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import ModelFactory from "./ZXingLibDemo.MainFlow.Decode.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.MainFlow.Decode.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as Extension_ZXingLibModel from "./Extension.ZXingLib.model.js";
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
return [createElement(OSWidgets$Upload, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
accept: /*Image*/ 0,
fileContent: model.createVariable(OS.DataTypes.DataTypes.BinaryData, model.variables.barcodeBinaryDataVar, function (value) {
model.variables.barcodeBinaryDataVar = value;
}),
fileName: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.filenameVar, function (value) {
model.variables.filenameVar = value;
}),
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "upload upload-image-withoverlay",
_idProps: {
service: idService,
name: "Upload1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
defaultImage: OS.Navigation.VersionedURL.getVersionedUrl("img/ZXingLibDemo.User.png"),
extendedProperties: {
style: "height: Auto;"
},
gridProperties: {
width: "Auto"
},
imageContent: model.variables.barcodeBinaryDataVar,
style: "shadow-s",
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "change-image",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "camera",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}), "Change")), createElement(OSWidgets$Container, {
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
targetWidget: "Input_FormatHint",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Barcode format hint", createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "margin-left-s",
Position: ZXingLibDemoModel.staticEntities.position.right
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
uuid: "8",
alias: "2"
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Use this hint to indicate the expected format of the barcode, e.g. EAN_13, IMB, etc. In some situations this hint is actually necessary for ZXing to be able to detect the barcode.")];
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
prompt: "e.g. EAN_13, IMB, PHARMA_CODE, etc.",
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.formatHintVar, function (value) {
model.variables.formatHintVar = value;
}),
_idProps: {
service: idService,
name: "Input_FormatHint"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.filenameVar) !== ("")),
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.decode$Action(false, controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Decode"), createElement(OSWidgets$Button, {
enabled: ((model.variables.filenameVar) !== ("")),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.decode$Action(true, controller.callContext(eventHandlerContext));
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
}, "Decode Multi"))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(model.variables.decodeBarcodeDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: false,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.decodeBarcodeDataAct.barcodesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Content_CardItem_mvc_view, {
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
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "17",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
left: new Widget.PlaceholderContent(function () {
return [$if(!(OS.DataTypes.areBinaryNulls(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).rawBytesAttr, OS.BuiltinFunctions.nullBinary())), false, this, function () {
return [createElement(OutSystemsUI_Interaction_LightboxImage_mvc_view, {
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
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "18",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
thumbnail: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
imageContent: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).detectedBarcodeAttr,
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).detectedBarcodeAttr)]
})];
}, function () {
return [];
})];
}),
title: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).valueAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)
})];
}),
right: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ZXingLibDemoModel.staticEntities.size.small,
Shape: ZXingLibDemoModel.staticEntities.shape.softRounded,
Color: ZXingLibDemoModel.staticEntities.color.orange
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "21",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).formatAttr,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).formatAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).formatAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).valueAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).detectedBarcodeAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).rawBytesAttr)]
}), $if((!(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading5 margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Metadata"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "key"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "value")];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr.getCurrent(callContext.iterationContext).keyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr.getCurrent(callContext.iterationContext).keyAttr,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr.getCurrent(callContext.iterationContext).valueAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr.getCurrent(callContext.iterationContext).valueAttr,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)]
}))];
}, function () {
return [];
})];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).metadataAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).formatAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).valueAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).detectedBarcodeAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut.getCurrent(callContext.iterationContext).rawBytesAttr)]
})];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.decodeBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.decodeBarcodeDataAct.barcodesOut), asPrimitiveValue(model.variables.decodeBarcodeDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.formatHintVar), asPrimitiveValue(model.variables.filenameVar), asPrimitiveValue(model.variables.barcodeBinaryDataVar)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Decode",
functionKey: "055ff008-50f8-42fb-9853-00b84324a31f",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "MainFlow.Decode",
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
return [OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Content_CardItem_mvc_view, OutSystemsUI_Interaction_LightboxImage_mvc_view, OutSystemsUI_Content_Tag_mvc_view];
};


return ELEM;
};

export default componentFactory()
