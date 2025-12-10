import { withBaseWebBlock, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Image as OSWidgets$Image, Container as OSWidgets$Container, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsMediumLeft.mvc$view.js";
import { createElement } from "react";
import OutSystemsMaps_Maps_Map_mvc_view from "./OutSystemsMaps.Maps.Map.mvc$view.js";
import OutSystemsMaps_Map_Events_MapEvent_mvc_view from "./OutSystemsMaps.Map_Events.MapEvent.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ModelFactory from "./ZXingLibDemo.MainFlow.EncodeGeoLocation.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.MainFlow.EncodeGeoLocation.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
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
return [$if(model.variables.geolocationBarcodeDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Image, {
imageContent: model.variables.geolocationBarcodeDataAct.imageOut,
style: "shadow-s",
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.geolocationBarcodeDataAct.dataFetchStatusAttr)
})];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsMaps_Maps_Map_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "400"
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
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
addOns_Placeholder: Widget.PlaceholderContent.Empty,
events_Placeholder: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsMaps_Map_Events_MapEvent_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
EventName: ZXingLibDemoModel.staticEntities.mapEventTriggered.click
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
action$Action: function (mapWidgetIdIn, eventNameIn, mapObjIn, latLngIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.mapEventAction$Action(latLngIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "5",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
licenseWarning: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "license-link",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "license-link",
text: ["https://developers.google.com/maps/documentation/javascript/get-api-key"],
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
})), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "8",
alias: "4"
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Latitude",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Latitude"), createElement(OSWidgets$Input, {
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
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.latitudeVar, function (value) {
model.variables.latitudeVar = value;
}),
_idProps: {
service: idService,
name: "Input_Latitude"
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Longitude",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Longitude"), createElement(OSWidgets$Input, {
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
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.longitudeVar, function (value) {
model.variables.longitudeVar = value;
}),
_idProps: {
service: idService,
name: "Input_Longitude"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.longitudeVar), asPrimitiveValue(model.variables.latitudeVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.geolocationEncodeOnClick$Action(controller.callContext(eventHandlerContext));
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
}, "Encode"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.longitudeVar), asPrimitiveValue(model.variables.latitudeVar), asPrimitiveValue(model.variables.geolocationBarcodeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.geolocationBarcodeDataAct.imageOut), asPrimitiveValue(model.variables.geolocationBarcodeDataAct.isDataFetchedAttr)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "EncodeGeoLocation",
functionKey: "cd78c720-d13d-41bd-b7ce-b1e7c08314f4",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "MainFlow.EncodeGeoLocation",
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
return [OutSystemsUI_Adaptive_ColumnsMediumLeft_mvc_view, OutSystemsMaps_Maps_Map_mvc_view, OutSystemsMaps_Map_Events_MapEvent_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view];
};


return ELEM;
};

export default componentFactory()
