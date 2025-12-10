using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressCircle_InternalConfigRecord
public class JSONRC_b6f4f6f58cf9d7e93da0322d7951765a : AbstractRESTStructure<RC_b6f4f6f58cf9d7e93da0322d7951765a> {
[JsonProperty("ProgressCircle_InternalConfig")]
[JsonPropertyName("ProgressCircle_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_2fd97622d01b72b1af62467b00f1da8eStructure AttrProgressCircle_InternalConfig;

public JSONRC_b6f4f6f58cf9d7e93da0322d7951765a() { }

public JSONRC_b6f4f6f58cf9d7e93da0322d7951765a (RC_b6f4f6f58cf9d7e93da0322d7951765a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressCircle_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTProgressCircle_InternalConfig, new ST_2fd97622d01b72b1af62467b00f1da8eStructure(), ssOutSystemsUI.RestRecords.JSONST_2fd97622d01b72b1af62467b00f1da8eStructure.FromStructureDelegate(config));
  } else {
AttrProgressCircle_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_2fd97622d01b72b1af62467b00f1da8eStructure.FromStructure(s.ssSTProgressCircle_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a, RC_b6f4f6f58cf9d7e93da0322d7951765a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a s) => ToStructure(s, config);
}
public static RC_b6f4f6f58cf9d7e93da0322d7951765a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a obj, IBehaviorsConfiguration config) { 
  RC_b6f4f6f58cf9d7e93da0322d7951765a s = new RC_b6f4f6f58cf9d7e93da0322d7951765a();
  if(obj != null) {
  s.ssSTProgressCircle_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_2fd97622d01b72b1af62467b00f1da8eStructure.ToStructure(obj.AttrProgressCircle_InternalConfig, config);
  }
  return s;
}

public static Func<RC_b6f4f6f58cf9d7e93da0322d7951765a, ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b6f4f6f58cf9d7e93da0322d7951765a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a FromStructure(RC_b6f4f6f58cf9d7e93da0322d7951765a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b6f4f6f58cf9d7e93da0322d7951765a(s, config);
}

}


