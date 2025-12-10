using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderTypeRecord
public class RESTRC_f332a0a4298f66d209888b6f5c56f633 : AbstractRESTStructure<RC_f332a0a4298f66d209888b6f5c56f633> {
[JsonProperty("RangeSliderType")]
public ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord AttrRangeSliderType;

public RESTRC_f332a0a4298f66d209888b6f5c56f633() { }

public RESTRC_f332a0a4298f66d209888b6f5c56f633 (RC_f332a0a4298f66d209888b6f5c56f633 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRangeSliderType = ConvertToRestWithoutDefaults(s.ssENRangeSliderType, new EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord.FromStructureDelegate(config));
  } else {
AttrRangeSliderType = ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord.FromStructure(s.ssENRangeSliderType, config);
  }
}

public static RC_f332a0a4298f66d209888b6f5c56f633 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_f332a0a4298f66d209888b6f5c56f633 obj) { 
  RC_f332a0a4298f66d209888b6f5c56f633 s = new RC_f332a0a4298f66d209888b6f5c56f633();
  if(obj != null) {
  s.ssENRangeSliderType = ssOutSystemsUI.RestRecords.RESTEN_7e19f04989174b13ab8c3badf82f69b4EntityRecord.ToStructure(obj.AttrRangeSliderType);
  }
  return s;
}

public static Func<RC_f332a0a4298f66d209888b6f5c56f633, ssOutSystemsUI.RestRecords.RESTRC_f332a0a4298f66d209888b6f5c56f633> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f332a0a4298f66d209888b6f5c56f633 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_f332a0a4298f66d209888b6f5c56f633 FromStructure(RC_f332a0a4298f66d209888b6f5c56f633 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_f332a0a4298f66d209888b6f5c56f633(s, config);
}

}


