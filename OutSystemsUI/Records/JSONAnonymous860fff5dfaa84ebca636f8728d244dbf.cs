using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTags_InternalConfigsRecord
public class JSONRC_e3b67119e4a2ce2c95244e08a29b21aa : AbstractRESTStructure<RC_e3b67119e4a2ce2c95244e08a29b21aa> {
[JsonProperty("DropdownTags_InternalConfigs")]
[JsonPropertyName("DropdownTags_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure AttrDropdownTags_InternalConfigs;

public JSONRC_e3b67119e4a2ce2c95244e08a29b21aa() { }

public JSONRC_e3b67119e4a2ce2c95244e08a29b21aa (RC_e3b67119e4a2ce2c95244e08a29b21aa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownTags_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownTags_InternalConfigs, new ST_f2d4817754eec123207470e41d7a01d7Structure(), ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure.FromStructureDelegate(config));
  } else {
AttrDropdownTags_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure.FromStructure(s.ssSTDropdownTags_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa, RC_e3b67119e4a2ce2c95244e08a29b21aa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa s) => ToStructure(s, config);
}
public static RC_e3b67119e4a2ce2c95244e08a29b21aa ToStructure(ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa obj, IBehaviorsConfiguration config) { 
  RC_e3b67119e4a2ce2c95244e08a29b21aa s = new RC_e3b67119e4a2ce2c95244e08a29b21aa();
  if(obj != null) {
  s.ssSTDropdownTags_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure.ToStructure(obj.AttrDropdownTags_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_e3b67119e4a2ce2c95244e08a29b21aa, ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3b67119e4a2ce2c95244e08a29b21aa s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa FromStructure(RC_e3b67119e4a2ce2c95244e08a29b21aa s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_e3b67119e4a2ce2c95244e08a29b21aa(s, config);
}

}


