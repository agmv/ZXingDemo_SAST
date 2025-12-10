using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_DrawPolygon_Configs
public class RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure : AbstractRESTStructure<ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure> {
[JsonProperty("Internal_to_provider_tools_configs")]
public ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure AttrInternal_to_provider_tools_configs;

[JsonProperty("UniqueId")]
public string AttrUniqueId;

public RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure() { }

public RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure (ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternal_to_provider_tools_configs = ConvertToRestWithoutDefaults(s.ssInternal_to_provider_tools_configs, new ST_d25262c67f1be04c1df274811b8c7ee4Structure(), ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructureDelegate(config));
AttrUniqueId = ConvertToRestWithoutDefaults(s.ssUniqueId, "");
  } else {
AttrInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.FromStructure(s.ssInternal_to_provider_tools_configs, config);
AttrUniqueId = s.ssUniqueId;
  }
}

public static ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure obj) { 
  ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure s = new ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure();
  if(obj != null) {
  s.ssInternal_to_provider_tools_configs = ssOutSystemsMaps.RestRecords.RESTST_d25262c67f1be04c1df274811b8c7ee4Structure.ToStructure(obj.AttrInternal_to_provider_tools_configs);
  s.ssUniqueId = obj.AttrUniqueId == null ? "" : obj.AttrUniqueId;
  }
  return s;
}

public static Func<ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure, ssOutSystemsMaps.RestRecords.RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure FromStructure(ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_707b1ead9a0d000606d8b9e0cca3c3f9Structure(s, config);
}

}


