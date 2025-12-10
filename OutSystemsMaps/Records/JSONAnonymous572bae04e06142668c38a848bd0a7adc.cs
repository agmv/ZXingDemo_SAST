using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_searchPlaces_configsRecord
public class JSONRC_5b713573f61d6f7da10c24ba6dcff0a5 : AbstractRESTStructure<RC_5b713573f61d6f7da10c24ba6dcff0a5> {
[JsonProperty("Internal_to_provider_searchPlaces_configs")]
[JsonPropertyName("Internal_to_provider_searchPlaces_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure AttrInternal_to_provider_searchPlaces_configs;

public JSONRC_5b713573f61d6f7da10c24ba6dcff0a5() { }

public JSONRC_5b713573f61d6f7da10c24ba6dcff0a5 (RC_5b713573f61d6f7da10c24ba6dcff0a5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_searchPlaces_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_searchPlaces_configs, new ST_d4721898ae8c007cd938074f575e2979Structure(), ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_searchPlaces_configs = ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.FromStructure(s.ssSTInternal_to_provider_searchPlaces_configs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5, RC_5b713573f61d6f7da10c24ba6dcff0a5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5 s) => ToStructure(s, config);
}
public static RC_5b713573f61d6f7da10c24ba6dcff0a5 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5 obj, IBehaviorsConfiguration config) { 
  RC_5b713573f61d6f7da10c24ba6dcff0a5 s = new RC_5b713573f61d6f7da10c24ba6dcff0a5();
  if(obj != null) {
  s.ssSTInternal_to_provider_searchPlaces_configs = ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.ToStructure(obj.AttrInternal_to_provider_searchPlaces_configs, config);
  }
  return s;
}

public static Func<RC_5b713573f61d6f7da10c24ba6dcff0a5, ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b713573f61d6f7da10c24ba6dcff0a5 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5 FromStructure(RC_5b713573f61d6f7da10c24ba6dcff0a5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_5b713573f61d6f7da10c24ba6dcff0a5(s, config);
}

}


