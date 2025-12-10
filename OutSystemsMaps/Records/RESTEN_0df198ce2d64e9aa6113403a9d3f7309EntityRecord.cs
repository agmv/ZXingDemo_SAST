using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapType
public class RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord : AbstractRESTStructure<EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord() { }

public RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord obj) { 
  EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s = new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord FromStructure(EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord(s, config);
}

}


