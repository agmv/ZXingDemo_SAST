using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// StrokeRecord
public class JSONRC_80cb2a4451da1d8d8f25a688259024cd : AbstractRESTStructure<RC_80cb2a4451da1d8d8f25a688259024cd> {
[JsonProperty("Stroke")]
[JsonPropertyName("Stroke")]
public ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

public JSONRC_80cb2a4451da1d8d8f25a688259024cd() { }

public JSONRC_80cb2a4451da1d8d8f25a688259024cd (RC_80cb2a4451da1d8d8f25a688259024cd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStroke = ConvertToRestWithoutDefaults(s.ssSTStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
  } else {
AttrStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssSTStroke, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd, RC_80cb2a4451da1d8d8f25a688259024cd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd s) => ToStructure(s, config);
}
public static RC_80cb2a4451da1d8d8f25a688259024cd ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd obj, IBehaviorsConfiguration config) { 
  RC_80cb2a4451da1d8d8f25a688259024cd s = new RC_80cb2a4451da1d8d8f25a688259024cd();
  if(obj != null) {
  s.ssSTStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke, config);
  }
  return s;
}

public static Func<RC_80cb2a4451da1d8d8f25a688259024cd, ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80cb2a4451da1d8d8f25a688259024cd s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd FromStructure(RC_80cb2a4451da1d8d8f25a688259024cd s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_80cb2a4451da1d8d8f25a688259024cd(s, config);
}

}


