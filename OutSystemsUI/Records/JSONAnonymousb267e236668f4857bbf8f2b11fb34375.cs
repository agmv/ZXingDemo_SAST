using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord
public class JSONRC_edb482045d64b0cbbcbf62278fb73c32 : AbstractRESTStructure<RC_edb482045d64b0cbbcbf62278fb73c32> {
[JsonProperty("Midnight")]
[JsonPropertyName("Midnight")]
public string AttrMidnight;

[JsonProperty("NextMonth")]
[JsonPropertyName("NextMonth")]
public string AttrNextMonth;

[JsonProperty("Noon")]
[JsonPropertyName("Noon")]
public string AttrNoon;

[JsonProperty("PreviousMonth")]
[JsonPropertyName("PreviousMonth")]
public string AttrPreviousMonth;

[JsonProperty("TodayButton")]
[JsonPropertyName("TodayButton")]
public string AttrTodayButton;

[JsonProperty("Weekdays")]
[JsonPropertyName("Weekdays")]
public ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11[] AttrWeekdays;

[JsonProperty("WeekdaysShort")]
[JsonPropertyName("WeekdaysShort")]
public ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa[] AttrWeekdaysShort;

[JsonProperty("Months")]
[JsonPropertyName("Months")]
public ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520[] AttrMonths;

public JSONRC_edb482045d64b0cbbcbf62278fb73c32() { }

public JSONRC_edb482045d64b0cbbcbf62278fb73c32 (RC_edb482045d64b0cbbcbf62278fb73c32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMidnight = ConvertToRestWithoutDefaults(s.ssMidnight, "");
AttrNextMonth = ConvertToRestWithoutDefaults(s.ssNextMonth, "");
AttrNoon = ConvertToRestWithoutDefaults(s.ssNoon, "");
AttrPreviousMonth = ConvertToRestWithoutDefaults(s.ssPreviousMonth, "");
AttrTodayButton = ConvertToRestWithoutDefaults(s.ssTodayButton, "");
AttrWeekdays = s.ssRLWeekdays.Length == 0 ? null : s.ssRLWeekdays.ToArray<ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11>(ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11.FromStructureDelegate(config));
AttrWeekdaysShort = s.ssRLWeekdaysShort.Length == 0 ? null : s.ssRLWeekdaysShort.ToArray<ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa>(ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa.FromStructureDelegate(config));
AttrMonths = s.ssRLMonths.Length == 0 ? null : s.ssRLMonths.ToArray<ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520>(ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520.FromStructureDelegate(config));
  } else {
AttrMidnight = s.ssMidnight;
AttrNextMonth = s.ssNextMonth;
AttrNoon = s.ssNoon;
AttrPreviousMonth = s.ssPreviousMonth;
AttrTodayButton = s.ssTodayButton;
AttrWeekdays = s.ssRLWeekdays.ToArray<ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11>(ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11.FromStructureDelegate(config));
AttrWeekdaysShort = s.ssRLWeekdaysShort.ToArray<ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa>(ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa.FromStructureDelegate(config));
AttrMonths = s.ssRLMonths.ToArray<ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520>(ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520.FromStructureDelegate(config));
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32, RC_edb482045d64b0cbbcbf62278fb73c32> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32 s) => ToStructure(s, config);
}
public static RC_edb482045d64b0cbbcbf62278fb73c32 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32 obj, IBehaviorsConfiguration config) { 
  RC_edb482045d64b0cbbcbf62278fb73c32 s = new RC_edb482045d64b0cbbcbf62278fb73c32();
  if(obj != null) {
  s.ssMidnight = obj.AttrMidnight == null ? "" : obj.AttrMidnight;
  s.ssNextMonth = obj.AttrNextMonth == null ? "" : obj.AttrNextMonth;
  s.ssNoon = obj.AttrNoon == null ? "" : obj.AttrNoon;
  s.ssPreviousMonth = obj.AttrPreviousMonth == null ? "" : obj.AttrPreviousMonth;
  s.ssTodayButton = obj.AttrTodayButton == null ? "" : obj.AttrTodayButton;
  s.ssRLWeekdays = RL_1729600b673fd0870291732dd16f0147.ToList(obj.AttrWeekdays, ssOutSystemsUI.RestRecords.JSONRC_d3d7d244571ed038dbfee008e77e8c11.ToStructureDelegate(config));
  s.ssRLWeekdaysShort = RL_4260c6c2a6b32d80f4d763c795bd8980.ToList(obj.AttrWeekdaysShort, ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa.ToStructureDelegate(config));
  s.ssRLMonths = RL_aec2af9ce70ea7e7bfe1e63d0f657cf5.ToList(obj.AttrMonths, ssOutSystemsUI.RestRecords.JSONRC_35ce9df1ad7a89533b2e8a49a8413520.ToStructureDelegate(config));
  }
  return s;
}

public static Func<RC_edb482045d64b0cbbcbf62278fb73c32, ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_edb482045d64b0cbbcbf62278fb73c32 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32 FromStructure(RC_edb482045d64b0cbbcbf62278fb73c32 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_edb482045d64b0cbbcbf62278fb73c32(s, config);
}

}


