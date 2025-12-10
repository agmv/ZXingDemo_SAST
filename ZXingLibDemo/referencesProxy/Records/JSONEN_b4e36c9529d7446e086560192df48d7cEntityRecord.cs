using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// DatePickerTimeFormat
public class JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord : AbstractRESTStructure<EN_b4e36c9529d7446e086560192df48d7cEntityRecord> {
[JsonProperty("Timeformat")]
[JsonPropertyName("Timeformat")]
public string AttrTimeformat;

public JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord() { }

public JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord (EN_b4e36c9529d7446e086560192df48d7cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimeformat = s.ssTimeformat;
  } else {
AttrTimeformat = s.ssTimeformat;
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord, EN_b4e36c9529d7446e086560192df48d7cEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord s) => ToStructure(s, config);
}
public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b4e36c9529d7446e086560192df48d7cEntityRecord s = new EN_b4e36c9529d7446e086560192df48d7cEntityRecord();
  if(obj != null) {
  s.ssTimeformat = obj.AttrTimeformat == null ? "" : obj.AttrTimeformat;
  }
  return s;
}

public static Func<EN_b4e36c9529d7446e086560192df48d7cEntityRecord, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord FromStructure(EN_b4e36c9529d7446e086560192df48d7cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord(s, config);
}

}


