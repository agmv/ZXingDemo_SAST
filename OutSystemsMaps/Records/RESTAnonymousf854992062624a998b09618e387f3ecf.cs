using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// TravelModeRecord
public class RESTRC_fd916ed3e439afbf2b3a8036c2de75ba : AbstractRESTStructure<RC_fd916ed3e439afbf2b3a8036c2de75ba> {
[JsonProperty("TravelMode")]
public ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord AttrTravelMode;

public RESTRC_fd916ed3e439afbf2b3a8036c2de75ba() { }

public RESTRC_fd916ed3e439afbf2b3a8036c2de75ba (RC_fd916ed3e439afbf2b3a8036c2de75ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTravelMode = ConvertToRestWithoutDefaults(s.ssENTravelMode, new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.FromStructureDelegate(config));
  } else {
AttrTravelMode = ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.FromStructure(s.ssENTravelMode, config);
  }
}

public static RC_fd916ed3e439afbf2b3a8036c2de75ba ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_fd916ed3e439afbf2b3a8036c2de75ba obj) { 
  RC_fd916ed3e439afbf2b3a8036c2de75ba s = new RC_fd916ed3e439afbf2b3a8036c2de75ba();
  if(obj != null) {
  s.ssENTravelMode = ssOutSystemsMaps.RestRecords.RESTEN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord.ToStructure(obj.AttrTravelMode);
  }
  return s;
}

public static Func<RC_fd916ed3e439afbf2b3a8036c2de75ba, ssOutSystemsMaps.RestRecords.RESTRC_fd916ed3e439afbf2b3a8036c2de75ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fd916ed3e439afbf2b3a8036c2de75ba s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_fd916ed3e439afbf2b3a8036c2de75ba FromStructure(RC_fd916ed3e439afbf2b3a8036c2de75ba s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_fd916ed3e439afbf2b3a8036c2de75ba(s, config);
}

}


