using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Provider
public class RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord : AbstractRESTStructure<EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord() { }

public RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord obj) { 
  EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s = new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord FromStructure(EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord(s, config);
}

}


