using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndexItem_InternalConfig
public class RESTST_a783e375273068e4b8f9c122c1661a6aStructure : AbstractRESTStructure<ST_a783e375273068e4b8f9c122c1661a6aStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("ScrollToWidgetId")]
public string AttrScrollToWidgetId;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_a783e375273068e4b8f9c122c1661a6aStructure() { }

public RESTST_a783e375273068e4b8f9c122c1661a6aStructure (ST_a783e375273068e4b8f9c122c1661a6aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrScrollToWidgetId = ConvertToRestWithoutDefaults(s.ssScrollToWidgetId, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrScrollToWidgetId = s.ssScrollToWidgetId;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_a783e375273068e4b8f9c122c1661a6aStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_a783e375273068e4b8f9c122c1661a6aStructure obj) { 
  ST_a783e375273068e4b8f9c122c1661a6aStructure s = new ST_a783e375273068e4b8f9c122c1661a6aStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssScrollToWidgetId = obj.AttrScrollToWidgetId == null ? "" : obj.AttrScrollToWidgetId;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_a783e375273068e4b8f9c122c1661a6aStructure, ssOutSystemsUI.RestRecords.RESTST_a783e375273068e4b8f9c122c1661a6aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a783e375273068e4b8f9c122c1661a6aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_a783e375273068e4b8f9c122c1661a6aStructure FromStructure(ST_a783e375273068e4b8f9c122c1661a6aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_a783e375273068e4b8f9c122c1661a6aStructure(s, config);
}

}


