using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerRange_InternalConfig
public class JSONST_256310aee13520906f2ba115af101f62Structure : AbstractRESTStructure<ST_256310aee13520906f2ba115af101f62Structure> {
[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

[JsonProperty("DateFormat")]
[JsonPropertyName("DateFormat")]
public string AttrDateFormat;

[JsonProperty("InitialStartDate")]
[JsonPropertyName("InitialStartDate")]
public String AttrInitialStartDate;

[JsonProperty("InitialEndDate")]
[JsonPropertyName("InitialEndDate")]
public String AttrInitialEndDate;

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

public JSONST_256310aee13520906f2ba115af101f62Structure() { }

public JSONST_256310aee13520906f2ba115af101f62Structure (ST_256310aee13520906f2ba115af101f62Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
AttrDateFormat = ConvertToRestWithoutDefaults(s.ssDateFormat, "");
AttrInitialStartDate = ConvertDateTimeToRestWithoutDefaults(s.ssInitialStartDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrInitialEndDate = ConvertDateTimeToRestWithoutDefaults(s.ssInitialEndDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrShowTodayButton = ConvertToRestWithoutDefaults(s.ssShowTodayButton, false);
AttrFirstWeekDay = ConvertToRestWithoutDefaults(s.ssFirstWeekDay, (ENDatePickerWeekDayEntity.GetRecordByKey(ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"))).ssWeekDay);
AttrMinDate = ConvertDateTimeToRestWithoutDefaults(s.ssMinDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMaxDate = ConvertDateTimeToRestWithoutDefaults(s.ssMaxDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrShowWeekNumbers = ConvertToRestWithoutDefaults(s.ssShowWeekNumbers, false);
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
  } else {
AttrUniqueId = s.ssUniqueId;
AttrDateFormat = s.ssDateFormat;
AttrInitialStartDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssInitialStartDate, config.DateTimeFormat);
AttrInitialEndDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssInitialEndDate, config.DateTimeFormat);
AttrShowTodayButton = (bool?) s.ssShowTodayButton;
AttrFirstWeekDay = (int?) s.ssFirstWeekDay;
AttrMinDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMinDate, config.DateTimeFormat);
AttrMaxDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMaxDate, config.DateTimeFormat);
AttrShowWeekNumbers = (bool?) s.ssShowWeekNumbers;
AttrExtendedClass = s.ssExtendedClass;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure, ST_256310aee13520906f2ba115af101f62Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure s) => ToStructure(s, config);
}
public static ST_256310aee13520906f2ba115af101f62Structure ToStructure(ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure obj, IBehaviorsConfiguration config) { 
  ST_256310aee13520906f2ba115af101f62Structure s = new ST_256310aee13520906f2ba115af101f62Structure();
  if(obj != null) {
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  s.ssDateFormat = obj.AttrDateFormat == null ? "" : obj.AttrDateFormat;
  s.ssInitialStartDate = obj.AttrInitialStartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrInitialStartDate, config.DateTimeFormat);
  s.ssInitialEndDate = obj.AttrInitialEndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrInitialEndDate, config.DateTimeFormat);
  s.ssShowTodayButton = obj.AttrShowTodayButton == null ? false : obj.AttrShowTodayButton.Value;
  s.ssFirstWeekDay = obj.AttrFirstWeekDay == null ? (ENDatePickerWeekDayEntity.GetRecordByKey(ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"))).ssWeekDay : obj.AttrFirstWeekDay.Value;
  s.ssMinDate = obj.AttrMinDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMinDate, config.DateTimeFormat);
  s.ssMaxDate = obj.AttrMaxDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMaxDate, config.DateTimeFormat);
  s.ssShowWeekNumbers = obj.AttrShowWeekNumbers == null ? false : obj.AttrShowWeekNumbers.Value;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  }
  return s;
}

public static Func<ST_256310aee13520906f2ba115af101f62Structure, ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_256310aee13520906f2ba115af101f62Structure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure FromStructure(ST_256310aee13520906f2ba115af101f62Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_256310aee13520906f2ba115af101f62Structure(s, config);
}

}


