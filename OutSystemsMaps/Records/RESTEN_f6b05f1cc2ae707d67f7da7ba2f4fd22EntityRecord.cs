using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsPosition
public class RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord : AbstractRESTStructure<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord() { }

public RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord obj) { 
  EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s = new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord FromStructure(EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTEN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord(s, config);
}

}


