using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// TypeRecord
public class JSONRC_b32e755d03dd085a4b975b8c0c7d4454 : AbstractRESTStructure<RC_b32e755d03dd085a4b975b8c0c7d4454> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord AttrType;

public JSONRC_b32e755d03dd085a4b975b8c0c7d4454() { }

public JSONRC_b32e755d03dd085a4b975b8c0c7d4454 (RC_b32e755d03dd085a4b975b8c0c7d4454 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = ConvertToRestWithoutDefaults(s.ssENType, new EN_da8d5af471adea3d9064074b1a40d8c2EntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.FromStructureDelegate(config));
  } else {
AttrType = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.FromStructure(s.ssENType, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454, RC_b32e755d03dd085a4b975b8c0c7d4454> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454 s) => ToStructure(s, config);
}
public static RC_b32e755d03dd085a4b975b8c0c7d4454 ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454 obj, IBehaviorsConfiguration config) { 
  RC_b32e755d03dd085a4b975b8c0c7d4454 s = new RC_b32e755d03dd085a4b975b8c0c7d4454();
  if(obj != null) {
  s.ssENType = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord.ToStructure(obj.AttrType, config);
  }
  return s;
}

public static Func<RC_b32e755d03dd085a4b975b8c0c7d4454, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b32e755d03dd085a4b975b8c0c7d4454 s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454 FromStructure(RC_b32e755d03dd085a4b975b8c0c7d4454 s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_b32e755d03dd085a4b975b8c0c7d4454(s, config);
}

}


