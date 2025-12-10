import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, AdvancedHtml as OSWidgets$AdvancedHtml } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Interaction.DEPRECATED_Video.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Interaction.DEPRECATED_Video.mvc$controller.js";
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
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClick$Action(controller.callContext(eventHandlerContext));

;
}
},
style: model.getCachedValue(idService.getId("VideoWrapper.Style"), function () {
return ("video-wrapper" + ((model.variables.controlsIn) ? ("") : (" hide-controls")));
}, function () {
return model.variables.controlsIn;
}),
visible: true,
_idProps: {
service: idService,
name: "VideoWrapper"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._controlsInDataFetchStatus)
}, createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
src: model.variables.videoURLIn,
width: model.variables.widthIn,
height: model.variables.heightIn,
muted: model.getCachedValue(idService.getId("Video.muted"), function () {
return ((model.variables.mutedIn) ? ("muted") : (""));
}, function () {
return model.variables.mutedIn;
}),
loop: model.getCachedValue(idService.getId("Video.loop"), function () {
return ((model.variables.loopIn) ? ("loop") : (""));
}, function () {
return model.variables.loopIn;
}),
controls: model.getCachedValue(idService.getId("Video.controls"), function () {
return ((model.variables.controlsIn) ? ("controls") : (""));
}, function () {
return model.variables.controlsIn;
}),
className: model.getCachedValue(idService.getId("Video.class"), function () {
return ("video" + (((model.variables.extendedClassIn === "")) ? ("") : ((" " + model.variables.extendedClassIn))));
}, function () {
return model.variables.extendedClassIn;
}),
autoPlay: model.getCachedValue(idService.getId("Video.autoplay"), function () {
return ((model.variables.autoplayIn) ? ("autoplay") : (""));
}, function () {
return model.variables.autoplayIn;
}),
poster: model.variables.posterURLIn
},
tag: "video",
_idProps: {
service: idService,
name: "Video"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DEPRECATED_Video",
functionKey: "29689e6c-700d-4835-8ce8-3d0198be055f",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Interaction.DEPRECATED_Video",
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
