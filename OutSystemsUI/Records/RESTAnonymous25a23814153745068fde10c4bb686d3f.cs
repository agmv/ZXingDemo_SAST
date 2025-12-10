using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ButtonLoading_InternalConfigRecord
public class RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e : AbstractRESTStructure<RC_f4b8704cebd53b0a2ed361a846fc1b0e> {
[JsonProperty("ButtonLoading_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_2b510eefd88959a00bf486cfc856fa96Structure AttrButtonLoading_InternalConfig;

public RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e() { }

public RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e (RC_f4b8704cebd53b0a2ed361a846fc1b0e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrButtonLoading_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTButtonLoading_InternalConfig, new ST_2b510eefd88959a00bf486cfc856fa96Structure(), ssOutSystemsUI.RestRecords.RESTST_2b510eefd88959a00bf486cfc856fa96Structure.FromStructureDelegate(config));
  } else {
AttrButtonLoading_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_2b510eefd88959a00bf486cfc856fa96Structure.FromStructure(s.ssSTButtonLoading_InternalConfig, config);
  }
}

public static RC_f4b8704cebd53b0a2ed361a846fc1b0e ToStructure(ssOutSystemsUI.RestRecords.RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e obj) { 
  RC_f4b8704cebd53b0a2ed361a846fc1b0e s = new RC_f4b8704cebd53b0a2ed361a846fc1b0e();
  if(obj != null) {
  s.ssSTButtonLoading_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_2b510eefd88959a00bf486cfc856fa96Structure.ToStructure(obj.AttrButtonLoading_InternalConfig);
  }
  return s;
}

public static Func<RC_f4b8704cebd53b0a2ed361a846fc1b0e, ssOutSystemsUI.RestRecords.RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f4b8704cebd53b0a2ed361a846fc1b0e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e FromStructure(RC_f4b8704cebd53b0a2ed361a846fc1b0e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_f4b8704cebd53b0a2ed361a846fc1b0e(s, config);
}

}


