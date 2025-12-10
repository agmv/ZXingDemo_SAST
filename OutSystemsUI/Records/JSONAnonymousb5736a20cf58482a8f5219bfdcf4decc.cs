using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Sidebar_InternalConfigRecord
public class JSONRC_11d8167e3fa15e3043cb2afdd0778cf2 : AbstractRESTStructure<RC_11d8167e3fa15e3043cb2afdd0778cf2> {
[JsonProperty("Sidebar_InternalConfig")]
[JsonPropertyName("Sidebar_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure AttrSidebar_InternalConfig;

public JSONRC_11d8167e3fa15e3043cb2afdd0778cf2() { }

public JSONRC_11d8167e3fa15e3043cb2afdd0778cf2 (RC_11d8167e3fa15e3043cb2afdd0778cf2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSidebar_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSidebar_InternalConfig, new ST_963c357dbc45b19fade654e21b1521d0Structure(), ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure.FromStructureDelegate(config));
  } else {
AttrSidebar_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure.FromStructure(s.ssSTSidebar_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2, RC_11d8167e3fa15e3043cb2afdd0778cf2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2 s) => ToStructure(s, config);
}
public static RC_11d8167e3fa15e3043cb2afdd0778cf2 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2 obj, IBehaviorsConfiguration config) { 
  RC_11d8167e3fa15e3043cb2afdd0778cf2 s = new RC_11d8167e3fa15e3043cb2afdd0778cf2();
  if(obj != null) {
  s.ssSTSidebar_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_963c357dbc45b19fade654e21b1521d0Structure.ToStructure(obj.AttrSidebar_InternalConfig, config);
  }
  return s;
}

public static Func<RC_11d8167e3fa15e3043cb2afdd0778cf2, ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11d8167e3fa15e3043cb2afdd0778cf2 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2 FromStructure(RC_11d8167e3fa15e3043cb2afdd0778cf2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_11d8167e3fa15e3043cb2afdd0778cf2(s, config);
}

}


