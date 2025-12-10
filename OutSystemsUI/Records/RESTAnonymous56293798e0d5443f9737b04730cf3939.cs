using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressCircle_InternalConfigRecord
public class RESTRC_b6f4f6f58cf9d7e93da0322d7951765a : AbstractRESTStructure<RC_b6f4f6f58cf9d7e93da0322d7951765a> {
[JsonProperty("ProgressCircle_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_2fd97622d01b72b1af62467b00f1da8eStructure AttrProgressCircle_InternalConfig;

public RESTRC_b6f4f6f58cf9d7e93da0322d7951765a() { }

public RESTRC_b6f4f6f58cf9d7e93da0322d7951765a (RC_b6f4f6f58cf9d7e93da0322d7951765a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressCircle_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTProgressCircle_InternalConfig, new ST_2fd97622d01b72b1af62467b00f1da8eStructure(), ssOutSystemsUI.RestRecords.RESTST_2fd97622d01b72b1af62467b00f1da8eStructure.FromStructureDelegate(config));
  } else {
AttrProgressCircle_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_2fd97622d01b72b1af62467b00f1da8eStructure.FromStructure(s.ssSTProgressCircle_InternalConfig, config);
  }
}

public static RC_b6f4f6f58cf9d7e93da0322d7951765a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b6f4f6f58cf9d7e93da0322d7951765a obj) { 
  RC_b6f4f6f58cf9d7e93da0322d7951765a s = new RC_b6f4f6f58cf9d7e93da0322d7951765a();
  if(obj != null) {
  s.ssSTProgressCircle_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_2fd97622d01b72b1af62467b00f1da8eStructure.ToStructure(obj.AttrProgressCircle_InternalConfig);
  }
  return s;
}

public static Func<RC_b6f4f6f58cf9d7e93da0322d7951765a, ssOutSystemsUI.RestRecords.RESTRC_b6f4f6f58cf9d7e93da0322d7951765a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b6f4f6f58cf9d7e93da0322d7951765a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b6f4f6f58cf9d7e93da0322d7951765a FromStructure(RC_b6f4f6f58cf9d7e93da0322d7951765a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b6f4f6f58cf9d7e93da0322d7951765a(s, config);
}

}


