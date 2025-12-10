using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressBarOptionalConfigsRecord
public class RESTRC_3554b1e2806a5b827c457cdecc492d4a : AbstractRESTStructure<RC_3554b1e2806a5b827c457cdecc492d4a> {
[JsonProperty("ProgressBarOptionalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure AttrProgressBarOptionalConfigs;

public RESTRC_3554b1e2806a5b827c457cdecc492d4a() { }

public RESTRC_3554b1e2806a5b827c457cdecc492d4a (RC_3554b1e2806a5b827c457cdecc492d4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressBarOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTProgressBarOptionalConfigs, new ST_8391f9d0c6b78f74493c47987669deecStructure(), ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure.FromStructureDelegate(config));
  } else {
AttrProgressBarOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure.FromStructure(s.ssSTProgressBarOptionalConfigs, config);
  }
}

public static RC_3554b1e2806a5b827c457cdecc492d4a ToStructure(ssOutSystemsUI.RestRecords.RESTRC_3554b1e2806a5b827c457cdecc492d4a obj) { 
  RC_3554b1e2806a5b827c457cdecc492d4a s = new RC_3554b1e2806a5b827c457cdecc492d4a();
  if(obj != null) {
  s.ssSTProgressBarOptionalConfigs = ssOutSystemsUI.RestRecords.RESTST_8391f9d0c6b78f74493c47987669deecStructure.ToStructure(obj.AttrProgressBarOptionalConfigs);
  }
  return s;
}

public static Func<RC_3554b1e2806a5b827c457cdecc492d4a, ssOutSystemsUI.RestRecords.RESTRC_3554b1e2806a5b827c457cdecc492d4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3554b1e2806a5b827c457cdecc492d4a s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_3554b1e2806a5b827c457cdecc492d4a FromStructure(RC_3554b1e2806a5b827c457cdecc492d4a s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_3554b1e2806a5b827c457cdecc492d4a(s, config);
}

}


