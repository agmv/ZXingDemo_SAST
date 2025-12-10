import * as OSRuntimeCore from "@outsystems/runtime-core-js";

var OS = OSRuntimeCore;
import * as OutSystemsMapsModel from "./OutSystemsMaps.staticEntities.js";
export {entities, setEntities} from "./OutSystemsMaps.entities-model.js";
export {staticEntities} from "./OutSystemsMaps.staticEntities.js";
export class ST_59c2aa6a35b14343cc78f655810f9ce8Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Language", "languageAttr", "language", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Region", "regionAttr", "region", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Localization";
}
}



ST_59c2aa6a35b14343cc78f655810f9ce8Structure.init();

export class ST_b2c05afcf4810ad0d4384a01306bb0f3Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Zoom", "zoomAttr", "Zoom", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsMapsModel.staticEntities.zoom.auto;
}, true), 
this.attr("Type", "typeAttr", "Type", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsMapsModel.staticEntities.type.roadmap;
}, true), 
this.attr("Localization", "localizationAttr", "Localization", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_59c2aa6a35b14343cc78f655810f9ce8Structure());
}, true, ST_59c2aa6a35b14343cc78f655810f9ce8Structure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalStaticMapConfigs";
}
}



ST_b2c05afcf4810ad0d4384a01306bb0f3Structure.init();

export class ST_c2a46cf64d2acc4b38d805712495224cStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Color", "colorAttr", "Color", false, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("Opacity", "opacityAttr", "Opacity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("Weight", "weightAttr", "Weight", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Stroke";
}
}



ST_c2a46cf64d2acc4b38d805712495224cStructure.init();

export class ST_4d96f69748c4f35fb433f7995d061407Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("locations", "locationsAttr", "locations", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("center", "centerAttr", "center", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("bounds", "boundsAttr", "bounds", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("radius", "radiusAttr", "radius", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("allowDrag", "allowDragAttr", "allowDrag", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("allowEdit", "allowEditAttr", "allowEdit", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("strokeColor", "strokeColorAttr", "strokeColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("strokeOpacity", "strokeOpacityAttr", "strokeOpacity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("strokeWeight", "strokeWeightAttr", "strokeWeight", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true), 
this.attr("fillColor", "fillColorAttr", "fillColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("fillOpacity", "fillOpacityAttr", "fillOpacity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_shape_configs";
}
}



ST_4d96f69748c4f35fb433f7995d061407Structure.init();

export class ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Color", "colorAttr", "Color", false, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("Opacity", "opacityAttr", "Opacity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Fill";
}
}



ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.init();

export class ST_fbded4e930a61a57761a37f0b1ea8d40Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowEdit", "allowEditAttr", "AllowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Stroke", "strokeAttr", "Stroke", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, true, ST_c2a46cf64d2acc4b38d805712495224cStructure), 
this.attr("Fill", "fillAttr", "Fill", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure());
}, true, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalRectangleConfigs";
}
}



ST_fbded4e930a61a57761a37f0b1ea8d40Structure.init();

export class ST_30625b4ad0f3e10abf82b61ea58e8644Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Active", "activeAttr", "markerClustererActive", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("MaxZoom", "maxZoomAttr", "markerClustererMaxZoom", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ZoomOnClick", "zoomOnClickAttr", "markerClustererZoomOnClick", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("MinClusterSize", "minClusterSizeAttr", "markerClustererMinClusterSize", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MarkerClusterer";
}
}



ST_30625b4ad0f3e10abf82b61ea58e8644Structure.init();

export class ST_be62cc31fbe4705834275960beeb55e2Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OffsetX", "offsetXAttr", "offsetX", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("OffsetY", "offsetYAttr", "offsetY", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Offset";
}
}



ST_be62cc31fbe4705834275960beeb55e2Structure.init();

