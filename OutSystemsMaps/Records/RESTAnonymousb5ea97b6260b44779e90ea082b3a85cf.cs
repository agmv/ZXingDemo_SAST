using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalStaticMapConfigsRecord
public class RESTRC_003de7652ef70684ee40ecb9c31ff117 : AbstractRESTStructure<RC_003de7652ef70684ee40ecb9c31ff117> {
[JsonProperty("OptionalStaticMapConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure AttrOptionalStaticMapConfigs;

public RESTRC_003de7652ef70684ee40ecb9c31ff117() { }

public RESTRC_003de7652ef70684ee40ecb9c31ff117 (RC_003de7652ef70684ee40ecb9c31ff117 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalStaticMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalStaticMapConfigs, new ST_b2c05afcf4810ad0d4384a01306bb0f3Structure(), ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure.FromStructureDelegate(config));
  } else {
AttrOptionalStaticMapConfigs = ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure.FromStructure(s.ssSTOptionalStaticMapConfigs, config);
  }
}

public static RC_003de7652ef70684ee40ecb9c31ff117 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_003de7652ef70684ee40ecb9c31ff117 obj) { 
  RC_003de7652ef70684ee40ecb9c31ff117 s = new RC_003de7652ef70684ee40ecb9c31ff117();
  if(obj != null) {
  s.ssSTOptionalStaticMapConfigs = ssOutSystemsMaps.RestRecords.RESTST_b2c05afcf4810ad0d4384a01306bb0f3Structure.ToStructure(obj.AttrOptionalStaticMapConfigs);
  }
  return s;
}

public static Func<RC_003de7652ef70684ee40ecb9c31ff117, ssOutSystemsMaps.RestRecords.RESTRC_003de7652ef70684ee40ecb9c31ff117> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003de7652ef70684ee40ecb9c31ff117 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_003de7652ef70684ee40ecb9c31ff117 FromStructure(RC_003de7652ef70684ee40ecb9c31ff117 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_003de7652ef70684ee40ecb9c31ff117(s, config);
}

}


