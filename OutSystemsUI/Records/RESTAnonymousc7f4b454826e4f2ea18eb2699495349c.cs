using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressCircleOptionalConfigsRecord
public class RESTRC_646e6c02297b69c2ac8936bd87cff545 : AbstractRESTStructure<RC_646e6c02297b69c2ac8936bd87cff545> {
[JsonProperty("ProgressCircleOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure AttrProgressCircleOptionalConfigs;

public RESTRC_646e6c02297b69c2ac8936bd87cff545() { }

public RESTRC_646e6c02297b69c2ac8936bd87cff545 (RC_646e6c02297b69c2ac8936bd87cff545 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressCircleOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTProgressCircleOptionalConfigs, new ST_eb161a8909408fbd30eac1833398f018Structure(), ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure.FromStructureDelegate(config));
  } else {
AttrProgressCircleOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure.FromStructure(s.ssSTProgressCircleOptionalConfigs, config);
  }
}

public static RC_646e6c02297b69c2ac8936bd87cff545 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_646e6c02297b69c2ac8936bd87cff545 obj) { 
  RC_646e6c02297b69c2ac8936bd87cff545 s = new RC_646e6c02297b69c2ac8936bd87cff545();
  if(obj != null) {
  s.ssSTProgressCircleOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_eb161a8909408fbd30eac1833398f018Structure.ToStructure(obj.AttrProgressCircleOptionalConfigs);
  }
  return s;
}

public static Func<RC_646e6c02297b69c2ac8936bd87cff545, ssOutSystemsUI.RestRecords.RESTRC_646e6c02297b69c2ac8936bd87cff545> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_646e6c02297b69c2ac8936bd87cff545 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_646e6c02297b69c2ac8936bd87cff545 FromStructure(RC_646e6c02297b69c2ac8936bd87cff545 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_646e6c02297b69c2ac8936bd87cff545(s, config);
}

}


