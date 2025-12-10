import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.FloatingActions.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.FloatingActions.mvc$controller.js";
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
return controller.toggleClick$Action(controller.callContext(eventHandlerContext));
});
;
}
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("G9JDl_3xN0mAlPt+68SuzA.Style"), function () {
return ("floating-overlay " + (((!(model.variables.isOpenVar))) ? ("") : (" is--open")));
}, function () {
return model.variables.isOpenVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "menubar"
},
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("FloatingActions.Style"), function () {
return (((("floating-actions-wrapper" + (((!(model.variables.isOpenVar))) ? ("") : (" is--open"))) + (((!(model.variables.isInsideBottomBarVar))) ? ("") : (" bottom-bar-exists"))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isOpenVar;
}, function () {
return model.variables.isInsideBottomBarVar;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "FloatingActions"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.items,
extendedProperties: {
"aria-hidden": model.getCachedValue(idService.getId("Items.aria-hidden"), function () {
return ((model.variables.isOpenVar) ? ("false") : ("true"));
}, function () {
return model.variables.isOpenVar;
}),
role: "menu"
},
style: "floating-items",
_idProps: {
service: idService,
name: "Items"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.button,
extendedProperties: {
role: "menuitem",
tabIndex: "0",
"aria-expanded": model.getCachedValue(idService.getId("Button.aria-expanded"), function () {
return ((model.variables.isOpenVar) ? ("true") : ("false"));
}, function () {
return model.variables.isOpenVar;
}),
"aria-haspopup": "true",
"aria-label": model.getCachedValue(idService.getId("Button.aria-label"), function () {
return ((model.variables.isOpenVar) ? (OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("GIz2P7I5J0qsipaGa1e6Fg#Value.-126484825.1", "Close menu")) : (OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("GIz2P7I5J0qsipaGa1e6Fg#Value.-803054251.1", "Open menu")));
}, function () {
return model.variables.isOpenVar;
})
},
style: "floating-button",
_idProps: {
service: idService,
name: "Button"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "FloatingActions",
functionKey: "fa304e38-44cb-43a4-b315-909c6826c078",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.FloatingActions",
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
