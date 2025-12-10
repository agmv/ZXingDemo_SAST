using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolTypeRecord
public class JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07 : AbstractRESTStructure<RC_e2e4078a68f051b01b0e49ed4f3f6e07> {
[JsonProperty("DrawingToolType")]
[JsonPropertyName("DrawingToolType")]
public ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord AttrDrawingToolType;

public JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07() { }

public JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07 (RC_e2e4078a68f051b01b0e49ed4f3f6e07 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolType = ConvertToRestWithoutDefaults(s.ssENDrawingToolType, new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolType = ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.FromStructure(s.ssENDrawingToolType, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07, RC_e2e4078a68f051b01b0e49ed4f3f6e07> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07 s) => ToStructure(s, config);
}
public static RC_e2e4078a68f051b01b0e49ed4f3f6e07 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07 obj, IBehaviorsConfiguration config) { 
  RC_e2e4078a68f051b01b0e49ed4f3f6e07 s = new RC_e2e4078a68f051b01b0e49ed4f3f6e07();
  if(obj != null) {
  s.ssENDrawingToolType = ssOutSystemsMaps.RestRecords.JSONEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.ToStructure(obj.AttrDrawingToolType, config);
  }
  return s;
}

public static Func<RC_e2e4078a68f051b01b0e49ed4f3f6e07, ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e2e4078a68f051b01b0e49ed4f3f6e07 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07 FromStructure(RC_e2e4078a68f051b01b0e49ed4f3f6e07 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_e2e4078a68f051b01b0e49ed4f3f6e07(s, config);
}

}


