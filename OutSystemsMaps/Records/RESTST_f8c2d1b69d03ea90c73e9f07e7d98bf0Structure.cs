using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ErrorMessage
public class RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure : AbstractRESTStructure<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> {
[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure() { }

public RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure obj) { 
  ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s = new ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure, ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure FromStructure(ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure(s, config);
}

}


