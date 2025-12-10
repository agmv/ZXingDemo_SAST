using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressBar_InternalConfigRecord
public class JSONRC_12cb0160c5b908b286f2418f6f00a5eb : AbstractRESTStructure<RC_12cb0160c5b908b286f2418f6f00a5eb> {
[JsonProperty("ProgressBar_InternalConfig")]
[JsonPropertyName("ProgressBar_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_b29bdecfa7956bb3d5bee97678e39fb0Structure AttrProgressBar_InternalConfig;

public JSONRC_12cb0160c5b908b286f2418f6f00a5eb() { }

public JSONRC_12cb0160c5b908b286f2418f6f00a5eb (RC_12cb0160c5b908b286f2418f6f00a5eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressBar_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTProgressBar_InternalConfig, new ST_b29bdecfa7956bb3d5bee97678e39fb0Structure(), ssOutSystemsUI.RestRecords.JSONST_b29bdecfa7956bb3d5bee97678e39fb0Structure.FromStructureDelegate(config));
  } else {
AttrProgressBar_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_b29bdecfa7956bb3d5bee97678e39fb0Structure.FromStructure(s.ssSTProgressBar_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb, RC_12cb0160c5b908b286f2418f6f00a5eb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb s) => ToStructure(s, config);
}
public static RC_12cb0160c5b908b286f2418f6f00a5eb ToStructure(ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb obj, IBehaviorsConfiguration config) { 
  RC_12cb0160c5b908b286f2418f6f00a5eb s = new RC_12cb0160c5b908b286f2418f6f00a5eb();
  if(obj != null) {
  s.ssSTProgressBar_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_b29bdecfa7956bb3d5bee97678e39fb0Structure.ToStructure(obj.AttrProgressBar_InternalConfig, config);
  }
  return s;
}

public static Func<RC_12cb0160c5b908b286f2418f6f00a5eb, ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_12cb0160c5b908b286f2418f6f00a5eb s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb FromStructure(RC_12cb0160c5b908b286f2418f6f00a5eb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_12cb0160c5b908b286f2418f6f00a5eb(s, config);
}

}


