using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Rating_InternalConfigRecord
public class RESTRC_d5f1a8119489aabce0fbd0fa422c2185 : AbstractRESTStructure<RC_d5f1a8119489aabce0fbd0fa422c2185> {
[JsonProperty("Rating_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_69c22c095aca285f3fb706e10e473ba5Structure AttrRating_InternalConfig;

public RESTRC_d5f1a8119489aabce0fbd0fa422c2185() { }

public RESTRC_d5f1a8119489aabce0fbd0fa422c2185 (RC_d5f1a8119489aabce0fbd0fa422c2185 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRating_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTRating_InternalConfig, new ST_69c22c095aca285f3fb706e10e473ba5Structure(), ssOutSystemsUI.RestRecords.RESTST_69c22c095aca285f3fb706e10e473ba5Structure.FromStructureDelegate(config));
  } else {
AttrRating_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_69c22c095aca285f3fb706e10e473ba5Structure.FromStructure(s.ssSTRating_InternalConfig, config);
  }
}

public static RC_d5f1a8119489aabce0fbd0fa422c2185 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_d5f1a8119489aabce0fbd0fa422c2185 obj) { 
  RC_d5f1a8119489aabce0fbd0fa422c2185 s = new RC_d5f1a8119489aabce0fbd0fa422c2185();
  if(obj != null) {
  s.ssSTRating_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_69c22c095aca285f3fb706e10e473ba5Structure.ToStructure(obj.AttrRating_InternalConfig);
  }
  return s;
}

public static Func<RC_d5f1a8119489aabce0fbd0fa422c2185, ssOutSystemsUI.RestRecords.RESTRC_d5f1a8119489aabce0fbd0fa422c2185> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5f1a8119489aabce0fbd0fa422c2185 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_d5f1a8119489aabce0fbd0fa422c2185 FromStructure(RC_d5f1a8119489aabce0fbd0fa422c2185 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_d5f1a8119489aabce0fbd0fa422c2185(s, config);
}

}


