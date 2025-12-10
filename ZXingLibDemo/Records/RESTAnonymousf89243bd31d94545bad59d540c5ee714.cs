using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIItemRecord
public class RESTRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
public ssZXingLibDemo.RestRecords.RESTSTAIItemStructure AttrAIItem;

public RESTRCAIItemRecord() { }

public RESTRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssZXingLibDemo.RestRecords.RESTSTAIItemStructure.FromStructureDelegate(config));
  } else {
AttrAIItem = ssZXingLibDemo.RestRecords.RESTSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static RCAIItemRecord ToStructure(ssZXingLibDemo.RestRecords.RESTRCAIItemRecord obj) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssZXingLibDemo.RestRecords.RESTSTAIItemStructure.ToStructure(obj.AttrAIItem);
  }
  return s;
}

public static Func<RCAIItemRecord, ssZXingLibDemo.RestRecords.RESTRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRCAIItemRecord(s, config);
}

}


