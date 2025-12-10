using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Bounds
public class JSONST_5fb6f64676b0133fcb572480a766fc9cStructure : AbstractRESTStructure<ST_5fb6f64676b0133fcb572480a766fc9cStructure> {
[JsonProperty("north")]
[JsonPropertyName("north")]
public string AttrNorth;

[JsonProperty("south")]
[JsonPropertyName("south")]
public string AttrSouth;

[JsonProperty("west")]
[JsonPropertyName("west")]
public string AttrWest;

[JsonProperty("east")]
[JsonPropertyName("east")]
public string AttrEast;

public JSONST_5fb6f64676b0133fcb572480a766fc9cStructure() { }

public JSONST_5fb6f64676b0133fcb572480a766fc9cStructure (ST_5fb6f64676b0133fcb572480a766fc9cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNorth = ConvertToRestWithoutDefaults(s.ssNorth, "");
AttrSouth = ConvertToRestWithoutDefaults(s.ssSouth, "");
AttrWest = ConvertToRestWithoutDefaults(s.ssWest, "");
AttrEast = ConvertToRestWithoutDefaults(s.ssEast, "");
  } else {
AttrNorth = s.ssNorth;
AttrSouth = s.ssSouth;
AttrWest = s.ssWest;
AttrEast = s.ssEast;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure, ST_5fb6f64676b0133fcb572480a766fc9cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure s) => ToStructure(s, config);
}
public static ST_5fb6f64676b0133fcb572480a766fc9cStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure obj, IBehaviorsConfiguration config) { 
  ST_5fb6f64676b0133fcb572480a766fc9cStructure s = new ST_5fb6f64676b0133fcb572480a766fc9cStructure();
  if(obj != null) {
  s.ssNorth = obj.AttrNorth == null ? "" : obj.AttrNorth;
  s.ssSouth = obj.AttrSouth == null ? "" : obj.AttrSouth;
  s.ssWest = obj.AttrWest == null ? "" : obj.AttrWest;
  s.ssEast = obj.AttrEast == null ? "" : obj.AttrEast;
  }
  return s;
}

public static Func<ST_5fb6f64676b0133fcb572480a766fc9cStructure, ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5fb6f64676b0133fcb572480a766fc9cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure FromStructure(ST_5fb6f64676b0133fcb572480a766fc9cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_5fb6f64676b0133fcb572480a766fc9cStructure(s, config);
}

}


