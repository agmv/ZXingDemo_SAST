using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_shape_configsRecord
public class JSONRC_d566c0a27b8928cd9ecc06f062d869f4 : AbstractRESTStructure<RC_d566c0a27b8928cd9ecc06f062d869f4> {
[JsonProperty("Internal_to_provider_shape_configs")]
[JsonPropertyName("Internal_to_provider_shape_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure AttrInternal_to_provider_shape_configs;

public JSONRC_d566c0a27b8928cd9ecc06f062d869f4() { }

public JSONRC_d566c0a27b8928cd9ecc06f062d869f4 (RC_d566c0a27b8928cd9ecc06f062d869f4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_shape_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_shape_configs, new ST_4d96f69748c4f35fb433f7995d061407Structure(), ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_shape_configs = ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure.FromStructure(s.ssSTInternal_to_provider_shape_configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4, RC_d566c0a27b8928cd9ecc06f062d869f4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4 s) => ToStructure(s, config);
}
public static RC_d566c0a27b8928cd9ecc06f062d869f4 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4 obj, IBehaviorsConfiguration config) { 
  RC_d566c0a27b8928cd9ecc06f062d869f4 s = new RC_d566c0a27b8928cd9ecc06f062d869f4();
  if(obj != null) {
  s.ssSTInternal_to_provider_shape_configs = ssOutSystemsMaps.RestRecords.JSONST_4d96f69748c4f35fb433f7995d061407Structure.ToStructure(obj.AttrInternal_to_provider_shape_configs, config);
  }
  return s;
}

public static Func<RC_d566c0a27b8928cd9ecc06f062d869f4, ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d566c0a27b8928cd9ecc06f062d869f4 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4 FromStructure(RC_d566c0a27b8928cd9ecc06f062d869f4 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_d566c0a27b8928cd9ecc06f062d869f4(s, config);
}

}


