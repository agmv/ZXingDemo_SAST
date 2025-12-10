using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// MapEventTriggeredRecord
public class JSONRC_bf75694d8016688134fa555a2fd4f5d7 : AbstractRESTStructure<RC_bf75694d8016688134fa555a2fd4f5d7> {
[JsonProperty("MapEventTriggered")]
[JsonPropertyName("MapEventTriggered")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord AttrMapEventTriggered;

public JSONRC_bf75694d8016688134fa555a2fd4f5d7() { }

public JSONRC_bf75694d8016688134fa555a2fd4f5d7 (RC_bf75694d8016688134fa555a2fd4f5d7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMapEventTriggered = ConvertToRestWithoutDefaults(s.ssENMapEventTriggered, new EN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.FromStructureDelegate(config));
  } else {
AttrMapEventTriggered = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.FromStructure(s.ssENMapEventTriggered, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7, RC_bf75694d8016688134fa555a2fd4f5d7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7 s) => ToStructure(s, config);
}
public static RC_bf75694d8016688134fa555a2fd4f5d7 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7 obj, IBehaviorsConfiguration config) { 
  RC_bf75694d8016688134fa555a2fd4f5d7 s = new RC_bf75694d8016688134fa555a2fd4f5d7();
  if(obj != null) {
  s.ssENMapEventTriggered = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord.ToStructure(obj.AttrMapEventTriggered, config);
  }
  return s;
}

public static Func<RC_bf75694d8016688134fa555a2fd4f5d7, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bf75694d8016688134fa555a2fd4f5d7 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7 FromStructure(RC_bf75694d8016688134fa555a2fd4f5d7 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_bf75694d8016688134fa555a2fd4f5d7(s, config);
}

}


