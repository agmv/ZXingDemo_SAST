using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Sidebar_InternalConfigRecord
public class RESTRC_11d8167e3fa15e3043cb2afdd0778cf2 : AbstractRESTStructure<RC_11d8167e3fa15e3043cb2afdd0778cf2> {
[JsonProperty("Sidebar_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_963c357dbc45b19fade654e21b1521d0Structure AttrSidebar_InternalConfig;

public RESTRC_11d8167e3fa15e3043cb2afdd0778cf2() { }

public RESTRC_11d8167e3fa15e3043cb2afdd0778cf2 (RC_11d8167e3fa15e3043cb2afdd0778cf2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSidebar_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTSidebar_InternalConfig, new ST_963c357dbc45b19fade654e21b1521d0Structure(), ssOutSystemsUI.RestRecords.RESTST_963c357dbc45b19fade654e21b1521d0Structure.FromStructureDelegate(config));
  } else {
AttrSidebar_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_963c357dbc45b19fade654e21b1521d0Structure.FromStructure(s.ssSTSidebar_InternalConfig, config);
  }
}

public static RC_11d8167e3fa15e3043cb2afdd0778cf2 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_11d8167e3fa15e3043cb2afdd0778cf2 obj) { 
  RC_11d8167e3fa15e3043cb2afdd0778cf2 s = new RC_11d8167e3fa15e3043cb2afdd0778cf2();
  if(obj != null) {
  s.ssSTSidebar_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_963c357dbc45b19fade654e21b1521d0Structure.ToStructure(obj.AttrSidebar_InternalConfig);
  }
  return s;
}

public static Func<RC_11d8167e3fa15e3043cb2afdd0778cf2, ssOutSystemsUI.RestRecords.RESTRC_11d8167e3fa15e3043cb2afdd0778cf2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11d8167e3fa15e3043cb2afdd0778cf2 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_11d8167e3fa15e3043cb2afdd0778cf2 FromStructure(RC_11d8167e3fa15e3043cb2afdd0778cf2 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_11d8167e3fa15e3043cb2afdd0778cf2(s, config);
}

}


