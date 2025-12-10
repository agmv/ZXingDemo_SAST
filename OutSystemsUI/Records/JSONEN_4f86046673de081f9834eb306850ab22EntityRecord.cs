using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FloatingPosition
public class JSONEN_4f86046673de081f9834eb306850ab22EntityRecord : AbstractRESTStructure<EN_4f86046673de081f9834eb306850ab22EntityRecord> {
[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

public JSONEN_4f86046673de081f9834eb306850ab22EntityRecord() { }

public JSONEN_4f86046673de081f9834eb306850ab22EntityRecord (EN_4f86046673de081f9834eb306850ab22EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord, EN_4f86046673de081f9834eb306850ab22EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord s) => ToStructure(s, config);
}
public static EN_4f86046673de081f9834eb306850ab22EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_4f86046673de081f9834eb306850ab22EntityRecord s = new EN_4f86046673de081f9834eb306850ab22EntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_4f86046673de081f9834eb306850ab22EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4f86046673de081f9834eb306850ab22EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord FromStructure(EN_4f86046673de081f9834eb306850ab22EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_4f86046673de081f9834eb306850ab22EntityRecord(s, config);
}

}


