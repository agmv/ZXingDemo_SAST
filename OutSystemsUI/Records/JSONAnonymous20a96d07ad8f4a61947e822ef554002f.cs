using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// VirtualSelectConfigsRecord
public class JSONRC_a34c029579f872c2fbb90741544ea7c6 : AbstractRESTStructure<RC_a34c029579f872c2fbb90741544ea7c6> {
[JsonProperty("VirtualSelectConfigs")]
[JsonPropertyName("VirtualSelectConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_ee4d16d56cd7c489ec094cc9fa0cd607Structure AttrVirtualSelectConfigs;

public JSONRC_a34c029579f872c2fbb90741544ea7c6() { }

public JSONRC_a34c029579f872c2fbb90741544ea7c6 (RC_a34c029579f872c2fbb90741544ea7c6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVirtualSelectConfigs = ConvertToRestWithoutDefaults(s.ssSTVirtualSelectConfigs, new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure(), ssOutSystemsUI.RestRecords.JSONST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.FromStructureDelegate(config));
  } else {
AttrVirtualSelectConfigs = ssOutSystemsUI.RestRecords.JSONST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.FromStructure(s.ssSTVirtualSelectConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6, RC_a34c029579f872c2fbb90741544ea7c6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6 s) => ToStructure(s, config);
}
public static RC_a34c029579f872c2fbb90741544ea7c6 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6 obj, IBehaviorsConfiguration config) { 
  RC_a34c029579f872c2fbb90741544ea7c6 s = new RC_a34c029579f872c2fbb90741544ea7c6();
  if(obj != null) {
  s.ssSTVirtualSelectConfigs = ssOutSystemsUI.RestRecords.JSONST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.ToStructure(obj.AttrVirtualSelectConfigs, config);
  }
  return s;
}

public static Func<RC_a34c029579f872c2fbb90741544ea7c6, ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a34c029579f872c2fbb90741544ea7c6 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6 FromStructure(RC_a34c029579f872c2fbb90741544ea7c6 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_a34c029579f872c2fbb90741544ea7c6(s, config);
}

}


