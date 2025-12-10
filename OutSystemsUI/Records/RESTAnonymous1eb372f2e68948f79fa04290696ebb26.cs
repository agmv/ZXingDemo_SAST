using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StackedCardsPositionRecord
public class RESTRC_967cb65710fd1a346ebf0b0d8dbea56b : AbstractRESTStructure<RC_967cb65710fd1a346ebf0b0d8dbea56b> {
[JsonProperty("StackedCardsPosition")]
public ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord AttrStackedCardsPosition;

public RESTRC_967cb65710fd1a346ebf0b0d8dbea56b() { }

public RESTRC_967cb65710fd1a346ebf0b0d8dbea56b (RC_967cb65710fd1a346ebf0b0d8dbea56b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStackedCardsPosition = ConvertToRestWithoutDefaults(s.ssENStackedCardsPosition, new EN_92679525739afa328c09890d25f5ac45EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord.FromStructureDelegate(config));
  } else {
AttrStackedCardsPosition = ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord.FromStructure(s.ssENStackedCardsPosition, config);
  }
}

public static RC_967cb65710fd1a346ebf0b0d8dbea56b ToStructure(ssOutSystemsUI.RestRecords.RESTRC_967cb65710fd1a346ebf0b0d8dbea56b obj) { 
  RC_967cb65710fd1a346ebf0b0d8dbea56b s = new RC_967cb65710fd1a346ebf0b0d8dbea56b();
  if(obj != null) {
  s.ssENStackedCardsPosition = ssOutSystemsUI.RestRecords.RESTEN_92679525739afa328c09890d25f5ac45EntityRecord.ToStructure(obj.AttrStackedCardsPosition);
  }
  return s;
}

public static Func<RC_967cb65710fd1a346ebf0b0d8dbea56b, ssOutSystemsUI.RestRecords.RESTRC_967cb65710fd1a346ebf0b0d8dbea56b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_967cb65710fd1a346ebf0b0d8dbea56b s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_967cb65710fd1a346ebf0b0d8dbea56b FromStructure(RC_967cb65710fd1a346ebf0b0d8dbea56b s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_967cb65710fd1a346ebf0b0d8dbea56b(s, config);
}

}


