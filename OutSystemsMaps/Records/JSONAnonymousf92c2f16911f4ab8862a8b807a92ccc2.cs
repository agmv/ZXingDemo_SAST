using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventTriggeredRecord
public class JSONRC_098c46906c1c0c7e7b39f1210fb64f78 : AbstractRESTStructure<RC_098c46906c1c0c7e7b39f1210fb64f78> {
[JsonProperty("ShapeEventTriggered")]
[JsonPropertyName("ShapeEventTriggered")]
public ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord AttrShapeEventTriggered;

public JSONRC_098c46906c1c0c7e7b39f1210fb64f78() { }

public JSONRC_098c46906c1c0c7e7b39f1210fb64f78 (RC_098c46906c1c0c7e7b39f1210fb64f78 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShapeEventTriggered = ConvertToRestWithoutDefaults(s.ssENShapeEventTriggered, new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.FromStructureDelegate(config));
  } else {
AttrShapeEventTriggered = ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.FromStructure(s.ssENShapeEventTriggered, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78, RC_098c46906c1c0c7e7b39f1210fb64f78> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78 s) => ToStructure(s, config);
}
public static RC_098c46906c1c0c7e7b39f1210fb64f78 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78 obj, IBehaviorsConfiguration config) { 
  RC_098c46906c1c0c7e7b39f1210fb64f78 s = new RC_098c46906c1c0c7e7b39f1210fb64f78();
  if(obj != null) {
  s.ssENShapeEventTriggered = ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord.ToStructure(obj.AttrShapeEventTriggered, config);
  }
  return s;
}

public static Func<RC_098c46906c1c0c7e7b39f1210fb64f78, ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_098c46906c1c0c7e7b39f1210fb64f78 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78 FromStructure(RC_098c46906c1c0c7e7b39f1210fb64f78 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_098c46906c1c0c7e7b39f1210fb64f78(s, config);
}

}


