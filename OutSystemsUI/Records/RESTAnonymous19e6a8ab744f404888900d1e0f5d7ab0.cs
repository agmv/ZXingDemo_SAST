using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePicker_InternalConfigRecord
public class RESTRC_3af5daa8009f6f7f8a09f38255a62078 : AbstractRESTStructure<RC_3af5daa8009f6f7f8a09f38255a62078> {
[JsonProperty("DatePicker_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_cd3e064c4ee8b37ab96945c09d5d2155Structure AttrDatePicker_InternalConfig;

public RESTRC_3af5daa8009f6f7f8a09f38255a62078() { }

public RESTRC_3af5daa8009f6f7f8a09f38255a62078 (RC_3af5daa8009f6f7f8a09f38255a62078 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePicker_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTDatePicker_InternalConfig, new ST_cd3e064c4ee8b37ab96945c09d5d2155Structure(), ssOutSystemsUI.RestRecords.RESTST_cd3e064c4ee8b37ab96945c09d5d2155Structure.FromStructureDelegate(config));
  } else {
AttrDatePicker_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_cd3e064c4ee8b37ab96945c09d5d2155Structure.FromStructure(s.ssSTDatePicker_InternalConfig, config);
  }
}

public static RC_3af5daa8009f6f7f8a09f38255a62078 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3af5daa8009f6f7f8a09f38255a62078 obj) { 
  RC_3af5daa8009f6f7f8a09f38255a62078 s = new RC_3af5daa8009f6f7f8a09f38255a62078();
  if(obj != null) {
  s.ssSTDatePicker_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_cd3e064c4ee8b37ab96945c09d5d2155Structure.ToStructure(obj.AttrDatePicker_InternalConfig);
  }
  return s;
}

public static Func<RC_3af5daa8009f6f7f8a09f38255a62078, ssOutSystemsUI.RestRecords.RESTRC_3af5daa8009f6f7f8a09f38255a62078> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3af5daa8009f6f7f8a09f38255a62078 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3af5daa8009f6f7f8a09f38255a62078 FromStructure(RC_3af5daa8009f6f7f8a09f38255a62078 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3af5daa8009f6f7f8a09f38255a62078(s, config);
}

}