export class ST_d609eacb476c603df8b92eb374da99faStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AutoZoomOnShapes", "autoZoomOnShapesAttr", "AutoZoomOnShapes", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Localization", "localizationAttr", "Localization", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_59c2aa6a35b14343cc78f655810f9ce8Structure());
}, true, ST_59c2aa6a35b14343cc78f655810f9ce8Structure), 
this.attr("MapStyleId", "mapStyleIdAttr", "MapStyleId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("MarkerClusterer", "markerClustererAttr", "MarkerClusterer", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_30625b4ad0f3e10abf82b61ea58e8644Structure());
}, true, ST_30625b4ad0f3e10abf82b61ea58e8644Structure), 
this.attr("Offset", "offsetAttr", "Offset", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_be62cc31fbe4705834275960beeb55e2Structure());
}, true, ST_be62cc31fbe4705834275960beeb55e2Structure), 
this.attr("RespectUserZoom", "respectUserZoomAttr", "respectUserZoom", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("ShowTraffic", "showTrafficAttr", "ShowTraffic", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Type", "typeAttr", "Type", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsMapsModel.staticEntities.type.roadmap;
}, true), 
this.attr("UseAdvancedMarkers", "useAdvancedMarkersAttr", "useAdvancedMarkers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Zoom", "zoomAttr", "Zoom", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsMapsModel.staticEntities.zoom.auto;
}, true), 
this.attr("DEPRECATED_AdvancedFormat", "dEPRECATED_AdvancedFormatAttr", "DEPRECATED_AdvancedFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DEPRECATED_Style", "dEPRECATED_StyleAttr", "DEPRECATED_Style", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsMapsModel.staticEntities.style.standard;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalMapConfigs";
}
}



ST_d609eacb476c603df8b92eb374da99faStructure.init();

export class EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord(new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "FileLayerEvent";
}
}



EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord.init();

export class ST_597877eac22877030461f6d98995be4aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AutoZoomOnShapes", "autoZoomOnShapesAttr", "AutoZoomOnShapes", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Offset", "offsetAttr", "Offset", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_be62cc31fbe4705834275960beeb55e2Structure());
}, true, ST_be62cc31fbe4705834275960beeb55e2Structure), 
this.attr("RespectUserZoom", "respectUserZoomAttr", "respectUserZoom", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Zoom", "zoomAttr", "Zoom", false, false, OS.DataTypes.DataTypes.Integer, function () {
return OutSystemsMapsModel.staticEntities.zoom.auto;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalLeafletMapConfigs";
}
}



ST_597877eac22877030461f6d98995be4aStructure.init();

export class ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Lat", "latAttr", "Lat", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Lng", "lngAttr", "Lng", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Weight", "weightAttr", "Weight", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("1.0"));
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Points";
}
}



ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure.init();

export class ST_ca5fecbdf222b72d179909c1f030119cStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("points", "pointsAttr", "points", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new (OS.GenericTypeCache.getGenericList(ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure))());
}, true, (OS.GenericTypeCache.getGenericList(ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure))), 
this.attr("maxIntensity", "maxIntensityAttr", "maxIntensity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("opacity", "opacityAttr", "opacity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("radius", "radiusAttr", "radius", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("dissipateOnZoom", "dissipateOnZoomAttr", "dissipateOnZoom", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("gradient", "gradientAttr", "gradient", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_heatmapLayer_configs";
}
}



ST_ca5fecbdf222b72d179909c1f030119cStructure.init();

export class EN_e7686de199fbd20281899419f0b6ff11EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Style", "styleAttr", "Style", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("URLStyle", "uRLStyleAttr", "URLStyle", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Is_Active", "is_ActiveAttr", "Is_Active", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Style";
}
}



EN_e7686de199fbd20281899419f0b6ff11EntityRecord.init();

export class ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Code", "codeAttr", "code", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ErrorMessage";
}
}



ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure.init();

export class EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord(new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ShapeEventTriggered";
}
}



EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.init();

