using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalSearchPlacesConfigsRecord
public class JSONRC_27d8031b19e05deba9a159874d88bc75 : AbstractRESTStructure<RC_27d8031b19e05deba9a159874d88bc75> {
[JsonProperty("OptionalSearchPlacesConfigs")]
[JsonPropertyName("OptionalSearchPlacesConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure AttrOptionalSearchPlacesConfigs;

public JSONRC_27d8031b19e05deba9a159874d88bc75() { }

public JSONRC_27d8031b19e05deba9a159874d88bc75 (RC_27d8031b19e05deba9a159874d88bc75 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalSearchPlacesConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalSearchPlacesConfigs, new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure(), ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure.FromStructureDelegate(config));
  } else {
AttrOptionalSearchPlacesConfigs = ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure.FromStructure(s.ssSTOptionalSearchPlacesConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75, RC_27d8031b19e05deba9a159874d88bc75> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75 s) => ToStructure(s, config);
}
public static RC_27d8031b19e05deba9a159874d88bc75 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75 obj, IBehaviorsConfiguration config) { 
  RC_27d8031b19e05deba9a159874d88bc75 s = new RC_27d8031b19e05deba9a159874d88bc75();
  if(obj != null) {
  s.ssSTOptionalSearchPlacesConfigs = ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure.ToStructure(obj.AttrOptionalSearchPlacesConfigs, config);
  }
  return s;
}

public static Func<RC_27d8031b19e05deba9a159874d88bc75, ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27d8031b19e05deba9a159874d88bc75 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75 FromStructure(RC_27d8031b19e05deba9a159874d88bc75 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_27d8031b19e05deba9a159874d88bc75(s, config);
}

}


