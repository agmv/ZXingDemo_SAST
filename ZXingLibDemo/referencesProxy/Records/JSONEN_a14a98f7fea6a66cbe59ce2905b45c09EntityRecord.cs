using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// Size
public class JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord : AbstractRESTStructure<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> {
[JsonProperty("Size")]
[JsonPropertyName("Size")]
public string AttrSize;

public JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord() { }

public JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = s.ssSize;
  } else {
AttrSize = s.ssSize;
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s) => ToStructure(s, config);
}
public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s = new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord();
  if(obj != null) {
  s.ssSize = obj.AttrSize == null ? "" : obj.AttrSize;
  }
  return s;
}

public static Func<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord FromStructure(EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord(s, config);
}

}


