using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionIconType
public class JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord : AbstractRESTStructure<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord() { }

public JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s) => ToStructure(s, config);
}
public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s = new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord FromStructure(EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord(s, config);
}

}


