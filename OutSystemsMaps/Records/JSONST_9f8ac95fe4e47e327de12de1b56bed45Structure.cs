using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Private_MarkerClusterer
public class JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure : AbstractRESTStructure<ST_9f8ac95fe4e47e327de12de1b56bed45Structure> {
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

public JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure() { }

public JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure (ST_9f8ac95fe4e47e327de12de1b56bed45Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure, ST_9f8ac95fe4e47e327de12de1b56bed45Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure s) => ToStructure(s, config);
}
public static ST_9f8ac95fe4e47e327de12de1b56bed45Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure obj, IBehaviorsConfiguration config) { 
  ST_9f8ac95fe4e47e327de12de1b56bed45Structure s = new ST_9f8ac95fe4e47e327de12de1b56bed45Structure();
  if(obj != null) {
  s.ssActive = obj.AttrActive == null ? false : obj.AttrActive.Value;
  s.ssMaxZoom = obj.AttrMaxZoom == null ? 0 : obj.AttrMaxZoom.Value;
  s.ssZoomOnClick = obj.AttrZoomOnClick == null ? true : obj.AttrZoomOnClick.Value;
  s.ssMinClusterSize = obj.AttrMinClusterSize == null ? 2 : obj.AttrMinClusterSize.Value;
  }
  return s;
}

public static Func<ST_9f8ac95fe4e47e327de12de1b56bed45Structure, ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9f8ac95fe4e47e327de12de1b56bed45Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure FromStructure(ST_9f8ac95fe4e47e327de12de1b56bed45Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_9f8ac95fe4e47e327de12de1b56bed45Structure(s, config);
}

}


