using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CalendarCalendarDatesCloseCalendarDateSelectedDaySelectedDaysInRangeDialogButtonEndRangeEnterCalendarGoToTodayHasEventIsDisabledIsTodayKeyboardShortcutsMonthMonthNextMonthPreviousNavigationOpenCalendarStartRangeYearShortcutsDialogRecord
public class RESTRC_aa6f2a469018f20449b52bedd4074e46 : AbstractRESTStructure<RC_aa6f2a469018f20449b52bedd4074e46> {
[JsonProperty("Calendar")]
public string AttrCalendar;

[JsonProperty("CalendarDates")]
public string AttrCalendarDates;

[JsonProperty("CloseCalendar")]
public string AttrCloseCalendar;

[JsonProperty("DateSelected")]
public string AttrDateSelected;

[JsonProperty("DaySelected")]
public string AttrDaySelected;

[JsonProperty("DaysInRange")]
public string AttrDaysInRange;

[JsonProperty("DialogButton")]
public string AttrDialogButton;

[JsonProperty("EndRange")]
public string AttrEndRange;

[JsonProperty("EnterCalendar")]
public string AttrEnterCalendar;

[JsonProperty("GoToToday")]
public string AttrGoToToday;

[JsonProperty("HasEvent")]
public string AttrHasEvent;

[JsonProperty("IsDisabled")]
public string AttrIsDisabled;

[JsonProperty("IsToday")]
public string AttrIsToday;

[JsonProperty("KeyboardShortcuts")]
public string AttrKeyboardShortcuts;

[JsonProperty("Month")]
public string AttrMonth;

[JsonProperty("MonthNext")]
public string AttrMonthNext;

[JsonProperty("MonthPrevious")]
public string AttrMonthPrevious;

[JsonProperty("Navigation")]
public string AttrNavigation;

[JsonProperty("OpenCalendar")]
public string AttrOpenCalendar;

[JsonProperty("StartRange")]
public string AttrStartRange;

[JsonProperty("Year")]
public string AttrYear;

[JsonProperty("ShortcutsDialog")]
public RestList<ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086> AttrShortcutsDialog;

public RESTRC_aa6f2a469018f20449b52bedd4074e46() { }

public RESTRC_aa6f2a469018f20449b52bedd4074e46 (RC_aa6f2a469018f20449b52bedd4074e46 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCalendar = ConvertToRestWithoutDefaults(s.ssCalendar, "");
AttrCalendarDates = ConvertToRestWithoutDefaults(s.ssCalendarDates, "");
AttrCloseCalendar = ConvertToRestWithoutDefaults(s.ssCloseCalendar, "");
AttrDateSelected = ConvertToRestWithoutDefaults(s.ssDateSelected, "");
AttrDaySelected = ConvertToRestWithoutDefaults(s.ssDaySelected, "");
AttrDaysInRange = ConvertToRestWithoutDefaults(s.ssDaysInRange, "");
AttrDialogButton = ConvertToRestWithoutDefaults(s.ssDialogButton, "");
AttrEndRange = ConvertToRestWithoutDefaults(s.ssEndRange, "");
AttrEnterCalendar = ConvertToRestWithoutDefaults(s.ssEnterCalendar, "");
AttrGoToToday = ConvertToRestWithoutDefaults(s.ssGoToToday, "");
AttrHasEvent = ConvertToRestWithoutDefaults(s.ssHasEvent, "");
AttrIsDisabled = ConvertToRestWithoutDefaults(s.ssIsDisabled, "");
AttrIsToday = ConvertToRestWithoutDefaults(s.ssIsToday, "");
AttrKeyboardShortcuts = ConvertToRestWithoutDefaults(s.ssKeyboardShortcuts, "");
AttrMonth = ConvertToRestWithoutDefaults(s.ssMonth, "");
AttrMonthNext = ConvertToRestWithoutDefaults(s.ssMonthNext, "");
AttrMonthPrevious = ConvertToRestWithoutDefaults(s.ssMonthPrevious, "");
AttrNavigation = ConvertToRestWithoutDefaults(s.ssNavigation, "");
AttrOpenCalendar = ConvertToRestWithoutDefaults(s.ssOpenCalendar, "");
AttrStartRange = ConvertToRestWithoutDefaults(s.ssStartRange, "");
AttrYear = ConvertToRestWithoutDefaults(s.ssYear, "");
AttrShortcutsDialog = s.ssRLShortcutsDialog.Length == 0 ? null : s.ssRLShortcutsDialog.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086>(ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086.FromStructureDelegate(config));
  } else {
AttrCalendar = s.ssCalendar;
AttrCalendarDates = s.ssCalendarDates;
AttrCloseCalendar = s.ssCloseCalendar;
AttrDateSelected = s.ssDateSelected;
AttrDaySelected = s.ssDaySelected;
AttrDaysInRange = s.ssDaysInRange;
AttrDialogButton = s.ssDialogButton;
AttrEndRange = s.ssEndRange;
AttrEnterCalendar = s.ssEnterCalendar;
AttrGoToToday = s.ssGoToToday;
AttrHasEvent = s.ssHasEvent;
AttrIsDisabled = s.ssIsDisabled;
AttrIsToday = s.ssIsToday;
AttrKeyboardShortcuts = s.ssKeyboardShortcuts;
AttrMonth = s.ssMonth;
AttrMonthNext = s.ssMonthNext;
AttrMonthPrevious = s.ssMonthPrevious;
AttrNavigation = s.ssNavigation;
AttrOpenCalendar = s.ssOpenCalendar;
AttrStartRange = s.ssStartRange;
AttrYear = s.ssYear;
AttrShortcutsDialog = s.ssRLShortcutsDialog.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086>(ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086.FromStructureDelegate(config));
  }
}

