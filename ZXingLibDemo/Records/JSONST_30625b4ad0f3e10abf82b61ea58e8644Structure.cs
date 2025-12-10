using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MarkerClusterer
public class JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure : AbstractRESTStructure<ST_30625b4ad0f3e10abf82b61ea58e8644Structure> {
[JsonProperty("markerClustererActive")]
[JsonPropertyName("markerClustererActive")]
public bool? AttrActive;

[JsonProperty("markerClustererMaxZoom")]
[JsonPropertyName("markerClustererMaxZoom")]
public int? AttrMaxZoom;

[JsonProperty("markerClustererZoomOnClick")]
[JsonPropertyName("markerClustererZoomOnClick")]
public bool? AttrZoomOnClick;

[JsonProperty("markerClustererMinClusterSize")]
[JsonPropertyName("markerClustererMinClusterSize")]
public int? AttrMinClusterSize;

public JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure() { }

public JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure (ST_30625b4ad0f3e10abf82b61ea58e8644Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActive = ConvertToRestWithoutDefaults(s.ssActive, false);
AttrMaxZoom = ConvertToRestWithoutDefaults(s.ssMaxZoom, 0);
AttrZoomOnClick = ConvertToRestWithoutDefaults(s.ssZoomOnClick, true);
AttrMinClusterSize = ConvertToRestWithoutDefaults(s.ssMinClusterSize, 2);
  } else {
AttrActive = (bool?) s.ssActive;
AttrMaxZoom = (int?) s.ssMaxZoom;
AttrZoomOnClick = (bool?) s.ssZoomOnClick;
AttrMinClusterSize = (int?) s.ssMinClusterSize;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure, ST_30625b4ad0f3e10abf82b61ea58e8644Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure s) => ToStructure(s, config);
}
public static ST_30625b4ad0f3e10abf82b61ea58e8644Structure ToStructure(ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure obj, IBehaviorsConfiguration config) { 
  ST_30625b4ad0f3e10abf82b61ea58e8644Structure s = new ST_30625b4ad0f3e10abf82b61ea58e8644Structure();
  if(obj != null) {
  s.ssActive = obj.AttrActive == null ? false : obj.AttrActive.Value;
  s.ssMaxZoom = obj.AttrMaxZoom == null ? 0 : obj.AttrMaxZoom.Value;
  s.ssZoomOnClick = obj.AttrZoomOnClick == null ? true : obj.AttrZoomOnClick.Value;
  s.ssMinClusterSize = obj.AttrMinClusterSize == null ? 2 : obj.AttrMinClusterSize.Value;
  }
  return s;
}

public static Func<ST_30625b4ad0f3e10abf82b61ea58e8644Structure, ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_30625b4ad0f3e10abf82b61ea58e8644Structure s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure FromStructure(ST_30625b4ad0f3e10abf82b61ea58e8644Structure s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONST_30625b4ad0f3e10abf82b61ea58e8644Structure(s, config);
}

}


