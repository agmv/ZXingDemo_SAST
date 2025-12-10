using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIModelUsageRecord
public class JSONRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
[JsonPropertyName("AIModelUsage")]
public ssZXingLibDemo.RestRecords.JSONSTAIModelUsageStructure AttrAIModelUsage;

public JSONRCAIModelUsageRecord() { }

public JSONRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssZXingLibDemo.RestRecords.JSONSTAIModelUsageStructure.FromStructureDelegate(config));
  } else {
AttrAIModelUsage = ssZXingLibDemo.RestRecords.JSONSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord, RCAIModelUsageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord s) => ToStructure(s, config);
}
public static RCAIModelUsageRecord ToStructure(ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord obj, IBehaviorsConfiguration config) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssZXingLibDemo.RestRecords.JSONSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage, config);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRCAIModelUsageRecord(s, config);
}

}


