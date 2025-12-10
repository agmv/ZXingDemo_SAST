using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Bounds
public class RESTST_5fb6f64676b0133fcb572480a766fc9cStructure : AbstractRESTStructure<ST_5fb6f64676b0133fcb572480a766fc9cStructure> {
[JsonProperty("North")]
public string AttrNorth;

[JsonProperty("South")]
public string AttrSouth;

[JsonProperty("West")]
public string AttrWest;

[JsonProperty("East")]
public string AttrEast;

public RESTST_5fb6f64676b0133fcb572480a766fc9cStructure() { }

public RESTST_5fb6f64676b0133fcb572480a766fc9cStructure (ST_5fb6f64676b0133fcb572480a766fc9cStructure s, IBehaviorsConfiguration config) {
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

public static ST_5fb6f64676b0133fcb572480a766fc9cStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure obj) { 
  ST_5fb6f64676b0133fcb572480a766fc9cStructure s = new ST_5fb6f64676b0133fcb572480a766fc9cStructure();
  if(obj != null) {
  s.ssNorth = obj.AttrNorth == null ? "" : obj.AttrNorth;
  s.ssSouth = obj.AttrSouth == null ? "" : obj.AttrSouth;
  s.ssWest = obj.AttrWest == null ? "" : obj.AttrWest;
  s.ssEast = obj.AttrEast == null ? "" : obj.AttrEast;
  }
  return s;
}

public static Func<ST_5fb6f64676b0133fcb572480a766fc9cStructure, ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5fb6f64676b0133fcb572480a766fc9cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure FromStructure(ST_5fb6f64676b0133fcb572480a766fc9cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_5fb6f64676b0133fcb572480a766fc9cStructure(s, config);
}

}


