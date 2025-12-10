using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Alert
public class RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord : AbstractRESTStructure<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> {
[JsonProperty("Alert")]
public string AttrAlert;

public RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord() { }

public RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAlert = s.ssAlert;
  } else {
AttrAlert = s.ssAlert;
  }
}

public static EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord obj) { 
  EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s = new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord();
  if(obj != null) {
  s.ssAlert = obj.AttrAlert == null ? "" : obj.AttrAlert;
  }
  return s;
}

public static Func<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord FromStructure(EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord(s, config);
}

}


