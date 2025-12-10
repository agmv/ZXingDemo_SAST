using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Notification_InternalConfig
public class JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure : AbstractRESTStructure<ST_46bd5f77d899939eaf145ae01d3efd6bStructure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("StartsOpen")]
[JsonPropertyName("StartsOpen")]
public bool? AttrStartsOpen;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

[JsonProperty("Width")]
[JsonPropertyName("Width")]
public string AttrWidth;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("CloseAfterTime")]
[JsonPropertyName("CloseAfterTime")]
public int? AttrCloseAfterTime;

[JsonProperty("InteractToClose")]
[JsonPropertyName("InteractToClose")]
public bool? AttrInteractToClose;

public JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure() { }

public JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure (ST_46bd5f77d899939eaf145ae01d3efd6bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrStartsOpen = ConvertToRestWithoutDefaults(s.ssStartsOpen, false);
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, "");
AttrWidth = ConvertToRestWithoutDefaults(s.ssWidth, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrCloseAfterTime = ConvertToRestWithoutDefaults(s.ssCloseAfterTime, 0);
AttrInteractToClose = ConvertToRestWithoutDefaults(s.ssInteractToClose, false);
  } else {
AttrUniqueId = s.ssUniqueId;
AttrStartsOpen = (bool?) s.ssStartsOpen;
AttrPosition = s.ssPosition;
AttrWidth = s.ssWidth;
AttrExtendedClass = s.ssExtendedClass;
AttrCloseAfterTime = (int?) s.ssCloseAfterTime;
AttrInteractToClose = (bool?) s.ssInteractToClose;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure, ST_46bd5f77d899939eaf145ae01d3efd6bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure s) => ToStructure(s, config);
}
public static ST_46bd5f77d899939eaf145ae01d3efd6bStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure obj, IBehaviorsConfiguration config) { 
  ST_46bd5f77d899939eaf145ae01d3efd6bStructure s = new ST_46bd5f77d899939eaf145ae01d3efd6bStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssStartsOpen = obj.AttrStartsOpen == null ? false : obj.AttrStartsOpen.Value;
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  s.ssWidth = obj.AttrWidth == null ? "" : obj.AttrWidth;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssCloseAfterTime = obj.AttrCloseAfterTime == null ? 0 : obj.AttrCloseAfterTime.Value;
  s.ssInteractToClose = obj.AttrInteractToClose == null ? false : obj.AttrInteractToClose.Value;
  }
  return s;
}

public static Func<ST_46bd5f77d899939eaf145ae01d3efd6bStructure, ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_46bd5f77d899939eaf145ae01d3efd6bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure FromStructure(ST_46bd5f77d899939eaf145ae01d3efd6bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_46bd5f77d899939eaf145ae01d3efd6bStructure(s, config);
}

}


