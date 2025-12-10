using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ListNavigationRecord
public class JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427 : AbstractRESTStructure<RC_5b37cd2bc5a279c3cc9b8640efcc6427> {
[JsonProperty("ListNavigation")]
[JsonPropertyName("ListNavigation")]
public ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure AttrListNavigation;

public JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427() { }

public JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427 (RC_5b37cd2bc5a279c3cc9b8640efcc6427 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrListNavigation = ConvertToRestWithoutDefaults(s.ssSTListNavigation, new ST_28a47f2e64dd49f0d3d29e55f70be394Structure(), ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure.FromStructureDelegate(config));
  } else {
AttrListNavigation = ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure.FromStructure(s.ssSTListNavigation, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427, RC_5b37cd2bc5a279c3cc9b8640efcc6427> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427 s) => ToStructure(s, config);
}
public static RC_5b37cd2bc5a279c3cc9b8640efcc6427 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427 obj, IBehaviorsConfiguration config) { 
  RC_5b37cd2bc5a279c3cc9b8640efcc6427 s = new RC_5b37cd2bc5a279c3cc9b8640efcc6427();
  if(obj != null) {
  s.ssSTListNavigation = ssOutSystemsUI.RestRecords.JSONST_28a47f2e64dd49f0d3d29e55f70be394Structure.ToStructure(obj.AttrListNavigation, config);
  }
  return s;
}

public static Func<RC_5b37cd2bc5a279c3cc9b8640efcc6427, ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b37cd2bc5a279c3cc9b8640efcc6427 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427 FromStructure(RC_5b37cd2bc5a279c3cc9b8640efcc6427 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_5b37cd2bc5a279c3cc9b8640efcc6427(s, config);
}

}


