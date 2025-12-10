using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ErrorMessageRecord
public class JSONRC_27b5a164e828de9b90686831c7908b4a : AbstractRESTStructure<RC_27b5a164e828de9b90686831c7908b4a> {
[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public ssOutSystemsUI.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure AttrErrorMessage;

public JSONRC_27b5a164e828de9b90686831c7908b4a() { }

public JSONRC_27b5a164e828de9b90686831c7908b4a (RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssSTErrorMessage, new ST_b7d405ca4407e572da091e54d07e3bd1Structure(), ssOutSystemsUI.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructureDelegate(config));
  } else {
AttrErrorMessage = ssOutSystemsUI.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructure(s.ssSTErrorMessage, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a, RC_27b5a164e828de9b90686831c7908b4a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a s) => ToStructure(s, config);
}
public static RC_27b5a164e828de9b90686831c7908b4a ToStructure(ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a obj, IBehaviorsConfiguration config) { 
  RC_27b5a164e828de9b90686831c7908b4a s = new RC_27b5a164e828de9b90686831c7908b4a();
  if(obj != null) {
  s.ssSTErrorMessage = ssOutSystemsUI.RestRecords.JSONST_b7d405ca4407e572da091e54d07e3bd1Structure.ToStructure(obj.AttrErrorMessage, config);
  }
  return s;
}

public static Func<RC_27b5a164e828de9b90686831c7908b4a, ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27b5a164e828de9b90686831c7908b4a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a FromStructure(RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_27b5a164e828de9b90686831c7908b4a(s, config);
}

}


