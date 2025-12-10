using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Rating_InternalConfig
public class JSONST_69c22c095aca285f3fb706e10e473ba5Structure : AbstractRESTStructure<ST_69c22c095aca285f3fb706e10e473ba5Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("RatingValue")]
[JsonPropertyName("RatingValue")]
public decimal? AttrRatingValue;

[JsonProperty("RatingScale")]
[JsonPropertyName("RatingScale")]
public int? AttrRatingScale;

[JsonProperty("IsEdit")]
[JsonPropertyName("IsEdit")]
public bool? AttrIsEdit;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public string AttrSize;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_69c22c095aca285f3fb706e10e473ba5Structure() { }

public JSONST_69c22c095aca285f3fb706e10e473ba5Structure (ST_69c22c095aca285f3fb706e10e473ba5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrRatingValue = ConvertToRestWithoutDefaults(s.ssRatingValue, 0.0M);
AttrRatingScale = ConvertToRestWithoutDefaults(s.ssRatingScale, 0);
AttrIsEdit = ConvertToRestWithoutDefaults(s.ssIsEdit, false);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrRatingValue = (decimal?) s.ssRatingValue;
AttrRatingScale = (int?) s.ssRatingScale;
AttrIsEdit = (bool?) s.ssIsEdit;
AttrSize = s.ssSize;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure, ST_69c22c095aca285f3fb706e10e473ba5Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure s) => ToStructure(s, config);
}
public static ST_69c22c095aca285f3fb706e10e473ba5Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure obj, IBehaviorsConfiguration config) { 
  ST_69c22c095aca285f3fb706e10e473ba5Structure s = new ST_69c22c095aca285f3fb706e10e473ba5Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssRatingValue = obj.AttrRatingValue == null ? 0.0M : obj.AttrRatingValue.Value;
  s.ssRatingScale = obj.AttrRatingScale == null ? 0 : obj.AttrRatingScale.Value;
  s.ssIsEdit = obj.AttrIsEdit == null ? false : obj.AttrIsEdit.Value;
  s.ssSize = obj.AttrSize == null ? "" : obj.AttrSize;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_69c22c095aca285f3fb706e10e473ba5Structure, ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_69c22c095aca285f3fb706e10e473ba5Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure FromStructure(ST_69c22c095aca285f3fb706e10e473ba5Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_69c22c095aca285f3fb706e10e473ba5Structure(s, config);
}

}


