using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record
public class RESTRC_d3d7d244571ed038dbfee008e77e8c11 : AbstractRESTStructure<RC_d3d7d244571ed038dbfee008e77e8c11> {
[JsonProperty("Weekday1")]
public string AttrWeekday1;

[JsonProperty("Weekday2")]
public string AttrWeekday2;

[JsonProperty("Weekday3")]
public string AttrWeekday3;

[JsonProperty("Weekday4")]
public string AttrWeekday4;

[JsonProperty("Weekday5")]
public string AttrWeekday5;

[JsonProperty("Weekday6")]
public string AttrWeekday6;

[JsonProperty("Weekday7")]
public string AttrWeekday7;

public RESTRC_d3d7d244571ed038dbfee008e77e8c11() { }

public RESTRC_d3d7d244571ed038dbfee008e77e8c11 (RC_d3d7d244571ed038dbfee008e77e8c11 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWeekday1 = ConvertToRestWithoutDefaults(s.ssWeekday1, "");
AttrWeekday2 = ConvertToRestWithoutDefaults(s.ssWeekday2, "");
AttrWeekday3 = ConvertToRestWithoutDefaults(s.ssWeekday3, "");
AttrWeekday4 = ConvertToRestWithoutDefaults(s.ssWeekday4, "");
AttrWeekday5 = ConvertToRestWithoutDefaults(s.ssWeekday5, "");
AttrWeekday6 = ConvertToRestWithoutDefaults(s.ssWeekday6, "");
AttrWeekday7 = ConvertToRestWithoutDefaults(s.ssWeekday7, "");
  } else {
AttrWeekday1 = s.ssWeekday1;
AttrWeekday2 = s.ssWeekday2;
AttrWeekday3 = s.ssWeekday3;
AttrWeekday4 = s.ssWeekday4;
AttrWeekday5 = s.ssWeekday5;
AttrWeekday6 = s.ssWeekday6;
AttrWeekday7 = s.ssWeekday7;
  }
}

public static RC_d3d7d244571ed038dbfee008e77e8c11 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11 obj) { 
  RC_d3d7d244571ed038dbfee008e77e8c11 s = new RC_d3d7d244571ed038dbfee008e77e8c11();
  if(obj != null) {
  s.ssWeekday1 = obj.AttrWeekday1 == null ? "" : obj.AttrWeekday1;
  s.ssWeekday2 = obj.AttrWeekday2 == null ? "" : obj.AttrWeekday2;
  s.ssWeekday3 = obj.AttrWeekday3 == null ? "" : obj.AttrWeekday3;
  s.ssWeekday4 = obj.AttrWeekday4 == null ? "" : obj.AttrWeekday4;
  s.ssWeekday5 = obj.AttrWeekday5 == null ? "" : obj.AttrWeekday5;
  s.ssWeekday6 = obj.AttrWeekday6 == null ? "" : obj.AttrWeekday6;
  s.ssWeekday7 = obj.AttrWeekday7 == null ? "" : obj.AttrWeekday7;
  }
  return s;
}

public static Func<RC_d3d7d244571ed038dbfee008e77e8c11, ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d3d7d244571ed038dbfee008e77e8c11 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11 FromStructure(RC_d3d7d244571ed038dbfee008e77e8c11 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_d3d7d244571ed038dbfee008e77e8c11(s, config);
}

}


