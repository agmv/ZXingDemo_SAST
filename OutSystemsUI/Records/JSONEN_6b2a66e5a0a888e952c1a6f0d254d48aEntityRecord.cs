using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselDirection
public class JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord : AbstractRESTStructure<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord() { }

public JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s) => ToStructure(s, config);
}
public static EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s = new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord FromStructure(EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord(s, config);
}

}


