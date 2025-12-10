using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTags_InternalConfigs
public class JSONST_f2d4817754eec123207470e41d7a01d7Structure : AbstractRESTStructure<ST_f2d4817754eec123207470e41d7a01d7Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("OptionsList")]
[JsonPropertyName("OptionsList")]
public ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure[] AttrOptionsList;

[JsonProperty("StartingSelection")]
[JsonPropertyName("StartingSelection")]
public ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure[] AttrStartingSelection;

[JsonProperty("Prompt")]
[JsonPropertyName("Prompt")]
public string AttrPrompt;

[JsonProperty("IsDisabled")]
[JsonPropertyName("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("NoOptionsText")]
[JsonPropertyName("NoOptionsText")]
public string AttrNoOptionsText;

[JsonProperty("NoResultsText")]
[JsonPropertyName("NoResultsText")]
public string AttrNoResultsText;

[JsonProperty("SearchPrompt")]
[JsonPropertyName("SearchPrompt")]
public string AttrSearchPrompt;

[JsonProperty("SanitizeDropdownValues")]
[JsonPropertyName("SanitizeDropdownValues")]
public bool? AttrSanitizeDropdownValues;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_f2d4817754eec123207470e41d7a01d7Structure() { }

public JSONST_f2d4817754eec123207470e41d7a01d7Structure (ST_f2d4817754eec123207470e41d7a01d7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrOptionsList = s.ssOptionsList.ToArray<ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrStartingSelection = s.ssStartingSelection.Length == 0 ? null : s.ssStartingSelection.ToArray<ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrPrompt = ConvertToRestWithoutDefaults(s.ssPrompt, "Select an item");
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrNoOptionsText = ConvertToRestWithoutDefaults(s.ssNoOptionsText, Convert.ToString(0));
AttrNoResultsText = ConvertToRestWithoutDefaults(s.ssNoResultsText, Convert.ToString(0));
AttrSearchPrompt = ConvertToRestWithoutDefaults(s.ssSearchPrompt, "");
AttrSanitizeDropdownValues = ConvertToRestWithoutDefaults(s.ssSanitizeDropdownValues, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, Convert.ToString(1));
  } else {
AttrUniqueId = s.ssUniqueId;
AttrOptionsList = s.ssOptionsList.ToArray<ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrStartingSelection = s.ssStartingSelection.ToArray<ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrPrompt = s.ssPrompt;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrNoOptionsText = s.ssNoOptionsText;
AttrNoResultsText = s.ssNoResultsText;
AttrSearchPrompt = s.ssSearchPrompt;
AttrSanitizeDropdownValues = (bool?) s.ssSanitizeDropdownValues;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure, ST_f2d4817754eec123207470e41d7a01d7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure s) => ToStructure(s, config);
}
public static ST_f2d4817754eec123207470e41d7a01d7Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure obj, IBehaviorsConfiguration config) { 
  ST_f2d4817754eec123207470e41d7a01d7Structure s = new ST_f2d4817754eec123207470e41d7a01d7Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssOptionsList = RL_c0f17d75c546075264f5d075e00ba65b.ToList(obj.AttrOptionsList, ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.ToStructureDelegate(config));
  s.ssStartingSelection = RL_c0f17d75c546075264f5d075e00ba65b.ToList(obj.AttrStartingSelection, ssOutSystemsUI.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.ToStructureDelegate(config));
  s.ssPrompt = obj.AttrPrompt == null ? "Select an item" : obj.AttrPrompt;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssNoOptionsText = obj.AttrNoOptionsText == null ? Convert.ToString(0) : obj.AttrNoOptionsText;
  s.ssNoResultsText = obj.AttrNoResultsText == null ? Convert.ToString(0) : obj.AttrNoResultsText;
  s.ssSearchPrompt = obj.AttrSearchPrompt == null ? "" : obj.AttrSearchPrompt;
  s.ssSanitizeDropdownValues = obj.AttrSanitizeDropdownValues == null ? false : obj.AttrSanitizeDropdownValues.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? Convert.ToString(1) : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_f2d4817754eec123207470e41d7a01d7Structure, ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f2d4817754eec123207470e41d7a01d7Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure FromStructure(ST_f2d4817754eec123207470e41d7a01d7Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_f2d4817754eec123207470e41d7a01d7Structure(s, config);
}

}


