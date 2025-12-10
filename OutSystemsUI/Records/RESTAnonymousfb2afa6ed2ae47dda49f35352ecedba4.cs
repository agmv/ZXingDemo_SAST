using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ErrorMessageRecord
public class RESTRC_27b5a164e828de9b90686831c7908b4a : AbstractRESTStructure<RC_27b5a164e828de9b90686831c7908b4a> {
[JsonProperty("ErrorMessage")]
public ssOutSystemsUI.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure AttrErrorMessage;

public RESTRC_27b5a164e828de9b90686831c7908b4a() { }

public RESTRC_27b5a164e828de9b90686831c7908b4a (RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssSTErrorMessage, new ST_b7d405ca4407e572da091e54d07e3bd1Structure(), ssOutSystemsUI.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructureDelegate(config));
  } else {
AttrErrorMessage = ssOutSystemsUI.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructure(s.ssSTErrorMessage, config);
  }
}

public static RC_27b5a164e828de9b90686831c7908b4a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a obj) { 
  RC_27b5a164e828de9b90686831c7908b4a s = new RC_27b5a164e828de9b90686831c7908b4a();
  if(obj != null) {
  s.ssSTErrorMessage = ssOutSystemsUI.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.ToStructure(obj.AttrErrorMessage);
  }
  return s;
}

public static Func<RC_27b5a164e828de9b90686831c7908b4a, ssOutSystemsUI.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27b5a164e828de9b90686831c7908b4a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a FromStructure(RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a(s, config);
}

}


