using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Sidebar_InternalConfig
public class JSONST_963c357dbc45b19fade654e21b1521d0Structure : AbstractRESTStructure<ST_963c357dbc45b19fade654e21b1521d0Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("StartsOpen")]
[JsonPropertyName("StartsOpen")]
public bool? AttrStartsOpen;

[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public string AttrDirection;

[JsonProperty("Width")]
[JsonPropertyName("Width")]
public string AttrWidth;

[JsonProperty("HasOverlay")]
[JsonPropertyName("HasOverlay")]
public bool? AttrHasOverlay;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_963c357dbc45b19fade654e21b1521d0Structure() { }

public JSONST_963c357dbc45b19fade654e21b1521d0Structure (ST_963c357dbc45b19fade654e21b1521d0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrStartsOpen = ConvertToRestWithoutDefaults(s.ssStartsOpen, false);
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrWidth = ConvertToRestWithoutDefaults(s.ssWidth, "");
AttrHasOverlay = ConvertToRestWithoutDefaults(s.ssHasOverlay, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrStartsOpen = (bool?) s.ssStartsOpen;
AttrDirection = s.ssDirection;
AttrWidth = s.ssWidth;
AttrHasOverlay = (bool?) s.ssHasOverlay;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure, ST_963c357dbc45b19fade654e21b1521d0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure s) => ToStructure(s, config);
}
public static ST_963c357dbc45b19fade654e21b1521d0Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure obj, IBehaviorsConfiguration config) { 
  ST_963c357dbc45b19fade654e21b1521d0Structure s = new ST_963c357dbc45b19fade654e21b1521d0Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssStartsOpen = obj.AttrStartsOpen == null ? false : obj.AttrStartsOpen.Value;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssWidth = obj.AttrWidth == null ? "" : obj.AttrWidth;
  s.ssHasOverlay = obj.AttrHasOverlay == null ? false : obj.AttrHasOverlay.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_963c357dbc45b19fade654e21b1521d0Structure, ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_963c357dbc45b19fade654e21b1521d0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure FromStructure(ST_963c357dbc45b19fade654e21b1521d0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure(s, config);
}

}


