using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_SearchPlaces_Configs
public class JSONST_b0933bf7957301c22e5d9229ad792ac0Structure : AbstractRESTStructure<ST_b0933bf7957301c22e5d9229ad792ac0Structure> {
[JsonProperty("Internal_to_provider_configs")]
[JsonPropertyName("Internal_to_provider_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure AttrInternal_to_provider_configs;

[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

public JSONST_b0933bf7957301c22e5d9229ad792ac0Structure() { }

public JSONST_b0933bf7957301c22e5d9229ad792ac0Structure (ST_b0933bf7957301c22e5d9229ad792ac0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_configs, new ST_d4721898ae8c007cd938074f575e2979Structure(), ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.FromStructure(s.ssInternal_to_provider_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure, ST_b0933bf7957301c22e5d9229ad792ac0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure s) => ToStructure(s, config);
}
public static ST_b0933bf7957301c22e5d9229ad792ac0Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure obj, IBehaviorsConfiguration config) { 
  ST_b0933bf7957301c22e5d9229ad792ac0Structure s = new ST_b0933bf7957301c22e5d9229ad792ac0Structure();
  if(obj != null) {
  s.ssInternal_to_provider_configs = ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure.ToStructure(obj.AttrInternal_to_provider_configs, config);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_b0933bf7957301c22e5d9229ad792ac0Structure, ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b0933bf7957301c22e5d9229ad792ac0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure FromStructure(ST_b0933bf7957301c22e5d9229ad792ac0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_b0933bf7957301c22e5d9229ad792ac0Structure(s, config);
}

}


