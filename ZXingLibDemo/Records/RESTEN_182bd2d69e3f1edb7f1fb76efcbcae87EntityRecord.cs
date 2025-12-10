using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// BreakColumns
public class RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord : AbstractRESTStructure<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> {
[JsonProperty("BreakColumns")]
public string AttrBreakColumns;

public RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord() { }

public RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBreakColumns = s.ssBreakColumns;
  } else {
AttrBreakColumns = s.ssBreakColumns;
  }
}

public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord ToStructure(ssZXingLibDemo.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord obj) { 
  EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s = new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord();
  if(obj != null) {
  s.ssBreakColumns = obj.AttrBreakColumns == null ? "" : obj.AttrBreakColumns;
  }
  return s;
}

public static Func<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, ssZXingLibDemo.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord FromStructure(EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(s, config);
}

}


