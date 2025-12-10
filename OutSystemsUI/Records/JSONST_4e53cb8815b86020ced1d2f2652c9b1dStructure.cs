using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownOptionalConfigs
public class JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure : AbstractRESTStructure<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> {
[JsonProperty("AllowMultipleSelection")]
[JsonPropertyName("AllowMultipleSelection")]
public bool? AttrAllowMultipleSelection;

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

public JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure() { }

public JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAllowMultipleSelection = ConvertToRestWithoutDefaults(s.ssAllowMultipleSelection, false);
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, false);
AttrNoResultsText = ConvertToRestWithoutDefaults(s.ssNoResultsText, "There are no options to show.");
AttrSearchPrompt = ConvertToRestWithoutDefaults(s.ssSearchPrompt, "Search...");
AttrNoOptionsText = ConvertToRestWithoutDefaults(s.ssNoOptionsText, "There are no options to show.");
AttrSanitizeDropdownValues = ConvertToRestWithoutDefaults(s.ssSanitizeDropdownValues, false);
  } else {
AttrAllowMultipleSelection = (bool?) s.ssAllowMultipleSelection;
AttrIsDisabled = (bool?) s.ssIsDisabled;
AttrNoResultsText = s.ssNoResultsText;
AttrSearchPrompt = s.ssSearchPrompt;
AttrNoOptionsText = s.ssNoOptionsText;
AttrSanitizeDropdownValues = (bool?) s.ssSanitizeDropdownValues;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure s) => ToStructure(s, config);
}
public static ST_4e53cb8815b86020ced1d2f2652c9b1dStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure obj, IBehaviorsConfiguration config) { 
  ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
  if(obj != null) {
  s.ssAllowMultipleSelection = obj.AttrAllowMultipleSelection == null ? false : obj.AttrAllowMultipleSelection.Value;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? false : obj.AttrIsDisabled.Value;
  s.ssNoResultsText = obj.AttrNoResultsText == null ? "There are no options to show." : obj.AttrNoResultsText;
  s.ssSearchPrompt = obj.AttrSearchPrompt == null ? "Search..." : obj.AttrSearchPrompt;
  s.ssNoOptionsText = obj.AttrNoOptionsText == null ? "There are no options to show." : obj.AttrNoOptionsText;
  s.ssSanitizeDropdownValues = obj.AttrSanitizeDropdownValues == null ? false : obj.AttrSanitizeDropdownValues.Value;
  }
  return s;
}

public static Func<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure FromStructure(ST_4e53cb8815b86020ced1d2f2652c9b1dStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_4e53cb8815b86020ced1d2f2652c9b1dStructure(s, config);
}

}


