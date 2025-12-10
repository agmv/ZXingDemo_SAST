using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_drawMarker_configsRecord
public class RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca : AbstractRESTStructure<RC_68b38ef52a6c43d6a00c9748c6ced1ca> {
[JsonProperty("Internal_to_provider_drawMarker_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure AttrInternal_to_provider_drawMarker_configs;

public RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca() { }

public RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca (RC_68b38ef52a6c43d6a00c9748c6ced1ca s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_drawMarker_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_drawMarker_configs, new ST_f121435b3edb481ee03ab7ef58e5b805Structure(), ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_drawMarker_configs = ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure.FromStructure(s.ssSTInternal_to_provider_drawMarker_configs, config);
  }
}

public static RC_68b38ef52a6c43d6a00c9748c6ced1ca ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca obj) { 
  RC_68b38ef52a6c43d6a00c9748c6ced1ca s = new RC_68b38ef52a6c43d6a00c9748c6ced1ca();
  if(obj != null) {
  s.ssSTInternal_to_provider_drawMarker_configs = ssOutSystemsMaps.RestRecords.RESTST_f121435b3edb481ee03ab7ef58e5b805Structure.ToStructure(obj.AttrInternal_to_provider_drawMarker_configs);
  }
  return s;
}

public static Func<RC_68b38ef52a6c43d6a00c9748c6ced1ca, ssOutSystemsMaps.RestRecords.RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_68b38ef52a6c43d6a00c9748c6ced1ca s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca FromStructure(RC_68b38ef52a6c43d6a00c9748c6ced1ca s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_68b38ef52a6c43d6a00c9748c6ced1ca(s, config);
}

}


