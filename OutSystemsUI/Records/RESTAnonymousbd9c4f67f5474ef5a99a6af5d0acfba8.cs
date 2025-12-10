using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Submenu_InternalConfigRecord
public class RESTRC_6806bcabed8c9a627c64e2f22fd43e7d : AbstractRESTStructure<RC_6806bcabed8c9a627c64e2f22fd43e7d> {
[JsonProperty("Submenu_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure AttrSubmenu_InternalConfig;

public RESTRC_6806bcabed8c9a627c64e2f22fd43e7d() { }

public RESTRC_6806bcabed8c9a627c64e2f22fd43e7d (RC_6806bcabed8c9a627c64e2f22fd43e7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSubmenu_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSubmenu_InternalConfig, new ST_e373082a732833044c6d132d736b9a20Structure(), ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure.FromStructureDelegate(config));
  } else {
AttrSubmenu_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure.FromStructure(s.ssSTSubmenu_InternalConfig, config);
  }
}

public static RC_6806bcabed8c9a627c64e2f22fd43e7d ToStructure(ssOutSystemsUI.RestRecords.RESTRC_6806bcabed8c9a627c64e2f22fd43e7d obj) { 
  RC_6806bcabed8c9a627c64e2f22fd43e7d s = new RC_6806bcabed8c9a627c64e2f22fd43e7d();
  if(obj != null) {
  s.ssSTSubmenu_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure.ToStructure(obj.AttrSubmenu_InternalConfig);
  }
  return s;
}

public static Func<RC_6806bcabed8c9a627c64e2f22fd43e7d, ssOutSystemsUI.RestRecords.RESTRC_6806bcabed8c9a627c64e2f22fd43e7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6806bcabed8c9a627c64e2f22fd43e7d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_6806bcabed8c9a627c64e2f22fd43e7d FromStructure(RC_6806bcabed8c9a627c64e2f22fd43e7d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_6806bcabed8c9a627c64e2f22fd43e7d(s, config);
}

}


