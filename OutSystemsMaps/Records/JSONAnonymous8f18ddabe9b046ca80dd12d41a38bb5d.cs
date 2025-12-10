using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEventTriggeredRecord
public class JSONRC_499511b992975daa9639159d76f69e74 : AbstractRESTStructure<RC_499511b992975daa9639159d76f69e74> {
[JsonProperty("DrawingToolsEventTriggered")]
[JsonPropertyName("DrawingToolsEventTriggered")]
public ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord AttrDrawingToolsEventTriggered;

public JSONRC_499511b992975daa9639159d76f69e74() { }

public JSONRC_499511b992975daa9639159d76f69e74 (RC_499511b992975daa9639159d76f69e74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolsEventTriggered = ConvertToRestWithoutDefaults(s.ssENDrawingToolsEventTriggered, new EN_8a068e43cce18c5870b845073fb713c1EntityRecord(), ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolsEventTriggered = ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord.FromStructure(s.ssENDrawingToolsEventTriggered, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74, RC_499511b992975daa9639159d76f69e74> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74 s) => ToStructure(s, config);
}
public static RC_499511b992975daa9639159d76f69e74 ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74 obj, IBehaviorsConfiguration config) { 
  RC_499511b992975daa9639159d76f69e74 s = new RC_499511b992975daa9639159d76f69e74();
  if(obj != null) {
  s.ssENDrawingToolsEventTriggered = ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord.ToStructure(obj.AttrDrawingToolsEventTriggered, config);
  }
  return s;
}

public static Func<RC_499511b992975daa9639159d76f69e74, ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_499511b992975daa9639159d76f69e74 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74 FromStructure(RC_499511b992975daa9639159d76f69e74 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_499511b992975daa9639159d76f69e74(s, config);
}

}


