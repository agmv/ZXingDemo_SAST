using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// TabsContentItem_InternalConfig
public class JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure : AbstractRESTStructure<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure() { }

public JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure, ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s) => ToStructure(s, config);
}
public static ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure obj, IBehaviorsConfiguration config) { 
  ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s = new ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure, ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure FromStructure(ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure(s, config);
}

}


