using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlipContent_InternalConfig
public class RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure : AbstractRESTStructure<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("IsFlipped")]
public bool? AttrIsFlipped;

[JsonProperty("FlipSelf")]
public bool? AttrFlipSelf;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure() { }

public RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s, IBehaviorsConfiguration config) {
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

public static ST_e828cdbd51e0c1ef095bd323f6e2875aStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure obj) { 
  ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s = new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssIsFlipped = obj.AttrIsFlipped == null ? false : obj.AttrIsFlipped.Value;
  s.ssFlipSelf = obj.AttrFlipSelf == null ? true : obj.AttrFlipSelf.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure, ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure FromStructure(ST_e828cdbd51e0c1ef095bd323f6e2875aStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure(s, config);
}

}


