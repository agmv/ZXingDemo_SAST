using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ReturnMessage
public class RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure : AbstractRESTStructure<ST_13c131829a33cb5bedb5c64aa6f4add2Structure> {
[JsonProperty("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("Value")]
public string AttrValue;

public RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure() { }

public RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure (ST_13c131829a33cb5bedb5c64aa6f4add2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
AttrValue = s.ssValue;
  }
}

public static ST_13c131829a33cb5bedb5c64aa6f4add2Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure obj) { 
  ST_13c131829a33cb5bedb5c64aa6f4add2Structure s = new ST_13c131829a33cb5bedb5c64aa6f4add2Structure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_13c131829a33cb5bedb5c64aa6f4add2Structure, ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_13c131829a33cb5bedb5c64aa6f4add2Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure FromStructure(ST_13c131829a33cb5bedb5c64aa6f4add2Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_13c131829a33cb5bedb5c64aa6f4add2Structure(s, config);
}

}