export class ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("North", "northAttr", "north", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("South", "southAttr", "south", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("West", "westAttr", "west", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("East", "eastAttr", "east", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "SearchArea";
}
}



ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.init();

export class ST_d4721898ae8c007cd938074f575e2979Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("apiKey", "apiKeyAttr", "apiKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("countries", "countriesAttr", "countries", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList), 
this.attr("searchArea", "searchAreaAttr", "searchArea", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure());
}, true, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure), 
this.attr("searchType", "searchTypeAttr", "searchType", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("localization", "localizationAttr", "localization", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_59c2aa6a35b14343cc78f655810f9ce8Structure());
}, true, ST_59c2aa6a35b14343cc78f655810f9ce8Structure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_searchPlaces_configs";
}
}



ST_d4721898ae8c007cd938074f575e2979Structure.init();

export class EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord(new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Provider";
}
}



EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord.init();

export class EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord(new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MarkerType";
}
}



EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord.init();

export class ST_793e574f3ddb64f39831eacf8a4462b0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("layerUrl", "layerUrlAttr", "layerUrl", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("suppressPopups", "suppressPopupsAttr", "suppressPopups", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("preserveViewport", "preserveViewportAttr", "preserveViewport", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_fileLayer_configs";
}
}



ST_793e574f3ddb64f39831eacf8a4462b0Structure.init();

export class ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_fileLayer_configs", "internal_to_provider_fileLayer_configsAttr", "Internal_to_provider_fileLayer_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_793e574f3ddb64f39831eacf8a4462b0Structure());
}, true, ST_793e574f3ddb64f39831eacf8a4462b0Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_FileLayer_Configs";
}
}



ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure.init();

export class ST_b3f640c8758c66e2b436da510a8dfe3cStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Location", "locationAttr", "location", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Radius", "radiusAttr", "radius", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawCircle_Shape";
}
}



ST_b3f640c8758c66e2b436da510a8dfe3cStructure.init();

export class EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord(new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MapType";
}
}



EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord.init();

export class ST_0e474756a4be14d378c73cd05f602bcdStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Lat", "latAttr", "Lat", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Lng", "lngAttr", "Lng", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Coordinates";
}
}



ST_0e474756a4be14d378c73cd05f602bcdStructure.init();

export class ST_5fb6f64676b0133fcb572480a766fc9cStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("North", "northAttr", "north", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("South", "southAttr", "south", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("West", "westAttr", "west", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("East", "eastAttr", "east", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Bounds";
}
}



ST_5fb6f64676b0133fcb572480a766fc9cStructure.init();

export class ST_d25262c67f1be04c1df274811b8c7ee4Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("allowDrag", "allowDragAttr", "allowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("allowEdit", "allowEditAttr", "allowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("strokeColor", "strokeColorAttr", "strokeColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("strokeOpacity", "strokeOpacityAttr", "strokeOpacity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("strokeWeight", "strokeWeightAttr", "strokeWeight", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true), 
this.attr("fillColor", "fillColorAttr", "fillColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("fillOpacity", "fillOpacityAttr", "fillOpacity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_drawFilledShape_configs";
}
}



ST_d25262c67f1be04c1df274811b8c7ee4Structure.init();

export class ST_5d8d0b250562ec29250400c2b0c3eb66Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_tools_configs", "internal_to_provider_tools_configsAttr", "Internal_to_provider_tools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_d25262c67f1be04c1df274811b8c7ee4Structure());
}, true, ST_d25262c67f1be04c1df274811b8c7ee4Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawCircle_Configs";
}
}



ST_5d8d0b250562ec29250400c2b0c3eb66Structure.init();

export class EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "LogType";
}
}



EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord.init();

export class ST_f021741499f997a32540fab3dfcdbbfaStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowEdit", "allowEditAttr", "AllowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Stroke", "strokeAttr", "Stroke", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, true, ST_c2a46cf64d2acc4b38d805712495224cStructure), 
this.attr("Fill", "fillAttr", "Fill", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure());
}, true, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalShapeConfigs";
}
}



ST_f021741499f997a32540fab3dfcdbbfaStructure.init();

