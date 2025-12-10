using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEventTriggered
public class RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord : AbstractRESTStructure<EN_8a068e43cce18c5870b845073fb713c1EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord() { }

public RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord (EN_8a068e43cce18c5870b845073fb713c1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_8a068e43cce18c5870b845073fb713c1EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord obj) { 
  EN_8a068e43cce18c5870b845073fb713c1EntityRecord s = new EN_8a068e43cce18c5870b845073fb713c1EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_8a068e43cce18c5870b845073fb713c1EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8a068e43cce18c5870b845073fb713c1EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord FromStructure(EN_8a068e43cce18c5870b845073fb713c1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_8a068e43cce18c5870b845073fb713c1EntityRecord(s, config);
}

}


