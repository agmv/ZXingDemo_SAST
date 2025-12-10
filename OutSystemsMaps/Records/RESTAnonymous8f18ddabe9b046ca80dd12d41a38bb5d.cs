using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEventTriggeredRecord
public class RESTRC_499511b992975daa9639159d76f69e74 : AbstractRESTStructure<RC_499511b992975daa9639159d76f69e74> {
[JsonProperty("DrawingToolsEventTriggered")]
public ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord AttrDrawingToolsEventTriggered;

public RESTRC_499511b992975daa9639159d76f69e74() { }

public RESTRC_499511b992975daa9639159d76f69e74 (RC_499511b992975daa9639159d76f69e74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDrawingToolsEventTriggered = ConvertToRestWithoutDefaults(s.ssENDrawingToolsEventTriggered, new EN_8a068e43cce18c5870b845073fb713c1EntityRecord(), ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord.FromStructureDelegate(config));
  } else {
AttrDrawingToolsEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord.FromStructure(s.ssENDrawingToolsEventTriggered, config);
  }
}

public static RC_499511b992975daa9639159d76f69e74 ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_499511b992975daa9639159d76f69e74 obj) { 
  RC_499511b992975daa9639159d76f69e74 s = new RC_499511b992975daa9639159d76f69e74();
  if(obj != null) {
  s.ssENDrawingToolsEventTriggered = ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord.ToStructure(obj.AttrDrawingToolsEventTriggered);
  }
  return s;
}

public static Func<RC_499511b992975daa9639159d76f69e74, ssOutSystemsMaps.RestRecords.RESTRC_499511b992975daa9639159d76f69e74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_499511b992975daa9639159d76f69e74 s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_499511b992975daa9639159d76f69e74 FromStructure(RC_499511b992975daa9639159d76f69e74 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_499511b992975daa9639159d76f69e74(s, config);
}

}


