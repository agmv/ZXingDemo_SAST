using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawPolyline_Configs
public class RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure : AbstractRESTStructure<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure> {
[JsonProperty("Internal_to_provider_tools_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure AttrInternal_to_provider_tools_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure() { }

public RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_tools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_tools_configs, new ST_86d2610e9625abf0ecb7241e6d8099fbStructure(), ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.FromStructure(s.ssInternal_to_provider_tools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_5223ca706bfb3de574fb0b39ebba3fb6Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure obj) { 
  ST_5223ca706bfb3de574fb0b39ebba3fb6Structure s = new ST_5223ca706bfb3de574fb0b39ebba3fb6Structure();
  if(obj != null) {
  s.ssInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.RESTST_86d2610e9625abf0ecb7241e6d8099fbStructure.ToStructure(obj.AttrInternal_to_provider_tools_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_5223ca706bfb3de574fb0b39ebba3fb6Structure, ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure FromStructure(ST_5223ca706bfb3de574fb0b39ebba3fb6Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_5223ca706bfb3de574fb0b39ebba3fb6Structure(s, config);
}

}


