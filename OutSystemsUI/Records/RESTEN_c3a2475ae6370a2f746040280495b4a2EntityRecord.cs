using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Autoplay
public class RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord : AbstractRESTStructure<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> {
[JsonProperty("Autoplay")]
public string AttrAutoplay;

public RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord() { }

public RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoplay = s.ssAutoplay;
  } else {
AttrAutoplay = s.ssAutoplay;
  }
}

public static EN_c3a2475ae6370a2f746040280495b4a2EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord obj) { 
  EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s = new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord();
  if(obj != null) {
  s.ssAutoplay = obj.AttrAutoplay == null ? "" : obj.AttrAutoplay;
  }
  return s;
}

public static Func<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord FromStructure(EN_c3a2475ae6370a2f746040280495b4a2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_c3a2475ae6370a2f746040280495b4a2EntityRecord(s, config);
}

}


