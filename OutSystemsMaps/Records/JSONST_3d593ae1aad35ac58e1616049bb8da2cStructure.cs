using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal__Marker_Configs
public class JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure : AbstractRESTStructure<ST_3d593ae1aad35ac58e1616049bb8da2cStructure> {
[JsonProperty("Internal_to_provider_marker_configs")]
[JsonPropertyName("Internal_to_provider_marker_configs")]
public ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure AttrInternal_to_provider_marker_configs;

[JsonProperty("UniqueId")]
[JsonPropertyName("UniqueId")]
public string AttrUniqueId;

public JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure() { }

public JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure (ST_3d593ae1aad35ac58e1616049bb8da2cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_marker_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_marker_configs, new ST_51ef6a78944132edc56aa7bf7c4ea240Structure(), ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.FromStructure(s.ssInternal_to_provider_marker_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure, ST_3d593ae1aad35ac58e1616049bb8da2cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure s) => ToStructure(s, config);
}
public static ST_3d593ae1aad35ac58e1616049bb8da2cStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure obj, IBehaviorsConfiguration config) { 
  ST_3d593ae1aad35ac58e1616049bb8da2cStructure s = new ST_3d593ae1aad35ac58e1616049bb8da2cStructure();
  if(obj != null) {
  s.ssInternal_to_provider_marker_configs = ssOutSystemsMaps.RestRecords.JSONST_51ef6a78944132edc56aa7bf7c4ea240Structure.ToStructure(obj.AttrInternal_to_provider_marker_configs, config);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_3d593ae1aad35ac58e1616049bb8da2cStructure, ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3d593ae1aad35ac58e1616049bb8da2cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure FromStructure(ST_3d593ae1aad35ac58e1616049bb8da2cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_3d593ae1aad35ac58e1616049bb8da2cStructure(s, config);
}

}


