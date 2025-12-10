using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// CircleShapeRecord
public class JSONRC_a4e8f80d0a21edea3a71318677a15130 : AbstractRESTStructure<RC_a4e8f80d0a21edea3a71318677a15130> {
[JsonProperty("CircleShape")]
[JsonPropertyName("CircleShape")]
public ssOutSystemsMaps.RestRecords.JSONST_7e9e7e47a56960855c31bd37116d68abStructure AttrCircleShape;

public JSONRC_a4e8f80d0a21edea3a71318677a15130() { }

public JSONRC_a4e8f80d0a21edea3a71318677a15130 (RC_a4e8f80d0a21edea3a71318677a15130 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCircleShape = ConvertToRestWithoutDefaults(s.ssSTCircleShape, new ST_7e9e7e47a56960855c31bd37116d68abStructure(), ssOutSystemsMaps.RestRecords.JSONST_7e9e7e47a56960855c31bd37116d68abStructure.FromStructureDelegate(config));
  } else {
AttrCircleShape = ssOutSystemsMaps.RestRecords.JSONST_7e9e7e47a56960855c31bd37116d68abStructure.FromStructure(s.ssSTCircleShape, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130, RC_a4e8f80d0a21edea3a71318677a15130> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130 s) => ToStructure(s, config);
}
public static RC_a4e8f80d0a21edea3a71318677a15130 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130 obj, IBehaviorsConfiguration config) { 
  RC_a4e8f80d0a21edea3a71318677a15130 s = new RC_a4e8f80d0a21edea3a71318677a15130();
  if(obj != null) {
  s.ssSTCircleShape = ssOutSystemsMaps.RestRecords.JSONST_7e9e7e47a56960855c31bd37116d68abStructure.ToStructure(obj.AttrCircleShape, config);
  }
  return s;
}

public static Func<RC_a4e8f80d0a21edea3a71318677a15130, ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a4e8f80d0a21edea3a71318677a15130 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130 FromStructure(RC_a4e8f80d0a21edea3a71318677a15130 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_a4e8f80d0a21edea3a71318677a15130(s, config);
}

}


