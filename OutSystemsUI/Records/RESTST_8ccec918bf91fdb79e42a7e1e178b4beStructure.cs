using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Search_InternalConfig
public class RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure : AbstractRESTStructure<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure() { }

public RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_8ccec918bf91fdb79e42a7e1e178b4beStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure obj) { 
  ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s = new ST_8ccec918bf91fdb79e42a7e1e178b4beStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_8ccec918bf91fdb79e42a7e1e178b4beStructure, ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure FromStructure(ST_8ccec918bf91fdb79e42a7e1e178b4beStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_8ccec918bf91fdb79e42a7e1e178b4beStructure(s, config);
}

}


