using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StackedCardsPositionRecord
public class JSONRC_967cb65710fd1a346ebf0b0d8dbea56b : AbstractRESTStructure<RC_967cb65710fd1a346ebf0b0d8dbea56b> {
[JsonProperty("StackedCardsPosition")]
[JsonPropertyName("StackedCardsPosition")]
public ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord AttrStackedCardsPosition;

public JSONRC_967cb65710fd1a346ebf0b0d8dbea56b() { }

public JSONRC_967cb65710fd1a346ebf0b0d8dbea56b (RC_967cb65710fd1a346ebf0b0d8dbea56b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStackedCardsPosition = ConvertToRestWithoutDefaults(s.ssENStackedCardsPosition, new EN_92679525739afa328c09890d25f5ac45EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord.FromStructureDelegate(config));
  } else {
AttrStackedCardsPosition = ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord.FromStructure(s.ssENStackedCardsPosition, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b, RC_967cb65710fd1a346ebf0b0d8dbea56b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b s) => ToStructure(s, config);
}
public static RC_967cb65710fd1a346ebf0b0d8dbea56b ToStructure(ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b obj, IBehaviorsConfiguration config) { 
  RC_967cb65710fd1a346ebf0b0d8dbea56b s = new RC_967cb65710fd1a346ebf0b0d8dbea56b();
  if(obj != null) {
  s.ssENStackedCardsPosition = ssOutSystemsUI.RestRecords.JSONEN_92679525739afa328c09890d25f5ac45EntityRecord.ToStructure(obj.AttrStackedCardsPosition, config);
  }
  return s;
}

public static Func<RC_967cb65710fd1a346ebf0b0d8dbea56b, ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_967cb65710fd1a346ebf0b0d8dbea56b s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b FromStructure(RC_967cb65710fd1a346ebf0b0d8dbea56b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_967cb65710fd1a346ebf0b0d8dbea56b(s, config);
}

}