export class ST_51ef6a78944132edc56aa7bf7c4ea240Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("location", "locationAttr", "location", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("iconUrl", "iconUrlAttr", "iconUrl", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("title", "titleAttr", "title", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("label", "labelAttr", "label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("allowDrag", "allowDragAttr", "allowDrag", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("iconWidth", "iconWidthAttr", "iconWidth", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("iconHeight", "iconHeightAttr", "iconHeight", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_marker_configs";
}
}



ST_51ef6a78944132edc56aa7bf7c4ea240Structure.init();

export class ST_3d593ae1aad35ac58e1616049bb8da2cStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_marker_configs", "internal_to_provider_marker_configsAttr", "Internal_to_provider_marker_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_51ef6a78944132edc56aa7bf7c4ea240Structure());
}, true, ST_51ef6a78944132edc56aa7bf7c4ea240Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal__Marker_Configs";
}
}



ST_3d593ae1aad35ac58e1616049bb8da2cStructure.init();

export class ST_3f16cd459ccd861deffd4483bc1bbac3Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("position", "positionAttr", "position", false, false, OS.DataTypes.DataTypes.Text, function () {
return OutSystemsMapsModel.staticEntities.drawingToolsPosition.top_Center;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new ST_3f16cd459ccd861deffd4483bc1bbac3Structure(new ST_3f16cd459ccd861deffd4483bc1bbac3Structure.RecordClass({
positionAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "Internal_to_provider_drawingTools_configs";
}
}



ST_3f16cd459ccd861deffd4483bc1bbac3Structure.init();

export class EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord(new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MarkerEvent";
}
}



EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord.init();

export class ST_f2c047cd8082950bd1961446a5ec1949Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_heatmapLayer_configs", "internal_to_provider_heatmapLayer_configsAttr", "Internal_to_provider_heatmapLayer_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_ca5fecbdf222b72d179909c1f030119cStructure());
}, true, ST_ca5fecbdf222b72d179909c1f030119cStructure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_HeatmapLayer_Configs";
}
}



ST_f2c047cd8082950bd1961446a5ec1949Structure.init();

export class ST_9f8ac95fe4e47e327de12de1b56bed45Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Active", "activeAttr", "markerClustererActive", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("MaxZoom", "maxZoomAttr", "markerClustererMaxZoom", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("ZoomOnClick", "zoomOnClickAttr", "markerClustererZoomOnClick", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("MinClusterSize", "minClusterSizeAttr", "markerClustererMinClusterSize", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Private_MarkerClusterer";
}
}



ST_9f8ac95fe4e47e327de12de1b56bed45Structure.init();

export class ST_5baae74ed57e3bb61180aff1dadec4e1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("advancedFormat", "advancedFormatAttr", "advancedFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("apiKey", "apiKeyAttr", "apiKey", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("autoZoomOnShapes", "autoZoomOnShapesAttr", "autoZoomOnShapes", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("center", "centerAttr", "center", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("height", "heightAttr", "height", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("offset", "offsetAttr", "offset", true, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_be62cc31fbe4705834275960beeb55e2Structure());
}, true, ST_be62cc31fbe4705834275960beeb55e2Structure), 
this.attr("showTraffic", "showTrafficAttr", "showTraffic", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("staticMap", "staticMapAttr", "staticMap", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("style", "styleAttr", "style", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("type", "typeAttr", "type", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("zoom", "zoomAttr", "zoom", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("markerClusterer", "markerClustererAttr", "markerClusterer", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_9f8ac95fe4e47e327de12de1b56bed45Structure());
}, true, ST_9f8ac95fe4e47e327de12de1b56bed45Structure), 
this.attr("respectUserZoom", "respectUserZoomAttr", "respectUserZoom", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("localization", "localizationAttr", "localization", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_59c2aa6a35b14343cc78f655810f9ce8Structure());
}, true, ST_59c2aa6a35b14343cc78f655810f9ce8Structure), 
this.attr("useAdvancedMarkers", "useAdvancedMarkersAttr", "useAdvancedMarkers", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("mapStyleId", "mapStyleIdAttr", "mapStyleId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_configs";
}
}



ST_5baae74ed57e3bb61180aff1dadec4e1Structure.init();

export class EN_e5ca0002e0338a827923cc311de3f95cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord(new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MapEvent";
}
}



EN_e5ca0002e0338a827923cc311de3f95cEntityRecord.init();

export class ST_2c6551904cfa95c93fa24da37b55d320Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Origin", "originAttr", "origin", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_0e474756a4be14d378c73cd05f602bcdStructure());
}, true, ST_0e474756a4be14d378c73cd05f602bcdStructure), 
this.attr("Destination", "destinationAttr", "destination", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_0e474756a4be14d378c73cd05f602bcdStructure());
}, true, ST_0e474756a4be14d378c73cd05f602bcdStructure), 
this.attr("Distance", "distanceAttr", "distance", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Duration", "durationAttr", "duration", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DirectionLegs";
}
}



