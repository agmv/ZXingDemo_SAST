using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// PositionRecord
public class RESTRC_5f28219a5e30fb90023fcbc295513e7c : AbstractRESTStructure<RC_5f28219a5e30fb90023fcbc295513e7c> {
[JsonProperty("Position")]
public ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord AttrPosition;

public RESTRC_5f28219a5e30fb90023fcbc295513e7c() { }

public RESTRC_5f28219a5e30fb90023fcbc295513e7c (RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = ConvertToRestWithoutDefaults(s.ssENPosition, new EN_5d1279724e719322292e34ef3c5500a0EntityRecord(), ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructureDelegate(config));
  } else {
AttrPosition = ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.FromStructure(s.ssENPosition, config);
  }
}

public static RC_5f28219a5e30fb90023fcbc295513e7c ToStructure(ssZXingLibDemo.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c obj) { 
  RC_5f28219a5e30fb90023fcbc295513e7c s = new RC_5f28219a5e30fb90023fcbc295513e7c();
  if(obj != null) {
  s.ssENPosition = ssZXingLibDemo.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord.ToStructure(obj.AttrPosition);
  }
  return s;
}

public static Func<RC_5f28219a5e30fb90023fcbc295513e7c, ssZXingLibDemo.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f28219a5e30fb90023fcbc295513e7c s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c FromStructure(RC_5f28219a5e30fb90023fcbc295513e7c s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_5f28219a5e30fb90023fcbc295513e7c(s, config);
}

}


