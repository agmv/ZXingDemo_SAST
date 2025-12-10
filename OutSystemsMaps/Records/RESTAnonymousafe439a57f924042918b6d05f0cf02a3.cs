using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_Shape_ConfigsRecord
public class RESTRC_6beef079e29e7256385ac77b93f8d4bb : AbstractRESTStructure<RC_6beef079e29e7256385ac77b93f8d4bb> {
[JsonProperty("Internal_Shape_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure AttrInternal_Shape_Configs;

public RESTRC_6beef079e29e7256385ac77b93f8d4bb() { }

public RESTRC_6beef079e29e7256385ac77b93f8d4bb (RC_6beef079e29e7256385ac77b93f8d4bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_Shape_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_Shape_Configs, new ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure(), ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.FromStructureDelegate(config));
  } else {
AttrInternal_Shape_Configs = ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.FromStructure(s.ssSTInternal_Shape_Configs, config);
  }
}

public static RC_6beef079e29e7256385ac77b93f8d4bb ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_6beef079e29e7256385ac77b93f8d4bb obj) { 
  RC_6beef079e29e7256385ac77b93f8d4bb s = new RC_6beef079e29e7256385ac77b93f8d4bb();
  if(obj != null) {
  s.ssSTInternal_Shape_Configs = ssOutSystemsMaps.RestRecords.RESTST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure.ToStructure(obj.AttrInternal_Shape_Configs);
  }
  return s;
}

public static Func<RC_6beef079e29e7256385ac77b93f8d4bb, ssOutSystemsMaps.RestRecords.RESTRC_6beef079e29e7256385ac77b93f8d4bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6beef079e29e7256385ac77b93f8d4bb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_6beef079e29e7256385ac77b93f8d4bb FromStructure(RC_6beef079e29e7256385ac77b93f8d4bb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_6beef079e29e7256385ac77b93f8d4bb(s, config);
}

}


