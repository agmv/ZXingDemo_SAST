import { withBaseWebScreen, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view from "./ZXingLibDemo.Layouts.LayoutTopMenu.mvc$view.js";
import ZXingLibDemo_Common_Menu_mvc_view from "./ZXingLibDemo.Common.Menu.mvc$view.js";
import { createElement } from "react";
import { Link as OSWidgets$Link, Form as OSWidgets$Form, Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Interaction_AnimatedLabel_mvc_view from "./OutSystemsUI.Interaction.AnimatedLabel.mvc$view.js";
import ModelFactory from "./ZXingLibDemo.Common.UserProfile.mvc$model.js";
import ControllerFactory from "./ZXingLibDemo.Common.UserProfile.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as ZXingLibDemoModel from "./ZXingLibDemo.model.js";
import * as ZXingLibDemoController from "./ZXingLibDemo.controller.js";
import * as System_Model from "./System_.model.js";
import {default as ZXingLibDemoClientVariables} from "./ZXingLibDemo.clientVariables.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view, {
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(ZXingLibDemo_Common_Menu_mvc_view, {
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return ["Your profile"];
}),
actions: new Widget.PlaceholderContent(function () {
return [$if(model.variables.isExternalVar, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS.Transitions.createTransition(OS.Transitions.TransitionAnimation.Default),
url: OS.Navigation.generateScreenURL("ZXingLibDemo", "ChangePassword", {}),
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Change your password")];
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "4",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
name: "EmailLabel"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Email"), createElement(OSWidgets$Expression, {
value: model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_AnimatedLabel_mvc_view, {
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
uuid: "9",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
label: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
name: "NameLabel"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Name")];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (!(model.variables.isExternalVar)),
extendedProperties: {
tabIndex: "1"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_NameOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Text, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.isExternalVar), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)]
})), $if(model.variables.isExternalVar, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Button, {
enabled: model.variables.isButtonEnabledVar,
extendedProperties: {
tabIndex: "2"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveChangesOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
name: "SaveChangesButton"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Save changes")];
})];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.isExternalVar), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr)]
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.isExternalVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "UserProfile",
functionKey: "d1f92804-a4fa-4d9e-a9cd-6ae1223130e4",
functionOwnerName: "ZXingLibDemo",
functionOwnerKey: "61918b7a-e496-4b63-992b-b83299b21e43",
screen: ""
};
},
displayName: "Common.UserProfile",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return "Your profile";
}
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsUI.OutSystemsUI.css", "css/ZXingLibDemo.ZXingLibDemo.css", "css/ZXingLibDemo.ZXingLibDemo.extra.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ZXingLibDemo_Layouts_LayoutTopMenu_mvc_view, ZXingLibDemo_Common_Menu_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_AnimatedLabel_mvc_view];
};


return ELEM;
};

export default componentFactory()
