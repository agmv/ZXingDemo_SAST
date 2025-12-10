using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// OptionalMapConfigs
public class RESTST_d609eacb476c603df8b92eb374da99faStructure : AbstractRESTStructure<ST_d609eacb476c603df8b92eb374da99faStructure> {
[JsonProperty("AutoZoomOnShapes")]
public bool? AttrAutoZoomOnShapes;

[JsonProperty("Localization")]
public ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

[JsonProperty("MapStyleId")]
public string AttrMapStyleId;

[JsonProperty("MarkerClusterer")]
public ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure AttrMarkerClusterer;

[JsonProperty("Offset")]
public ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure AttrOffset;

[JsonProperty("RespectUserZoom")]
public bool? AttrRespectUserZoom;

[JsonProperty("ShowTraffic")]
public bool? AttrShowTraffic;

[JsonProperty("Type")]
public string AttrType;

[JsonProperty("UseAdvancedMarkers")]
public bool? AttrUseAdvancedMarkers;

[JsonProperty("Zoom")]
public int? AttrZoom;

[JsonProperty("DEPRECATED_AdvancedFormat")]
public string AttrDEPRECATED_AdvancedFormat;

[JsonProperty("DEPRECATED_Style")]
public int? AttrDEPRECATED_Style;

public RESTST_d609eacb476c603df8b92eb374da99faStructure() { }

public RESTST_d609eacb476c603df8b92eb374da99faStructure (ST_d609eacb476c603df8b92eb374da99faStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoZoomOnShapes = ConvertToRestWithoutDefaults(s.ssAutoZoomOnShapes, false);
AttrLocalization = ConvertToRestWithoutDefaults(s.ssLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
AttrMapStyleId = ConvertToRestWithoutDefaults(s.ssMapStyleId, "");
AttrMarkerClusterer = ConvertToRestWithoutDefaults(s.ssMarkerClusterer, new ST_30625b4ad0f3e10abf82b61ea58e8644Structure(), ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructureDelegate(config));
AttrOffset = ConvertToRestWithoutDefaults(s.ssOffset, new ST_be62cc31fbe4705834275960beeb55e2Structure(), ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructureDelegate(config));
AttrRespectUserZoom = ConvertToRestWithoutDefaults(s.ssRespectUserZoom, false);
AttrShowTraffic = ConvertToRestWithoutDefaults(s.ssShowTraffic, false);
AttrType = ConvertToRestWithoutDefaults(s.ssType, RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Type);
AttrUseAdvancedMarkers = ConvertToRestWithoutDefaults(s.ssUseAdvancedMarkers, true);
AttrZoom = ConvertToRestWithoutDefaults(s.ssZoom, RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Zoom);
AttrDEPRECATED_AdvancedFormat = ConvertToRestWithoutDefaults(s.ssDEPRECATED_AdvancedFormat, "");
AttrDEPRECATED_Style = ConvertToRestWithoutDefaults(s.ssDEPRECATED_Style, RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_DEPRECATED_Style);
  } else {
AttrAutoZoomOnShapes = (bool?) s.ssAutoZoomOnShapes;
AttrLocalization = ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssLocalization, config);
AttrMapStyleId = s.ssMapStyleId;
AttrMarkerClusterer = ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.FromStructure(s.ssMarkerClusterer, config);
AttrOffset = ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssOffset, config);
AttrRespectUserZoom = (bool?) s.ssRespectUserZoom;
AttrShowTraffic = (bool?) s.ssShowTraffic;
AttrType = s.ssType;
AttrUseAdvancedMarkers = (bool?) s.ssUseAdvancedMarkers;
AttrZoom = (int?) s.ssZoom;
AttrDEPRECATED_AdvancedFormat = s.ssDEPRECATED_AdvancedFormat;
AttrDEPRECATED_Style = (int?) s.ssDEPRECATED_Style;
  }
}

public static ST_d609eacb476c603df8b92eb374da99faStructure ToStructure(ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure obj) { 
  ST_d609eacb476c603df8b92eb374da99faStructure s = new ST_d609eacb476c603df8b92eb374da99faStructure();
  if(obj != null) {
  s.ssAutoZoomOnShapes = obj.AttrAutoZoomOnShapes == null ? false : obj.AttrAutoZoomOnShapes.Value;
  s.ssLocalization = ssZXingLibDemo.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization);
  s.ssMapStyleId = obj.AttrMapStyleId == null ? "" : obj.AttrMapStyleId;
  s.ssMarkerClusterer = ssZXingLibDemo.RestRecords.RESTST_30625b4ad0f3e10abf82b61ea58e8644Structure.ToStructure(obj.AttrMarkerClusterer);
  s.ssOffset = ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.AttrOffset);
  s.ssRespectUserZoom = obj.AttrRespectUserZoom == null ? false : obj.AttrRespectUserZoom.Value;
  s.ssShowTraffic = obj.AttrShowTraffic == null ? false : obj.AttrShowTraffic.Value;
  s.ssType = obj.AttrType == null ? RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Type : obj.AttrType;
  s.ssUseAdvancedMarkers = obj.AttrUseAdvancedMarkers == null ? true : obj.AttrUseAdvancedMarkers.Value;
  s.ssZoom = obj.AttrZoom == null ? RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Zoom : obj.AttrZoom.Value;
  s.ssDEPRECATED_AdvancedFormat = obj.AttrDEPRECATED_AdvancedFormat == null ? "" : obj.AttrDEPRECATED_AdvancedFormat;
  s.ssDEPRECATED_Style = obj.AttrDEPRECATED_Style == null ? RsseSpaceOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_DEPRECATED_Style : obj.AttrDEPRECATED_Style.Value;
  }
  return s;
}

public static Func<ST_d609eacb476c603df8b92eb374da99faStructure, ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d609eacb476c603df8b92eb374da99faStructure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure FromStructure(ST_d609eacb476c603df8b92eb374da99faStructure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTST_d609eacb476c603df8b92eb374da99faStructure(s, config);
}

}


