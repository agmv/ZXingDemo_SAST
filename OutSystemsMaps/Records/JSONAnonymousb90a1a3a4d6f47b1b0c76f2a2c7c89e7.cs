using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesErrorsRecord
public class JSONRC_28b5debce9c04e64c6dd40275449bf6c : AbstractRESTStructure<RC_28b5debce9c04e64c6dd40275449bf6c> {
[JsonProperty("SearchPlacesErrors")]
[JsonPropertyName("SearchPlacesErrors")]
public ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord AttrSearchPlacesErrors;

public JSONRC_28b5debce9c04e64c6dd40275449bf6c() { }

public JSONRC_28b5debce9c04e64c6dd40275449bf6c (RC_28b5debce9c04e64c6dd40275449bf6c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSearchPlacesErrors = ConvertToRestWithoutDefaults(s.ssENSearchPlacesErrors, new EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord.FromStructureDelegate(config));
  } else {
AttrSearchPlacesErrors = ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord.FromStructure(s.ssENSearchPlacesErrors, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c, RC_28b5debce9c04e64c6dd40275449bf6c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c s) => ToStructure(s, config);
}
public static RC_28b5debce9c04e64c6dd40275449bf6c ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c obj, IBehaviorsConfiguration config) { 
  RC_28b5debce9c04e64c6dd40275449bf6c s = new RC_28b5debce9c04e64c6dd40275449bf6c();
  if(obj != null) {
  s.ssENSearchPlacesErrors = ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord.ToStructure(obj.AttrSearchPlacesErrors, config);
  }
  return s;
}

public static Func<RC_28b5debce9c04e64c6dd40275449bf6c, ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_28b5debce9c04e64c6dd40275449bf6c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c FromStructure(RC_28b5debce9c04e64c6dd40275449bf6c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_28b5debce9c04e64c6dd40275449bf6c(s, config);
}

}


