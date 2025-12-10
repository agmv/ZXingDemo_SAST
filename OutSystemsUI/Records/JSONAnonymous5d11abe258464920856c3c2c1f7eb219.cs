using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DEPRECATED_ColorRecord
public class JSONRC_c47826b7e4232fbf890784243715f5a8 : AbstractRESTStructure<RC_c47826b7e4232fbf890784243715f5a8> {
[JsonProperty("DEPRECATED_Color")]
[JsonPropertyName("DEPRECATED_Color")]
public ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord AttrDEPRECATED_Color;

public JSONRC_c47826b7e4232fbf890784243715f5a8() { }

public JSONRC_c47826b7e4232fbf890784243715f5a8 (RC_c47826b7e4232fbf890784243715f5a8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDEPRECATED_Color = ConvertToRestWithoutDefaults(s.ssENDEPRECATED_Color, new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord.FromStructureDelegate(config));
  } else {
AttrDEPRECATED_Color = ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord.FromStructure(s.ssENDEPRECATED_Color, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8, RC_c47826b7e4232fbf890784243715f5a8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8 s) => ToStructure(s, config);
}
public static RC_c47826b7e4232fbf890784243715f5a8 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8 obj, IBehaviorsConfiguration config) { 
  RC_c47826b7e4232fbf890784243715f5a8 s = new RC_c47826b7e4232fbf890784243715f5a8();
  if(obj != null) {
  s.ssENDEPRECATED_Color = ssOutSystemsUI.RestRecords.JSONEN_d383eada98ae47b51248dfe934bb4fabEntityRecord.ToStructure(obj.AttrDEPRECATED_Color, config);
  }
  return s;
}

public static Func<RC_c47826b7e4232fbf890784243715f5a8, ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c47826b7e4232fbf890784243715f5a8 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8 FromStructure(RC_c47826b7e4232fbf890784243715f5a8 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_c47826b7e4232fbf890784243715f5a8(s, config);
}

}


