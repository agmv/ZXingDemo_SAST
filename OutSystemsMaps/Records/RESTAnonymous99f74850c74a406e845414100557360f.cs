using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalFileLayerConfigsRecord
public class RESTRC_a13c14b9ba27332cf1eb1f7147c42c92 : AbstractRESTStructure<RC_a13c14b9ba27332cf1eb1f7147c42c92> {
[JsonProperty("OptionalFileLayerConfigs")]
public ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure AttrOptionalFileLayerConfigs;

public RESTRC_a13c14b9ba27332cf1eb1f7147c42c92() { }

public RESTRC_a13c14b9ba27332cf1eb1f7147c42c92 (RC_a13c14b9ba27332cf1eb1f7147c42c92 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalFileLayerConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalFileLayerConfigs, new ST_2bb06e37aea9715ba999f70106cf37a5Structure(), ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure.FromStructureDelegate(config));
  } else {
AttrOptionalFileLayerConfigs = ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure.FromStructure(s.ssSTOptionalFileLayerConfigs, config);
  }
}

public static RC_a13c14b9ba27332cf1eb1f7147c42c92 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_a13c14b9ba27332cf1eb1f7147c42c92 obj) { 
  RC_a13c14b9ba27332cf1eb1f7147c42c92 s = new RC_a13c14b9ba27332cf1eb1f7147c42c92();
  if(obj != null) {
  s.ssSTOptionalFileLayerConfigs = ssOutSystemsMaps.RestRecords.RESTST_2bb06e37aea9715ba999f70106cf37a5Structure.ToStructure(obj.AttrOptionalFileLayerConfigs);
  }
  return s;
}

public static Func<RC_a13c14b9ba27332cf1eb1f7147c42c92, ssOutSystemsMaps.RestRecords.RESTRC_a13c14b9ba27332cf1eb1f7147c42c92> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a13c14b9ba27332cf1eb1f7147c42c92 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_a13c14b9ba27332cf1eb1f7147c42c92 FromStructure(RC_a13c14b9ba27332cf1eb1f7147c42c92 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_a13c14b9ba27332cf1eb1f7147c42c92(s, config);
}

}


