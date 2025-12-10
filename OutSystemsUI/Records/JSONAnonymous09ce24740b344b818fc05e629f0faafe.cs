using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// OverflowMenu_InternalConfigsRecord
public class JSONRC_b12957472059fa384384c2ddc449560e : AbstractRESTStructure<RC_b12957472059fa384384c2ddc449560e> {
[JsonProperty("OverflowMenu_InternalConfigs")]
[JsonPropertyName("OverflowMenu_InternalConfigs")]
public ssOutSystemsUI.RestRecords.JSONST_6e6632cfd831e4e0f6a401872bea6eccStructure AttrOverflowMenu_InternalConfigs;

public JSONRC_b12957472059fa384384c2ddc449560e() { }

public JSONRC_b12957472059fa384384c2ddc449560e (RC_b12957472059fa384384c2ddc449560e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOverflowMenu_InternalConfigs = ConvertToRestWithoutDefaults(s.ssSTOverflowMenu_InternalConfigs, new ST_6e6632cfd831e4e0f6a401872bea6eccStructure(), ssOutSystemsUI.RestRecords.JSONST_6e6632cfd831e4e0f6a401872bea6eccStructure.FromStructureDelegate(config));
  } else {
AttrOverflowMenu_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_6e6632cfd831e4e0f6a401872bea6eccStructure.FromStructure(s.ssSTOverflowMenu_InternalConfigs, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e, RC_b12957472059fa384384c2ddc449560e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e s) => ToStructure(s, config);
}
public static RC_b12957472059fa384384c2ddc449560e ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e obj, IBehaviorsConfiguration config) { 
  RC_b12957472059fa384384c2ddc449560e s = new RC_b12957472059fa384384c2ddc449560e();
  if(obj != null) {
  s.ssSTOverflowMenu_InternalConfigs = ssOutSystemsUI.RestRecords.JSONST_6e6632cfd831e4e0f6a401872bea6eccStructure.ToStructure(obj.AttrOverflowMenu_InternalConfigs, config);
  }
  return s;
}

public static Func<RC_b12957472059fa384384c2ddc449560e, ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b12957472059fa384384c2ddc449560e s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e FromStructure(RC_b12957472059fa384384c2ddc449560e s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b12957472059fa384384c2ddc449560e(s, config);
}

}


