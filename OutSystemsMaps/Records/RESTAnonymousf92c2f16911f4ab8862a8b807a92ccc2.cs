using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventTriggeredRecord
public class RESTRC_098c46906c1c0c7e7b39f1210fb64f78 : AbstractRESTStructure<RC_098c46906c1c0c7e7b39f1210fb64f78> {
[JsonProperty("ShapeEventTriggered")]
public ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord AttrShapeEventTriggered;

public RESTRC_098c46906c1c0c7e7b39f1210fb64f78() { }

public RESTRC_098c46906c1c0c7e7b39f1210fb64f78 (RC_098c46906c1c0c7e7b39f1210fb64f78 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShapeEventTriggered = ConvertToRestWithoutDefaults(s.ssENShapeEventTriggered, new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.FromStructureDelegate(config));
  } else {
AttrShapeEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.FromStructure(s.ssENShapeEventTriggered, config);
  }
}

public static RC_098c46906c1c0c7e7b39f1210fb64f78 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_098c46906c1c0c7e7b39f1210fb64f78 obj) { 
  RC_098c46906c1c0c7e7b39f1210fb64f78 s = new RC_098c46906c1c0c7e7b39f1210fb64f78();
  if(obj != null) {
  s.ssENShapeEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.ToStructure(obj.AttrShapeEventTriggered);
  }
  return s;
}

public static Func<RC_098c46906c1c0c7e7b39f1210fb64f78, ssOutSystemsMaps.RestRecords.RESTRC_098c46906c1c0c7e7b39f1210fb64f78> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_098c46906c1c0c7e7b39f1210fb64f78 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_098c46906c1c0c7e7b39f1210fb64f78 FromStructure(RC_098c46906c1c0c7e7b39f1210fb64f78 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_098c46906c1c0c7e7b39f1210fb64f78(s, config);
}

}


