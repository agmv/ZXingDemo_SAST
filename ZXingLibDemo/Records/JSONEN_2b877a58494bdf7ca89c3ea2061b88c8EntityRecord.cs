using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// MapEventTriggered
public class JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord : AbstractRESTStructure<EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

public JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord() { }

public JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord, EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s) => ToStructure(s, config);
}
public static EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord ToStructure(ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s = new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord, ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord FromStructure(EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord(s, config);
}

}


