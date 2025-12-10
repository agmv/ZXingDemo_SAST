using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// TravelMode
public class JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord : AbstractRESTStructure<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord() { }

public JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s) => ToStructure(s, config);
}
public static EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s = new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord FromStructure(EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord(s, config);
}

}


