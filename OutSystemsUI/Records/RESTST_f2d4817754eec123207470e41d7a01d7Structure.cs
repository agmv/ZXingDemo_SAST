using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTags_InternalConfigs
public class RESTST_f2d4817754eec123207470e41d7a01d7Structure : AbstractRESTStructure<ST_f2d4817754eec123207470e41d7a01d7Structure> {
[JsonProperty("UniqueId")]
public string AttrUniqueId;

[JsonProperty("OptionsList")]
public RestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure> AttrOptionsList;

[JsonProperty("StartingSelection")]
public RestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure> AttrStartingSelection;

[JsonProperty("Prompt")]
public string AttrPrompt;

[JsonProperty("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("NoOptionsText")]
public string AttrNoOptionsText;

[JsonProperty("NoResultsText")]
public string AttrNoResultsText;

[JsonProperty("SearchPrompt")]
public string AttrSearchPrompt;

[JsonProperty("SanitizeDropdownValues")]
public bool? AttrSanitizeDropdownValues;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

public RESTST_f2d4817754eec123207470e41d7a01d7Structure() { }

public RESTST_f2d4817754eec123207470e41d7a01d7Structure (ST_f2d4817754eec123207470e41d7a01d7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrOptionsList = s.ssOptionsList.ToRestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrStartingSelection = s.ssStartingSelection.Length == 0 ? null : s.ssStartingSelection.ToRestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrPrompt = ConvertToRestWithoutDefaults(s.ssPrompt, "Select an item");
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrNoOptionsText = ConvertToRestWithoutDefaults(s.ssNoOptionsText, Convert.ToString(0));
AttrNoResultsText = ConvertToRestWithoutDefaults(s.ssNoResultsText, Convert.ToString(0));
AttrSearchPrompt = ConvertToRestWithoutDefaults(s.ssSearchPrompt, "");
AttrSanitizeDropdownValues = ConvertToRestWithoutDefaults(s.ssSanitizeDropdownValues, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, Convert.ToString(1));
  } else {
AttrUniqueId = s.ssUniqueId;
AttrOptionsList = s.ssOptionsList.ToRestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrStartingSelection = s.ssStartingSelection.ToRestList<ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure>(ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructureDelegate(config));
AttrPrompt = s.ssPrompt;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrNoOptionsText = s.ssNoOptionsText;
AttrNoResultsText = s.ssNoResultsText;
AttrSearchPrompt = s.ssSearchPrompt;
AttrSanitizeDropdownValues = (bool?) s.ssSanitizeDropdownValues;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static ST_f2d4817754eec123207470e41d7a01d7Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure obj) { 
  ST_f2d4817754eec123207470e41d7a01d7Structure s = new ST_f2d4817754eec123207470e41d7a01d7Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssOptionsList = RL_c0f17d75c546075264f5d075e00ba65b.FromRestList(obj.AttrOptionsList, ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.ToStructure);
  s.ssStartingSelection = RL_c0f17d75c546075264f5d075e00ba65b.FromRestList(obj.AttrStartingSelection, ssOutSystemsUI.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure.ToStructure);
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

public static Func<ST_f2d4817754eec123207470e41d7a01d7Structure, ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f2d4817754eec123207470e41d7a01d7Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure FromStructure(ST_f2d4817754eec123207470e41d7a01d7Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_f2d4817754eec123207470e41d7a01d7Structure(s, config);
}

}