public static RC_aa6f2a469018f20449b52bedd4074e46 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_aa6f2a469018f20449b52bedd4074e46 obj) { 
  RC_aa6f2a469018f20449b52bedd4074e46 s = new RC_aa6f2a469018f20449b52bedd4074e46();
  if(obj != null) {
  s.ssCalendar = obj.AttrCalendar == null ? "" : obj.AttrCalendar;
  s.ssCalendarDates = obj.AttrCalendarDates == null ? "" : obj.AttrCalendarDates;
  s.ssCloseCalendar = obj.AttrCloseCalendar == null ? "" : obj.AttrCloseCalendar;
  s.ssDateSelected = obj.AttrDateSelected == null ? "" : obj.AttrDateSelected;
  s.ssDaySelected = obj.AttrDaySelected == null ? "" : obj.AttrDaySelected;
  s.ssDaysInRange = obj.AttrDaysInRange == null ? "" : obj.AttrDaysInRange;
  s.ssDialogButton = obj.AttrDialogButton == null ? "" : obj.AttrDialogButton;
  s.ssEndRange = obj.AttrEndRange == null ? "" : obj.AttrEndRange;
  s.ssEnterCalendar = obj.AttrEnterCalendar == null ? "" : obj.AttrEnterCalendar;
  s.ssGoToToday = obj.AttrGoToToday == null ? "" : obj.AttrGoToToday;
  s.ssHasEvent = obj.AttrHasEvent == null ? "" : obj.AttrHasEvent;
  s.ssIsDisabled = obj.AttrIsDisabled == null ? "" : obj.AttrIsDisabled;
  s.ssIsToday = obj.AttrIsToday == null ? "" : obj.AttrIsToday;
  s.ssKeyboardShortcuts = obj.AttrKeyboardShortcuts == null ? "" : obj.AttrKeyboardShortcuts;
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssMonthNext = obj.AttrMonthNext == null ? "" : obj.AttrMonthNext;
  s.ssMonthPrevious = obj.AttrMonthPrevious == null ? "" : obj.AttrMonthPrevious;
  s.ssNavigation = obj.AttrNavigation == null ? "" : obj.AttrNavigation;
  s.ssOpenCalendar = obj.AttrOpenCalendar == null ? "" : obj.AttrOpenCalendar;
  s.ssStartRange = obj.AttrStartRange == null ? "" : obj.AttrStartRange;
  s.ssYear = obj.AttrYear == null ? "" : obj.AttrYear;
  s.ssRLShortcutsDialog = RL_52688881ccfed8dc2d89a4eb45a2498e.FromRestList(obj.AttrShortcutsDialog, ssOutSystemsUI.RestRecords.RESTRC_4c3ee0d0ad514546e23495b0186f9086.ToStructure);
  }
  return s;
}

public static Func<RC_aa6f2a469018f20449b52bedd4074e46, ssOutSystemsUI.RestRecords.RESTRC_aa6f2a469018f20449b52bedd4074e46> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa6f2a469018f20449b52bedd4074e46 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_aa6f2a469018f20449b52bedd4074e46 FromStructure(RC_aa6f2a469018f20449b52bedd4074e46 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_aa6f2a469018f20449b52bedd4074e46(s, config);
}

}


