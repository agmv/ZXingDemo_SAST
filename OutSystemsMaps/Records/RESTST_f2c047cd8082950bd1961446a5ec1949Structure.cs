using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_HeatmapLayer_Configs
public class RESTST_f2c047cd8082950bd1961446a5ec1949Structure : AbstractRESTStructure<ST_f2c047cd8082950bd1961446a5ec1949Structure> {
[JsonProperty("Internal_to_provider_heatmapLayer_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure AttrInternal_to_provider_heatmapLayer_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_f2c047cd8082950bd1961446a5ec1949Structure() { }

public RESTST_f2c047cd8082950bd1961446a5ec1949Structure (ST_f2c047cd8082950bd1961446a5ec1949Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_heatmapLayer_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_heatmapLayer_configs, new ST_ca5fecbdf222b72d179909c1f030119cStructure(), ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_heatmapLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.FromStructure(s.ssInternal_to_provider_heatmapLayer_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_f2c047cd8082950bd1961446a5ec1949Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure obj) { 
  ST_f2c047cd8082950bd1961446a5ec1949Structure s = new ST_f2c047cd8082950bd1961446a5ec1949Structure();
  if(obj != null) {
  s.ssInternal_to_provider_heatmapLayer_configs = ssOutSystemsMaps.RestRecords.RESTST_ca5fecbdf222b72d179909c1f030119cStructure.ToStructure(obj.AttrInternal_to_provider_heatmapLayer_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_f2c047cd8082950bd1961446a5ec1949Structure, ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f2c047cd8082950bd1961446a5ec1949Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure FromStructure(ST_f2c047cd8082950bd1961446a5ec1949Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_f2c047cd8082950bd1961446a5ec1949Structure(s, config);
}

}


