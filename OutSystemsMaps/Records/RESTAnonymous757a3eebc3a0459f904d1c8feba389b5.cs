using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalSearchPlacesConfigsRecord
public class RESTRC_27d8031b19e05deba9a159874d88bc75 : AbstractRESTStructure<RC_27d8031b19e05deba9a159874d88bc75> {
[JsonProperty("OptionalSearchPlacesConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure AttrOptionalSearchPlacesConfigs;

public RESTRC_27d8031b19e05deba9a159874d88bc75() { }

public RESTRC_27d8031b19e05deba9a159874d88bc75 (RC_27d8031b19e05deba9a159874d88bc75 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalSearchPlacesConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalSearchPlacesConfigs, new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure(), ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure.FromStructureDelegate(config));
  } else {
AttrOptionalSearchPlacesConfigs = ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure.FromStructure(s.ssSTOptionalSearchPlacesConfigs, config);
  }
}

public static RC_27d8031b19e05deba9a159874d88bc75 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_27d8031b19e05deba9a159874d88bc75 obj) { 
  RC_27d8031b19e05deba9a159874d88bc75 s = new RC_27d8031b19e05deba9a159874d88bc75();
  if(obj != null) {
  s.ssSTOptionalSearchPlacesConfigs = ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure.ToStructure(obj.AttrOptionalSearchPlacesConfigs);
  }
  return s;
}

public static Func<RC_27d8031b19e05deba9a159874d88bc75, ssOutSystemsMaps.RestRecords.RESTRC_27d8031b19e05deba9a159874d88bc75> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27d8031b19e05deba9a159874d88bc75 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_27d8031b19e05deba9a159874d88bc75 FromStructure(RC_27d8031b19e05deba9a159874d88bc75 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_27d8031b19e05deba9a159874d88bc75(s, config);
}

}


