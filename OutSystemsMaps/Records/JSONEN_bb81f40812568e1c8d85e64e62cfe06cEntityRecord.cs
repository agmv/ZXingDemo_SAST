using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEvent
public class JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord : AbstractRESTStructure<EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord() { }

public JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord, EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s) => ToStructure(s, config);
}
public static EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s = new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord FromStructure(EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord(s, config);
}

}


