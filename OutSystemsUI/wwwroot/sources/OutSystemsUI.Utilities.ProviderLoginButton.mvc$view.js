import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Button as OSWidgets$Button, Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_InlineSVG_mvc_view from "./OutSystemsUI.Utilities.InlineSVG.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsUI.Utilities.ProviderLoginButton.mvc$model.js";
import ControllerFactory from "./OutSystemsUI.Utilities.ProviderLoginButton.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClick$Action(controller.callContext(eventHandlerContext));

;
},
style: model.getCachedValue(idService.getId("QYmexbH3Kk6Q26uiMbo9AQ.Style"), function () {
return ((((((("btn btn-provider-login " + model.variables.identityProviderIn) + " ") + model.variables.shapeIn) + " ") + ((model.variables.iconOnlyIn) ? ("btn-provider-login-logo-only") : (""))) + " ") + model.variables.extendedClassIn);
}, function () {
return model.variables.identityProviderIn;
}, function () {
return model.variables.shapeIn;
}, function () {
return model.variables.iconOnlyIn;
}, function () {
return model.variables.extendedClassIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._identityProviderInDataFetchStatus, model.variables._shapeInDataFetchStatus, model.variables._iconOnlyInDataFetchStatus, model.variables._extendedClassInDataFetchStatus)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "btn-provider-login-logo",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [$if((model.variables.identityProviderIn === OutSystemsUIModel.staticEntities.identityProvider.apple), false, this, function () {
return [createElement(OutSystemsUI_Utilities_InlineSVG_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SVGCode: "<svg width=\"16\" height=\"19\" viewBox=\"0 0 16 19\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"><path d=\"M15.6647 14.8068C15.3774 15.4706 15.0374 16.0816 14.6434 16.6434C14.1064 17.4092 13.6667 17.9393 13.3279 18.2337C12.8026 18.7169 12.2398 18.9644 11.6371 18.9784C11.2045 18.9784 10.6827 18.8553 10.0753 18.6055C9.46598 18.3568 8.906 18.2337 8.39396 18.2337C7.85696 18.2337 7.28102 18.3568 6.66499 18.6055C6.04801 18.8553 5.55099 18.9855 5.17098 18.9984C4.59305 19.023 4.017 18.7685 3.442 18.2337C3.07501 17.9135 2.61598 17.3647 2.06607 16.5871C1.47607 15.7567 0.991001 14.7939 0.610992 13.6961C0.204016 12.5104 0 11.3622 0 10.2507C0 8.97735 0.27507 7.87913 0.82603 6.95883C1.25904 6.21962 1.83509 5.6365 2.55606 5.20842C3.27703 4.78035 4.05605 4.56221 4.89497 4.54825C5.35401 4.54825 5.95597 4.69028 6.70403 4.96941C7.44998 5.24947 7.92895 5.3915 8.13894 5.3915C8.29594 5.3915 8.82802 5.22543 9.73003 4.89435C10.583 4.58731 11.3029 4.46018 11.8927 4.51025C13.4908 4.63926 14.6915 5.26941 15.49 6.40468C14.0607 7.27092 13.3537 8.48418 13.3677 10.0406C13.3806 11.2529 13.8203 12.2618 14.6845 13.0628C15.0761 13.4346 15.5134 13.7219 16 13.926C15.8945 14.2321 15.7831 14.5253 15.6647 14.8068ZM11.9994 0.380108C11.9994 1.33033 11.6524 2.21754 10.9606 3.03874C10.1258 4.01498 9.11599 4.5791 8.02099 4.49008C8.00704 4.37609 7.99894 4.25611 7.99894 4.13003C7.99894 3.21782 8.39596 2.24158 9.10098 1.44337C9.45297 1.03922 9.90063 0.70318 10.4435 0.435112C10.9852 0.171044 11.4976 0.025008 11.9795 0C11.9936 0.127029 11.9994 0.254079 11.9994 0.380108Z\" fill=\"black\"/></svg>"
},
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
name: "Apple",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [$if((model.variables.identityProviderIn === OutSystemsUIModel.staticEntities.identityProvider.facebook), false, this, function () {
return [createElement(OutSystemsUI_Utilities_InlineSVG_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SVGCode: "<svg width=\"20\" height=\"20\" viewBox=\"0 0 20 20\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"><path d=\"M20 10.0611C20 4.50451 15.5229 0 10 0C4.47715 0 0 4.50451 0 10.0611C0 15.0829 3.65686 19.2452 8.4375 20V12.9694H5.89844V10.0611H8.4375V7.84452C8.4375 5.32296 9.93043 3.93012 12.2146 3.93012C13.3087 3.93012 14.4531 4.12663 14.4531 4.12663V6.6026H13.1921C11.9499 6.6026 11.5625 7.37815 11.5625 8.17381V10.0611H14.3359L13.8926 12.9694H11.5625V20C16.3431 19.2452 20 15.0829 20 10.0611Z\" fill=\"#1877F2\"/></svg>"
},
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
name: "Facebook",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OutSystemsUI_Utilities_InlineSVG_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SVGCode: "<svg width=\"20\" height=\"20\" viewBox=\"0 0 20 20\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M20 10.2274C20 9.51826 19.9351 8.83643 19.8145 8.18188H10.2041V12.0501H15.6958C15.4592 13.3001 14.7403 14.3592 13.6596 15.0683V17.5774H16.9573C18.8868 15.8365 20 13.2728 20 10.2274Z\" fill=\"#4285F4\"/><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M10.2042 20C12.9593 20 15.2691 19.1045 16.9574 17.5772L13.6597 15.0681C12.7459 15.6681 11.5771 16.0227 10.2042 16.0227C7.54649 16.0227 5.29695 14.2636 4.49454 11.8999H1.08545V14.4908C2.76448 17.759 6.21532 20 10.2042 20Z\" fill=\"#34A853\"/><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M4.49443 11.9001C4.29035 11.3001 4.1744 10.6592 4.1744 10.0001C4.1744 9.341 4.29035 8.70009 4.49443 8.10008V5.50916H1.08534C0.394249 6.85917 0 8.38645 0 10.0001C0 11.6137 0.394249 13.141 1.08534 14.491L4.49443 11.9001Z\" fill=\"#FBBC05\"/><path fill-rule=\"evenodd\" clip-rule=\"evenodd\" d=\"M10.2042 3.9773C11.7023 3.9773 13.0474 4.48185 14.1049 5.47277L17.0317 2.60456C15.2645 0.990916 12.9547 0 10.2042 0C6.21532 0 2.76449 2.24093 1.08545 5.50913L4.49454 8.10006C5.29695 5.7364 7.54649 3.9773 10.2042 3.9773Z\" fill=\"#EA4335\"/></svg>"
},
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
name: "Google",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "btn-provider-login-text",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pkkBFWlTBkKR_5aWTYykaA#Value", "Continue with ")), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "btn-provider-login-text-name",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("vTayC01ojkmK5XxehkeAGA.Value"), function () {
return (((model.variables.identityProviderIn === OutSystemsUIModel.staticEntities.identityProvider.apple)) ? ("Apple") : ((((model.variables.identityProviderIn === OutSystemsUIModel.staticEntities.identityProvider.facebook)) ? ("Facebook") : ((((model.variables.identityProviderIn === OutSystemsUIModel.staticEntities.identityProvider.google)) ? ("Google") : ("none"))))));
}, function () {
return model.variables.identityProviderIn;
}),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS.Model.calculateDataFetchStatus(model.variables._identityProviderInDataFetchStatus)
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "ProviderLoginButton",
functionKey: "c89a03f6-fa00-4bb9-a79a-774d8fa454fb",
functionOwnerName: "OutSystemsUI",
functionOwnerKey: "8be17f2a-431c-4958-b894-c77b988a7271",
screen: ""
};
},
displayName: "Utilities.ProviderLoginButton",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/OutSystemsUI.UserScripts.OutSystemsUI.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_InlineSVG_mvc_view];
};


return ELEM;
};

export default componentFactory()
