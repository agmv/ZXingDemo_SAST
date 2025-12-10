using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// TravelModeRecord
public class JSONRC_fd916ed3e439afbf2b3a8036c2de75ba : AbstractRESTStructure<RC_fd916ed3e439afbf2b3a8036c2de75ba> {
[JsonProperty("TravelMode")]
[JsonPropertyName("TravelMode")]
public ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord AttrTravelMode;

public JSONRC_fd916ed3e439afbf2b3a8036c2de75ba() { }

public JSONRC_fd916ed3e439afbf2b3a8036c2de75ba (RC_fd916ed3e439afbf2b3a8036c2de75ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTravelMode = ConvertToRestWithoutDefaults(s.ssENTravelMode, new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.FromStructureDelegate(config));
  } else {
AttrTravelMode = ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.FromStructure(s.ssENTravelMode, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba, RC_fd916ed3e439afbf2b3a8036c2de75ba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba s) => ToStructure(s, config);
}
public static RC_fd916ed3e439afbf2b3a8036c2de75ba ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba obj, IBehaviorsConfiguration config) { 
  RC_fd916ed3e439afbf2b3a8036c2de75ba s = new RC_fd916ed3e439afbf2b3a8036c2de75ba();
  if(obj != null) {
  s.ssENTravelMode = ssOutSystemsMaps.RestRecords.JSONEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.ToStructure(obj.AttrTravelMode, config);
  }
  return s;
}

public static Func<RC_fd916ed3e439afbf2b3a8036c2de75ba, ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fd916ed3e439afbf2b3a8036c2de75ba s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba FromStructure(RC_fd916ed3e439afbf2b3a8036c2de75ba s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_fd916ed3e439afbf2b3a8036c2de75ba(s, config);
}

}


