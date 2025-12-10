using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolTypeRecord
public class RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07 : AbstractRESTStructure<RC_e2e4078a68f051b01b0e49ed4f3f6e07> {
[JsonProperty("DrawingToolType")]
public ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord AttrDrawingToolType;

public RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07() { }

public RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07 (RC_e2e4078a68f051b01b0e49ed4f3f6e07 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolType = ConvertToRestWithoutDefaults(s.ssENDrawingToolType, new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolType = ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.FromStructure(s.ssENDrawingToolType, config);
  }
}

public static RC_e2e4078a68f051b01b0e49ed4f3f6e07 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07 obj) { 
  RC_e2e4078a68f051b01b0e49ed4f3f6e07 s = new RC_e2e4078a68f051b01b0e49ed4f3f6e07();
  if(obj != null) {
  s.ssENDrawingToolType = ssOutSystemsMaps.RestRecords.RESTEN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord.ToStructure(obj.AttrDrawingToolType);
  }
  return s;
}

public static Func<RC_e2e4078a68f051b01b0e49ed4f3f6e07, ssOutSystemsMaps.RestRecords.RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e2e4078a68f051b01b0e49ed4f3f6e07 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07 FromStructure(RC_e2e4078a68f051b01b0e49ed4f3f6e07 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_e2e4078a68f051b01b0e49ed4f3f6e07(s, config);
}

}


