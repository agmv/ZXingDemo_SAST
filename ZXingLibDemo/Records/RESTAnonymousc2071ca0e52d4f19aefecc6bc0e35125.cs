using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// StartResetPasswordResultRecord
public class RESTRC_8f8c9b77bcc0996564febb7d38ea930a : AbstractRESTStructure<RC_8f8c9b77bcc0996564febb7d38ea930a> {
[JsonProperty("StartResetPasswordResult")]
public ssZXingLibDemo.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure AttrStartResetPasswordResult;

public RESTRC_8f8c9b77bcc0996564febb7d38ea930a() { }

public RESTRC_8f8c9b77bcc0996564febb7d38ea930a (RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartResetPasswordResult = ConvertToRestWithoutDefaults(s.ssSTStartResetPasswordResult, new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure(), ssZXingLibDemo.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructureDelegate(config));
  } else {
AttrStartResetPasswordResult = ssZXingLibDemo.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructure(s.ssSTStartResetPasswordResult, config);
  }
}

public static RC_8f8c9b77bcc0996564febb7d38ea930a ToStructure(ssZXingLibDemo.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a obj) { 
  RC_8f8c9b77bcc0996564febb7d38ea930a s = new RC_8f8c9b77bcc0996564febb7d38ea930a();
  if(obj != null) {
  s.ssSTStartResetPasswordResult = ssZXingLibDemo.RestRecords.RESTST_7df0b593cd1052614bf3d2f66d1ab2efStructure.ToStructure(obj.AttrStartResetPasswordResult);
  }
  return s;
}

public static Func<RC_8f8c9b77bcc0996564febb7d38ea930a, ssZXingLibDemo.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f8c9b77bcc0996564febb7d38ea930a s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a FromStructure(RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.RESTRC_8f8c9b77bcc0996564febb7d38ea930a(s, config);
}

}