ST_2c6551904cfa95c93fa24da37b55d320Structure.init();

export class ST_f121435b3edb481ee03ab7ef58e5b805Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("allowDrag", "allowDragAttr", "allowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("iconUrl", "iconUrlAttr", "iconUrl", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_drawMarker_configs";
}
}



ST_f121435b3edb481ee03ab7ef58e5b805Structure.init();

export class ST_60018fad8b9768f5644ffadf96040a85Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_tools_configs", "internal_to_provider_tools_configsAttr", "Internal_to_provider_tools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_f121435b3edb481ee03ab7ef58e5b805Structure());
}, true, ST_f121435b3edb481ee03ab7ef58e5b805Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawMarker_Configs";
}
}



ST_60018fad8b9768f5644ffadf96040a85Structure.init();

export class EN_8a068e43cce18c5870b845073fb713c1EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_8a068e43cce18c5870b845073fb713c1EntityRecord(new EN_8a068e43cce18c5870b845073fb713c1EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DrawingToolsEventTriggered";
}
}



EN_8a068e43cce18c5870b845073fb713c1EntityRecord.init();

export class ST_7cd861eaa819851d6fba6d8150ed8cc1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Countries", "countriesAttr", "Countries", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList), 
this.attr("SearchArea", "searchAreaAttr", "SearchArea", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure());
}, true, ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure), 
this.attr("SearchType", "searchTypeAttr", "SearchType", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Localization", "localizationAttr", "Localization", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_59c2aa6a35b14343cc78f655810f9ce8Structure());
}, true, ST_59c2aa6a35b14343cc78f655810f9ce8Structure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalSearchPlacesConfigs";
}
}



ST_7cd861eaa819851d6fba6d8150ed8cc1Structure.init();

export class ST_f85923824a33f65ded14770af5377402Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowEdit", "allowEditAttr", "AllowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Stroke", "strokeAttr", "Stroke", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, true, ST_c2a46cf64d2acc4b38d805712495224cStructure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalPolylineConfigs";
}
}



ST_f85923824a33f65ded14770af5377402Structure.init();

export class EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Code", "codeAttr", "Code", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "Message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "SearchPlacesErrors";
}
}



EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord.init();

export class EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord(new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SearchTypes";
}
}



EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord.init();

export class ST_9df57e801e7478aaf703933c17abb4f6Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_tools_configs", "internal_to_provider_tools_configsAttr", "Internal_to_provider_tools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_d25262c67f1be04c1df274811b8c7ee4Structure());
}, true, ST_d25262c67f1be04c1df274811b8c7ee4Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawRectangle_Configs";
}
}



ST_9df57e801e7478aaf703933c17abb4f6Structure.init();

export class EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord(new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MapEventTriggered";
}
}



EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.init();

export class ST_2bb06e37aea9715ba999f70106cf37a5Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SuppressPopups", "suppressPopupsAttr", "SuppressPopups", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("PreserveViewport", "preserveViewportAttr", "PreserveViewport", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalFileLayerConfigs";
}
}



ST_2bb06e37aea9715ba999f70106cf37a5Structure.init();

