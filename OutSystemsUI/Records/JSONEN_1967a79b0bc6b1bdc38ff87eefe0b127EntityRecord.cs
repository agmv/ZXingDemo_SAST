using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ScrollbarStyle
public class JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord : AbstractRESTStructure<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> {
[JsonProperty("Style")]
[JsonPropertyName("Style")]
public string AttrStyle;

public JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord() { }

public JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStyle = s.ssStyle;
  } else {
AttrStyle = s.ssStyle;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord s) => ToStructure(s, config);
}
public static EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord s = new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord();
  if(obj != null) {
  s.ssStyle = obj.AttrStyle == null ? "" : obj.AttrStyle;
  }
  return s;
}

public static Func<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord FromStructure(EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord(s, config);
}

}


