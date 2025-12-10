using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StackedCardsPosition
public class RESTEN_92679525739afa328c09890d25f5ac45EntityRecord : AbstractRESTStructure<EN_92679525739afa328c09890d25f5ac45EntityRecord> {
[JsonProperty("Label")]
public string AttrLabel;

public RESTEN_92679525739afa328c09890d25f5ac45EntityRecord() { }

public RESTEN_92679525739afa328c09890d25f5ac45EntityRecord (EN_92679525739afa328c09890d25f5ac45EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
  } else {
AttrLabel = s.ssLabel;
  }
}

public static EN_92679525739afa328c09890d25f5ac45EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord obj) { 
  EN_92679525739afa328c09890d25f5ac45EntityRecord s = new EN_92679525739afa328c09890d25f5ac45EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<EN_92679525739afa328c09890d25f5ac45EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_92679525739afa328c09890d25f5ac45EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord FromStructure(EN_92679525739afa328c09890d25f5ac45EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord(s, config);
}

}


