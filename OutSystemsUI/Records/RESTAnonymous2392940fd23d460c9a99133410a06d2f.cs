using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Video_InternalConfigRecord
public class RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf : AbstractRESTStructure<RC_824809bf8c57cb0db3f5d42bbea4d2cf> {
[JsonProperty("Video_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure AttrVideo_InternalConfig;

public RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf() { }

public RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf (RC_824809bf8c57cb0db3f5d42bbea4d2cf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideo_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTVideo_InternalConfig, new ST_87ed820dae13f311d79f7f394fc3790aStructure(), ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure.FromStructureDelegate(config));
  } else {
AttrVideo_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure.FromStructure(s.ssSTVideo_InternalConfig, config);
  }
}

public static RC_824809bf8c57cb0db3f5d42bbea4d2cf ToStructure(ssOutSystemsUI.RestRecords.RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf obj) { 
  RC_824809bf8c57cb0db3f5d42bbea4d2cf s = new RC_824809bf8c57cb0db3f5d42bbea4d2cf();
  if(obj != null) {
  s.ssSTVideo_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_87ed820dae13f311d79f7f394fc3790aStructure.ToStructure(obj.AttrVideo_InternalConfig);
  }
  return s;
}

public static Func<RC_824809bf8c57cb0db3f5d42bbea4d2cf, ssOutSystemsUI.RestRecords.RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_824809bf8c57cb0db3f5d42bbea4d2cf s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf FromStructure(RC_824809bf8c57cb0db3f5d42bbea4d2cf s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_824809bf8c57cb0db3f5d42bbea4d2cf(s, config);
}

}