export class ST_832344699c82a4f799a423f89bbe7297Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Location", "locationAttr", "location", false, false, OS.DataTypes.DataTypes.Text, function () {
return "42.3517926,-71.0467845";
}, true), 
this.attr("IconURL", "iconURLAttr", "iconUrl", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DEPRECATED_AdvancedFormat", "dEPRECATED_AdvancedFormatAttr", "advancedFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "StaticMarker";
}
}



ST_832344699c82a4f799a423f89bbe7297Structure.init();

export class ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_shape_configs", "internal_to_provider_shape_configsAttr", "Internal_to_provider_shape_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_4d96f69748c4f35fb433f7995d061407Structure());
}, true, ST_4d96f69748c4f35fb433f7995d061407Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_Shape_Configs";
}
}



ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.init();

export class ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Email", "emailAttr", "email", false, false, OS.DataTypes.DataTypes.Email, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Uri", "uriAttr", "uri", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Author";
}
}



ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure.init();

export class ST_87d89cf32a40d309845674355a1bd4e1Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "id", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameAttr", "name", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Author", "authorAttr", "author", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure());
}, true, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure), 
this.attr("Description", "descriptionAttr", "description", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("InfoWindowHtml", "infoWindowHtmlAttr", "infoWindowHtml", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Snippet", "snippetAttr", "Snippet", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "FeatureData";
}
}



ST_87d89cf32a40d309845674355a1bd4e1Structure.init();

export class ST_b0933bf7957301c22e5d9229ad792ac0Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_configs", "internal_to_provider_configsAttr", "Internal_to_provider_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_d4721898ae8c007cd938074f575e2979Structure());
}, true, ST_d4721898ae8c007cd938074f575e2979Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_SearchPlaces_Configs";
}
}



ST_b0933bf7957301c22e5d9229ad792ac0Structure.init();

export class EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord(new EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ShapeType";
}
}



EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord.init();

export class EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Zoom", "zoomAttr", "Zoom", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Zoom";
}
}



EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord.init();

export class EN_4d0e07d9538530f68924ab612d15f82bEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Code", "codeAttr", "Code", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "Message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "MapErrors";
}
}



EN_4d0e07d9538530f68924ab612d15f82bEntityRecord.init();

export class ST_86d2610e9625abf0ecb7241e6d8099fbStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("allowDrag", "allowDragAttr", "allowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("allowEdit", "allowEditAttr", "allowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("strokeColor", "strokeColorAttr", "strokeColor", true, false, OS.DataTypes.DataTypes.Text, function () {
return "#000000";
}, true), 
this.attr("strokeOpacity", "strokeOpacityAttr", "strokeOpacity", true, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.BuiltinFunctions.integerToDecimal(1);
}, true), 
this.attr("strokeWeight", "strokeWeightAttr", "strokeWeight", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 2;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_to_provider_drawNotFilledShape_configs";
}
}



ST_86d2610e9625abf0ecb7241e6d8099fbStructure.init();

export class ST_5223ca706bfb3de574fb0b39ebba3fb6Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_tools_configs", "internal_to_provider_tools_configsAttr", "Internal_to_provider_tools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_86d2610e9625abf0ecb7241e6d8099fbStructure());
}, true, ST_86d2610e9625abf0ecb7241e6d8099fbStructure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawPolyline_Configs";
}
}



ST_5223ca706bfb3de574fb0b39ebba3fb6Structure.init();

export class EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord(new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DrawingToolsPosition";
}
}



EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord.init();

export class ST_78fd8c130caeaf241d821392d1010014Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AvoidTolls", "avoidTollsAttr", "avoidTolls", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AvoidHighways", "avoidHighwaysAttr", "avoidHighways", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AvoidFerries", "avoidFerriesAttr", "avoidFerries", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ExcludeCriteria";
}
}



ST_78fd8c130caeaf241d821392d1010014Structure.init();

export class ST_78b0cd1737b6725aac7ae45759769b93Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Origin", "originAttr", "originRoute", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Destination", "destinationAttr", "destinationRoute", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TravelMode", "travelModeAttr", "travelMode", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Waypoints", "waypointsAttr", "waypoints", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList), 
this.attr("OptimizeWaypoints", "optimizeWaypointsAttr", "optimizeWaypoints", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Exclude", "excludeAttr", "exclude", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_78fd8c130caeaf241d821392d1010014Structure());
}, true, ST_78fd8c130caeaf241d821392d1010014Structure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "DirectionOptions";
}
}



