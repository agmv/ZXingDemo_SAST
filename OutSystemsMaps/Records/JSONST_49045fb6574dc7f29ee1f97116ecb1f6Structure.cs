using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalPolygonConfigs
public class JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure : AbstractRESTStructure<ST_49045fb6574dc7f29ee1f97116ecb1f6Structure> {
[JsonProperty("AllowDrag")]
[JsonPropertyName("AllowDrag")]
public bool? AttrAllowDrag;

[JsonProperty("AllowEdit")]
[JsonPropertyName("AllowEdit")]
public bool? AttrAllowEdit;

[JsonProperty("Stroke")]
[JsonPropertyName("Stroke")]
public ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

[JsonProperty("Fill")]
[JsonPropertyName("Fill")]
public ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure AttrFill;

public JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure() { }

public JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure (ST_49045fb6574dc7f29ee1f97116ecb1f6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
AttrAllowEdit = ConvertToRestWithoutDefaults(s.ssAllowEdit, false);
AttrStroke = ConvertToRestWithoutDefaults(s.ssStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
AttrFill = ConvertToRestWithoutDefaults(s.ssFill, new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(), ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructureDelegate(config));
  } else {
AttrAllowDrag = (bool?) s.ssAllowDrag;
AttrAllowEdit = (bool?) s.ssAllowEdit;
AttrStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssStroke, config);
AttrFill = ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructure(s.ssFill, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure, ST_49045fb6574dc7f29ee1f97116ecb1f6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure s) => ToStructure(s, config);
}
public static ST_49045fb6574dc7f29ee1f97116ecb1f6Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure obj, IBehaviorsConfiguration config) { 
  ST_49045fb6574dc7f29ee1f97116ecb1f6Structure s = new ST_49045fb6574dc7f29ee1f97116ecb1f6Structure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke, config);
  s.ssFill = ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill, config);
  }
  return s;
}

public static Func<ST_49045fb6574dc7f29ee1f97116ecb1f6Structure, ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_49045fb6574dc7f29ee1f97116ecb1f6Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure FromStructure(ST_49045fb6574dc7f29ee1f97116ecb1f6Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_49045fb6574dc7f29ee1f97116ecb1f6Structure(s, config);
}

}


