import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Content.UserAvatar.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Content.UserAvatar.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, $if(OS.DataTypes.areBinaryNulls(model.variables.imageIn, OS.BuiltinFunctions.nullBinary()), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
"aria-label": model.getCachedValue(idService.getId("7f6YjdTQxkC4Pxv1mZ0Zag.aria-label"), function () {
return ((OS.Injector.resolve(OS.ServiceNames.TranslationsService).getMessage("ZjdCYX5OCUuwF54zTTqTTw#Value.-549939496.1", "user initials, ") + OS.BuiltinFunctions.substr(OS.BuiltinFunctions.trim(model.variables.nameIn), 0, 1)) + (((OS.BuiltinFunctions.index(OS.BuiltinFunctions.trim(model.variables.nameIn), " ", 0, false, false) > (-1))) ? (OS.BuiltinFunctions.substr(OS.BuiltinFunctions.trim(model.variables.nameIn), (OS.BuiltinFunctions.index(OS.BuiltinFunctions.trim(model.variables.nameIn), " ", 0, false, false) + 1), 1)) : ("")));
}, function () {
return model.variables.nameIn;
}),
role: "img"
},
style: model.getCachedValue(idService.getId("7f6YjdTQxkC4Pxv1mZ0Zag.Style"), function () {
return ((((((("avatar " + ((((model.variables.sizeIn) !== (OS.BuiltinFunctions.nullTextIdentifier()))) ? ((" avatar-" + model.variables.sizeIn)) : (""))) + " ") + "border-radius-") + model.variables.shapeIn) + ((model.variables.isLightIn) ? ((((((" " + "background-") + model.variables.colorIn) + "-lightest text-") + model.variables.colorIn) + "-darker")) : (((" " + "background-") + model.variables.colorIn)))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.sizeIn;
}, function () {
return model.variables.shapeIn;
}, function () {
return model.variables.isLightIn;
}, function () {
return model.variables.colorIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._sizeInDataFetchStatus, model.variables._shapeInDataFetchStatus, model.variables._isLightInDataFetchStatus, model.variables._colorInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: model.getCachedValue(idService.getId("+D_RQ3IXnEqBKRHWtTlI+Q.Value"), function () {
return (OS.BuiltinFunctions.substr(OS.BuiltinFunctions.trim(model.variables.nameIn), 0, 1) + (((OS.BuiltinFunctions.index(OS.BuiltinFunctions.trim(model.variables.nameIn), " ", 0, false, false) > (-1))) ? (OS.BuiltinFunctions.substr(OS.BuiltinFunctions.trim(model.variables.nameIn), (OS.BuiltinFunctions.index(OS.BuiltinFunctions.trim(model.variables.nameIn), " ", 0, false, false) + 1), 1)) : ("")));
}, function () {
return model.variables.nameIn;
}),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._nameInDataFetchStatus)
}))];
}, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: model.variables.nameIn
},
imageContent: model.variables.imageIn,
style: model.getCachedValue(idService.getId("e9VXyGkMykejiuHggtOyPw.Style"), function () {
return ((((("avatar" + ((((model.variables.sizeIn) !== (OS.BuiltinFunctions.nullTextIdentifier()))) ? ((" avatar-" + model.variables.sizeIn)) : (""))) + " border-radius-") + model.variables.shapeIn) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.sizeIn;
}, function () {
return model.variables.shapeIn;
}, function () {
return model.variables.extendedClassIn;
}),
type: /*Binary*/ 2,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._imageInDataFetchStatus),
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._sizeInDataFetchStatus, model.variables._shapeInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "UserAvatar",
functionKey: "8fc25ace-aad9-4e38-805d-8882d7d9165a",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Content.UserAvatar",
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
