using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record
public class JSONRC_bbab5f70da1d7251909f44ce9efe20fa : AbstractRESTStructure<RC_bbab5f70da1d7251909f44ce9efe20fa> {
[JsonProperty("WeekdayShort1")]
[JsonPropertyName("WeekdayShort1")]
public string AttrWeekdayShort1;

[JsonProperty("WeekdayShort2")]
[JsonPropertyName("WeekdayShort2")]
public string AttrWeekdayShort2;

[JsonProperty("WeekdayShort3")]
[JsonPropertyName("WeekdayShort3")]
public string AttrWeekdayShort3;

[JsonProperty("WeekdayShort4")]
[JsonPropertyName("WeekdayShort4")]
public string AttrWeekdayShort4;

[JsonProperty("WeekdayShort5")]
[JsonPropertyName("WeekdayShort5")]
public string AttrWeekdayShort5;

[JsonProperty("WeekdayShort6")]
[JsonPropertyName("WeekdayShort6")]
public string AttrWeekdayShort6;

[JsonProperty("WeekdayShort7")]
[JsonPropertyName("WeekdayShort7")]
public string AttrWeekdayShort7;

public JSONRC_bbab5f70da1d7251909f44ce9efe20fa() { }

public JSONRC_bbab5f70da1d7251909f44ce9efe20fa (RC_bbab5f70da1d7251909f44ce9efe20fa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWeekdayShort1 = ConvertToRestWithoutDefaults(s.ssWeekdayShort1, "");
AttrWeekdayShort2 = ConvertToRestWithoutDefaults(s.ssWeekdayShort2, "");
AttrWeekdayShort3 = ConvertToRestWithoutDefaults(s.ssWeekdayShort3, "");
AttrWeekdayShort4 = ConvertToRestWithoutDefaults(s.ssWeekdayShort4, "");
AttrWeekdayShort5 = ConvertToRestWithoutDefaults(s.ssWeekdayShort5, "");
AttrWeekdayShort6 = ConvertToRestWithoutDefaults(s.ssWeekdayShort6, "");
AttrWeekdayShort7 = ConvertToRestWithoutDefaults(s.ssWeekdayShort7, "");
  } else {
AttrWeekdayShort1 = s.ssWeekdayShort1;
AttrWeekdayShort2 = s.ssWeekdayShort2;
AttrWeekdayShort3 = s.ssWeekdayShort3;
AttrWeekdayShort4 = s.ssWeekdayShort4;
AttrWeekdayShort5 = s.ssWeekdayShort5;
AttrWeekdayShort6 = s.ssWeekdayShort6;
AttrWeekdayShort7 = s.ssWeekdayShort7;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa, RC_bbab5f70da1d7251909f44ce9efe20fa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa s) => ToStructure(s, config);
}
public static RC_bbab5f70da1d7251909f44ce9efe20fa ToStructure(ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa obj, IBehaviorsConfiguration config) { 
  RC_bbab5f70da1d7251909f44ce9efe20fa s = new RC_bbab5f70da1d7251909f44ce9efe20fa();
  if(obj != null) {
  s.ssWeekdayShort1 = obj.AttrWeekdayShort1 == null ? "" : obj.AttrWeekdayShort1;
  s.ssWeekdayShort2 = obj.AttrWeekdayShort2 == null ? "" : obj.AttrWeekdayShort2;
  s.ssWeekdayShort3 = obj.AttrWeekdayShort3 == null ? "" : obj.AttrWeekdayShort3;
  s.ssWeekdayShort4 = obj.AttrWeekdayShort4 == null ? "" : obj.AttrWeekdayShort4;
  s.ssWeekdayShort5 = obj.AttrWeekdayShort5 == null ? "" : obj.AttrWeekdayShort5;
  s.ssWeekdayShort6 = obj.AttrWeekdayShort6 == null ? "" : obj.AttrWeekdayShort6;
  s.ssWeekdayShort7 = obj.AttrWeekdayShort7 == null ? "" : obj.AttrWeekdayShort7;
  }
  return s;
}

public static Func<RC_bbab5f70da1d7251909f44ce9efe20fa, ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bbab5f70da1d7251909f44ce9efe20fa s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa FromStructure(RC_bbab5f70da1d7251909f44ce9efe20fa s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_bbab5f70da1d7251909f44ce9efe20fa(s, config);
}

}


