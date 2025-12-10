using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolygonConfigsRecord
public class JSONRC_48d7c166849f4c26288a543a51543b8d : AbstractRESTStructure<RC_48d7c166849f4c26288a543a51543b8d> {
[JsonProperty("OptionalPolygonConfigs")]
[JsonPropertyName("OptionalPolygonConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure AttrOptionalPolygonConfigs;

public JSONRC_48d7c166849f4c26288a543a51543b8d() { }

public JSONRC_48d7c166849f4c26288a543a51543b8d (RC_48d7c166849f4c26288a543a51543b8d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalPolygonConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalPolygonConfigs, new ST_49045fb6574dc7f29ee1f97116ecb1f6Structure(), ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure.FromStructureDelegate(config));
  } else {
AttrOptionalPolygonConfigs = ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure.FromStructure(s.ssSTOptionalPolygonConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d, RC_48d7c166849f4c26288a543a51543b8d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d s) => ToStructure(s, config);
}
public static RC_48d7c166849f4c26288a543a51543b8d ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d obj, IBehaviorsConfiguration config) { 
  RC_48d7c166849f4c26288a543a51543b8d s = new RC_48d7c166849f4c26288a543a51543b8d();
  if(obj != null) {
  s.ssSTOptionalPolygonConfigs = ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure.ToStructure(obj.AttrOptionalPolygonConfigs, config);
  }
  return s;
}

public static Func<RC_48d7c166849f4c26288a543a51543b8d, ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_48d7c166849f4c26288a543a51543b8d s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d FromStructure(RC_48d7c166849f4c26288a543a51543b8d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_48d7c166849f4c26288a543a51543b8d(s, config);
}

}


