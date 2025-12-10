using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AnimatedLabel_InternalConfigRecord
public class JSONRC_40ff37b8719fa708a2bb67c839d296b2 : AbstractRESTStructure<RC_40ff37b8719fa708a2bb67c839d296b2> {
[JsonProperty("AnimatedLabel_InternalConfig")]
[JsonPropertyName("AnimatedLabel_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_52888c3e6f33b11b7d6288dd268a26dcStructure AttrAnimatedLabel_InternalConfig;

public JSONRC_40ff37b8719fa708a2bb67c839d296b2() { }

public JSONRC_40ff37b8719fa708a2bb67c839d296b2 (RC_40ff37b8719fa708a2bb67c839d296b2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAnimatedLabel_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTAnimatedLabel_InternalConfig, new ST_52888c3e6f33b11b7d6288dd268a26dcStructure(), ssOutSystemsUI.RestRecords.JSONST_52888c3e6f33b11b7d6288dd268a26dcStructure.FromStructureDelegate(config));
  } else {
AttrAnimatedLabel_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_52888c3e6f33b11b7d6288dd268a26dcStructure.FromStructure(s.ssSTAnimatedLabel_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2, RC_40ff37b8719fa708a2bb67c839d296b2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2 s) => ToStructure(s, config);
}
public static RC_40ff37b8719fa708a2bb67c839d296b2 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2 obj, IBehaviorsConfiguration config) { 
  RC_40ff37b8719fa708a2bb67c839d296b2 s = new RC_40ff37b8719fa708a2bb67c839d296b2();
  if(obj != null) {
  s.ssSTAnimatedLabel_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_52888c3e6f33b11b7d6288dd268a26dcStructure.ToStructure(obj.AttrAnimatedLabel_InternalConfig, config);
  }
  return s;
}

public static Func<RC_40ff37b8719fa708a2bb67c839d296b2, ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40ff37b8719fa708a2bb67c839d296b2 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2 FromStructure(RC_40ff37b8719fa708a2bb67c839d296b2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_40ff37b8719fa708a2bb67c839d296b2(s, config);
}

}


