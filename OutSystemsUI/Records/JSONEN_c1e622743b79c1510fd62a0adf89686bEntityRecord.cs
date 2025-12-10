using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// SideMenuBehavior
public class JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord : AbstractRESTStructure<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> {
[JsonProperty("SideMenuBehavior")]
[JsonPropertyName("SideMenuBehavior")]
public string AttrSideMenuBehavior;

public JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord() { }

public JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSideMenuBehavior = s.ssSideMenuBehavior;
  } else {
AttrSideMenuBehavior = s.ssSideMenuBehavior;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord s) => ToStructure(s, config);
}
public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s = new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord();
  if(obj != null) {
  s.ssSideMenuBehavior = obj.AttrSideMenuBehavior == null ? "" : obj.AttrSideMenuBehavior;
  }
  return s;
}

public static Func<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord FromStructure(EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord(s, config);
}

}


