using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Search_InternalConfig
public class JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure : AbstractRESTStructure<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure() { }

public JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure, ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure s) => ToStructure(s, config);
}
public static ST_8ccec918bf91fdb79e42a7e1e178b4beStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure obj, IBehaviorsConfiguration config) { 
  ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s = new ST_8ccec918bf91fdb79e42a7e1e178b4beStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure, ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure FromStructure(ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_8ccec918bf91fdb79e42a7e1e178b4beStructure(s, config);
}

}


