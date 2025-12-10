using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEvent
public class RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord : AbstractRESTStructure<EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord() { }

public RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord obj) { 
  EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s = new EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord FromStructure(EN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_bb81f40812568e1c8d85e64e62cfe06cEntityRecord(s, config);
}

}


