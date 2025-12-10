using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ListNavigationRecord
public class RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427 : AbstractRESTStructure<RC_5b37cd2bc5a279c3cc9b8640efcc6427> {
[JsonProperty("ListNavigation")]
public ssOutSystemsUI.RestRecords.RESTST_28a47f2e64dd49f0d3d29e55f70be394Structure AttrListNavigation;

public RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427() { }

public RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427 (RC_5b37cd2bc5a279c3cc9b8640efcc6427 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrListNavigation = ConvertToRestWithoutDefaults(s.ssSTListNavigation, new ST_28a47f2e64dd49f0d3d29e55f70be394Structure(), ssOutSystemsUI.RestRecords.RESTST_28a47f2e64dd49f0d3d29e55f70be394Structure.FromStructureDelegate(config));
  } else {
AttrListNavigation = ssOutSystemsUI.RestRecords.RESTST_28a47f2e64dd49f0d3d29e55f70be394Structure.FromStructure(s.ssSTListNavigation, config);
  }
}

public static RC_5b37cd2bc5a279c3cc9b8640efcc6427 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427 obj) { 
  RC_5b37cd2bc5a279c3cc9b8640efcc6427 s = new RC_5b37cd2bc5a279c3cc9b8640efcc6427();
  if(obj != null) {
  s.ssSTListNavigation = ssOutSystemsUI.RestRecords.RESTST_28a47f2e64dd49f0d3d29e55f70be394Structure.ToStructure(obj.AttrListNavigation);
  }
  return s;
}

public static Func<RC_5b37cd2bc5a279c3cc9b8640efcc6427, ssOutSystemsUI.RestRecords.RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b37cd2bc5a279c3cc9b8640efcc6427 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427 FromStructure(RC_5b37cd2bc5a279c3cc9b8640efcc6427 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_5b37cd2bc5a279c3cc9b8640efcc6427(s, config);
}

}


