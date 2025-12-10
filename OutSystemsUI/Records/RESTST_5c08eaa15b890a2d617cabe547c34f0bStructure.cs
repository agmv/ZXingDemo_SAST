using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthYear
public class RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure : AbstractRESTStructure<ST_5c08eaa15b890a2d617cabe547c34f0bStructure> {
[JsonProperty("Month")]
public string AttrMonth;

[JsonProperty("Year")]
public int? AttrYear;

public RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure() { }

public RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure (ST_5c08eaa15b890a2d617cabe547c34f0bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth = ConvertToRestWithoutDefaults(s.ssMonth, "");
AttrYear = ConvertToRestWithoutDefaults(s.ssYear, 0);
  } else {
AttrMonth = s.ssMonth;
AttrYear = (int?) s.ssYear;
  }
}

public static ST_5c08eaa15b890a2d617cabe547c34f0bStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure obj) { 
  ST_5c08eaa15b890a2d617cabe547c34f0bStructure s = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
  if(obj != null) {
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  }
  return s;
}

public static Func<ST_5c08eaa15b890a2d617cabe547c34f0bStructure, ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5c08eaa15b890a2d617cabe547c34f0bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure FromStructure(ST_5c08eaa15b890a2d617cabe547c34f0bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_5c08eaa15b890a2d617cabe547c34f0bStructure(s, config);
}

}


