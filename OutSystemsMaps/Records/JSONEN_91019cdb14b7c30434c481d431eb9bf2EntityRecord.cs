using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// DrawingToolsEvent
public class JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord : AbstractRESTStructure<EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord() { }

public JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord (EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord, EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord s) => ToStructure(s, config);
}
public static EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord ToStructure(ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord s = new EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord, ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord FromStructure(EN_91019cdb14b7c30434c481d431eb9bf2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONEN_91019cdb14b7c30434c481d431eb9bf2EntityRecord(s, config);
}

}


