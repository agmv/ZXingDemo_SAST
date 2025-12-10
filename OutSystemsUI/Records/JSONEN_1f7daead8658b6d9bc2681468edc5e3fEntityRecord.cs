using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownProvider
public class JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord : AbstractRESTStructure<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> {
[JsonProperty("Provider")]
[JsonPropertyName("Provider")]
public string AttrProvider;

public JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord() { }

public JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord s) => ToStructure(s, config);
}
public static EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord s = new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord, ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord FromStructure(EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord(s, config);
}

}


