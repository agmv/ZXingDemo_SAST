using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_SearchPlaces_ConfigsRecord
public class JSONRC_31c29444fafad199d1156f5f03b41f57 : AbstractRESTStructure<RC_31c29444fafad199d1156f5f03b41f57> {
[JsonProperty("Internal_SearchPlaces_Configs")]
[JsonPropertyName("Internal_SearchPlaces_Configs")]
public ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure AttrInternal_SearchPlaces_Configs;

public JSONRC_31c29444fafad199d1156f5f03b41f57() { }

public JSONRC_31c29444fafad199d1156f5f03b41f57 (RC_31c29444fafad199d1156f5f03b41f57 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_SearchPlaces_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_SearchPlaces_Configs, new ST_b0933bf7957301c22e5d9229ad792ac0Structure(), ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure.FromStructureDelegate(config));
  } else {
AttrInternal_SearchPlaces_Configs = ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure.FromStructure(s.ssSTInternal_SearchPlaces_Configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57, RC_31c29444fafad199d1156f5f03b41f57> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57 s) => ToStructure(s, config);
}
public static RC_31c29444fafad199d1156f5f03b41f57 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57 obj, IBehaviorsConfiguration config) { 
  RC_31c29444fafad199d1156f5f03b41f57 s = new RC_31c29444fafad199d1156f5f03b41f57();
  if(obj != null) {
  s.ssSTInternal_SearchPlaces_Configs = ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure.ToStructure(obj.AttrInternal_SearchPlaces_Configs, config);
  }
  return s;
}

public static Func<RC_31c29444fafad199d1156f5f03b41f57, ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_31c29444fafad199d1156f5f03b41f57 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57 FromStructure(RC_31c29444fafad199d1156f5f03b41f57 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_31c29444fafad199d1156f5f03b41f57(s, config);
}

}


