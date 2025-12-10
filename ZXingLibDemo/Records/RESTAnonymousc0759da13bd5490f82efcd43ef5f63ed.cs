using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIModelUsageRecord
public class RESTRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
public ssZXingLibDemo.RestRecords.RESTSTAIModelUsageStructure AttrAIModelUsage;

public RESTRCAIModelUsageRecord() { }

public RESTRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssZXingLibDemo.RestRecords.RESTSTAIModelUsageStructure.FromStructureDelegate(config));
  } else {
AttrAIModelUsage = ssZXingLibDemo.RestRecords.RESTSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static RCAIModelUsageRecord ToStructure(ssZXingLibDemo.RestRecords.RESTRCAIModelUsageRecord obj) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssZXingLibDemo.RestRecords.RESTSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssZXingLibDemo.RestRecords.RESTRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRCAIModelUsageRecord(s, config);
}

}


