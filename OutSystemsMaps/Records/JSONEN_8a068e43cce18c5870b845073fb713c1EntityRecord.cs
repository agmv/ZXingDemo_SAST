using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEventTriggered
public class JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord : AbstractRESTStructure<EN_8a068e43cce18c5870b845073fb713c1EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord() { }

public JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord (EN_8a068e43cce18c5870b845073fb713c1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord, EN_8a068e43cce18c5870b845073fb713c1EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord s) => ToStructure(s, config);
}
public static EN_8a068e43cce18c5870b845073fb713c1EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8a068e43cce18c5870b845073fb713c1EntityRecord s = new EN_8a068e43cce18c5870b845073fb713c1EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_8a068e43cce18c5870b845073fb713c1EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8a068e43cce18c5870b845073fb713c1EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord FromStructure(EN_8a068e43cce18c5870b845073fb713c1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_8a068e43cce18c5870b845073fb713c1EntityRecord(s, config);
}

}


