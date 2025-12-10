using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// VirtualSelectConfigs
public class RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure : AbstractRESTStructure<ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure> {
[JsonProperty("additionalClasses")]
public string AttradditionalClasses;

[JsonProperty("aliasKey")]
public string AttraliasKey;

[JsonProperty("allOptionsSelectedText")]
public string AttrallOptionsSelectedText;

[JsonProperty("allowNewOption")]
public string AttrallowNewOption;

[JsonProperty("alwaysShowSelectedOptionsCount")]
public string AttralwaysShowSelectedOptionsCount;

[JsonProperty("alwaysShowSelectedOptionsLabel")]
public string AttralwaysShowSelectedOptionsLabel;

[JsonProperty("ariaLabelClearButtonText")]
public string AttrariaLabelClearButtonText;

[JsonProperty("ariaLabelledby")]
public string AttrariaLabelledby;

[JsonProperty("ariaLabelSearchClearButtonText")]
public string AttrariaLabelSearchClearButtonText;

[JsonProperty("ariaLabelTagClearButtonText")]
public string AttrariaLabelTagClearButtonText;

[JsonProperty("ariaLabelText")]
public string AttrariaLabelText;

[JsonProperty("autofocus")]
public string Attrautofocus;

[JsonProperty("autoSelectFirstOption")]
public string AttrautoSelectFirstOption;

[JsonProperty("descriptionKey")]
public string AttrdescriptionKey;

[JsonProperty("disableSelectAll")]
public string AttrdisableSelectAll;

[JsonProperty("disableAllOptionsSelectedText")]
public string AttrdisableAllOptionsSelectedText;

[JsonProperty("disabledOptions")]
public RestList<string> AttrdisabledOptions;

[JsonProperty("disableOptionGroupCheckbox")]
public string AttrdisableOptionGroupCheckbox;

[JsonProperty("disableValidation")]
public string AttrdisableValidation;

[JsonProperty("dropboxWidth")]
public string AttrdropboxWidth;

[JsonProperty("emptyValue")]
public string AttremptyValue;

[JsonProperty("enableSecureText")]
public string AttrenableSecureText;

[JsonProperty("focusSelectedOptionOnOpen")]
public string AttrfocusSelectedOptionOnOpen;

[JsonProperty("hideClearButton")]
public string AttrhideClearButton;

[JsonProperty("markSearchResults")]
public string AttrmarkSearchResults;

[JsonProperty("keepAlwaysOpen")]
public string AttrkeepAlwaysOpen;

[JsonProperty("labelKey")]
public string AttrlabelKey;

[JsonProperty("maxValues")]
public int? AttrmaxValues;

[JsonProperty("maxWidth")]
public string AttrmaxWidth;

[JsonProperty("minValues")]
public int? AttrminValues;

[JsonProperty("moreText")]
public string AttrmoreText;

[JsonProperty("noOfDisplayValues")]
public int? AttrnoOfDisplayValues;

[JsonProperty("optionsCount")]
public int? AttroptionsCount;

[JsonProperty("optionHeight")]
public string AttroptionHeight;

[JsonProperty("optionSelectedText")]
public string AttroptionSelectedText;

[JsonProperty("optionsSelectedText")]
public string AttroptionsSelectedText;

[JsonProperty("popupDropboxBreakpoint")]
public string AttrpopupDropboxBreakpoint;

[JsonProperty("popupPosition")]
public string AttrpopupPosition;

[JsonProperty("position")]
public string Attrposition;

[JsonProperty("required")]
public string Attrrequired;

[JsonProperty("search")]
public string Attrsearch;

[JsonProperty("searchByStartsWith")]
public string AttrsearchByStartsWith;

[JsonProperty("searchFormLabel")]
public string AttrsearchFormLabel;

[JsonProperty("searchGroup")]
public string AttrsearchGroup;

[JsonProperty("searchNormalize")]
public string AttrsearchNormalize;

[JsonProperty("selectAllOnlyVisible")]
public string AttrselectAllOnlyVisible;

[JsonProperty("selectAllText")]
public string AttrselectAllText;

[JsonProperty("showDropboxAsPopup")]
public string AttrshowDropboxAsPopup;

[JsonProperty("showOptionsOnlyOnSearch")]
public string AttrshowOptionsOnlyOnSearch;

[JsonProperty("showDuration")]
public int? AttrshowDuration;

[JsonProperty("showSelectedOptionsFirst")]
public string AttrshowSelectedOptionsFirst;

[JsonProperty("textDirection")]
public string AttrtextDirection;

[JsonProperty("valueKey")]
public string AttrvalueKey;

[JsonProperty("zIndex")]
public int? AttrzIndex;

[JsonProperty("hideDuration")]
public int? AttrhideDuration;

public RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure() { }

public RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure (ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttradditionalClasses = ConvertToRestWithoutDefaults(s.ssadditionalClasses, "");
AttraliasKey = ConvertToRestWithoutDefaults(s.ssaliasKey, "");
AttrallOptionsSelectedText = ConvertToRestWithoutDefaults(s.ssallOptionsSelectedText, "");
AttrallowNewOption = ConvertToRestWithoutDefaults(s.ssallowNewOption, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttralwaysShowSelectedOptionsCount = ConvertToRestWithoutDefaults(s.ssalwaysShowSelectedOptionsCount, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttralwaysShowSelectedOptionsLabel = ConvertToRestWithoutDefaults(s.ssalwaysShowSelectedOptionsLabel, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("kvBa3wQmCUSufbhtK875+w"))).ssLabel);
AttrariaLabelClearButtonText = ConvertToRestWithoutDefaults(s.ssariaLabelClearButtonText, "");
AttrariaLabelledby = ConvertToRestWithoutDefaults(s.ssariaLabelledby, "");
AttrariaLabelSearchClearButtonText = ConvertToRestWithoutDefaults(s.ssariaLabelSearchClearButtonText, "");
AttrariaLabelTagClearButtonText = ConvertToRestWithoutDefaults(s.ssariaLabelTagClearButtonText, "");
AttrariaLabelText = ConvertToRestWithoutDefaults(s.ssariaLabelText, "");
Attrautofocus = ConvertToRestWithoutDefaults(s.ssautofocus, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrautoSelectFirstOption = ConvertToRestWithoutDefaults(s.ssautoSelectFirstOption, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrdescriptionKey = ConvertToRestWithoutDefaults(s.ssdescriptionKey, "");
AttrdisableSelectAll = ConvertToRestWithoutDefaults(s.ssdisableSelectAll, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrdisableAllOptionsSelectedText = ConvertToRestWithoutDefaults(s.ssdisableAllOptionsSelectedText, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrdisabledOptions = s.ssdisabledOptions.Length == 0 ? null : s.ssdisabledOptions.ToRestList();
AttrdisableOptionGroupCheckbox = ConvertToRestWithoutDefaults(s.ssdisableOptionGroupCheckbox, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrdisableValidation = ConvertToRestWithoutDefaults(s.ssdisableValidation, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrdropboxWidth = ConvertToRestWithoutDefaults(s.ssdropboxWidth, "");
AttremptyValue = ConvertToRestWithoutDefaults(s.ssemptyValue, "");
AttrenableSecureText = ConvertToRestWithoutDefaults(s.ssenableSecureText, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrfocusSelectedOptionOnOpen = ConvertToRestWithoutDefaults(s.ssfocusSelectedOptionOnOpen, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrhideClearButton = ConvertToRestWithoutDefaults(s.sshideClearButton, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrmarkSearchResults = ConvertToRestWithoutDefaults(s.ssmarkSearchResults, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrkeepAlwaysOpen = ConvertToRestWithoutDefaults(s.sskeepAlwaysOpen, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrlabelKey = ConvertToRestWithoutDefaults(s.sslabelKey, "");
AttrmaxValues = ConvertToRestWithoutDefaults(s.ssmaxValues, 0);
AttrmaxWidth = ConvertToRestWithoutDefaults(s.ssmaxWidth, "");
AttrminValues = ConvertToRestWithoutDefaults(s.ssminValues, 0);
AttrmoreText = ConvertToRestWithoutDefaults(s.ssmoreText, "");
AttrnoOfDisplayValues = ConvertToRestWithoutDefaults(s.ssnoOfDisplayValues, 0);
AttroptionsCount = ConvertToRestWithoutDefaults(s.ssoptionsCount, 0);
AttroptionHeight = ConvertToRestWithoutDefaults(s.ssoptionHeight, "");
AttroptionSelectedText = ConvertToRestWithoutDefaults(s.ssoptionSelectedText, "");
AttroptionsSelectedText = ConvertToRestWithoutDefaults(s.ssoptionsSelectedText, "");
AttrpopupDropboxBreakpoint = ConvertToRestWithoutDefaults(s.sspopupDropboxBreakpoint, "");
AttrpopupPosition = ConvertToRestWithoutDefaults(s.sspopupPosition, "");
Attrposition = ConvertToRestWithoutDefaults(s.ssposition, "");
Attrrequired = ConvertToRestWithoutDefaults(s.ssrequired, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
Attrsearch = ConvertToRestWithoutDefaults(s.sssearch, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrsearchByStartsWith = ConvertToRestWithoutDefaults(s.sssearchByStartsWith, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrsearchFormLabel = ConvertToRestWithoutDefaults(s.sssearchFormLabel, "");
AttrsearchGroup = ConvertToRestWithoutDefaults(s.sssearchGroup, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrsearchNormalize = ConvertToRestWithoutDefaults(s.sssearchNormalize, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrselectAllOnlyVisible = ConvertToRestWithoutDefaults(s.ssselectAllOnlyVisible, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrselectAllText = ConvertToRestWithoutDefaults(s.ssselectAllText, "");
AttrshowDropboxAsPopup = ConvertToRestWithoutDefaults(s.ssshowDropboxAsPopup, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrshowOptionsOnlyOnSearch = ConvertToRestWithoutDefaults(s.ssshowOptionsOnlyOnSearch, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrshowDuration = ConvertToRestWithoutDefaults(s.ssshowDuration, 0);
AttrshowSelectedOptionsFirst = ConvertToRestWithoutDefaults(s.ssshowSelectedOptionsFirst, (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel);
AttrtextDirection = ConvertToRestWithoutDefaults(s.sstextDirection, "");
AttrvalueKey = ConvertToRestWithoutDefaults(s.ssvalueKey, "");
AttrzIndex = ConvertToRestWithoutDefaults(s.sszIndex, 0);
AttrhideDuration = ConvertToRestWithoutDefaults(s.sshideDuration, 0);
  } else {
AttradditionalClasses = s.ssadditionalClasses;
AttraliasKey = s.ssaliasKey;
AttrallOptionsSelectedText = s.ssallOptionsSelectedText;
AttrallowNewOption = s.ssallowNewOption;
AttralwaysShowSelectedOptionsCount = s.ssalwaysShowSelectedOptionsCount;
AttralwaysShowSelectedOptionsLabel = s.ssalwaysShowSelectedOptionsLabel;
AttrariaLabelClearButtonText = s.ssariaLabelClearButtonText;
AttrariaLabelledby = s.ssariaLabelledby;
AttrariaLabelSearchClearButtonText = s.ssariaLabelSearchClearButtonText;
AttrariaLabelTagClearButtonText = s.ssariaLabelTagClearButtonText;
AttrariaLabelText = s.ssariaLabelText;
Attrautofocus = s.ssautofocus;
AttrautoSelectFirstOption = s.ssautoSelectFirstOption;
AttrdescriptionKey = s.ssdescriptionKey;
AttrdisableSelectAll = s.ssdisableSelectAll;
AttrdisableAllOptionsSelectedText = s.ssdisableAllOptionsSelectedText;
AttrdisabledOptions = s.ssdisabledOptions.ToRestList();
AttrdisableOptionGroupCheckbox = s.ssdisableOptionGroupCheckbox;
AttrdisableValidation = s.ssdisableValidation;
AttrdropboxWidth = s.ssdropboxWidth;
AttremptyValue = s.ssemptyValue;
AttrenableSecureText = s.ssenableSecureText;
AttrfocusSelectedOptionOnOpen = s.ssfocusSelectedOptionOnOpen;
AttrhideClearButton = s.sshideClearButton;
AttrmarkSearchResults = s.ssmarkSearchResults;
AttrkeepAlwaysOpen = s.sskeepAlwaysOpen;
AttrlabelKey = s.sslabelKey;
AttrmaxValues = (int?) s.ssmaxValues;
AttrmaxWidth = s.ssmaxWidth;
AttrminValues = (int?) s.ssminValues;
AttrmoreText = s.ssmoreText;
AttrnoOfDisplayValues = (int?) s.ssnoOfDisplayValues;
AttroptionsCount = (int?) s.ssoptionsCount;
AttroptionHeight = s.ssoptionHeight;
AttroptionSelectedText = s.ssoptionSelectedText;
AttroptionsSelectedText = s.ssoptionsSelectedText;
AttrpopupDropboxBreakpoint = s.sspopupDropboxBreakpoint;
AttrpopupPosition = s.sspopupPosition;
Attrposition = s.ssposition;
Attrrequired = s.ssrequired;
Attrsearch = s.sssearch;
AttrsearchByStartsWith = s.sssearchByStartsWith;
AttrsearchFormLabel = s.sssearchFormLabel;
AttrsearchGroup = s.sssearchGroup;
AttrsearchNormalize = s.sssearchNormalize;
AttrselectAllOnlyVisible = s.ssselectAllOnlyVisible;
AttrselectAllText = s.ssselectAllText;
AttrshowDropboxAsPopup = s.ssshowDropboxAsPopup;
AttrshowOptionsOnlyOnSearch = s.ssshowOptionsOnlyOnSearch;
AttrshowDuration = (int?) s.ssshowDuration;
AttrshowSelectedOptionsFirst = s.ssshowSelectedOptionsFirst;
AttrtextDirection = s.sstextDirection;
AttrvalueKey = s.ssvalueKey;
AttrzIndex = (int?) s.sszIndex;
AttrhideDuration = (int?) s.sshideDuration;
  }
}

public static ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure ToStructure(ssOutSystemsUI.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure obj) { 
  ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure s = new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure();
  if(obj != null) {
  s.ssadditionalClasses = obj.AttradditionalClasses == null ? "" : obj.AttradditionalClasses;
  s.ssaliasKey = obj.AttraliasKey == null ? "" : obj.AttraliasKey;
  s.ssallOptionsSelectedText = obj.AttrallOptionsSelectedText == null ? "" : obj.AttrallOptionsSelectedText;
  s.ssallowNewOption = obj.AttrallowNewOption == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrallowNewOption;
  s.ssalwaysShowSelectedOptionsCount = obj.AttralwaysShowSelectedOptionsCount == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttralwaysShowSelectedOptionsCount;
  s.ssalwaysShowSelectedOptionsLabel = obj.AttralwaysShowSelectedOptionsLabel == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("kvBa3wQmCUSufbhtK875+w"))).ssLabel : obj.AttralwaysShowSelectedOptionsLabel;
  s.ssariaLabelClearButtonText = obj.AttrariaLabelClearButtonText == null ? "" : obj.AttrariaLabelClearButtonText;
  s.ssariaLabelledby = obj.AttrariaLabelledby == null ? "" : obj.AttrariaLabelledby;
  s.ssariaLabelSearchClearButtonText = obj.AttrariaLabelSearchClearButtonText == null ? "" : obj.AttrariaLabelSearchClearButtonText;
  s.ssariaLabelTagClearButtonText = obj.AttrariaLabelTagClearButtonText == null ? "" : obj.AttrariaLabelTagClearButtonText;
  s.ssariaLabelText = obj.AttrariaLabelText == null ? "" : obj.AttrariaLabelText;
  s.ssautofocus = obj.Attrautofocus == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrautofocus;
  s.ssautoSelectFirstOption = obj.AttrautoSelectFirstOption == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrautoSelectFirstOption;
  s.ssdescriptionKey = obj.AttrdescriptionKey == null ? "" : obj.AttrdescriptionKey;
  s.ssdisableSelectAll = obj.AttrdisableSelectAll == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrdisableSelectAll;
  s.ssdisableAllOptionsSelectedText = obj.AttrdisableAllOptionsSelectedText == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrdisableAllOptionsSelectedText;
  s.ssdisabledOptions = BasicTypeList<string>.FromRestList(obj.AttrdisabledOptions);
  s.ssdisableOptionGroupCheckbox = obj.AttrdisableOptionGroupCheckbox == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrdisableOptionGroupCheckbox;
  s.ssdisableValidation = obj.AttrdisableValidation == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrdisableValidation;
  s.ssdropboxWidth = obj.AttrdropboxWidth == null ? "" : obj.AttrdropboxWidth;
  s.ssemptyValue = obj.AttremptyValue == null ? "" : obj.AttremptyValue;
  s.ssenableSecureText = obj.AttrenableSecureText == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrenableSecureText;
  s.ssfocusSelectedOptionOnOpen = obj.AttrfocusSelectedOptionOnOpen == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrfocusSelectedOptionOnOpen;
  s.sshideClearButton = obj.AttrhideClearButton == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrhideClearButton;
  s.ssmarkSearchResults = obj.AttrmarkSearchResults == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrmarkSearchResults;
  s.sskeepAlwaysOpen = obj.AttrkeepAlwaysOpen == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrkeepAlwaysOpen;
  s.sslabelKey = obj.AttrlabelKey == null ? "" : obj.AttrlabelKey;
  s.ssmaxValues = obj.AttrmaxValues == null ? 0 : obj.AttrmaxValues.Value;
  s.ssmaxWidth = obj.AttrmaxWidth == null ? "" : obj.AttrmaxWidth;
  s.ssminValues = obj.AttrminValues == null ? 0 : obj.AttrminValues.Value;
  s.ssmoreText = obj.AttrmoreText == null ? "" : obj.AttrmoreText;
  s.ssnoOfDisplayValues = obj.AttrnoOfDisplayValues == null ? 0 : obj.AttrnoOfDisplayValues.Value;
  s.ssoptionsCount = obj.AttroptionsCount == null ? 0 : obj.AttroptionsCount.Value;
  s.ssoptionHeight = obj.AttroptionHeight == null ? "" : obj.AttroptionHeight;
  s.ssoptionSelectedText = obj.AttroptionSelectedText == null ? "" : obj.AttroptionSelectedText;
  s.ssoptionsSelectedText = obj.AttroptionsSelectedText == null ? "" : obj.AttroptionsSelectedText;
  s.sspopupDropboxBreakpoint = obj.AttrpopupDropboxBreakpoint == null ? "" : obj.AttrpopupDropboxBreakpoint;
  s.sspopupPosition = obj.AttrpopupPosition == null ? "" : obj.AttrpopupPosition;
  s.ssposition = obj.Attrposition == null ? "" : obj.Attrposition;
  s.ssrequired = obj.Attrrequired == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrrequired;
  s.sssearch = obj.Attrsearch == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.Attrsearch;
  s.sssearchByStartsWith = obj.AttrsearchByStartsWith == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrsearchByStartsWith;
  s.sssearchFormLabel = obj.AttrsearchFormLabel == null ? "" : obj.AttrsearchFormLabel;
  s.sssearchGroup = obj.AttrsearchGroup == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrsearchGroup;
  s.sssearchNormalize = obj.AttrsearchNormalize == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrsearchNormalize;
  s.ssselectAllOnlyVisible = obj.AttrselectAllOnlyVisible == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrselectAllOnlyVisible;
  s.ssselectAllText = obj.AttrselectAllText == null ? "" : obj.AttrselectAllText;
  s.ssshowDropboxAsPopup = obj.AttrshowDropboxAsPopup == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrshowDropboxAsPopup;
  s.ssshowOptionsOnlyOnSearch = obj.AttrshowOptionsOnlyOnSearch == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrshowOptionsOnlyOnSearch;
  s.ssshowDuration = obj.AttrshowDuration == null ? 0 : obj.AttrshowDuration.Value;
  s.ssshowSelectedOptionsFirst = obj.AttrshowSelectedOptionsFirst == null ? (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel : obj.AttrshowSelectedOptionsFirst;
  s.sstextDirection = obj.AttrtextDirection == null ? "" : obj.AttrtextDirection;
  s.ssvalueKey = obj.AttrvalueKey == null ? "" : obj.AttrvalueKey;
  s.sszIndex = obj.AttrzIndex == null ? 0 : obj.AttrzIndex.Value;
  s.sshideDuration = obj.AttrhideDuration == null ? 0 : obj.AttrhideDuration.Value;
  }
  return s;
}

public static Func<ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure, ssOutSystemsUI.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure FromStructure(ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure(s, config);
}

}


