import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsMaps.Styles.LeafletRoutingCSS.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Styles.LeafletRoutingCSS.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, $if(false, false, this, function () {
return [];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "LeafletRoutingCSS",
functionKey: "d728bd84-9355-4b62-b91c-05270c061165",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Styles.LeafletRoutingCSS",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsMaps.Styles.LeafletRoutingCSS.css"];
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
