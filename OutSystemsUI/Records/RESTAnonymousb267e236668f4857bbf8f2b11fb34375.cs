using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord
public class RESTRC_edb482045d64b0cbbcbf62278fb73c32 : AbstractRESTStructure<RC_edb482045d64b0cbbcbf62278fb73c32> {
[JsonProperty("Midnight")]
public string AttrMidnight;

[JsonProperty("NextMonth")]
public string AttrNextMonth;

[JsonProperty("Noon")]
public string AttrNoon;

[JsonProperty("PreviousMonth")]
public string AttrPreviousMonth;

[JsonProperty("TodayButton")]
public string AttrTodayButton;

[JsonProperty("Weekdays")]
public RestList<ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11> AttrWeekdays;

[JsonProperty("WeekdaysShort")]
public RestList<ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa> AttrWeekdaysShort;

[JsonProperty("Months")]
public RestList<ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520> AttrMonths;

public RESTRC_edb482045d64b0cbbcbf62278fb73c32() { }

public RESTRC_edb482045d64b0cbbcbf62278fb73c32 (RC_edb482045d64b0cbbcbf62278fb73c32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMidnight = ConvertToRestWithoutDefaults(s.ssMidnight, "");
AttrNextMonth = ConvertToRestWithoutDefaults(s.ssNextMonth, "");
AttrNoon = ConvertToRestWithoutDefaults(s.ssNoon, "");
AttrPreviousMonth = ConvertToRestWithoutDefaults(s.ssPreviousMonth, "");
AttrTodayButton = ConvertToRestWithoutDefaults(s.ssTodayButton, "");
AttrWeekdays = s.ssRLWeekdays.Length == 0 ? null : s.ssRLWeekdays.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11>(ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11.FromStructureDelegate(config));
AttrWeekdaysShort = s.ssRLWeekdaysShort.Length == 0 ? null : s.ssRLWeekdaysShort.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa>(ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa.FromStructureDelegate(config));
AttrMonths = s.ssRLMonths.Length == 0 ? null : s.ssRLMonths.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520>(ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520.FromStructureDelegate(config));
  } else {
AttrMidnight = s.ssMidnight;
AttrNextMonth = s.ssNextMonth;
AttrNoon = s.ssNoon;
AttrPreviousMonth = s.ssPreviousMonth;
AttrTodayButton = s.ssTodayButton;
AttrWeekdays = s.ssRLWeekdays.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11>(ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11.FromStructureDelegate(config));
AttrWeekdaysShort = s.ssRLWeekdaysShort.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa>(ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa.FromStructureDelegate(config));
AttrMonths = s.ssRLMonths.ToRestList<ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520>(ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520.FromStructureDelegate(config));
  }
}

public static RC_edb482045d64b0cbbcbf62278fb73c32 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_edb482045d64b0cbbcbf62278fb73c32 obj) { 
  RC_edb482045d64b0cbbcbf62278fb73c32 s = new RC_edb482045d64b0cbbcbf62278fb73c32();
  if(obj != null) {
  s.ssMidnight = obj.AttrMidnight == null ? "" : obj.AttrMidnight;
  s.ssNextMonth = obj.AttrNextMonth == null ? "" : obj.AttrNextMonth;
  s.ssNoon = obj.AttrNoon == null ? "" : obj.AttrNoon;
  s.ssPreviousMonth = obj.AttrPreviousMonth == null ? "" : obj.AttrPreviousMonth;
  s.ssTodayButton = obj.AttrTodayButton == null ? "" : obj.AttrTodayButton;
  s.ssRLWeekdays = RL_1729600b673fd0870291732dd16f0147.FromRestList(obj.AttrWeekdays, ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11.ToStructure);
  s.ssRLWeekdaysShort = RL_4260c6c2a6b32d80f4d763c795bd8980.FromRestList(obj.AttrWeekdaysShort, ssOutSystemsUI.RestRecords.RESTRC_bbab5f70da1d7251909f44ce9efe20fa.ToStructure);
  s.ssRLMonths = RL_aec2af9ce70ea7e7bfe1e63d0f657cf5.FromRestList(obj.AttrMonths, ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520.ToStructure);
  }
  return s;
}

public static Func<RC_edb482045d64b0cbbcbf62278fb73c32, ssOutSystemsUI.RestRecords.RESTRC_edb482045d64b0cbbcbf62278fb73c32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_edb482045d64b0cbbcbf62278fb73c32 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_edb482045d64b0cbbcbf62278fb73c32 FromStructure(RC_edb482045d64b0cbbcbf62278fb73c32 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_edb482045d64b0cbbcbf62278fb73c32(s, config);
}

}


