using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// PositionRecord
public class JSONRC_5f28219a5e30fb90023fcbc295513e7c : AbstractRESTStructure<RC_5f28219a5e30fb90023fcbc295513e7c> {
[JsonProperty("Position")]
[JsonPropertyName("Position")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord AttrPosition;

public JSONRC_5f28219a5e30fb90023fcbc295513e7c() { }

public JSONRC_5f28219a5e30fb90023fcbc295513e7c (RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = ConvertToRestWithoutDefaults(s.ssENPosition, new EN_5d1279724e719322292e34ef3c5500a0EntityRecord(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructureDelegate(config));
  } else {
AttrPosition = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructure(s.ssENPosition, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c, RC_5f28219a5e30fb90023fcbc295513e7c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c s) => ToStructure(s, config);
}
public static RC_5f28219a5e30fb90023fcbc295513e7c ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c obj, IBehaviorsConfiguration config) { 
  RC_5f28219a5e30fb90023fcbc295513e7c s = new RC_5f28219a5e30fb90023fcbc295513e7c();
  if(obj != null) {
  s.ssENPosition = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord.ToStructure(obj.AttrPosition, config);
  }
  return s;
}

public static Func<RC_5f28219a5e30fb90023fcbc295513e7c, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f28219a5e30fb90023fcbc295513e7c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c FromStructure(RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_5f28219a5e30fb90023fcbc295513e7c(s, config);
}

}


