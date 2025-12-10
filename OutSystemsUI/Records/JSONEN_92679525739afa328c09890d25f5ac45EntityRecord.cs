using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StackedCardsPosition
public class JSONEN_92679525739afa328c09890d25f5ac45EntityRecord : AbstractRESTStructure<EN_92679525739afa328c09890d25f5ac45EntityRecord> {
[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

public JSONEN_92679525739afa328c09890d25f5ac45EntityRecord() { }

public JSONEN_92679525739afa328c09890d25f5ac45EntityRecord (EN_92679525739afa328c09890d25f5ac45EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
  } else {
AttrLabel = s.ssLabel;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord, EN_92679525739afa328c09890d25f5ac45EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord s) => ToStructure(s, config);
}
public static EN_92679525739afa328c09890d25f5ac45EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_92679525739afa328c09890d25f5ac45EntityRecord s = new EN_92679525739afa328c09890d25f5ac45EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<EN_92679525739afa328c09890d25f5ac45EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_92679525739afa328c09890d25f5ac45EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord FromStructure(EN_92679525739afa328c09890d25f5ac45EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord(s, config);
}

}


