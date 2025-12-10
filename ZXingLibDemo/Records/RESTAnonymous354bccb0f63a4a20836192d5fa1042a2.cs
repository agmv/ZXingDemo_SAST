using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIMessageRecord
public class RESTRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
public ssZXingLibDemo.RestRecords.RESTSTAIMessageStructure AttrAIMessage;

public RESTRCAIMessageRecord() { }

public RESTRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssZXingLibDemo.RestRecords.RESTSTAIMessageStructure.FromStructureDelegate(config));
  } else {
AttrAIMessage = ssZXingLibDemo.RestRecords.RESTSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static RCAIMessageRecord ToStructure(ssZXingLibDemo.RestRecords.RESTRCAIMessageRecord obj) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssZXingLibDemo.RestRecords.RESTSTAIMessageStructure.ToStructure(obj.AttrAIMessage);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssZXingLibDemo.RestRecords.RESTRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRCAIMessageRecord(s, config);
}

}


