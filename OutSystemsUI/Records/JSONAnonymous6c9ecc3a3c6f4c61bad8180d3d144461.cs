using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SpeedRecord
public class JSONRC_d15ba8cc56cc5ee58bd8acaffd974239 : AbstractRESTStructure<RC_d15ba8cc56cc5ee58bd8acaffd974239> {
[JsonProperty("Speed")]
[JsonPropertyName("Speed")]
public ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord AttrSpeed;

public JSONRC_d15ba8cc56cc5ee58bd8acaffd974239() { }

public JSONRC_d15ba8cc56cc5ee58bd8acaffd974239 (RC_d15ba8cc56cc5ee58bd8acaffd974239 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpeed = ConvertToRestWithoutDefaults(s.ssENSpeed, new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord.FromStructureDelegate(config));
  } else {
AttrSpeed = ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord.FromStructure(s.ssENSpeed, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239, RC_d15ba8cc56cc5ee58bd8acaffd974239> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239 s) => ToStructure(s, config);
}
public static RC_d15ba8cc56cc5ee58bd8acaffd974239 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239 obj, IBehaviorsConfiguration config) { 
  RC_d15ba8cc56cc5ee58bd8acaffd974239 s = new RC_d15ba8cc56cc5ee58bd8acaffd974239();
  if(obj != null) {
  s.ssENSpeed = ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord.ToStructure(obj.AttrSpeed, config);
  }
  return s;
}

public static Func<RC_d15ba8cc56cc5ee58bd8acaffd974239, ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d15ba8cc56cc5ee58bd8acaffd974239 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239 FromStructure(RC_d15ba8cc56cc5ee58bd8acaffd974239 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_d15ba8cc56cc5ee58bd8acaffd974239(s, config);
}

}


