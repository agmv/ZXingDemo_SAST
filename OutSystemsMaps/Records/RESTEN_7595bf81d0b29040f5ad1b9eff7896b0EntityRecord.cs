using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEvent
public class RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord : AbstractRESTStructure<EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord() { }

public RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord obj) { 
  EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s = new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord FromStructure(EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord(s, config);
}

}


