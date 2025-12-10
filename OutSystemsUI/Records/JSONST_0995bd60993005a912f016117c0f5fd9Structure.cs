using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProviderEventReturnMessage
public class JSONST_0995bd60993005a912f016117c0f5fd9Structure : AbstractRESTStructure<ST_0995bd60993005a912f016117c0f5fd9Structure> {
[JsonProperty("value")]
[JsonPropertyName("value")]
public string AttrProviderEventId;

[JsonProperty("isSuccess")]
[JsonPropertyName("isSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("code")]
[JsonPropertyName("code")]
public string AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

public JSONST_0995bd60993005a912f016117c0f5fd9Structure() { }

public JSONST_0995bd60993005a912f016117c0f5fd9Structure (ST_0995bd60993005a912f016117c0f5fd9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProviderEventId = ConvertToRestWithoutDefaults(s.ssProviderEventId, "");
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrProviderEventId = s.ssProviderEventId;
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure, ST_0995bd60993005a912f016117c0f5fd9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure s) => ToStructure(s, config);
}
public static ST_0995bd60993005a912f016117c0f5fd9Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure obj, IBehaviorsConfiguration config) { 
  ST_0995bd60993005a912f016117c0f5fd9Structure s = new ST_0995bd60993005a912f016117c0f5fd9Structure();
  if(obj != null) {
  s.ssProviderEventId = obj.AttrProviderEventId == null ? "" : obj.AttrProviderEventId;
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_0995bd60993005a912f016117c0f5fd9Structure, ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0995bd60993005a912f016117c0f5fd9Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure FromStructure(ST_0995bd60993005a912f016117c0f5fd9Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_0995bd60993005a912f016117c0f5fd9Structure(s, config);
}

}


