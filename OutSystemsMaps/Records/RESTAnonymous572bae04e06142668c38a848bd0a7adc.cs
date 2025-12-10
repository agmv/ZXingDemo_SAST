using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_searchPlaces_configsRecord
public class RESTRC_5b713573f61d6f7da10c24ba6dcff0a5 : AbstractRESTStructure<RC_5b713573f61d6f7da10c24ba6dcff0a5> {
[JsonProperty("Internal_to_provider_searchPlaces_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure AttrInternal_to_provider_searchPlaces_configs;

public RESTRC_5b713573f61d6f7da10c24ba6dcff0a5() { }

public RESTRC_5b713573f61d6f7da10c24ba6dcff0a5 (RC_5b713573f61d6f7da10c24ba6dcff0a5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_searchPlaces_configs = ConvertToRestWithoutDefaults(s.ssSTInternal_to_provider_searchPlaces_configs, new ST_d4721898ae8c007cd938074f575e2979Structure(), ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure.FromStructureDelegate(config));
  } else {
AttrInternal_to_provider_searchPlaces_configs = ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure.FromStructure(s.ssSTInternal_to_provider_searchPlaces_configs, config);
  }
}

public static RC_5b713573f61d6f7da10c24ba6dcff0a5 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_5b713573f61d6f7da10c24ba6dcff0a5 obj) { 
  RC_5b713573f61d6f7da10c24ba6dcff0a5 s = new RC_5b713573f61d6f7da10c24ba6dcff0a5();
  if(obj != null) {
  s.ssSTInternal_to_provider_searchPlaces_configs = ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure.ToStructure(obj.AttrInternal_to_provider_searchPlaces_configs);
  }
  return s;
}

public static Func<RC_5b713573f61d6f7da10c24ba6dcff0a5, ssOutSystemsMaps.RestRecords.RESTRC_5b713573f61d6f7da10c24ba6dcff0a5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b713573f61d6f7da10c24ba6dcff0a5 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_5b713573f61d6f7da10c24ba6dcff0a5 FromStructure(RC_5b713573f61d6f7da10c24ba6dcff0a5 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_5b713573f61d6f7da10c24ba6dcff0a5(s, config);
}

}


