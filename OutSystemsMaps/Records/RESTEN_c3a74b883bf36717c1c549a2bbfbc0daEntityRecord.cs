using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerType
public class RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord : AbstractRESTStructure<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord() { }

public RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord obj) { 
  EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s = new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord FromStructure(EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord(s, config);
}

}


