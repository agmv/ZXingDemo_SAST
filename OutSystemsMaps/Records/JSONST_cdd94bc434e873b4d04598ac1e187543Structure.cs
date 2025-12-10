using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ReturnMessage
public class JSONST_cdd94bc434e873b4d04598ac1e187543Structure : AbstractRESTStructure<ST_cdd94bc434e873b4d04598ac1e187543Structure> {
[JsonProperty("isSuccess")]
[JsonPropertyName("isSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("code")]
[JsonPropertyName("code")]
public string AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

public JSONST_cdd94bc434e873b4d04598ac1e187543Structure() { }

public JSONST_cdd94bc434e873b4d04598ac1e187543Structure (ST_cdd94bc434e873b4d04598ac1e187543Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure, ST_cdd94bc434e873b4d04598ac1e187543Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure s) => ToStructure(s, config);
}
public static ST_cdd94bc434e873b4d04598ac1e187543Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure obj, IBehaviorsConfiguration config) { 
  ST_cdd94bc434e873b4d04598ac1e187543Structure s = new ST_cdd94bc434e873b4d04598ac1e187543Structure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_cdd94bc434e873b4d04598ac1e187543Structure, ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cdd94bc434e873b4d04598ac1e187543Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure FromStructure(ST_cdd94bc434e873b4d04598ac1e187543Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_cdd94bc434e873b4d04598ac1e187543Structure(s, config);
}

}


