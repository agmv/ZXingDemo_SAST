import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.DEPRECATED_AccordionItem.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"data-expanded": model.getCachedValue(idService.getId("SectionItem.data-expanded"), function () {
return OS.BuiltinFunctions.toLower((model.variables.isExpandedIn ? "True" : "False"));
}, function () {
return model.variables.isExpandedIn;
}),
"aria-expanded": model.getCachedValue(idService.getId("SectionItem.aria-expanded"), function () {
return OS.BuiltinFunctions.toLower((model.variables.isExpandedIn ? "True" : "False"));
}, function () {
return model.variables.isExpandedIn;
}),
"aria-disabled": model.getCachedValue(idService.getId("SectionItem.aria-disabled"), function () {
return (((!(model.variables.isDisabledIn))) ? ("false") : ("true"));
}, function () {
return model.variables.isDisabledIn;
}),
role: "tab"
},
style: model.getCachedValue(idService.getId("SectionItem.Style"), function () {
return (((("osui-deprecated section-expandable " + ((model.variables.isExpandedIn) ? (" open is--open") : ("is--closed"))) + ((model.variables.isDisabledIn) ? (" is--disabled") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.isExpandedIn;
}, function () {
return model.variables.isDisabledIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
name: "SectionItem"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._isExpandedInDataFetchStatus, model.variables._isDisabledInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClick$Action(idService.getId("SectionItem"), false, controller.callContext(eventHandlerContext));
});
;
}
},
extendedProperties: {
role: "button",
"aria-hidden": model.getCachedValue(idService.getId("TitleWrapper.aria-hidden"), function () {
return OS.BuiltinFunctions.toLower((model.variables.isDisabledIn ? "True" : "False"));
}, function () {
return model.variables.isDisabledIn;
}),
"aria-expanded": model.getCachedValue(idService.getId("TitleWrapper.aria-expanded"), function () {
return OS.BuiltinFunctions.toLower((model.variables.isExpandedIn ? "True" : "False"));
}, function () {
return model.variables.isExpandedIn;
}),
tabIndex: model.getCachedValue(idService.getId("TitleWrapper.tabindex"), function () {
return (((model.variables.isDisabledIn || (!(model.variables.hasContentVar)))) ? ("-1") : ("0"));
}, function () {
return model.variables.isDisabledIn;
}, function () {
return model.variables.hasContentVar;
}),
"aria-controls": idService.getId("Content")
},
style: "section-expandable-title",
visible: true,
_idProps: {
service: idService,
name: "TitleWrapper"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.title,
style: model.getCachedValue(idService.getId("Title.Style"), function () {
return ("dividers full-width" + ((model.variables.isWebAppVar) ? ("") : (" text-ellipsis")));
}, function () {
return model.variables.isWebAppVar;
}),
_idProps: {
service: idService,
name: "Title"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-hidden": "true"
},
style: "section-expandable-icon",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
tabIndex: model.getCachedValue(idService.getId("ContentWrapper.tabindex"), function () {
return ((model.variables.hasContentVar) ? ("0") : ("-1"));
}, function () {
return model.variables.hasContentVar;
}),
"aria-hidden": model.getCachedValue(idService.getId("ContentWrapper.aria-hidden"), function () {
return ((model.variables.isExpandedIn) ? ("false") : ("true"));
}, function () {
return model.variables.isExpandedIn;
}),
"aria-labelledby": idService.getId("TitleWrapper")
},
style: model.getCachedValue(idService.getId("ContentWrapper.Style"), function () {
return ("section-expandable-content is--collapsed" + ((model.variables.usePaddingIn) ? ("") : (" no-padding")));
}, function () {
return model.variables.usePaddingIn;
}),
visible: true,
_idProps: {
service: idService,
name: "ContentWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._usePaddingInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.content,
extendedProperties: {
role: "tabpanel"
},
_idProps: {
service: idService,
name: "Content"
},
_widgetRecordProvider: widgetsRecordProvider
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_AccordionItem",
functionKey: "a1bcaab8-4538-4050-81c9-8c57ec23dfc8",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.DEPRECATED_AccordionItem",
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
