using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// InlineSVG_InternalConfig
public class JSONST_bc9955d62033e77475d9540bd4940593Structure : AbstractRESTStructure<ST_bc9955d62033e77475d9540bd4940593Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("SVGCode")]
[JsonPropertyName("SVGCode")]
public string AttrSVGCode;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_bc9955d62033e77475d9540bd4940593Structure() { }

public JSONST_bc9955d62033e77475d9540bd4940593Structure (ST_bc9955d62033e77475d9540bd4940593Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrSVGCode = ConvertToRestWithoutDefaults(s.ssSVGCode, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrSVGCode = s.ssSVGCode;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure, ST_bc9955d62033e77475d9540bd4940593Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure s) => ToStructure(s, config);
}
public static ST_bc9955d62033e77475d9540bd4940593Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure obj, IBehaviorsConfiguration config) { 
  ST_bc9955d62033e77475d9540bd4940593Structure s = new ST_bc9955d62033e77475d9540bd4940593Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssSVGCode = obj.AttrSVGCode == null ? "" : obj.AttrSVGCode;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_bc9955d62033e77475d9540bd4940593Structure, ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bc9955d62033e77475d9540bd4940593Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure FromStructure(ST_bc9955d62033e77475d9540bd4940593Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_bc9955d62033e77475d9540bd4940593Structure(s, config);
}

}


