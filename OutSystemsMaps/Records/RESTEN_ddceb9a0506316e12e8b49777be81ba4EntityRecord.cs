using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesErrors
public class RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord : AbstractRESTStructure<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> {
[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord() { }

public RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = s.ssCode;
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord obj) { 
  EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s = new EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord FromStructure(EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord(s, config);
}

}


