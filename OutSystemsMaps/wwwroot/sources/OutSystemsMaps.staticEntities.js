import * as OS from "@outsystems/runtime-core-js";
var OutSystemsMapsModel = {
staticEntities: {
logType: Object.freeze({
get general() {return "General";
},
get error() {return "Error";
},
get debug() {return "Debug";
},
get performance() {return "Performance";
},
get warning() {return "Warning";
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
drawingToolType: Object.freeze({
get polyline() {return "polyline";
},
get rectangle() {return "rectangle";
},
get marker() {return "marker";
},
get circle() {return "circle";
},
get polygon() {return "polygon";
}
}),
shapeType: Object.freeze({
get rectangle() {return "Rectangle";
},
get circle() {return "Circle";
},
get polyline() {return "Polyline";
},
get polygon() {return "Polygon";
}
}),
directionsProvider: Object.freeze({
get oSRM() {return "OSRM";
},
get mapBox() {return "MapBox";
}
}),
popupEvent: Object.freeze({
get onMouseover() {return "OnMouseover";
},
get onMouseout() {return "OnMouseout";
},
get onClick() {return "OnClick";
},
get rightClick() {return "RightClick";
},
get doubleClick() {return "DoubleClick";
}
}),
drawingToolsEventTriggered: Object.freeze({
get polygonCreated() {return "polygoncomplete";
},
get polylineCreated() {return "polylinecomplete";
},
get rectangleCreated() {return "rectanglecomplete";
},
get circleCreated() {return "circlecomplete";
},
get markerAdd() {return "markercomplete";
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
searchPlacesEvent: Object.freeze({
get onError() {return "OnError";
},
get onPlaceSelect() {return "OnPlaceSelect";
},
get initialized() {return "Initialized";
}
}),
shapeEvent: Object.freeze({
get onClick() {return "OnClick";
}
}),
markerType: Object.freeze({
get markerPopup() {return "MarkerPopup";
},
get marker() {return "Marker";
}
}),
searchPlacesErrors: Object.freeze({
get gEN_UnsupportedEventSearchPlaces() {return "MAPS-GEN-10002";
},
get cFG_APIKeyAlreadySetSearchPlaces() {return "MAPS-CFG-10001";
},
get lIB_InvalidApiKeySearchPlaces() {return "MAPS-LIB-10001";
},
get cFG_APIKeyDiffersFromPlacesToMaps() {return "MAPS-CFG-01002";
},
get lIB_FailedGeocodingSearchAreaLocations() {return "MAPS-LIB-10002";
},
get cFG_MaximumCountriesNumber() {return "MAPS-CFG-10003";
},
get gEN_InvalidChangePropertySearchPlaces() {return "MAPS-GEN-10001";
},
get cFG_InvalidSearchPlacesSearchArea() {return "MAPS-CFG-10002";
}
}),
mapEvent: Object.freeze({
get initialized() {return "Initialized";
},
get onError() {return "OnError";
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
searchTypes: Object.freeze({
get addresses() {return "Addresses";
},
get establishments() {return "Establishments";
},
get cities() {return "Cities";
},
get regions() {return "Regions";
},
get geocodes() {return "Geocodes";
}
}),
markerEvent: Object.freeze({
get onClick() {return "OnClick";
},
get initialized() {return "Initialized";
}
}),
provider: Object.freeze({
get google() {return "Google";
},
get leaflet() {return "Leaflet";
}
}),
drawingToolsPosition: Object.freeze({
get top_Right() {return "TOP_RIGHT";
},
get top_Center() {return "TOP_CENTER";
},
get right_Center() {return "RIGHT_CENTER";
},
get top_Left() {return "TOP_LEFT";
},
get bottom_Center() {return "BOTTOM_CENTER";
},
get right_Top() {return "RIGHT_TOP";
},
get bottom_Right() {return "BOTTOM_RIGHT";
},
get bottom_Left() {return "BOTTOM_LEFT";
},
get right_Bottom() {return "RIGHT_BOTTOM";
},
get left_Center() {return "LEFT_CENTER";
},
get left_Top() {return "LEFT_TOP";
},
get left_Bottom() {return "LEFT_BOTTOM";
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
fileLayerEvent: Object.freeze({
get onClick() {return "OnClick";
}
}),
markerEventTriggered: Object.freeze({
get onClick() {return "OnClick";
},
get doubleClick() {return "dblclick";
},
get rightClick() {return "contextmenu";
},
get dragEnd() {return "dragend";
}
}),
mapType: Object.freeze({
get staticMap() {return "StaticMap";
},
get map() {return "Map";
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
}),
verbosity: Object.freeze({
get verbose() {return "Verbose";
},
get noLogging() {return "No Logging";
},
get error() {return "Error";
},
get warning() {return "Warning";
},
get log() {return "Log";
}
}),
drawingToolsEvent: Object.freeze({
get initialized() {return "Initialized";
}
}),
shapeEventTriggered: Object.freeze({
get dragEnd() {return "dragend";
},
get shapeChanged() {return "shape_changed";
}
}),
travelMode: Object.freeze({
get dRIVING() {return "DRIVING";
},
get bICYCLING() {return "BICYCLING";
},
get tRANSIT() {return "TRANSIT";
},
get wALKING() {return "WALKING";
}
})
}
};
export var staticEntities = OutSystemsMapsModel.staticEntities;


