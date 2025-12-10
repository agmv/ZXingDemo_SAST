using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderOptionalConfigsRecord
public class RESTRC_4fc16da695108ad1b034b7256ffa868d : AbstractRESTStructure<RC_4fc16da695108ad1b034b7256ffa868d> {
[JsonProperty("RangeSliderOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure AttrRangeSliderOptionalConfigs;

public RESTRC_4fc16da695108ad1b034b7256ffa868d() { }

public RESTRC_4fc16da695108ad1b034b7256ffa868d (RC_4fc16da695108ad1b034b7256ffa868d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRangeSliderOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTRangeSliderOptionalConfigs, new ST_7167810326c75456a7ce120ed2dbd76bStructure(), ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure.FromStructureDelegate(config));
  } else {
AttrRangeSliderOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure.FromStructure(s.ssSTRangeSliderOptionalConfigs, config);
  }
}

public static RC_4fc16da695108ad1b034b7256ffa868d ToStructure(ssOutSystemsUI.RestRecords.RESTRC_4fc16da695108ad1b034b7256ffa868d obj) { 
  RC_4fc16da695108ad1b034b7256ffa868d s = new RC_4fc16da695108ad1b034b7256ffa868d();
  if(obj != null) {
  s.ssSTRangeSliderOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_7167810326c75456a7ce120ed2dbd76bStructure.ToStructure(obj.AttrRangeSliderOptionalConfigs);
  }
  return s;
}

public static Func<RC_4fc16da695108ad1b034b7256ffa868d, ssOutSystemsUI.RestRecords.RESTRC_4fc16da695108ad1b034b7256ffa868d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4fc16da695108ad1b034b7256ffa868d s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_4fc16da695108ad1b034b7256ffa868d FromStructure(RC_4fc16da695108ad1b034b7256ffa868d s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_4fc16da695108ad1b034b7256ffa868d(s, config);
}

}


