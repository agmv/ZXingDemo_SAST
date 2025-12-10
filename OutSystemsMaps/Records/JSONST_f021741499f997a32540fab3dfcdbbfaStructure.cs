using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalShapeConfigs
public class JSONST_f021741499f997a32540fab3dfcdbbfaStructure : AbstractRESTStructure<ST_f021741499f997a32540fab3dfcdbbfaStructure> {
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

public JSONST_f021741499f997a32540fab3dfcdbbfaStructure() { }

public JSONST_f021741499f997a32540fab3dfcdbbfaStructure (ST_f021741499f997a32540fab3dfcdbbfaStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure, ST_f021741499f997a32540fab3dfcdbbfaStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure s) => ToStructure(s, config);
}
public static ST_f021741499f997a32540fab3dfcdbbfaStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure obj, IBehaviorsConfiguration config) { 
  ST_f021741499f997a32540fab3dfcdbbfaStructure s = new ST_f021741499f997a32540fab3dfcdbbfaStructure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.JSONST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke, config);
  s.ssFill = ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill, config);
  }
  return s;
}

public static Func<ST_f021741499f997a32540fab3dfcdbbfaStructure, ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f021741499f997a32540fab3dfcdbbfaStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure FromStructure(ST_f021741499f997a32540fab3dfcdbbfaStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_f021741499f997a32540fab3dfcdbbfaStructure(s, config);
}

}


