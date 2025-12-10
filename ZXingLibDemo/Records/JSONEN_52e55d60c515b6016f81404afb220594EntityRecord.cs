using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// Trigger
public class JSONEN_52e55d60c515b6016f81404afb220594EntityRecord : AbstractRESTStructure<EN_52e55d60c515b6016f81404afb220594EntityRecord> {
[JsonProperty("Trigger")]
[JsonPropertyName("Trigger")]
public string AttrTrigger;

public JSONEN_52e55d60c515b6016f81404afb220594EntityRecord() { }

public JSONEN_52e55d60c515b6016f81404afb220594EntityRecord (EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTrigger = s.ssTrigger;
  } else {
AttrTrigger = s.ssTrigger;
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord, EN_52e55d60c515b6016f81404afb220594EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord s) => ToStructure(s, config);
}
public static EN_52e55d60c515b6016f81404afb220594EntityRecord ToStructure(ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_52e55d60c515b6016f81404afb220594EntityRecord s = new EN_52e55d60c515b6016f81404afb220594EntityRecord();
  if(obj != null) {
  s.ssTrigger = obj.AttrTrigger == null ? "" : obj.AttrTrigger;
  }
  return s;
}

public static Func<EN_52e55d60c515b6016f81404afb220594EntityRecord, ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_52e55d60c515b6016f81404afb220594EntityRecord s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord FromStructure(EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord(s, config);
}

}


