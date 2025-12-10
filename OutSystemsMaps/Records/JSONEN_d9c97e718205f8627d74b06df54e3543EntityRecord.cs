using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// MarkerEventTriggered
public class JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord : AbstractRESTStructure<EN_d9c97e718205f8627d74b06df54e3543EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord() { }

public JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord (EN_d9c97e718205f8627d74b06df54e3543EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord, EN_d9c97e718205f8627d74b06df54e3543EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord s) => ToStructure(s, config);
}
public static EN_d9c97e718205f8627d74b06df54e3543EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d9c97e718205f8627d74b06df54e3543EntityRecord s = new EN_d9c97e718205f8627d74b06df54e3543EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_d9c97e718205f8627d74b06df54e3543EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d9c97e718205f8627d74b06df54e3543EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord FromStructure(EN_d9c97e718205f8627d74b06df54e3543EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_d9c97e718205f8627d74b06df54e3543EntityRecord(s, config);
}

}


