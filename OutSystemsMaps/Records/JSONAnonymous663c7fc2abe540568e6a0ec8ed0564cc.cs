using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolylineConfigsRecord
public class JSONRC_3836c6494dc01a6dca1bf0597beb32bb : AbstractRESTStructure<RC_3836c6494dc01a6dca1bf0597beb32bb> {
[JsonProperty("OptionalPolylineConfigs")]
[JsonPropertyName("OptionalPolylineConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure AttrOptionalPolylineConfigs;

public JSONRC_3836c6494dc01a6dca1bf0597beb32bb() { }

public JSONRC_3836c6494dc01a6dca1bf0597beb32bb (RC_3836c6494dc01a6dca1bf0597beb32bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalPolylineConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalPolylineConfigs, new ST_f85923824a33f65ded14770af5377402Structure(), ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure.FromStructureDelegate(config));
  } else {
AttrOptionalPolylineConfigs = ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure.FromStructure(s.ssSTOptionalPolylineConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb, RC_3836c6494dc01a6dca1bf0597beb32bb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb s) => ToStructure(s, config);
}
public static RC_3836c6494dc01a6dca1bf0597beb32bb ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb obj, IBehaviorsConfiguration config) { 
  RC_3836c6494dc01a6dca1bf0597beb32bb s = new RC_3836c6494dc01a6dca1bf0597beb32bb();
  if(obj != null) {
  s.ssSTOptionalPolylineConfigs = ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure.ToStructure(obj.AttrOptionalPolylineConfigs, config);
  }
  return s;
}

public static Func<RC_3836c6494dc01a6dca1bf0597beb32bb, ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3836c6494dc01a6dca1bf0597beb32bb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb FromStructure(RC_3836c6494dc01a6dca1bf0597beb32bb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_3836c6494dc01a6dca1bf0597beb32bb(s, config);
}

}


