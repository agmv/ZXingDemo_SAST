using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIMessageRecord
public class JSONRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
[JsonPropertyName("AIMessage")]
public ssZXingLibDemo.RestRecords.JSONSTAIMessageStructure AttrAIMessage;

public JSONRCAIMessageRecord() { }

public JSONRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssZXingLibDemo.RestRecords.JSONSTAIMessageStructure.FromStructureDelegate(config));
  } else {
AttrAIMessage = ssZXingLibDemo.RestRecords.JSONSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord, RCAIMessageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord s) => ToStructure(s, config);
}
public static RCAIMessageRecord ToStructure(ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord obj, IBehaviorsConfiguration config) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssZXingLibDemo.RestRecords.JSONSTAIMessageStructure.ToStructure(obj.AttrAIMessage, config);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRCAIMessageRecord(s, config);
}

}


