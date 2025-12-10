using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Submenu_InternalConfig
public class JSONST_e373082a732833044c6d132d736b9a20Structure : AbstractRESTStructure<ST_e373082a732833044c6d132d736b9a20Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_e373082a732833044c6d132d736b9a20Structure() { }

public JSONST_e373082a732833044c6d132d736b9a20Structure (ST_e373082a732833044c6d132d736b9a20Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure, ST_e373082a732833044c6d132d736b9a20Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure s) => ToStructure(s, config);
}
public static ST_e373082a732833044c6d132d736b9a20Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure obj, IBehaviorsConfiguration config) { 
  ST_e373082a732833044c6d132d736b9a20Structure s = new ST_e373082a732833044c6d132d736b9a20Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_e373082a732833044c6d132d736b9a20Structure, ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e373082a732833044c6d132d736b9a20Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure FromStructure(ST_e373082a732833044c6d132d736b9a20Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_e373082a732833044c6d132d736b9a20Structure(s, config);
}

}


