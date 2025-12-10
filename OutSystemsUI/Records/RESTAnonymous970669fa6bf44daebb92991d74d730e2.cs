using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownSearch_InternalConfigsRecord
public class RESTRC_7925a19e6fd0a09e9058a96c7f19b104 : AbstractRESTStructure<RC_7925a19e6fd0a09e9058a96c7f19b104> {
[JsonProperty("DropdownSearch_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_936f99e69df60f5aa2563bbd38e49c98Structure AttrDropdownSearch_InternalConfigs;

public RESTRC_7925a19e6fd0a09e9058a96c7f19b104() { }

public RESTRC_7925a19e6fd0a09e9058a96c7f19b104 (RC_7925a19e6fd0a09e9058a96c7f19b104 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownSearch_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownSearch_InternalConfigs, new ST_936f99e69df60f5aa2563bbd38e49c98Structure(), ssOutSystemsUI.RestRecords.RESTST_936f99e69df60f5aa2563bbd38e49c98Structure.FromStructureDelegate(config));
  } else {
AttrDropdownSearch_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_936f99e69df60f5aa2563bbd38e49c98Structure.FromStructure(s.ssSTDropdownSearch_InternalConfigs, config);
  }
}

public static RC_7925a19e6fd0a09e9058a96c7f19b104 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_7925a19e6fd0a09e9058a96c7f19b104 obj) { 
  RC_7925a19e6fd0a09e9058a96c7f19b104 s = new RC_7925a19e6fd0a09e9058a96c7f19b104();
  if(obj != null) {
  s.ssSTDropdownSearch_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_936f99e69df60f5aa2563bbd38e49c98Structure.ToStructure(obj.AttrDropdownSearch_InternalConfigs);
  }
  return s;
}

public static Func<RC_7925a19e6fd0a09e9058a96c7f19b104, ssOutSystemsUI.RestRecords.RESTRC_7925a19e6fd0a09e9058a96c7f19b104> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7925a19e6fd0a09e9058a96c7f19b104 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_7925a19e6fd0a09e9058a96c7f19b104 FromStructure(RC_7925a19e6fd0a09e9058a96c7f19b104 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_7925a19e6fd0a09e9058a96c7f19b104(s, config);
}

}


