using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// ShapeEventTriggered
public class JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord : AbstractRESTStructure<EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord() { }

public JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord, EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s) => ToStructure(s, config);
}
public static EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s = new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord FromStructure(EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord(s, config);
}

}


