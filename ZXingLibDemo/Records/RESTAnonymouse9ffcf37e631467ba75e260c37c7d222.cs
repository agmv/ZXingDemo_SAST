using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// OffsetRecord
public class RESTRC_a3e0d02178b078a960ae427dd1751cbc : AbstractRESTStructure<RC_a3e0d02178b078a960ae427dd1751cbc> {
[JsonProperty("Offset")]
public ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure AttrOffset;

public RESTRC_a3e0d02178b078a960ae427dd1751cbc() { }

public RESTRC_a3e0d02178b078a960ae427dd1751cbc (RC_a3e0d02178b078a960ae427dd1751cbc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOffset = ConvertToRestWithoutDefaults(s.ssSTOffset, new ST_be62cc31fbe4705834275960beeb55e2Structure(), ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructureDelegate(config));
  } else {
AttrOffset = ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.FromStructure(s.ssSTOffset, config);
  }
}

public static RC_a3e0d02178b078a960ae427dd1751cbc ToStructure(ssZXingLibDemo.RestRecords.RESTRC_a3e0d02178b078a960ae427dd1751cbc obj) { 
  RC_a3e0d02178b078a960ae427dd1751cbc s = new RC_a3e0d02178b078a960ae427dd1751cbc();
  if(obj != null) {
  s.ssSTOffset = ssZXingLibDemo.RestRecords.RESTST_be62cc31fbe4705834275960beeb55e2Structure.ToStructure(obj.AttrOffset);
  }
  return s;
}

public static Func<RC_a3e0d02178b078a960ae427dd1751cbc, ssZXingLibDemo.RestRecords.RESTRC_a3e0d02178b078a960ae427dd1751cbc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a3e0d02178b078a960ae427dd1751cbc s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_a3e0d02178b078a960ae427dd1751cbc FromStructure(RC_a3e0d02178b078a960ae427dd1751cbc s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_a3e0d02178b078a960ae427dd1751cbc(s, config);
}

}


