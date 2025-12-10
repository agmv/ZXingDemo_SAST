using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalStaticMapConfigsRecord
public class JSONRC_003de7652ef70684ee40ecb9c31ff117 : AbstractRESTStructure<RC_003de7652ef70684ee40ecb9c31ff117> {
[JsonProperty("OptionalStaticMapConfigs")]
[JsonPropertyName("OptionalStaticMapConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_b2c05afcf4810ad0d4384a01306bb0f3Structure AttrOptionalStaticMapConfigs;

public JSONRC_003de7652ef70684ee40ecb9c31ff117() { }

public JSONRC_003de7652ef70684ee40ecb9c31ff117 (RC_003de7652ef70684ee40ecb9c31ff117 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalStaticMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalStaticMapConfigs, new ST_b2c05afcf4810ad0d4384a01306bb0f3Structure(), ssOutSystemsMaps.RestRecords.JSONST_b2c05afcf4810ad0d4384a01306bb0f3Structure.FromStructureDelegate(config));
  } else {
AttrOptionalStaticMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_b2c05afcf4810ad0d4384a01306bb0f3Structure.FromStructure(s.ssSTOptionalStaticMapConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117, RC_003de7652ef70684ee40ecb9c31ff117> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117 s) => ToStructure(s, config);
}
public static RC_003de7652ef70684ee40ecb9c31ff117 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117 obj, IBehaviorsConfiguration config) { 
  RC_003de7652ef70684ee40ecb9c31ff117 s = new RC_003de7652ef70684ee40ecb9c31ff117();
  if(obj != null) {
  s.ssSTOptionalStaticMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_b2c05afcf4810ad0d4384a01306bb0f3Structure.ToStructure(obj.AttrOptionalStaticMapConfigs, config);
  }
  return s;
}

public static Func<RC_003de7652ef70684ee40ecb9c31ff117, ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003de7652ef70684ee40ecb9c31ff117 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117 FromStructure(RC_003de7652ef70684ee40ecb9c31ff117 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_003de7652ef70684ee40ecb9c31ff117(s, config);
}

}


