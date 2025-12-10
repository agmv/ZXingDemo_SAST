using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// AIItemRecord
public class JSONRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
[JsonPropertyName("AIItem")]
public ssZXingLibDemo.RestRecords.JSONSTAIItemStructure AttrAIItem;

public JSONRCAIItemRecord() { }

public JSONRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssZXingLibDemo.RestRecords.JSONSTAIItemStructure.FromStructureDelegate(config));
  } else {
AttrAIItem = ssZXingLibDemo.RestRecords.JSONSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRCAIItemRecord, RCAIItemRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRCAIItemRecord s) => ToStructure(s, config);
}
public static RCAIItemRecord ToStructure(ssZXingLibDemo.RestRecords.JSONRCAIItemRecord obj, IBehaviorsConfiguration config) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssZXingLibDemo.RestRecords.JSONSTAIItemStructure.ToStructure(obj.AttrAIItem, config);
  }
  return s;
}

public static Func<RCAIItemRecord, ssZXingLibDemo.RestRecords.JSONRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRCAIItemRecord(s, config);
}

}


