using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownSearch_InternalConfigsRecord
public class JSONRC_7925a19e6fd0a09e9058a96c7f19b104 : AbstractRESTStructure<RC_7925a19e6fd0a09e9058a96c7f19b104> {
[JsonProperty("DropdownSearch_InternalConfigs")]
[JsonPropertyName("DropdownSearch_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_936f99e69df60f5aa2563bbd38e49c98Structure AttrDropdownSearch_InternalConfigs;

public JSONRC_7925a19e6fd0a09e9058a96c7f19b104() { }

public JSONRC_7925a19e6fd0a09e9058a96c7f19b104 (RC_7925a19e6fd0a09e9058a96c7f19b104 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownSearch_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownSearch_InternalConfigs, new ST_936f99e69df60f5aa2563bbd38e49c98Structure(), ssOutSystemsUI.RestRecords.JSONST_936f99e69df60f5aa2563bbd38e49c98Structure.FromStructureDelegate(config));
  } else {
AttrDropdownSearch_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_936f99e69df60f5aa2563bbd38e49c98Structure.FromStructure(s.ssSTDropdownSearch_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104, RC_7925a19e6fd0a09e9058a96c7f19b104> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104 s) => ToStructure(s, config);
}
public static RC_7925a19e6fd0a09e9058a96c7f19b104 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104 obj, IBehaviorsConfiguration config) { 
  RC_7925a19e6fd0a09e9058a96c7f19b104 s = new RC_7925a19e6fd0a09e9058a96c7f19b104();
  if(obj != null) {
  s.ssSTDropdownSearch_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_936f99e69df60f5aa2563bbd38e49c98Structure.ToStructure(obj.AttrDropdownSearch_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_7925a19e6fd0a09e9058a96c7f19b104, ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7925a19e6fd0a09e9058a96c7f19b104 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104 FromStructure(RC_7925a19e6fd0a09e9058a96c7f19b104 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_7925a19e6fd0a09e9058a96c7f19b104(s, config);
}

}


