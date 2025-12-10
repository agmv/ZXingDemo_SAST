using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Provider
public class JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord : AbstractRESTStructure<EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord() { }

public JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord, EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s) => ToStructure(s, config);
}
public static EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s = new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord FromStructure(EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord(s, config);
}

}


