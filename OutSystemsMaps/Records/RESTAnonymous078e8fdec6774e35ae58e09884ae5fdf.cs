using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_SearchPlaces_ConfigsRecord
public class RESTRC_31c29444fafad199d1156f5f03b41f57 : AbstractRESTStructure<RC_31c29444fafad199d1156f5f03b41f57> {
[JsonProperty("Internal_SearchPlaces_Configs")]
public ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure AttrInternal_SearchPlaces_Configs;

public RESTRC_31c29444fafad199d1156f5f03b41f57() { }

public RESTRC_31c29444fafad199d1156f5f03b41f57 (RC_31c29444fafad199d1156f5f03b41f57 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_SearchPlaces_Configs = ConvertToRestWithoutDefaults(s.ssSTInternal_SearchPlaces_Configs, new ST_b0933bf7957301c22e5d9229ad792ac0Structure(), ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure.FromStructureDelegate(config));
  } else {
AttrInternal_SearchPlaces_Configs = ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure.FromStructure(s.ssSTInternal_SearchPlaces_Configs, config);
  }
}

public static RC_31c29444fafad199d1156f5f03b41f57 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_31c29444fafad199d1156f5f03b41f57 obj) { 
  RC_31c29444fafad199d1156f5f03b41f57 s = new RC_31c29444fafad199d1156f5f03b41f57();
  if(obj != null) {
  s.ssSTInternal_SearchPlaces_Configs = ssOutSystemsMaps.RestRecords.RESTST_b0933bf7957301c22e5d9229ad792ac0Structure.ToStructure(obj.AttrInternal_SearchPlaces_Configs);
  }
  return s;
}

public static Func<RC_31c29444fafad199d1156f5f03b41f57, ssOutSystemsMaps.RestRecords.RESTRC_31c29444fafad199d1156f5f03b41f57> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_31c29444fafad199d1156f5f03b41f57 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_31c29444fafad199d1156f5f03b41f57 FromStructure(RC_31c29444fafad199d1156f5f03b41f57 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_31c29444fafad199d1156f5f03b41f57(s, config);
}

}


