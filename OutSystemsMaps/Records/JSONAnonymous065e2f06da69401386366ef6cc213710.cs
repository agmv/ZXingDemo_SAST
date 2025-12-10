using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// LatLngRecord
public class JSONRC_df0786951d2357ea5f13ac02dccd68c2 : AbstractRESTStructure<RC_df0786951d2357ea5f13ac02dccd68c2> {
[JsonProperty("Lat")]
[JsonPropertyName("Lat")]
public decimal? AttrLat;

[JsonProperty("Lng")]
[JsonPropertyName("Lng")]
public decimal? AttrLng;

public JSONRC_df0786951d2357ea5f13ac02dccd68c2() { }

public JSONRC_df0786951d2357ea5f13ac02dccd68c2 (RC_df0786951d2357ea5f13ac02dccd68c2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLat = ConvertToRestWithoutDefaults(s.ssLat, 0.0M);
AttrLng = ConvertToRestWithoutDefaults(s.ssLng, 0.0M);
  } else {
AttrLat = (decimal?) s.ssLat;
AttrLng = (decimal?) s.ssLng;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2, RC_df0786951d2357ea5f13ac02dccd68c2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2 s) => ToStructure(s, config);
}
public static RC_df0786951d2357ea5f13ac02dccd68c2 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2 obj, IBehaviorsConfiguration config) { 
  RC_df0786951d2357ea5f13ac02dccd68c2 s = new RC_df0786951d2357ea5f13ac02dccd68c2();
  if(obj != null) {
  s.ssLat = obj.AttrLat == null ? 0.0M : obj.AttrLat.Value;
  s.ssLng = obj.AttrLng == null ? 0.0M : obj.AttrLng.Value;
  }
  return s;
}

public static Func<RC_df0786951d2357ea5f13ac02dccd68c2, ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df0786951d2357ea5f13ac02dccd68c2 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2 FromStructure(RC_df0786951d2357ea5f13ac02dccd68c2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_df0786951d2357ea5f13ac02dccd68c2(s, config);
}

}


