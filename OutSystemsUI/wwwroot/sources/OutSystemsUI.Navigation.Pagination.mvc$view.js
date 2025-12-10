import { withBaseWebBlock, textWidget as $text, getTranslation, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Text as OSWidgets$Text, AdvancedHtml as OSWidgets$AdvancedHtml, Button as OSWidgets$Button, Placeholder as OSWidgets$Placeholder, List as OSWidgets$List, Label as OSWidgets$Label, Input as OSWidgets$Input } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Navigation.Pagination.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Navigation.Pagination.mvc$controller.js";
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
"data-maxrecords": (model.variables.maxRecordsIn).toString(),
"data-selectedpage": (model.variables.selectedPageButtonVar).toString(),
"data-totalpages": (model.variables.totalPagesVar).toString()
},
style: ("pagination " + model.variables.extendedClassIn),
visible: model.variables.isVisibleVar,
_idProps: {
service: idService,
name: "PaginationWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
role: "status",
"aria-live": "polite",
"aria-atomic": "true"
},
gridProperties: {
classes: "OSInline"
},
style: "pagination-counter",
visible: true,
_idProps: {
service: idService,
name: "PaginationRecords"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
"data-testid": "Pagination.RecordNumberFrom"
},
value: ((model.variables.startIndexIn + 1)).toString(),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._startIndexInDataFetchStatus)
}), createElement(OSWidgets$Text, {
extendedProperties: {
"data-trans": "6c08ff2e-126f-45fe-9737-83cf5de0970f",
"data-testid": "Pagination.To"
},
text: [$text(getTranslation("pXwE30aZ60u1odHgwarKxA#Value", " to "))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
"data-testid": "Pagination.RecordNumberTo"
},
value: model.getCachedValue(idService.getId("PostuaGEoES8eAKZ_FQhhA.Value"), function () {
return OS.BuiltinFunctions.longIntegerToText(((OS.BuiltinFunctions.integerToLongInteger((model.variables.maxRecordsIn + model.variables.startIndexIn)).gte(model.variables.totalCountIn)) ? (model.variables.totalCountIn) : (OS.BuiltinFunctions.integerToLongInteger((model.variables.maxRecordsIn + model.variables.startIndexIn)))));
}, function () {
return model.variables.maxRecordsIn;
}, function () {
return model.variables.startIndexIn;
}, function () {
return model.variables.totalCountIn;
}),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._maxRecordsInDataFetchStatus, model.variables._startIndexInDataFetchStatus, model.variables._totalCountInDataFetchStatus)
}), createElement(OSWidgets$Text, {
extendedProperties: {
"data-trans": "f3606a4b-4ae9-4147-bbb5-1f016314d425",
"data-testid": "Pagination.Of.Items"
},
text: [$text(getTranslation("pi29bOzmnECCH4s0wX7adQ#Value", " of "))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
"data-testid": "Pagination.RecordsNumber"
},
value: OS.BuiltinFunctions.longIntegerToText(model.variables.totalCountIn),
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._totalCountInDataFetchStatus)
}), createElement(OSWidgets$Text, {
extendedProperties: {
"data-trans": "7daeb8e1-4b0e-4831-b7ad-c9895d4f2d60",
"data-testid": "Pagination.Items"
},
text: [$text(getTranslation("hlifhXWvEUiM2xnV5qJqWw#Value", " items"))],
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
className: "pagination-container",
"aria-label": OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("ZYzGEXKOyk2N5mkbive_kA#Value.-1003809862.1", "Pagination")
},
tag: "nav",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (model.variables.startIndexIn > 0),
extendedProperties: {
"aria-label": OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("6Qh2nNxJnk+kL86LOyxxag#Value.1688455531.1", "go to previous page")
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.goTo$Action((model.variables.startIndexIn - model.variables.maxRecordsIn), idService.getId("btnPreviousPage"), controller.callContext(eventHandlerContext));
});
;
},
style: "pagination-button",
visible: (model.variables.totalPagesVar > 0),
_idProps: {
service: idService,
name: "btnPreviousPage"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._startIndexInDataFetchStatus)
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.previous,
gridProperties: {
classes: "OSInline"
},
style: "pagination-previous",
_idProps: {
service: idService,
name: "Previous"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: (!(model.variables.showGoToPageIn)),
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._showGoToPageInDataFetchStatus)
}, createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
"aria-label": model.getCachedValue(idService.getId("btnFirstPage.aria-label"), function () {
return (((model.variables.selectedPageButtonVar > 1)) ? (OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("vnO7u9dfQU6j+cP12wFQVA#Value.-874293523.1", "go to page 1")) : (OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("vnO7u9dfQU6j+cP12wFQVA#Value.-995754272.1", "page 1")));
}, function () {
return model.variables.selectedPageButtonVar;
}),
"aria-current": model.getCachedValue(idService.getId("btnFirstPage.aria-current"), function () {
return (((model.variables.selectedPageButtonVar > 1)) ? ("false") : ("true"));
}, function () {
return model.variables.selectedPageButtonVar;
})
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.goTo$Action(0, idService.getId("btnFirstPage"), controller.callContext(eventHandlerContext));
});
;
},
style: model.getCachedValue(idService.getId("btnFirstPage.Style"), function () {
return (((model.variables.selectedPageButtonVar > 1)) ? ("pagination-button") : ("pagination-button is--active"));
}, function () {
return model.variables.selectedPageButtonVar;
}),
visible: (model.variables.totalPagesVar >= 1),
_idProps: {
service: idService,
name: "btnFirstPage"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: "1",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "pagination-button is--ellipsis",
visible: model.getCachedValue(idService.getId("P2VdB7FUD0SBQvf4uiyv2Q.Visible"), function () {
return ((model.variables.isPhoneVar) ? (((model.variables.selectedPageButtonVar > 2) && (model.variables.totalPagesVar >= 5))) : (((model.variables.selectedPageButtonVar > 3) && (model.variables.totalPagesVar >= 5))));
}, function () {
return model.variables.isPhoneVar;
}, function () {
return model.variables.selectedPageButtonVar;
}, function () {
return model.variables.totalPagesVar;
}),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, "..."), createElement(OSWidgets$List, {
animateItems: false,
extendedProperties: {
"disable-virtualization": "True"
},
mode: /*Default*/ 0,
source: model.variables.middleNavigationPagesVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
name: "PaginationList"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
"aria-label": model.getCachedValue(idService.getId("btnPaginationButton.aria-label"), function () {
return (((model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr === model.variables.selectedPageButtonVar)) ? ((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("6jWbcuzhxE+MbP_chOlJ7g#Value.106426225.1", "page ") + (model.variables.selectedPageButtonVar).toString())) : ((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("6jWbcuzhxE+MbP_chOlJ7g#Value.-1690771004.1", "go to page ") + (model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr).toString())));
}, function () {
return model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr;
}, function () {
return model.variables.selectedPageButtonVar;
}),
"aria-current": model.getCachedValue(idService.getId("btnPaginationButton.aria-current"), function () {
return (((model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr === model.variables.selectedPageButtonVar)) ? ("true") : ("false"));
}, function () {
return model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr;
}, function () {
return model.variables.selectedPageButtonVar;
})
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.goTo$Action(model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).startIndexAttr, "", controller.callContext(eventHandlerContext));
});
;
},
style: model.getCachedValue(idService.getId("btnPaginationButton.Style"), function () {
return ((((model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr) !== (model.variables.selectedPageButtonVar))) ? ("pagination-button") : ("pagination-button is--active"));
}, function () {
return model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr;
}, function () {
return model.variables.selectedPageButtonVar;
}),
visible: model.getCachedValue(idService.getId("btnPaginationButton.Visible"), function () {
return (((model.variables.selectedPageButtonVar >= 3)) ? ((model.variables.middleNavigationPagesVar.getCurrentRowNumber(callContext.iterationContext) <= 3)) : (true));
}, function () {
return model.variables.selectedPageButtonVar;
}, function () {
return model.variables.middleNavigationPagesVar.getCurrentRowNumber(callContext.iterationContext);
}),
_idProps: {
service: idService,
name: "btnPaginationButton"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr)]
}, createElement(OSWidgets$Expression, {
value: (model.variables.middleNavigationPagesVar.getCurrent(callContext.iterationContext).pageAttr).toString(),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.selectedPageButtonVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "pagination-button is--ellipsis hide-on-service-studio",
visible: model.getCachedValue(idService.getId("ALy0eFVaxEKDQ0XBQgUPCw.Visible"), function () {
return ((model.variables.isPhoneVar) ? (((model.variables.totalPagesVar > model.variables.selectedPageButtonVar) && (model.variables.totalPagesVar >= 5))) : (((model.variables.totalPagesVar > (model.variables.selectedPageButtonVar + 1)) && (model.variables.totalPagesVar >= 5))));
}, function () {
return model.variables.isPhoneVar;
}, function () {
return model.variables.totalPagesVar;
}, function () {
return model.variables.selectedPageButtonVar;
}),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, "..."), createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
"aria-label": ((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("HRKDiqXjLEyxYt9_gvs4Uw#Value.106426225.1", "page ") + (model.variables.lastPageNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("HRKDiqXjLEyxYt9_gvs4Uw#Value.-1429362217.1", ", is last page")),
"aria-current": model.getCachedValue(idService.getId("buttonLastPage.aria-current"), function () {
return (((model.variables.selectedPageButtonVar === model.variables.lastPageNumberVar)) ? ("true") : ("false"));
}, function () {
return model.variables.selectedPageButtonVar;
}, function () {
return model.variables.lastPageNumberVar;
})
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.goTo$Action((model.variables.totalPagesVar * model.variables.maxRecordsIn), idService.getId("buttonLastPage"), controller.callContext(eventHandlerContext));
});
;
},
style: model.getCachedValue(idService.getId("buttonLastPage.Style"), function () {
return ((((model.variables.selectedPageButtonVar) !== (model.variables.lastPageNumberVar))) ? ("pagination-button") : ("pagination-button is--active"));
}, function () {
return model.variables.selectedPageButtonVar;
}, function () {
return model.variables.lastPageNumberVar;
}),
visible: (model.variables.totalPagesVar > 3),
_idProps: {
service: idService,
name: "buttonLastPage"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.lastPageNumberVar).toString(),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "pagination-input",
visible: model.variables.showGoToPageIn,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._showGoToPageInDataFetchStatus)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "wcag-hide-text ",
targetWidget: "Input_SelectedPageButton",
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (((((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CucftRBUUEqHV8zM_Dw2OA#ValueExpression.1577988586.1", "Current page ") + (model.variables.goToValueVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CucftRBUUEqHV8zM_Dw2OA#ValueExpression.1063177.1", " of ")) + (model.variables.lastPageNumberVar).toString()) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CucftRBUUEqHV8zM_Dw2OA#ValueExpression.-868175786.1", " pages. ")) + OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("CucftRBUUEqHV8zM_Dw2OA#ValueExpression.-118380476.1", "Insert the page number to go to...")),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.inputOnChange$Action(true, controller.callContext(eventHandlerContext));

;
}
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.inputOnChange$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS.DataTypes.DataTypes.Integer, model.variables.goToValueVar, function (value) {
model.variables.goToValueVar = value;
}),
_idProps: {
service: idService,
name: "Input_SelectedPageButton"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "pagination-counter",
visible: true,
_idProps: {
service: idService,
name: "TotalPagesCounter"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
"data-trans": "b207f5ee-aead-4d0c-bbbd-2bc9a6361e2c",
"data-testid": "Pagination.Of.Pages"
},
text: [$text(getTranslation("uBeyH5aSPEyJ3Sabl5Fs1Q#Value", "of "))],
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
"data-testid": "Pagination.Counter"
},
value: ((model.variables.totalPagesVar + 1)).toString(),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
extendedProperties: {
"data-trans": "04fc28b2-d8a4-409b-847f-ebf28e962f60",
"data-testid": "Pagination.Pages"
},
text: [$text(getTranslation("UORHHTCqVk2EUv+9K3dohw#Value", " pages"))],
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Button, {
enabled: (model.variables.selectedPageButtonVar < (model.variables.totalPagesVar + 1)),
extendedProperties: {
"aria-label": OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("XDix4Ax880+cewCxySJSfQ#Value.-1061341073.1", "go to next page")
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.goTo$Action((model.variables.startIndexIn + model.variables.maxRecordsIn), idService.getId("btnNextPage"), controller.callContext(eventHandlerContext));
});
;
},
style: "pagination-button",
visible: (model.variables.totalPagesVar > 0),
_idProps: {
service: idService,
name: "btnNextPage"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.next,
gridProperties: {
classes: "OSInline"
},
style: "pagination-next",
_idProps: {
service: idService,
name: "Next"
},
_widgetRecordProvider: widgetsRecordProvider
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Pagination",
functionKey: "16c74e3e-972a-450e-81f4-1da5b3d8606e",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Navigation.Pagination",
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
