using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderOptionalConfigsRecord
public class JSONRC_4fc16da695108ad1b034b7256ffa868d : AbstractRESTStructure<RC_4fc16da695108ad1b034b7256ffa868d> {
[JsonProperty("RangeSliderOptionalConfigs")]
[JsonPropertyName("RangeSliderOptionalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_7167810326c75456a7ce120ed2dbd76bStructure AttrRangeSliderOptionalConfigs;

public JSONRC_4fc16da695108ad1b034b7256ffa868d() { }

public JSONRC_4fc16da695108ad1b034b7256ffa868d (RC_4fc16da695108ad1b034b7256ffa868d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRangeSliderOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTRangeSliderOptionalConfigs, new ST_7167810326c75456a7ce120ed2dbd76bStructure(), ssOutSystemsUI.RestRecords.JSONST_7167810326c75456a7ce120ed2dbd76bStructure.FromStructureDelegate(config));
  } else {
AttrRangeSliderOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_7167810326c75456a7ce120ed2dbd76bStructure.FromStructure(s.ssSTRangeSliderOptionalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d, RC_4fc16da695108ad1b034b7256ffa868d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d s) => ToStructure(s, config);
}
public static RC_4fc16da695108ad1b034b7256ffa868d ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d obj, IBehaviorsConfiguration config) { 
  RC_4fc16da695108ad1b034b7256ffa868d s = new RC_4fc16da695108ad1b034b7256ffa868d();
  if(obj != null) {
  s.ssSTRangeSliderOptionalConfigs = ssOutSystemsUI.RestRecords.JSONST_7167810326c75456a7ce120ed2dbd76bStructure.ToStructure(obj.AttrRangeSliderOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_4fc16da695108ad1b034b7256ffa868d, ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4fc16da695108ad1b034b7256ffa868d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d FromStructure(RC_4fc16da695108ad1b034b7256ffa868d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4fc16da695108ad1b034b7256ffa868d(s, config);
}

}


