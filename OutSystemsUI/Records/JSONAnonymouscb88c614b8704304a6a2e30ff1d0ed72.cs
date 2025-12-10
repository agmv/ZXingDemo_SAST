using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// PasswordValidationResultRecord
public class JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 : AbstractRESTStructure<RC_b27f0b968b0f7cea61506ac9d6ee7c27> {
[JsonProperty("PasswordValidationResult")]
[JsonPropertyName("PasswordValidationResult")]
public ssOutSystemsUI.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure AttrPasswordValidationResult;

public JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27() { }

public JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordValidationResult = ConvertToRestWithoutDefaults(s.ssSTPasswordValidationResult, new ST_b9e6959231369ae517164f0fb8e8606dStructure(), ssOutSystemsUI.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructureDelegate(config));
  } else {
AttrPasswordValidationResult = ssOutSystemsUI.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructure(s.ssSTPasswordValidationResult, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27, RC_b27f0b968b0f7cea61506ac9d6ee7c27> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 s) => ToStructure(s, config);
}
public static RC_b27f0b968b0f7cea61506ac9d6ee7c27 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 obj, IBehaviorsConfiguration config) { 
  RC_b27f0b968b0f7cea61506ac9d6ee7c27 s = new RC_b27f0b968b0f7cea61506ac9d6ee7c27();
  if(obj != null) {
  s.ssSTPasswordValidationResult = ssOutSystemsUI.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.ToStructure(obj.AttrPasswordValidationResult, config);
  }
  return s;
}

public static Func<RC_b27f0b968b0f7cea61506ac9d6ee7c27, ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 FromStructure(RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27(s, config);
}

}


