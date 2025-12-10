using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// TravelMode
public class RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord : AbstractRESTStructure<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord() { }

public RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord obj) { 
  EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s = new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord FromStructure(EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord(s, config);
}

}


