using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTagsOptionalConfigs
public class JSONST_34444d0742578c128ebc8b2594439346Structure : AbstractRESTStructure<ST_34444d0742578c128ebc8b2594439346Structure> {
[JsonProperty("IsDisabled")]
[JsonPropertyName("IsDisabled")]
public bool? AttrIsDisabled;

[JsonProperty("NoResultsText")]
[JsonPropertyName("NoResultsText")]
public string AttrNoResultsText;

[JsonProperty("SearchPrompt")]
[JsonPropertyName("SearchPrompt")]
public string AttrSearchPrompt;

[JsonProperty("NoOptionsText")]
[JsonPropertyName("NoOptionsText")]
public string AttrNoOptionsText;

[JsonProperty("SanitizeDropdownValues")]
[JsonPropertyName("SanitizeDropdownValues")]
public bool? AttrSanitizeDropdownValues;

public JSONST_34444d0742578c128ebc8b2594439346Structure() { }

public JSONST_34444d0742578c128ebc8b2594439346Structure (ST_34444d0742578c128ebc8b2594439346Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrNoResultsText = ConvertToRestWithoutDefaults(s.ssNoResultsText, "There are no options to show.");
AttrSearchPrompt = ConvertToRestWithoutDefaults(s.ssSearchPrompt, "Search...");
AttrNoOptionsText = ConvertToRestWithoutDefaults(s.ssNoOptionsText, "There are no options to show.");
AttrSanitizeDropdownValues = ConvertToRestWithoutDefaults(s.ssSanitizeDropdownValues, false);
  } else {
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrNoResultsText = s.ssNoResultsText;
AttrSearchPrompt = s.ssSearchPrompt;
AttrNoOptionsText = s.ssNoOptionsText;
AttrSanitizeDropdownValues = (bool?) s.ssSanitizeDropdownValues;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure, ST_34444d0742578c128ebc8b2594439346Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure s) => ToStructure(s, config);
}
public static ST_34444d0742578c128ebc8b2594439346Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure obj, IBehaviorsConfiguration config) { 
  ST_34444d0742578c128ebc8b2594439346Structure s = new ST_34444d0742578c128ebc8b2594439346Structure();
  if(obj != null) {
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssNoResultsText = obj.AttrNoResultsText == null ? "There are no options to show." : obj.AttrNoResultsText;
  s.ssSearchPrompt = obj.AttrSearchPrompt == null ? "Search..." : obj.AttrSearchPrompt;
  s.ssNoOptionsText = obj.AttrNoOptionsText == null ? "There are no options to show." : obj.AttrNoOptionsText;
  s.ssSanitizeDropdownValues = obj.AttrSanitizeDropdownValues == null ? false : obj.AttrSanitizeDropdownValues.Value;
  }
  return s;
}

public static Func<ST_34444d0742578c128ebc8b2594439346Structure, ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34444d0742578c128ebc8b2594439346Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure FromStructure(ST_34444d0742578c128ebc8b2594439346Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_34444d0742578c128ebc8b2594439346Structure(s, config);
}

}


