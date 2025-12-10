using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_Shape_ConfigsRecord
public class JSONRC_6beef079e29e7256385ac77b93f8d4bb : AbstractRESTStructure<RC_6beef079e29e7256385ac77b93f8d4bb> {
[JsonProperty("Internal_Shape_Configs")]
[JsonPropertyName("Internal_Shape_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure AttrInternal_Shape_Configs;

public JSONRC_6beef079e29e7256385ac77b93f8d4bb() { }

public JSONRC_6beef079e29e7256385ac77b93f8d4bb (RC_6beef079e29e7256385ac77b93f8d4bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_Shape_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_Shape_Configs, new ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure(), ssOutSystemsMaps.RestRecords.JSONST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.FromStructureDelegate(config));
  } else {
AttrInternal_Shape_Configs = ssOutSystemsMaps.RestRecords.JSONST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.FromStructure(s.ssSTInternal_Shape_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb, RC_6beef079e29e7256385ac77b93f8d4bb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb s) => ToStructure(s, config);
}
public static RC_6beef079e29e7256385ac77b93f8d4bb ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb obj, IBehaviorsConfiguration config) { 
  RC_6beef079e29e7256385ac77b93f8d4bb s = new RC_6beef079e29e7256385ac77b93f8d4bb();
  if(obj != null) {
  s.ssSTInternal_Shape_Configs = ssOutSystemsMaps.RestRecords.JSONST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.ToStructure(obj.AttrInternal_Shape_Configs, config);
  }
  return s;
}

public static Func<RC_6beef079e29e7256385ac77b93f8d4bb, ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6beef079e29e7256385ac77b93f8d4bb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb FromStructure(RC_6beef079e29e7256385ac77b93f8d4bb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_6beef079e29e7256385ac77b93f8d4bb(s, config);
}

}


