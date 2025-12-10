import * as OS from "@outsystems/runtime-core-js";
var ZXingLibDemoModel = {
staticEntities: {
codeDefaults: Object.freeze({
get eAN_8() {return "EAN_8";
},
get cODE_93() {return "CODE_93";
},
get cODE_39() {return "CODE_39";
},
get mSI() {return "MSI";
},
get dATA_MATRIX() {return "DATA_MATRIX";
},
get uPC_A() {return "UPC_A";
},
get aZTEC() {return "AZTEC";
},
get uPC_E() {return "UPC_E";
},
get cODE_128() {return "CODE_128";
},
get eAN_13() {return "EAN_13";
},
get qR_CODE() {return "QR_CODE";
},
get pDF_417() {return "PDF_417";
},
get pLESSEY() {return "PLESSEY";
},
get iTF() {return "ITF";
},
get cODABAR() {return "CODABAR";
}
}),
aIContentType: Object.freeze({
get textContent() {return OS.BuiltinFunctions.integerToLongInteger(1);
},
get imageURL() {return OS.BuiltinFunctions.integerToLongInteger(2);
},
get imageBinary() {return OS.BuiltinFunctions.integerToLongInteger(3);
}
}),
aIRole: Object.freeze({
get system() {return OS.BuiltinFunctions.integerToLongInteger(1);
},
get user() {return OS.BuiltinFunctions.integerToLongInteger(2);
},
get assistant() {return OS.BuiltinFunctions.integerToLongInteger(3);
},
get action() {return OS.BuiltinFunctions.integerToLongInteger(4);
}
}),
sideMenuBehavior: Object.freeze({
get visible() {return "aside-visible";
},
get expandable() {return "aside-expandable";
},
get overlay() {return "aside-overlay";
}
}),
size: Object.freeze({
get medium() {return "medium";
},
get small() {return "small";
}
}),
gutterSize: Object.freeze({
get xXLarge() {return "gutter-xxl";
},
get medium() {return "gutter-m";
},
get none() {return "gutter-none";
},
get extraLarge() {return "gutter-xl";
},
get small() {return "gutter-s";
},
get large() {return "gutter-l";
},
get base() {return "gutter-base";
},
get extraSmall() {return "gutter-xs";
}
}),
orientation: Object.freeze({
get horizontal() {return "horizontal";
},
get vertical() {return "vertical";
}
}),
datePickerTimeFormat: Object.freeze({
get disabled() {return "disabled";
},
get time24hFormat() {return "24";
},
get time12hFormat() {return "12";
}
}),
direction: Object.freeze({
get left() {return "left";
},
get right() {return "right";
}
}),
breakColumns: Object.freeze({
get none() {return "break-none";
},
get first() {return "break-first";
},
get all() {return "break-all";
},
get middle() {return "break-middle";
},
get last() {return "break-last";
}
}),
shape: Object.freeze({
get sharp() {return "none";
},
get softRounded() {return "soft";
},
get rounded() {return "rounded";
}
}),
position: Object.freeze({
get top() {return "top";
},
get left() {return "left";
},
get bottomRight() {return "bottom-right";
},
get bottomLeft() {return "bottom-left";
},
get right() {return "right";
},
get topLeft() {return "top-left";
},
get topRight() {return "top-right";
},
get center() {return "center";
},
get bottom() {return "bottom";
}
}),
trigger: Object.freeze({
get onClick() {return "onclick";
},
get onHover() {return "onhover";
}
}),
space: Object.freeze({
get large() {return "l";
},
get medium() {return "m";
},
get xXLarge() {return "xxl";
},
get extraSmall() {return "xs";
},
get small() {return "s";
},
get base() {return "base";
},
get extraLarge() {return "xl";
},
get none() {return "none";
}
}),
color: Object.freeze({
get neutral9() {return "neutral-9";
},
get grape() {return "grape";
},
get neutral7() {return "neutral-7";
},
get neutral10() {return "neutral-10";
},
get teal() {return "teal";
},
get primary() {return "primary";
},
get neutral4() {return "neutral-4";
},
get neutral8() {return "neutral-8";
},
get indigo() {return "indigo";
},
get orange() {return "orange";
},
get lime() {return "lime";
},
get cyan() {return "cyan";
},
get secondary() {return "secondary";
},
get neutral6() {return "neutral-6";
},
get yellow() {return "yellow";
},
get neutral2() {return "neutral-2";
},
get neutral1() {return "neutral-1";
},
get neutral3() {return "neutral-3";
},
get transparent() {return "transparent";
},
get violet() {return "violet";
},
get blue() {return "blue";
},
get neutral5() {return "neutral-5";
},
get red() {return "red";
},
get pink() {return "pink";
},
get green() {return "green";
},
get neutral0() {return "neutral-0";
}
}),
datePickerWeekDay: Object.freeze({
get monday() {return 1;
},
get saturday() {return 6;
},
get sunday() {return 0;
},
get friday() {return 5;
},
get tuesday() {return 2;
},
get thursday() {return 4;
},
get wednesday() {return 3;
}
}),
mapErrors: Object.freeze({
get cFG_CantChangeParamsStaticMap() {return "MAPS-CFG-02002";
},
get gEN_ToolTypeAlreadyExists() {return "MAPS-GEN-06004";
},
get aPI_FailedGettingShapeRadius() {return "MAPS-API-05004";
},
get lIB_FailedGeocodingLeafletShapeLocations() {return "MAPS-LIB-05002";
},
get lIB_FailedSetDirections() {return "MAPS-LIB-04001";
},
get aPI_FailedUnsubscribeMarkerEvent() {return "MAPS-API-09006";
},
get cFG_InvalidMapId() {return "MAPS-CFG-10005";
},
get lIB_FailedGeocodingMarker() {return "MAPS-LIB-03001";
},
get aPI_FailedNoPluginDirections() {return "MAPS-API-04003";
},
get cFG_APIKeyAlreadySetStaticMap() {return "MAPS-CFG-02001";
},
get cFG_APIKeyDiffersFromPlacesToMaps() {return "MAPS-CFG-01002";
},
get aPI_FailedCreateMarker() {return "MAPS-API-09002";
},
get lIB_InvalidApiKeyStaticMap() {return "MAPS-LIB-02001";
},
get aPI_FailedGettingCenterCoordinates() {return "MAPS-API-01001";
},
get lIB_FailedGeocodingLeafletMarker() {return "MAPS-LIB-03002";
},
get cFG_LocalizationAlreadySetStaticMap() {return "MAPS-CFG-02003";
},
get gEN_InvalidChangePropertyShape() {return "MAPS-GEN-05001";
},
get gEN_UnsupportedEventShape() {return "MAPS-GEN-05002";
},
get gEN_UnsupportedEventMap() {return "MAPS-GEN-01002";
},
get gEN_UnsupportedEventDrawingTools() {return "MAPS-GEN-06003";
},
get gEN_InvalidChangePropertyMap() {return "MAPS-GEN-01001";
},
get cFG_InvalidCircleShapeCenter() {return "MAPS-CFG-05003";
},
get gEN_InvalidChangePropertyDrawingTools() {return "MAPS-GEN-06001";
},
get gEN_InvalidChangePropertyMapStyleId() {return "MAPS-GEN-06006";
},
get gEN_InvalidChangePropertyHeatmapLayer() {return "MAPS-GEN-08001";
},
get gEN_InvalidChangePropertyMarker() {return "MAPS-GEN-03001";
},
get cFG_InvalidPolylineShapeLocations() {return "MAPS-CFG-05001";
},
get gEN_InvalidChangePropertyUseAdvancedMarkers() {return "MAPS-GEN-06005";
},
get aPI_FailedRemoveDirections() {return "MAPS-API-03001";
},
get cFG_InvalidRectangleShapeBounds() {return "MAPS-CFG-05004";
},
get lIB_FailedGeocodingShapeLocations() {return "MAPS-LIB-05001";
},
get aPI_FailedGettingShapePath() {return "MAPS-API-05001";
},
get gEN_InvalidChangePropertyTools() {return "MAPS-GEN-06002";
},
get aPI_PolylineUnsupported() {return "MAPS-GEN-01003";
},
get aPI_FailedGettingShapeCenter() {return "MAPS-API-05003";
},
get cFG_LocalizationAlreadySetMap() {return "MAPS-CFG-01003";
},
get cFG_APIKeyAlreadySetMap() {return "MAPS-CFG-01001";
},
get cFG_InvalidDrawingToolsPosition() {return "MAPS-CFG-06001";
},
get gEN_UnsupportedEventMarker() {return "MAPS-GEN-03002";
},
get aPI_FailedGettingCircleShape() {return "MAPS-API-05002";
},
get gEN_InvalidChangePropertyMarkerClusterer() {return "MAPS-GEN-09001";
},
get gEN_NoPluginDirectionsNeeded() {return "MAPS-GEN-04001";
},
get aPI_FailedSubscribeMarkerEvent() {return "MAPS-API-09005";
},
get aPI_FailedRemoveMarker() {return "MAPS-API-09003";
},
get cFG_InvalidPolygonShapeLocations() {return "MAPS-CFG-05002";
},
get lIB_InvalidApiKeyMap() {return "MAPS-LIB-01001";
},
get aPI_FailedContainsLocation() {return "MAPS-API-05005";
},
get lIB_FailedGeocodingMap() {return "MAPS-LIB-01002";
},
get cFG_InvalidTravelMode() {return "MAPS-CFG-04001";
},
get lIB_FailedGeocodingLeafletMap() {return "MAPS-LIB-11001";
},
get gEN_InvalidChangePropertyFileLayer() {return "MAPS-GEN-07001";
},
get aPI_FailedRemoveMarkers() {return "MAPS-API-09004";
},
get aPI_FailedLoadingPlugin() {return "MAPS-API-04002";
}
}),
type: Object.freeze({
get hybrid() {return "hybrid";
},
get terrain() {return "terrain";
},
get roadmap() {return "roadmap";
},
get satellite() {return "satellite";
}
}),
mapEventTriggered: Object.freeze({
get dragEnd() {return "dragend";
},
get rightClick() {return "contextmenu";
},
get doubleClick() {return "dblclick";
},
get click() {return "click";
},
get zoomChanged() {return "zoom_changed";
}
}),
style: Object.freeze({
get silver() {return 2;
},
get standard() {return 1;
},
get dark() {return 4;
},
get night() {return 5;
},
get aubergine() {return 6;
},
get retro() {return 3;
}
}),
zoom: Object.freeze({
get zoom13() {return 13;
},
get zoom9() {return 9;
},
get zoom10_City() {return 10;
},
get zoom3() {return 3;
},
get zoom15_Streets() {return 15;
},
get zoom20_Buildings() {return 20;
},
get zoom19() {return 19;
},
get zoom7() {return 7;
},
get zoom4() {return 4;
},
get zoom16() {return 16;
},
get zoom5_Continent() {return 5;
},
get zoom18() {return 18;
},
get zoom11() {return 11;
},
get zoom1_World() {return 1;
},
get zoom8() {return 8;
},
get zoom2() {return 2;
},
get zoom6() {return 6;
},
get zoom17() {return 17;
},
get zoom12() {return 12;
},
get zoom14() {return 14;
},
get auto() {return 0;
}
})
}
};
export var staticEntities = ZXingLibDemoModel.staticEntities;


