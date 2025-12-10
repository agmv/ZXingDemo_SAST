using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// CarouselDirection
public class RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord : AbstractRESTStructure<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> {
[JsonProperty("Type")]
public string AttrType;

public RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord() { }

public RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord obj) { 
  EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s = new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord FromStructure(EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord(s, config);
}

}


