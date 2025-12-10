using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.RestRecords;

// StartResetPasswordResultRecord
public class JSONRC_8f8c9b77bcc0996564febb7d38ea930a : AbstractRESTStructure<RC_8f8c9b77bcc0996564febb7d38ea930a> {
[JsonProperty("StartResetPasswordResult")]
[JsonPropertyName("StartResetPasswordResult")]
public ssZXingLibDemo.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure AttrStartResetPasswordResult;

public JSONRC_8f8c9b77bcc0996564febb7d38ea930a() { }

public JSONRC_8f8c9b77bcc0996564febb7d38ea930a (RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartResetPasswordResult = ConvertToRestWithoutDefaults(s.ssSTStartResetPasswordResult, new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure(), ssZXingLibDemo.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructureDelegate(config));
  } else {
AttrStartResetPasswordResult = ssZXingLibDemo.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructure(s.ssSTStartResetPasswordResult, config);
  }
}

public static Func<ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a, RC_8f8c9b77bcc0996564febb7d38ea930a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a s) => ToStructure(s, config);
}
public static RC_8f8c9b77bcc0996564febb7d38ea930a ToStructure(ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a obj, IBehaviorsConfiguration config) { 
  RC_8f8c9b77bcc0996564febb7d38ea930a s = new RC_8f8c9b77bcc0996564febb7d38ea930a();
  if(obj != null) {
  s.ssSTStartResetPasswordResult = ssZXingLibDemo.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.ToStructure(obj.AttrStartResetPasswordResult, config);
  }
  return s;
}

public static Func<RC_8f8c9b77bcc0996564febb7d38ea930a, ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f8c9b77bcc0996564febb7d38ea930a s) => FromStructure(s, config);
}
public static ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a FromStructure(RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a(s, config);
}

}


