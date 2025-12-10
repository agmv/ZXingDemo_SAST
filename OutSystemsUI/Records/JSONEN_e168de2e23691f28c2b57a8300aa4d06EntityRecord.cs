using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressType
public class JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord : AbstractRESTStructure<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord() { }

public JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord s) => ToStructure(s, config);
}
public static EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord s = new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord FromStructure(EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord(s, config);
}

}


