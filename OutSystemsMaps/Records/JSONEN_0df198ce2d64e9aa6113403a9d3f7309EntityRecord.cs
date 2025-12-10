using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MapType
public class JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord : AbstractRESTStructure<EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord() { }

public JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord, EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s) => ToStructure(s, config);
}
public static EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s = new EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord FromStructure(EN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_0df198ce2d64e9aa6113403a9d3f7309EntityRecord(s, config);
}

}


