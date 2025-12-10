using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Autoplay
public class JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord : AbstractRESTStructure<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> {
[JsonProperty("Autoplay")]
[JsonPropertyName("Autoplay")]
public string AttrAutoplay;

public JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord() { }

public JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoplay = s.ssAutoplay;
  } else {
AttrAutoplay = s.ssAutoplay;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord s) => ToStructure(s, config);
}
public static EN_c3a2475ae6370a2f746040280495b4a2EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s = new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord();
  if(obj != null) {
  s.ssAutoplay = obj.AttrAutoplay == null ? "" : obj.AttrAutoplay;
  }
  return s;
}

public static Func<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord FromStructure(EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_c3a2475ae6370a2f746040280495b4a2EntityRecord(s, config);
}

}


