using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Speed
public class JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord : AbstractRESTStructure<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> {
[JsonProperty("Speed")]
[JsonPropertyName("Speed")]
public string AttrSpeed;

public JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord() { }

public JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpeed = s.ssSpeed;
  } else {
AttrSpeed = s.ssSpeed;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord s) => ToStructure(s, config);
}
public static EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord s = new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord();
  if(obj != null) {
  s.ssSpeed = obj.AttrSpeed == null ? "" : obj.AttrSpeed;
  }
  return s;
}

public static Func<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord FromStructure(EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord(s, config);
}

}


