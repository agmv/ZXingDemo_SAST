using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndex_InternalConfig
public class JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure : AbstractRESTStructure<ST_3b9304e9875ccc71ec31b003d76d44c7Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("SmoothScrolling")]
[JsonPropertyName("SmoothScrolling")]
public bool? AttrSmoothScrolling;

[JsonProperty("IsFixed")]
[JsonPropertyName("IsFixed")]
public bool? AttrIsFixed;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure() { }

public JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure (ST_3b9304e9875ccc71ec31b003d76d44c7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrSmoothScrolling = ConvertToRestWithoutDefaults(s.ssSmoothScrolling, false);
AttrIsFixed = ConvertToRestWithoutDefaults(s.ssIsFixed, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrSmoothScrolling = (bool?) s.ssSmoothScrolling;
AttrIsFixed = (bool?) s.ssIsFixed;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure, ST_3b9304e9875ccc71ec31b003d76d44c7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure s) => ToStructure(s, config);
}
public static ST_3b9304e9875ccc71ec31b003d76d44c7Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure obj, IBehaviorsConfiguration config) { 
  ST_3b9304e9875ccc71ec31b003d76d44c7Structure s = new ST_3b9304e9875ccc71ec31b003d76d44c7Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssSmoothScrolling = obj.AttrSmoothScrolling == null ? false : obj.AttrSmoothScrolling.Value;
  s.ssIsFixed = obj.AttrIsFixed == null ? false : obj.AttrIsFixed.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_3b9304e9875ccc71ec31b003d76d44c7Structure, ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3b9304e9875ccc71ec31b003d76d44c7Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure FromStructure(ST_3b9304e9875ccc71ec31b003d76d44c7Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_3b9304e9875ccc71ec31b003d76d44c7Structure(s, config);
}

}


