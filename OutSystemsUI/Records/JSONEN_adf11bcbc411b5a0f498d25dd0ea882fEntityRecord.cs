using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Alert
public class JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord : AbstractRESTStructure<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> {
[JsonProperty("Alert")]
[JsonPropertyName("Alert")]
public string AttrAlert;

public JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord() { }

public JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAlert = s.ssAlert;
  } else {
AttrAlert = s.ssAlert;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s) => ToStructure(s, config);
}
public static EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s = new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord();
  if(obj != null) {
  s.ssAlert = obj.AttrAlert == null ? "" : obj.AttrAlert;
  }
  return s;
}

public static Func<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord FromStructure(EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord(s, config);
}

}


