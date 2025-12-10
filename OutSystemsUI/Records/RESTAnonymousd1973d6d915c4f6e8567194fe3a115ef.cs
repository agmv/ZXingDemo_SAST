using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSlider_InternalConfigRecord
public class RESTRC_a52e1739b8f4600af03587813c6346bb : AbstractRESTStructure<RC_a52e1739b8f4600af03587813c6346bb> {
[JsonProperty("RangeSlider_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure AttrRangeSlider_InternalConfig;

public RESTRC_a52e1739b8f4600af03587813c6346bb() { }

public RESTRC_a52e1739b8f4600af03587813c6346bb (RC_a52e1739b8f4600af03587813c6346bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRangeSlider_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTRangeSlider_InternalConfig, new ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure(), ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure.FromStructureDelegate(config));
  } else {
AttrRangeSlider_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure.FromStructure(s.ssSTRangeSlider_InternalConfig, config);
  }
}

public static RC_a52e1739b8f4600af03587813c6346bb ToStructure(ssOutSystemsUI.RestRecords.RESTRC_a52e1739b8f4600af03587813c6346bb obj) { 
  RC_a52e1739b8f4600af03587813c6346bb s = new RC_a52e1739b8f4600af03587813c6346bb();
  if(obj != null) {
  s.ssSTRangeSlider_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_5abb10cad8e1029cd3a5a677a5bd89aeStructure.ToStructure(obj.AttrRangeSlider_InternalConfig);
  }
  return s;
}

public static Func<RC_a52e1739b8f4600af03587813c6346bb, ssOutSystemsUI.RestRecords.RESTRC_a52e1739b8f4600af03587813c6346bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a52e1739b8f4600af03587813c6346bb s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_a52e1739b8f4600af03587813c6346bb FromStructure(RC_a52e1739b8f4600af03587813c6346bb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_a52e1739b8f4600af03587813c6346bb(s, config);
}

}


