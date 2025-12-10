using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerType
public class JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord : AbstractRESTStructure<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord() { }

public JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s) => ToStructure(s, config);
}
public static EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s = new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord FromStructure(EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord(s, config);
}

}


