using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssZXingLibDemo.ReferencesProxy.RestRecords;

// ErrorMessageRecord
public class JSONRC_27b5a164e828de9b90686831c7908b4a : AbstractRESTStructure<RC_27b5a164e828de9b90686831c7908b4a> {
[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure AttrErrorMessage;

public JSONRC_27b5a164e828de9b90686831c7908b4a() { }

public JSONRC_27b5a164e828de9b90686831c7908b4a (RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssSTErrorMessage, new ST_b7d405ca4407e572da091e54d07e3bd1Structure(), ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructureDelegate(config));
  } else {
AttrErrorMessage = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructure(s.ssSTErrorMessage, config);
  }
}

public static Func<ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a, RC_27b5a164e828de9b90686831c7908b4a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a s) => ToStructure(s, config);
}
public static RC_27b5a164e828de9b90686831c7908b4a ToStructure(ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a obj, IBehaviorsConfiguration config) { 
  RC_27b5a164e828de9b90686831c7908b4a s = new RC_27b5a164e828de9b90686831c7908b4a();
  if(obj != null) {
  s.ssSTErrorMessage = ssZXingLibDemo.ReferencesProxy.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.ToStructure(obj.AttrErrorMessage, config);
  }
  return s;
}

public static Func<RC_27b5a164e828de9b90686831c7908b4a, ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27b5a164e828de9b90686831c7908b4a s) => FromStructure(s, config);
}
public static ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a FromStructure(RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) { 
  return new ssZXingLibDemo.ReferencesProxy.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a(s, config);
}

}


