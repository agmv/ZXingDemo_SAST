using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ReturnMessage
public class RESTST_cdd94bc434e873b4d04598ac1e187543Structure : AbstractRESTStructure<ST_cdd94bc434e873b4d04598ac1e187543Structure> {
[JsonProperty("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_cdd94bc434e873b4d04598ac1e187543Structure() { }

public RESTST_cdd94bc434e873b4d04598ac1e187543Structure (ST_cdd94bc434e873b4d04598ac1e187543Structure s, IBehaviorsConfiguration config) {
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

public static ST_cdd94bc434e873b4d04598ac1e187543Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure obj) { 
  ST_cdd94bc434e873b4d04598ac1e187543Structure s = new ST_cdd94bc434e873b4d04598ac1e187543Structure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_cdd94bc434e873b4d04598ac1e187543Structure, ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cdd94bc434e873b4d04598ac1e187543Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure FromStructure(ST_cdd94bc434e873b4d04598ac1e187543Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_cdd94bc434e873b4d04598ac1e187543Structure(s, config);
}

}


