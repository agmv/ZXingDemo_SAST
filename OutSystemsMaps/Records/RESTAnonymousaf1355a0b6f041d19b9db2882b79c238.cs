using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// CircleShapeRecord
public class RESTRC_a4e8f80d0a21edea3a71318677a15130 : AbstractRESTStructure<RC_a4e8f80d0a21edea3a71318677a15130> {
[JsonProperty("CircleShape")]
public ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure AttrCircleShape;

public RESTRC_a4e8f80d0a21edea3a71318677a15130() { }

public RESTRC_a4e8f80d0a21edea3a71318677a15130 (RC_a4e8f80d0a21edea3a71318677a15130 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCircleShape = ConvertToRestWithoutDefaults(s.ssSTCircleShape, new ST_7e9e7e47a56960855c31bd37116d68abStructure(), ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure.FromStructureDelegate(config));
  } else {
AttrCircleShape = ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure.FromStructure(s.ssSTCircleShape, config);
  }
}

public static RC_a4e8f80d0a21edea3a71318677a15130 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_a4e8f80d0a21edea3a71318677a15130 obj) { 
  RC_a4e8f80d0a21edea3a71318677a15130 s = new RC_a4e8f80d0a21edea3a71318677a15130();
  if(obj != null) {
  s.ssSTCircleShape = ssOutSystemsMaps.RestRecords.RESTST_7e9e7e47a56960855c31bd37116d68abStructure.ToStructure(obj.AttrCircleShape);
  }
  return s;
}

public static Func<RC_a4e8f80d0a21edea3a71318677a15130, ssOutSystemsMaps.RestRecords.RESTRC_a4e8f80d0a21edea3a71318677a15130> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a4e8f80d0a21edea3a71318677a15130 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_a4e8f80d0a21edea3a71318677a15130 FromStructure(RC_a4e8f80d0a21edea3a71318677a15130 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_a4e8f80d0a21edea3a71318677a15130(s, config);
}

}


