using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerTypeRecord
public class RESTRC_0b102c453446be3ebcb793be90d6b209 : AbstractRESTStructure<RC_0b102c453446be3ebcb793be90d6b209> {
[JsonProperty("MarkerType")]
public ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord AttrMarkerType;

public RESTRC_0b102c453446be3ebcb793be90d6b209() { }

public RESTRC_0b102c453446be3ebcb793be90d6b209 (RC_0b102c453446be3ebcb793be90d6b209 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarkerType = ConvertToRestWithoutDefaults(s.ssENMarkerType, new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord.FromStructureDelegate(config));
  } else {
AttrMarkerType = ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord.FromStructure(s.ssENMarkerType, config);
  }
}

public static RC_0b102c453446be3ebcb793be90d6b209 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_0b102c453446be3ebcb793be90d6b209 obj) { 
  RC_0b102c453446be3ebcb793be90d6b209 s = new RC_0b102c453446be3ebcb793be90d6b209();
  if(obj != null) {
  s.ssENMarkerType = ssOutSystemsMaps.RestRecords.RESTEN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord.ToStructure(obj.AttrMarkerType);
  }
  return s;
}

public static Func<RC_0b102c453446be3ebcb793be90d6b209, ssOutSystemsMaps.RestRecords.RESTRC_0b102c453446be3ebcb793be90d6b209> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0b102c453446be3ebcb793be90d6b209 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_0b102c453446be3ebcb793be90d6b209 FromStructure(RC_0b102c453446be3ebcb793be90d6b209 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_0b102c453446be3ebcb793be90d6b209(s, config);
}

}


