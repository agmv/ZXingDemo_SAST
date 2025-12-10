using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIContentType
public class JSONENAIContentTypeEntityRecord : AbstractRESTStructure<ENAIContentTypeEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENAIContentTypeEntityRecord() { }

public JSONENAIContentTypeEntityRecord (ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord, ENAIContentTypeEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord s) => ToStructure(s, config);
}
public static ENAIContentTypeEntityRecord ToStructure(ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord obj, IBehaviorsConfiguration config) { 
  ENAIContentTypeEntityRecord s = new ENAIContentTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIContentTypeEntityRecord, ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIContentTypeEntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord FromStructure(ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONENAIContentTypeEntityRecord(s, config);
}

}


