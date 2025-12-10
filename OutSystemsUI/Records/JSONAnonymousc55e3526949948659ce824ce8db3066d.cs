using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// PasswordComplexityPolicyRecord
public class JSONRC_4d77cfdd567b208680377834fc8205a2 : AbstractRESTStructure<RC_4d77cfdd567b208680377834fc8205a2> {
[JsonProperty("PasswordComplexityPolicy")]
[JsonPropertyName("PasswordComplexityPolicy")]
public ssOutSystemsUI.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure AttrPasswordComplexityPolicy;

public JSONRC_4d77cfdd567b208680377834fc8205a2() { }

public JSONRC_4d77cfdd567b208680377834fc8205a2 (RC_4d77cfdd567b208680377834fc8205a2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordComplexityPolicy = ConvertToRestWithoutDefaults(s.ssSTPasswordComplexityPolicy, new ST_0774152396050b877fe73fc0db09d4f4Structure(), ssOutSystemsUI.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure.FromStructureDelegate(config));
  } else {
AttrPasswordComplexityPolicy = ssOutSystemsUI.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure.FromStructure(s.ssSTPasswordComplexityPolicy, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2, RC_4d77cfdd567b208680377834fc8205a2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2 s) => ToStructure(s, config);
}
public static RC_4d77cfdd567b208680377834fc8205a2 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2 obj, IBehaviorsConfiguration config) { 
  RC_4d77cfdd567b208680377834fc8205a2 s = new RC_4d77cfdd567b208680377834fc8205a2();
  if(obj != null) {
  s.ssSTPasswordComplexityPolicy = ssOutSystemsUI.RestRecords.JSONST_0774152396050b877fe73fc0db09d4f4Structure.ToStructure(obj.AttrPasswordComplexityPolicy, config);
  }
  return s;
}

public static Func<RC_4d77cfdd567b208680377834fc8205a2, ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d77cfdd567b208680377834fc8205a2 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2 FromStructure(RC_4d77cfdd567b208680377834fc8205a2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4d77cfdd567b208680377834fc8205a2(s, config);
}

}


