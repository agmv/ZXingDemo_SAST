using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// VideoState
public class JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord : AbstractRESTStructure<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> {
[JsonProperty("State")]
[JsonPropertyName("State")]
public string AttrState;

public JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord() { }

public JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrState = s.ssState;
  } else {
AttrState = s.ssState;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s) => ToStructure(s, config);
}
public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s = new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord();
  if(obj != null) {
  s.ssState = obj.AttrState == null ? "" : obj.AttrState;
  }
  return s;
}

public static Func<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord FromStructure(EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord(s, config);
}

}


