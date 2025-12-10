using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// StrokeRecord
public class RESTRC_80cb2a4451da1d8d8f25a688259024cd : AbstractRESTStructure<RC_80cb2a4451da1d8d8f25a688259024cd> {
[JsonProperty("Stroke")]
public ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

public RESTRC_80cb2a4451da1d8d8f25a688259024cd() { }

public RESTRC_80cb2a4451da1d8d8f25a688259024cd (RC_80cb2a4451da1d8d8f25a688259024cd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStroke = ConvertToRestWithoutDefaults(s.ssSTStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
  } else {
AttrStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssSTStroke, config);
  }
}

public static RC_80cb2a4451da1d8d8f25a688259024cd ToStructure(ssOutSystemsMaps.RestRecords.RESTRC_80cb2a4451da1d8d8f25a688259024cd obj) { 
  RC_80cb2a4451da1d8d8f25a688259024cd s = new RC_80cb2a4451da1d8d8f25a688259024cd();
  if(obj != null) {
  s.ssSTStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke);
  }
  return s;
}

public static Func<RC_80cb2a4451da1d8d8f25a688259024cd, ssOutSystemsMaps.RestRecords.RESTRC_80cb2a4451da1d8d8f25a688259024cd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80cb2a4451da1d8d8f25a688259024cd s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTRC_80cb2a4451da1d8d8f25a688259024cd FromStructure(RC_80cb2a4451da1d8d8f25a688259024cd s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTRC_80cb2a4451da1d8d8f25a688259024cd(s, config);
}

}


