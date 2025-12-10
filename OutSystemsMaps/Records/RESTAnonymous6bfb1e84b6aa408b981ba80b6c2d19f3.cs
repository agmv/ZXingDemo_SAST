using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsPositionRecord
public class RESTRC_c52fa927f09489f1c90f3a0526a1c8c9 : AbstractRESTStructure<RC_c52fa927f09489f1c90f3a0526a1c8c9> {
[JsonProperty("DrawingToolsPosition")]
public ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord AttrDrawingToolsPosition;

public RESTRC_c52fa927f09489f1c90f3a0526a1c8c9() { }

public RESTRC_c52fa927f09489f1c90f3a0526a1c8c9 (RC_c52fa927f09489f1c90f3a0526a1c8c9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolsPosition = ConvertToRestWithoutDefaults(s.ssENDrawingToolsPosition, new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolsPosition = ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord.FromStructure(s.ssENDrawingToolsPosition, config);
  }
}

public static RC_c52fa927f09489f1c90f3a0526a1c8c9 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_c52fa927f09489f1c90f3a0526a1c8c9 obj) { 
  RC_c52fa927f09489f1c90f3a0526a1c8c9 s = new RC_c52fa927f09489f1c90f3a0526a1c8c9();
  if(obj != null) {
  s.ssENDrawingToolsPosition = ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord.ToStructure(obj.AttrDrawingToolsPosition);
  }
  return s;
}

public static Func<RC_c52fa927f09489f1c90f3a0526a1c8c9, ssOutSystemsMaps.RestRecords.RESTRC_c52fa927f09489f1c90f3a0526a1c8c9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c52fa927f09489f1c90f3a0526a1c8c9 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_c52fa927f09489f1c90f3a0526a1c8c9 FromStructure(RC_c52fa927f09489f1c90f3a0526a1c8c9 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_c52fa927f09489f1c90f3a0526a1c8c9(s, config);
}

}


