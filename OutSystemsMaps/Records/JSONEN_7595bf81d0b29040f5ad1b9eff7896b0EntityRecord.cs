using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEvent
public class JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord : AbstractRESTStructure<EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord() { }

public JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord, EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s) => ToStructure(s, config);
}
public static EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s = new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord FromStructure(EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord(s, config);
}

}


