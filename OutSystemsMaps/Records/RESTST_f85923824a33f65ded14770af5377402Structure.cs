using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolylineConfigs
public class RESTST_f85923824a33f65ded14770af5377402Structure : AbstractRESTStructure<ST_f85923824a33f65ded14770af5377402Structure> {
[JsonProperty("AllowDrag")]
public bool? AttrAllowDrag;

[JsonProperty("AllowEdit")]
public bool? AttrAllowEdit;

[JsonProperty("Stroke")]
public ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

public RESTST_f85923824a33f65ded14770af5377402Structure() { }

public RESTST_f85923824a33f65ded14770af5377402Structure (ST_f85923824a33f65ded14770af5377402Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
AttrAllowEdit = ConvertToRestWithoutDefaults(s.ssAllowEdit, false);
AttrStroke = ConvertToRestWithoutDefaults(s.ssStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
  } else {
AttrAllowDrag = (bool?) s.ssAllowDrag;
AttrAllowEdit = (bool?) s.ssAllowEdit;
AttrStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssStroke, config);
  }
}

public static ST_f85923824a33f65ded14770af5377402Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure obj) { 
  ST_f85923824a33f65ded14770af5377402Structure s = new ST_f85923824a33f65ded14770af5377402Structure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke);
  }
  return s;
}

public static Func<ST_f85923824a33f65ded14770af5377402Structure, ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f85923824a33f65ded14770af5377402Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure FromStructure(ST_f85923824a33f65ded14770af5377402Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_f85923824a33f65ded14770af5377402Structure(s, config);
}

}


