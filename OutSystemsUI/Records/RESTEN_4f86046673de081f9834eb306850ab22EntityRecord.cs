using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FloatingPosition
public class RESTEN_4f86046673de081f9834eb306850ab22EntityRecord : AbstractRESTStructure<EN_4f86046673de081f9834eb306850ab22EntityRecord> {
[JsonProperty("Position")]
public string AttrPosition;

public RESTEN_4f86046673de081f9834eb306850ab22EntityRecord() { }

public RESTEN_4f86046673de081f9834eb306850ab22EntityRecord (EN_4f86046673de081f9834eb306850ab22EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static EN_4f86046673de081f9834eb306850ab22EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord obj) { 
  EN_4f86046673de081f9834eb306850ab22EntityRecord s = new EN_4f86046673de081f9834eb306850ab22EntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_4f86046673de081f9834eb306850ab22EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4f86046673de081f9834eb306850ab22EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord FromStructure(EN_4f86046673de081f9834eb306850ab22EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_4f86046673de081f9834eb306850ab22EntityRecord(s, config);
}

}


