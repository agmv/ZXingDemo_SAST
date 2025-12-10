using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ReturnMessage
public class JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure : AbstractRESTStructure<ST_13c131829a33cb5bedb5c64aa6f4add2Structure> {
[JsonProperty("isSuccess")]
[JsonPropertyName("isSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("code")]
[JsonPropertyName("code")]
public string AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

[JsonProperty("value")]
[JsonPropertyName("value")]
public string AttrValue;

public JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure() { }

public JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure (ST_13c131829a33cb5bedb5c64aa6f4add2Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure, ST_13c131829a33cb5bedb5c64aa6f4add2Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure s) => ToStructure(s, config);
}
public static ST_13c131829a33cb5bedb5c64aa6f4add2Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure obj, IBehaviorsConfiguration config) { 
  ST_13c131829a33cb5bedb5c64aa6f4add2Structure s = new ST_13c131829a33cb5bedb5c64aa6f4add2Structure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_13c131829a33cb5bedb5c64aa6f4add2Structure, ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_13c131829a33cb5bedb5c64aa6f4add2Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure FromStructure(ST_13c131829a33cb5bedb5c64aa6f4add2Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_13c131829a33cb5bedb5c64aa6f4add2Structure(s, config);
}

}


