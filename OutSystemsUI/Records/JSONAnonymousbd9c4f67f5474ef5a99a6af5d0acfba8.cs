using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Submenu_InternalConfigRecord
public class JSONRC_6806bcabed8c9a627c64e2f22fd43e7d : AbstractRESTStructure<RC_6806bcabed8c9a627c64e2f22fd43e7d> {
[JsonProperty("Submenu_InternalConfig")]
[JsonPropertyName("Submenu_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure AttrSubmenu_InternalConfig;

public JSONRC_6806bcabed8c9a627c64e2f22fd43e7d() { }

public JSONRC_6806bcabed8c9a627c64e2f22fd43e7d (RC_6806bcabed8c9a627c64e2f22fd43e7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSubmenu_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSubmenu_InternalConfig, new ST_e373082a732833044c6d132d736b9a20Structure(), ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure.FromStructureDelegate(config));
  } else {
AttrSubmenu_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure.FromStructure(s.ssSTSubmenu_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d, RC_6806bcabed8c9a627c64e2f22fd43e7d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d s) => ToStructure(s, config);
}
public static RC_6806bcabed8c9a627c64e2f22fd43e7d ToStructure(ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d obj, IBehaviorsConfiguration config) { 
  RC_6806bcabed8c9a627c64e2f22fd43e7d s = new RC_6806bcabed8c9a627c64e2f22fd43e7d();
  if(obj != null) {
  s.ssSTSubmenu_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure.ToStructure(obj.AttrSubmenu_InternalConfig, config);
  }
  return s;
}

public static Func<RC_6806bcabed8c9a627c64e2f22fd43e7d, ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6806bcabed8c9a627c64e2f22fd43e7d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d FromStructure(RC_6806bcabed8c9a627c64e2f22fd43e7d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_6806bcabed8c9a627c64e2f22fd43e7d(s, config);
}

}


