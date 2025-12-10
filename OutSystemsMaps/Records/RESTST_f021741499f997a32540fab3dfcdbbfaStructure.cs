using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalShapeConfigs
public class RESTST_f021741499f997a32540fab3dfcdbbfaStructure : AbstractRESTStructure<ST_f021741499f997a32540fab3dfcdbbfaStructure> {
[JsonProperty("AllowDrag")]
public bool? AttrAllowDrag;

[JsonProperty("AllowEdit")]
public bool? AttrAllowEdit;

[JsonProperty("Stroke")]
public ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure AttrStroke;

[JsonProperty("Fill")]
public ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure AttrFill;

public RESTST_f021741499f997a32540fab3dfcdbbfaStructure() { }

public RESTST_f021741499f997a32540fab3dfcdbbfaStructure (ST_f021741499f997a32540fab3dfcdbbfaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowDrag = ConvertToRestWithoutDefaults(s.ssAllowDrag, false);
AttrAllowEdit = ConvertToRestWithoutDefaults(s.ssAllowEdit, false);
AttrStroke = ConvertToRestWithoutDefaults(s.ssStroke, new ST_c2a46cf64d2acc4b38d805712495224cStructure(), ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructureDelegate(config));
AttrFill = ConvertToRestWithoutDefaults(s.ssFill, new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(), ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructureDelegate(config));
  } else {
AttrAllowDrag = (bool?) s.ssAllowDrag;
AttrAllowEdit = (bool?) s.ssAllowEdit;
AttrStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.FromStructure(s.ssStroke, config);
AttrFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.FromStructure(s.ssFill, config);
  }
}

public static ST_f021741499f997a32540fab3dfcdbbfaStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure obj) { 
  ST_f021741499f997a32540fab3dfcdbbfaStructure s = new ST_f021741499f997a32540fab3dfcdbbfaStructure();
  if(obj != null) {
  s.ssAllowDrag = obj.AttrAllowDrag == null ? false : obj.AttrAllowDrag.Value;
  s.ssAllowEdit = obj.AttrAllowEdit == null ? false : obj.AttrAllowEdit.Value;
  s.ssStroke = ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure.ToStructure(obj.AttrStroke);
  s.ssFill = ssOutSystemsMaps.RestRecords.RESTST_7f8762cb0c77867d9f9e3b82fd927c7bStructure.ToStructure(obj.AttrFill);
  }
  return s;
}

public static Func<ST_f021741499f997a32540fab3dfcdbbfaStructure, ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f021741499f997a32540fab3dfcdbbfaStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure FromStructure(ST_f021741499f997a32540fab3dfcdbbfaStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_f021741499f997a32540fab3dfcdbbfaStructure(s, config);
}

}


