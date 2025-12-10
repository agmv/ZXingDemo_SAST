using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SectionIndex_InternalConfig
public class RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure : AbstractRESTStructure<ST_3b9304e9875ccc71ec31b003d76d44c7Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("SmoothScrolling")]
public bool? AttrSmoothScrolling;

[JsonProperty("IsFixed")]
public bool? AttrIsFixed;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure() { }

public RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure (ST_3b9304e9875ccc71ec31b003d76d44c7Structure s, IBehaviorsConfiguration config) {
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

public static ST_3b9304e9875ccc71ec31b003d76d44c7Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure obj) { 
  ST_3b9304e9875ccc71ec31b003d76d44c7Structure s = new ST_3b9304e9875ccc71ec31b003d76d44c7Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssSmoothScrolling = obj.AttrSmoothScrolling == null ? false : obj.AttrSmoothScrolling.Value;
  s.ssIsFixed = obj.AttrIsFixed == null ? false : obj.AttrIsFixed.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_3b9304e9875ccc71ec31b003d76d44c7Structure, ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3b9304e9875ccc71ec31b003d76d44c7Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure FromStructure(ST_3b9304e9875ccc71ec31b003d76d44c7Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_3b9304e9875ccc71ec31b003d76d44c7Structure(s, config);
}

}


