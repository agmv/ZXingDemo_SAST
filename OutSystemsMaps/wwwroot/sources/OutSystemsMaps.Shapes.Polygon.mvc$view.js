import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsMaps_Shapes_Generic_mvc_view from "./OutSystemsMaps.Shapes.Generic.mvc$view.js";
import ModelFactory from "./OutSystemsMaps.Shapes.Polygon.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Shapes.Polygon.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";

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
name: model.variables.uniqueIdVar
},
gridProperties: {
classes: "OSInline",
width: "auto"
},
style: "ss-shape",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ss-shape-icon",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
width: "25"
},
image: OS.Navigation.VersionedURL.getVersionedUrl("img/OutSystemsMaps.MapPolygon.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.shapeEvents,
style: "ss-shape-events",
_idProps: {
service: idService,
name: "ShapeEvents"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OutSystemsMaps_Shapes_Generic_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ShapeType: OutSystemsMapsModel.staticEntities.shapeType.polygon,
OptionalConfigs: model.getCachedValue(idService.getId("15OGYKIlkEOMAxHifqr3Rw.OptionalConfigs"), function () {
return OS.DataConversion.JSConversions.typeConvertRecord(model.variables.optionalConfigsIn, new OutSystemsMapsModel.ST_f021741499f997a32540fab3dfcdbbfaStructure(), function (source, target) {
target.allowDragAttr = source.allowDragAttr;
target.allowEditAttr = source.allowEditAttr;
target.strokeAttr = source.strokeAttr;
target.fillAttr = source.fillAttr;
return target;
});
}, function () {
return model.variables.optionalConfigsIn;
}),
_optionalConfigsInDataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._optionalConfigsInDataFetchStatus),
UniqueId: model.variables.uniqueIdVar,
Locations: model.variables.locationsIn,
_locationsInDataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._locationsInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClick$Action: function (mapWidgetIdIn, shapeIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClick$Action(mapWidgetIdIn, shapeIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "4",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Polygon",
functionKey: "6dbfd1f4-6166-445a-a086-707f475a8dd8",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Shapes.Polygon",
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
return [OutSystemsMaps_Shapes_Generic_mvc_view];
};


return ELEM;
};

export default componentFactory()
