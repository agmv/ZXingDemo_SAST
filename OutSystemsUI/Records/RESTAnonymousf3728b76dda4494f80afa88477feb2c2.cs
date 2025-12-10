using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AnimatedLabel_InternalConfigRecord
public class RESTRC_40ff37b8719fa708a2bb67c839d296b2 : AbstractRESTStructure<RC_40ff37b8719fa708a2bb67c839d296b2> {
[JsonProperty("AnimatedLabel_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure AttrAnimatedLabel_InternalConfig;

public RESTRC_40ff37b8719fa708a2bb67c839d296b2() { }

public RESTRC_40ff37b8719fa708a2bb67c839d296b2 (RC_40ff37b8719fa708a2bb67c839d296b2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAnimatedLabel_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTAnimatedLabel_InternalConfig, new ST_52888c3e6f33b11b7d6288dd268a26dcStructure(), ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure.FromStructureDelegate(config));
  } else {
AttrAnimatedLabel_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure.FromStructure(s.ssSTAnimatedLabel_InternalConfig, config);
  }
}

public static RC_40ff37b8719fa708a2bb67c839d296b2 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_40ff37b8719fa708a2bb67c839d296b2 obj) { 
  RC_40ff37b8719fa708a2bb67c839d296b2 s = new RC_40ff37b8719fa708a2bb67c839d296b2();
  if(obj != null) {
  s.ssSTAnimatedLabel_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_52888c3e6f33b11b7d6288dd268a26dcStructure.ToStructure(obj.AttrAnimatedLabel_InternalConfig);
  }
  return s;
}

public static Func<RC_40ff37b8719fa708a2bb67c839d296b2, ssOutSystemsUI.RestRecords.RESTRC_40ff37b8719fa708a2bb67c839d296b2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40ff37b8719fa708a2bb67c839d296b2 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_40ff37b8719fa708a2bb67c839d296b2 FromStructure(RC_40ff37b8719fa708a2bb67c839d296b2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_40ff37b8719fa708a2bb67c839d296b2(s, config);
}

}


