using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_marker_configsRecord
public class RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d : AbstractRESTStructure<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> {
[JsonProperty("Internal_to_provider_marker_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_51ef6a78944132edc56aa7bf7c4ea240Structure AttrInternal_to_provider_marker_configs;

public RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d() { }

public RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_marker_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_marker_configs, new ST_51ef6a78944132edc56aa7bf7c4ea240Structure(), ssOutSystemsMaps.RestRecords.RESTST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.RESTST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructure(s.ssSTInternal_to_provider_marker_configs, config);
  }
}

public static RC_fc0e8940fcfc7ecaecb548b5cf8eab5d ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d obj) { 
  RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s = new RC_fc0e8940fcfc7ecaecb548b5cf8eab5d();
  if(obj != null) {
  s.ssSTInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.RESTST_51ef6a78944132edc56aa7bf7c4ea240Structure.ToStructure(obj.AttrInternal_to_provider_marker_configs);
  }
  return s;
}

public static Func<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d, ssOutSystemsMaps.RestRecords.RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d FromStructure(RC_fc0e8940fcfc7ecaecb548b5cf8eab5d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_fc0e8940fcfc7ecaecb548b5cf8eab5d(s, config);
}

}


