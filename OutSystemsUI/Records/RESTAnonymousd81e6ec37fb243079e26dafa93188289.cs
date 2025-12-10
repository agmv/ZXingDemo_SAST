using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressBar_InternalConfigRecord
public class RESTRC_12cb0160c5b908b286f2418f6f00a5eb : AbstractRESTStructure<RC_12cb0160c5b908b286f2418f6f00a5eb> {
[JsonProperty("ProgressBar_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure AttrProgressBar_InternalConfig;

public RESTRC_12cb0160c5b908b286f2418f6f00a5eb() { }

public RESTRC_12cb0160c5b908b286f2418f6f00a5eb (RC_12cb0160c5b908b286f2418f6f00a5eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressBar_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTProgressBar_InternalConfig, new ST_b29bdecfa7956bb3d5bee97678e39fb0Structure(), ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure.FromStructureDelegate(config));
  } else {
AttrProgressBar_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure.FromStructure(s.ssSTProgressBar_InternalConfig, config);
  }
}

public static RC_12cb0160c5b908b286f2418f6f00a5eb ToStructure(ssOutSystemsUI.RestRecords.RESTRC_12cb0160c5b908b286f2418f6f00a5eb obj) { 
  RC_12cb0160c5b908b286f2418f6f00a5eb s = new RC_12cb0160c5b908b286f2418f6f00a5eb();
  if(obj != null) {
  s.ssSTProgressBar_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_b29bdecfa7956bb3d5bee97678e39fb0Structure.ToStructure(obj.AttrProgressBar_InternalConfig);
  }
  return s;
}

public static Func<RC_12cb0160c5b908b286f2418f6f00a5eb, ssOutSystemsUI.RestRecords.RESTRC_12cb0160c5b908b286f2418f6f00a5eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_12cb0160c5b908b286f2418f6f00a5eb s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_12cb0160c5b908b286f2418f6f00a5eb FromStructure(RC_12cb0160c5b908b286f2418f6f00a5eb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_12cb0160c5b908b286f2418f6f00a5eb(s, config);
}

}


