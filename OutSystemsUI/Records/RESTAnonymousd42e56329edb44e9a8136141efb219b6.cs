using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record
public class RESTRC_35ce9df1ad7a89533b2e8a49a8413520 : AbstractRESTStructure<RC_35ce9df1ad7a89533b2e8a49a8413520> {
[JsonProperty("Month1")]
public string AttrMonth1;

[JsonProperty("Month10")]
public string AttrMonth10;

[JsonProperty("Month11")]
public string AttrMonth11;

[JsonProperty("Month12")]
public string AttrMonth12;

[JsonProperty("Month2")]
public string AttrMonth2;

[JsonProperty("Month3")]
public string AttrMonth3;

[JsonProperty("Month4")]
public string AttrMonth4;

[JsonProperty("Month5")]
public string AttrMonth5;

[JsonProperty("Month6")]
public string AttrMonth6;

[JsonProperty("Month7")]
public string AttrMonth7;

[JsonProperty("Month8")]
public string AttrMonth8;

[JsonProperty("Month9")]
public string AttrMonth9;

public RESTRC_35ce9df1ad7a89533b2e8a49a8413520() { }

public RESTRC_35ce9df1ad7a89533b2e8a49a8413520 (RC_35ce9df1ad7a89533b2e8a49a8413520 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth1 = ConvertToRestWithoutDefaults(s.ssMonth1, "");
AttrMonth10 = ConvertToRestWithoutDefaults(s.ssMonth10, "");
AttrMonth11 = ConvertToRestWithoutDefaults(s.ssMonth11, "");
AttrMonth12 = ConvertToRestWithoutDefaults(s.ssMonth12, "");
AttrMonth2 = ConvertToRestWithoutDefaults(s.ssMonth2, "");
AttrMonth3 = ConvertToRestWithoutDefaults(s.ssMonth3, "");
AttrMonth4 = ConvertToRestWithoutDefaults(s.ssMonth4, "");
AttrMonth5 = ConvertToRestWithoutDefaults(s.ssMonth5, "");
AttrMonth6 = ConvertToRestWithoutDefaults(s.ssMonth6, "");
AttrMonth7 = ConvertToRestWithoutDefaults(s.ssMonth7, "");
AttrMonth8 = ConvertToRestWithoutDefaults(s.ssMonth8, "");
AttrMonth9 = ConvertToRestWithoutDefaults(s.ssMonth9, "");
  } else {
AttrMonth1 = s.ssMonth1;
AttrMonth10 = s.ssMonth10;
AttrMonth11 = s.ssMonth11;
AttrMonth12 = s.ssMonth12;
AttrMonth2 = s.ssMonth2;
AttrMonth3 = s.ssMonth3;
AttrMonth4 = s.ssMonth4;
AttrMonth5 = s.ssMonth5;
AttrMonth6 = s.ssMonth6;
AttrMonth7 = s.ssMonth7;
AttrMonth8 = s.ssMonth8;
AttrMonth9 = s.ssMonth9;
  }
}

public static RC_35ce9df1ad7a89533b2e8a49a8413520 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520 obj) { 
  RC_35ce9df1ad7a89533b2e8a49a8413520 s = new RC_35ce9df1ad7a89533b2e8a49a8413520();
  if(obj != null) {
  s.ssMonth1 = obj.AttrMonth1 == null ? "" : obj.AttrMonth1;
  s.ssMonth10 = obj.AttrMonth10 == null ? "" : obj.AttrMonth10;
  s.ssMonth11 = obj.AttrMonth11 == null ? "" : obj.AttrMonth11;
  s.ssMonth12 = obj.AttrMonth12 == null ? "" : obj.AttrMonth12;
  s.ssMonth2 = obj.AttrMonth2 == null ? "" : obj.AttrMonth2;
  s.ssMonth3 = obj.AttrMonth3 == null ? "" : obj.AttrMonth3;
  s.ssMonth4 = obj.AttrMonth4 == null ? "" : obj.AttrMonth4;
  s.ssMonth5 = obj.AttrMonth5 == null ? "" : obj.AttrMonth5;
  s.ssMonth6 = obj.AttrMonth6 == null ? "" : obj.AttrMonth6;
  s.ssMonth7 = obj.AttrMonth7 == null ? "" : obj.AttrMonth7;
  s.ssMonth8 = obj.AttrMonth8 == null ? "" : obj.AttrMonth8;
  s.ssMonth9 = obj.AttrMonth9 == null ? "" : obj.AttrMonth9;
  }
  return s;
}

public static Func<RC_35ce9df1ad7a89533b2e8a49a8413520, ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_35ce9df1ad7a89533b2e8a49a8413520 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520 FromStructure(RC_35ce9df1ad7a89533b2e8a49a8413520 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_35ce9df1ad7a89533b2e8a49a8413520(s, config);
}

}


