using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthOrderYear
public class RESTST_71bc196daedd9ac0648bfd56a713859dStructure : AbstractRESTStructure<ST_71bc196daedd9ac0648bfd56a713859dStructure> {
[JsonProperty("Month")]
public string AttrMonth;

[JsonProperty("MonthOrder")]
public int? AttrMonthOrder;

[JsonProperty("Year")]
public int? AttrYear;

public RESTST_71bc196daedd9ac0648bfd56a713859dStructure() { }

public RESTST_71bc196daedd9ac0648bfd56a713859dStructure (ST_71bc196daedd9ac0648bfd56a713859dStructure s, IBehaviorsConfiguration config) {
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

public static ST_71bc196daedd9ac0648bfd56a713859dStructure ToStructure(ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure obj) { 
  ST_71bc196daedd9ac0648bfd56a713859dStructure s = new ST_71bc196daedd9ac0648bfd56a713859dStructure();
  if(obj != null) {
  s.ssMonth = obj.AttrMonth == null ? "" : obj.AttrMonth;
  s.ssMonthOrder = obj.AttrMonthOrder == null ? 0 : obj.AttrMonthOrder.Value;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  }
  return s;
}

public static Func<ST_71bc196daedd9ac0648bfd56a713859dStructure, ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_71bc196daedd9ac0648bfd56a713859dStructure s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure FromStructure(ST_71bc196daedd9ac0648bfd56a713859dStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure(s, config);
}

}


