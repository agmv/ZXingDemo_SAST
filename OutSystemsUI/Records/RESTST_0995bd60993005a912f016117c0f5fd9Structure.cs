using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProviderEventReturnMessage
public class RESTST_0995bd60993005a912f016117c0f5fd9Structure : AbstractRESTStructure<ST_0995bd60993005a912f016117c0f5fd9Structure> {
[JsonProperty("ProviderEventId")]
public string AttrProviderEventId;

[JsonProperty("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_0995bd60993005a912f016117c0f5fd9Structure() { }

public RESTST_0995bd60993005a912f016117c0f5fd9Structure (ST_0995bd60993005a912f016117c0f5fd9Structure s, IBehaviorsConfiguration config) {
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

public static ST_0995bd60993005a912f016117c0f5fd9Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure obj) { 
  ST_0995bd60993005a912f016117c0f5fd9Structure s = new ST_0995bd60993005a912f016117c0f5fd9Structure();
  if(obj != null) {
  s.ssProviderEventId = obj.AttrProviderEventId == null ? "" : obj.AttrProviderEventId;
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_0995bd60993005a912f016117c0f5fd9Structure, ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0995bd60993005a912f016117c0f5fd9Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure FromStructure(ST_0995bd60993005a912f016117c0f5fd9Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_0995bd60993005a912f016117c0f5fd9Structure(s, config);
}

}


