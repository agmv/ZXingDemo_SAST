using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolType
public class JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord : AbstractRESTStructure<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord() { }

public JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s) => ToStructure(s, config);
}
public static EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s = new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord FromStructure(EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord(s, config);
}

}


