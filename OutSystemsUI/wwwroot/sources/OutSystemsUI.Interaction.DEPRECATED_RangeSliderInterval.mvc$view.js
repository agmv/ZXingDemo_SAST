import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.mvc$controller.js";
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
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"data-disabled": model.getCachedValue(idService.getId("g9VH5xmZc02dIAMltwA2+Q.data-disabled"), function () {
return OS.BuiltinFunctions.toLower((model.variables.isDisabledIn ? "True" : "False"));
}, function () {
return model.variables.isDisabledIn;
})
},
style: (("range-slider noUi-wrapper SliderInterval" + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: model.getCachedValue(idService.getId("RangeSliderInterval.style"), function () {
return ("height: " + ((model.variables.isVerticalIn) ? (((model.variables.verticalHeightIn).toString() + "px")) : ("")));
}, function () {
return model.variables.isVerticalIn;
}, function () {
return model.variables.verticalHeightIn;
})
},
style: model.getCachedValue(idService.getId("RangeSliderInterval.Style"), function () {
return ((model.variables.showPipsIn) ? ("noUi-pips-margin") : (""));
}, function () {
return model.variables.showPipsIn;
}),
visible: true,
_idProps: {
service: idService,
name: "RangeSliderInterval"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._showPipsInDataFetchStatus)
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_RangeSliderInterval",
functionKey: "1ebad60c-679e-4c22-a619-91174473508b",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DEPRECATED_RangeSliderInterval",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsUI.Interaction.DEPRECATED_RangeSliderInterval.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.wNumb.js", "scripts/OutSystemsUI.UserScripts.DEPRECATED_NoUISlider.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
