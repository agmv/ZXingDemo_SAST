using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ShortcutsDialog1ShortcutsDialog2ShortcutsDialog3ShortcutsDialog4ShortcutsDialog5ShortcutsDialog6ShortcutsDialog7ShortcutsDialog8Record
public class JSONRC_4c3ee0d0ad514546e23495b0186f9086 : AbstractRESTStructure<RC_4c3ee0d0ad514546e23495b0186f9086> {
[JsonProperty("ShortcutsDialog1")]
[JsonPropertyName("ShortcutsDialog1")]
public string AttrShortcutsDialog1;

[JsonProperty("ShortcutsDialog2")]
[JsonPropertyName("ShortcutsDialog2")]
public string AttrShortcutsDialog2;

[JsonProperty("ShortcutsDialog3")]
[JsonPropertyName("ShortcutsDialog3")]
public string AttrShortcutsDialog3;

[JsonProperty("ShortcutsDialog4")]
[JsonPropertyName("ShortcutsDialog4")]
public string AttrShortcutsDialog4;

[JsonProperty("ShortcutsDialog5")]
[JsonPropertyName("ShortcutsDialog5")]
public string AttrShortcutsDialog5;

[JsonProperty("ShortcutsDialog6")]
[JsonPropertyName("ShortcutsDialog6")]
public string AttrShortcutsDialog6;

[JsonProperty("ShortcutsDialog7")]
[JsonPropertyName("ShortcutsDialog7")]
public string AttrShortcutsDialog7;

[JsonProperty("ShortcutsDialog8")]
[JsonPropertyName("ShortcutsDialog8")]
public string AttrShortcutsDialog8;

public JSONRC_4c3ee0d0ad514546e23495b0186f9086() { }

public JSONRC_4c3ee0d0ad514546e23495b0186f9086 (RC_4c3ee0d0ad514546e23495b0186f9086 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShortcutsDialog1 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog1, "");
AttrShortcutsDialog2 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog2, "");
AttrShortcutsDialog3 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog3, "");
AttrShortcutsDialog4 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog4, "");
AttrShortcutsDialog5 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog5, "");
AttrShortcutsDialog6 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog6, "");
AttrShortcutsDialog7 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog7, "");
AttrShortcutsDialog8 = ConvertToRestWithoutDefaults(s.ssShortcutsDialog8, "");
  } else {
AttrShortcutsDialog1 = s.ssShortcutsDialog1;
AttrShortcutsDialog2 = s.ssShortcutsDialog2;
AttrShortcutsDialog3 = s.ssShortcutsDialog3;
AttrShortcutsDialog4 = s.ssShortcutsDialog4;
AttrShortcutsDialog5 = s.ssShortcutsDialog5;
AttrShortcutsDialog6 = s.ssShortcutsDialog6;
AttrShortcutsDialog7 = s.ssShortcutsDialog7;
AttrShortcutsDialog8 = s.ssShortcutsDialog8;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086, RC_4c3ee0d0ad514546e23495b0186f9086> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086 s) => ToStructure(s, config);
}
public static RC_4c3ee0d0ad514546e23495b0186f9086 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086 obj, IBehaviorsConfiguration config) { 
  RC_4c3ee0d0ad514546e23495b0186f9086 s = new RC_4c3ee0d0ad514546e23495b0186f9086();
  if(obj != null) {
  s.ssShortcutsDialog1 = obj.AttrShortcutsDialog1 == null ? "" : obj.AttrShortcutsDialog1;
  s.ssShortcutsDialog2 = obj.AttrShortcutsDialog2 == null ? "" : obj.AttrShortcutsDialog2;
  s.ssShortcutsDialog3 = obj.AttrShortcutsDialog3 == null ? "" : obj.AttrShortcutsDialog3;
  s.ssShortcutsDialog4 = obj.AttrShortcutsDialog4 == null ? "" : obj.AttrShortcutsDialog4;
  s.ssShortcutsDialog5 = obj.AttrShortcutsDialog5 == null ? "" : obj.AttrShortcutsDialog5;
  s.ssShortcutsDialog6 = obj.AttrShortcutsDialog6 == null ? "" : obj.AttrShortcutsDialog6;
  s.ssShortcutsDialog7 = obj.AttrShortcutsDialog7 == null ? "" : obj.AttrShortcutsDialog7;
  s.ssShortcutsDialog8 = obj.AttrShortcutsDialog8 == null ? "" : obj.AttrShortcutsDialog8;
  }
  return s;
}

public static Func<RC_4c3ee0d0ad514546e23495b0186f9086, ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4c3ee0d0ad514546e23495b0186f9086 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086 FromStructure(RC_4c3ee0d0ad514546e23495b0186f9086 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_4c3ee0d0ad514546e23495b0186f9086(s, config);
}

}


