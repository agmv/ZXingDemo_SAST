using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// LogType
public class RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord : AbstractRESTStructure<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> {
[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord() { }

public RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord obj) { 
  EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord s = new EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord FromStructure(EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord(s, config);
}

}


