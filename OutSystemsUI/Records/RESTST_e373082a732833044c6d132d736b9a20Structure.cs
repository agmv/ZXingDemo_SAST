using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Submenu_InternalConfig
public class RESTST_e373082a732833044c6d132d736b9a20Structure : AbstractRESTStructure<ST_e373082a732833044c6d132d736b9a20Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_e373082a732833044c6d132d736b9a20Structure() { }

public RESTST_e373082a732833044c6d132d736b9a20Structure (ST_e373082a732833044c6d132d736b9a20Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_e373082a732833044c6d132d736b9a20Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure obj) { 
  ST_e373082a732833044c6d132d736b9a20Structure s = new ST_e373082a732833044c6d132d736b9a20Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_e373082a732833044c6d132d736b9a20Structure, ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e373082a732833044c6d132d736b9a20Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure FromStructure(ST_e373082a732833044c6d132d736b9a20Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_e373082a732833044c6d132d736b9a20Structure(s, config);
}

}


