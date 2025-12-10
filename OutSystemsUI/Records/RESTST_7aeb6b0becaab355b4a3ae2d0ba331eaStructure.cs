using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsContentItem_InternalConfig
public class RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure : AbstractRESTStructure<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure() { }

public RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure obj) { 
  ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s = new ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure, ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure FromStructure(ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure(s, config);
}

}


