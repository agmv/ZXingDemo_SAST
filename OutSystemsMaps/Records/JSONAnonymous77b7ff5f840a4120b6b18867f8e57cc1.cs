using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalHeatmapLayerConfigsRecord
public class JSONRC_59608f6fdf263bd270d8edd0a1db0f3c : AbstractRESTStructure<RC_59608f6fdf263bd270d8edd0a1db0f3c> {
[JsonProperty("OptionalHeatmapLayerConfigs")]
[JsonPropertyName("OptionalHeatmapLayerConfigs")]
public ssOutSystemsMaps.RestRecords.JSONST_c84e2ea85c3f77e3b083b2b79806c17aStructure AttrOptionalHeatmapLayerConfigs;

public JSONRC_59608f6fdf263bd270d8edd0a1db0f3c() { }

public JSONRC_59608f6fdf263bd270d8edd0a1db0f3c (RC_59608f6fdf263bd270d8edd0a1db0f3c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalHeatmapLayerConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalHeatmapLayerConfigs, new ST_c84e2ea85c3f77e3b083b2b79806c17aStructure(), ssOutSystemsMaps.RestRecords.JSONST_c84e2ea85c3f77e3b083b2b79806c17aStructure.FromStructureDelegate(config));
  } else {
AttrOptionalHeatmapLayerConfigs = ssOutSystemsMaps.RestRecords.JSONST_c84e2ea85c3f77e3b083b2b79806c17aStructure.FromStructure(s.ssSTOptionalHeatmapLayerConfigs, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c, RC_59608f6fdf263bd270d8edd0a1db0f3c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c s) => ToStructure(s, config);
}
public static RC_59608f6fdf263bd270d8edd0a1db0f3c ToStructure(ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c obj, IBehaviorsConfiguration config) { 
  RC_59608f6fdf263bd270d8edd0a1db0f3c s = new RC_59608f6fdf263bd270d8edd0a1db0f3c();
  if(obj != null) {
  s.ssSTOptionalHeatmapLayerConfigs = ssOutSystemsMaps.RestRecords.JSONST_c84e2ea85c3f77e3b083b2b79806c17aStructure.ToStructure(obj.AttrOptionalHeatmapLayerConfigs, config);
  }
  return s;
}

public static Func<RC_59608f6fdf263bd270d8edd0a1db0f3c, ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_59608f6fdf263bd270d8edd0a1db0f3c s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c FromStructure(RC_59608f6fdf263bd270d8edd0a1db0f3c s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONRC_59608f6fdf263bd270d8edd0a1db0f3c(s, config);
}

}


