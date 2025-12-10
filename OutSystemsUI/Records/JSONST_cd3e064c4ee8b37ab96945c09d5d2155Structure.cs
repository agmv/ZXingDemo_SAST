using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePicker_InternalConfig
public class JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure : AbstractRESTStructure<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("DateFormat")]
[JsonPropertyName("DateFormat")]
public string AttrDateFormat;

[JsonProperty("InitialDate")]
[JsonPropertyName("InitialDate")]
public String AttrInitialDate;

[JsonProperty("TimeFormat")]
[JsonPropertyName("TimeFormat")]
public string AttrTimeFormat;

[JsonProperty("ShowTodayButton")]
[JsonPropertyName("ShowTodayButton")]
public bool? AttrShowTodayButton;

[JsonProperty("FirstWeekDay")]
[JsonPropertyName("FirstWeekDay")]
public int? AttrFirstWeekDay;

[JsonProperty("MinDate")]
[JsonPropertyName("MinDate")]
public String AttrMinDate;

[JsonProperty("MaxDate")]
[JsonPropertyName("MaxDate")]
public String AttrMaxDate;

[JsonProperty("ShowWeekNumbers")]
[JsonPropertyName("ShowWeekNumbers")]
public bool? AttrShowWeekNumbers;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

public JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure() { }

public JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrDateFormat = ConvertToRestWithoutDefaults(s.ssDateFormat, "");
AttrInitialDate = ConvertDateTimeToRestWithoutDefaults(s.ssInitialDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrTimeFormat = ConvertToRestWithoutDefaults(s.ssTimeFormat, (ENDatePickerTimeFormatEntity.GetRecordByKey(ObjectKey.Parse("FTwhSItTIkKj6tE25gilfQ"))).ssTimeformat);
AttrShowTodayButton = ConvertToRestWithoutDefaults(s.ssShowTodayButton, false);
AttrFirstWeekDay = ConvertToRestWithoutDefaults(s.ssFirstWeekDay, (ENDatePickerWeekDayEntity.GetRecordByKey(ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"))).ssWeekDay);
AttrMinDate = ConvertDateTimeToRestWithoutDefaults(s.ssMinDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMaxDate = ConvertDateTimeToRestWithoutDefaults(s.ssMaxDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrShowWeekNumbers = ConvertToRestWithoutDefaults(s.ssShowWeekNumbers, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrDateFormat = s.ssDateFormat;
AttrInitialDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssInitialDate, config.DateTimeFormat);
AttrTimeFormat = s.ssTimeFormat;
AttrShowTodayButton = (bool?) s.ssShowTodayButton;
AttrFirstWeekDay = (int?) s.ssFirstWeekDay;
AttrMinDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMinDate, config.DateTimeFormat);
AttrMaxDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMaxDate, config.DateTimeFormat);
AttrShowWeekNumbers = (bool?) s.ssShowWeekNumbers;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure, ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure s) => ToStructure(s, config);
}
public static ST_cd3e064c4ee8b37ab96945c09d5d2155Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure obj, IBehaviorsConfiguration config) { 
  ST_cd3e064c4ee8b37ab96945c09d5d2155Structure s = new ST_cd3e064c4ee8b37ab96945c09d5d2155Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssDateFormat = obj.AttrDateFormat == null ? "" : obj.AttrDateFormat;
  s.ssInitialDate = obj.AttrInitialDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrInitialDate, config.DateTimeFormat);
  s.ssTimeFormat = obj.AttrTimeFormat == null ? (ENDatePickerTimeFormatEntity.GetRecordByKey(ObjectKey.Parse("FTwhSItTIkKj6tE25gilfQ"))).ssTimeformat : obj.AttrTimeFormat;
  s.ssShowTodayButton = obj.AttrShowTodayButton == null ? false : obj.AttrShowTodayButton.Value;
  s.ssFirstWeekDay = obj.AttrFirstWeekDay == null ? (ENDatePickerWeekDayEntity.GetRecordByKey(ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"))).ssWeekDay : obj.AttrFirstWeekDay.Value;
  s.ssMinDate = obj.AttrMinDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMinDate, config.DateTimeFormat);
  s.ssMaxDate = obj.AttrMaxDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMaxDate, config.DateTimeFormat);
  s.ssShowWeekNumbers = obj.AttrShowWeekNumbers == null ? false : obj.AttrShowWeekNumbers.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure, ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure FromStructure(ST_cd3e064c4ee8b37ab96945c09d5d2155Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_cd3e064c4ee8b37ab96945c09d5d2155Structure(s, config);
}

}


