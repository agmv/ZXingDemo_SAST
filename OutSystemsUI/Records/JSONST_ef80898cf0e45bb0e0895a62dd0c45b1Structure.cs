using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AccordionItem_InternalConfigs
public class JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure : AbstractRESTStructure<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("StartsExpanded")]
[JsonPropertyName("StartsExpanded")]
public bool? AttrStartsExpanded;

[JsonProperty("Icon")]
[JsonPropertyName("Icon")]
public string AttrIcon;

[JsonProperty("IconPosition")]
[JsonPropertyName("IconPosition")]
public string AttrIconPosition;

[JsonProperty("IsDisabled")]
[JsonPropertyName("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure() { }

public JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrStartsExpanded = ConvertToRestWithoutDefaults(s.ssStartsExpanded, false);
AttrIcon = ConvertToRestWithoutDefaults(s.ssIcon, "");
AttrIconPosition = ConvertToRestWithoutDefaults(s.ssIconPosition, "");
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrStartsExpanded = (bool?) s.ssStartsExpanded;
AttrIcon = s.ssIcon;
AttrIconPosition = s.ssIconPosition;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure, ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure s) => ToStructure(s, config);
}
public static ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure obj, IBehaviorsConfiguration config) { 
  ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure s = new ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssStartsExpanded = obj.AttrStartsExpanded == null ? false : obj.AttrStartsExpanded.Value;
  s.ssIcon = obj.AttrIcon == null ? "" : obj.AttrIcon;
  s.ssIconPosition = obj.AttrIconPosition == null ? "" : obj.AttrIconPosition;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure, ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure FromStructure(ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_ef80898cf0e45bb0e0895a62dd0c45b1Structure(s, config);
}

}


