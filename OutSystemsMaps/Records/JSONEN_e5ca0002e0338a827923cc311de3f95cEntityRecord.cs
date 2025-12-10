using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapEvent
public class JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord : AbstractRESTStructure<EN_e5ca0002e0338a827923cc311de3f95cEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord() { }

public JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord, EN_e5ca0002e0338a827923cc311de3f95cEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord s) => ToStructure(s, config);
}
public static EN_e5ca0002e0338a827923cc311de3f95cEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s = new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_e5ca0002e0338a827923cc311de3f95cEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord FromStructure(EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_e5ca0002e0338a827923cc311de3f95cEntityRecord(s, config);
}

}


