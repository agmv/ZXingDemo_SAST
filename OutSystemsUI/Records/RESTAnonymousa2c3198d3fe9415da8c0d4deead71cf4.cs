using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MonthOrderYearRecord
public class RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 : AbstractRESTStructure<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> {
[JsonProperty("MonthOrderYear")]
public ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure AttrMonthOrderYear;

public RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1() { }

public RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMonthOrderYear = ConvertToRestWithoutDefaults(s.ssSTMonthOrderYear, new ST_71bc196daedd9ac0648bfd56a713859dStructure(), ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure.FromStructureDelegate(config));
  } else {
AttrMonthOrderYear = ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure.FromStructure(s.ssSTMonthOrderYear, config);
  }
}

public static RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 obj) { 
  RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s = new RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1();
  if(obj != null) {
  s.ssSTMonthOrderYear = ssOutSystemsUI.RestRecords.RESTST_71bc196daedd9ac0648bfd56a713859dStructure.ToStructure(obj.AttrMonthOrderYear);
  }
  return s;
}

public static Func<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1, ssOutSystemsUI.RestRecords.RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 FromStructure(RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1(s, config);
}

}


