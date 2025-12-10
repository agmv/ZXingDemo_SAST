using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Tooltip_InternalConfigRecord
public class JSONRC_c506c74ca8aaa04b11f3b2041bb6669f : AbstractRESTStructure<RC_c506c74ca8aaa04b11f3b2041bb6669f> {
[JsonProperty("Tooltip_InternalConfig")]
[JsonPropertyName("Tooltip_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_9cac82fc47e32e1503b2dbc00140aa98Structure AttrTooltip_InternalConfig;

public JSONRC_c506c74ca8aaa04b11f3b2041bb6669f() { }

public JSONRC_c506c74ca8aaa04b11f3b2041bb6669f (RC_c506c74ca8aaa04b11f3b2041bb6669f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTooltip_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTTooltip_InternalConfig, new ST_9cac82fc47e32e1503b2dbc00140aa98Structure(), ssOutSystemsUI.RestRecords.JSONST_9cac82fc47e32e1503b2dbc00140aa98Structure.FromStructureDelegate(config));
  } else {
AttrTooltip_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_9cac82fc47e32e1503b2dbc00140aa98Structure.FromStructure(s.ssSTTooltip_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f, RC_c506c74ca8aaa04b11f3b2041bb6669f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f s) => ToStructure(s, config);
}
public static RC_c506c74ca8aaa04b11f3b2041bb6669f ToStructure(ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f obj, IBehaviorsConfiguration config) { 
  RC_c506c74ca8aaa04b11f3b2041bb6669f s = new RC_c506c74ca8aaa04b11f3b2041bb6669f();
  if(obj != null) {
  s.ssSTTooltip_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_9cac82fc47e32e1503b2dbc00140aa98Structure.ToStructure(obj.AttrTooltip_InternalConfig, config);
  }
  return s;
}

public static Func<RC_c506c74ca8aaa04b11f3b2041bb6669f, ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c506c74ca8aaa04b11f3b2041bb6669f s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f FromStructure(RC_c506c74ca8aaa04b11f3b2041bb6669f s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_c506c74ca8aaa04b11f3b2041bb6669f(s, config);
}

}


