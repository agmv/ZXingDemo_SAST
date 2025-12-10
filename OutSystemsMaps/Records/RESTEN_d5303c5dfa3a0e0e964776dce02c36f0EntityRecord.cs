using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventTriggered
public class RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord : AbstractRESTStructure<EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord() { }

public RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord obj) { 
  EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s = new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord FromStructure(EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord(s, config);
}

}


