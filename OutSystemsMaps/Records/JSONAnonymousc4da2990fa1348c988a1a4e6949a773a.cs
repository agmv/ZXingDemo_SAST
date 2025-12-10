using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalRectangleConfigsRecord
public class JSONRC_a11b90f038b532a4625b14a0974b03a2 : AbstractRESTStructure<RC_a11b90f038b532a4625b14a0974b03a2> {
[JsonProperty("OptionalRectangleConfigs")]
[JsonPropertyName("OptionalRectangleConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_fbded4e930a61a57761a37f0b1ea8d40Structure AttrOptionalRectangleConfigs;

public JSONRC_a11b90f038b532a4625b14a0974b03a2() { }

public JSONRC_a11b90f038b532a4625b14a0974b03a2 (RC_a11b90f038b532a4625b14a0974b03a2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalRectangleConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalRectangleConfigs, new ST_fbded4e930a61a57761a37f0b1ea8d40Structure(), ssOutSystemsMaps.RestRecords.JSONST_fbded4e930a61a57761a37f0b1ea8d40Structure.FromStructureDelegate(config));
  } else {
AttrOptionalRectangleConfigs = ssOutSystemsMaps.RestRecords.JSONST_fbded4e930a61a57761a37f0b1ea8d40Structure.FromStructure(s.ssSTOptionalRectangleConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2, RC_a11b90f038b532a4625b14a0974b03a2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2 s) => ToStructure(s, config);
}
public static RC_a11b90f038b532a4625b14a0974b03a2 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2 obj, IBehaviorsConfiguration config) { 
  RC_a11b90f038b532a4625b14a0974b03a2 s = new RC_a11b90f038b532a4625b14a0974b03a2();
  if(obj != null) {
  s.ssSTOptionalRectangleConfigs = ssOutSystemsMaps.RestRecords.JSONST_fbded4e930a61a57761a37f0b1ea8d40Structure.ToStructure(obj.AttrOptionalRectangleConfigs, config);
  }
  return s;
}

public static Func<RC_a11b90f038b532a4625b14a0974b03a2, ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a11b90f038b532a4625b14a0974b03a2 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2 FromStructure(RC_a11b90f038b532a4625b14a0974b03a2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_a11b90f038b532a4625b14a0974b03a2(s, config);
}

}


