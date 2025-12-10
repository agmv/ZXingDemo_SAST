using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolylineConfigs
public class JSONST_f85923824a33f65ded14770af5377402Structure : AbstractRESTStructure<ST_f85923824a33f65ded14770af5377402Structure> {
[JsonProperty("AllowDrag")]
[JsonPropertyName("AllowDrag")]
public bool? AttrAllowDrag;

[JsonProperty("AllowEdit")]
[JsonPropertyName("AllowEdit")]
public bool? AttrAllowEdit;

[JsonProperty("Stroke")]
[JsonPropertyName("Stroke")]
public ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

public JSONST_f85923824a33f65ded14770af5377402Structure() { }

public JSONST_f85923824a33f65ded14770af5377402Structure (ST_f85923824a33f65ded14770af5377402Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
AttrAllowEdit = ConvertToRestWithoutDefaults(s.ssAllowEdit, false);
AttrStroke = ConvertToRestWithoutDefaults(s.ssStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
  } else {
AttrAllowDrag = (bool?) s.ssAllowDrag;
AttrAllowEdit = (bool?) s.ssAllowEdit;
AttrStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssStroke, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure, ST_f85923824a33f65ded14770af5377402Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure s) => ToStructure(s, config);
}
public static ST_f85923824a33f65ded14770af5377402Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure obj, IBehaviorsConfiguration config) { 
  ST_f85923824a33f65ded14770af5377402Structure s = new ST_f85923824a33f65ded14770af5377402Structure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke, config);
  }
  return s;
}

public static Func<ST_f85923824a33f65ded14770af5377402Structure, ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f85923824a33f65ded14770af5377402Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure FromStructure(ST_f85923824a33f65ded14770af5377402Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_f85923824a33f65ded14770af5377402Structure(s, config);
}

}


