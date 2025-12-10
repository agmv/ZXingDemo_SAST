using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthYear
public class JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure : AbstractRESTStructure<ST_5c08eaa15b890a2d617cabe547c34f0bStructure> {
[JsonProperty("Month")]
[JsonPropertyName("Month")]
public string AttrMonth;

[JsonProperty("Year")]
[JsonPropertyName("Year")]
public int? AttrYear;

public JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure() { }

public JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure (ST_5c08eaa15b890a2d617cabe547c34f0bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth = ConvertToRestWithoutDefaults(s.ssMonth, "");
AttrYear = ConvertToRestWithoutDefaults(s.ssYear, 0);
  } else {
AttrMonth = s.ssMonth;
AttrYear = (int?) s.ssYear;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure, ST_5c08eaa15b890a2d617cabe547c34f0bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure s) => ToStructure(s, config);
}
public static ST_5c08eaa15b890a2d617cabe547c34f0bStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure obj, IBehaviorsConfiguration config) { 
  ST_5c08eaa15b890a2d617cabe547c34f0bStructure s = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
  if(obj != null) {
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  }
  return s;
}

public static Func<ST_5c08eaa15b890a2d617cabe547c34f0bStructure, ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5c08eaa15b890a2d617cabe547c34f0bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure FromStructure(ST_5c08eaa15b890a2d617cabe547c34f0bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_5c08eaa15b890a2d617cabe547c34f0bStructure(s, config);
}

}


