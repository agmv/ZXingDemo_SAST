using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// LatLngRecord
public class RESTRC_df0786951d2357ea5f13ac02dccd68c2 : AbstractRESTStructure<RC_df0786951d2357ea5f13ac02dccd68c2> {
[JsonProperty("Lat")]
public decimal? AttrLat;

[JsonProperty("Lng")]
public decimal? AttrLng;

public RESTRC_df0786951d2357ea5f13ac02dccd68c2() { }

public RESTRC_df0786951d2357ea5f13ac02dccd68c2 (RC_df0786951d2357ea5f13ac02dccd68c2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLat = ConvertToRestWithoutDefaults(s.ssLat, 0.0M);
AttrLng = ConvertToRestWithoutDefaults(s.ssLng, 0.0M);
  } else {
AttrLat = (decimal?) s.ssLat;
AttrLng = (decimal?) s.ssLng;
  }
}

public static RC_df0786951d2357ea5f13ac02dccd68c2 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_df0786951d2357ea5f13ac02dccd68c2 obj) { 
  RC_df0786951d2357ea5f13ac02dccd68c2 s = new RC_df0786951d2357ea5f13ac02dccd68c2();
  if(obj != null) {
  s.ssLat = obj.AttrLat == null ? 0.0M : obj.AttrLat.Value;
  s.ssLng = obj.AttrLng == null ? 0.0M : obj.AttrLng.Value;
  }
  return s;
}

public static Func<RC_df0786951d2357ea5f13ac02dccd68c2, ssOutSystemsMaps.RestRecords.RESTRC_df0786951d2357ea5f13ac02dccd68c2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df0786951d2357ea5f13ac02dccd68c2 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_df0786951d2357ea5f13ac02dccd68c2 FromStructure(RC_df0786951d2357ea5f13ac02dccd68c2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_df0786951d2357ea5f13ac02dccd68c2(s, config);
}

}


