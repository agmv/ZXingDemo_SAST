using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// TriggerRecord
public class JSONRC_ab84a98a3ac9de80e9278e5b21681a23 : AbstractRESTStructure<RC_ab84a98a3ac9de80e9278e5b21681a23> {
[JsonProperty("Trigger")]
[JsonPropertyName("Trigger")]
public ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord AttrTrigger;

public JSONRC_ab84a98a3ac9de80e9278e5b21681a23() { }

public JSONRC_ab84a98a3ac9de80e9278e5b21681a23 (RC_ab84a98a3ac9de80e9278e5b21681a23 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTrigger = ConvertToRestWithoutDefaults(s.ssENTrigger, new EN_52e55d60c515b6016f81404afb220594EntityRecord(), ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord.FromStructureDelegate(config));
  } else {
AttrTrigger = ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord.FromStructure(s.ssENTrigger, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23, RC_ab84a98a3ac9de80e9278e5b21681a23> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23 s) => ToStructure(s, config);
}
public static RC_ab84a98a3ac9de80e9278e5b21681a23 ToStructure(ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23 obj, IBehaviorsConfiguration config) { 
  RC_ab84a98a3ac9de80e9278e5b21681a23 s = new RC_ab84a98a3ac9de80e9278e5b21681a23();
  if(obj != null) {
  s.ssENTrigger = ssZXingLibDemo.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord.ToStructure(obj.AttrTrigger, config);
  }
  return s;
}

public static Func<RC_ab84a98a3ac9de80e9278e5b21681a23, ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab84a98a3ac9de80e9278e5b21681a23 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23 FromStructure(RC_ab84a98a3ac9de80e9278e5b21681a23 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_ab84a98a3ac9de80e9278e5b21681a23(s, config);
}

}


