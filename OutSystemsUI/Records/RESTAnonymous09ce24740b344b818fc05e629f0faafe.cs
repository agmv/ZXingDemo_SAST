using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// OverflowMenu_InternalConfigsRecord
public class RESTRC_b12957472059fa384384c2ddc449560e : AbstractRESTStructure<RC_b12957472059fa384384c2ddc449560e> {
[JsonProperty("OverflowMenu_InternalConfigs")]
public ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure AttrOverflowMenu_InternalConfigs;

public RESTRC_b12957472059fa384384c2ddc449560e() { }

public RESTRC_b12957472059fa384384c2ddc449560e (RC_b12957472059fa384384c2ddc449560e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOverflowMenu_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTOverflowMenu_InternalConfigs, new ST_6e6632cfd831e4e0f6a401872bea6eccStructure(), ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure.FromStructureDelegate(config));
  } else {
AttrOverflowMenu_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure.FromStructure(s.ssSTOverflowMenu_InternalConfigs, config);
  }
}

public static RC_b12957472059fa384384c2ddc449560e ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b12957472059fa384384c2ddc449560e obj) { 
  RC_b12957472059fa384384c2ddc449560e s = new RC_b12957472059fa384384c2ddc449560e();
  if(obj != null) {
  s.ssSTOverflowMenu_InternalConfigs = ssOutSystemsUI.RestRecords.RESTST_6e6632cfd831e4e0f6a401872bea6eccStructure.ToStructure(obj.AttrOverflowMenu_InternalConfigs);
  }
  return s;
}

public static Func<RC_b12957472059fa384384c2ddc449560e, ssOutSystemsUI.RestRecords.RESTRC_b12957472059fa384384c2ddc449560e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b12957472059fa384384c2ddc449560e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b12957472059fa384384c2ddc449560e FromStructure(RC_b12957472059fa384384c2ddc449560e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b12957472059fa384384c2ddc449560e(s, config);
}

}


