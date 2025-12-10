using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_marker_configsRecord
public class JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d : AbstractRESTStructure<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> {
[JsonProperty("Internal_to_provider_marker_configs")]
[JsonPropertyName("Internal_to_provider_marker_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure AttrInternal_to_provider_marker_configs;

public JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d() { }

public JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_marker_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_marker_configs, new ST_51ef6a78944132edc56aa7bf7c4ea240Structure(), ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructure(s.ssSTInternal_to_provider_marker_configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d, RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d s) => ToStructure(s, config);
}
public static RC_fc0e8940fcfc7ecaecb548b5cf8eab5d ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d obj, IBehaviorsConfiguration config) { 
  RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s = new RC_fc0e8940fcfc7ecaecb548b5cf8eab5d();
  if(obj != null) {
  s.ssSTInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.ToStructure(obj.AttrInternal_to_provider_marker_configs, config);
  }
  return s;
}

public static Func<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d, ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d FromStructure(RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_fc0e8940fcfc7ecaecb548b5cf8eab5d(s, config);
}

}


