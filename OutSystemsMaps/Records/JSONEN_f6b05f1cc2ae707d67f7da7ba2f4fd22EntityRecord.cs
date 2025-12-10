using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsPosition
public class JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord : AbstractRESTStructure<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord() { }

public JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s) => ToStructure(s, config);
}
public static EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s = new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord FromStructure(EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord(s, config);
}

}


