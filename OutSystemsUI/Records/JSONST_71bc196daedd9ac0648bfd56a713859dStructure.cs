using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthOrderYear
public class JSONST_71bc196daedd9ac0648bfd56a713859dStructure : AbstractRESTStructure<ST_71bc196daedd9ac0648bfd56a713859dStructure> {
[JsonProperty("Month")]
[JsonPropertyName("Month")]
public string AttrMonth;

[JsonProperty("MonthOrder")]
[JsonPropertyName("MonthOrder")]
public int? AttrMonthOrder;

[JsonProperty("Year")]
[JsonPropertyName("Year")]
public int? AttrYear;

public JSONST_71bc196daedd9ac0648bfd56a713859dStructure() { }

public JSONST_71bc196daedd9ac0648bfd56a713859dStructure (ST_71bc196daedd9ac0648bfd56a713859dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonth = ConvertToRestWithoutDefaults(s.ssMonth, "");
AttrMonthOrder = ConvertToRestWithoutDefaults(s.ssMonthOrder, 0);
AttrYear = ConvertToRestWithoutDefaults(s.ssYear, 0);
  } else {
AttrMonth = s.ssMonth;
AttrMonthOrder = (int?) s.ssMonthOrder;
AttrYear = (int?) s.ssYear;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure, ST_71bc196daedd9ac0648bfd56a713859dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure s) => ToStructure(s, config);
}
public static ST_71bc196daedd9ac0648bfd56a713859dStructure ToStructure(ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure obj, IBehaviorsConfiguration config) { 
  ST_71bc196daedd9ac0648bfd56a713859dStructure s = new ST_71bc196daedd9ac0648bfd56a713859dStructure();
  if(obj != null) {
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssMonthOrder = obj.AttrMonthOrder == null ? 0 : obj.AttrMonthOrder.Value;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  }
  return s;
}

public static Func<ST_71bc196daedd9ac0648bfd56a713859dStructure, ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_71bc196daedd9ac0648bfd56a713859dStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure FromStructure(ST_71bc196daedd9ac0648bfd56a713859dStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure(s, config);
}

}