ST_78b0cd1737b6725aac7ae45759769b93Structure.init();

export class EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord(new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "PopupEvent";
}
}



EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord.init();

export class ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Width", "widthAttr", "Width", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "IconSize";
}
}



ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure.init();

export class ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_tools_configs", "internal_to_provider_tools_configsAttr", "Internal_to_provider_tools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_d25262c67f1be04c1df274811b8c7ee4Structure());
}, true, ST_d25262c67f1be04c1df274811b8c7ee4Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawPolygon_Configs";
}
}



ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure.init();

export class ST_49045fb6574dc7f29ee1f97116ecb1f6Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowEdit", "allowEditAttr", "AllowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Stroke", "strokeAttr", "Stroke", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, true, ST_c2a46cf64d2acc4b38d805712495224cStructure), 
this.attr("Fill", "fillAttr", "Fill", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure());
}, true, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalPolygonConfigs";
}
}



ST_49045fb6574dc7f29ee1f97116ecb1f6Structure.init();

export class EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord(new EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DrawingToolsEvent";
}
}



EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord.init();

export class EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord(new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DrawingToolType";
}
}



EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.init();

export class ST_c84e2ea85c3f77e3b083b2b79806c17aStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MaxIntensity", "maxIntensityAttr", "MaxIntensity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Opacity", "opacityAttr", "Opacity", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return (new OS.DataTypes.Decimal("0.6"));
}, true), 
this.attr("Radius", "radiusAttr", "Radius", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 3;
}, true), 
this.attr("DissipateOnZoom", "dissipateOnZoomAttr", "DissipateOnZoom", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return true;
}, true), 
this.attr("Gradient", "gradientAttr", "Gradient", false, false, OS.DataTypes.DataTypes.RecordList, function () {
return OS.DataTypes.ImmutableBase.getData(new OS.DataTypes.TextList());
}, true, OS.DataTypes.TextList)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalHeatmapLayerConfigs";
}
}



ST_c84e2ea85c3f77e3b083b2b79806c17aStructure.init();

export class ST_5a7ef7acf3b11e0c41074aefa2466f75Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Location", "locationAttr", "location", false, false, OS.DataTypes.DataTypes.Text, function () {
return "42.3517926,-71.0467845";
}, true), 
this.attr("IconURL", "iconURLAttr", "iconUrl", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("AdvancedFormat", "advancedFormatAttr", "advancedFormat", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Marker";
}
}



ST_5a7ef7acf3b11e0c41074aefa2466f75Structure.init();

export class ST_bbc1ca6a16af45dbf463953c280f2bf7Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IconURL", "iconURLAttr", "IconURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IconSize", "iconSizeAttr", "IconSize", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure());
}, true, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure), 
this.attr("Title", "titleAttr", "Title", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalPopupMarkerConfigs";
}
}



ST_bbc1ca6a16af45dbf463953c280f2bf7Structure.init();

export class ST_61db11323cabca5a5fb3b6c7b9d63842Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Internal_to_provider_drawingTools_configs", "internal_to_provider_drawingTools_configsAttr", "Internal_to_provider_drawingTools_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_3f16cd459ccd861deffd4483bc1bbac3Structure());
}, true, ST_3f16cd459ccd861deffd4483bc1bbac3Structure), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_DrawingTools_Configs";
}
}



ST_61db11323cabca5a5fb3b6c7b9d63842Structure.init();

export class EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", false, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Verbosity";
}
}



EN_79a82b77f95346f2348912e0d4ee0bf1EntityRecord.init();

export class EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord(new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "TravelMode";
}
}



EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.init();

export class EN_714295b6f712e509405abbf66debf617EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_714295b6f712e509405abbf66debf617EntityRecord(new EN_714295b6f712e509405abbf66debf617EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "DirectionsProvider";
}
}



