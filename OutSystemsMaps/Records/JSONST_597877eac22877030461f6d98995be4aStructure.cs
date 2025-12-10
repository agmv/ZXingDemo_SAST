using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalLeafletMapConfigs
public class JSONST_597877eac22877030461f6d98995be4aStructure : AbstractRESTStructure<ST_597877eac22877030461f6d98995be4aStructure> {
[JsonProperty("AutoZoomOnShapes")]
[JsonPropertyName("AutoZoomOnShapes")]
public bool? AttrAutoZoomOnShapes;

[JsonProperty("Offset")]
[JsonPropertyName("Offset")]
public ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure AttrOffset;

[JsonProperty("respectUserZoom")]
[JsonPropertyName("respectUserZoom")]
public bool? AttrRespectUserZoom;

[JsonProperty("Zoom")]
[JsonPropertyName("Zoom")]
public int? AttrZoom;

public JSONST_597877eac22877030461f6d98995be4aStructure() { }

public JSONST_597877eac22877030461f6d98995be4aStructure (ST_597877eac22877030461f6d98995be4aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoZoomOnShapes = ConvertToRestWithoutDefaults(s.ssAutoZoomOnShapes, false);
AttrOffset = ConvertToRestWithoutDefaults(s.ssOffset, new ST_be62cc31fbe4705834275960beeb55e2Structure(), ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructureDelegate(config));
AttrRespectUserZoom = ConvertToRestWithoutDefaults(s.ssRespectUserZoom, false);
AttrZoom = ConvertToRestWithoutDefaults(s.ssZoom, (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId);
  } else {
AttrAutoZoomOnShapes = (bool?) s.ssAutoZoomOnShapes;
AttrOffset = ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssOffset, config);
AttrRespectUserZoom = (bool?) s.ssRespectUserZoom;
AttrZoom = (int?) s.ssZoom;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure, ST_597877eac22877030461f6d98995be4aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure s) => ToStructure(s, config);
}
public static ST_597877eac22877030461f6d98995be4aStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure obj, IBehaviorsConfiguration config) { 
  ST_597877eac22877030461f6d98995be4aStructure s = new ST_597877eac22877030461f6d98995be4aStructure();
  if(obj != null) {
  s.ssAutoZoomOnShapes = obj.AttrAutoZoomOnShapes == null ? false : obj.AttrAutoZoomOnShapes.Value;
  s.ssOffset = ssOutSystemsMaps.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.AttrOffset, config);
  s.ssRespectUserZoom = obj.AttrRespectUserZoom == null ? false : obj.AttrRespectUserZoom.Value;
  s.ssZoom = obj.AttrZoom == null ? (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId : obj.AttrZoom.Value;
  }
  return s;
}

public static Func<ST_597877eac22877030461f6d98995be4aStructure, ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_597877eac22877030461f6d98995be4aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure FromStructure(ST_597877eac22877030461f6d98995be4aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_597877eac22877030461f6d98995be4aStructure(s, config);
}

}


