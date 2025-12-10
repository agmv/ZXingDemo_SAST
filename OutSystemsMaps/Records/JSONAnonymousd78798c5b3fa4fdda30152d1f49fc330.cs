using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalMapConfigsRecord
public class JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c : AbstractRESTStructure<RC_d761bc5f1b0fe2debf1c3edffd0efd3c> {
[JsonProperty("OptionalMapConfigs")]
[JsonPropertyName("OptionalMapConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_d609eacb476c603df8b92eb374da99faStructure AttrOptionalMapConfigs;

public JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c() { }

public JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c (RC_d761bc5f1b0fe2debf1c3edffd0efd3c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalMapConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalMapConfigs, new ST_d609eacb476c603df8b92eb374da99faStructure(), ssOutSystemsMaps.RestRecords.JSONST_d609eacb476c603df8b92eb374da99faStructure.FromStructureDelegate(config));
  } else {
AttrOptionalMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_d609eacb476c603df8b92eb374da99faStructure.FromStructure(s.ssSTOptionalMapConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c, RC_d761bc5f1b0fe2debf1c3edffd0efd3c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c s) => ToStructure(s, config);
}
public static RC_d761bc5f1b0fe2debf1c3edffd0efd3c ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c obj, IBehaviorsConfiguration config) { 
  RC_d761bc5f1b0fe2debf1c3edffd0efd3c s = new RC_d761bc5f1b0fe2debf1c3edffd0efd3c();
  if(obj != null) {
  s.ssSTOptionalMapConfigs = ssOutSystemsMaps.RestRecords.JSONST_d609eacb476c603df8b92eb374da99faStructure.ToStructure(obj.AttrOptionalMapConfigs, config);
  }
  return s;
}

public static Func<RC_d761bc5f1b0fe2debf1c3edffd0efd3c, ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d761bc5f1b0fe2debf1c3edffd0efd3c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c FromStructure(RC_d761bc5f1b0fe2debf1c3edffd0efd3c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_d761bc5f1b0fe2debf1c3edffd0efd3c(s, config);
}

}


