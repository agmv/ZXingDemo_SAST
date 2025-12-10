using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolType
public class RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord : AbstractRESTStructure<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord() { }

public RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord obj) { 
  EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s = new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord FromStructure(EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord(s, config);
}

}


