using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// UserUpdateInfoRecord
public class JSONRC_a582d84634a30a3a3b1e61cbfd3db9de : AbstractRESTStructure<RC_a582d84634a30a3a3b1e61cbfd3db9de> {
[JsonProperty("UserUpdateInfo")]
[JsonPropertyName("UserUpdateInfo")]
public ssZXingLibDemo.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure AttrUserUpdateInfo;

public JSONRC_a582d84634a30a3a3b1e61cbfd3db9de() { }

public JSONRC_a582d84634a30a3a3b1e61cbfd3db9de (RC_a582d84634a30a3a3b1e61cbfd3db9de s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserUpdateInfo = ConvertToRestWithoutDefaults(s.ssSTUserUpdateInfo, new ST_da83da85e5348cd2800e701fda6288aaStructure(), ssZXingLibDemo.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure.FromStructureDelegate(config));
  } else {
AttrUserUpdateInfo = ssZXingLibDemo.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure.FromStructure(s.ssSTUserUpdateInfo, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de, RC_a582d84634a30a3a3b1e61cbfd3db9de> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de s) => ToStructure(s, config);
}
public static RC_a582d84634a30a3a3b1e61cbfd3db9de ToStructure(ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de obj, IBehaviorsConfiguration config) { 
  RC_a582d84634a30a3a3b1e61cbfd3db9de s = new RC_a582d84634a30a3a3b1e61cbfd3db9de();
  if(obj != null) {
  s.ssSTUserUpdateInfo = ssZXingLibDemo.RestRecords.JSONST_da83da85e5348cd2800e701fda6288aaStructure.ToStructure(obj.AttrUserUpdateInfo, config);
  }
  return s;
}

public static Func<RC_a582d84634a30a3a3b1e61cbfd3db9de, ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a582d84634a30a3a3b1e61cbfd3db9de s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de FromStructure(RC_a582d84634a30a3a3b1e61cbfd3db9de s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_a582d84634a30a3a3b1e61cbfd3db9de(s, config);
}

}


