using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// SearchPlacesErrors
public class JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord : AbstractRESTStructure<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> {
[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord() { }

public JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = s.ssCode;
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s) => ToStructure(s, config);
}
public static EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s = new EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord FromStructure(EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_ddceb9a0506316e12e8b49777be81ba4EntityRecord(s, config);
}

}


