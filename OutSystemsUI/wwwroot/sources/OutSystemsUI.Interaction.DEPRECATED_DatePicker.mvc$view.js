import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Label as OSWidgets$Label, Input as OSWidgets$Input, Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DEPRECATED_DatePicker.mvc$controller.js";
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
return [$if((model.variables.inputWidgetIdIn === OS.BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "wcag-hide-text",
targetWidget: "DateInput",
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0em4b0bnWUWSmZBLzg0EIg#Value", "Calendar"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
"data-inline": "True"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
style: "form-control calendar-input",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.inputVarVar, function (value) {
model.variables.inputVarVar = value;
}),
_idProps: {
service: idService,
name: "DateInput"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Calendar.Style"), function () {
return (("calendar" + ((((model.variables.selectIntervalIn && !(model.variables.startDateVar.equals(OS.BuiltinFunctions.nullDate()))) && model.variables.endDateVar.equals(OS.BuiltinFunctions.nullDate()))) ? (" interval") : (""))) + ((model.variables.showWeekNumbersIn) ? (" week-numbers") : ("")));
}, function () {
return model.variables.selectIntervalIn;
}, function () {
return model.variables.startDateVar;
}, function () {
return model.variables.endDateVar;
}, function () {
return model.variables.showWeekNumbersIn;
}),
visible: true,
_idProps: {
service: idService,
name: "Calendar"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._selectIntervalInDataFetchStatus, model.variables._showWeekNumbersInDataFetchStatus)
})];
}, function () {
return [];
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_DatePicker",
functionKey: "55d9aa8c-ee5e-43e2-a14f-5629a3b1f707",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DEPRECATED_DatePicker",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.DEPRECATED_Moment.js", "scripts/OutSystemsUI.UserScripts.DEPRECATED_Calendar.js"];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
