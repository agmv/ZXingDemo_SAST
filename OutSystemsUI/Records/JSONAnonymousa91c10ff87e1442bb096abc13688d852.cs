using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Gallery_InternalConfigRecord
public class JSONRC_dd0070f225e242673216fed1481d0a20 : AbstractRESTStructure<RC_dd0070f225e242673216fed1481d0a20> {
[JsonProperty("Gallery_InternalConfig")]
[JsonPropertyName("Gallery_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure AttrGallery_InternalConfig;

public JSONRC_dd0070f225e242673216fed1481d0a20() { }

public JSONRC_dd0070f225e242673216fed1481d0a20 (RC_dd0070f225e242673216fed1481d0a20 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGallery_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTGallery_InternalConfig, new ST_546a3060996e070a522a708cd2d94c23Structure(), ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure.FromStructureDelegate(config));
  } else {
AttrGallery_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure.FromStructure(s.ssSTGallery_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20, RC_dd0070f225e242673216fed1481d0a20> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20 s) => ToStructure(s, config);
}
public static RC_dd0070f225e242673216fed1481d0a20 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20 obj, IBehaviorsConfiguration config) { 
  RC_dd0070f225e242673216fed1481d0a20 s = new RC_dd0070f225e242673216fed1481d0a20();
  if(obj != null) {
  s.ssSTGallery_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_546a3060996e070a522a708cd2d94c23Structure.ToStructure(obj.AttrGallery_InternalConfig, config);
  }
  return s;
}

public static Func<RC_dd0070f225e242673216fed1481d0a20, ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dd0070f225e242673216fed1481d0a20 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20 FromStructure(RC_dd0070f225e242673216fed1481d0a20 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_dd0070f225e242673216fed1481d0a20(s, config);
}

}


