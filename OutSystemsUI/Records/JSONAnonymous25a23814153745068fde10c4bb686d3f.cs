using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ButtonLoading_InternalConfigRecord
public class JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e : AbstractRESTStructure<RC_f4b8704cebd53b0a2ed361a846fc1b0e> {
[JsonProperty("ButtonLoading_InternalConfig")]
[JsonPropertyName("ButtonLoading_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure AttrButtonLoading_InternalConfig;

public JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e() { }

public JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e (RC_f4b8704cebd53b0a2ed361a846fc1b0e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrButtonLoading_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTButtonLoading_InternalConfig, new ST_2b510eefd88959a00bf486cfc856fa96Structure(), ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure.FromStructureDelegate(config));
  } else {
AttrButtonLoading_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure.FromStructure(s.ssSTButtonLoading_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e, RC_f4b8704cebd53b0a2ed361a846fc1b0e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e s) => ToStructure(s, config);
}
public static RC_f4b8704cebd53b0a2ed361a846fc1b0e ToStructure(ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e obj, IBehaviorsConfiguration config) { 
  RC_f4b8704cebd53b0a2ed361a846fc1b0e s = new RC_f4b8704cebd53b0a2ed361a846fc1b0e();
  if(obj != null) {
  s.ssSTButtonLoading_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_2b510eefd88959a00bf486cfc856fa96Structure.ToStructure(obj.AttrButtonLoading_InternalConfig, config);
  }
  return s;
}

public static Func<RC_f4b8704cebd53b0a2ed361a846fc1b0e, ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f4b8704cebd53b0a2ed361a846fc1b0e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e FromStructure(RC_f4b8704cebd53b0a2ed361a846fc1b0e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_f4b8704cebd53b0a2ed361a846fc1b0e(s, config);
}

}


