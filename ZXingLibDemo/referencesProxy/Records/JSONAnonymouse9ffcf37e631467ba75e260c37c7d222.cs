using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// OffsetRecord
public class JSONRC_a3e0d02178b078a960ae427dd1751cbc : AbstractRESTStructure<RC_a3e0d02178b078a960ae427dd1751cbc> {
[JsonProperty("Offset")]
[JsonPropertyName("Offset")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure AttrOffset;

public JSONRC_a3e0d02178b078a960ae427dd1751cbc() { }

public JSONRC_a3e0d02178b078a960ae427dd1751cbc (RC_a3e0d02178b078a960ae427dd1751cbc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOffset = ConvertToRestWithoutDefaults(s.ssSTOffset, new ST_be62cc31fbe4705834275960beeb55e2Structure(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructureDelegate(config));
  } else {
AttrOffset = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssSTOffset, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc, RC_a3e0d02178b078a960ae427dd1751cbc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc s) => ToStructure(s, config);
}
public static RC_a3e0d02178b078a960ae427dd1751cbc ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc obj, IBehaviorsConfiguration config) { 
  RC_a3e0d02178b078a960ae427dd1751cbc s = new RC_a3e0d02178b078a960ae427dd1751cbc();
  if(obj != null) {
  s.ssSTOffset = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.AttrOffset, config);
  }
  return s;
}

public static Func<RC_a3e0d02178b078a960ae427dd1751cbc, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a3e0d02178b078a960ae427dd1751cbc s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc FromStructure(RC_a3e0d02178b078a960ae427dd1751cbc s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_a3e0d02178b078a960ae427dd1751cbc(s, config);
}

}


