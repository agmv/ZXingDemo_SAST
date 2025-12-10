using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownServerSide_InternalConfigsRecord
public class RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80 : AbstractRESTStructure<RC_7d9f2e2bc8ad21193b3b806a3a092d80> {
[JsonProperty("DropdownServerSide_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_0d18385ed976d2d74e8cea1d77078409Structure AttrDropdownServerSide_InternalConfigs;

public RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80() { }

public RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80 (RC_7d9f2e2bc8ad21193b3b806a3a092d80 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownServerSide_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTDropdownServerSide_InternalConfigs, new ST_0d18385ed976d2d74e8cea1d77078409Structure(), ssOutSystemsUI.RestRecords.RESTST_0d18385ed976d2d74e8cea1d77078409Structure.FromStructureDelegate(config));
  } else {
AttrDropdownServerSide_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_0d18385ed976d2d74e8cea1d77078409Structure.FromStructure(s.ssSTDropdownServerSide_InternalConfigs, config);
  }
}

public static RC_7d9f2e2bc8ad21193b3b806a3a092d80 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80 obj) { 
  RC_7d9f2e2bc8ad21193b3b806a3a092d80 s = new RC_7d9f2e2bc8ad21193b3b806a3a092d80();
  if(obj != null) {
  s.ssSTDropdownServerSide_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_0d18385ed976d2d74e8cea1d77078409Structure.ToStructure(obj.AttrDropdownServerSide_InternalConfigs);
  }
  return s;
}

public static Func<RC_7d9f2e2bc8ad21193b3b806a3a092d80, ssOutSystemsUI.RestRecords.RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d9f2e2bc8ad21193b3b806a3a092d80 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80 FromStructure(RC_7d9f2e2bc8ad21193b3b806a3a092d80 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_7d9f2e2bc8ad21193b3b806a3a092d80(s, config);
}

}


