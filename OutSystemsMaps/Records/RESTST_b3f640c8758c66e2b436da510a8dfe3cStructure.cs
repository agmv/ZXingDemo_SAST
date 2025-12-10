using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawCircle_Shape
public class RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure : AbstractRESTStructure<ST_b3f640c8758c66e2b436da510a8dfe3cStructure> {
[JsonProperty("Location")]
public string AttrLocation;

[JsonProperty("Radius")]
public decimal? AttrRadius;

public RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure() { }

public RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure (ST_b3f640c8758c66e2b436da510a8dfe3cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLocation = ConvertToRestWithoutDefaults(s.ssLocation, "");
AttrRadius = ConvertToRestWithoutDefaults(s.ssRadius, 0.0M);
  } else {
AttrLocation = s.ssLocation;
AttrRadius = (decimal?) s.ssRadius;
  }
}

public static ST_b3f640c8758c66e2b436da510a8dfe3cStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure obj) { 
  ST_b3f640c8758c66e2b436da510a8dfe3cStructure s = new ST_b3f640c8758c66e2b436da510a8dfe3cStructure();
  if(obj != null) {
  s.ssLocation = obj.AttrLocation == null ? "" : obj.AttrLocation;
  s.ssRadius = obj.AttrRadius == null ? 0.0M : obj.AttrRadius.Value;
  }
  return s;
}

public static Func<ST_b3f640c8758c66e2b436da510a8dfe3cStructure, ssOutSystemsMaps.RestRecords.RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b3f640c8758c66e2b436da510a8dfe3cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure FromStructure(ST_b3f640c8758c66e2b436da510a8dfe3cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_b3f640c8758c66e2b436da510a8dfe3cStructure(s, config);
}

}


