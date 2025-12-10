import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.ActionSheet.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.ActionSheet.mvc$controller.js";
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
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onCancelClick$Action(controller.callContext(eventHandlerContext));
});
;
}
},
extendedProperties: {
"aria-hidden": model.getCachedValue(idService.getId("ActionSheetContainer.aria-hidden"), function () {
return ((model.variables.isOpenIn) ? ("false") : ("true"));
}, function () {
return model.variables.isOpenIn;
}),
"aria-expanded": model.getCachedValue(idService.getId("ActionSheetContainer.aria-expanded"), function () {
return ((model.variables.isOpenIn) ? ("true") : ("false"));
}, function () {
return model.variables.isOpenIn;
}),
"aria-live": "polite",
"aria-atomic": "true"
},
style: (("action-sheet-container" + " ") + model.variables.extendedClassIn),
visible: true,
_idProps: {
service: idService,
name: "ActionSheetContainer"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "action-sheet-background",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: ("action-sheet" + " OSAutoMarginTop"),
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "menu"
},
style: "action-sheet-buttons",
visible: true,
_idProps: {
service: idService,
name: "ActionSheetButtons"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button1,
style: "action-sheet-actions ph",
_idProps: {
service: idService,
name: "Button1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button2,
style: "action-sheet-actions ph",
_idProps: {
service: idService,
name: "Button2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button3,
style: "action-sheet-actions ph",
_idProps: {
service: idService,
name: "Button3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button4,
style: "action-sheet-actions ph",
_idProps: {
service: idService,
name: "Button4"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button5,
style: "action-sheet-actions ph",
_idProps: {
service: idService,
name: "Button5"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: ("action-sheet-cancel" + " OSAutoMarginTop"),
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
tabIndex: model.getCachedValue(idService.getId("ActionSheetCancel.tabindex"), function () {
return ((model.variables.isOpenIn) ? ("0") : ("-1"));
}, function () {
return model.variables.isOpenIn;
})
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onCancelClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn background-white",
visible: true,
_idProps: {
service: idService,
name: "ActionSheetCancel"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nDSSP_x_pU+pHuYXyjsdWQ#Value", "Cancel"))))))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ActionSheet",
functionKey: "4a2ed3b7-d299-41f5-a385-2c9d470299da",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.ActionSheet",
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
