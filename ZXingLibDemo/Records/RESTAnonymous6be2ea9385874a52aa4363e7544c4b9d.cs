using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// UserLoginResultRecord
public class RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb : AbstractRESTStructure<RC_f9a589fe5b81c3bda7db0e574d5d11fb> {
[JsonProperty("UserLoginResult")]
public ssZXingLibDemo.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure AttrUserLoginResult;

public RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb() { }

public RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb (RC_f9a589fe5b81c3bda7db0e574d5d11fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserLoginResult = ConvertToRestWithoutDefaults(s.ssSTUserLoginResult, new ST_784fb57b420e5c0c2e1f611378088fbaStructure(), ssZXingLibDemo.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure.FromStructureDelegate(config));
  } else {
AttrUserLoginResult = ssZXingLibDemo.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure.FromStructure(s.ssSTUserLoginResult, config);
  }
}

public static RC_f9a589fe5b81c3bda7db0e574d5d11fb ToStructure(ssZXingLibDemo.RestRecords.RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb obj) { 
  RC_f9a589fe5b81c3bda7db0e574d5d11fb s = new RC_f9a589fe5b81c3bda7db0e574d5d11fb();
  if(obj != null) {
  s.ssSTUserLoginResult = ssZXingLibDemo.RestRecords.RESTST_784fb57b420e5c0c2e1f611378088fbaStructure.ToStructure(obj.AttrUserLoginResult);
  }
  return s;
}

public static Func<RC_f9a589fe5b81c3bda7db0e574d5d11fb, ssZXingLibDemo.RestRecords.RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f9a589fe5b81c3bda7db0e574d5d11fb s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb FromStructure(RC_f9a589fe5b81c3bda7db0e574d5d11fb s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_f9a589fe5b81c3bda7db0e574d5d11fb(s, config);
}

}


