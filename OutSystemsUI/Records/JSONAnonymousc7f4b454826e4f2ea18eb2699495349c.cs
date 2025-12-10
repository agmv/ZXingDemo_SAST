using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressCircleOptionalConfigsRecord
public class JSONRC_646e6c02297b69c2ac8936bd87cff545 : AbstractRESTStructure<RC_646e6c02297b69c2ac8936bd87cff545> {
[JsonProperty("ProgressCircleOptionalConfigs")]
[JsonPropertyName("ProgressCircleOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_eb161a8909408fbd30eac1833398f018Structure AttrProgressCircleOptionalConfigs;

public JSONRC_646e6c02297b69c2ac8936bd87cff545() { }

public JSONRC_646e6c02297b69c2ac8936bd87cff545 (RC_646e6c02297b69c2ac8936bd87cff545 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressCircleOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTProgressCircleOptionalConfigs, new ST_eb161a8909408fbd30eac1833398f018Structure(), ssOutSystemsUI.RestRecords.JSONST_eb161a8909408fbd30eac1833398f018Structure.FromStructureDelegate(config));
  } else {
AttrProgressCircleOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_eb161a8909408fbd30eac1833398f018Structure.FromStructure(s.ssSTProgressCircleOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545, RC_646e6c02297b69c2ac8936bd87cff545> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545 s) => ToStructure(s, config);
}
public static RC_646e6c02297b69c2ac8936bd87cff545 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545 obj, IBehaviorsConfiguration config) { 
  RC_646e6c02297b69c2ac8936bd87cff545 s = new RC_646e6c02297b69c2ac8936bd87cff545();
  if(obj != null) {
  s.ssSTProgressCircleOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_eb161a8909408fbd30eac1833398f018Structure.ToStructure(obj.AttrProgressCircleOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_646e6c02297b69c2ac8936bd87cff545, ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_646e6c02297b69c2ac8936bd87cff545 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545 FromStructure(RC_646e6c02297b69c2ac8936bd87cff545 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_646e6c02297b69c2ac8936bd87cff545(s, config);
}

}


