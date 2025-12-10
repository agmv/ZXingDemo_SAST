using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolylineConfigsRecord
public class RESTRC_3836c6494dc01a6dca1bf0597beb32bb : AbstractRESTStructure<RC_3836c6494dc01a6dca1bf0597beb32bb> {
[JsonProperty("OptionalPolylineConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure AttrOptionalPolylineConfigs;

public RESTRC_3836c6494dc01a6dca1bf0597beb32bb() { }

public RESTRC_3836c6494dc01a6dca1bf0597beb32bb (RC_3836c6494dc01a6dca1bf0597beb32bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalPolylineConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalPolylineConfigs, new ST_f85923824a33f65ded14770af5377402Structure(), ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure.FromStructureDelegate(config));
  } else {
AttrOptionalPolylineConfigs = ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure.FromStructure(s.ssSTOptionalPolylineConfigs, config);
  }
}

public static RC_3836c6494dc01a6dca1bf0597beb32bb ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_3836c6494dc01a6dca1bf0597beb32bb obj) { 
  RC_3836c6494dc01a6dca1bf0597beb32bb s = new RC_3836c6494dc01a6dca1bf0597beb32bb();
  if(obj != null) {
  s.ssSTOptionalPolylineConfigs = ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure.ToStructure(obj.AttrOptionalPolylineConfigs);
  }
  return s;
}

public static Func<RC_3836c6494dc01a6dca1bf0597beb32bb, ssOutSystemsMaps.RestRecords.RESTRC_3836c6494dc01a6dca1bf0597beb32bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3836c6494dc01a6dca1bf0597beb32bb s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_3836c6494dc01a6dca1bf0597beb32bb FromStructure(RC_3836c6494dc01a6dca1bf0597beb32bb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_3836c6494dc01a6dca1bf0597beb32bb(s, config);
}

}


