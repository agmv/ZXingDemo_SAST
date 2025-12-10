using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTags_InternalConfigsRecord
public class RESTRC_e3b67119e4a2ce2c95244e08a29b21aa : AbstractRESTStructure<RC_e3b67119e4a2ce2c95244e08a29b21aa> {
[JsonProperty("DropdownTags_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure AttrDropdownTags_InternalConfigs;

public RESTRC_e3b67119e4a2ce2c95244e08a29b21aa() { }

public RESTRC_e3b67119e4a2ce2c95244e08a29b21aa (RC_e3b67119e4a2ce2c95244e08a29b21aa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownTags_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownTags_InternalConfigs, new ST_f2d4817754eec123207470e41d7a01d7Structure(), ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure.FromStructureDelegate(config));
  } else {
AttrDropdownTags_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure.FromStructure(s.ssSTDropdownTags_InternalConfigs, config);
  }
}

public static RC_e3b67119e4a2ce2c95244e08a29b21aa ToStructure(ssOutSystemsUI.RestRecords.RESTRC_e3b67119e4a2ce2c95244e08a29b21aa obj) { 
  RC_e3b67119e4a2ce2c95244e08a29b21aa s = new RC_e3b67119e4a2ce2c95244e08a29b21aa();
  if(obj != null) {
  s.ssSTDropdownTags_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure.ToStructure(obj.AttrDropdownTags_InternalConfigs);
  }
  return s;
}

public static Func<RC_e3b67119e4a2ce2c95244e08a29b21aa, ssOutSystemsUI.RestRecords.RESTRC_e3b67119e4a2ce2c95244e08a29b21aa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3b67119e4a2ce2c95244e08a29b21aa s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_e3b67119e4a2ce2c95244e08a29b21aa FromStructure(RC_e3b67119e4a2ce2c95244e08a29b21aa s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_e3b67119e4a2ce2c95244e08a29b21aa(s, config);
}

}


