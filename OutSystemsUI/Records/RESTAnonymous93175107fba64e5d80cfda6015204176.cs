using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SplideConfigsRecord
public class RESTRC_a784fb81632458d6690327bfa77675d9 : AbstractRESTStructure<RC_a784fb81632458d6690327bfa77675d9> {
[JsonProperty("SplideConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_3fe78d74e319e2ce842fd51dd2d67caaStructure AttrSplideConfigs;

public RESTRC_a784fb81632458d6690327bfa77675d9() { }

public RESTRC_a784fb81632458d6690327bfa77675d9 (RC_a784fb81632458d6690327bfa77675d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSplideConfigs = ConvertToRestWithoutDefaults(s.ssSTSplideConfigs, new ST_3fe78d74e319e2ce842fd51dd2d67caaStructure(), ssOutSystemsUI.RestRecords.RESTST_3fe78d74e319e2ce842fd51dd2d67caaStructure.FromStructureDelegate(config));
  } else {
AttrSplideConfigs = ssOutSystemsUI.RestRecords.RESTST_3fe78d74e319e2ce842fd51dd2d67caaStructure.FromStructure(s.ssSTSplideConfigs, config);
  }
}

public static RC_a784fb81632458d6690327bfa77675d9 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_a784fb81632458d6690327bfa77675d9 obj) { 
  RC_a784fb81632458d6690327bfa77675d9 s = new RC_a784fb81632458d6690327bfa77675d9();
  if(obj != null) {
  s.ssSTSplideConfigs = ssOutSystemsUI.RestRecords.RESTST_3fe78d74e319e2ce842fd51dd2d67caaStructure.ToStructure(obj.AttrSplideConfigs);
  }
  return s;
}

public static Func<RC_a784fb81632458d6690327bfa77675d9, ssOutSystemsUI.RestRecords.RESTRC_a784fb81632458d6690327bfa77675d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a784fb81632458d6690327bfa77675d9 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_a784fb81632458d6690327bfa77675d9 FromStructure(RC_a784fb81632458d6690327bfa77675d9 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_a784fb81632458d6690327bfa77675d9(s, config);
}

}


