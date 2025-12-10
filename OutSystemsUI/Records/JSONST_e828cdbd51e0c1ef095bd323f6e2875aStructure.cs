using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlipContent_InternalConfig
public class JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure : AbstractRESTStructure<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("IsFlipped")]
[JsonPropertyName("IsFlipped")]
public bool? AttrIsFlipped;

[JsonProperty("FlipSelf")]
[JsonPropertyName("FlipSelf")]
public bool? AttrFlipSelf;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure() { }

public JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrIsFlipped = ConvertToRestWithoutDefaults(s.ssIsFlipped, false);
AttrFlipSelf = ConvertToRestWithoutDefaults(s.ssFlipSelf, true);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrIsFlipped = (bool?) s.ssIsFlipped;
AttrFlipSelf = (bool?) s.ssFlipSelf;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure, ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure s) => ToStructure(s, config);
}
public static ST_e828cdbd51e0c1ef095bd323f6e2875aStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure obj, IBehaviorsConfiguration config) { 
  ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s = new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssIsFlipped = obj.AttrIsFlipped == null ? false : obj.AttrIsFlipped.Value;
  s.ssFlipSelf = obj.AttrFlipSelf == null ? true : obj.AttrFlipSelf.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure, ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure FromStructure(ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure(s, config);
}

}


