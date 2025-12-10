using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// MenuAction
public class JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord : AbstractRESTStructure<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> {
[JsonProperty("MenuAction")]
[JsonPropertyName("MenuAction")]
public string AttrMenuAction;

public JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord() { }

public JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMenuAction = s.ssMenuAction;
  } else {
AttrMenuAction = s.ssMenuAction;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord s) => ToStructure(s, config);
}
public static EN_f43f179caddf7f7b68b18272d67285d6EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f43f179caddf7f7b68b18272d67285d6EntityRecord s = new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord();
  if(obj != null) {
  s.ssMenuAction = obj.AttrMenuAction == null ? "" : obj.AttrMenuAction;
  }
  return s;
}

public static Func<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord FromStructure(EN_f43f179caddf7f7b68b18272d67285d6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_f43f179caddf7f7b68b18272d67285d6EntityRecord(s, config);
}

}


