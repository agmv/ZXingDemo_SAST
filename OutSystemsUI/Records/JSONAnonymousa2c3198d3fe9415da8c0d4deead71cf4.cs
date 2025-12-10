using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthOrderYearRecord
public class JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 : AbstractRESTStructure<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> {
[JsonProperty("MonthOrderYear")]
[JsonPropertyName("MonthOrderYear")]
public ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure AttrMonthOrderYear;

public JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1() { }

public JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonthOrderYear = ConvertToRestWithoutDefaults(s.ssSTMonthOrderYear, new ST_71bc196daedd9ac0648bfd56a713859dStructure(), ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure.FromStructureDelegate(config));
  } else {
AttrMonthOrderYear = ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure.FromStructure(s.ssSTMonthOrderYear, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1, RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s) => ToStructure(s, config);
}
public static RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 obj, IBehaviorsConfiguration config) { 
  RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s = new RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1();
  if(obj != null) {
  s.ssSTMonthOrderYear = ssOutSystemsUI.RestRecords.JSONST_71bc196daedd9ac0648bfd56a713859dStructure.ToStructure(obj.AttrMonthOrderYear, config);
  }
  return s;
}

public static Func<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1, ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 FromStructure(RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1(s, config);
}

}


