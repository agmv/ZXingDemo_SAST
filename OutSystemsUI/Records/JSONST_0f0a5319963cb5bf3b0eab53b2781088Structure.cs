using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Accordion_InternalConfigs
public class JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure : AbstractRESTStructure<ST_0f0a5319963cb5bf3b0eab53b2781088Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("MultipleItems")]
[JsonPropertyName("MultipleItems")]
public bool? AttrMultipleItems;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure() { }

public JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure (ST_0f0a5319963cb5bf3b0eab53b2781088Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrMultipleItems = ConvertToRestWithoutDefaults(s.ssMultipleItems, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrMultipleItems = (bool?) s.ssMultipleItems;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure, ST_0f0a5319963cb5bf3b0eab53b2781088Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure s) => ToStructure(s, config);
}
public static ST_0f0a5319963cb5bf3b0eab53b2781088Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure obj, IBehaviorsConfiguration config) { 
  ST_0f0a5319963cb5bf3b0eab53b2781088Structure s = new ST_0f0a5319963cb5bf3b0eab53b2781088Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssMultipleItems = obj.AttrMultipleItems == null ? false : obj.AttrMultipleItems.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_0f0a5319963cb5bf3b0eab53b2781088Structure, ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0f0a5319963cb5bf3b0eab53b2781088Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure FromStructure(ST_0f0a5319963cb5bf3b0eab53b2781088Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_0f0a5319963cb5bf3b0eab53b2781088Structure(s, config);
}

}