EN_714295b6f712e509405abbf66debf617EntityRecord.init();

export class ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IconURL", "iconURLAttr", "IconURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IconSize", "iconSizeAttr", "IconSize", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure());
}, true, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure), 
this.attr("Title", "titleAttr", "Title", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalMarkerConfigs";
}
}



ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure.init();

export class ST_cdd94bc434e873b4d04598ac1e187543Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsSuccess", "isSuccessAttr", "isSuccess", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Code", "codeAttr", "code", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Message", "messageAttr", "message", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "ReturnMessage";
}
}



ST_cdd94bc434e873b4d04598ac1e187543Structure.init();

export class EN_d9c97e718205f8627d74b06df54e3543EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_d9c97e718205f8627d74b06df54e3543EntityRecord(new EN_d9c97e718205f8627d74b06df54e3543EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "MarkerEventTriggered";
}
}



EN_d9c97e718205f8627d74b06df54e3543EntityRecord.init();

export class ST_78d3133d124713193d703c2644ecd39bStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ExtendedClass", "extendedClassAttr", "ExtendedClass", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Height", "heightAttr", "Height", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Internal_to_provider_configs", "internal_to_provider_configsAttr", "Internal_to_provider_configs", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_5baae74ed57e3bb61180aff1dadec4e1Structure());
}, true, ST_5baae74ed57e3bb61180aff1dadec4e1Structure), 
this.attr("StaticMapURL", "staticMapURLAttr", "StaticMapURL", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("UniqueId", "uniqueIdAttr", "UniqueId", false, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Internal_Configs";
}
}



ST_78d3133d124713193d703c2644ecd39bStructure.init();

export class ST_7e9e7e47a56960855c31bd37116d68abStructure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Center", "centerAttr", "Center", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_0e474756a4be14d378c73cd05f602bcdStructure());
}, true, ST_0e474756a4be14d378c73cd05f602bcdStructure), 
this.attr("Radius", "radiusAttr", "Radius", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "CircleShape";
}
}



ST_7e9e7e47a56960855c31bd37116d68abStructure.init();

export class EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord(new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "SearchPlacesEvent";
}
}



EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord.init();

export class EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("MapType", "mapTypeAttr", "MapType", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Label", "labelAttr", "Label", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Order", "orderAttr", "Order", true, false, OS.DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("Is_Active", "is_ActiveAttr", "Is_Active", true, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "Type";
}
}



EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.init();

export class ST_9a87c036f8540c84242b92bb54609014Structure extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AllowDrag", "allowDragAttr", "AllowDrag", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowEdit", "allowEditAttr", "AllowEdit", false, false, OS.DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Stroke", "strokeAttr", "Stroke", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_c2a46cf64d2acc4b38d805712495224cStructure());
}, true, ST_c2a46cf64d2acc4b38d805712495224cStructure), 
this.attr("Fill", "fillAttr", "Fill", false, false, OS.DataTypes.DataTypes.Record, function () {
return OS.DataTypes.ImmutableBase.getData(new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure());
}, true, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get $runtimeName() {return "OptionalCircleConfigs";
}
}



ST_9a87c036f8540c84242b92bb54609014Structure.init();

export class RC_df0786951d2357ea5f13ac02dccd68c2 extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Lat", "latAttr", "Lat", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true), 
this.attr("Lng", "lngAttr", "Lng", false, false, OS.DataTypes.DataTypes.Decimal, function () {
return OS.DataTypes.Decimal.defaultValue;
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static get _isAnonymousRecord() {return true;
}
static get UniqueId() {return "df078695-1d23-57ea-5f13-ac02dccd68c2";
}
}



RC_df0786951d2357ea5f13ac02dccd68c2.init();

export class EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord extends 
OS.DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idAttr", "Id", true, false, OS.DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS.DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord(new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.RecordClass({
idAttr: OS.DataTypes.ImmutableBase.getData(str)
}));
}

static get $runtimeName() {return "ShapeEvent";
}
}



EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord.init();



