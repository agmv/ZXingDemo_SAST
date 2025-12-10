using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ErrorMessage
public class JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure : AbstractRESTStructure<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> {
[JsonProperty("code")]
[JsonPropertyName("code")]
public string AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

public JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure() { }

public JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure, ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s) => ToStructure(s, config);
}
public static ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure obj, IBehaviorsConfiguration config) { 
  ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s = new ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure, ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure FromStructure(ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure(s, config);
}

}


