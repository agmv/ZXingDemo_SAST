using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapEvent
public class RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord : AbstractRESTStructure<EN_e5ca0002e0338a827923cc311de3f95cEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord() { }

public RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_e5ca0002e0338a827923cc311de3f95cEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord obj) { 
  EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s = new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_e5ca0002e0338a827923cc311de3f95cEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord FromStructure(EN_e5ca0002e0338a827923cc311de3f95cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_e5ca0002e0338a827923cc311de3f95cEntityRecord(s, config);
}

}


