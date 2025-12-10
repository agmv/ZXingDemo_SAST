using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Accordion_InternalConfigs
public class RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure : AbstractRESTStructure<ST_0f0a5319963cb5bf3b0eab53b2781088Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("MultipleItems")]
public bool? AttrMultipleItems;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure() { }

public RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure (ST_0f0a5319963cb5bf3b0eab53b2781088Structure s, IBehaviorsConfiguration config) {
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

public static ST_0f0a5319963cb5bf3b0eab53b2781088Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure obj) { 
  ST_0f0a5319963cb5bf3b0eab53b2781088Structure s = new ST_0f0a5319963cb5bf3b0eab53b2781088Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssMultipleItems = obj.AttrMultipleItems == null ? false : obj.AttrMultipleItems.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_0f0a5319963cb5bf3b0eab53b2781088Structure, ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0f0a5319963cb5bf3b0eab53b2781088Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure FromStructure(ST_0f0a5319963cb5bf3b0eab53b2781088Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_0f0a5319963cb5bf3b0eab53b2781088Structure(s, config);
}

}


